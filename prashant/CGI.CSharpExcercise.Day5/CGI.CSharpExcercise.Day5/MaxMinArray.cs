using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class MaxMinArray
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

        public void MaxMin()
        {
            Array.Sort(arr);
            Console.WriteLine("The maximum value is: {0} The Minimum is: {1}",arr[4],arr[0]);
        }
    }
}
