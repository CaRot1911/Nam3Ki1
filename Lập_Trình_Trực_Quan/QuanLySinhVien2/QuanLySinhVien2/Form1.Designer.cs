
namespace QuanLySinhVien2
{
    partial class ThongTinSinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grP2 = new System.Windows.Forms.Panel();
            this.bttXuat = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThemSV = new System.Windows.Forms.Button();
            this.bttSuaTT = new System.Windows.Forms.Button();
            this.bttNhapDiem = new System.Windows.Forms.Button();
            this.grP1 = new System.Windows.Forms.Panel();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.ns = new System.Windows.Forms.DateTimePicker();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.tbML = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbGT = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.tbHT = new System.Windows.Forms.TextBox();
            this.tbMSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialized = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.grP2.SuspendLayout();
            this.grP1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grP2);
            this.groupBox1.Controls.Add(this.grP1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // grP2
            // 
            this.grP2.Controls.Add(this.bttXoa);
            this.grP2.Controls.Add(this.bttThemSV);
            this.grP2.Controls.Add(this.bttSuaTT);
            this.grP2.Controls.Add(this.bttNhapDiem);
            this.grP2.Dock = System.Windows.Forms.DockStyle.Right;
            this.grP2.Location = new System.Drawing.Point(843, 16);
            this.grP2.Name = "grP2";
            this.grP2.Size = new System.Drawing.Size(298, 195);
            this.grP2.TabIndex = 1;
            // 
            // bttXuat
            // 
            this.bttXuat.Location = new System.Drawing.Point(41, 11);
            this.bttXuat.Name = "bttXuat";
            this.bttXuat.Size = new System.Drawing.Size(141, 29);
            this.bttXuat.TabIndex = 5;
            this.bttXuat.Text = "Xuất File";
            this.bttXuat.UseVisualStyleBackColor = true;
            this.bttXuat.Click += new System.EventHandler(this.bttXuat_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(167, 122);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(93, 27);
            this.bttXoa.TabIndex = 4;
            this.bttXoa.Text = "Xóa Sinh Viên";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThemSV
            // 
            this.bttThemSV.Location = new System.Drawing.Point(31, 122);
            this.bttThemSV.Name = "bttThemSV";
            this.bttThemSV.Size = new System.Drawing.Size(93, 27);
            this.bttThemSV.TabIndex = 2;
            this.bttThemSV.Text = "Thêm Sinh Viên";
            this.bttThemSV.UseVisualStyleBackColor = true;
            this.bttThemSV.Click += new System.EventHandler(this.bttThemSV_Click);
            // 
            // bttSuaTT
            // 
            this.bttSuaTT.Location = new System.Drawing.Point(31, 49);
            this.bttSuaTT.Name = "bttSuaTT";
            this.bttSuaTT.Size = new System.Drawing.Size(93, 27);
            this.bttSuaTT.TabIndex = 1;
            this.bttSuaTT.Text = "Sửa Thông Tin";
            this.bttSuaTT.UseVisualStyleBackColor = true;
            this.bttSuaTT.Click += new System.EventHandler(this.bttSuaTT_Click);
            // 
            // bttNhapDiem
            // 
            this.bttNhapDiem.Location = new System.Drawing.Point(167, 49);
            this.bttNhapDiem.Name = "bttNhapDiem";
            this.bttNhapDiem.Size = new System.Drawing.Size(93, 27);
            this.bttNhapDiem.TabIndex = 0;
            this.bttNhapDiem.Text = "Nhập/Sửa Điểm";
            this.bttNhapDiem.UseVisualStyleBackColor = true;
            this.bttNhapDiem.Click += new System.EventHandler(this.bttNhapDiem_Click);
            // 
            // grP1
            // 
            this.grP1.Controls.Add(this.bttHuy);
            this.grP1.Controls.Add(this.bttLuu);
            this.grP1.Controls.Add(this.ns);
            this.grP1.Controls.Add(this.tbCN);
            this.grP1.Controls.Add(this.tbML);
            this.grP1.Controls.Add(this.tbSDT);
            this.grP1.Controls.Add(this.tbGT);
            this.grP1.Controls.Add(this.tbDC);
            this.grP1.Controls.Add(this.tbHT);
            this.grP1.Controls.Add(this.tbMSV);
            this.grP1.Controls.Add(this.label8);
            this.grP1.Controls.Add(this.label7);
            this.grP1.Controls.Add(this.label6);
            this.grP1.Controls.Add(this.label5);
            this.grP1.Controls.Add(this.label4);
            this.grP1.Controls.Add(this.label3);
            this.grP1.Controls.Add(this.label2);
            this.grP1.Controls.Add(this.label1);
            this.grP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grP1.Location = new System.Drawing.Point(3, 16);
            this.grP1.Name = "grP1";
            this.grP1.Size = new System.Drawing.Size(1138, 195);
            this.grP1.TabIndex = 0;
            this.grP1.Click += new System.EventHandler(this.grP1_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(744, 147);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(90, 26);
            this.bttHuy.TabIndex = 18;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(744, 15);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(90, 26);
            this.bttLuu.TabIndex = 17;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // ns
            // 
            this.ns.CustomFormat = "yyyy-MM-dd";
            this.ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ns.Location = new System.Drawing.Point(464, 104);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(225, 20);
            this.ns.TabIndex = 16;
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(467, 153);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(222, 20);
            this.tbCN.TabIndex = 15;
            // 
            // tbML
            // 
            this.tbML.Location = new System.Drawing.Point(467, 60);
            this.tbML.Name = "tbML";
            this.tbML.Size = new System.Drawing.Size(222, 20);
            this.tbML.TabIndex = 13;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(467, 12);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(222, 20);
            this.tbSDT.TabIndex = 12;
            // 
            // tbGT
            // 
            this.tbGT.Location = new System.Drawing.Point(116, 153);
            this.tbGT.Name = "tbGT";
            this.tbGT.Size = new System.Drawing.Size(222, 20);
            this.tbGT.TabIndex = 11;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(116, 104);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(222, 20);
            this.tbDC.TabIndex = 10;
            // 
            // tbHT
            // 
            this.tbHT.Location = new System.Drawing.Point(116, 53);
            this.tbHT.Name = "tbHT";
            this.tbHT.Size = new System.Drawing.Size(222, 20);
            this.tbHT.TabIndex = 9;
            // 
            // tbMSV
            // 
            this.tbMSV.Location = new System.Drawing.Point(116, 8);
            this.tbMSV.Name = "tbMSV";
            this.tbMSV.Size = new System.Drawing.Size(222, 20);
            this.tbMSV.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chuyên Nghành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Và Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1144, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fullname,
            this.address,
            this.gender,
            this.numberPhone,
            this.classID,
            this.dateOfBirth,
            this.specialized});
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(3, 16);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1138, 370);
            this.data.TabIndex = 0;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã Sinh Viên";
            this.ID.Name = "ID";
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Họ Và Tên";
            this.fullname.Name = "fullname";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa Chỉ";
            this.address.Name = "address";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới Tính";
            this.gender.Name = "gender";
            // 
            // numberPhone
            // 
            this.numberPhone.DataPropertyName = "numberPhone";
            this.numberPhone.HeaderText = "Số Điện Thoại";
            this.numberPhone.Name = "numberPhone";
            // 
            // classID
            // 
            this.classID.DataPropertyName = "classID";
            this.classID.HeaderText = "Mã Lớp";
            this.classID.Name = "classID";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "dateOfBirth";
            this.dateOfBirth.HeaderText = "Ngày Sinh";
            this.dateOfBirth.Name = "dateOfBirth";
            // 
            // specialized
            // 
            this.specialized.DataPropertyName = "specialized";
            this.specialized.HeaderText = "Chuyên Ngành";
            this.specialized.Name = "specialized";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbTK);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.bttTimKiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1144, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttXuat);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(756, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 53);
            this.panel1.TabIndex = 18;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(234, 11);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(142, 30);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã Lớp: ";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(64, 37);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(222, 20);
            this.tbTK.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 8;
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Location = new System.Drawing.Point(314, 33);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(93, 27);
            this.bttTimKiem.TabIndex = 6;
            this.bttTimKiem.Text = "Tìm Kiếm";
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "Excel Document(*.xlsx)|.xlsx";
            // 
            // ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinSinhVien";
            this.Text = "Quản Lý SInh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.grP2.ResumeLayout(false);
            this.grP1.ResumeLayout(false);
            this.grP1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel grP2;
        private System.Windows.Forms.Panel grP1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttXuat;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThemSV;
        private System.Windows.Forms.Button bttSuaTT;
        private System.Windows.Forms.Button bttNhapDiem;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.TextBox tbML;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbGT;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.TextBox tbHT;
        private System.Windows.Forms.TextBox tbMSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn classID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialized;
        private System.Windows.Forms.DateTimePicker ns;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

