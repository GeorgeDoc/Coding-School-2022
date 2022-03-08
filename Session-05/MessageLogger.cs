using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger : Message
    {
        public Message[] Messages { get; set; } 


        public void ReadAll()
        {

        }

        public void ClearAll()
        {

        }

        public void Write(Message message)
        {
            Console.WriteLine(message._Message.ToString() + "\n");
        }


        public MessageLogger()
        {
                
        }
    }
}
