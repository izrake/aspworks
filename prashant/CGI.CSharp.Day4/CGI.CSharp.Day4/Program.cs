using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*OperatorOverload op = new OperatorOverload();
            OperatorOverload op2 = new OperatorOverload();            
            op = (+op2);
            Console.WriteLine(op.x);                   
            Program p = new Program();
            p.name = "prashant";
            Console.WriteLine(p.name);
            Console.ReadKey();
             * */

            /*RectangularBox volume = new RectangularBox();
            RectangularBox box = new RectangularBox();
            RectangularBox box1 = new RectangularBox();
            volume = (box + box1);
            Console.WriteLine("The volume is:"+ volume.Area);*/

          /*  UnaryOperatorOver un = new UnaryOperatorOver();
            UnaryOperatorOver result = new UnaryOperatorOver();
            UnaryOperatorOver rs = new UnaryOperatorOver();
            rs=(un/result);
            Console.WriteLine("The value is: " + rs.Result);
            Console.ReadKey();
           * */

            
            //UserRegistration user = new UserRegistration();
            ////user.SetTheUseDetails();
            //int check = -1;
            //do
           // {
               //  check = user.ValidateUser();
           // } while (check>0);

            //Console.ReadKey();

           /*
            * ElectronicsStudent ec = new ElectronicsStudent();
            ComputerStudent cs = new ComputerStudent();
            Console.WriteLine("Enter Your Choice\n");
            Console.WriteLine("*************************************************");
            bool status = true;
            while (status)
            {
                Console.WriteLine("1.Detail For ECE\n2.Detail For CSE");
            
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        ec.GetTheStudentDetails();
                        ec.Average();
                        ec.Display();
                        status=ec.Status();
                        break;
                    case 2:
                        cs.GetTheStudentDetails();
                        cs.Average();
                        cs.Display();
                        status=cs.Status();
                        break;
                    default:
                        Console.WriteLine("Entered The Wrong Choice!!");
                        break;
                }
            * */
           
            

            


        }
    }


