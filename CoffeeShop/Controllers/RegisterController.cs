using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
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
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                if (user.Password == user.Password2)
                {
                    string uName = (string)(user.FirstName[0] + user.LastName);
                    user.UserName = uName;
                    return View(user);
                }
                else
                {
                    ViewData["errorMsg"] = "Your Passwrods do not match";
                    return View("RegisterIndex", user);//redirects to index blank.
                }
            }
            else
            {
                ViewData["errorMsg"] = "Your form has errors";
                return View("RegisterIndex", user);//redirects to index blank.
            }
        }
        //public IActionResult Order()
        //{

        //}
    }
}