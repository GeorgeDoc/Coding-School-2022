using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class2
    {
        public Class2()
        {

        }
        //TODO: n must be >=0 and need separate if for n=0

        public int GetSum(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        public int GetProduct(int n)
        {
            int result = 1;
            int i = 1;
            while(i <= n)
            {
                result *=i;
                i++;
            }
            return result;
        }
    }
}
