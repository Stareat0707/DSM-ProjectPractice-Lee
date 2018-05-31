using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_electronic
{
    class Raptop : HomeAppliance
    {
        public Raptop(string name, int price, string quality) : base(name, price)
        {
            switch(quality)
            {
                case "최고급":
                    DiscountRate = 0.15;
                    break;

                case "고급":
                    DiscountRate = 0.1;
                    break;
            }
        }
    }
}
