using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(UserOrder order)
        {
            return View("OrderIndex");
        }

        public IActionResult Order(UserOrder order)
        {
            return View(order);
        }
    }
}