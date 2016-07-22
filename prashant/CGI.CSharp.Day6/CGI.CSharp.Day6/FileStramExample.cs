using System;
using System.IO;

namespace CGI.CSharp.Day6
{
    class FileStramExample
    {
        String Name, City, Id;

        public void GetTheDetails()
        {
            Console.WriteLine("Enter the name , city , id:");
            Name = Console.ReadLine();
            City = Console.ReadLine();
            Id = Console.ReadLine();

        }

        public void WriteTheDetails(String path)
        {
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Name:" + Name);
            sw.WriteLine("Id:" + Id);
            sw.WriteLine("City:" + City);
            sw.Close();
            fs.Close();
        }

        public void ReadFromFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamWriter sw = new StreamWriter(fs);
        }
    }
}
