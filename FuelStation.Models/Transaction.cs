using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class Transaction : BaseEntity {
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }    
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public Transaction() {

        }
    }
}
