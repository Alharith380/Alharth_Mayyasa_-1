namespace project.Forms
{
    partial class Sales_basket
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_iconnumber = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_brise = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tutleprice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gred_show = new System.Windows.Forms.DataGridView();
            this.label_exet = new System.Windows.Forms.Label();
            this.cmb_broudact = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Add_goods = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_quntite = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DiscountCode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gred_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quntite)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Warehouse Invoice Screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(527, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "https://www.weblrni.com/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip3.SetToolTip(this.label2, "Go To The Link");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Invoice number";
            // 
            // txt_iconnumber
            // 
            this.txt_iconnumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iconnumber.ForeColor = System.Drawing.Color.Red;
            this.txt_iconnumber.Location = new System.Drawing.Point(483, 121);
            this.txt_iconnumber.Multiline = true;
            this.txt_iconnumber.Name = "txt_iconnumber";
            this.txt_iconnumber.Size = new System.Drawing.Size(182, 37);
            this.txt_iconnumber.TabIndex = 11;
            this.txt_iconnumber.Text = "0000299";
            this.txt_iconnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Navy;
            this.txt_data.Location = new System.Drawing.Point(849, 121);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(182, 37);
            this.txt_data.TabIndex = 13;
            this.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_data_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(726, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "The date";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_name.Location = new System.Drawing.Point(483, 190);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(553, 37);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Customer name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1185, 46);
            this.label6.TabIndex = 16;
            this.label6.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Type";
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(217, 278);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(576, 30);
            this.cmb_type.TabIndex = 2;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(542, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Quantity";
            // 
            // txt_brise
            // 
            this.txt_brise.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brise.Location = new System.Drawing.Point(235, 349);
            this.txt_brise.Multiline = true;
            this.txt_brise.Name = "txt_brise";
            this.txt_brise.Size = new System.Drawing.Size(155, 28);
            this.txt_brise.TabIndex = 0;
            this.txt_brise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "The price";
            // 
            // txt_tutleprice
            // 
            this.txt_tutleprice.BackColor = System.Drawing.Color.Purple;
            this.txt_tutleprice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tutleprice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tutleprice.Location = new System.Drawing.Point(826, 340);
            this.txt_tutleprice.Multiline = true;
            this.txt_tutleprice.Name = "txt_tutleprice";
            this.txt_tutleprice.Size = new System.Drawing.Size(182, 37);
            this.txt_tutleprice.TabIndex = 24;
            this.txt_tutleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(839, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "⬇ Total Price ⬇";
            // 
            // gred_show
            // 
            this.gred_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gred_show.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gred_show.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.gred_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gred_show.DefaultCellStyle = dataGridViewCellStyle1;
            this.gred_show.Location = new System.Drawing.Point(69, 440);
            this.gred_show.Name = "gred_show";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gred_show.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gred_show.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gred_show.RowTemplate.Height = 26;
            this.gred_show.Size = new System.Drawing.Size(1092, 321);
            this.gred_show.TabIndex = 26;
            // 
            // label_exet
            // 
            this.label_exet.AutoSize = true;
            this.label_exet.BackColor = System.Drawing.Color.Transparent;
            this.label_exet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exet.Location = new System.Drawing.Point(1136, 9);
            this.label_exet.Name = "label_exet";
            this.label_exet.Size = new System.Drawing.Size(24, 24);
            this.label_exet.TabIndex = 27;
            this.label_exet.Text = "X";
            this.label_exet.Click += new System.EventHandler(this.label_exet_Click);
            // 
            // cmb_broudact
            // 
            this.cmb_broudact.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_broudact.FormattingEnabled = true;
            this.cmb_broudact.Location = new System.Drawing.Point(217, 312);
            this.cmb_broudact.Name = "cmb_broudact";
            this.cmb_broudact.Size = new System.Drawing.Size(576, 30);
            this.cmb_broudact.TabIndex = 3;
            this.cmb_broudact.SelectedIndexChanged += new System.EventHandler(this.cmb_broudact_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(101, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 26);
            this.label11.TabIndex = 28;
            this.label11.Text = "Product";
            // 
            // btn_Add_goods
            // 
            this.btn_Add_goods.BackColor = System.Drawing.Color.Navy;
            this.btn_Add_goods.FlatAppearance.BorderSize = 0;
            this.btn_Add_goods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_Add_goods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_Add_goods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_goods.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_goods.ForeColor = System.Drawing.Color.White;
            this.btn_Add_goods.Location = new System.Drawing.Point(1027, 268);
            this.btn_Add_goods.Name = "btn_Add_goods";
            this.btn_Add_goods.Size = new System.Drawing.Size(133, 60);
            this.btn_Add_goods.TabIndex = 5;
            this.btn_Add_goods.Text = "Add";
            this.toolTip1.SetToolTip(this.btn_Add_goods, "Add In Sales Basket");
            this.btn_Add_goods.UseVisualStyleBackColor = false;
            this.btn_Add_goods.Click += new System.EventHandler(this.btn_Add_goods_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Navy;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1028, 361);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(133, 60);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "Buying";
            this.toolTip2.SetToolTip(this.btn_print, "Print The Salre Basket");
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1;
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 0;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 1;
            this.toolTip2.AutoPopDelay = 1000;
            this.toolTip2.InitialDelay = 1;
            this.toolTip2.ReshowDelay = 0;
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 1;
            this.toolTip3.AutoPopDelay = 1000;
            this.toolTip3.InitialDelay = 1;
            this.toolTip3.ReshowDelay = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::project.Properties.Resources.icons8_trash_can_50;
            this.btn_delete.Location = new System.Drawing.Point(0, 135);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(62, 56);
            this.btn_delete.TabIndex = 7;
            this.toolTip3.SetToolTip(this.btn_delete, "Delet");
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_quntite
            // 
            this.txt_quntite.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_quntite.Location = new System.Drawing.Point(652, 348);
            this.txt_quntite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quntite.Name = "txt_quntite";
            this.txt_quntite.Size = new System.Drawing.Size(141, 29);
            this.txt_quntite.TabIndex = 4;
            this.txt_quntite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quntite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quntite.ValueChanged += new System.EventHandler(this.txt_quntite_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 327);
            this.panel1.TabIndex = 31;
            // 
            // lbl_DiscountCode
            // 
            this.lbl_DiscountCode.AutoSize = true;
            this.lbl_DiscountCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiscountCode.Location = new System.Drawing.Point(456, 398);
            this.lbl_DiscountCode.Name = "lbl_DiscountCode";
            this.lbl_DiscountCode.Size = new System.Drawing.Size(0, 26);
            this.lbl_DiscountCode.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(255, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 26);
            this.label13.TabIndex = 66;
            this.label13.Text = " Discount Code :";
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Navy;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.Color.White;
            this.btn_help.Location = new System.Drawing.Point(106, 392);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(112, 42);
            this.btn_help.TabIndex = 67;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::project.Properties.Resources.تصميم_بدون_عنوان__4__removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(-44, -64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 321);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Sales_basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1172, 764);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_DiscountCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_quntite);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Add_goods);
            this.Controls.Add(this.cmb_broudact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_exet);
            this.Controls.Add(this.gred_show);
            this.Controls.Add(this.txt_tutleprice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_brise);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_iconnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_basket";
            ((System.ComponentModel.ISupportInitialize)(this.gred_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quntite)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_iconnumber;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_brise;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tutleprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gred_show;
        private System.Windows.Forms.Label label_exet;
        private System.Windows.Forms.ComboBox cmb_broudact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Add_goods;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.NumericUpDown txt_quntite;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DiscountCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_help;
    }
}