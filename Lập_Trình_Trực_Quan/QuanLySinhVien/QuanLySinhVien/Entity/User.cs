using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Entity
{
    class User
    {
        private int tendangnhap;
        private DateTime matkhau;

        // đổ vào datatable hoặc dataset

        public User() { }

        private int TenDangNhap { get => tendangnhap; set => tendangnhap = value; }
        private DateTime MatKhau { get => matkhau; set => matkhau = value; }
    }
}
