using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University2._0.Classes
{
    public class University
    {
        public University()
        {
            Students = new List<Student>();
        }
        public List<Student> Students { get; set; }
    }
}
