namespace _12BTL
{
    partial class Form_LichTrinh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblichtrinh = new System.Windows.Forms.Label();
            this.btnInRa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 96);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblichtrinh
            // 
            this.lblichtrinh.AutoSize = true;
            this.lblichtrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblichtrinh.Location = new System.Drawing.Point(223, 25);
            this.lblichtrinh.Name = "lblichtrinh";
            this.lblichtrinh.Size = new System.Drawing.Size(323, 36);
            this.lblichtrinh.TabIndex = 1;
            this.lblichtrinh.Text = "Danh Sách Lịch Trình";
            // 
            // btnInRa
            // 
            this.btnInRa.BackColor = System.Drawing.Color.Aqua;
            this.btnInRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInRa.Location = new System.Drawing.Point(683, 386);
            this.btnInRa.Name = "btnInRa";
            this.btnInRa.Size = new System.Drawing.Size(95, 35);
            this.btnInRa.TabIndex = 3;
            this.btnInRa.Text = "IN RA";
            this.btnInRa.UseVisualStyleBackColor = false;
            this.btnInRa.Click += new System.EventHandler(this.btnInRa_Click);
            // 
            // Form_LichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_12BTL.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnInRa);
            this.Controls.Add(this.lblichtrinh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_LichTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_LichTrinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblichtrinh;
        private System.Windows.Forms.Button btnInRa;
    }
}