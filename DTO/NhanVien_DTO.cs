using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 public   class NhanVien_DTO
    {
        private string maNV;
        private string tenNV;
        private string chucVu;
        private string namSinh;
        private string gioiTinh;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
