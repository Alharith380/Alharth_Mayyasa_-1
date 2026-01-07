using project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project.Services
{
    
        public sealed class DebtPaymentService : IPaymentService
        {
            public string Phone { get; set; }
            public string NationalId { get; set; }

            public bool ValidatePaymentData()
            {
                return Regex.IsMatch(Phone, @"^\+963\d{9}$") &&
                       Regex.IsMatch(NationalId, @"^\d{10,11}$");
            }

            public void ProcessPayment(Invoice invoice)
            {
                
            }
        } 
    }

