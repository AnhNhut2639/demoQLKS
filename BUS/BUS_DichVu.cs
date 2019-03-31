using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_DichVu
    {
        public static List<DichVu_DTO> TakeAllService(string IDKH)
        {
            return DichVu_DAO.takeServices(IDKH);
        }
        public static List<DichVu_DTO> takeAllServiceFId(string ID)
        {
            return DichVu_DAO.takeServicesFId(ID);
        }

        public static List<DichVu_DTO> takeAllServiceTest()
        {
            return DichVu_DAO.takeServicesTest();
        }

        public static List<DichVu_DTO> takeAllServiceFIdSer(string IDDV)
        {
            return DichVu_DAO.takeServiceFIDSer(IDDV);
        }
        //UPDATE Số lượng dịch vụ

        public static bool UpdateSoLuong(DichVu_DTO DT)
        {
            return DichVu_DAO.UpdateSoLuong(DT);
        }
    }
}