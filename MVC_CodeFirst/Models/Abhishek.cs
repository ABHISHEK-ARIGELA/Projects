﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Models
{
    public class Abhishek
    {
        [Key]
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string PanNumber { get; set; }
        public string City { get; set; }
    }
}
