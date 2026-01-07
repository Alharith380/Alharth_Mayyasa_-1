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
    public partial class DetailsForm : Form
    {
        public DetailsForm(string title, object data)
        {
            InitializeComponent();
     
                this.Text = title;
                LoadData(data);
            }

            private void LoadData(object data)
            {
                try
                {
                    if (data == null)
                    {
                        MessageBox.Show("No data to display.", "Empty",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    gridDetails.DataSource = data;

                    foreach (DataGridViewColumn col in gridDetails.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void label_exet_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void gridDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridDetails.ReadOnly = true;
            foreach (DataGridViewColumn column in gridDetails.Columns)
            {
                column.ReadOnly = true;
            }
        }
    }
    }
