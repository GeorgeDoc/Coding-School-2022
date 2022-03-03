using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid ID { get; }
        public Guid StudentID { get; }
        public Guid CourseID { get; }
        public int number { get; set; } //the Grade asked

        public Grade()
        {
            ID = Guid.NewGuid();
        }
    }
}
