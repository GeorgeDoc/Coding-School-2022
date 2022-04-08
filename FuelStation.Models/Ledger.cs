using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public  class Ledger {
        public byte Month { get; set; }
        public byte Year { get; set; }
        public decimal Income { get; set; } 
        public decimal Expences { get; set; }
        public decimal Total { get; set; }
        public Ledger() {

        }
    }
}
