using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        public static List<TaiKhoan_DTO> takeALLAccount(string TenNV)
        {
            return TaiKhoan_DAO.takeAccount(TenNV);
        }
    }
}
