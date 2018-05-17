using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePrimaryColor
{
    class Program
    {
        static void Main(string[] args)
        {
            CFavoritePrimaryColor yourColor = new CFavoritePrimaryColor();
            yourColor.FavoritePrimaryColor = "red";
            Console.WriteLine("Your Favorite Color is " + yourColor.FavoritePrimaryColor);
            CFavoritePrimaryColor myColor = new CFavoritePrimaryColor();
            myColor.FavoritePrimaryColor = "Green";
        }
    }
}
