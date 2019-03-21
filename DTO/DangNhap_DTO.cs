using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        private string maTK;
        private string account;
        private string passWord;
        private int trangThai;
        private string note;
        private string fullName;

        public string MaTK { get => maTK; set => maTK = value; }
        public string Account { get => account; set => account = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string Note { get => note; set => note = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }
    
}
