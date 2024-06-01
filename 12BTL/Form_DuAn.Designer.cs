namespace _12BTL
{
    partial class Form_DuAn
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
            this.lbDuAn = new System.Windows.Forms.Label();
            this.lbIDduAn = new System.Windows.Forms.Label();
            this.lbTenDuAn = new System.Windows.Forms.Label();
            this.lbIDnhaDauTu = new System.Windows.Forms.Label();
            this.lbIDlichTrinh = new System.Windows.Forms.Label();
            this.lbKinhPhi = new System.Windows.Forms.Label();
            this.lbIDkhachHang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDduAn = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtIDkhachHang = new System.Windows.Forms.TextBox();
            this.txtKinhPhi = new System.Windows.Forms.TextBox();
            this.txtIDlichTrinh = new System.Windows.Forms.TextBox();
            this.txtIDnhaDauTu = new System.Windows.Forms.TextBox();
            this.txtTenDuAn = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIDhopDong = new System.Windows.Forms.Label();
            this.txtIDhopDong = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lbDuAn
            // 
            this.lbDuAn.AutoSize = true;
            this.lbDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuAn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDuAn.Location = new System.Drawing.Point(12, 46);
            this.lbDuAn.Name = "lbDuAn";
            this.lbDuAn.Size = new System.Drawing.Size(286, 32);
            this.lbDuAn.TabIndex = 1;
            this.lbDuAn.Text = "DANH SÁCH DỰ ÁN";
            // 
            // lbIDduAn
            // 
            this.lbIDduAn.AutoSize = true;
            this.lbIDduAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDduAn.Location = new System.Drawing.Point(514, 78);
            this.lbIDduAn.Name = "lbIDduAn";
            this.lbIDduAn.Size = new System.Drawing.Size(73, 16);
            this.lbIDduAn.TabIndex = 2;
            this.lbIDduAn.Text = "Mã Dự Án";
            // 
            // lbTenDuAn
            // 
            this.lbTenDuAn.AutoSize = true;
            this.lbTenDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDuAn.Location = new System.Drawing.Point(514, 127);
            this.lbTenDuAn.Name = "lbTenDuAn";
            this.lbTenDuAn.Size = new System.Drawing.Size(79, 16);
            this.lbTenDuAn.TabIndex = 3;
            this.lbTenDuAn.Text = "Tên Dự Án";
            // 
            // lbIDnhaDauTu
            // 
            this.lbIDnhaDauTu.AutoSize = true;
            this.lbIDnhaDauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDnhaDauTu.Location = new System.Drawing.Point(514, 176);
            this.lbIDnhaDauTu.Name = "lbIDnhaDauTu";
            this.lbIDnhaDauTu.Size = new System.Drawing.Size(113, 16);
            this.lbIDnhaDauTu.TabIndex = 4;
            this.lbIDnhaDauTu.Text = "Mã Nhà Đầu Tư";
            // 
            // lbIDlichTrinh
            // 
            this.lbIDlichTrinh.AutoSize = true;
            this.lbIDlichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDlichTrinh.Location = new System.Drawing.Point(514, 230);
            this.lbIDlichTrinh.Name = "lbIDlichTrinh";
            this.lbIDlichTrinh.Size = new System.Drawing.Size(99, 16);
            this.lbIDlichTrinh.TabIndex = 5;
            this.lbIDlichTrinh.Text = "Mã Lịch Trình";
            // 
            // lbKinhPhi
            // 
            this.lbKinhPhi.AutoSize = true;
            this.lbKinhPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKinhPhi.Location = new System.Drawing.Point(514, 278);
            this.lbKinhPhi.Name = "lbKinhPhi";
            this.lbKinhPhi.Size = new System.Drawing.Size(62, 16);
            this.lbKinhPhi.TabIndex = 6;
            this.lbKinhPhi.Text = "Kinh Phí";
            // 
            // lbIDkhachHang
            // 
            this.lbIDkhachHang.AutoSize = true;
            this.lbIDkhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDkhachHang.Location = new System.Drawing.Point(514, 319);
            this.lbIDkhachHang.Name = "lbIDkhachHang";
            this.lbIDkhachHang.Size = new System.Drawing.Size(115, 16);
            this.lbIDkhachHang.TabIndex = 7;
            this.lbIDkhachHang.Text = "Mã Khách Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 8;
            // 
            // txtIDduAn
            // 
            this.txtIDduAn.Location = new System.Drawing.Point(635, 78);
            this.txtIDduAn.Name = "txtIDduAn";
            this.txtIDduAn.Size = new System.Drawing.Size(217, 22);
            this.txtIDduAn.TabIndex = 9;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(635, 363);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(217, 22);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // txtIDkhachHang
            // 
            this.txtIDkhachHang.Location = new System.Drawing.Point(635, 319);
            this.txtIDkhachHang.Name = "txtIDkhachHang";
            this.txtIDkhachHang.Size = new System.Drawing.Size(217, 22);
            this.txtIDkhachHang.TabIndex = 13;
            // 
            // txtKinhPhi
            // 
            this.txtKinhPhi.Location = new System.Drawing.Point(635, 275);
            this.txtKinhPhi.Name = "txtKinhPhi";
            this.txtKinhPhi.Size = new System.Drawing.Size(217, 22);
            this.txtKinhPhi.TabIndex = 14;
            // 
            // txtIDlichTrinh
            // 
            this.txtIDlichTrinh.Location = new System.Drawing.Point(635, 227);
            this.txtIDlichTrinh.Name = "txtIDlichTrinh";
            this.txtIDlichTrinh.Size = new System.Drawing.Size(217, 22);
            this.txtIDlichTrinh.TabIndex = 15;
            // 
            // txtIDnhaDauTu
            // 
            this.txtIDnhaDauTu.Location = new System.Drawing.Point(635, 176);
            this.txtIDnhaDauTu.Name = "txtIDnhaDauTu";
            this.txtIDnhaDauTu.Size = new System.Drawing.Size(217, 22);
            this.txtIDnhaDauTu.TabIndex = 16;
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.Location = new System.Drawing.Point(635, 127);
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(217, 22);
            this.txtTenDuAn.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(517, 443);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(720, 443);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 41);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(818, 443);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã nhân viên ";
            // 
            // lbIDhopDong
            // 
            this.lbIDhopDong.AutoSize = true;
            this.lbIDhopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDhopDong.Location = new System.Drawing.Point(514, 409);
            this.lbIDhopDong.Name = "lbIDhopDong";
            this.lbIDhopDong.Size = new System.Drawing.Size(101, 16);
            this.lbIDhopDong.TabIndex = 22;
            this.lbIDhopDong.Text = "Mã Hợp Đồng";
            // 
            // txtIDhopDong
            // 
            this.txtIDhopDong.Location = new System.Drawing.Point(635, 403);
            this.txtIDhopDong.Name = "txtIDhopDong";
            this.txtIDhopDong.Size = new System.Drawing.Size(217, 22);
            this.txtIDhopDong.TabIndex = 23;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Yellow;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(616, 443);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 41);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Form_DuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_12BTL.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(905, 496);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtIDhopDong);
            this.Controls.Add(this.lbIDhopDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenDuAn);
            this.Controls.Add(this.txtIDnhaDauTu);
            this.Controls.Add(this.txtIDlichTrinh);
            this.Controls.Add(this.txtKinhPhi);
            this.Controls.Add(this.txtIDkhachHang);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtIDduAn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbIDkhachHang);
            this.Controls.Add(this.lbKinhPhi);
            this.Controls.Add(this.lbIDlichTrinh);
            this.Controls.Add(this.lbIDnhaDauTu);
            this.Controls.Add(this.lbTenDuAn);
            this.Controls.Add(this.lbIDduAn);
            this.Controls.Add(this.lbDuAn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_DuAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DuAn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbDuAn;
        private System.Windows.Forms.Label lbIDduAn;
        private System.Windows.Forms.Label lbTenDuAn;
        private System.Windows.Forms.Label lbIDnhaDauTu;
        private System.Windows.Forms.Label lbIDlichTrinh;
        private System.Windows.Forms.Label lbKinhPhi;
        private System.Windows.Forms.Label lbIDkhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDduAn;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtIDkhachHang;
        private System.Windows.Forms.TextBox txtKinhPhi;
        private System.Windows.Forms.TextBox txtIDlichTrinh;
        private System.Windows.Forms.TextBox txtIDnhaDauTu;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIDhopDong;
        private System.Windows.Forms.TextBox txtIDhopDong;
        private System.Windows.Forms.Button btnTimKiem;
    }
}