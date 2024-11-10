using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes
{
    internal static class DecimalExtensions
    {
        public static decimal DiscountPrice(decimal value)
        {
            return value * 0.9M;
        }
        public static decimal DiscountThisPrice(this decimal value)
        {
            return value * Math.Round(0.9M);
        }
    }
}
