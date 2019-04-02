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
   public class DichVuDaDat_DAO
    {
        static SqlConnection conn;
        public static List<DichVuDaDat_DTO> takeServicesTest()
        {
            
            string sQuery = @"select D.* from DichVuDaDat D";           
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVuDaDat_DTO> Ser = new List<DichVuDaDat_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVuDaDat_DTO K = new DichVuDaDat_DTO();
                K.Id = int.Parse(dt.Rows[i]["id"].ToString());
                K.MaDV = dt.Rows[i]["MaDV"].ToString();
                K.TenDV = dt.Rows[i]["TenDV"].ToString();
                K.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                K.GiaDV = int.Parse(dt.Rows[i]["GiaDV"].ToString());
                
                Ser.Add(K);
            }
            return Ser;

        }

        public static List<DichVuDaDat_DTO> takeServiceFIDSer(string IDDV)
        {
            string sQuery = @" select * from DichVuDaDat where MaDV ='" + IDDV + "' ";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVuDaDat_DTO> Ser = new List<DichVuDaDat_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               DichVuDaDat_DTO K = new DichVuDaDat_DTO();
                K.Id = int.Parse(dt.Rows[i]["id"].ToString());
                K.MaDV = dt.Rows[i]["MaDV"].ToString();
                K.TenDV = dt.Rows[i]["TenDV"].ToString();
                K.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                K.GiaDV = int.Parse(dt.Rows[i]["GiaDV"].ToString());              
                Ser.Add(K);
            }
            return Ser;
        }

    }
}
