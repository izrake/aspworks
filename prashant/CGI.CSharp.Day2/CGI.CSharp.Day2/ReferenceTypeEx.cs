using System;


namespace CGI.CSharp.Day2
{
    class ReferenceTypeEx
    {
        public  void CalCulateExpense(ref int exp)
        {
            Console.WriteLine("Enter the expense again:");
            exp = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("This is the expense value which entered in the method: " + exp);

        }

    }
}
