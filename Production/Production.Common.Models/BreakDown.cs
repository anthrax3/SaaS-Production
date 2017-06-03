using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class BreakDown
    {
        [Key]
        public int Id { get; set; }
        public int StageId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Boolean State { get; set; }
    }
}
