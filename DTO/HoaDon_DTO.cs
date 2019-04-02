using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class HoaDon_DTO
    {
        private string maHD;
        private string maNV;
        private string maPhong;
        private string tenKH;
        private DateTime ngayDatPhong;
        private DateTime ngayTraPhong;
        private int giaHD;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
        public int GiaHD { get => giaHD; set => giaHD = value; }
    }
}
