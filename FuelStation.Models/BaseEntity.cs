using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class BaseEntity {
        //public int ID { get; set; }
        public Guid Id { get; set; }
        public BaseEntity() {
                
        }
    }
}
