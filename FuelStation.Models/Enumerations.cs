using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    
    public enum EmployeeType {
        Manager,
        Staff,
        Cashier
    }

    public enum ItemType {
        Fuel,
        Product,
        Service
    }

    public enum PaymentMethod {
        Credit_Card,
        Cash
    }
}
