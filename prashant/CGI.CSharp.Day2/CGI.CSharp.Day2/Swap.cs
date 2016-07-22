using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.Day2
{
    class Swap
    {
        public void SwapTheString(ref string first, ref string name)
        {
            string temp;
            temp=first;
            first = name;
            name = temp;
        }
    }
}
