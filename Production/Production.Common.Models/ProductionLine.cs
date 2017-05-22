using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class ProductionLine
    {
        int Id { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        List<Stage> Stages { get; set; }
    }
}
