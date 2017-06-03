using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class Resources
    {
        [Key]
        public int Id { get; set; }
        public String ResourceName { get; set; }
        public String Description { get; set; }
        public ResourceType Type { get; set; }
    }
}
