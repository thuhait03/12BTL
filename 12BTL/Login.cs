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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Data db = new Data();

        void check()
        {
            var user = db.Taikhoans.Where(s => s.TenTk == textTenTK.Text && s.Matkhau == textMK.Text).FirstOrDefault();

            if (user != null)
            {
             Form_ManHinhChinh f = new Form_ManHinhChinh();
                f.ShowDialog();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_QuenMatKhau quenMatKhau = new Form_QuenMatKhau();
            quenMatKhau.ShowDialog();

            this.Show();
            quenMatKhau.FormClosed += (s, args) => this.Show();
        }
    }
}
