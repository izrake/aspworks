using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.MProject
{
    class QuantityCheck
    {
        public int Quantity { get; set; }

        public QuantityCheck(int quantity)
        {
            Quantity = quantity;
        }
        public int CheckQuantity()
        {
            if (Quantity <= 0)
            {
                throw (new QuantityException("Enter the quantity >0"));
                
            }
            else
            {
                return Quantity;
            }
                
        }
    }
}
