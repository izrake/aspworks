using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day2
{
    class EmployeeDetail

    {
        int id, age;
        char gender;
        string name;


        public void setEmployeeDetails()
        {
            
            Console.WriteLine("Enter the Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Employee Gender: ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Employee Age: ");          
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************\n ");
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine("Employee ID is: {0}\nEmployee Name is: {1}\t Employee Gender:{2}\t Employee Age: {3}",id,name,gender,age);
        }
    }
}
