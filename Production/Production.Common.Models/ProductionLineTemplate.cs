using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class ProductionLineTemplate
    {
        [Key]
        public int Id { get; set; }
        public DateTime EstimatedTime { get; set; }
        public List<StageTemplate> StageTemplateId { get; set; }
    }
}
