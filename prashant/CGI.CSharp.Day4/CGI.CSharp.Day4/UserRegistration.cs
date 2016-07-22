using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class UserRegistration
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int check { get; set; }

        public UserRegistration()
        {
            check = 3;
        }

        public void SetTheUseDetails()
        {
            Console.WriteLine("Enter the username: ");
            Name=Console.ReadLine();
            Console.WriteLine("Enter the password: ");
            Password = Console.ReadLine();
            Console.WriteLine("<-------------------Thank you for the details-------------->");
            

        }

        public int ValidateUser()
        {
            Console.WriteLine("Enter The username");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The Password");
            string pass = Console.ReadLine();
            if (Name == name && Password == pass)
            {
                Console.WriteLine("User Details Found Correct");
                check = 0;
                return check;

            }
            else
            {
                Console.WriteLine("Enter the correct detail");
                check--;
                return check;
            }
        }
    }
}
