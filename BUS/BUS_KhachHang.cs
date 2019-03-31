using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_KhachHang
    {
        public static List<KhachHang_DTO> TakeAllCustomers()
        {
            return KhachHang_DAO.takeCustomers();
            //test Git
        }
        public static List<KhachHang_DTO> takeCustomerAllID(string ID)
        {
            return KhachHang_DAO.takeCustomersFID(ID);
        }

        public static List<KhachHang_DTO> takeAllCustomerFiDPhong(string id)
        {
            return KhachHang_DAO.takeCustomerFIdPhong(id);
        }

        // thêm khách hàng 

        public static bool AddCustomer(KhachHang_DTO KH)
        {
            return KhachHang_DAO.AddCustomers(KH);
        }
    }
}
