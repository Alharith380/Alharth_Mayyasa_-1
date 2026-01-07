using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using project.Classes;
using project.Classes.project.Classes;

namespace project.Repositories
{
        public sealed class ProductRepository
        {
            private const string ProductsFile = "Data\\products.json";
            private const string MarketersFile = "Data/marketers.json";
            private static readonly object _lock = new object();

            public ProductRepository()
            {
                string dir = Path.GetDirectoryName(ProductsFile);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                if (!File.Exists(ProductsFile))
                    File.WriteAllText(ProductsFile, "[]");
            }

            public List<Product> LoadAll()
            {
                lock (_lock)
                {
                    string json = File.ReadAllText(ProductsFile);
                    return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
                }
            }

            public Product LoadById(int id)
            {
                List<Product> products = LoadAll();
                return products.FirstOrDefault(p => p.Id == id);
            }

            public void Save(Product product)
            {
                lock (_lock)
                {
                    List<Product> products = LoadAll();
                    Product existing = products.FirstOrDefault(p => p.Id == product.Id);
                    if (existing != null)
                    {
                        int index = products.IndexOf(existing);
                        products[index] = product;
                    }
                    else
                    {
                        product.Id = GetNextId(products);
                        products.Add(product);
                    }
                    string json = JsonConvert.SerializeObject(products, Formatting.Indented);
                    File.WriteAllText(ProductsFile, json);
                }
            }

            public void Delete(int id)
            {
                lock (_lock)
                {
                    List<Product> products = LoadAll();
                    products.RemoveAll(p => p.Id == id);
                    string json = JsonConvert.SerializeObject(products, Formatting.Indented);
                    File.WriteAllText(ProductsFile, json);
                }
            }

            public List<Marketer> LoadMarketers()
            {
                if (!File.Exists(MarketersFile))
                    return new List<Marketer>();
                string json = File.ReadAllText(MarketersFile);
                return JsonConvert.DeserializeObject<List<Marketer>>(json) ?? new List<Marketer>();
            }

            private int GetNextId(List<Product> products)
            {
                if (products.Count == 0)
                    return 1;
                return products.Max(p => p.Id) + 1;
            }
        }
    }