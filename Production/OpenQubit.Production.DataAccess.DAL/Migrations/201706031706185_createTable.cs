namespace OpenQubit.Production.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BreakDown",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StageId = c.Int(nullable: false),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InventoryItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        ItemType_Id = c.Int(),
                        ProductionInventory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemType", t => t.ItemType_Id)
                .ForeignKey("dbo.ProductionInventory", t => t.ProductionInventory_Id)
                .Index(t => t.ItemType_Id)
                .Index(t => t.ProductionInventory_Id);
            
            CreateTable(
                "dbo.ItemType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InventoryItemID = c.Int(nullable: false),
                        Input = c.String(),
                        OutPut = c.String(),
                        Waste = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Other",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Heat = c.String(),
                        Power = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductionInventory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StageTemplate_Id = c.Int(),
                        Stage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StageTemplate", t => t.StageTemplate_Id)
                .ForeignKey("dbo.Stage", t => t.Stage_Id)
                .Index(t => t.StageTemplate_Id)
                .Index(t => t.Stage_Id);
            
            CreateTable(
                "dbo.ProductionLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ProductionLineTemplateId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductionLineTemplate", t => t.ProductionLineTemplateId_Id)
                .Index(t => t.ProductionLineTemplateId_Id);
            
            CreateTable(
                "dbo.ProductionLineTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstimatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StageTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OutPutStageId = c.Int(nullable: false),
                        EstimatedTime = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Operation = c.String(),
                        Done = c.Boolean(nullable: false),
                        StageTemplate_Id = c.Int(),
                        Other_ID = c.Int(),
                        StageLocation_ID = c.Int(),
                        ProductionLineTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StageTemplate", t => t.StageTemplate_Id)
                .ForeignKey("dbo.Other", t => t.Other_ID)
                .ForeignKey("dbo.Location", t => t.StageLocation_ID)
                .ForeignKey("dbo.ProductionLineTemplate", t => t.ProductionLineTemplate_Id)
                .Index(t => t.StageTemplate_Id)
                .Index(t => t.Other_ID)
                .Index(t => t.StageLocation_ID)
                .Index(t => t.ProductionLineTemplate_Id);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResourceName = c.String(),
                        Description = c.String(),
                        Type_ResourceTypeId = c.Int(),
                        StageTemplate_Id = c.Int(),
                        Stage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResourceType", t => t.Type_ResourceTypeId)
                .ForeignKey("dbo.StageTemplate", t => t.StageTemplate_Id)
                .ForeignKey("dbo.Stage", t => t.Stage_Id)
                .Index(t => t.Type_ResourceTypeId)
                .Index(t => t.StageTemplate_Id)
                .Index(t => t.Stage_Id);
            
            CreateTable(
                "dbo.ResourceType",
                c => new
                    {
                        ResourceTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ResourceTypeId);
            
            CreateTable(
                "dbo.Stage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OutPutStageId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Operation = c.String(),
                        Done = c.Boolean(nullable: false),
                        Stage_Id = c.Int(),
                        Other_ID = c.Int(),
                        StageLocation_ID = c.Int(),
                        StageTemplateID_Id = c.Int(),
                        ProductionLine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stage", t => t.Stage_Id)
                .ForeignKey("dbo.Other", t => t.Other_ID)
                .ForeignKey("dbo.Location", t => t.StageLocation_ID)
                .ForeignKey("dbo.StageTemplate", t => t.StageTemplateID_Id)
                .ForeignKey("dbo.ProductionLine", t => t.ProductionLine_Id)
                .Index(t => t.Stage_Id)
                .Index(t => t.Other_ID)
                .Index(t => t.StageLocation_ID)
                .Index(t => t.StageTemplateID_Id)
                .Index(t => t.ProductionLine_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stage", "ProductionLine_Id", "dbo.ProductionLine");
            DropForeignKey("dbo.Stage", "StageTemplateID_Id", "dbo.StageTemplate");
            DropForeignKey("dbo.Resources", "Stage_Id", "dbo.Stage");
            DropForeignKey("dbo.Stage", "StageLocation_ID", "dbo.Location");
            DropForeignKey("dbo.ProductionInventory", "Stage_Id", "dbo.Stage");
            DropForeignKey("dbo.Stage", "Other_ID", "dbo.Other");
            DropForeignKey("dbo.Stage", "Stage_Id", "dbo.Stage");
            DropForeignKey("dbo.ProductionLine", "ProductionLineTemplateId_Id", "dbo.ProductionLineTemplate");
            DropForeignKey("dbo.StageTemplate", "ProductionLineTemplate_Id", "dbo.ProductionLineTemplate");
            DropForeignKey("dbo.Resources", "StageTemplate_Id", "dbo.StageTemplate");
            DropForeignKey("dbo.Resources", "Type_ResourceTypeId", "dbo.ResourceType");
            DropForeignKey("dbo.StageTemplate", "StageLocation_ID", "dbo.Location");
            DropForeignKey("dbo.ProductionInventory", "StageTemplate_Id", "dbo.StageTemplate");
            DropForeignKey("dbo.StageTemplate", "Other_ID", "dbo.Other");
            DropForeignKey("dbo.StageTemplate", "StageTemplate_Id", "dbo.StageTemplate");
            DropForeignKey("dbo.InventoryItem", "ProductionInventory_Id", "dbo.ProductionInventory");
            DropForeignKey("dbo.InventoryItem", "ItemType_Id", "dbo.ItemType");
            DropIndex("dbo.Stage", new[] { "ProductionLine_Id" });
            DropIndex("dbo.Stage", new[] { "StageTemplateID_Id" });
            DropIndex("dbo.Stage", new[] { "StageLocation_ID" });
            DropIndex("dbo.Stage", new[] { "Other_ID" });
            DropIndex("dbo.Stage", new[] { "Stage_Id" });
            DropIndex("dbo.Resources", new[] { "Stage_Id" });
            DropIndex("dbo.Resources", new[] { "StageTemplate_Id" });
            DropIndex("dbo.Resources", new[] { "Type_ResourceTypeId" });
            DropIndex("dbo.StageTemplate", new[] { "ProductionLineTemplate_Id" });
            DropIndex("dbo.StageTemplate", new[] { "StageLocation_ID" });
            DropIndex("dbo.StageTemplate", new[] { "Other_ID" });
            DropIndex("dbo.StageTemplate", new[] { "StageTemplate_Id" });
            DropIndex("dbo.ProductionLine", new[] { "ProductionLineTemplateId_Id" });
            DropIndex("dbo.ProductionInventory", new[] { "Stage_Id" });
            DropIndex("dbo.ProductionInventory", new[] { "StageTemplate_Id" });
            DropIndex("dbo.InventoryItem", new[] { "ProductionInventory_Id" });
            DropIndex("dbo.InventoryItem", new[] { "ItemType_Id" });
            DropTable("dbo.Stage");
            DropTable("dbo.ResourceType");
            DropTable("dbo.Resources");
            DropTable("dbo.StageTemplate");
            DropTable("dbo.ProductionLineTemplate");
            DropTable("dbo.ProductionLine");
            DropTable("dbo.ProductionInventory");
            DropTable("dbo.Other");
            DropTable("dbo.Location");
            DropTable("dbo.ItemType");
            DropTable("dbo.InventoryItem");
            DropTable("dbo.BreakDown");
        }
    }
}
