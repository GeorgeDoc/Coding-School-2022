using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University2._0.Classes
{
    public class Student : Person
    {
        public int Age { get; set; }
        public string RegNumber { get; set; }
        public string StudentTypeID { get; set; }

        public GenderEnum? Gender { get; set; } // nulllable to not return default value 0 when null

        public string FullName
        {
            get
            {
                //return Name + " " + Surname;
                return $"{Name} {Surname}";
                //return String.Format("{0} {1}", Name, Surname);
            }
        }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
