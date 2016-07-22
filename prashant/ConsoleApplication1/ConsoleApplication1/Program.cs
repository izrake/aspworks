using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            int k = j++ + ++j + j++;
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
