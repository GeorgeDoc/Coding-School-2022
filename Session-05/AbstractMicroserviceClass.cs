using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal abstract class AbstractMicroserviceClass
    {

        public Guid RequestID { get; }

        public AbstractMicroserviceClass()
        {
            RequestID = Guid.NewGuid();
        }
    }
}
