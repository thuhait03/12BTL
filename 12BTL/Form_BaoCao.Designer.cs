namespace _12BTL
{
    partial class Form_BaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSoLuongDuAn = new System.Windows.Forms.Label();
            this.lbNhaDauTu = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDA = new System.Windows.Forms.Label();
            this.LbNDT = new System.Windows.Forms.Label();
            this.lbKhach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 131);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbSoLuongDuAn
            // 
            this.lbSoLuongDuAn.AutoSize = true;
            this.lbSoLuongDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongDuAn.Location = new System.Drawing.Point(91, 26);
            this.lbSoLuongDuAn.Name = "lbSoLuongDuAn";
            this.lbSoLuongDuAn.Size = new System.Drawing.Size(36, 38);
            this.lbSoLuongDuAn.TabIndex = 2;
            this.lbSoLuongDuAn.Text = "0";
            this.lbSoLuongDuAn.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNhaDauTu
            // 
            this.lbNhaDauTu.AutoSize = true;
            this.lbNhaDauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaDauTu.Location = new System.Drawing.Point(92, 26);
            this.lbNhaDauTu.Name = "lbNhaDauTu";
            this.lbNhaDauTu.Size = new System.Drawing.Size(36, 38);
            this.lbNhaDauTu.TabIndex = 3;
            this.lbNhaDauTu.Text = "0";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.Location = new System.Drawing.Point(87, 26);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(36, 38);
            this.lbKhachHang.TabIndex = 4;
            this.lbKhachHang.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.lbSoLuongDuAn);
            this.panel1.Location = new System.Drawing.Point(64, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.lbNhaDauTu);
            this.panel2.Location = new System.Drawing.Point(316, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.lbKhachHang);
            this.panel3.Location = new System.Drawing.Point(568, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 7;
            // 
            // lbDA
            // 
            this.lbDA.AutoSize = true;
            this.lbDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDA.Location = new System.Drawing.Point(123, 224);
            this.lbDA.Name = "lbDA";
            this.lbDA.Size = new System.Drawing.Size(72, 25);
            this.lbDA.TabIndex = 8;
            this.lbDA.Text = "Dự Án";
            // 
            // LbNDT
            // 
            this.LbNDT.AutoSize = true;
            this.LbNDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNDT.Location = new System.Drawing.Point(356, 224);
            this.LbNDT.Name = "LbNDT";
            this.LbNDT.Size = new System.Drawing.Size(128, 25);
            this.LbNDT.TabIndex = 9;
            this.LbNDT.Text = "Nhà Đầu Tư";
            this.LbNDT.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbKhach
            // 
            this.lbKhach.AutoSize = true;
            this.lbKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhach.Location = new System.Drawing.Point(620, 224);
            this.lbKhach.Name = "lbKhach";
            this.lbKhach.Size = new System.Drawing.Size(131, 25);
            this.lbKhach.TabIndex = 10;
            this.lbKhach.Text = "Khách Hàng";
            // 
            // Form_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_12BTL.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKhach);
            this.Controls.Add(this.LbNDT);
            this.Controls.Add(this.lbDA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form_BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSoLuongDuAn;
        private System.Windows.Forms.Label lbNhaDauTu;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDA;
        private System.Windows.Forms.Label LbNDT;
        private System.Windows.Forms.Label lbKhach;
    }
}