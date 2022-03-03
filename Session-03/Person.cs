using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Person
    {
        public Guid ID { get; }
        public int Age { get; set; }
        public string Name;
        public string getName() { return Name; }
        public void setName(string name)
        {
            Name = name;
        }

        public Person()
        {
            ID = Guid.NewGuid();
        }

        //public string GetThisID() { return ID.ToString(); }
    }
}
