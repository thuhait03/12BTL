namespace _12BTL
{
    partial class Form_NhaDauTu
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
            this.lbIDnhaDauTu = new System.Windows.Forms.Label();
            this.lbTenNhaDauTu = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDnhaDautu = new System.Windows.Forms.TextBox();
            this.txtTenNhaDauTu = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbThongtinNhadauTu = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lbIDnhaDauTu
            // 
            this.lbIDnhaDauTu.AutoSize = true;
            this.lbIDnhaDauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDnhaDauTu.Location = new System.Drawing.Point(98, 46);
            this.lbIDnhaDauTu.Name = "lbIDnhaDauTu";
            this.lbIDnhaDauTu.Size = new System.Drawing.Size(113, 16);
            this.lbIDnhaDauTu.TabIndex = 1;
            this.lbIDnhaDauTu.Text = "Mã Nhà Đầu Tư";
            // 
            // lbTenNhaDauTu
            // 
            this.lbTenNhaDauTu.AutoSize = true;
            this.lbTenNhaDauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhaDauTu.Location = new System.Drawing.Point(98, 119);
            this.lbTenNhaDauTu.Name = "lbTenNhaDauTu";
            this.lbTenNhaDauTu.Size = new System.Drawing.Size(119, 16);
            this.lbTenNhaDauTu.TabIndex = 2;
            this.lbTenNhaDauTu.Text = "Tên Nhà Đầu Tư";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(467, 55);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(38, 16);
            this.lbSdt.TabIndex = 3;
            this.lbSdt.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // txtIDnhaDautu
            // 
            this.txtIDnhaDautu.Location = new System.Drawing.Point(255, 49);
            this.txtIDnhaDautu.Name = "txtIDnhaDautu";
            this.txtIDnhaDautu.Size = new System.Drawing.Size(158, 22);
            this.txtIDnhaDautu.TabIndex = 5;
            // 
            // txtTenNhaDauTu
            // 
            this.txtTenNhaDauTu.Location = new System.Drawing.Point(255, 113);
            this.txtTenNhaDauTu.Name = "txtTenNhaDauTu";
            this.txtTenNhaDauTu.Size = new System.Drawing.Size(158, 22);
            this.txtTenNhaDauTu.TabIndex = 6;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(557, 52);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(153, 22);
            this.txtSdt.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(101, 168);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(282, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(614, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbThongtinNhadauTu
            // 
            this.lbThongtinNhadauTu.AutoSize = true;
            this.lbThongtinNhadauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtinNhadauTu.Location = new System.Drawing.Point(97, 222);
            this.lbThongtinNhadauTu.Name = "lbThongtinNhadauTu";
            this.lbThongtinNhadauTu.Size = new System.Drawing.Size(184, 20);
            this.lbThongtinNhadauTu.TabIndex = 11;
            this.lbThongtinNhadauTu.Text = "Thông tin Nhà đầu tư";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Olive;
            this.btnTimkiem.Location = new System.Drawing.Point(449, 168);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(85, 37);
            this.btnTimkiem.TabIndex = 12;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // Form_NhaDauTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_12BTL.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.lbThongtinNhadauTu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTenNhaDauTu);
            this.Controls.Add(this.txtIDnhaDautu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbTenNhaDauTu);
            this.Controls.Add(this.lbIDnhaDauTu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_NhaDauTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NhaDauTu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbIDnhaDauTu;
        private System.Windows.Forms.Label lbTenNhaDauTu;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDnhaDautu;
        private System.Windows.Forms.TextBox txtTenNhaDauTu;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbThongtinNhadauTu;
        private System.Windows.Forms.Button btnTimkiem;
    }
}