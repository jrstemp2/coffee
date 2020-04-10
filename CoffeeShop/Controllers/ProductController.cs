using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Dapper;


namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;
        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("coffeeShopDB"));
        }
        
        public IActionResult Index()
        {

            ViewData["Products"] = dal.GetProductCategories();

            return View("ProductIndex");
        }

        public IActionResult Cat(string cat)
        {
            ViewData["Title"] = cat;
            ViewData["Products"] = dal.GetProductsInCategory(cat);

            return View();
        }

        public IActionResult Detail(int id)
        {
            Product prod = dal.GetProductById(id);
            ViewData["Title"] = prod.Name;
            ViewData["Product"] = prod;
            return View();
        }





        }
    }