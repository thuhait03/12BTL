namespace _12BTL
{
    partial class Form_nhanvien
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
            this.lbIDnhanVien = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbTenNhanvien = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbIDphongBan = new System.Windows.Forms.Label();
            this.txtIDnhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtIDphongBan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbThongTinNV = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIDnhanVien
            // 
            this.lbIDnhanVien.AutoSize = true;
            this.lbIDnhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDnhanVien.Location = new System.Drawing.Point(79, 54);
            this.lbIDnhanVien.Name = "lbIDnhanVien";
            this.lbIDnhanVien.Size = new System.Drawing.Size(101, 16);
            this.lbIDnhanVien.TabIndex = 0;
            this.lbIDnhanVien.Text = "Mã Nhân viên";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(52, 288);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(685, 150);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.Click += new System.EventHandler(this.dataGridView3_Click);
            // 
            // lbTenNhanvien
            // 
            this.lbTenNhanvien.AutoSize = true;
            this.lbTenNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanvien.Location = new System.Drawing.Point(79, 126);
            this.lbTenNhanvien.Name = "lbTenNhanvien";
            this.lbTenNhanvien.Size = new System.Drawing.Size(107, 16);
            this.lbTenNhanvien.TabIndex = 2;
            this.lbTenNhanvien.Text = "Tên Nhân viên";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(455, 54);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(38, 16);
            this.lbSdt.TabIndex = 3;
            this.lbSdt.Text = "SDT";
            // 
            // lbIDphongBan
            // 
            this.lbIDphongBan.AutoSize = true;
            this.lbIDphongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDphongBan.Location = new System.Drawing.Point(455, 126);
            this.lbIDphongBan.Name = "lbIDphongBan";
            this.lbIDphongBan.Size = new System.Drawing.Size(107, 16);
            this.lbIDphongBan.TabIndex = 4;
            this.lbIDphongBan.Text = "Mã Phòng Ban";
            // 
            // txtIDnhanVien
            // 
            this.txtIDnhanVien.Location = new System.Drawing.Point(227, 54);
            this.txtIDnhanVien.Name = "txtIDnhanVien";
            this.txtIDnhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtIDnhanVien.TabIndex = 5;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(227, 123);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtTenNhanVien.TabIndex = 6;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(596, 54);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(155, 22);
            this.txtSdt.TabIndex = 7;
            // 
            // txtIDphongBan
            // 
            this.txtIDphongBan.Location = new System.Drawing.Point(596, 126);
            this.txtIDphongBan.Name = "txtIDphongBan";
            this.txtIDphongBan.Size = new System.Drawing.Size(155, 22);
            this.txtIDphongBan.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnThem.Location = new System.Drawing.Point(111, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Coral;
            this.btnSua.Location = new System.Drawing.Point(276, 192);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(638, 192);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbThongTinNV
            // 
            this.lbThongTinNV.AutoSize = true;
            this.lbThongTinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNV.Location = new System.Drawing.Point(48, 251);
            this.lbThongTinNV.Name = "lbThongTinNV";
            this.lbThongTinNV.Size = new System.Drawing.Size(179, 20);
            this.lbThongTinNV.TabIndex = 12;
            this.lbThongTinNV.Text = "Thông tin Nhân Viên";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Olive;
            this.btnTimkiem.Location = new System.Drawing.Point(458, 192);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimkiem.TabIndex = 13;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // Form_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_12BTL.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.lbThongTinNV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtIDphongBan);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtIDnhanVien);
            this.Controls.Add(this.lbIDphongBan);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbTenNhanvien);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lbIDnhanVien);
            this.Name = "Form_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_nhanvien";
            this.Load += new System.EventHandler(this.Form_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDnhanVien;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbTenNhanvien;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbIDphongBan;
        private System.Windows.Forms.TextBox txtIDnhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtIDphongBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbThongTinNV;
        private System.Windows.Forms.Button btnTimkiem;
    }
}