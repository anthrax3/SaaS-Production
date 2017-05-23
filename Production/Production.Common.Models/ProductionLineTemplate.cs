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
        int Id { get; set; }
        DateTime EstimatedTime { get; set; }
        List<StageTemplate> StageTemplateId { get; set; }
    }
}
