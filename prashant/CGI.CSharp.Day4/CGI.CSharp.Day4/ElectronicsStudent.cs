using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class ElectronicsStudent:StudentRegistration
    {
        public int ECircuits { get; set; }
        public int CAnalysis { get; set; }
        public int ACommunication { get; set; }
       

        public override void GetTheStudentDetails()
        {
            base.GetTheStudentDetails();
            Console.WriteLine("Enter Electronics Circuits Mark ");
            ECircuits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Circuit Analysysis Marks: ");
            CAnalysis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Analog Communication Marks: ");
            ACommunication = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Registration Number: {0}\tName: {1}\tElectronics Circuit: {2}\nCircuit Analysis Marks: {3}\tAnalog Communication Mark: {4}\tAverage Number: {5}"
                , RNumber, Name, ECircuits, CAnalysis, ACommunication,AverageNum
                );

        }
        public void Average()
        {
            AverageNum = (float)(ECircuits + ACommunication + CAnalysis) / 3;

        }

    }
}
