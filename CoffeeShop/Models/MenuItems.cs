using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MenuItems
    {
        private static string[] coffeeType = { "Latte", "Capuccino", "Regular Coffee" };
        private static string[] coffeeSize = { "Small", "Medium", "Large", "X-Large" };

        public static string[] CoffeeType { get => coffeeType; set => coffeeType = value; }
        public static string[] CoffeeSize { get => coffeeSize; set => coffeeSize = value; }
    }
}
