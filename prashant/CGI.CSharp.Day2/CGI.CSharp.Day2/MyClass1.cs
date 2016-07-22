using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day2
{
    class MyClass1
    {

        public void method1()
        {
            //implicit type conversion
            int a = 10;
            Object obj;
            obj = a;
            Console.WriteLine("Object value is: " + obj);
        }

    }
}
