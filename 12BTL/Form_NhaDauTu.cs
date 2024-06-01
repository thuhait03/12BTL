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
    public partial class Form_NhaDauTu : Form
    {
        public Form_NhaDauTu()
        {
            InitializeComponent();
            LoadDataNhadautu();
        }

        Data db = new Data();

        //void AddBinding()
        //{
        //   // txtIDnhaDautu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDnhaDautu", true, DataSourceUpdateMode.Never));
        //   // txtTenNhaDauTu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tennhadautu", true, DataSourceUpdateMode.Never));
        //   // txtSdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
        //}

        void AddNhaDautu()
        {
            Nhadautu c = new Nhadautu();
            c.IDnhadautu = int.Parse(txtIDnhaDautu.Text);
            c.Tennhadautu = txtTenNhaDauTu.Text;
            c.Sđt = txtSdt.Text;
            db.Nhadautus.Add(c);
            db.SaveChanges();
            LoadDataNhadautu();

        }
        void LoadDataNhadautu()
        {
            var data = db.Nhadautus.Select(s => new
            {

             s.IDnhadautu,
             s.Tennhadautu,
             s.Sđt
            });
            dataGridView1.DataSource = data.ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddNhaDautu();
        }

        void EditData()
        {
            var id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["IDnhadautu"].Value.ToString());
            Nhadautu c = db.Nhadautus.Find(id);
            c.Tennhadautu = txtTenNhaDauTu.Text;
            c.Sđt = txtSdt.Text;
            db.SaveChanges();
            LoadDataNhadautu();
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {
           
            EditData();
        }

        void DeleteData()
        {
            int id = int.Parse(txtIDnhaDautu.Text);
            Nhadautu c = db.Nhadautus.Where(s => s.IDnhadautu == id).FirstOrDefault();
            db.Nhadautus.Remove(c);
            db.SaveChanges();
            LoadDataNhadautu() ;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtIDnhaDautu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNhaDauTu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() ;
        }

        void SearchDataNhaDT()
        {
            string tennhadt = txtTenNhaDauTu.Text.Trim();
            dataGridView1.DataSource = db.Nhadautus.Where(s => s.Tennhadautu.Contains(tennhadt)).ToList();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SearchDataNhaDT();
        }
    }
}
