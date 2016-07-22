using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CGI.CSharp.Day6
{
    class HashExample
    {

        public void HashAddValue()
        {
            Hashtable has = new Hashtable();
            has.Add(1, "Prashant");
            has.Add(2, "Maurya");
            has.Remove(2);
            has.Contains(1);

            foreach (DictionaryEntry dd in has)
            {
                Console.WriteLine("The key is: {0}\tThe Value is: {1}", dd.Key, dd.Value);
                Console.WriteLine(has.Contains(3));
            }

        }
    }
}
