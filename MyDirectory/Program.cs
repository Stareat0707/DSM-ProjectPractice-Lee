using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\temp\dir_20180612";
            Console.WriteLine($"{dir}이 존재하는가? {Directory.Exists(dir)}");

            Directory.CreateDirectory(dir);
            Console.WriteLine($"{dir}이 존재하는가? {Directory.Exists(dir)}");

            Directory.Delete(dir);
            Console.WriteLine($"{dir}이 존재하는가? {Directory.Exists(dir)}");
        }
    }
}
