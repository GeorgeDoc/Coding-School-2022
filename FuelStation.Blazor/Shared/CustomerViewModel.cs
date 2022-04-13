using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared {
    public class CustomerViewModel {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        public string CardNumber{ get; set; }
    }

    public class CustomerEditViewModel { // could use the same as above now, but requirements might change, so good to have this called
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
}
