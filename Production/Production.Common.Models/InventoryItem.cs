using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class InventoryItem
    {
        [Key]
        int Id { get; set; }
        String Name { get; set; }
        ItemType ItemType { get; set; }
        int Quantity { get; set; }
    }
}
