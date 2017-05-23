﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class Other
    {
        [Key]
        int Id { get; set; }
        String Heat { get; set; }
        String Power { get; set; }
    }
}
