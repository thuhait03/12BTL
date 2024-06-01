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
    public partial class Form_nhanvien : Form
    {
            public Form_nhanvien ()
            {
                InitializeComponent();
                LoadDataNhanvien();
            }
            Data db = new Data();

        //void AddBinding()
        //{
        //    txtIDnhanVien.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "IDnhanVien", true, DataSourceUpdateMode.Never));
        //    txtTenNhanVien.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "TenNhanVien", true, DataSourceUpdateMode.Never));
        //    txtSdt.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
        //    txtIDphongBan.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "IDphongBan", true, DataSourceUpdateMode.Never));
        //}


        void AddDataNhanvien()
            {
                Nhanvien c = new Nhanvien();
                c.IDnhanvien = int.Parse(txtIDnhanVien.Text);
                c.tennhanvien = txtTenNhanVien.Text;
                c.SĐT = txtSdt.Text;
                c.IDPhongban = int.Parse(txtIDphongBan.Text);
                db.Nhanviens.Add(c);
                db.SaveChanges();
                LoadDataNhanvien();
                   
            }
            
            void LoadDataNhanvien()
        {
            var data = db.Nhanviens.Select(s => new
            {
                s.IDnhanvien,
                s.tennhanvien,
                s.SĐT,
                s.IDPhongban
            }).ToList();
            dataGridView3.DataSource = data;
        }


        private void Form_nhanvien_Load(object sender, EventArgs e)
        {
            LoadDataNhanvien();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddDataNhanvien();
        }

        void EditDataNhanvien()
        {
            int id = int.Parse(txtIDnhanVien.Text);
            Nhanvien c = db.Nhanviens.Where(s => s.IDnhanvien == id).FirstOrDefault();
            c.tennhanvien = txtTenNhanVien.Text;
            c.SĐT = txtSdt.Text;
            c.IDPhongban = int.Parse(txtIDphongBan.Text);
            db.SaveChanges();
            LoadDataNhanvien();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            EditDataNhanvien();
        }

        void DeleteDataNhanvien()
        {
            int id = int.Parse(txtIDnhanVien.Text);
            Nhanvien c = db.Nhanviens.Where(s => s.IDnhanvien == id).FirstOrDefault();
            db.Nhanviens.Remove(c);
            db.SaveChanges();
            LoadDataNhanvien();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteDataNhanvien();
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            txtIDnhanVien.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            txtSdt.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            txtIDphongBan.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        void SearchData()
        {
            string tennv = txtTenNhanVien.Text.Trim();
            dataGridView3.DataSource = db.Nhanviens.Where(s => s.tennhanvien.Contains(tennv)).ToList();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
 }
    

