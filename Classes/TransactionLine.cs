using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    public class TransactionLine {

        public Guid ID { get; }
        public Guid ProductID { get; }
        public double Price { get; set; }
        public bool Discount { get; set; }
        public double TotalPrice { get; set; }
        public double LineCost { get; set; }

        public Guid TransID { get; set; } //foreign key to transaction
        public Transaction Transaction { get; set; } //to connect with foreigh key

        public TransactionLine() {
            ID = Guid.NewGuid();
        }
        public TransactionLine(Product product, int Quantity) {
            ID = Guid.NewGuid();
        }
    }
}
