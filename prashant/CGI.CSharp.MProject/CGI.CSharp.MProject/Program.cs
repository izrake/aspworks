using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CGI.CSharp.MProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                 Welcome Please Register With Us To Continue!!!                                       ");
            Console.WriteLine("******************************************************************************************************");
            Registration reg = new Registration();
            Console.WriteLine("Register The User: ");
            reg.GetTheDetails();
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("                                          Please Sign In                                              ");
            Console.WriteLine("******************************************************************************************************");
            reg.StatusSignIn();                
            Console.ReadKey();
        }
    }
}
