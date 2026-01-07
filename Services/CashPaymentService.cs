using project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project.Services
{

    
        public sealed class CashPaymentService : IPaymentService
        {
            public string Name { get; set; }
            public string CardNumber { get; set; }
            public string BankAccount { get; set; }

            public bool ValidatePaymentData()
            {
                return !string.IsNullOrEmpty(Name) &&
                       Regex.IsMatch(CardNumber, @"^\d{10}$") &&
                       Regex.IsMatch(BankAccount, @"^\d{8,}$");
            }

            public void ProcessPayment(Invoice invoice)
            {

            }
        } 
    }

