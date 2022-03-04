﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test_api.Models
{
    public class InspectionType
    {
        public int Id { get; set; }
        
        [StringLength(20)]
        public string InspectionName { get; set; }
    }
}
