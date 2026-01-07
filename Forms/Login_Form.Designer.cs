namespace project.Forms
{
    partial class Form1
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
            this.btn_log_in = new System.Windows.Forms.Button();
            this.lable_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_passowrd = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_helpwrite = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_typesestem = new System.Windows.Forms.Label();
            this.label_Hello = new System.Windows.Forms.Label();
            this.label_exet = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_log_in
            // 
            this.btn_log_in.BackColor = System.Drawing.Color.Navy;
            this.btn_log_in.FlatAppearance.BorderSize = 0;
            this.btn_log_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_log_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log_in.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_in.ForeColor = System.Drawing.Color.White;
            this.btn_log_in.Location = new System.Drawing.Point(470, 376);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(119, 42);
            this.btn_log_in.TabIndex = 3;
            this.btn_log_in.Text = "LOGIN";
            this.btn_log_in.UseVisualStyleBackColor = false;
            this.btn_log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // lable_username
            // 
            this.lable_username.AutoSize = true;
            this.lable_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_username.Location = new System.Drawing.Point(390, 175);
            this.lable_username.Name = "lable_username";
            this.lable_username.Size = new System.Drawing.Size(112, 24);
            this.lable_username.TabIndex = 2;
            this.lable_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_username.Location = new System.Drawing.Point(394, 218);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(272, 38);
            this.txt_username.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_username, "Root");
            this.txt_username.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // txt_passowrd
            // 
            this.txt_passowrd.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_passowrd.Location = new System.Drawing.Point(394, 308);
            this.txt_passowrd.Name = "txt_passowrd";
            this.txt_passowrd.Size = new System.Drawing.Size(272, 38);
            this.txt_passowrd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_passowrd, "root@root");
            this.txt_passowrd.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(396, 274);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(80, 24);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "E-meal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label_helpwrite);
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_typesestem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 543);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::project.Properties.Resources._32349redapple_98912;
            this.pictureBox6.Location = new System.Drawing.Point(8, 393);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(62, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::project.Properties.Resources.trophy_jewelry_winner_win_treasure_gift_blue_diamond_game_icon_262398;
            this.pictureBox4.Location = new System.Drawing.Point(266, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::project.Properties.Resources.Mac_Dictionary_23497;
            this.pictureBox3.Location = new System.Drawing.Point(9, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label_helpwrite
            // 
            this.label_helpwrite.AutoSize = true;
            this.label_helpwrite.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_helpwrite.ForeColor = System.Drawing.Color.Gold;
            this.label_helpwrite.Location = new System.Drawing.Point(79, 327);
            this.label_helpwrite.Name = "label_helpwrite";
            this.label_helpwrite.Size = new System.Drawing.Size(174, 69);
            this.label_helpwrite.TabIndex = 11;
            this.label_helpwrite.Text = "Befor Your LogIn\r\n Pleas Clic Hear\r\n            ⏬";
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
            this.btn_help.Location = new System.Drawing.Point(27, 482);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(283, 42);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::project.Properties.Resources.currency_exchange_finance_coins_money_usd_dollar_icon_262507;
            this.pictureBox5.Location = new System.Drawing.Point(266, 393);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::project.Properties.Resources.تصميم_بدون_عنوان__13__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(56, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_typesestem
            // 
            this.label_typesestem.AutoSize = true;
            this.label_typesestem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_typesestem.ForeColor = System.Drawing.Color.White;
            this.label_typesestem.Location = new System.Drawing.Point(37, 194);
            this.label_typesestem.Name = "label_typesestem";
            this.label_typesestem.Size = new System.Drawing.Size(291, 24);
            this.label_typesestem.TabIndex = 3;
            this.label_typesestem.Text = "Seling Manegement System";
            // 
            // label_Hello
            // 
            this.label_Hello.AutoSize = true;
            this.label_Hello.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hello.Location = new System.Drawing.Point(437, 62);
            this.label_Hello.Name = "label_Hello";
            this.label_Hello.Size = new System.Drawing.Size(177, 28);
            this.label_Hello.TabIndex = 6;
            this.label_Hello.Text = "Login Account";
            // 
            // label_exet
            // 
            this.label_exet.AutoSize = true;
            this.label_exet.BackColor = System.Drawing.Color.Transparent;
            this.label_exet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exet.Location = new System.Drawing.Point(708, 9);
            this.label_exet.Name = "label_exet";
            this.label_exet.Size = new System.Drawing.Size(24, 24);
            this.label_exet.TabIndex = 7;
            this.label_exet.Text = "X";
            this.label_exet.Click += new System.EventHandler(this.label3_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 543);
            this.Controls.Add(this.label_exet);
            this.Controls.Add(this.label_Hello);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_passowrd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lable_username);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.btn_log_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_log_in;
        private System.Windows.Forms.Label lable_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_passowrd;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_typesestem;
        private System.Windows.Forms.Label label_Hello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_helpwrite;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label_exet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

