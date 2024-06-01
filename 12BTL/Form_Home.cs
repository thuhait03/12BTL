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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
 

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SignUp signUp = new Form_SignUp();
            signUp.ShowDialog();

            this.Show();
            signUp.FormClosed += (s, args) => this.Show();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            this.Show();
            login.FormClosed += (s, args) => this.Show();
        }
    }
}
