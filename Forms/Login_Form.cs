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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static project.Forms.Form1;

namespace project.Forms
{
    
    public partial class Form1 : Form
    {
        public static bool NeedToUpdateMarketers = false;
        public static UserType CurrentUser;
        public Form1()
        {
            InitializeComponent();

          try
                {
                    var productRepo = new ProductRepository();
                    var productService = new ProductService(productRepo);
                    productService.InitializeDefaultData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error initializing data: " + ex.Message, "Startup Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void log_in_Click(object sender, EventArgs e)
            {
                string username = txt_username.Text.Trim();
                string password = txt_passowrd.Text.Trim();

                if (username == "User" && password == "user@user")
                {
                    CurrentUser = UserType.User;
                    this.Hide();
                    Sales_basket start = new Sales_basket();
                    start.ShowDialog();
                    this.Close();
                }
                else if (username == "Admin" && password == "admin@admin")
                {
                    CurrentUser = UserType.Admin;
                    this.Hide();
                    start_slre start = new start_slre();
                    start.ShowDialog();
                    this.Close();
                }
                else if (username == "Marketer" && password == "mark@mark")
                {
                    CurrentUser = UserType.Marketer;
                    this.Hide();
                    var productRepo = new ProductRepository();
                    Add_typs start = new Add_typs();
                      start.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "اسم المستخدم أو كلمة المرور غير صحيحة",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            private void button_help_Click(object sender, EventArgs e)
            {
                MessageBox.Show(
                    "LogIn With:\n" +
                    "• Admin → Username: Admin | Password: admin@admin\n" +
                    "• User  → Username: User  | Password: user@user\n" +
                    "• Marketer → Username: Marketer | Password: mark@mark",
                    "Login Help",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            private void label3_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            // ✅ الحدثان الفارغان (لإصلاح خطأ الـ Designer)
            private void textBox_username_TextChanged(object sender, EventArgs e) { }
            private void textBox_password_TextChanged(object sender, EventArgs e) { }

            // ✅ تعريف enum داخل Form1 كما في الأصلي
            public enum UserType
            {
                User,
                Admin,
                Marketer
            }
       
    }
    }