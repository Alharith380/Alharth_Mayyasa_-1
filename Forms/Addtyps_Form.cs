using project.Classes;
using project.Classes.project.Classes;
using project.Repositories;
using project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Forms
{
    public partial class Add_typs : Form
    {
        private Product selectedProduct = null;
        private bool isEditing = false;
        private readonly ProductService _productService;

        public Add_typs()
        {
            InitializeComponent();

            _productService = new ProductService(new ProductRepository());
            LoadCategoryComboBox();
            LoadMarketersList();
            LoadData();
        }
        private void LoadMarketersList()
        {
            Form1.NeedToUpdateMarketers = false;

            var marketerRepo = new MarketerRepository();
            var marketers = marketerRepo.LoadAll();

            var marketerNames = new List<string>();
            foreach (var marketer in marketers)
            {
                marketerNames.Add($"{marketer.FirstName} {marketer.LastName}");
            }

            txt_add_user.DataSource = marketerNames;
        }

        private void LoadCategoryComboBox()
        {
            cmb_add_name_kinds.DataSource = _productService.GetAllCategories();
        }

        private void ClearInputs()
        {
            txt_add_user.Text = "";
            cmb_add_name_kinds.Text = "";
            txt_add_name_goods.Clear();
            txt_add_brice.Clear();
            txt_add_amounts.Clear();
            txt_add_cost_prise.Clear();
            selectedProduct = null;
            isEditing = false;
        }

        private void LoadData()
        {
            grid_Add.DataSource = null;
            grid_Add.DataSource = _productService.GetAllProducts();
            if (grid_Add.Columns["Id"] != null)
                grid_Add.Columns["Id"].ReadOnly = true;
            if (grid_Add.Columns["CreatedAt"] != null)
                grid_Add.Columns["CreatedAt"].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_add_name_kinds.Text) ||
                string.IsNullOrEmpty(txt_add_name_goods.Text) ||
                string.IsNullOrEmpty(txt_add_brice.Text) ||
                string.IsNullOrEmpty(txt_add_amounts.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                string selectedMarketer = txt_add_user.Text.Trim();

                if (string.IsNullOrEmpty(selectedMarketer))
                {
                    MessageBox.Show("Please select a marketer from the list.", "Validation Error");
                    return;
                }

                // التحقق من وجود المسوق فعليًا
                var marketerRepo = new MarketerRepository();
                var allMarketers = marketerRepo.LoadAll();
                bool isValidMarketer = allMarketers.Any(m =>
                    $"{m.FirstName} {m.LastName}" == selectedMarketer);

                if (!isValidMarketer)
                {
                    MessageBox.Show("Invalid marketer selected. Please choose from the list.", "Validation Error");
                    return;
                }

                string username = selectedMarketer; // استخدام الاسم المختار
                string category = cmb_add_name_kinds.Text.Trim();
                string productName = txt_add_name_goods.Text.Trim();
                int price = Convert.ToInt32(txt_add_brice.Text);
                int quantity = Convert.ToInt32(txt_add_amounts.Text);
                int costPrice = string.IsNullOrEmpty(txt_add_cost_prise.Text)
                    ? 0 : Convert.ToInt32(txt_add_cost_prise.Text);

                var existingProduct = _productService.GetProductByName(productName);

                if (existingProduct != null && selectedProduct == null)
                {
                    var result = MessageBox.Show(
                        "The product already exists.\nDo you want to:\n\nYes = Replace the existing values\nNo = Only increase quantity\nCancel = Do nothing",
                        "Product already exists",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        existingProduct.Username = username;
                        existingProduct.CategoryName = category;
                        existingProduct.ProductName = productName;
                        existingProduct.Price = price;
                        existingProduct.Quantity = quantity;
                        existingProduct.CostPrice = costPrice;
                        _productService.AddOrUpdateProduct(existingProduct);
                    }
                    else if (result == DialogResult.No)
                    {
                        existingProduct.Quantity += quantity;
                        _productService.AddOrUpdateProduct(existingProduct);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    var product = new Product(0, username, category, productName, price, quantity, costPrice);
                    _productService.AddOrUpdateProduct(product);
                }

                LoadData();
                LoadCategoryComboBox(); // ✅ تحديث الكومبو بوكس فورًا
                ClearInputs();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in the price and quantity fields.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (grid_Add.SelectedRows.Count > 0)
            {
                var selectedProducts = new System.Collections.Generic.List<Product>();
                foreach (DataGridViewRow row in grid_Add.SelectedRows)
                {
                    var p = row.DataBoundItem as Product;
                    if (p != null)
                        selectedProducts.Add(p);
                }

                if (selectedProducts.Count == 0)
                {
                    MessageBox.Show("⚠️ No valid products selected.");
                    return;
                }

                if (MessageBox.Show(
                    "Are you sure you want to delete the selected products?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _productService.DeleteProducts(selectedProducts);
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("🗑️ Deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("⚠️ Please select product(s) to delete.");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Form1.CurrentUser == Form1.UserType.Marketer)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                start_slre start = new start_slre();
                start.ShowDialog();
                this.Close();
            }
        }

        private void txt_add_amounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btn_amen_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (grid_Add.SelectedRows.Count > 0)
                {
                    selectedProduct = grid_Add.SelectedRows[0].DataBoundItem as Product;
                    if (selectedProduct != null)
                    {
                        txt_add_user.Text = selectedProduct.Username;
                        cmb_add_name_kinds.Text = selectedProduct.CategoryName;
                        txt_add_name_goods.Text = selectedProduct.ProductName;
                        txt_add_brice.Text = selectedProduct.Price.ToString();
                        txt_add_amounts.Text = selectedProduct.Quantity.ToString();
                        txt_add_cost_prise.Text = selectedProduct.CostPrice.ToString();
                        isEditing = true;
                    }
                    else
                    {
                        MessageBox.Show("‼️ Invalid product selected.");
                    }
                }
                else
                {
                    MessageBox.Show("‼️ Please select a product to edit.");
                }
            }
            else
            {
                try
                {
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("Error: No product to update.");
                        return;
                    }

                    selectedProduct.Username = txt_add_user.Text.Trim();
                    selectedProduct.CategoryName = cmb_add_name_kinds.Text.Trim();
                    selectedProduct.ProductName = txt_add_name_goods.Text.Trim();
                    selectedProduct.Price = int.Parse(txt_add_brice.Text);
                    selectedProduct.Quantity = int.Parse(txt_add_amounts.Text);
                    selectedProduct.CostPrice = int.Parse(txt_add_cost_prise.Text);

                    _productService.AddOrUpdateProduct(selectedProduct);
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("📝 Product updated successfully!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("❌ Please enter valid numbers.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }

        private void grid_Add_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_Add.ReadOnly = true;
            foreach (DataGridViewColumn column in grid_Add.Columns)
            {
                column.ReadOnly = true;
            }


        }
    }
}