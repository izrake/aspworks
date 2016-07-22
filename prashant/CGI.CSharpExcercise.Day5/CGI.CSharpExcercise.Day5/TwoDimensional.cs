using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class TwoDimensional
    {
        int[,] arr=new int[2,3];

        public void EnterTheValue()
        {
            Console.WriteLine("Enter The Value in Matrix:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("The value of the matrix is:");
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for(int j=0;j<arr.GetLength(1);j++)
                    {
                        Console.Write("{0}\t",arr[i,j]);
                    }
                    Console.WriteLine("\n");
                }
        }

    }
}
