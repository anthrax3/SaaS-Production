using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class ProductionLine
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Stage> Stages { get; set; }
        public ProductionLineTemplate ProductionLineTemplateId { get; set; }
    }
}
