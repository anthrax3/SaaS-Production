using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Common.Models
{
    public class Inventory
    {
        List<Item> ItemList { get; set; }
        int Qty { get; set; }
        int Usage { get; set; }
        int Waste { get; set; }
    }
}
