using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    [Serializable]
    public class Grade
    {
        public Guid ID { get; }
        public Guid StudentID { get; }
        public Guid CourseID { get; }
        public int value { get; set; } //the Grade asked

        public Grade()
        {
            ID = Guid.NewGuid();
            value = 0;
        }
    }
}
