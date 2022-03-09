using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    internal class Multiplication : Operation
    {
        public string Multiply(string input)
        {
            var a = new Multiplication();
            Operands = a.ConvertToDec(input);
            return (Operands[0] * Operands[1]).ToString();
        }

        public Multiplication()
        {

        }
    }
}
