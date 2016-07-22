using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class ArrayElSum
    {
        int[] arr = new int[5];
        public void StoreTheValue()
        {

            Console.WriteLine("Enter the value in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        public void Sum()
        {
            int add = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                add = add + arr[i];
            }
            Console.WriteLine("The addtion is: {0}", add);
        }
    }
}
