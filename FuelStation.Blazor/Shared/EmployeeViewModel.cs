using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared {
    public class EmployeeViewModel {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        public DateTime HireDateStart { get; set; } 
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeEditViewModel {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
