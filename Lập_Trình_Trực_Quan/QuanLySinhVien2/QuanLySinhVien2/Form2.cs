using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien2
{
    public partial class DiemSinhVien : Form
    {
        DataBase.ConnectDataBase connectData = new DataBase.ConnectDataBase();
        public DiemSinhVien()
        {
            InitializeComponent();
        }
        private void bttExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void bttHienDS_Click(object sender, EventArgs e)
        {
            if(cbbLop.Text.Trim() != "" && cbbMMH.Text.Trim() != "" && cbbKhoa.Text.Trim() != "" && cbbKiHoc.Text.Trim() != "")
            {

                String sql = "SELECT S.ID,S.fullName,S2.subjectID,S2.subjectName,CS.classSubjectID,J.pointProcess,J.testScore,J.finalGrade " +
                   "FROM LockUp LU JOIN dbo.Class C on LU.classID = C.classID JOIN Student S on C.classID = S.classID " +
                    "JOIN Joins J on S.ID = J.ID JOIN dbo.ClassSubject CS on J.classSubjectID = CS.classSubjectID " +
                    "JOIN Subject S2 on S2.subjectID = CS.subjectID " +
                   "WHERE LU.lockUpName = N'"+cbbKhoa.Text+"' AND C.className = N'"+cbbLop.Text+"' AND S2.subjectID = " + int.Parse(cbbMMH.Text) + "AND S2.semester = '" + cbbKiHoc.Text + "'";

                data.DataSource = connectData.DataReader(sql);
            }
            else
            {
                MessageBox.Show("Tồn tại trường để chống","Thông Báo");
            }


        }

        private void DiemSinhVien_Load(object sender, EventArgs e)
        {
           

        }

        private void bttTK_Click(object sender, EventArgs e)
        {
            if (cbbLop.Text.Trim() != "" && cbbMMH.Text.Trim() != "" && cbbKhoa.Text.Trim() != "" && tbTK.Text.Trim() != "")
            {

                String sql = "SELECT S.ID,S.fullName,S2.subjectID,S2.subjectName,CS.classSubjectID,J.pointProcess,J.testScore,J.finalGrade " +
                "FROM LockUp LU JOIN dbo.Class C on LU.classID = C.classID JOIN Student S on C.classID = S.classID " +
                "JOIN Joins J on S.ID = J.ID JOIN dbo.ClassSubject CS on J.classSubjectID = CS.classSubjectID " +
                "JOIN Subject S2 on S2.subjectID = CS.subjectID " +
                "WHERE LU.lockUpName = N'" + cbbKhoa.Text + "' AND C.className = N'" + cbbLop.Text + "' AND S2.subjectID = " + int.Parse(cbbMMH.Text) + " AND S.ID = " + int.Parse(tbTK.Text) + "AND S2.semester = '" + cbbKiHoc.Text + "'"; ;

                data.DataSource = connectData.DataReader(sql);

            }
            else
            {
                MessageBox.Show("Trường lớp học, mã môn học, lớp, mã sinh viên không được để trống", "Thông Báo");
            }

        }

        //private Entity.BangDiem getInfor(int rowIndex)
        //{
        //    DataGridViewRow viewRow = data.Rows[rowIndex];
        //    Entity.BangDiem bangDiem = new Entity.BangDiem();
        //    try
        //    {
        //        bangDiem.id =   (int)viewRow.Cells["ID"].Value;
        //        bangDiem.classSid = (string)viewRow.Cells["classSubjectID"].Value;
        //        bangDiem.point = (double)viewRow.Cells["pointProcess"].Value;
        //        bangDiem.score = (double)viewRow.Cells["testScore"].Value;

        //    }catch(Exception e)
        //    {
        //        MessageBox.Show("Error!");
        //    }
        //    return bangDiem;
        //}
        private void bttLuu_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i <= data.Rows.Count; i++)
            {
                if(data.Rows[i].Cells["ID"].Value != null)
                {
                    Entity.BangDiem bangDiem = new Entity.BangDiem();
                    bangDiem.id = (int)data.Rows[i].Cells["ID"].Value;
                    bangDiem.classSid = (string)data.Rows[i].Cells["classSubjectID"].Value;
                    bangDiem.point = (double)data.Rows[i].Cells["pointProcess"].Value;
                    bangDiem.score = (double)data.Rows[i].Cells["testScore"].Value;
     
                    string sql = "UPDATE Joins SET pointProcess = " + bangDiem.point + " ,testScore = " + bangDiem.score
                         + ",finalGrade = " + (bangDiem.point * 0.3 + bangDiem.score * 0.7) + " WHERE ID = " + bangDiem.id + " AND classSubjectID = '" + bangDiem.classSid + "'";
                    connectData.DataChange(sql);

                    MessageBox.Show("Nhập điểm thành công !!!");
                    break;
                }else
                {
                    break;
                }
            }
            // load form
            try
            {
                String query = "SELECT S.ID,S.fullName,S2.subjectID,S2.subjectName,CS.classSubjectID,J.pointProcess,J.testScore,J.finalGrade " +
                        "FROM LockUp LU JOIN dbo.Class C on LU.classID = C.classID JOIN Student S on C.classID = S.classID " +
                        "JOIN Joins J on S.ID = J.ID JOIN dbo.ClassSubject CS on J.classSubjectID = CS.classSubjectID " +
                        "JOIN Subject S2 on S2.subjectID = CS.subjectID " +
                        "WHERE LU.lockUpName = N'" + cbbKhoa.Text + "' AND C.className = N'" + cbbLop.Text + "' AND S2.subjectID = " + int.Parse(cbbMMH.Text) + "AND S2.semester = '" + cbbKiHoc.Text + "'";

                data.DataSource = connectData.DataReader(query);
            }catch(Exception ex)
            {
                MessageBox.Show("Bảng không có dữ liệu!!");
            }
        }

    }
}
