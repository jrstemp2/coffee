using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("RegisterIndex");
        }
        [HttpPost]
        public IActionResult Register(string fname, string lname, string email, string password, string offers)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["offers"] = offers;
            ViewData["password"] = password;
            ViewData["username"] = fname[0] + lname;
            return View();
        }
    }
}