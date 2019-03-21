using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
   public class Account_DAO
    {
        static SqlConnection conn;
        //public static List<DangNhap_DTO> getNameUser()
        //{
        //    string sQuery = "select *from TaiKhoan";
        //    conn = DataProvider.Connect();
        //    DataTable dt = DataProvider.dataSQuery(sQuery, conn);

        //    if (dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    List<DangNhap_DTO> Acc = new List<DangNhap_DTO>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DangNhap_DTO N = new DangNhap_DTO();
        //        N.MaTK = dt.Rows[i]["MaTK"].ToString();
        //        N.Account = dt.Rows[i]["TaiKhoan"].ToString();
        //        N.PassWord = dt.Rows[i]["MatKhau"].ToString();
        //        N.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
        //        N.Note = dt.Rows[i]["Note"].ToString();


        //        Acc.Add(N);
        //    }
        //    return Acc;
        //}
        public static bool Login(string userName , string passWord)
        {
            
            string sQuery = "SELECT * FROM TaiKhoan WHERE TaiKhoan= '" + userName + "' AND MatKhau = '" + passWord + "' ";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
          
            return dt.Rows.Count > 0;
        }
        public static string getNameUser(string userName, string passWord)
        {
            string nameUser = " ";
           if( Login(userName, passWord) ) // nếu login đăng nhập thành công thì sẽ tiến hành chọn ra tên người đăng nhập 
            {
                string sQuery = "select FullName from TaiKhoan WHERE TaiKhoan= '" + userName + "' AND MatKhau = '" + passWord + "'";
                conn = DataProvider.Connect();
                DataTable dt = DataProvider.dataSQuery(sQuery, conn);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        nameUser = dr["FullName"].ToString();

                    }
                }
            }               
            return nameUser;
        }
        public static int getID(string userName, string passWord)
        {
            // string getID = "";
            int getID = 0;
            if (Login(userName, passWord)) // nếu login đăng nhập thành công thì sẽ tiến hành chọn ra tên người đăng nhập 
            {
                string sQuery = "select TrangThai from TaiKhoan WHERE TaiKhoan= '" + userName + "' AND MatKhau = '" + passWord + "'";
                conn = DataProvider.Connect();
                DataTable dt = DataProvider.dataSQuery(sQuery, conn);
                if (dt != null)
                {
                   // foreach (DataRow dr in dt.Rows)
                   //  {
                   for (int i = 0; i < dt.Rows.Count; i++)
                       {
                        // getID = dr["TrangThai"].ToString();
                        //getID = int.Parse(dr["TinhTrang"]);
                        getID =  int.Parse(dt.Rows[i]["TrangThai"].ToString());

                    }
                }
            }
            return getID;
        }
        public static string getChucVu(string userName, string passWord)
        {
            string chucVuUser = " ";
            if (Login(userName, passWord)) // nếu login đăng nhập thành công thì sẽ tiến hành chọn ra tên người đăng nhập 
            {
                
                string sQuery = "select ChuTich from TaiKhoan WHERE TaiKhoan= '" + userName + "' AND MatKhau = '" + passWord + "'";
                conn = DataProvider.Connect();
                DataTable dt = DataProvider.dataSQuery(sQuery, conn);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                       chucVuUser = dr["ChuTich"].ToString();

                    }
                }
            }
            return chucVuUser;
        }
    }
}
