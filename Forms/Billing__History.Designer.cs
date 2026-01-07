namespace project.Forms
{
    partial class Billing__History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridInvoices = new System.Windows.Forms.DataGridView();
            this.btn_searth = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblUserValue = new System.Windows.Forms.Label();
            this.lblInvoiceNumberValue = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grid_rghit = new System.Windows.Forms.DataGridView();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblInvoiceNumberTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_exet = new System.Windows.Forms.Label();
            this.label_Hello = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoices)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rghit)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btn_print);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 658);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1136, 71);
            this.panel4.TabIndex = 32;
            // 
            // gridInvoices
            // 
            this.gridInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridInvoices.BackgroundColor = System.Drawing.Color.White;
            this.gridInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridInvoices.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridInvoices.GridColor = System.Drawing.Color.Thistle;
            this.gridInvoices.Location = new System.Drawing.Point(9, 169);
            this.gridInvoices.Name = "gridInvoices";
            this.gridInvoices.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridInvoices.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridInvoices.RowTemplate.Height = 26;
            this.gridInvoices.Size = new System.Drawing.Size(340, 481);
            this.gridInvoices.TabIndex = 37;
            this.gridInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInvoices_CellContentClick);
            // 
            // btn_searth
            // 
            this.btn_searth.BackColor = System.Drawing.Color.Navy;
            this.btn_searth.FlatAppearance.BorderSize = 0;
            this.btn_searth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_searth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_searth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searth.ForeColor = System.Drawing.Color.White;
            this.btn_searth.Location = new System.Drawing.Point(142, 121);
            this.btn_searth.Name = "btn_searth";
            this.btn_searth.Size = new System.Drawing.Size(75, 33);
            this.btn_searth.TabIndex = 39;
            this.btn_searth.Text = "Searth";
            this.btn_searth.UseVisualStyleBackColor = false;
            this.btn_searth.Click += new System.EventHandler(this.txt_searth_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(89, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 41);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.lblDiscountValue);
            this.panel1.Controls.Add(this.lblSubtotalValue);
            this.panel1.Controls.Add(this.lblUserValue);
            this.panel1.Controls.Add(this.lblInvoiceNumberValue);
            this.panel1.Controls.Add(this.lblDateValue);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.grid_rghit);
            this.panel1.Controls.Add(this.lblTotalTitle);
            this.panel1.Controls.Add(this.lblDiscountTitle);
            this.panel1.Controls.Add(this.lblSubtotalTitle);
            this.panel1.Controls.Add(this.lblUserTitle);
            this.panel1.Controls.Add(this.lblDateTitle);
            this.panel1.Controls.Add(this.lblInvoiceNumberTitle);
            this.panel1.Location = new System.Drawing.Point(375, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 562);
            this.panel1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(298, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(96, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "payment method :";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalValue.Location = new System.Drawing.Point(563, 177);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(0, 23);
            this.lblTotalValue.TabIndex = 50;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountValue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblDiscountValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDiscountValue.Location = new System.Drawing.Point(591, 92);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(0, 23);
            this.lblDiscountValue.TabIndex = 49;
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalValue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSubtotalValue.Location = new System.Drawing.Point(587, 131);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(0, 23);
            this.lblSubtotalValue.TabIndex = 48;
            // 
            // lblUserValue
            // 
            this.lblUserValue.AutoSize = true;
            this.lblUserValue.BackColor = System.Drawing.Color.Transparent;
            this.lblUserValue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblUserValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUserValue.Location = new System.Drawing.Point(231, 155);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(0, 23);
            this.lblUserValue.TabIndex = 47;
            // 
            // lblInvoiceNumberValue
            // 
            this.lblInvoiceNumberValue.AutoSize = true;
            this.lblInvoiceNumberValue.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceNumberValue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNumberValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInvoiceNumberValue.Location = new System.Drawing.Point(217, 70);
            this.lblInvoiceNumberValue.Name = "lblInvoiceNumberValue";
            this.lblInvoiceNumberValue.Size = new System.Drawing.Size(0, 23);
            this.lblInvoiceNumberValue.TabIndex = 46;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDateValue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblDateValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDateValue.Location = new System.Drawing.Point(179, 112);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(0, 23);
            this.lblDateValue.TabIndex = 45;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.panel7.Location = new System.Drawing.Point(707, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 479);
            this.panel7.TabIndex = 43;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(-1, 516);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(746, 44);
            this.panel6.TabIndex = 44;
            // 
            // grid_rghit
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_rghit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_rghit.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.grid_rghit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rghit.Location = new System.Drawing.Point(38, 249);
            this.grid_rghit.Name = "grid_rghit";
            this.grid_rghit.RowTemplate.Height = 26;
            this.grid_rghit.Size = new System.Drawing.Size(668, 264);
            this.grid_rghit.TabIndex = 6;
            this.grid_rghit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rghit_CellContentClick);
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitle.Location = new System.Drawing.Point(463, 174);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(84, 26);
            this.lblTotalTitle.TabIndex = 5;
            this.lblTotalTitle.Text = "Total : ";
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDiscountTitle.Location = new System.Drawing.Point(463, 89);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(122, 26);
            this.lblDiscountTitle.TabIndex = 4;
            this.lblDiscountTitle.Text = "Discount : ";
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.AutoSize = true;
            this.lblSubtotalTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalTitle.Location = new System.Drawing.Point(463, 128);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(118, 26);
            this.lblSubtotalTitle.TabIndex = 3;
            this.lblSubtotalTitle.Text = "Subtotal : ";
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblUserTitle.Location = new System.Drawing.Point(96, 152);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(129, 26);
            this.lblUserTitle.TabIndex = 2;
            this.lblUserTitle.Text = "Username :";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDateTitle.Location = new System.Drawing.Point(96, 109);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(80, 26);
            this.lblDateTitle.TabIndex = 1;
            this.lblDateTitle.Text = "Date : ";
            // 
            // lblInvoiceNumberTitle
            // 
            this.lblInvoiceNumberTitle.AutoSize = true;
            this.lblInvoiceNumberTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNumberTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblInvoiceNumberTitle.Location = new System.Drawing.Point(96, 68);
            this.lblInvoiceNumberTitle.Name = "lblInvoiceNumberTitle";
            this.lblInvoiceNumberTitle.Size = new System.Drawing.Size(112, 26);
            this.lblInvoiceNumberTitle.TabIndex = 0;
            this.lblInvoiceNumberTitle.Text = "Invoice  : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(374, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 479);
            this.panel2.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(61)))));
            this.panel5.Location = new System.Drawing.Point(374, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 38);
            this.panel5.TabIndex = 43;
            // 
            // label_exet
            // 
            this.label_exet.AutoSize = true;
            this.label_exet.BackColor = System.Drawing.Color.Transparent;
            this.label_exet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exet.ForeColor = System.Drawing.Color.White;
            this.label_exet.Location = new System.Drawing.Point(1100, 7);
            this.label_exet.Name = "label_exet";
            this.label_exet.Size = new System.Drawing.Size(24, 24);
            this.label_exet.TabIndex = 28;
            this.label_exet.Text = "X";
            this.label_exet.Click += new System.EventHandler(this.label_exet_Click);
            // 
            // label_Hello
            // 
            this.label_Hello.AutoSize = true;
            this.label_Hello.BackColor = System.Drawing.Color.Transparent;
            this.label_Hello.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hello.ForeColor = System.Drawing.Color.White;
            this.label_Hello.Location = new System.Drawing.Point(480, 7);
            this.label_Hello.Name = "label_Hello";
            this.label_Hello.Size = new System.Drawing.Size(193, 43);
            this.label_Hello.TabIndex = 30;
            this.label_Hello.Text = "Billings History";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label_Hello);
            this.panel3.Controls.Add(this.label_exet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1136, 51);
            this.panel3.TabIndex = 31;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Image = global::project.Properties.Resources.icons8_plus_48;
            this.btn_print.Location = new System.Drawing.Point(1063, 8);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(62, 56);
            this.btn_print.TabIndex = 9;
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // Billing__History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1136, 729);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_searth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridInvoices);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing__History";
            this.Text = "Billing__History";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rghit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView gridInvoices;
        private System.Windows.Forms.Button btn_searth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblInvoiceNumberTitle;
        private System.Windows.Forms.DataGridView grid_rghit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.Label lblInvoiceNumberValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_exet;
        private System.Windows.Forms.Label label_Hello;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_print;
    }
}