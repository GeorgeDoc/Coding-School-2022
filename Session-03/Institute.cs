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
        public string Name;
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name; }

        public Institute()
        {
            ID = Guid.NewGuid();
        }
    }
}
