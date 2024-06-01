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
    public partial class Form_PhongBan : Form
    {
        public Form_PhongBan()
        {
            InitializeComponent();
             LoadDataPhongBan();
        }
        Data db = new Data();
        //void AddBinding()
        //{
        //    txtIDPhongBan.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDPhongBan", true, DataSourceUpdateMode.Never));
        //    txtMaNhanVien.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenNhanVien", true, DataSourceUpdateMode.Never));
        //    txtTenPhongBan.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenPhongBan", true, DataSourceUpdateMode.Never));
            
        //}


        private void btnThem_Click(object sender, EventArgs e)
        {
            AddPhongBan();
        }
        void AddPhongBan()
        {
            Phongban c = new Phongban();
            c.IDphongban = int.Parse(txtIDPhongBan.Text);
            c.manhanvien = int.Parse(txtMaNhanVien.Text);
            c.tenphongban = txtTenPhongBan.Text;
            db.Phongbans.Add(c);
            db.SaveChanges();
            LoadDataPhongBan();

        }
        void LoadDataPhongBan()
        {
            var data = db.Phongbans.Select(s => new
            {

                s.IDphongban,
                s.manhanvien,
                s.tenphongban
            });
            dataGridView1.DataSource = data.ToList();
        }

        void EditDataPhongBan()
        {
            int id = int.Parse(txtIDPhongBan.Text);
            Phongban c = db.Phongbans.Where( s => s.IDphongban == id ).FirstOrDefault();
            c.manhanvien = int.Parse( txtMaNhanVien.Text);
            c.tenphongban = txtTenPhongBan.Text;
            db.SaveChanges();
            LoadDataPhongBan();
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            EditDataPhongBan();
        }

        void DeleteDataPhongBan()
        {
            int id = int.Parse(txtIDPhongBan.Text);
            Phongban c = db.Phongbans.Where(s => s.IDphongban == id).FirstOrDefault();
           
            db.Phongbans.Remove(c);
            db.SaveChanges();
            LoadDataPhongBan();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteDataPhongBan();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtIDPhongBan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMaNhanVien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTenPhongBan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        void SearchDataPhongban()
        {
            string tenpb = txtTenPhongBan.Text.Trim();
            dataGridView1.DataSource = db.Phongbans.Where(s => s.tenphongban.Contains(tenpb)).ToList();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchDataPhongban();
        }
    }
}