using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Classes
{
    public class InvoiceSummary
    {
        public int InvoiceNumber { get; set; }
        public string Username { get; set; }
        public string PaymentType { get; set; }
        public Invoice FullInvoice { get; set; }
    }
}