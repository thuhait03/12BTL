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
    public partial class Form_HopDong : Form
    {
        public Form_HopDong()
        {
            InitializeComponent();
            LoadDataHopDong();
        }
        Data db = new Data();
        void LoadDataHopDong()
        {
            var data = db.Hopdongs.Select(s => new
            {
                s.IDhopdong,
                s.Tenhophopdongduan,
                s.ngaykiket,
                s.hieuluc
            });
            dataGridView1.DataSource = data.ToList();
        }
    }
}
