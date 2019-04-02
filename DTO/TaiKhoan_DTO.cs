using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan_DTO
    {
        private string maTk;
        private string taiKhoan;
        private string matKhau;
        private int trangThai;
        private string chuTich;
        private string fullName;
        private string maNV;

        public string MaTk { get => maTk; set => maTk = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string ChuTich { get => chuTich; set => chuTich = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
