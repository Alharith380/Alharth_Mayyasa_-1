using project.Classes;
using project.Helpers;
using project.Repositories;
using project.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Linq;

namespace project.Forms
{
    public partial class Billing__History : Form
    {
        private List<InvoiceSummary> _invoiceSummaries;
        private List<InvoiceSummary> _currentInvoices;
        private string _currentReportText;
        private Invoice _selectedInvoice;

        public Billing__History()
        {
            InitializeComponent();
            SetupInvoicesGrid();
            SetupItemsGrid();
            LoadInvoices();
            gridInvoices.CellClick += gridInvoices_CellClick;
            btn_searth.Click += txt_searth_Click;
            btn_print.Click += (s, e) => PrintInvoice();
        }

        //=================================== تصميم القائمة اليسرى =======================================
        private void SetupInvoicesGrid()
        {
            gridInvoices.AutoGenerateColumns = false;
            gridInvoices.Columns.Clear();

            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 0, 64),
                ForeColor = Color.White,
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            var cellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Tahoma", 9),
                SelectionBackColor = Color.LightBlue,
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            gridInvoices.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            gridInvoices.RowsDefaultCellStyle.BackColor = Color.White;
            gridInvoices.BorderStyle = BorderStyle.FixedSingle;
            gridInvoices.GridColor = Color.LightGray;
            gridInvoices.BackgroundColor = Color.White;

            gridInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colInvoice",
                HeaderText = "Invoice",
                DataPropertyName = "InvoiceNumber",
                Width = 80,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = cellStyle
            });

            gridInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Name",
                DataPropertyName = "Username",
                Width = 120,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = cellStyle
            });

            gridInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPayment",
                HeaderText = "Payment",
                DataPropertyName = "PaymentType",
                Width = 90,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = cellStyle
            });

            gridInvoices.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == 0 && e.Value != null)
                {
                    e.Value = "#" + e.Value.ToString();
                }
            };
        }

        //==================================== تصميم القائمة السفلية اليمنى =======================================
        private void SetupItemsGrid()
        {
            grid_rghit.AutoGenerateColumns = false;
            grid_rghit.Columns.Clear();

            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 0, 64),
                ForeColor = Color.White,
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            var baseCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Tahoma", 9, FontStyle.Bold),
                SelectionBackColor = Color.LightBlue,
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            grid_rghit.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            grid_rghit.RowsDefaultCellStyle.BackColor = Color.White;
            grid_rghit.BorderStyle = BorderStyle.FixedSingle;
            grid_rghit.GridColor = Color.LightGray;
            grid_rghit.BackgroundColor = Color.White;

            grid_rghit.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 40,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = baseCellStyle
            });

            grid_rghit.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                HeaderText = "Category",
                DataPropertyName = "Type",
                Width = 100,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = baseCellStyle
            });

            grid_rghit.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProduct",
                HeaderText = "Product",
                DataPropertyName = "Product",
                Width = 110,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = baseCellStyle
            });

            var priceColumn = new DataGridViewTextBoxColumn
            {
                Name = "colPrice",
                HeaderText = "Unit Price",
                DataPropertyName = "Price",
                Width = 100,
                HeaderCell = { Style = headerStyle }
            };
            priceColumn.DefaultCellStyle = new DataGridViewCellStyle(baseCellStyle)
            {
                Format = "C2"
            };
            grid_rghit.Columns.Add(priceColumn);

            grid_rghit.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQty",
                HeaderText = "Qty",
                DataPropertyName = "Quantity",
                Width = 80,
                HeaderCell = { Style = headerStyle },
                DefaultCellStyle = baseCellStyle
            });

            var totalColumn = new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Total",
                DataPropertyName = "TotalPrice",
                Width = 100,
                HeaderCell = { Style = headerStyle }
            };
            totalColumn.DefaultCellStyle = new DataGridViewCellStyle(baseCellStyle)
            {
                Format = "C2",
                Font = new Font("Tahoma", 9, FontStyle.Bold),
                ForeColor = Color.Black
            };
            grid_rghit.Columns.Add(totalColumn);
        }

        //==================================== تحميل الفواتير =======================================
        private void LoadInvoices()
        {
            try
            {
                var invoiceRepo = new InvoiceRepository();
                var allInvoices = invoiceRepo.LoadAll();

                _invoiceSummaries = new List<InvoiceSummary>();
                foreach (var invoice in allInvoices)
                {
                    _invoiceSummaries.Add(new InvoiceSummary
                    {
                        InvoiceNumber = invoice.Id,
                        Username = invoice.UserId ?? "Guest",
                        PaymentType = invoice.PaymentType ?? "Unknown",
                         FullInvoice = invoice
                    });
                }

                _currentInvoices = new List<InvoiceSummary>(_invoiceSummaries);
                DisplayInvoices(_currentInvoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoices: {ex.Message}");
            }
        }

        private void DisplayInvoices(List<InvoiceSummary> invoices)
        {
            gridInvoices.DataSource = null;
            gridInvoices.DataSource = invoices;
            ApplyInvoicesGridStyle();
        }

        private void DisplayInvoiceDetails(Invoice invoice)
        {
            try
            {
                lblInvoiceNumberValue.Text = invoice.Id.ToString();
                lblUserValue.Text = invoice.UserId ?? "Guest";
                lblDateValue.Text = invoice.Date.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                lblDiscountValue.Text = invoice.DiscountAmount.ToString("0.00");
                lblSubtotalValue.Text = invoice.Total.ToString("0.00");
                lblTotalValue.Text = invoice.FinalTotal.ToString("0.00");
                label2.Text = invoice.PaymentType ?? "Unknown";

                grid_rghit.DataSource = null;
                grid_rghit.DataSource = invoice.Items;
                ApplyItemsGridStyle();

                // حفظ الفاتورة المختارة للطباعة
                _selectedInvoice = invoice;
                _currentReportText = ReportBuilder.BuildInvoice(
                    invoice,
                    invoice.PaymentType,
                    invoice.PayerName,
                    invoice.PayerPhone,
                    "", 
                    "",  
                    invoice.PayerAddress,
                    invoice.PayerNatunal
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying invoice: {ex.Message}");
            }
        }

        private void gridInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _currentInvoices == null || e.RowIndex >= _currentInvoices.Count)
                return;

            var selectedSummary = _currentInvoices[e.RowIndex];
            if (selectedSummary?.FullInvoice != null)
            {
                DisplayInvoiceDetails(selectedSummary.FullInvoice);
            }
        }

        //=================================== وظيفة البحث =======================================
        private void txt_searth_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                _currentInvoices = new List<InvoiceSummary>(_invoiceSummaries);
                DisplayInvoices(_currentInvoices);
                return;
            }

            var filtered = _invoiceSummaries.Where(invoice =>
                invoice.InvoiceNumber.ToString().IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                invoice.Username.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                invoice.PaymentType.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                invoice.FullInvoice.Date.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
                    .IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            _currentInvoices = filtered;
            DisplayInvoices(_currentInvoices);

            if (filtered.Count == 0)
            {
                MessageBox.Show("No invoices found matching your search.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //=================================== تطبيق تنسيقات الجدول اليساري =======================================
        private void ApplyInvoicesGridStyle()
        {
            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 0, 64),
                ForeColor = Color.White,
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            foreach (DataGridViewColumn col in gridInvoices.Columns)
            {
                col.HeaderCell.Style = headerStyle;
            }

            gridInvoices.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            gridInvoices.RowsDefaultCellStyle.BackColor = Color.White;
            gridInvoices.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            gridInvoices.BorderStyle = BorderStyle.FixedSingle;
            gridInvoices.GridColor = Color.LightGray;
            gridInvoices.BackgroundColor = Color.White;
        }

        //=================================== تطبيق تنسيقات الجدول الأيمن السفلي =======================================

        private void ApplyItemsGridStyle()
        {
            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 0, 64),
                ForeColor = Color.White,
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            foreach (DataGridViewColumn col in grid_rghit.Columns)
            {
                col.HeaderCell.Style = headerStyle;
            }

            grid_rghit.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            grid_rghit.RowsDefaultCellStyle.BackColor = Color.White;
            grid_rghit.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            grid_rghit.BorderStyle = BorderStyle.FixedSingle;
            grid_rghit.GridColor = Color.LightGray;
            grid_rghit.BackgroundColor = Color.White;
        }

        //=================================== وظيفة الطباعة =======================================
        private void PrintInvoice()
        {
            if (string.IsNullOrEmpty(_currentReportText))
            {
                MessageBox.Show("No invoice selected to print.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (PrintDocument printDoc = new PrintDocument())
            {
                printDoc.PrintPage += (sender, e) =>
                {
                    Font printFont = new Font("Courier New", 10);
                    float lineHeight = printFont.GetHeight(e.Graphics);
                    float x = e.MarginBounds.Left;
                    float y = e.MarginBounds.Top;
                    int lineCount = 0;

                    string[] lines = _currentReportText.Split('\n');

                    foreach (string line in lines)
                    {
                        if (y + lineHeight > e.MarginBounds.Bottom)
                        {
                            e.HasMorePages = true;
                            break;
                        }

                        e.Graphics.DrawString(line.TrimEnd(), printFont, Brushes.Black, x, y);
                        y += lineHeight;
                        lineCount++;
                    }

                    if (e.HasMorePages)
                    {
                        _currentReportText = string.Join("\n", lines.Skip(lineCount));
                    }
                };

                using (PrintPreviewDialog previewDlg = new PrintPreviewDialog())
                {
                    previewDlg.Document = printDoc;
                    previewDlg.ShowDialog();
                }
            }

            // إعادة تعيين النص بعد الطباعة
            if (_selectedInvoice != null)
            {
                _currentReportText = ReportBuilder.BuildInvoice(
                    _selectedInvoice,
                    _selectedInvoice.PaymentType,
                    _selectedInvoice.PayerName,
                    _selectedInvoice.PayerPhone,
                    "",
                    "",
                    _selectedInvoice.PayerAddress,
                    _selectedInvoice.PayerNatunal
                );
            }
        }

        private void label_exet_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new start_slre();
            form.ShowDialog();
            this.Close();
        }

        private void grid_rghit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_rghit.ReadOnly = true;
            foreach (DataGridViewColumn column in grid_rghit.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void gridInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridInvoices.ReadOnly = true;
            foreach (DataGridViewColumn column in gridInvoices.Columns)
            {
                column.ReadOnly = true;
            }
        }
    }
}