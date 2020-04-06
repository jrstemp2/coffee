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
                string phone = user.Phone;
                if (user.Password != user.Password2)
                {
                    

                    ViewData["errorMsg"] = "Your Passwrods do not match";
                    return View("RegisterIndex", user);//redirects to index blank.




                }
                
                else
                {

                    if (phone.Length < 12)
                    {
                        ViewData["errorMsg"] = "Your Phone number is not in the proper format. Please use XXX-XXX-XXXX";
                        return View("RegisterIndex", user);//redirects to index blank.
                    }
                    else
                    {
                        string uName = (string)(user.FirstName[0] + user.LastName);
                        user.UserName = uName;
                    }
                    


                    return View(user);
                }

                
            }
            else
            {
                ViewData["errorMsg"] = "Your form has errors";
                return View("RegisterIndex", user);//redirects to index blank.
            }

            

            
        }

        public IActionResult UserPage(UserInfo user)
        {
            
            
            return View("Register", user);
        }
        //public IActionResult Order()
        //{

        //}
    }
}