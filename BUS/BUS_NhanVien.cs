using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class BUS_NhanVien
    {
        public static List<NhanVien_DTO> takeAllEmployees()
        {
            return NhanVien_DAO.takeEmployees();

        }
    }
}
