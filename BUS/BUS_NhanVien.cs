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
        public static NhanVien_DTO TakeAllIDEmployees(string ID)
        {
            return NhanVien_DAO.takeIDEmployees(ID);
        }


        public static bool AddAllEmployess(NhanVien_DTO nv)
        {
            return NhanVien_DAO.AddEmployees(nv);
        }

        public static List<NhanVien_DTO> loadALLChucVu()
        {
            return NhanVien_DAO.loadChucVu();
        }

        public static bool UpdateALLEmployess(NhanVien_DTO nv)
        {
            return NhanVien_DAO.UpdateEmployees(nv);
        }

        public static bool deleteALLEmployess(NhanVien_DTO nv)
        {
            return NhanVien_DAO.deleteEmployees(nv);
        }
    }
}
