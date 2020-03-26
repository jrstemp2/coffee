using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class UserOrder
    {
        private int orderNUmber;
        private string coffeeOrder;

        public int OrderNUmber { get => orderNUmber; set => orderNUmber = value; }
        public string CoffeeOrder { get => coffeeOrder; set => coffeeOrder = value; }
    }
}
