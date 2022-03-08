using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }


        public ActionResponse Execute(ActionRequest actionRequest)
        {
            ActionResponse response = new ActionResponse();
            return response;
        }


        private void Action(ActionRequest.ActionEnum actionEnum, string Input) //TODO: more elegant way than ActionRequest.ActionEnum??
        {
            switch (actionEnum)
            {
                case ActionRequest.ActionEnum.Convert: //TODO: separate the if from the function
                    Message BinaryMessage = new Message();
                    BinaryMessage._Message = ConvertBinary(Input).ToString();
                    Logger.Write(BinaryMessage);
                    break;
                case ActionRequest.ActionEnum.UpperCase:
                    if (CheckMultipleWords(Input))
                    {
                        Message LargesMessage = new MessageLogger();
                        LargesMessage._Message = FindLargestWord(Input).ToString();
                        Logger.Write(LargesMessage);
                    }
                    break;
                case ActionRequest.ActionEnum.Reverse:
                    if (Input is string)
                    {
                        Message ReverseMessage = new Message();
                        ReverseMessage._Message = ReverseString(Input).ToString();
                        Logger.Write(ReverseMessage);
                    }
                    break;
                default:
                    Message ErrorMessage = new Message();
                    ErrorMessage._Message = "An error occured, run!!";
                    Logger.Write(ErrorMessage);
                    break;
            }
        }

        public int[] ConvertBinary(string input)
        {
            decimal decValue;
            int[] binary = new int[10]; //x

            try //maybe overkill since TryParse, but then again, we have to log everything
            {
                if (Decimal.TryParse(input, out decValue))
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
            if (input.Length > 0)
                return input[input.Length - 1] + ReverseString(input.Substring(0, input.Length - 1));              
            else
                return input;
        }


        public ActionResolver()
        {

        }
    }
}
