
namespace QuanLySinhVien2
{
    partial class DiemSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbKiHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bttHienDS = new System.Windows.Forms.Button();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbMMH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttTK = new System.Windows.Forms.Button();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 579);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Điểm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.data);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 517);
            this.panel4.TabIndex = 1;
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fullNama,
            this.subjectID,
            this.subjectName,
            this.classSubjectID,
            this.pointProcess,
            this.testScore,
            this.finalGrade});
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1056, 517);
            this.data.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã Sinh Viên";
            this.ID.Name = "ID";
            // 
            // fullNama
            // 
            this.fullNama.DataPropertyName = "fullName";
            this.fullNama.HeaderText = "Họ Và Tên";
            this.fullNama.Name = "fullNama";
            // 
            // subjectID
            // 
            this.subjectID.DataPropertyName = "subjectID";
            this.subjectID.HeaderText = "Mã Môn Học";
            this.subjectID.Name = "subjectID";
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "Tên Môn Học";
            this.subjectName.Name = "subjectName";
            // 
            // classSubjectID
            // 
            this.classSubjectID.DataPropertyName = "classSubjectID";
            this.classSubjectID.HeaderText = "Mã Lớp Học Phần";
            this.classSubjectID.Name = "classSubjectID";
            // 
            // pointProcess
            // 
            this.pointProcess.DataPropertyName = "pointProcess";
            this.pointProcess.HeaderText = "Điểm Quá Trình";
            this.pointProcess.Name = "pointProcess";
            // 
            // testScore
            // 
            this.testScore.DataPropertyName = "testScore";
            this.testScore.HeaderText = "Điểm Thi";
            this.testScore.Name = "testScore";
            // 
            // finalGrade
            // 
            this.finalGrade.DataPropertyName = "finalGrade";
            this.finalGrade.HeaderText = "Điểm Tổng Kết";
            this.finalGrade.Name = "finalGrade";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.cbbKiHoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbbKhoa);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbbLop);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbbMMH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 43);
            this.panel2.TabIndex = 0;
            // 
            // cbbKiHoc
            // 
            this.cbbKiHoc.FormattingEnabled = true;
            this.cbbKiHoc.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX"});
            this.cbbKiHoc.Location = new System.Drawing.Point(625, 8);
            this.cbbKiHoc.Name = "cbbKiHoc";
            this.cbbKiHoc.Size = new System.Drawing.Size(121, 21);
            this.cbbKiHoc.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kì Học:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "Khóa 60",
            "Khóa 59",
            "Khóa 58"});
            this.cbbKhoa.Location = new System.Drawing.Point(456, 8);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(115, 21);
            this.cbbKhoa.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Khóa:";
            // 
            // bttHienDS
            // 
            this.bttHienDS.Location = new System.Drawing.Point(28, 7);
            this.bttHienDS.Name = "bttHienDS";
            this.bttHienDS.Size = new System.Drawing.Size(124, 27);
            this.bttHienDS.TabIndex = 4;
            this.bttHienDS.Text = "Danh Sách";
            this.bttHienDS.UseVisualStyleBackColor = true;
            this.bttHienDS.Click += new System.EventHandler(this.bttHienDS_Click);
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Items.AddRange(new object[] {
            "Công nghệ thông tin 1",
            "Công nghệ thông tin 2",
            "Công nghệ thông tin 3",
            "Công nghệ thông tin 4"});
            this.cbbLop.Location = new System.Drawing.Point(270, 8);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(139, 21);
            this.cbbLop.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lớp:";
            // 
            // cbbMMH
            // 
            this.cbbMMH.FormattingEnabled = true;
            this.cbbMMH.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbbMMH.Location = new System.Drawing.Point(87, 8);
            this.cbbMMH.Name = "cbbMMH";
            this.cbbMMH.Size = new System.Drawing.Size(149, 21);
            this.cbbMMH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Môn Học:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.bttTK);
            this.groupBox2.Controls.Add(this.tbTK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 507);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bttExit);
            this.panel3.Controls.Add(this.bttLuu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(748, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 53);
            this.panel3.TabIndex = 3;
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(175, 15);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(100, 31);
            this.bttExit.TabIndex = 3;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(42, 15);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(100, 31);
            this.bttLuu.TabIndex = 0;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttTK
            // 
            this.bttTK.Location = new System.Drawing.Point(433, 24);
            this.bttTK.Name = "bttTK";
            this.bttTK.Size = new System.Drawing.Size(85, 27);
            this.bttTK.TabIndex = 2;
            this.bttTK.Text = "Tìm Kiếm";
            this.bttTK.UseVisualStyleBackColor = true;
            this.bttTK.Click += new System.EventHandler(this.bttTK_Click);
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(120, 28);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(292, 20);
            this.tbTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Sinh Viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttHienDS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(890, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 43);
            this.panel1.TabIndex = 9;
            // 
            // DiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DiemSinhVien";
            this.Text = "Bảng Điểm";
            this.Load += new System.EventHandler(this.DiemSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttTK;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMMH;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttHienDS;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbKiHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn classSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn testScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalGrade;
        private System.Windows.Forms.Panel panel1;
    }
}