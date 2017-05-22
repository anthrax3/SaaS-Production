using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OpenQubit.Production.Common.Models
{
    public class ProductionInventory
    {
        int Id { get; set; }
        List<InventoryItem> ItemLIDList { get; set; }
    }
}
