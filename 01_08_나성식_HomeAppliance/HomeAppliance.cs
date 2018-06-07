using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_나성식_electronic
{
    class HomeAppliance
    {
        public string Name { get; set; }

        public int Price { get; set; }

        protected double DiscountRate { get; set; }

        public HomeAppliance(string name, int price)
        {
            Name = name;
            Price = price;
            DiscountRate = 0;
        }

        public string GetDescription()
        {
            return $"이름: {Name}, 정가: {Price}, 할인률: {DiscountRate * 100}%, 가격: {Price * (1 - DiscountRate)}";
        }
    }
}
