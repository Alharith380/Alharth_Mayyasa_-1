using project.Classes;
using System.Text;

namespace project.Helpers
{
            public static class ReportBuilder
        {
            public static string BuildInvoice(Invoice invoice, string paymentType = "", string payerName = "", string phone = "", string cardNum = "", string bankNum = "", string address = "", string nationalId = "")
        {
                var sb = new StringBuilder();
            sb.AppendLine("========================================");
            sb.AppendLine("           INVOICE");
            sb.AppendLine("========================================");
            sb.AppendLine($"Invoice No: {invoice.Id}");
            sb.AppendLine($"Date: {invoice.Date:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Customer: {invoice.UserId}");

            if (!string.IsNullOrEmpty(paymentType))
            {
                sb.AppendLine($"Payment Type: {paymentType}");
                if (!string.IsNullOrEmpty(payerName))
                    sb.AppendLine($"Payer Name: {payerName}");

                // ✅ إضافة العنوان والرقم الوطني لحالة الدين
                if (paymentType == "Debt")
                {
                    if (!string.IsNullOrEmpty(address))
                        sb.AppendLine($"Address: {address}");
                    if (!string.IsNullOrEmpty(nationalId))
                        sb.AppendLine($"National ID: {nationalId}");
                }

                if (!string.IsNullOrEmpty(phone))
                    sb.AppendLine($"Phone: {phone}");
                if (!string.IsNullOrEmpty(cardNum))
                    sb.AppendLine($"Card Number: {cardNum}");
                if (!string.IsNullOrEmpty(bankNum))
                    sb.AppendLine($"Bank Account: {bankNum}");
            }
            sb.AppendLine("----------------------------------------");

                const string header = "| ID | Product       | Qty | Price   | Total   |";
                sb.AppendLine(header);
                sb.AppendLine("|----|---------------|-----|---------|---------|");

                foreach (var item in invoice.Items)
                {
                    sb.AppendLine($"| {item.Id,-2} | {item.Product,-13} | {item.Quantity,3} | {item.Price,7:F2} | {item.TotalPrice,7:F2} |");
                }

                sb.AppendLine("----------------------------------------");
                sb.AppendLine($"Subtotal: {invoice.Total,24:F2}");
                if (!string.IsNullOrEmpty(invoice.AppliedDiscountCode))
                {
                    sb.AppendLine($"Discount ({invoice.AppliedDiscountCode}): {-invoice.DiscountAmount,15:F2}");
                }
                sb.AppendLine($"TOTAL: {invoice.FinalTotal,27:F2}");
                sb.AppendLine("========================================");
                sb.AppendLine("Thank you for your purchase!");

                return sb.ToString();
            }
        }
    }
