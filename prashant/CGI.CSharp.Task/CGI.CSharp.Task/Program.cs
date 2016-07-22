using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails emp = new EmployeeDetails();
            emp.GetTheEmployeeDetails();
            int x= emp.ChoseOption();
            bool status;
            do
            {
                status = emp.Status();
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Enter The Name:");
                        string name = Console.ReadLine();
                        emp.CompareTheValues(name);
                        break;
                    default:                       
                        break;

                }


            } while (status);
            
            emp.CompareTheValues(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
