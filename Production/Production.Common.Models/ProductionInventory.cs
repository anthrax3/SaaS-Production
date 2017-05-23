using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class ProductionInventory
    {
        [Key]
        int Id { get; set; }
        List<InventoryItem> ItemLIDList { get; set; }
    }
}
