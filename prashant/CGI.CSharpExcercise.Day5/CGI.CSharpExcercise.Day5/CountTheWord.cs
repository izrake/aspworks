using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class CountTheWord
    {
        String str;
        int ctr = 1;

        public void CountWords()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    ctr++;
                }
            }
            Console.WriteLine("The count is:" + ctr);
        }
    }
}
