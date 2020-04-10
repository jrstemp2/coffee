using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class DAL
    {
        SqlConnection connection; 

        public DAL (string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        //Get all distinct categories of products. 

        public IEnumerable<Product> GetAllProducts()
        {
            string queryString = "SELECT * FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }
        public IEnumerable<Product> GetProductCategories()
        {
            string queryString = "SELECT DISTINCT Category FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }

        public Product GetProductById(int id)
        {
            string queryString = "SELECT * FROM Products WHERE Id = @val";
            Product prod = connection.QueryFirstOrDefault<Product>(queryString, new { val = id });
            return prod;
        }

        public IEnumerable<Product> GetProductsInCategory(string cat)
        {
            string queryString = "SELECT * FROM Products WHERE Category = @val";
            IEnumerable<Product> Products = connection.Query<Product>(queryString, new { val = cat });

            return Products;
        }

        public int DeleteProductById(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
        }

        public int CreateProduct(Product prod)//pass empty product in. 
        {
            string createString = "INSERT INTO Products (Name, Price, Description, Category, Temperature)";
            createString += "VALUES(@Name, @Price, @Description, @Category, @Temperature)";
            return connection.Execute(createString, prod);//create product and return int value for success or fail. 
        }

        public int UpdateProductById(Product prod)
        {
            string editString = "UPDATE Products SET Name = @Name, Description = @Description, ";
            editString += "Category = @Category, Price = @Price, Temperature=@Temperature WHERE Id = @Id";
            return connection.Execute(editString, prod);
        }



    }
}
