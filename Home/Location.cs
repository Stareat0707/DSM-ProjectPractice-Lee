using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Location
    {
        public string Name { get; set; }
        public Location[] Exits { get; set; }

        public void Description()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Exits: ");
            for (int i = 0; i < Exits.Length; ++i)
            {
                Console.WriteLine(Exits[i].Name);
            }

            Console.WriteLine();
        }
    }
}
