using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_DbFirst.EFModels
{
    public partial class Abhishek
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string PanNumber { get; set; }
        public string City { get; set; }
    }
}
