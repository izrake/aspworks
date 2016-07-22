using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class ArrayStoring
    {
        int[] arr = new int[20];
        public void StoreTheValue()
        {
            
            Console.WriteLine("Enter the value in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
          
        }

        public void DisplayArray()
        {
            for (int k = 0; k < arr.Length;k++ )
            {
                Console.WriteLine(arr[k]);
            }
        }
    }

}
