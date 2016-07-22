using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class ComputerStudent : StudentRegistration
    {
        public float CNetwork { get; set; }
        public float DStructure { get; set; }
        public float Testing { get; set; }

        public override void GetTheStudentDetails()
        {
            base.GetTheStudentDetails();
            Console.WriteLine("Enter Computer NetWork Mark ");
            CNetwork = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Data Structure Mark: ");
            DStructure = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Testing Marks: ");
            Testing = float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Registration Number: {0}\tName: {1}\tComputer Network: {2}\nData Structure: {3}\tTesting: {4}\tAverage Number: {5}"
                , RNumber, Name, CNetwork, DStructure, Testing, AverageNum
                );
        }

        public void Average()
        {
            AverageNum = (DStructure + Testing + CNetwork) / 3;

        }
    }
}
