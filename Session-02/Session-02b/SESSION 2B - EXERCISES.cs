using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_School_2022.Session_02b
{
    internal class SESSION_2B___EXERCISES
    {
        static void Main(string[] args)
        {
            //1. 
            Console.WriteLine("Hello from" + " George Aivaliotis\n" + DateTime.Now);


            //2. 
            Console.WriteLine("Enter 2 numbers to get their sum: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1+num2) + "\n");


            //3.
            Console.WriteLine("Operations:\n");
            Console.WriteLine(-1 + 5 * 6);
            Console.WriteLine(38 + 5 % 7);
            Console.WriteLine(14 + (-3.0 * 6.0) / 7);
            Console.WriteLine(2 + (13.0 / 6) * 6 + Math.Sqrt(7));
            Console.WriteLine((Math.Pow(6, 4) + Math.Pow(5, 7)) / 9 % 4);


            //4. 
            short age = 99;
            string gender = "apache helicoper";
            Console.WriteLine("\nYou are " + gender + ", and look exaclty like you're " + age + "years old.\n");


            //5.
            Console.WriteLine("Enter an integer number that represents seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double minutes = 0;
            double hours = 0;
            double days = 0;
            double years = 0;

            minutes = seconds / 60;
            hours = minutes / 60;
            days = hours / 24;
            years = days / 365;

            Console.WriteLine(seconds + " seconds are :");//make it 1 string
            Console.WriteLine(minutes + " minutes");
            Console.WriteLine(hours + " hours");
            Console.WriteLine(days + " days");
            Console.WriteLine(years + " Years\n");


            //6.
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            minutes = t.Minutes;
            hours = t.Hours;
            days = t.Days;
            //years = days / 365;

            Console.WriteLine(seconds + " seconds are :");
            Console.WriteLine(minutes + " minutes");
            Console.WriteLine(hours + " hours");
            Console.WriteLine(days + " days");
            Console.WriteLine(years + " Years\n");


            //7. 
            Console.WriteLine("Enter an number in Celcius to convert to Kelvin & Farenheit: ");
            double celcius = 0;
            celcius = Double.Parse(Console.ReadLine());

            double kelvin = celcius + 273;
            double fahrenheit = celcius * 1.8 + 32;

            Console.WriteLine(celcius + " are " + kelvin + " Kelvin, and " + fahrenheit + " degrees Fahrenheit");
        }
    }
}
