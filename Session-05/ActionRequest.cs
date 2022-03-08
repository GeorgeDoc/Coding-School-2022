using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionRequest : AbstractMicroserviceClass
    {
        //public Guid RequestID;
        public string Input { get; set; }

        public enum ActionEnum
        {
            Convert,
            UpperCase,
            Reverse
        }

        public ActionRequest()
        {
            //RequestID = Guid.NewGuid();
        }
        //public ActionEnum Action { get; set; }


        /*private void Action(ActionEnum actionEnum, string Input)  
        {
            decimal decValue;
            int[] binary;

            switch (actionEnum)
            {
                case ActionEnum.Convert: //TODO: separate the if from the function
                    ConvertBinary(Input);
                    break;
                case ActionEnum.UpperCase:
                    if (CheckMultipleWords(Input))
                    {
                        FindLargestWord(Input);
                    }
                    break;
                case ActionEnum.Reverse:
                    if (Input is string)
                    {
                        ReverseString(Input);
                    }
                    break;
                default:
                    Message ErrorMessage = new Message();
                    ErrorMessage._Message = "An error occured, run!!";
                    break;
            }
        }

        public int[] ConvertBinary(string input)
        {
            decimal decValue;
            int[] binary = new int[10]; //x

            try //maybe overkill since TryParse, but then again, we have to log everything
            {
                if (Decimal.TryParse(Input, out decValue))
                {
                    if (decValue % 1 > 0) //diferent decimal meaning?
                    {
                        for (int i = 0; decValue > 0; i++)
                        {
                            binary[i] = (int)(decValue % 2);
                            decValue = decValue / 2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return binary;
        }

        public string FindLargestWord(string input)
        {
            string[] words = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string LargestWord = string.Empty;
            int DigitCount = 0;

            foreach (String str in words)
            {
                if (str.Length > DigitCount)
                {
                    LargestWord = str;
                }
            }
            return LargestWord;
        }

        public bool CheckMultipleWords(string input)
        {
            return input.Trim().Contains(" ");
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
        */

        //public ActionRequest(Guid RequestID, string input, ActionEnum action)
        //{
        //    Input = input;
        //    Action = action;
        //}
    }
}
