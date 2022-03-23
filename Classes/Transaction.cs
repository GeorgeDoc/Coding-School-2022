using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    public class Transaction {
        public Guid ID { get; }
        public Guid CustomerID { get; }
        public Guid EmployeeID { get; }
        public double TotalPrice { get; set; }

        public List<TransactionLine> Lines { get; set; }
        public enum PaymentMethod { Cash, CreditCard }
        public double TransCost { get; set; }
        public DateTime Date { get; }


        //public  
        public Transaction() {
            ID = Guid.NewGuid();
        }
    }
}
