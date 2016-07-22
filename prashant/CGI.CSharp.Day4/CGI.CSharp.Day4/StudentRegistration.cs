using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class StudentRegistration
    {
        public string Name { get; set; }
        public int RNumber { get; set; }
        public float AverageNum { get; set; }

        public virtual void GetTheStudentDetails()
        {
            Console.WriteLine("Enter The Student Name: ");
            Name=Console.ReadLine();
           
            Console.WriteLine("Enter The Student Registration Number: ");
            RNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool Status()
        {
            char s;
            bool status = false;
            Console.WriteLine("Would you like to continue the feeding details:y/n");
            s = Convert.ToChar(Console.ReadLine());
            if (s == 'y' || s == 'Y')
            {
                status = true;
                return status;
            }
            else
            {

                status = false;
                return status;
            }
        }
    }
}
