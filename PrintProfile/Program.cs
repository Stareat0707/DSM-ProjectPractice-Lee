using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProfile
{
    class Program
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine("Name: {0}, Phone: {1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile(phone: "010-123-1234", name: "박찬호");
        }
    }
}
