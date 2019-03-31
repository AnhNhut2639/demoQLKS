using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
   public class BUS_Phong
    {
        public static List<Phong_DTO> TakeAllEmptyRooms()
        {
            return Phong_DAO.takeEmptyRooms();
        }
        public static List<Phong_DTO> TakeAllOderedRooms()
        {
            return Phong_DAO.takeOderedRooms();
        }
        public static List<Phong_DTO> TakeAllRooms()
        {
            return Phong_DAO.takeRooms();
        }
        public static List<Phong_DTO> takeALLRoomsFId(string id)
        {
            return Phong_DAO.takeRoomsFId(id);
        }

        // update tình trạng phòng
        public static bool UpdateStatusRoom(Phong_DTO P)
        {
            return Phong_DAO.UpdateStatusRoom(P);
        }

        //Update ngày đặt phòng
        public static bool UpdateDateRoom(Phong_DTO P)
        {
            return Phong_DAO.UpdateDateRoom(P);
        }
    }
}
