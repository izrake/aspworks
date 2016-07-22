using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class OperatorOverload
    {
        public int x;
        int y;
        public OperatorOverload()
        {
            x = 0;
            y = 0;

        }
        public OperatorOverload(int o,int z)
        {
            x = o;
            y = z;

        }
        public void Display()
        {
            Console.WriteLine(x);
        }

        public static OperatorOverload operator +(OperatorOverload obj)
        {
            OperatorOverload temp = new OperatorOverload();
            temp.x = ++obj.x;
            temp.y = ++obj.y;
            return temp;
        }

    }
}
