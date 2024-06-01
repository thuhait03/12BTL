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
    public partial class Form_KhachHang : Form
    {
        public Form_KhachHang()
        {
            InitializeComponent();
            LoadDataKhachHang();
        }


        Data db = new Data();
        //void AddBinding()
        //{
        //    txtIDKhachHang.DataBindings.Add(new Binding("Text",dataGridView1.DataSource,"IDKhachHang",true,DataSourceUpdateMode.Never));
        //    txtTenKhachHang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenKhachHang", true, DataSourceUpdateMode.Never));
        //    txtDiaChi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Diachi", true, DataSourceUpdateMode.Never));
        //    txtSdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
        //}

        void AddDataKH()
        {
            KhachHang c = new KhachHang();
            c.IDKhachhang = int.Parse(txtIDKhachHang.Text);
            c.TenKhachhang = txtTenKhachHang.Text;
            c.Diachi = txtDiaChi.Text;
            c.SĐT = txtSdt.Text;
            db.KhachHangs.Add(c);
            db.SaveChanges();
            LoadDataKhachHang();
            
        }

        void LoadDataKhachHang()
        {
            var data = db.KhachHangs.Select(s => new
            {

                s.IDKhachhang,
                s.TenKhachhang,
                s.Diachi,
                s.SĐT,

            });
            dataGridView1.DataSource = data.ToList();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        void EditDataKH()
        {
            int id = int.Parse(txtIDKhachHang.Text);
            KhachHang c = db.KhachHangs.Where(s => s.IDKhachhang == id).FirstOrDefault();
            c.TenKhachhang = txtTenKhachHang.Text;
            c.Diachi = txtDiaChi.Text;
            c.SĐT = txtSdt.Text;
            db.SaveChanges();
            LoadDataKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           EditDataKH();
        }

        void DeleteDataKH()
        {
            int id = int.Parse(txtIDKhachHang.Text);
            KhachHang c = db.KhachHangs.Where(s => s.IDKhachhang == id).FirstOrDefault();
           
            db.KhachHangs.Remove(c);
            db.SaveChanges();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteDataKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddDataKH();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtIDKhachHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        void SearchDataKH()
        {
            string tenkh = txtTenKhachHang.Text.Trim();
            dataGridView1.DataSource = db.KhachHangs.Where(s => s.TenKhachhang.Contains(tenkh)).ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchDataKH();
        }
    }
}
