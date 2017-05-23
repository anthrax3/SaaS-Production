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
        int Id { get; set; }
        String ResourceName { get; set; }
        String Description { get; set; }
        ResourceType Type { get; set; }
    }
}
