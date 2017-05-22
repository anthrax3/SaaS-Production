using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Production.Common.Models
{
    public class Resources
    {
        int Id { get; set; }
        String ResourceName { get; set; }
        String Description { get; set; }
        ResourceType Type { get; set; }
    }
}
