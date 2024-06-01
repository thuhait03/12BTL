using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System;
using System.IO;
using OfficeOpenXml;


namespace _12BTL
{
    public partial class Form_LichTrinh : Form
    {
        public Form_LichTrinh()
        {
            InitializeComponent();
            LoadDataLichTrinh();
        }
        Data db = new Data();
        void LoadDataLichTrinh()
        {
            var data = db.Lichtrinhs.Select(s => new
            {

                s.IDlichtrinh,
                s.Tenduan,
                s.ngaybatdau,
                s.ngạketthuc,
                s.IDthongbao
            });
            dataGridView1.DataSource = data.ToList();
        }

        private void btnInRa_Click(object sender, EventArgs e)
        {

        
        //{
        //    // Đường dẫn lưu file Excel
        //    string filePath = @"D:\năm 3\lâp trình Net1\lichtring.xlsx";

        //    // Tạo file Excel mới
        //    using (ExcelPackage package = new ExcelPackage())
        //    {
        //        // Thêm một worksheet mới
        //        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

        //        // Điền dữ liệu vào worksheet
        //        worksheet.Cells[1, 1].Value = "ID lịch trình";
        //        worksheet.Cells[1, 2].Value = "Tên dự án";
        //        worksheet.Cells[1, 3].Value = "Ngày bắt đầu";
        //        worksheet.Cells[1, 4].Value = "Ngày kết thúc";
        //        worksheet.Cells[1, 5].Value = "ID dự án";
        //        worksheet.Cells[2, 1].Value = "data";
        //        worksheet.Cells[2, 2].Value = "data";
        //        worksheet.Cells[2, 3].Value = "data";
        //        worksheet.Cells[2, 4].Value = "data";
        //        worksheet.Cells[2, 5].Value = "data";

        //        // Lưu file Excel
        //        FileInfo fi = new FileInfo(filePath);
        //        package.SaveAs(fi);
        //    }

        //    Console.WriteLine("Excel file created successfully!");
        }
    }
}
