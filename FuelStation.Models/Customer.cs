using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class Customer : Person{
        public string _cardNumber;
        private const string START = "A";   // Making a seperate file for a letter seems a waste. Although now just 1 char, later might be more, so string

        public string CardNumber {          // since it always starts with A, it doesn't make sence to ask a
            get { return _cardNumber; }     // user to type it, we add it instead without his interference
            set { _cardNumber = START + value; }
        } 
        
        public List<Transaction> Transactions { get; set; }

        public Customer() {

        }
    }
}
