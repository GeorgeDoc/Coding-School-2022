using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    internal class Addition : Operation
    {
        public string Add(string input)
        {
            var a = new Addition();
            Operands = a.ConvertToDec(input);
            return (Operands[0] + Operands[1]).ToString();
        }


        public Addition()
        {

        }
    }
}
