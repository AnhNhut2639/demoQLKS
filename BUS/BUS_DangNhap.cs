using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class BUS_DangNhap
    {
        public static bool TakeAllAccounts(string userName,string passWord)
        {
            return Account_DAO.Login(userName, passWord);
        }

        //public static List<DangNhap_DTO> takeTaiKhoan()
        //{
        //    return Account_DAO.takeAccount();
        //}
        public static string getAllName(string user,string pass)
        {
            return Account_DAO.getNameUser(user, pass);
        }

        public static int getPer(string userID, string passID)
        {
            return Account_DAO.getID(userID, passID);
        }
        public static string getAllChucVu(string userCV, string passCV)
        {
            return Account_DAO.getChucVu(userCV, passCV);
        }
    }
}
