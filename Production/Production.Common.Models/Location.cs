using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set;}
    }
}
