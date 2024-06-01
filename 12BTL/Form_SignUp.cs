using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _12BTL
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }
        Data db = new Data();
        

        void AddAccount()//them tai khoan vao database
        {
            Taikhoan taikhoan = new Taikhoan()
            {
            TenTk = txtTenTaiKhoan.Text,
            Sđt = txtSDT.Text,
            Matkhau = txtMatKhau.Text,
         

            };
            db.Taikhoans.Add(taikhoan);
            db.SaveChanges();
        }


        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text == ""|| txtSDT.Text == ""|| txtMatKhau.Text == ""|| txtNhapLai.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
            }
           
            if(txtMatKhau.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mat khau khong trung khop!");
                return;
            }
            if(!db.Taikhoans.Any(sdt => sdt.Sđt == txtSDT.Text))
            {
                if(!db.Taikhoans.Any(taikhoan => taikhoan.TenTk == txtMatKhau.Text))
                {
                    AddAccount();
                    MessageBox.Show("Dang ki thanh cong!");
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Show();
                    login.FormClosed += (s, args) => this.Show();
                }
                else
                {
                    MessageBox.Show("Ten tai khoan da ton tai!");
                }
            }
            else
            {
                MessageBox.Show("So dien thoai da duoc dang ki!");
            }
           
        }
    }
}
