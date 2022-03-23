using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    public class Employee {
        private const string EMPLOYEE_STORAGE = "employeeStorage.json";
        public Guid ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double SalaryPerMonth { get; set; }
        public enum EmployeeType { Manager, Cashier, Barista, Waiter }

        public Employee() {

        }
    }
}
