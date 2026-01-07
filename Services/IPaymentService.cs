using project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Services
{
   
        public interface IPaymentService
        {
            bool ValidatePaymentData();
            void ProcessPayment(Invoice invoice);
        }
    
}
