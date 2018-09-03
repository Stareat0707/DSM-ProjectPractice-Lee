using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bookCategories = new string[] { "web", "child", "cooking", "language" };

            string fileName = @"C:\temp\stringToFile.txt";
            FileStream fileStream = File.Create(fileName);

            StreamWriter writer = new StreamWriter(fileStream);

            foreach (var item in bookCategories)
                writer.WriteLine(item);
            
            writer.Dispose();
            fileStream.Dispose();
        }
    }
}
