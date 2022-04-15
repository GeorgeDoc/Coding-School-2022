using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University2._0
{
    public class Person
    {
        public enum GenderEnum { Male, Female, OtherGender }

        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
