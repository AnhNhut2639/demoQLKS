using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
   public class DataProvider
    {
        public static SqlConnection Connect()
        {
            // string s = @"Data Source=DELIMA\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
            string s = @"Data Source=DELIMA\SQLEXPRESS;Initial Catalog=QLKS2;Integrated Security=True";
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            return conn;
        }
        //đóng kết nối 

        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }
        //thực hiện truy vấn và trả về bảng dữ liệu
        public static DataTable dataSQuery(string sQuery , SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sQuery, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;                
        }
        // truy vấn không lấy dữ liệu
        public static bool TruyVanKhongData(string Squery , SqlConnection connect)
        {
            try
            {
                SqlCommand cm = new SqlCommand(Squery, connect);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
