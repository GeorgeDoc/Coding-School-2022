using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    [Serializable]
    public class Course
    {
        public Guid ID { get; }
        public string Code { get; set; }
        public string Subject { get; set; }

        public Course()
        {
            ID = Guid.NewGuid();
            Code = String.Empty;
            Subject = String.Empty;
        }
    }
}
