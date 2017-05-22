using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class Stage
    {
        int Id { get; set; }
        List<ProductionInventory> StageInventory { get; set; }
        List<Resources> StageResoureces { get; set; }
        List<Stage> StageID { get; set; }
        DateTime Start { get; set; }
        // output
        //primaryInput
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        DateTime EstimatedTime { get; set; }
        Boolean Active { get; set; }
        String Operation { get; set; }
        Boolean Done { get; set; }
        Location StageLocation { get; set; }
        Other Other { get; set; }
        int StageTemplateID { get; set; }
    }
}
