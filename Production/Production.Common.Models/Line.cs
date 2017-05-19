using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Common.Models
{
    public class Line
    {
        int Id { get; set; }
        DateTime Start { get; set; }
        DateTime End { get; set; }
        Boolean Active { get; set; }
        String Operation { get; set; }
        Boolean Done { get; set; }
        int Qunatity { get; set; }
        Resources StageResoureces { get; set; }
        Inventory StageInventory { get; set; }
        Location StageLocation { get; set; }
        Other Other { get; set; }

    }
}
