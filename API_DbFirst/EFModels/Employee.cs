using System;
using System.Collections.Generic;

#nullable disable

namespace API_DbFirst.EFModels
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string EmailId { get; set; }
    }
}
