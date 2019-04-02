using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_HoaDon
    {
        public static bool AddInvoice(HoaDon_DTO HD)
        {
            return HoaDon_DAO.AddInvoice(HD);
        }
        public static List<HoaDon_DTO> takeInvoice()
        {
            return HoaDon_DAO.takeInvoice();
        }
    }
}
