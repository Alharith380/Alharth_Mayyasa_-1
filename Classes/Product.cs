using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Classes
{
    using System;

    namespace project.Classes
    {
        public sealed class Product
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal CostPrice { get; set; }
            public DateTime CreatedAt { get; set; }

            public Product() { }

            public Product(int id, string username, string category, string productName, decimal price, int quantity, decimal costPrice)
            {
                if (string.IsNullOrEmpty(username)) throw new ArgumentNullException("username");
                if (string.IsNullOrEmpty(category)) throw new ArgumentNullException("category");
                if (string.IsNullOrEmpty(productName)) throw new ArgumentNullException("productName");

                Id = id;
                Username = username;
                CategoryName = category;
                ProductName = productName;
                Price = price;
                Quantity = quantity;
                CostPrice = costPrice;
                CreatedAt = DateTime.Now;
            }
        }
    }
}