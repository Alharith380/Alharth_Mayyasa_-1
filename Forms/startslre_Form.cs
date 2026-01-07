using project.Classes;
using project.Classes.project.Classes;
using project.Repositories;
using project.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project.Forms
{
    public partial class start_slre : Form
    {
        private readonly ProductService _productService;
            private readonly InvoiceService _invoiceService;
        
        public start_slre()
        {
            InitializeComponent();
          
                var productRepo = new ProductRepository();
                var invoiceRepo = new InvoiceRepository();
                _productService = new ProductService(productRepo);
                _invoiceService = new InvoiceService(invoiceRepo, productRepo);
                UpdateStatistics();
            }

            private void UpdateStatistics()
            {
                try
                {
                    // ✅ عدد التصنيفات
                    var categories = _productService.GetAllCategories();
                    label_kindsnum.Text = categories.Count.ToString();

                    // ✅ إجمالي الكمية في المخزون
                    var allProducts = _productService.GetAllProducts();
                    int totalQuantity = 0;
                    foreach (var p in allProducts)
                    {
                        totalQuantity += p.Quantity;
                    }
                    lable_numgoods.Text = totalQuantity.ToString();

                    // ✅ عدد المستخدمين الفريدين (الذين أدخلوا منتجات)
                    var uniqueUsers = new HashSet<string>();
                    foreach (var p in allProducts)
                    {
                        if (!string.IsNullOrEmpty(p.Username))
                            uniqueUsers.Add(p.Username);
                    }
                    lable_numuser.Text = uniqueUsers.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading statistics: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void Add_Click(object sender, EventArgs e)
            {
                this.Hide();
                var re = new ReportsForm();
                re.ShowDialog();
                this.Show();
            }

            private void label_exet_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                  var add = new Add_typs();
                   add.ShowDialog();
                UpdateStatistics(); // ✅ تحديث الإحصائيات بعد العودة
                this.Show();
            }

            private void Viewcart_Click(object sender, EventArgs e)
            {
                this.Hide();
                var sale = new Sales_basket();
                sale.ShowDialog();
                this.Show();
            }

            private void SigOut_Click_1(object sender, EventArgs e)
            {
                var res = MessageBox.Show(
                    "Do You Want To Close The Application?",
                    "Exit",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            private void btn_log_in_Click(object sender, EventArgs e)
            {
                this.Hide();
                var mark = new AddMarketers();
                mark.ShowDialog();
                UpdateStatistics(); // ✅ تحديث الإحصائيات
                this.Show();
            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                this.Hide();
                var bild = new Billing__History();
                bild.ShowDialog();
                this.Show();
            }
        }
    }