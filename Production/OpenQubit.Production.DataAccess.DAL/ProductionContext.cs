using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OpenQubit.Production.Common.Models;

namespace OpenQubit.Production.DataAccess.DAL
{
   public class ProductionContext : DbContext
    {
        public ProductionContext() : base("ProductionDB") // get database details
        {

        }
        public DbSet<BreakDown> BreakDown { get; set; }
        public DbSet<InventoryItem> InventoryItem { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<Location> Location { get; set; } 
        public DbSet<Other> Other { get; set; }
        public DbSet<ProductionInventory> ProductionInventory { get; set; }
        public DbSet<ProductionLine> ProductionLine { get; set; }
        public DbSet<ProductionLineTemplate> ProductionLineTemplate { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<ResourceType> ResourceType { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<StageTemplate> StageTemplate { get; set; } 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
