using project.Classes.project.Classes;
using project.Repositories;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace project.Forms
{
    public partial class AddMarketers : Form
    {
        private readonly MarketerRepository _marketerRepo;
        private Marketer _selectedMarketer = null;
        private bool _isEditing = false;

        public AddMarketers()
        {
            InitializeComponent();

            _marketerRepo = new MarketerRepository();
            LoadMarketers();
        }

        private void LoadMarketers()
        {
            try
            {
                var marketers = _marketerRepo.LoadAll();
                grid_Add.DataSource = null;
                grid_Add.DataSource = marketers;

                if (grid_Add.Columns["Id"] != null)
                    grid_Add.Columns["Id"].Visible = false;
                if (grid_Add.Columns["CreatedAt"] != null)
                    grid_Add.Columns["CreatedAt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading marketers: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txt_add_firstname.Clear();
            txt_add_lastname.Clear();
            txt_add_age.Clear();
            txt_add_Phone.Clear();
            txt_add_Nat_num.Clear();
            _selectedMarketer = null;
            _isEditing = false;
            btn_Add.Text = "Add";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txt_add_firstname.Text.Trim();
                string lastName = txt_add_lastname.Text.Trim();
                string ageText = txt_add_age.Text.Trim();
                string phone = txt_add_Phone.Text.Trim();
                string natId = txt_add_Nat_num.Text.Trim();

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("First and last name are required.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int age;
                if (!int.TryParse(ageText, out age) || age < 18 || age > 65)
                {
                    MessageBox.Show("Age must be a number between 18 and 65.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(phone, @"^09\d{8}$"))
                {
                    MessageBox.Show("Phone must be: 09 followed by 8 digits.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(natId, @"^\d{11}$"))
                {
                    MessageBox.Show("National ID must be 11 digits.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var allMarketers = _marketerRepo.LoadAll();
                if (allMarketers.Any(m => m.PhoneNumber == phone && (!_isEditing || m.Id != _selectedMarketer?.Id)))
                {
                    MessageBox.Show("Phone number already exists.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (allMarketers.Any(m => m.NationalId == natId && (!_isEditing || m.Id != _selectedMarketer?.Id)))
                {
                    MessageBox.Show("National ID already exists.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Marketer marketer;
                if (_isEditing && _selectedMarketer != null)
                {
                    marketer = _selectedMarketer;
                    marketer.FirstName = firstName;
                    marketer.LastName = lastName;
                    marketer.Age = age;
                    marketer.PhoneNumber = phone;
                    marketer.NationalId = natId;
                }
                else
                {
                    marketer = new Marketer(0, firstName, lastName, age, phone, natId);
                }

                _marketerRepo.Save(marketer);
                LoadMarketers();
                ClearInputs();
                MessageBox.Show("✅ Marketer saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1.NeedToUpdateMarketers = true;
        }

        private void btn_amen_Click(object sender, EventArgs e)
        {
            if (!_isEditing)
            {
                if (grid_Add.SelectedRows.Count > 0)
                {
                    _selectedMarketer = grid_Add.SelectedRows[0].DataBoundItem as Marketer;
                    if (_selectedMarketer != null)
                    {
                        txt_add_firstname.Text = _selectedMarketer.FirstName;
                        txt_add_lastname.Text = _selectedMarketer.LastName;
                        txt_add_age.Text = _selectedMarketer.Age.ToString();
                        txt_add_Phone.Text = _selectedMarketer.PhoneNumber;
                        txt_add_Nat_num.Text = _selectedMarketer.NationalId;
                        _isEditing = true;
                        btn_Add.Text = "Update";
                    }
                }
                else
                {
                    MessageBox.Show("Please select a marketer to edit.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                btn_Add_Click(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (grid_Add.SelectedRows.Count > 0)
            {
                var selected = grid_Add.SelectedRows[0].DataBoundItem as Marketer;
                if (selected != null)
                {
                    if (MessageBox.Show(
                        $"Delete {selected.FullName}?",
                        "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _marketerRepo.Delete(selected.Id);
                        LoadMarketers();
                        ClearInputs();
                        MessageBox.Show("🗑️ Deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a marketer to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void grid_Add_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_Add.ReadOnly = true;
            foreach (DataGridViewColumn column in grid_Add.Columns)
            {
                column.ReadOnly = true;
            }
        }
    }
}
