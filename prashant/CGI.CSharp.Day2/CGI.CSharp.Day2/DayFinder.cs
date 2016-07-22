using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day2
{
    class DayFinder
    {
        int i;
        string name;
        public void GetTheDayInNumber()
        {
            Console.WriteLine("Hey Pls Introduce Your Name!!!");
            name=Console.ReadLine();

            Console.WriteLine("Enter The Number Btw 1 to 7 "+name);
            i = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayTheDay()
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("Its is Sunday " +name);
                    break;
                case 2:
                    Console.WriteLine("Its is Monday " + name);
                    break;
                case 3:
                    Console.WriteLine("Its is Tuesday " + name);
                    break;
                case 4:
                    Console.WriteLine("Its is Wednesday " + name);
                    break;
                case 5:
                    Console.WriteLine("Its is Thursday " + name);
                    break;
                case 6:
                    Console.WriteLine("Its is Friday " + name);
                    break;
                case 7:
                    Console.WriteLine("Its Saturday " + name);
                    break;
            }
        }
    }
}
