namespace project.Forms
{
    partial class DetailsForm
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
            this.gridDetails = new System.Windows.Forms.DataGridView();
            this.label_Hello = new System.Windows.Forms.Label();
            this.label_exet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetails
            // 
            this.gridDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetails.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.gridDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetails.GridColor = System.Drawing.Color.White;
            this.gridDetails.Location = new System.Drawing.Point(12, 59);
            this.gridDetails.Name = "gridDetails";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetails.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetails.RowTemplate.Height = 26;
            this.gridDetails.Size = new System.Drawing.Size(732, 337);
            this.gridDetails.TabIndex = 4;
            this.gridDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetails_CellContentClick);
            // 
            // label_Hello
            // 
            this.label_Hello.AutoSize = true;
            this.label_Hello.BackColor = System.Drawing.Color.Transparent;
            this.label_Hello.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hello.ForeColor = System.Drawing.Color.White;
            this.label_Hello.Location = new System.Drawing.Point(254, 6);
            this.label_Hello.Name = "label_Hello";
            this.label_Hello.Size = new System.Drawing.Size(253, 43);
            this.label_Hello.TabIndex = 31;
            this.label_Hello.Text = "Warehouse statistics";
            // 
            // label_exet
            // 
            this.label_exet.AutoSize = true;
            this.label_exet.BackColor = System.Drawing.Color.Transparent;
            this.label_exet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exet.ForeColor = System.Drawing.Color.White;
            this.label_exet.Location = new System.Drawing.Point(717, 9);
            this.label_exet.Name = "label_exet";
            this.label_exet.Size = new System.Drawing.Size(27, 26);
            this.label_exet.TabIndex = 32;
            this.label_exet.Text = "X";
            this.label_exet.Click += new System.EventHandler(this.label_exet_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 420);
            this.Controls.Add(this.label_exet);
            this.Controls.Add(this.label_Hello);
            this.Controls.Add(this.gridDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDetails;
        private System.Windows.Forms.Label label_Hello;
        private System.Windows.Forms.Label label_exet;
    }
}