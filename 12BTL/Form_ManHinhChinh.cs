using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12BTL
{
    public partial class Form_ManHinhChinh : Form
    {
        public Form_ManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            this.Show();
            login.FormClosed += (s, args) => this.Show();
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DuAn duAn = new Form_DuAn();
            duAn.ShowDialog();

            this.Show();
            duAn.FormClosed += (s, args) => this.Show();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_PhongBan phongBan = new Form_PhongBan();
            phongBan.ShowDialog();

            this.Show();
            phongBan.FormClosed += (s, args) => this.Show();
        }

        private void btnNhaDauTu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NhaDauTu nhaDauTu = new Form_NhaDauTu();
            nhaDauTu.ShowDialog();

            this.Show();
            nhaDauTu.FormClosed += (s, args) => this.Show();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_HopDong hopDong = new Form_HopDong();
            hopDong.ShowDialog();

            this.Show();
            hopDong.FormClosed += (s, args) => this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_nhanvien nhanVien = new Form_nhanvien();
            nhanVien.ShowDialog();

            this.Show();
            nhanVien.FormClosed += (s, args) => this.Show();
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LichTrinh lichTrinh = new Form_LichTrinh();
            lichTrinh.ShowDialog();

            this.Show();
            lichTrinh.FormClosed += (s, args) => this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_KhachHang khachHang = new Form_KhachHang();
            khachHang.ShowDialog();

            this.Show();
            khachHang.FormClosed += (s, args) => this.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BaoCao baoCao = new Form_BaoCao();
            baoCao.ShowDialog();

            this.Show();
            baoCao.FormClosed += (s, args) => this.Show();
        }

        private void Form_ManHinhChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
