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
    public partial class Form_BaoCao : Form
    {
        public Form_BaoCao()
        {
            InitializeComponent();
            LoadDataBaocao();
            ThongKeDuAn();
            ThongKeKhachHang();
            ThongKeNhaDauTu();
        }
        Data db = new Data();
        void LoadDataBaocao()
        {
            var data = db.Thongbaos.Select(s => new
            {
                s.IDthongbao,
                s.Tenthongbao,
                s.Ngaythongbao
            });
            dataGridView1.DataSource = data.ToList();
        }
        void ThongKeDuAn()
        {
            var data = db.DuAns.Count();
            lbSoLuongDuAn.Text = data.ToString();   
            
        }
        void ThongKeNhaDauTu()
        {
            var data=db.Nhadautus.Count();
            lbNhaDauTu.Text = data.ToString();

        }
        void ThongKeKhachHang()
        {
            var data = db.KhachHangs.Count();
            lbKhachHang.Text = data.ToString();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
