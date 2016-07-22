using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CGI.CSharp.MiniProject
{
    class Registraion
    {
        
        ArrayList arr = new ArrayList();

        public void GetTheUserDetails()
        {            
            
            Console.Write("Enter The First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter The Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter The Emaild Id: ");
            string EmailId = Console.ReadLine();
            Console.Write("Enter The Password Name: ");
            string PassWord = Console.ReadLine();
            arr.Add(new User(FirstName, LastName, EmailId, PassWord));
            Object obj = arr;
            User user = (User)obj;
            Console.WriteLine(user.FirstName);
        }

        public void SignIn()
        {
            Object obj=arr;
            User user = (User)obj;

            Console.Write("Please Enter The Username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The Password: ");
            string pass = Console.ReadLine();
            if (user.FirstName == name && user.PassWord == pass)
            {
                Console.WriteLine("Log In Successfull");
            }
            else
            {
                Console.WriteLine("Enter the correct details:");
            }

            
            
        }


    }
}
