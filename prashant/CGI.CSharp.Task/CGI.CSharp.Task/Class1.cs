using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Task
{
    class EmployeeDetails
    {
        string Name, Mobile;
        DateTime Dob;
        double Salary;

        public void GetTheEmployeeDetails()
        {
            Console.WriteLine("Enter the name of the employee:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the mobile number:");
            Mobile = Console.ReadLine();
            Console.WriteLine("Enter the Employee salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the dob of the employee:");
            Dob = Convert.ToDateTime(Console.ReadLine());         
        }

        public int ChoseOption()
        {
            int x;
            Console.WriteLine("1.Search By Name\n2.Search By Mobile\n3.Search By DOB");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        public bool CompareTheValues(string name)
        {
            if (Name == name)
            {
                Display();
                return true;
            }
            else
                return false;       
        }

        public bool Status()
        {
            Console.WriteLine("Do you want to continue search:y/n");
            char status = Convert.ToChar(Console.ReadLine());
            if (status == 'y' || status == 'n')
            {
                return false;
            }
            else
                return false;
        }


        public void Display()
        {
            Console.WriteLine("Employee Details Found\n{0}\n{1}\n{2}\n{3}\n", Name, Mobile, Dob, Salary);
        }

    }
}
