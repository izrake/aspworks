using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesssExample;

namespace CGI.CSharp.Day2
{
    class Program:AccessSpecifiers
        
    {
        ~Program()
        {
            Console.WriteLine("Destructor of main class");
        }
        public void Get()
        {
            AccessSpecifiers acs = new AccessSpecifiers();
            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
# region class
            /* EmployeeDetail emp = new EmployeeDetail();
            emp.setEmployeeDetails();
            emp.DisplayEmpDetails();
            Console.ReadKey();

             MyClass1 m1 = new MyClass1();
             m1.method1();
             Console.ReadKey();
            Console.WriteLine("Hey Dude!!!!!!");
             Console.WriteLine("********************************");
             Console.WriteLine("Lets Have Some Fun: ");
             Console.WriteLine("|_______|");
             Console.WriteLine("Guess The Number! Let's See How Strong You Are: ");
            // int d=20,e ;
             //e = Convert.ToInt32(Console.ReadLine());

            while (d != e) 
             {
                 Console.WriteLine("Ohh Wron Again!! Try It one more time: ");
                 Console.WriteLine("Guess The Number! Let's See How Strong You Are: ");
                 e = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Ohh Great U Finally Did It!! Congooooooo ");
                 Console.ReadLine();

             } */

            /*StudentMarksDetail std = new StudentMarksDetail();
            std.GetTheStudentDetails();
            std.CalculateTheDetails();
            std.DispalyDetails();
            Console.ReadKey();*/
            /*
            DayFinder df = new DayFinder();
            df.GetTheDayInNumber();
            df.DisplayTheDay();
            Console.ReadKey();*/
# endregion
            # region postNdPrefix Example
            /*
            int i, j = 1, k;
            for (i = 0; i < 5; i++)
            {
                k = j++ + ++j;
                Console.WriteLine("k:" + k);


            }
            Console.ReadKey();*/



            /*int expense=0 ;
            int day = 0;
            Console.WriteLine("Write Number to see the magic");
            expense = Int32.Parse(Console.ReadLine());
            ReferenceTypeEx ex = new ReferenceTypeEx();
            ex.CalCulateExpense(ref expense);

            bool b=Int32.TryParse(Console.ReadLine(),out day);
            if (b)
            {
                expense = day;
            }
            else
            {
                day = expense;
            }
              */
            # endregion


            #region Swap
            /*
            string first=null, second=null;
            Console.WriteLine("Enter the first string: ");
            first=Console.ReadLine();
            Console.WriteLine("Enter the second String: ");
            second = Console.ReadLine();

            Swap sw = new Swap();
            sw.SwapTheString(ref first, ref second);

            Console.WriteLine("After Swap:");
            Console.WriteLine("The values of first is now: " + first);
            Console.WriteLine("The value of the second is now: " + second);
            Console.ReadKey();
             
              */
            #endregion
            ConstructorDestruc cd = new ConstructorDestruc();
            Program p = new Program();
            Console.ReadKey();




        }
    }
}
