using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class StageTemplate
    {
        [Key]
        int Id { get; set; }
        List<ProductionInventory> StageInventory { get; set; }
        List<Resources> StageResoureces { get; set; }
        List<StageTemplate> InputStageID { get; set; }
        int OutPutStageId { get; set; }
        DateTime EstimatedTime { get; set; }
        Boolean Active { get; set; }
        String Operation { get; set; }
        Boolean Done { get; set; }
        Location StageLocation { get; set; }
        Other Other { get; set; }
    }
}
