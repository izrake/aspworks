using System;
using System.Collections.Generic;

using System.Collections;

namespace CGI.CSharp.MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Registraion rg = new Registraion();
            rg.GetTheUserDetails();
            //rg.SignIn();
            Console.ReadKey();
        }
    }
}
