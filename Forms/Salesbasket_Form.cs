using project.Classes;
using project.Classes.project.Classes;
using project.Repositories;
using project.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project.Forms
{
    public partial class Sales_basket : Form
    {
        private readonly InvoiceService _invoiceService;
        private readonly ProductService _productService;
        private Invoice _currentInvoice;
        private string _currentUserName = "Guest";

        public Sales_basket()
        {
            InitializeComponent();

            var productRepo = new ProductRepository();
            var invoiceRepo = new InvoiceRepository();
            _productService = new ProductService(productRepo);
            _invoiceService = new InvoiceService(invoiceRepo, productRepo);
            _currentInvoice = _invoiceService.CreateNew(_currentUserName);
            LoadProducts();
            InitializeDateTime();
            SetupDataGridView();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            string input = txt_name.Text.Trim();
            _currentUserName = string.IsNullOrEmpty(input) ? "Guest" : input;

            // Update the invoice User ID (Customer Name) immediately
            if (_currentInvoice != null)
            {
                _currentInvoice.UserId = _currentUserName;
            }
        }

        private void SetupDataGridView()
        {
            gred_show.ReadOnly = false;
            foreach (DataGridViewColumn column in gred_show.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void InitializeDateTime()
        {
            txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_data.ReadOnly = true;
            txt_tutleprice.ReadOnly = true;
        }

        private void ClearInputs()
        {
            txt_brise.Clear();
            txt_quntite.Value = 1;
            cmb_type.SelectedIndex = -1;
            cmb_broudact.Text = string.Empty;
        }

        private void LoadProducts()
        {
            cmb_type.Items.Clear();
            cmb_broudact.Items.Clear();
            var categories = _productService.GetAllCategories();
            cmb_type.Items.AddRange(categories.ToArray());
        }

        private void label_exet_Click(object sender, EventArgs e)
        {
            if (Form1.CurrentUser == Form1.UserType.User)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                start_slre str = new start_slre();
                str.ShowDialog();
                this.Close();
            }
        }

        private void txt_data_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Add_goods_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_type.Text) ||
                string.IsNullOrEmpty(cmb_broudact.Text) ||
                txt_quntite.Value <= 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                string productName = cmb_broudact.Text.Trim();
                var product = _productService.GetProductByName(productName);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                int requestedQuantity = (int)txt_quntite.Value;

                if (requestedQuantity > product.Quantity)
                {
                    MessageBox.Show($"Only {product.Quantity} items available in stock.");
                    txt_quntite.Value = product.Quantity;
                    return;
                }

                InvoiceItem existingItem = null;
                foreach (var item in _currentInvoice.Items)
                {
                    if (item.Product == productName && item.Type == cmb_type.Text.Trim())
                    {
                        existingItem = item;
                        break;
                    }
                }

                if (existingItem != null)
                {
                    int totalQuantity = existingItem.Quantity + requestedQuantity;
                    if (totalQuantity > product.Quantity)
                    {
                        MessageBox.Show($"Only {product.Quantity} items available in total.");
                        return;
                    }
                    existingItem.Quantity = totalQuantity;
                }
                else
                {
                    _invoiceService.AddItemToInvoice(
                        _currentInvoice,
                        cmb_type.Text.Trim(),
                        product.ProductName,
                        product.Price,
                        requestedQuantity
                    );
                }

                gred_show.DataSource = null;
                gred_show.DataSource = _currentInvoice.Items;
                SetupDataGridView();
                UpdateTotalPriceDisplay();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalPriceDisplay()
        {
            _invoiceService.RecalculateTotal(_currentInvoice);
            txt_tutleprice.Text = _currentInvoice.Total.ToString("0.00");

            var discount = _invoiceService.GetApplicableDiscount(_currentInvoice.Total);
            lbl_DiscountCode.Text = discount.Code ?? "No discount";
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_broudact.Items.Clear();
            if (cmb_type.SelectedItem != null)
            {
                string category = cmb_type.SelectedItem.ToString();
                var products = _productService.GetProductsByCategory(category);
                cmb_broudact.Items.AddRange(products.ToArray());
            }
        }

        private void cmb_broudact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_broudact.SelectedItem != null)
            {
                string productName = cmb_broudact.SelectedItem.ToString();
                var product = _productService.GetProductByName(productName);
                if (product != null)
                {
                    txt_brise.Text = product.Price.ToString();
                    txt_quntite.Maximum = product.Quantity;
                    txt_quntite.Value = Math.Min(txt_quntite.Value, product.Quantity);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (gred_show.SelectedRows.Count > 0)
            {
                var selectedItems = new List<InvoiceItem>();
                foreach (DataGridViewRow row in gred_show.SelectedRows)
                {
                    var item = row.DataBoundItem as InvoiceItem;
                    if (item != null)
                        selectedItems.Add(item);
                }

                if (selectedItems.Count == 0)
                {
                    MessageBox.Show("No valid items selected.");
                    return;
                }

                if (MessageBox.Show(
                    "Are you sure you want to delete the selected items?",
                    "Confirm deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in selectedItems)
                    {
                        _currentInvoice.Items.Remove(item);
                    }

                    gred_show.DataSource = null;
                    gred_show.DataSource = _currentInvoice.Items;
                    SetupDataGridView();
                    UpdateTotalPriceDisplay();

                    MessageBox.Show("!! Deleted successfully !!");
                }
            }
            else
            {
                MessageBox.Show("!! Please select item(s) to delete. !!");
            }
        }

        private void gred_show_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gred_show.Columns[e.ColumnIndex].Name == "Quantity" && e.RowIndex >= 0)
            {
                DataGridViewRow row = gred_show.Rows[e.RowIndex];
                InvoiceItem item = row.DataBoundItem as InvoiceItem;
                if (item != null)
                {
                    try
                    {
                        var product = _productService.GetProductByName(item.Product);
                        if (product == null)
                        {
                            MessageBox.Show("Product not found in inventory.");
                            row.Cells["Quantity"].Value = item.Quantity;
                            return;
                        }

                        int newQuantity;
                        if (!int.TryParse(row.Cells["Quantity"].Value?.ToString(), out newQuantity) || newQuantity <= 0)
                        {
                            MessageBox.Show("Quantity must be a positive number.");
                            row.Cells["Quantity"].Value = item.Quantity;
                            return;
                        }

                        if (newQuantity > product.Quantity)
                        {
                            MessageBox.Show($"Only {product.Quantity} items available. Cannot exceed stock.");
                            row.Cells["Quantity"].Value = product.Quantity;
                            newQuantity = product.Quantity;
                        }

                        item.Quantity = newQuantity;
                        UpdateTotalPriceDisplay();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating quantity: " + ex.Message);
                        row.Cells["Quantity"].Value = item.Quantity;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_currentInvoice.Items.Count == 0)
            {
                MessageBox.Show(
                    "Please add at least one product to the invoice before proceeding to payment.",
                    "No Products Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _invoiceService.SaveInvoice(_currentInvoice);
                MessageBox.Show($"Invoice #{_currentInvoice.Id} saved successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save invoice: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            PaymentDialog pay = new PaymentDialog(_currentInvoice, _invoiceService, _productService);
            pay.ShowDialog();
            this.Close();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "The discount code is calculated automatically based on the total amount:\n" +
                "• ≥1500 SYP → DISC12 (12%)\n" +
                "• ≥5000 SYP → DISC20 (20%)\n" +
                "• ≥7000 SYP → DISC25 (25%)\n" +
                "• ≥10000 SYP → DISC35 (35%)\n\n" +
                "Click the discount label to copy the code.",
                "Discount Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txt_quntite_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lbl_DiscountCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_DiscountCode.Text) && lbl_DiscountCode.Text != "No discount")
            {
                Clipboard.SetText(lbl_DiscountCode.Text);
                MessageBox.Show($"Discount code {lbl_DiscountCode.Text} copied to clipboard!", "Copied",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
