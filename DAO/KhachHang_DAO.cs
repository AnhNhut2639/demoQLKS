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
   public class KhachHang_DAO
    {
        // static SqlConnection con = new SqlConnection(@"Data Source=DELIMA\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        static SqlConnection conn;
        public static List<KhachHang_DTO> takeCustomers()
        {
            string sQuery = @"select *from KhachHang";
            // SqlDataAdapter da = new SqlDataAdapter(sQuery, con);
            //  DataTable dt = new DataTable();
            //da.Fill(dt);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> Cus = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO K = new KhachHang_DTO();
                
                K.MaKH= dt.Rows[i]["MaKH"].ToString();
                K.TenKH= dt.Rows[i]["TenKH"].ToString();
                K.Cmnd = int.Parse(dt.Rows[i]["CMND"].ToString());
                K.QuocTich = dt.Rows[i]["QuocTich"].ToString();
                K.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                K.Tuoi = int.Parse(dt.Rows[i]["Tuoi"].ToString());
                K.Sdt = int.Parse(dt.Rows[i]["SDT"].ToString());
                K.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                Cus.Add(K);
            }
            return Cus;

        }
        public static List<KhachHang_DTO> takeCustomersFID(string id)
        {
            string sQuery = @"select k.* from Phong p, KhachHang k WHERE p.MaPhong= k.MaPhong And p.MaPhong = '" + id + "' ";
            //where p.MaPhong = k.MaPhong AND p.MaPhong = 'P003'
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> Cus = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO K = new KhachHang_DTO();

                K.MaKH = dt.Rows[i]["MaKH"].ToString();
                K.TenKH = dt.Rows[i]["TenKH"].ToString();
                K.Cmnd = int.Parse(dt.Rows[i]["CMND"].ToString());
                K.QuocTich = dt.Rows[i]["QuocTich"].ToString();
                K.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                K.Tuoi = int.Parse(dt.Rows[i]["Tuoi"].ToString());
                K.Sdt = int.Parse(dt.Rows[i]["SDT"].ToString());
                K.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                Cus.Add(K);
            }
            return Cus;

        }

    }
    
}
