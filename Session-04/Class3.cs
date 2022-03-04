using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {
        public bool IsPrime(int n)
        {
            bool isPrime = true;
            if(n%2 == 0)
            {
                return false;
            }
            return isPrime;
        }

        public void GetPrimes(int n)
        {
            Console.WriteLine("Prime numbers up to n (n not included): ");
            int i = 1;
            if (n == 0)
            {
                Console.WriteLine("0 prime numbers");
            }
            else 
            {
                while(i < n)
                {
                    if(IsPrime(i))
                    {
                        Console.Write(i + " ");
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
