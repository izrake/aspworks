using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class UnaryOperatorOver
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Result { get; set; }


        public static UnaryOperatorOver operator /(UnaryOperatorOver obj,UnaryOperatorOver obj1)
        {
            Console.WriteLine("Enter the two values whose multiplication u need:");
            obj.First = Convert.ToInt32(Console.ReadLine());
            obj1.Second = Convert.ToInt32(Console.ReadLine());
            obj.Result=obj.First*obj1.Second;
            return obj;
        }
    }
}
