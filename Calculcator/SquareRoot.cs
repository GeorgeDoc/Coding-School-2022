using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    internal class SquareRoot : Operation
    {
        public string Root(string input)
        {
            var a = new SquareRoot();
            Operands = a.ConvertToDec(input);
            if(input[0] <= 0)
            {
                return "0";
            }
            else
            {
                return Math.Sqrt(decimal.ToDouble(Operands[0])).ToString();
            }
        }

        public SquareRoot()
        {

        }
    }
}
