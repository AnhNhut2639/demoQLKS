using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class DichVu_DAO
    {
        static SqlConnection conn;
        public static List<DichVu_DTO> takeServices(string idKH)
        {
            string sQuery = @"select d.* from KhachHang k , DichVu d , Phong p where k.MaPhong = p.MaPhong and p.MaDV = d.MaDV and  k.MaKH = '" + idKH + "' ";
            // SqlDataAdapter da = new SqlDataAdapter(sQuery, con);
            //  DataTable dt = new DataTable();
            //da.Fill(dt);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> Ser = new List<DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO K = new DichVu_DTO();

                K.MaDV = dt.Rows[i]["MaDV"].ToString();
                K.TenDV= dt.Rows[i]["TenDV"].ToString();
                K.SoLuong= int.Parse(dt.Rows[i]["SoLuong"].ToString());
                K.GiaDV = int.Parse(dt.Rows[i]["GiaDV"].ToString());

                Ser.Add(K);
            }
            return Ser;

        }
    }
}
