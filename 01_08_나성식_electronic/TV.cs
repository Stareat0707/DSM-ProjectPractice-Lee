using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_electronic
{
    class TV : HomeAppliance
    {
        public TV(string name, int price) : base(name, price)
        {
            DiscountRate = 0.15;
        }
    }
}
