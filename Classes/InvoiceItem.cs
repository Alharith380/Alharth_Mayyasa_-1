using System;


namespace project.Classes
{


    namespace project.Classes
    {
        public sealed class InvoiceItem
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice => Price * Quantity;
            public int Opponent { get; set; }

            public InvoiceItem() { }

            public InvoiceItem(int id, string type, string product, decimal price, int quantity, int opponent = 0)
            {
                if (string.IsNullOrEmpty(type)) throw new ArgumentNullException("type");
                if (string.IsNullOrEmpty(product)) throw new ArgumentNullException("product");
                Id = id;
                Type = type;
                Product = product;
                Price = price;
                Quantity = quantity;
                Opponent = opponent;
            }
        }

    }    }