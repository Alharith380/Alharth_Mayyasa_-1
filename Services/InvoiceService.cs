using project.Classes;
using project.Classes.project.Classes;
using project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.Services
{
    
        public class InvoiceService
        {
            private readonly InvoiceRepository _invoiceRepo;
            private readonly ProductRepository _productRepo;

            public InvoiceService(InvoiceRepository invoiceRepo, ProductRepository productRepo)
            {
                if (invoiceRepo == null) throw new ArgumentNullException("invoiceRepo");
                if (productRepo == null) throw new ArgumentNullException("productRepo");
                _invoiceRepo = invoiceRepo;
                _productRepo = productRepo;
            }

            public Invoice CreateNew(string userId)
            {
                if (string.IsNullOrEmpty(userId)) throw new ArgumentException("userId cannot be null or empty.");
                int id = _invoiceRepo.GetNextId();
                return new Invoice(id, DateTime.Now, userId);
            }

            public void AddItemToInvoice(Invoice invoice, string type, string productName, decimal price, int quantity)
            {
                if (invoice == null) throw new ArgumentNullException("invoice");
                if (string.IsNullOrEmpty(type)) throw new ArgumentException("type cannot be null or empty.");
                if (string.IsNullOrEmpty(productName)) throw new ArgumentException("productName cannot be null or empty.");

                var product = _productRepo.LoadAll().FirstOrDefault(p => p.ProductName == productName);
                if (product == null) throw new InvalidOperationException("Product '" + productName + "' not found.");

                var item = new InvoiceItem(0, type, productName, price, quantity);
                invoice.AddItem(item);
                invoice.RecalculateTotal();
            }

            public void RecalculateTotal(Invoice invoice)
            {
                if (invoice == null) throw new ArgumentNullException("invoice");
                invoice.RecalculateTotal();
            }

            public DiscountInfo GetApplicableDiscount(decimal total)
            {
                if (total >= 10000) return new DiscountInfo("DISC35", 0.35m);
                if (total >= 7000) return new DiscountInfo("DISC25", 0.25m);
                if (total >= 5000) return new DiscountInfo("DISC20", 0.20m);
                if (total >= 1500) return new DiscountInfo("DISC12", 0.12m);
                return new DiscountInfo(null, 0m);
            }

            public void ApplyDiscount(Invoice invoice, string code)
            {
                if (invoice == null) throw new ArgumentNullException("invoice");
                if (string.IsNullOrEmpty(code)) throw new ArgumentException("code cannot be null or empty.");

                var discount = GetApplicableDiscount(invoice.Total);
                if (code != discount.Code) throw new ArgumentException("Invalid or inapplicable discount code.");

                var discountAmount = Math.Round(invoice.Total * discount.Rate, 2);
                invoice.ApplyDiscount(code, discountAmount);
            }

            public void SaveInvoice(Invoice invoice)
            {
                if (invoice == null) throw new ArgumentNullException("invoice");
                _invoiceRepo.Save(invoice);
            }

            public List<Invoice> GetAllInvoices() => _invoiceRepo.LoadAll();
            public Invoice GetInvoiceById(int id) => _invoiceRepo.LoadById(id);
        }
    }
