using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    
    public enum EmployeeType {
        Manager = 0,
        Staff = 1,
        Cashier = 2 
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

    public enum MonthEnum {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
