using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    public enum Action
    {
        Addition,
        Subtraction,   
        Multiplication,
        Division,
        SquarePower,
        SquareRoot
    }

    internal class Operation
    {
        public decimal[] Operands = new decimal[2];
        //public decimal LeftOperand { get; set; }
        //public decimal RightOperand { get; set; }


        public virtual decimal[] ConvertToDec(string str)
        {
            char[] separator = {'+', '-', '*', '/', '^', '!' }; // ^ for square, and ! for square root. yes I know...
            string[] input = str.Split(separator);

            try
            {
                //LeftOperand = Convert.ToDecimal(input[0]);
                //LeftOperand = Convert.ToDecimal(input[1]);
                for(int i=0; i<input.Length; i++)
                {
                    Operands[i] = Convert.ToDecimal(input[i]);
                }
                //Operands[0] = Convert.ToDecimal(input[0]);
                //Operands[1] = Convert.ToDecimal(input[1]);                
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Operands;
        }

        public Operation()
        {

        }
    }
}
