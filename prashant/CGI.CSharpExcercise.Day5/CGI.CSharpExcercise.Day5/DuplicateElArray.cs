using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class DuplicateElArray
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

        public void CompareTheArray()
        {
            int count=0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1 ; i++)
            {
                Console.WriteLine("Value of i:" + i);
                if (arr[i] == arr[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine("There are" + count + "same elements");
        }

    }
}
