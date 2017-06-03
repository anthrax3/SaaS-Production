using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class Stage
    {
        [Key]
        public int Id { get; set; }
        public List<ProductionInventory> StageInventory { get; set; }
        public List<Resources> StageResoureces { get; set; }
        public List<Stage> InputStageID { get; set; }
        public int OutPutStageId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean Active { get; set; }
        public String Operation { get; set; }
        public Boolean Done { get; set; }
        public Location StageLocation { get; set; }
        public Other Other { get; set; }
        public StageTemplate StageTemplateID { get; set; }
    }
}
