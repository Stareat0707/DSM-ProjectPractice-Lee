using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary 컬렉션");

            var colorMap = new Dictionary<string, ConsoleColor>
            {
                ["Error"] = ConsoleColor.Red,
                ["Warning"] = ConsoleColor.Yellow,
                ["Information"] = ConsoleColor.Green,
                ["Verbose"] = ConsoleColor.DarkGray
            };
            colorMap.Add("Critical Error", ConsoleColor.DarkRed);
            colorMap["Minor Error"] = ConsoleColor.Cyan;

            ConsoleColor fg = Console.ForegroundColor;
            foreach (KeyValuePair<string, ConsoleColor> item in colorMap)
            {
                Console.ForegroundColor = item.Value;
                Console.WriteLine(item.Key);
            }
            Console.ForegroundColor = fg;
        }
    }
}
