using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class4
    {
        public void GetArrayProduct(int[] arr1, int[] arr2)
        {
            Console.WriteLine("The multiplication of all Array1 values with all Array2 values is as follows:");
            for (int i = 0; i<arr1.Length; i++)
            {
                Console.WriteLine(); 
                for(int j = 0; j < arr2.Length; j++)
                {
                    Console.WriteLine(arr1[i] + " * " + arr2[j] + " = " + arr1[i] * arr2[j]);                    
                }
            } 
        }


        //TODO: method to print an array

        public Class4() { }
    }
}
