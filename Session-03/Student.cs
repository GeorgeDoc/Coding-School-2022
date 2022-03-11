using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    [Serializable]
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Course[] courses { get; set; }

        public Student()
        {
            RegistrationNumber = 0;
        }

        public bool Attend(Course c, DateTime dt)
        {
            return true;
        }
        public bool WriteExam(Course c, DateTime dt)
        {
            return false;
        }
    }
}
