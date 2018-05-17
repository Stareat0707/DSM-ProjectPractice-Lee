using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePrimaryColor
{
    class CFavoritePrimaryColor
    {
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch(value.ToLower())
                {
                    case "red":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{ value } is not a primary color. Choose from: red, blue.");
                }
            }
        }
    }
}
