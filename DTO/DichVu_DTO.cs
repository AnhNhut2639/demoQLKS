using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DichVu_DTO
    {
        private string maDV;
        private string tenDV;
        private int soLuong;
        private int giaDV;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaDV { get => giaDV; set => giaDV = value; }
    }
}
