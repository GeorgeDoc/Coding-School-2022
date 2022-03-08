using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse : AbstractMicroserviceClass
    {
        //public Guid ResponseID { get; }
        public Guid RequestID { get; } //must be the same as RequestID of ActionRequest




        public ActionResponse()
        {
            //ResponseID = Guid.NewGuid();
            //RequestID = ActionRequest.RequestID;
        }
    }
}
