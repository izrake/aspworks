using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class MergeArray
    {
        int[] first=new int[5];
        int[] second = new int[5];
     

        public void FeedTheValue()
        {
            Console.WriteLine("Enter the value in the first array:");
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter the value in the second array:");
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        public void Merge()
        {
            Console.WriteLine("The merge value is:");
            int[] combined = new int[first.Length + second.Length];
            Array.Copy(first, combined, first.Length);
            Array.Copy(second, 0, combined, first.Length, second.Length);
            Array.Sort(combined);

            for (int i = 0; i < combined.Length; i++)
            {
                Console.WriteLine(combined[i]);
            }

        }

    }
}
