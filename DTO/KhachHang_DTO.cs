using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHang_DTO
    {
        private string maKH;
        private string tenKH;
        private int cmnd;
        private string quocTich;
        private string gioiTinh;
        private DateTime ngaySinh;//
        private int sdt;
        private string maPhong;
        //thứ tự cột trong bảng khi hiện lên dgv sẽ được sắp xếp theo thứ tự ở đây
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }//
        public int Sdt { get => sdt; set => sdt = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
       
    }
}
