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
    }
}
