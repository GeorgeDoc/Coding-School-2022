using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {
        string result = String.Empty;
        public Class1()
        {

        }
        public string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            char[] charResult = new char[chars.Length];
            for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
            {
                charResult[i] = chars[j];
            }
            string stringResult = new String(charResult);
            return stringResult;
        }

        //public string ReverseString2(string input)
        //{
        //    string result = String.Empty;
        //    char[] initial = input.ToCharArray();
        //
        //    for (int i = 0; i<input.Length-1; i++)
        //    {
        //        result += initial[input.Length];
        //    }
        //    return result;
        //} // index out of bounds

        public string ReverseLib (string input) //library method
        {
            char[] chars = input.ToCharArray ();
            Array.Reverse (chars);
            return new string(chars);
        }
    }
}
