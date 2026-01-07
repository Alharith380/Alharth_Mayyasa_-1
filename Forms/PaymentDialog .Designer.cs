namespace project.Forms
{
    partial class PaymentDialog
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
            this.label12 = new System.Windows.Forms.Label();
            this.txt_criditnum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_name_cash = new System.Windows.Forms.TextBox();
            this.groupBoxCash = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_banknum = new System.Windows.Forms.TextBox();
            this.lbl_discount_applied = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_adric = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ntunalnam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phonnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name_debt = new System.Windows.Forms.TextBox();
            this.groupBoxDebt = new System.Windows.Forms.GroupBox();
            this.groupBoxPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbDebt = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_iconnumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Items = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label_exet = new System.Windows.Forms.Label();
            this.txt_DiscountCode = new System.Windows.Forms.TextBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data = new System.Windows.Forms.Label();
            this.txt_tutleprice_ksm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ConfirmPayment = new System.Windows.Forms.Button();
            this.groupBoxCash.SuspendLayout();
            this.groupBoxDebt.SuspendLayout();
            this.groupBoxPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Items)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 26);
            this.label12.TabIndex = 92;
            this.label12.Text = "Credit card number";
            // 
            // txt_criditnum
            // 
            this.txt_criditnum.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criditnum.ForeColor = System.Drawing.Color.Navy;
            this.txt_criditnum.Location = new System.Drawing.Point(238, 103);
            this.txt_criditnum.Multiline = true;
            this.txt_criditnum.Name = "txt_criditnum";
            this.txt_criditnum.Size = new System.Drawing.Size(147, 33);
            this.txt_criditnum.TabIndex = 3;
            this.txt_criditnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 26);
            this.label10.TabIndex = 90;
            this.label10.Text = "Account number";
            // 
            // txt_name_cash
            // 
            this.txt_name_cash.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_cash.ForeColor = System.Drawing.Color.Navy;
            this.txt_name_cash.Location = new System.Drawing.Point(238, 20);
            this.txt_name_cash.Multiline = true;
            this.txt_name_cash.Name = "txt_name_cash";
            this.txt_name_cash.Size = new System.Drawing.Size(147, 33);
            this.txt_name_cash.TabIndex = 2;
            this.txt_name_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxCash
            // 
            this.groupBoxCash.Controls.Add(this.label9);
            this.groupBoxCash.Controls.Add(this.label12);
            this.groupBoxCash.Controls.Add(this.txt_criditnum);
            this.groupBoxCash.Controls.Add(this.label10);
            this.groupBoxCash.Controls.Add(this.txt_banknum);
            this.groupBoxCash.Controls.Add(this.lbl_discount_applied);
            this.groupBoxCash.Controls.Add(this.txt_name_cash);
            this.groupBoxCash.Location = new System.Drawing.Point(481, 241);
            this.groupBoxCash.Name = "groupBoxCash";
            this.groupBoxCash.Size = new System.Drawing.Size(399, 233);
            this.groupBoxCash.TabIndex = 108;
            this.groupBoxCash.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 93;
            this.label9.Text = "Name";
            // 
            // txt_banknum
            // 
            this.txt_banknum.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_banknum.ForeColor = System.Drawing.Color.Navy;
            this.txt_banknum.Location = new System.Drawing.Point(238, 179);
            this.txt_banknum.Multiline = true;
            this.txt_banknum.Name = "txt_banknum";
            this.txt_banknum.Size = new System.Drawing.Size(147, 33);
            this.txt_banknum.TabIndex = 4;
            this.txt_banknum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_discount_applied
            // 
            this.lbl_discount_applied.AutoSize = true;
            this.lbl_discount_applied.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount_applied.Location = new System.Drawing.Point(73, 27);
            this.lbl_discount_applied.Name = "lbl_discount_applied";
            this.lbl_discount_applied.Size = new System.Drawing.Size(71, 26);
            this.lbl_discount_applied.TabIndex = 88;
            this.lbl_discount_applied.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 26);
            this.label8.TabIndex = 88;
            this.label8.Text = "Aaddress";
            // 
            // txt_adric
            // 
            this.txt_adric.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adric.ForeColor = System.Drawing.Color.Navy;
            this.txt_adric.Location = new System.Drawing.Point(235, 84);
            this.txt_adric.Multiline = true;
            this.txt_adric.Name = "txt_adric";
            this.txt_adric.Size = new System.Drawing.Size(147, 33);
            this.txt_adric.TabIndex = 3;
            this.txt_adric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 26);
            this.label7.TabIndex = 86;
            this.label7.Text = "National number ";
            // 
            // txt_ntunalnam
            // 
            this.txt_ntunalnam.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ntunalnam.ForeColor = System.Drawing.Color.Navy;
            this.txt_ntunalnam.Location = new System.Drawing.Point(235, 134);
            this.txt_ntunalnam.Multiline = true;
            this.txt_ntunalnam.Name = "txt_ntunalnam";
            this.txt_ntunalnam.Size = new System.Drawing.Size(147, 33);
            this.txt_ntunalnam.TabIndex = 4;
            this.txt_ntunalnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 84;
            this.label5.Text = "phone number";
            // 
            // txt_phonnum
            // 
            this.txt_phonnum.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phonnum.ForeColor = System.Drawing.Color.Navy;
            this.txt_phonnum.Location = new System.Drawing.Point(235, 190);
            this.txt_phonnum.Multiline = true;
            this.txt_phonnum.Name = "txt_phonnum";
            this.txt_phonnum.Size = new System.Drawing.Size(147, 33);
            this.txt_phonnum.TabIndex = 5;
            this.txt_phonnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 82;
            this.label4.Text = "Name";
            // 
            // txt_name_debt
            // 
            this.txt_name_debt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_debt.ForeColor = System.Drawing.Color.Navy;
            this.txt_name_debt.Location = new System.Drawing.Point(235, 22);
            this.txt_name_debt.Multiline = true;
            this.txt_name_debt.Name = "txt_name_debt";
            this.txt_name_debt.Size = new System.Drawing.Size(147, 33);
            this.txt_name_debt.TabIndex = 2;
            this.txt_name_debt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxDebt
            // 
            this.groupBoxDebt.Controls.Add(this.label8);
            this.groupBoxDebt.Controls.Add(this.txt_adric);
            this.groupBoxDebt.Controls.Add(this.label7);
            this.groupBoxDebt.Controls.Add(this.txt_ntunalnam);
            this.groupBoxDebt.Controls.Add(this.label5);
            this.groupBoxDebt.Controls.Add(this.txt_phonnum);
            this.groupBoxDebt.Controls.Add(this.label4);
            this.groupBoxDebt.Controls.Add(this.txt_name_debt);
            this.groupBoxDebt.Location = new System.Drawing.Point(49, 241);
            this.groupBoxDebt.Name = "groupBoxDebt";
            this.groupBoxDebt.Size = new System.Drawing.Size(397, 232);
            this.groupBoxDebt.TabIndex = 107;
            this.groupBoxDebt.TabStop = false;
            // 
            // groupBoxPaymentMethod
            // 
            this.groupBoxPaymentMethod.Controls.Add(this.rbDebt);
            this.groupBoxPaymentMethod.Controls.Add(this.rbCash);
            this.groupBoxPaymentMethod.Location = new System.Drawing.Point(489, 73);
            this.groupBoxPaymentMethod.Name = "groupBoxPaymentMethod";
            this.groupBoxPaymentMethod.Size = new System.Drawing.Size(516, 62);
            this.groupBoxPaymentMethod.TabIndex = 106;
            this.groupBoxPaymentMethod.TabStop = false;
            // 
            // rbDebt
            // 
            this.rbDebt.AutoSize = true;
            this.rbDebt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebt.Location = new System.Drawing.Point(289, 18);
            this.rbDebt.Name = "rbDebt";
            this.rbDebt.Size = new System.Drawing.Size(212, 30);
            this.rbDebt.TabIndex = 1;
            this.rbDebt.TabStop = true;
            this.rbDebt.Text = "Payment By Debt";
            this.rbDebt.UseVisualStyleBackColor = true;
            this.rbDebt.CheckedChanged += new System.EventHandler(this.rbDebt_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(10, 18);
            this.rbCash.Name = "rbCash";
            this.rbCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCash.Size = new System.Drawing.Size(208, 30);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Payment In Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(915, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_iconnumber
            // 
            this.txt_iconnumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iconnumber.ForeColor = System.Drawing.Color.Red;
            this.txt_iconnumber.Location = new System.Drawing.Point(220, 98);
            this.txt_iconnumber.Multiline = true;
            this.txt_iconnumber.Name = "txt_iconnumber";
            this.txt_iconnumber.Size = new System.Drawing.Size(182, 37);
            this.txt_iconnumber.TabIndex = 104;
            this.txt_iconnumber.Text = "0000299";
            this.txt_iconnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 26);
            this.label14.TabIndex = 103;
            this.label14.Text = "Invoice number";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 247);
            this.label2.TabIndex = 101;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(886, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 247);
            this.label1.TabIndex = 100;
            this.label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // grid_Items
            // 
            this.grid_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Items.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.grid_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Items.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Items.GridColor = System.Drawing.Color.Thistle;
            this.grid_Items.Location = new System.Drawing.Point(58, 509);
            this.grid_Items.Name = "grid_Items";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_Items.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Items.RowTemplate.Height = 26;
            this.grid_Items.Size = new System.Drawing.Size(946, 257);
            this.grid_Items.TabIndex = 99;
            this.grid_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Items_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 26);
            this.label13.TabIndex = 97;
            this.label13.Text = "Giv The Discount Code :";
            // 
            // label_exet
            // 
            this.label_exet.AutoSize = true;
            this.label_exet.BackColor = System.Drawing.Color.Transparent;
            this.label_exet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exet.ForeColor = System.Drawing.Color.White;
            this.label_exet.Location = new System.Drawing.Point(1023, 12);
            this.label_exet.Name = "label_exet";
            this.label_exet.Size = new System.Drawing.Size(24, 24);
            this.label_exet.TabIndex = 35;
            this.label_exet.Text = "X";
            this.label_exet.Click += new System.EventHandler(this.label_exet_Click);
            // 
            // txt_DiscountCode
            // 
            this.txt_DiscountCode.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiscountCode.ForeColor = System.Drawing.Color.Navy;
            this.txt_DiscountCode.Location = new System.Drawing.Point(275, 157);
            this.txt_DiscountCode.Multiline = true;
            this.txt_DiscountCode.Name = "txt_DiscountCode";
            this.txt_DiscountCode.Size = new System.Drawing.Size(147, 33);
            this.txt_DiscountCode.TabIndex = 96;
            this.txt_DiscountCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Navy;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(915, 417);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(133, 47);
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Text = "Completion";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 298);
            this.panel3.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1060, 32);
            this.label3.TabIndex = 102;
            this.label3.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.data);
            this.panel1.Controls.Add(this.label_exet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 70);
            this.panel1.TabIndex = 92;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(243, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(544, 40);
            this.data.TabIndex = 112;
            this.data.Text = "Please Enter Your Payment Information.";
            // 
            // txt_tutleprice_ksm
            // 
            this.txt_tutleprice_ksm.BackColor = System.Drawing.Color.Purple;
            this.txt_tutleprice_ksm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tutleprice_ksm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tutleprice_ksm.Location = new System.Drawing.Point(866, 158);
            this.txt_tutleprice_ksm.Multiline = true;
            this.txt_tutleprice_ksm.Name = "txt_tutleprice_ksm";
            this.txt_tutleprice_ksm.Size = new System.Drawing.Size(182, 37);
            this.txt_tutleprice_ksm.TabIndex = 110;
            this.txt_tutleprice_ksm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(678, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 26);
            this.label11.TabIndex = 109;
            this.label11.Text = " Total Price ➡";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(915, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Discount Test";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(1000, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 298);
            this.panel2.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1060, 39);
            this.label6.TabIndex = 112;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------------";
            // 
            // btn_ConfirmPayment
            // 
            this.btn_ConfirmPayment.BackColor = System.Drawing.Color.Navy;
            this.btn_ConfirmPayment.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_ConfirmPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_ConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmPayment.Location = new System.Drawing.Point(915, 353);
            this.btn_ConfirmPayment.Name = "btn_ConfirmPayment";
            this.btn_ConfirmPayment.Size = new System.Drawing.Size(133, 55);
            this.btn_ConfirmPayment.TabIndex = 7;
            this.btn_ConfirmPayment.Text = "\"Confirm \r\n  Payment\"";
            this.btn_ConfirmPayment.UseVisualStyleBackColor = false;
            this.btn_ConfirmPayment.Click += new System.EventHandler(this.btn_ConfirmPayment_Click);
            // 
            // PaymentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1060, 770);
            this.Controls.Add(this.btn_ConfirmPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_tutleprice_ksm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxCash);
            this.Controls.Add(this.groupBoxDebt);
            this.Controls.Add(this.groupBoxPaymentMethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_iconnumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_Items);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_DiscountCode);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentDialog";
            this.Text = "PaymentDialog";
            this.Load += new System.EventHandler(this.PaymentDialog_Load);
            this.groupBoxCash.ResumeLayout(false);
            this.groupBoxCash.PerformLayout();
            this.groupBoxDebt.ResumeLayout(false);
            this.groupBoxDebt.PerformLayout();
            this.groupBoxPaymentMethod.ResumeLayout(false);
            this.groupBoxPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Items)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_criditnum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_name_cash;
        private System.Windows.Forms.GroupBox groupBoxCash;
        private System.Windows.Forms.TextBox txt_banknum;
        private System.Windows.Forms.Label lbl_discount_applied;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_adric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ntunalnam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phonnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name_debt;
        private System.Windows.Forms.GroupBox groupBoxDebt;
        private System.Windows.Forms.GroupBox groupBoxPaymentMethod;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_iconnumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Items;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_exet;
        private System.Windows.Forms.TextBox txt_DiscountCode;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDebt;
        private System.Windows.Forms.TextBox txt_tutleprice_ksm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ConfirmPayment;
        private System.Windows.Forms.Label label9;
    }
}