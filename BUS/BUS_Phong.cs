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
        //lấy loại phòng
        public static List<Phong_DTO> takeKindROOM(string id)
        {
            return Phong_DAO.takeKindRoom(id);
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
        //update dịch vụ phòng

        public static bool updateServiceRoom(Phong_DTO P)
        {
            return Phong_DAO.UpdateServiceRoom(P);
        }
        // thêm phòng
        public static bool AddRooms(Phong_DTO P)
        {
            return Phong_DAO.AddRoom(P);
        }

        //xóa phòng

        public static bool deleteRooms(Phong_DTO P)
        {
            return Phong_DAO.DeleteRoom(P);
        }
        // sửa giá phòng
        public static bool UpdatePriceRooms(Phong_DTO P)
        {
            return Phong_DAO.UpdatePriceRoom(P);
        }

    }
}
