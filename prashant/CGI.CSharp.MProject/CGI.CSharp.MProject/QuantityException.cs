using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.MProject
{
    class QuantityException:Exception
    {
        public QuantityException(string message)
            : base(message)
        {
        }
    }
}
