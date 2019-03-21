using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Phong_DTO
    {
        private string maPhong;
        private string tenPhong;
        private string loaiPhong;
        private int giaPhong;
        private string tinhTrang;
        private string maNV;
        private string maDV;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaDV { get => maDV; set => maDV = value; }
    }
}
