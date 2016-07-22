using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day2
{
    class ConstructorDestruc
    {
        public ConstructorDestruc()
        {
            Console.WriteLine("Instance Constructor");
        }
         static ConstructorDestruc()
        {
            Console.WriteLine("This is the static destructor");
        }
        ~ConstructorDestruc()
        {
            Console.WriteLine("Destructor has been called");
        }
    }
}
