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
        protected string _name;
        public string getName() { return _name; }
        public void setName(string name)
        {
            _name = name;
        }

        public Person()
        {
            ID = Guid.NewGuid();
            Age = 0;
            _name = String.Empty;
        }

        //public string GetThisID() { return ID.ToString(); }
    }
}
