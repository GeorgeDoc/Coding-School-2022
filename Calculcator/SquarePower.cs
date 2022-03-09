using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    internal class SquarePower : Operation
    {
        public string Square(string input)
        {
            var a = new SquarePower();
            Operands = a.ConvertToDec(input);
            return (Operands[0] * Operands[0]).ToString();
        }

        public SquarePower()
        {

        }
    }
}
