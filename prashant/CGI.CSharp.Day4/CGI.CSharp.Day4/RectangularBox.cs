using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day4
{
    class RectangularBox
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get; set; }

        public RectangularBox()
        {
            Length = 0;
            Width = 0;
            Height = 0;
        }

        public RectangularBox(int a,int b,int c)
        {
            Length=a;
            Width=b;
            Height=c;
        }
        public static RectangularBox operator +(RectangularBox box,RectangularBox box1)
        {
            Console.WriteLine("Enter the value of length breadth nd height");
            box.Length = Convert.ToInt32(Console.ReadLine());
            box.Width = Convert.ToInt32(Console.ReadLine());
            box.Height = Convert.ToInt32(Console.ReadLine());
            box1.Area = box.Height * box.Length * box.Width;
            return box1;

        }

        
    }
}
