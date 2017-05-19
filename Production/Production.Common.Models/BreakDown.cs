using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Common.Models
{
    public class BreakDown
    {
        int Id { get; set; }
        int LineId { get; set; }
        DateTime Start { get; set; }
        DateTime End { get; set; }
        Boolean State { get; set; }
    }
}
