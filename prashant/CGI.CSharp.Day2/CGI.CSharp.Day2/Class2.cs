using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day2
{
    class StudentMarksDetail
    {
        string Name;
        float Marks1, Marks2,Marks3,Avg,Total;
        int Id;

        public void GetTheStudentDetails()
        {
            Console.WriteLine("Enter The Name Of The Student: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter ID Of The Student: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark1: ");
            Marks1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mark2: ");
            Marks2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mark3: ");
            Marks3= float.Parse(Console.ReadLine());
        }

        public void CalculateTheDetails()
        {
            Avg = (Marks3 + Marks2 + Marks1)/3;
            Total = Marks3 + Marks2 + Marks1;
        }

        public void DispalyDetails()

        {
            Console.WriteLine("***********************************************************************************************\n");
            Console.WriteLine("Student ID: {0}\nStudent Name: {1}\tMarks1: {2}\tMarks2: {3}\tMarks3: {4}\n Avg:{5} \t Total: {5}",  Name, Marks1, Marks2, Marks3, Avg, Total);
            if (Avg > 90) 
            {
                Console.WriteLine("Grade A!! Congo " + Name);
            }
            else if (Avg < 90 && Avg >= 80)
            {
                Console.WriteLine("Grade B!! Congo " + Name);
            }
            else if (Avg < 80 && Avg >= 70)
            {
                Console.WriteLine("Grade C!! Congo " + Name);
            }
            else if (Avg < 70 && Avg >= 60)
            {
                Console.WriteLine("Grade D!! Passed " + Name);
            }
            else if (Avg < 60 && Avg >=50 )
            {
                Console.WriteLine("Sorry You Are Failed In Exam " + Name);
            }
        }
        
    }
}
