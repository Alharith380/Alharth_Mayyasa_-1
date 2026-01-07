using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
using project.Classes;
using project.Services;
using project.Helpers;

namespace project.Forms
{
   
        public partial class PaymentDialog : Form
        {
       
            private readonly Invoice _invoice;
            private readonly InvoiceService _invoiceService;
            private readonly ProductService _productService; 
            private PrintDocument _printDocument;
            private string _reportText;
            private bool _isPaymentValid = false;
            private bool _isPaymentConfirmed = false;

            // ✅ الـ Constructor الصحيح بـ 3 معلمات
            public PaymentDialog(Invoice invoice, InvoiceService invoiceService, ProductService productService)
            {
                 InitializeComponent();

                if (invoice == null)
                    throw new ArgumentNullException(nameof(invoice));
                if (invoiceService == null)
                    throw new ArgumentNullException(nameof(invoiceService));
                if (productService == null) // ← productService موجود الآن
                    throw new ArgumentNullException(nameof(productService));

                _invoice = invoice;
                _invoiceService = invoiceService;
                _productService = productService; // ← تعيين القيمة

                LoadInvoiceData();
                SetupPrintDocument();
                InitializeConfirmButton();
            }

              private void btn_ConfirmPayment_Click(object sender, EventArgs e)
            {
                if (!_isPaymentValid)
                {
                    MessageBox.Show("Please complete and verify payment information first.", "Incomplete Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    foreach (var item in _invoice.Items)
                    {
                        var product = _productService.GetProductByName(item.Product); // ← صحيح
                        if (product == null)
                        {
                            MessageBox.Show($"Product '{item.Product}' not found.");
                            return;
                        }
                        if (product.Quantity < item.Quantity)
                        {
                            MessageBox.Show($"Not enough stock for '{item.Product}'. Available: {product.Quantity}");
                            return;
                        }
                    }

                    foreach (var item in _invoice.Items)
                    {
                        var product = _productService.GetProductByName(item.Product); // ← صحيح
                        product.Quantity -= item.Quantity;
                        _productService.AddOrUpdateProduct(product); // ← صحيح
                    }

                    _isPaymentConfirmed = true;
                    MessageBox.Show("✅ Payment confirmed! Stock updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
            string paymentType = rbCash.Checked ? "Cash" : "Debt";
            string payerName = rbCash.Checked
                ? txt_name_cash.Text.Trim()
                : txt_name_debt.Text.Trim();
            string payerAddress = rbDebt.Checked ? txt_adric.Text.Trim() : "";
            string payernatunal = rbDebt.Checked ? txt_ntunalnam.Text.Trim() : "";
            string payerPhone = rbDebt.Checked ? txt_phonnum.Text.Trim() : "";
           

            _invoice.SetPaymentInfo(paymentType, payerName, payerAddress, payernatunal, payerPhone);
            _invoiceService.SaveInvoice(_invoice); 
        }


            private void SetupPrintDocument()
            {
                _printDocument = new PrintDocument();
                _printDocument.PrintPage += PrintDocument_PrintPage;
            }

            private void InitializeConfirmButton()
            {
                var confirmButton = new Button
                {
                    Name = "btn_ConfirmPayment",
                    Text = "Confirm Payment",
                    Location = new System.Drawing.Point(20, 400),
                    Size = new System.Drawing.Size(120, 30),
                    TabIndex = 10
                };
                confirmButton.Click += btn_ConfirmPayment_Click;

                var existingButton = this.Controls.Find("btn_ConfirmPayment", true);
                if (existingButton.Length == 0)
                {
                    this.Controls.Add(confirmButton);
                }
            }
    private void LoadInvoiceData()
            {
                grid_Items.DataSource = null;
                grid_Items.DataSource = _invoice.Items;
                grid_Items.ReadOnly = true;

                txt_tutleprice_ksm.Text = _invoice.FinalTotal.ToString("0.00");
                txt_iconnumber.Text = _invoice.Id.ToString();

                lbl_discount_applied.Text = string.IsNullOrEmpty(_invoice.AppliedDiscountCode)
                    ? ""
                    : $"Discount: {_invoice.AppliedDiscountCode} (-{_invoice.DiscountAmount:0.00})";
            }

            private void rbCash_CheckedChanged(object sender, EventArgs e)
            {
                groupBoxCash.Visible = rbCash.Checked;
                groupBoxDebt.Visible = !rbCash.Checked;
            }

            private void rbDebt_CheckedChanged(object sender, EventArgs e)
            {
                groupBoxDebt.Visible = rbDebt.Checked;
                groupBoxCash.Visible = !rbDebt.Checked;
            }

            private void PaymentDialog_Load(object sender, EventArgs e)
            {
                groupBoxCash.Visible = false;
                groupBoxDebt.Visible = false;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (rbCash.Checked)
                    {
                        string name = txt_name_cash.Text.Trim();
                        string cardNum = txt_criditnum.Text.Trim();
                        string bankNum = txt_banknum.Text.Trim();

                        if (string.IsNullOrEmpty(name) || !System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L} ]+$"))
                        {
                            MessageBox.Show("Please enter a valid name using letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (cardNum.Length < 10 || !System.Text.RegularExpressions.Regex.IsMatch(cardNum, @"^\d+$"))
                        {
                            MessageBox.Show("Card number must be at least 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (bankNum.Length < 8 || !System.Text.RegularExpressions.Regex.IsMatch(bankNum, @"^\d+$"))
                        {
                            MessageBox.Show("Bank account number must be at least 8 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else if (rbDebt.Checked)
                    {
                        string phone = txt_phonnum.Text.Trim();
                        string natId = txt_ntunalnam.Text.Trim();

                        if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^09\d{8}$"))
                        {
                            MessageBox.Show("Phone must start with 09 followed by 8 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!System.Text.RegularExpressions.Regex.IsMatch(natId, @"^\d{10,11}$"))
                        {
                            MessageBox.Show("National ID must be 10 or 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    _isPaymentValid = true;
                    MessageBox.Show("✅ Payment information verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Validation error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                string code = txt_DiscountCode.Text.Trim();
                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("Please enter a discount code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _invoiceService.ApplyDiscount(_invoice, code);
                    _invoiceService.SaveInvoice(_invoice);
                    txt_tutleprice_ksm.Text = _invoice.FinalTotal.ToString("0.00");
                    MessageBox.Show("Discount applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

         

            private void btn_Print_Click(object sender, EventArgs e)
            {
        
            if (!_isPaymentConfirmed)
            {
                MessageBox.Show("Please confirm payment before printing.", "Payment Not Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string paymentType = rbCash.Checked ? "Cash" : "Debt";
                string payerName = rbCash.Checked
                    ? txt_name_cash.Text.Trim()
                    : txt_name_debt.Text.Trim(); // ← تأكد من اسم الحقل
                string phone = rbDebt.Checked ? txt_phonnum.Text : "";
                string cardNum = rbCash.Checked ? txt_criditnum.Text : "";
                string bankNum = rbCash.Checked ? txt_banknum.Text : "";

                // ✅ جلب العنوان والرقم الوطني لحالة الدين
                string address = rbDebt.Checked ? txt_adric.Text.Trim() : "";
                string nationalId = rbDebt.Checked ? txt_ntunalnam.Text.Trim() : "";

                _reportText = ReportBuilder.BuildInvoice(
                    _invoice,
                    paymentType,
                    payerName,
                    phone,
                    cardNum,
                    bankNum,
                    address,          // ← معطى جديد
                    nationalId        // ← معطى جديد
                );

                using (var pd = new PrintDialog())
                {
                    pd.Document = _printDocument;
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        _printDocument.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Printing error: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

            private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
            {
                if (string.IsNullOrEmpty(_reportText)) return;
                var font = new Font("Courier New", 10);
                float x = 20, y = 20;
                float lineHeight = font.GetHeight(e.Graphics);
                var lines = _reportText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                    y += lineHeight;
                    if (y + lineHeight > e.PageBounds.Height - 50)
                    {
                        e.HasMorePages = true;
                        break;
                    }
                }
            }

            private void label_exet_Click(object sender, EventArgs e)
            {
                this.Hide();
                var form = new Sales_basket();
                form.ShowDialog();
                this.Close();
            }

            private void grid_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            grid_Items.ReadOnly = true;
            foreach (DataGridViewColumn column in grid_Items.Columns)
            {
                column.ReadOnly = true;
            }
        }

       
    }
    }