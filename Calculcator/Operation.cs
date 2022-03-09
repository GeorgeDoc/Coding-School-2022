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

        public virtual decimal[] ConvertToDec(string str)
        {
            char[] separator = {'+', '-', '*', '/', '^', '!' }; // ^ for square, and ! for square root. yes I know...
            string[] input = str.Split(separator);

            try
            {
                for(int i=0; i<input.Length; i++)
                {
                    Operands[i] = Convert.ToDecimal(input[i]);
                }               
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Operands;
        }

        public char[] GetOperators(string str)
        {
            char[] separator = { '+', '-', '*', '/', '^', '!' };
            string[] input = str.Split(separator);

            char[] operators = new char[input.Length];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                    if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '^' || str[i] == '!')
                    {
                        operators[j] = str[i];
                    }
            }
            return operators;
        }

        public Operation()
        {

        }
    }
}
