using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    internal class Calculation : Operation // This is the class that will be called when = is pressed
    { 
     // The TextBox string will be spit into a decimall array, and operatins will start taking place.
     // The operations will happen from let to right, 2 operands at a time, probably recursively (the result will be the new left operand)
     // TODO: Keep track of symbols, so proper order of precedence is kept, (maybe add parentheses to the calculator buttons as well)


        public string DoCalculation(string input)
        {
            var calc = new Calculation();
            string result = string.Empty;
            decimal temp = 0;

            decimal[] AllOperands = calc.ConvertToDec(input);
            char[] AllOperators = calc.GetOperators(input);

            for(int i = 0; i < AllOperators.Length; i++)
            {
                if(AllOperators[i] == '+')
                {
                    temp = AllOperands[i] + AllOperands[i+1]; 
                }
            }
            return result;   
        }

        public Calculation()
        {

        }
    }
}
