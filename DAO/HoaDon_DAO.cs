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
  public  class HoaDon_DAO
    {
       static SqlConnection conn;
        public static bool AddInvoice(HoaDon_DTO HD)
        {
            string sQuery = string.Format(@"insert into HoaDon values('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}')",HD.MaHD, HD.MaNV, HD.MaPhong, HD.TenKH, HD.NgayDatPhong,HD.NgayTraPhong,HD.GiaHD);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }

        public static List<HoaDon_DTO> takeInvoice()
        {
            string sQuery = @"select *from HoaDon";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lst = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO HD = new HoaDon_DTO();              
                HD.MaHD = dt.Rows[i]["MaHD"].ToString();
                HD.MaNV = dt.Rows[i]["MaNV"].ToString();
                HD.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                HD.TenKH = dt.Rows[i]["TenKH"].ToString();
                HD.NgayDatPhong = DateTime.Parse(dt.Rows[i]["NgayDatPhong"].ToString());
                HD.NgayTraPhong = DateTime.Parse(dt.Rows[i]["NgayTraPhong"].ToString());
                HD.GiaHD = int.Parse(dt.Rows[i]["GiaHD"].ToString());
                lst.Add(HD);
            }
            return lst;

        }
    }
}
