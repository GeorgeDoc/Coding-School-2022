using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class Employee : Person {
        public DateTime HireDateStart { get; set; } //= DateTime.Now; 
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        //public bool Current { get; set; } = true;

        public List<Transaction> Transactions { get; set; }
        public Employee() {

        }
    }
}
