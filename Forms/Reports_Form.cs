using System;
using System.Collections.Generic;
using System.Windows.Forms;
using project.Services;
using project.Repositories;
using project.Classes;
using project.Classes.project.Classes;

namespace project.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ProductService _productService;
            private readonly InvoiceService _invoiceService;

        public ReportsForm()
        {
            InitializeComponent();
         
                _productService = new ProductService(new ProductRepository());
                _invoiceService = new InvoiceService(new InvoiceRepository(), new ProductRepository());
                LoadStatistics();
            }

            private void ShowDetails(string title, object data)
            {
                using (var detailForm = new DetailsForm(title, data))
                {
                    detailForm.ShowDialog();
                }
            }

            private void LoadStatistics()
            {
                try
                {
                    var allInvoices = _invoiceService.GetAllInvoices();
                    var allProducts = _productService.GetAllProducts();

                    // 1. أفضل المنتجات مبيعًا
                    var bestSelling = GetBestSellingProducts(allInvoices);
                    lable_prodectbig_sell.Text = bestSelling.Count.ToString();

                    // 2. المستخدمون الأكثر إضافة
                    var topUsers = GetMostAddedUsers(allProducts);
                    lable_most_user.Text = topUsers.Count.ToString();

                    // 3. عدد المنتجات المباعة (إجمالي الكمية)
                    int totalSold = 0;
                    foreach (var inv in allInvoices)
                    {
                        foreach (var item in inv.Items)
                        {
                            totalSold += item.Quantity;
                        }
                    }
                    lable_prodact_solld.Text = totalSold.ToString();

                    // 4. إجمالي الأرباح
                    var totalProfit = CalculateTotalProfit(allInvoices, allProducts);
                    label_profit.Text = totalProfit.ToString("0.00");

                    // 5. إجمالي المنتجات في النظام
                    label_qountite_intyps.Text = allProducts.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading  " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private List<BestSellingProduct> GetBestSellingProducts(List<Invoice> invoices)
            {
                var sales = new Dictionary<string, int>();

                foreach (var inv in invoices)
                {
                    foreach (var item in inv.Items)
                    {
                        if (sales.ContainsKey(item.Product))
                            sales[item.Product] += item.Quantity;
                        else
                            sales[item.Product] = item.Quantity;
                    }
                }

                var result = new List<BestSellingProduct>();
                foreach (var kvp in sales)
                {
                    result.Add(new BestSellingProduct(kvp.Key, kvp.Value));
                }
                result.Sort((x, y) => y.QuantitySold.CompareTo(x.QuantitySold));
                return result;
            }

            private List<UserProductStats> GetMostAddedUsers(List<Product> products)
            {
                var userCounts = new Dictionary<string, int>();

                foreach (var p in products)
                {
                    if (string.IsNullOrEmpty(p.Username)) continue;
                    if (userCounts.ContainsKey(p.Username))
                        userCounts[p.Username]++;
                    else
                        userCounts[p.Username] = 1;
                }

                var result = new List<UserProductStats>();
                foreach (var kvp in userCounts)
                {
                    result.Add(new UserProductStats(kvp.Key, kvp.Value));
                }
                result.Sort((x, y) => y.ProductCount.CompareTo(x.ProductCount));
                if (result.Count > 5)
                    result = result.GetRange(0, 5);
                return result;
            }

        private decimal CalculateTotalProfit(List<Invoice> invoices, List<Product> products)
        {
            decimal totalProfit = 0;
            var productMap = new Dictionary<string, Product>();
            foreach (Product p in products)
            {
                productMap[p.ProductName] = p;
            }

            foreach (Invoice inv in invoices)
            {
                foreach (InvoiceItem item in inv.Items)
                {
                    Product product;
                    if (productMap.TryGetValue(item.Product, out product))
                    {
                        decimal profitPerItem = item.Price - product.CostPrice;
                        totalProfit += profitPerItem * item.Quantity;
                    }
                }
            }
            return totalProfit;
        }

        private List<ProfitDetail> GetProfitDetails(List<Invoice> invoices, List<Product> products)
        {
            var productMap = new Dictionary<string, Product>();
            foreach (Product p in products)
            {
                productMap[p.ProductName] = p;
            }

            var details = new List<ProfitDetail>();
            foreach (Invoice inv in invoices)
            {
                foreach (InvoiceItem item in inv.Items)
                {
                    Product product;
                    if (productMap.TryGetValue(item.Product, out product))
                    {
                        decimal profit = (item.Price - product.CostPrice) * item.Quantity;
                        details.Add(new ProfitDetail(
                            product.ProductName,
                            product.CostPrice,
                            item.Price,
                            item.Quantity,
                            profit
                        ));
                    }
                }
            }
            return details;
        }
        private void button2_Click(object sender, EventArgs e)
            {
                var invoices = _invoiceService.GetAllInvoices();
                var data = GetBestSellingProducts(invoices);
                ShowDetails("Best Selling Products", data);
            }

            private void button4_Click(object sender, EventArgs e)
            {
                var invoices = _invoiceService.GetAllInvoices();
                var productSales = new System.Collections.Generic.List<dynamic>();

                var sales = new Dictionary<string, int>();
                foreach (var inv in invoices)
                {
                    foreach (var item in inv.Items)
                    {
                        if (sales.ContainsKey(item.Product))
                            sales[item.Product] += item.Quantity;
                        else
                            sales[item.Product] = item.Quantity;
                    }
                }

                foreach (var kvp in sales)
                {
                    productSales.Add(new { Product_name = kvp.Key, Quantity_sold = kvp.Value });
                }

                ShowDetails("Details of products sold", productSales);
            }

            private void button3_Click(object sender, EventArgs e)
            {
                var products = _productService.GetAllProducts();
                var data = GetMostAddedUsers(products);
                ShowDetails("Most Added Users", data);
            }

            private void btn_log_in_Click(object sender, EventArgs e)
            {
                var invoices = _invoiceService.GetAllInvoices();
                var products = _productService.GetAllProducts();
                var data = GetProfitDetails(invoices, products);
                ShowDetails("Earnings details", data);
            }

            private void button1_Click(object sender, EventArgs e)
            {
                var products = _productService.GetAllProducts();
                ShowDetails("Quantities in Each Item", products);
            }

            private void label_exet_Click(object sender, EventArgs e)
            {
                this.Hide();
                start_slre str = new start_slre();
                str.ShowDialog();
                this.Close();
            }

            // ✅ كلاسات مساعدة للتقارير (بداخل الملف)
            public class BestSellingProduct
            {
                public string ProductName { get; set; }
                public int QuantitySold { get; set; }

                public BestSellingProduct(string name, int qty)
                {
                    ProductName = name;
                    QuantitySold = qty;
                }
            }

            public class UserProductStats
            {
                public string Username { get; set; }
                public int ProductCount { get; set; }

                public UserProductStats(string user, int count)
                {
                    Username = user;
                    ProductCount = count;
                }
            }

            public class ProfitDetail
            {
                public string ProductName { get; set; }
                public decimal CostPrice { get; set; }
                public decimal SoldPrice { get; set; }
                public int Quantity { get; set; }
                public decimal Profit { get; set; }

                public ProfitDetail(string name, decimal cost, decimal sold, int qty, decimal profit)
                {
                    ProductName = name;
                    CostPrice = cost;
                    SoldPrice = sold;
                    Quantity = qty;
                    Profit = profit;
                }
            }
        }
    }