﻿using System;
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
    }
}