using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class UserOrder
    {
        private int orderNumber;
        private string userName;
        private string coffeeOrder;

        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public string UserName { get => userName; set => userName = value; }
        public string CoffeeOrder { get => coffeeOrder; set => coffeeOrder = value; }
        
    }
}
