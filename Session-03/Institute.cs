using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Institute
    {
        public Guid ID { get; }

        public int YearsInService { get; set; }
        private string _name { get; set; }
        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }

        public Institute()
        {
            ID = Guid.NewGuid();
        }
    }
}
