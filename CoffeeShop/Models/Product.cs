using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private string description;
        private string category;
        private string temperature;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
        public string Temperature { get => temperature; set => temperature = value; }
    }
}
