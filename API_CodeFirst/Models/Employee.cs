using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
       // public string PanNumber { get; set; }
        public string City { get; set; }
        public string EmailId { get; set; }

    }
}
