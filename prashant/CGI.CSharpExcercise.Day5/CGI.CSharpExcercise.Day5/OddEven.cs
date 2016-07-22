using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharpExcercise.Day5
{
    class OddEven
    {
        String str;

        public void PrintTheStringChar()
        {
            str = "AMBULANCE";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("The Charcter Are:{0}\n", str[i]);
            }
        }
             
    }
}
