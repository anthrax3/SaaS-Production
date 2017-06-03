using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class ItemType
    {
        [Key]
        public int Id { get; set; }
        public int InventoryItemID { get; set; }
        public String Input { get; set; }
        public String OutPut { get; set; }
        public int Waste { get; set; }
    }
}
