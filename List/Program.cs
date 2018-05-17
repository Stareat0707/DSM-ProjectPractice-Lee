using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Doc", "Sneezy", "Happy", "Dopey", "Sleepy", "Bashful", "Grumpy" };

            List<string> list = new List<string>();

            foreach (var item in array)
            {
                list.Add(item);
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in list)
            {
                stringBuilder.Append(item.ToString() + Environment.NewLine);
            }

            string str = stringBuilder.ToString();
            Console.WriteLine($"List:{Environment.NewLine}{str}");
        }
    }
}
