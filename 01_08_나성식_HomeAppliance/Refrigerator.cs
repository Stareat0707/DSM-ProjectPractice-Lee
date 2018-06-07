using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_electronic
{
    class Refrigerator : HomeAppliance
    {
        public Refrigerator(string name, int price) : base(name, price)
        {
            DiscountRate = 0.05;
        }
    }
}
