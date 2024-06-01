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
    public partial class Form_DuAn : Form
    {
        public Form_DuAn()
        {
            InitializeComponent();
            LoadDataDuAn();
            
        }

        Data db = new Data();

        //void AddBinding()
        //{
        //    txtIDduAn.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDduAn", true, DataSourceUpdateMode.Never));
        //    txtTenDuAn.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenDuAn", true, DataSourceUpdateMode.Never));
        //    txtIDnhaDauTu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDnhaDauTu", true, DataSourceUpdateMode.Never));
        //    txtIDlichTrinh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDlichTrinh", true, DataSourceUpdateMode.Never));
        //    txtKinhPhi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KinhPhi", true, DataSourceUpdateMode.Never));
        //    txtIDkhachHang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDkhachHang", true, DataSourceUpdateMode.Never));
        //    txtMaNhanVien.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaNhanVien", true, DataSourceUpdateMode.Never));
        //    txtIDhopDong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDhopDong", true, DataSourceUpdateMode.Never));
        //}

        void AddDataDuAn()
        {
            DuAn duAn = new DuAn();
            duAn.IDduan = int.Parse(txtIDduAn.Text);
            duAn.Tenduan = txtTenDuAn.Text;
            duAn.IDnhadautu = int.Parse(txtIDnhaDauTu.Text);
            duAn.IDlichtrinh = int.Parse(txtIDlichTrinh.Text);
            duAn.kinhphi = int.Parse(txtKinhPhi.Text);
            duAn.IDkhachhang = int.Parse(txtIDkhachHang.Text);
            duAn.IDnhanvien = int.Parse(txtMaNhanVien.Text);
            duAn.IDhopdong = int.Parse(txtIDhopDong.Text);
            db.DuAns.Add(duAn);
            db.SaveChanges();
            LoadDataDuAn();

        }

        void LoadDataDuAn()
        {
            var data = db.DuAns.Select(s => new
            {
                s.IDduan,
                s.Tenduan,
                s.IDnhadautu,
                s.IDlichtrinh,
                s.kinhphi,
                s.IDkhachhang,
                s.IDnhanvien,
                s.IDhopdong,

            });
            dataGridView1.DataSource = data.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddDataDuAn();
        }

        void EditDataDuAn()
        {
            int id = int.Parse(txtIDduAn.Text);
            DuAn c = db.DuAns.Where(s => s.IDduan == id).FirstOrDefault();
            c.Tenduan = txtTenDuAn.Text;
            c.IDnhadautu = int.Parse(txtIDnhaDauTu.Text);
            c.IDlichtrinh = int.Parse(txtIDlichTrinh.Text);
            c.kinhphi = int.Parse(txtKinhPhi.Text);
            c.IDkhachhang = int.Parse(txtIDkhachHang.Text);
            c.IDnhanvien = int.Parse(txtMaNhanVien.Text);
            c.IDhopdong = int.Parse(txtIDhopDong.Text);
            db.SaveChanges();
            LoadDataDuAn();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            EditDataDuAn();
        }

        void DeleteDataDuAn()
        {
            int id = int.Parse(txtIDduAn.Text);
            DuAn c = db.DuAns.Where(s => s.IDduan == id).FirstOrDefault();
           
            db.DuAns.Remove(c);
            db.SaveChanges();
            LoadDataDuAn();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteDataDuAn();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtIDduAn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenDuAn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtIDnhaDauTu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtIDlichTrinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtKinhPhi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtIDkhachHang.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMaNhanVien.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtIDhopDong.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        void SearchDataDuAn()
        {
            string tenduan = txtTenDuAn.Text.Trim();
            dataGridView1.DataSource = db.DuAns.Where(s => s.Tenduan.Contains(tenduan)).ToList();

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchDataDuAn();
        }
    }
}
