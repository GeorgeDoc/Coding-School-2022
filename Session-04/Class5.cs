using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class5
    {

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void SortArray(int[] array) 
        {
            int temp = 0;

            //for(int i = 0; i < array.Length-1; i++)
            //{
            //    for (int j = array.Length-1; j > i; --j)
            //    {
            //        if(array[j] < array[j-1])
            //        {
            //            temp = array[j];
            //            array[j - 1] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}

            //for(int i = 1; i < result.Length; i++)
            //for(int i = 1; i < array.Length; i++) 
            //{
            //    for (int j = 1; j < array.Length; j++)
            //    {
            //        if (array[j] < array[j - 1]) // if smaller than previous element, swap
            //        {
            //            temp = array[j];
            //            array[j - 1] = array[j];
            //            array[j] = temp;
            //        }
            //    }

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length -1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i+1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            PrintArray(array);
        }

        public Class5() { }
    }
}
