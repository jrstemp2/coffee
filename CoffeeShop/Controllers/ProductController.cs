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
        SqlConnection connection;

        public ProductController(IConfiguration config)
        {
            ConfigRoot = config;
            connection = new SqlConnection(ConfigRoot.GetConnectionString("coffeeShopDB"));
        }
        public IActionResult Index()
        {

            string queryString = "SELECT * FROM Products ORDER BY Category";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            ViewData["Products"] = Products;
            return View("ProductIndex");
        }





    }
}