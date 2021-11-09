using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace QuanLySinhVien2
{
    public partial class ThongTinSinhVien : Form
    {

        DataBase.ConnectDataBase connectDataBase = new DataBase.ConnectDataBase();
        public ThongTinSinhVien()
        {
            InitializeComponent();
        }
        public void tBox(bool xuat)
        {
            tbCN.Enabled = xuat;
            tbDC.Enabled = xuat;
            tbGT.Enabled = xuat;
            tbHT.Enabled = xuat;
            tbML.Enabled = xuat;
            tbMSV.Enabled = xuat;
            tbSDT.Enabled = xuat;
            ns.Enabled = xuat;
        }
        public void Reset()
        {
            tbCN.Text = "";
            tbDC.Text = "";
            tbGT.Text = "";
            tbHT.Text = "";
            tbML.Text = "";
            tbMSV.Text = "";
            tbSDT.Text = "";
            ns.Value = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.DataSource = connectDataBase.DataReader("SELECT * FROM Student");
            bttSuaTT.Enabled = false;
            bttXoa.Enabled = false;
            bttXuat.Enabled = false;
            bttLuu.Enabled = false;
            bttHuy.Enabled = false;

        }

        // click vào Panel1
        private void grP1_Click(object sender, EventArgs e)
        {

            tBox(true);
            Reset();
            bttSuaTT.Enabled = false;
            bttXoa.Enabled = false;
            bttThemSV.Enabled = true;
        }


        // Show danh sach sinh viên của một lớp
        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Student WHERE ";
            if(tbTK.Text != "")
            {
                sql += "classID LIKE N'%" + tbTK.Text + "%'";
                
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã lớp");
                return;
            }

            data.DataSource = connectDataBase.DataReader(sql);
            bttXuat.Enabled = true;
        }

        // Thoát CT
        private void btExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng chương trình không?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bttSuaTT.Enabled = true;
            bttXoa.Enabled = true;
            bttThemSV.Enabled = false;

            // Khi click trên datagrip
            try
            {
                tbMSV.Text = data.CurrentRow.Cells[0].Value.ToString();
                tbHT.Text = data.CurrentRow.Cells[1].Value.ToString();
                tbDC.Text = data.CurrentRow.Cells[2].Value.ToString();
                tbGT.Text = data.CurrentRow.Cells[3].Value.ToString();
                tbSDT.Text = data.CurrentRow.Cells[4].Value.ToString();
                tbML.Text = data.CurrentRow.Cells[5].Value.ToString();
                ns.Value = (DateTime)data.CurrentRow.Cells[6].Value;
                tbCN.Text = data.CurrentRow.Cells[7].Value.ToString();

                // Không cho sửa
                tbMSV.Enabled = false;
                tbHT.Enabled = false;
                tbDC.Enabled = false;
                tbGT.Enabled = false;
                tbSDT.Enabled = false;
                tbML.Enabled = false;
                ns.Enabled = false;
                tbCN.Enabled = false;

            }
            catch(Exception ex)
            {

            }
        }

        private void bttThemSV_Click(object sender, EventArgs e)
        {
            
            // Check xem có trường rỗng không
            if (tbCN.Text == "" || tbDC.Text == "" || tbGT.Text == "" || tbHT.Text == "" || tbML.Text == "" || tbMSV.Text == ""||tbSDT.Text =="" ||ns.Value > DateTime.Today)
            {
                MessageBox.Show("Bạn phải thực hiện đầy nhập đầy dủ các trường");
                return;
            }
            else
            {
                // Check mã sinh viên có trùng không
                System.Data.DataTable tblSV = connectDataBase.DataReader("SELECT * FROM Student WHERE id = " + tbMSV.Text);
                if(tblSV.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại sinh viên có mã sinh viên là: " + tbMSV.Text.ToString());
                    return;
                }
                else
                {
                    String query = "INSERT INTO Student(id, fullname, address, gender, numberphone, classid, dateofbirth, specialized) VALUES";
                    query += "(" + Convert.ToInt32(tbMSV.Text) + ",N'" + tbHT.Text + "',N'" + tbDC .Text+ "',N'" + tbGT.Text + "'," + tbSDT.Text + ",'" + tbML.Text + "','" + ns.Value.Date + "',N'" + tbCN.Text + "')";

                    //Thực hiện thêm
                    connectDataBase.DataChange(query);
                    MessageBox.Show("Thêm Thành Công !!");

                    //Reset textbox
                    Reset();

                    //view data
                    data.DataSource =  connectDataBase.DataReader("SELECT * FROM Student");


                }
            }
        }

        private void bttSuaTT_Click(object sender, EventArgs e)
        {
            tBox(true);
            bttLuu.Enabled = true;
            bttHuy.Enabled = true;
          
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            String query = "UPDATE Student SET ";
            query += "fullName = N'" + tbHT.Text + "',address = N'" + tbDC.Text + "',gender = N'" + tbGT.Text +
                "',numberPhone = " + tbSDT.Text + ",classID = N'" + tbML.Text + "',dateOfBirth = '" + ns.Value.Date + "',specialized =N'" + tbCN.Text + "'" + "WHERE ID = '" + tbMSV.Text + "'";

            //Run query
            connectDataBase.DataChange(query);

            //return load from
            data.DataSource = connectDataBase.DataReader("SELECT * FROM Student");
            bttLuu.Enabled = false;
            bttHuy.Enabled = false;

        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            Reset();
            bttLuu.Enabled = false;
            bttHuy.Enabled = false;
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM Student WHERE ID = " + tbMSV.Text;

            // Run query
            connectDataBase.DataChange(query);

            // Load data
            data.DataSource = connectDataBase.DataReader("SELECT * FROM Student");
            

        }

        private void bttNhapDiem_Click(object sender, EventArgs e)
        {
            DiemSinhVien diemSinhVien = new DiemSinhVien();
            diemSinhVien.ShowDialog();
        }

        // Xuat file

        private void bttXuat_Click(object sender, EventArgs e)
        {
            //Khai báo và khởi tạo các đối tượng
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];


            Excel.Range tenLop = (Excel.Range)exSheet.Cells[1, 1];
            tenLop.Font.Size = 16;
            tenLop.Font.Bold = true;
            tenLop.Value = "Danh Sinh Viên Lớp " + tbTK.Text;

            // dinh dang bang
            exSheet.get_Range("A3:H3").Font.Bold = true;
            exSheet.get_Range("A3:H3").ColumnWidth = 25;
            exSheet.get_Range("A3:H3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A3").Value = "Mã Sinh Viên";
            exSheet.get_Range("B3").Value = "Họ Tên";
            exSheet.get_Range("C3").Value = "Địa Chỉ";
            exSheet.get_Range("D3").Value = "Giới Tính";
            exSheet.get_Range("E3").Value = "Số Điện Thoại";
            exSheet.get_Range("F3").Value = "Mã Lớp";
            exSheet.get_Range("G3").Value = "Ngày Sinh";
            exSheet.get_Range("H3").Value = "Chuyên Nghành";

            //Xuất data
            for(int i = 0; i < data.Rows.Count; i++)
            {
                exSheet.get_Range("A" + (i + 4).ToString() + ":H" + (i + 4).ToString()).Font.Bold = false; 
                exSheet.get_Range("A" + (i + 4).ToString()).Value = (i + 1).ToString();
                exSheet.get_Range("A" + (i + 4).ToString()).Value = data.Rows[i].Cells["ID"].ToString();
                exSheet.get_Range("B" + (i + 4).ToString()).Value = data.Rows[i].Cells["fullName"].ToString();
                exSheet.get_Range("C" + (i + 4).ToString()).Value = data.Rows[i].Cells["address"].ToString();
                exSheet.get_Range("D" + (i + 4).ToString()).Value = data.Rows[i].Cells["gender"].ToString();
                exSheet.get_Range("E" + (i + 4).ToString()).Value = data.Rows[i].Cells["numberPhone"].ToString();
                exSheet.get_Range("F" + (i + 4).ToString()).Value = data.Rows[i].Cells["classID"].ToString();
                exSheet.get_Range("G" + (i + 4).ToString()).Value = data.Rows[i].Cells["dateOfBirth"].ToString();
                exSheet.get_Range("H" + (i + 4).ToString()).Value = data.Rows[i].Cells["specialized"].ToString();

            }

            exSheet.Name = "Học Sinh";
            exBook.Activate(); //Kích hoạt Excel
            //Thiết lập các thuộc tính của SaveFileDialog
            dlgSave.Filter = "Excel Document(*.xlsx)|*.xlsx  |Word Document(*.doc) |*.doc|All files(*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".xlsx";

            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                exBook.SaveAs(dlgSave.FileName.ToString()); //Lưu file
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
            {
                MessageBox.Show("Danh sách trống");
            }
                
                    
        }
    }
}
