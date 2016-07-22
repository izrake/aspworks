using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class OdAndEven
    {
        int[] odd=new int[5];
        int[] even= new int[5];
        int[] arr = new int[5];
        int j = 0,k=0;

        public void StoreTheValue()
        {

            Console.WriteLine("Enter the value in the array");
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        public void Seperate()
        {
            
            for (int i = 0; i < arr.Length;i++ )
            {
                if (arr[i] % 2 == 0)
                {
                    even[k] = arr[i];
                    k++;                 
                }
                else
                {
                    odd[j] = arr[i];
                    j++;

                }
                
                
        }
        }

        public void Display()
        {
            Console.WriteLine("The Odd Values are:");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(odd[i]);
            }
            Console.WriteLine("The Evens Values are:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(even[i]);
            }

        }


    }
}
