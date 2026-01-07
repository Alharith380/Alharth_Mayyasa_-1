using project.Classes.project.Classes;
using project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.Services
{

        public class ProductService
        {
            private readonly ProductRepository _productRepo;

            public ProductService(ProductRepository productRepo)
            {
                if (productRepo == null) throw new ArgumentNullException("productRepo");
                _productRepo = productRepo;
            }

            public void InitializeDefaultData()
            {
                var existing = _productRepo.LoadAll();
                if (existing.Count > 0) return;

                var products = new List<Product>
            {
                new Product(1, "Ahmed", "Electronics", "iPhone 14", 3000, 10, 1500),
                new Product(2, "Ahmed", "Electronics", "Samsung S23", 2500, 15, 1000),
                new Product(3, "Ahmed", "Clothing", "T-Shirt", 150, 50, 50),
                new Product(4, "Ahmed", "Clothing", "Jeans", 300, 40, 200),
                new Product(5, "Ahmed", "Books", "C# Programming", 120, 30, 75),
                new Product(6, "Ahmed", "Books", "ASP.NET Core", 180, 25, 120)
            };

                foreach (var p in products)
                {
                    _productRepo.Save(p);
                }
            }

            public void AddOrUpdateProduct(Product product)
            {
                if (product == null) throw new ArgumentNullException("product");
                _productRepo.Save(product);
            }

            public void DeleteProducts(List<Product> products)
            {
                if (products == null) throw new ArgumentNullException("products");
                foreach (var p in products)
                {
                    _productRepo.Delete(p.Id);
                }
            }

            public List<string> GetAllCategories()
            {
                return _productRepo.LoadAll()
                        .Select(p => p.CategoryName)
                        .Distinct()
                        .ToList();
            }

            public List<string> GetProductsByCategory(string categoryName)
            {
            return _productRepo.LoadAll()
                .Where(p => p.CategoryName == categoryName)
                .OrderBy(p => p.ProductName)
                .Select(p => p.ProductName)
                .ToList();

        }

        public Product GetProductByName(string productName)
            {
                if (string.IsNullOrEmpty(productName)) throw new ArgumentException("productName cannot be null or empty.");
                return _productRepo
                .LoadAll()
                .FirstOrDefault(p => p.ProductName == productName);
            }

            public List<Product> GetAllProducts() => _productRepo.LoadAll();

            public bool IsMarketerExists(string username)
            {
                if (string.IsNullOrEmpty(username)) return false;
                var marketers = _productRepo.LoadMarketers();
                return marketers.Any(m => m.FullName.Equals(username, StringComparison.OrdinalIgnoreCase));
            }
        }
    }