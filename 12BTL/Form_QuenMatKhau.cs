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
    public partial class Form_QuenMatKhau : Form
    {
        public Form_QuenMatKhau()
        {
            InitializeComponent();
            txtSDT.Text = "";
            
        }
        Data db = new Data();


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           if (txtSDT.Text == "")
            {
                txtSDT.Text = "vui long nhap lai so dien thoai!";
                txtSDT.ForeColor = Color.Red;

            }
           else
            {
                var check = db.Taikhoans.Where(s => s.Sđt == txtSDT.Text).FirstOrDefault();
                if (check == null)
                {
                    txtSDT.Text = "so dien thoai chua duoc dang ki!";
                    txtSDT.ForeColor = Color.Red;
                }
                else
                {
                    txtSDT.Text = "mat khau cua ban la :" + check.Matkhau;
                    txtSDT.ForeColor = Color.Green;

                }
            }
        }
    }
}
