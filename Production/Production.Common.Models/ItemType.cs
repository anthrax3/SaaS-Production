using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class ItemType
    {
        int ItemId { get; set; }
        String Input { get; set; }
        String OutPut { get; set; }
        int Waste { get; set; }
    }
}
