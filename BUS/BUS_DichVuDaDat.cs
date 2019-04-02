using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
  public class BUS_DichVuDaDat
    {
        public static List<DichVuDaDat_DTO> takeALLServiced()
        {
            return DichVuDaDat_DAO.takeServicesTest();
        }
        public static List<DichVuDaDat_DTO> takeAllServicedFIdSer(string IDDV)
        {
            return DichVuDaDat_DAO.takeServiceFIDSer(IDDV);
        }
    }
}
