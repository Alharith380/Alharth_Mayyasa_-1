using project.Classes.project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Classes
{

    
        public sealed class Invoice
        {
            public int Id { get; set; }
            public DateTime Date { get;  set; }
            public string UserId { get;   set; }
        public string PaymentType { get;   set; }
        public string PayerName { get;   set; }
        public string PayerAddress { get;   set; }
        public string PayerPhone { get;   set; }
        public string PayerNatunal { get;   set; }

        public List<InvoiceItem> Items { get;   set; }
            public decimal Total { get;   set; }
            public string AppliedDiscountCode { get;   set; }
            public decimal DiscountAmount { get;   set; }
            public decimal FinalTotal => Total - DiscountAmount;
      

          int _nextItemId = 1;

            public Invoice()
            {
                Items = new List<InvoiceItem>();
            }

            public Invoice(int id, DateTime date, string userId, string paymentType = "", string payerName = "",string payerAddress="",string payerphone="" , string payernatunal="")
            {
                if (string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
                Id = id;
                Date = date;
                UserId = userId;
                PaymentType = paymentType;
                PayerName = payerName;
                PayerAddress = payerAddress;
            PayerNatunal = payernatunal;
                PayerPhone = payerphone;
                Items = new List<InvoiceItem>();
            }

        public void SetPaymentInfo(string paymentType, string payerName, string payerAddress , string payernatunal, string payerphone)
        {
            PaymentType = paymentType ?? "";
            PayerName = payerName ?? "";
            PayerAddress = payerAddress?? "";
            PayerNatunal = payernatunal ?? "";

            PayerPhone = payerphone ?? "";
        }

        public void AddItem(InvoiceItem item)
            {
                if (item == null) throw new ArgumentNullException("item");
                item.Id = _nextItemId++;
                Items.Add(item);
            }

            public void RecalculateTotal()
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.TotalPrice;
                }
                Total = Math.Round(total, 2);
            }

            public void ApplyDiscount(string code, decimal amount)
            {
                AppliedDiscountCode = code;
                DiscountAmount = Math.Round(amount, 2);
            }
        }
    }