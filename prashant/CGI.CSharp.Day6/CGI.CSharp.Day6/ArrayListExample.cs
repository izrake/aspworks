using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CGI.CSharp.Day6
{
    class ArrayListExample
    {
        ArrayList arr = new ArrayList();
        public void AddValeArray()
        {
           
            arr.Add(new EmployeeDetails { EmpId = 1, City = "Banglore", Name = "Prashant" });
            arr.Insert(0, new EmployeeDetails { EmpId = 2, City = "Chennai", Name = "Prashant" });
            arr.Insert(1, new EmployeeDetails { EmpId = 3, City = "MAdras", Name = "Prashant" });
            //arr.Add("prashant");
           
        }
        public void DisplayArrayValue()
        {
            foreach (object obj in arr)
            {
                EmployeeDetails nn = (EmployeeDetails)obj;

                Console.WriteLine(arr.Capacity);
                Console.WriteLine(arr.Count);
                Console.WriteLine("The City is:" + nn.City);
            }
        }



      
        
    }
}
