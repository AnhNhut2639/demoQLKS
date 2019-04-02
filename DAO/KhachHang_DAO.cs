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
                K.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                K.Sdt = int.Parse(dt.Rows[i]["SDT"].ToString());
                K.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                Cus.Add(K);
            }
            DataProvider.DongKetNoi(conn);
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
                K.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                K.Sdt = int.Parse(dt.Rows[i]["SDT"].ToString());
                K.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                Cus.Add(K);
            }
            DataProvider.DongKetNoi(conn);
            return Cus;

        }
        public static List<KhachHang_DTO> takeCustomerFIdPhong(string id)
        {

            string sQuery = @"select k.* from Phong p , KhachHang K where p.MaPhong = k.MaPhong and p.MaPhong = '" + id + "' ";
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
                K.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                K.Sdt = int.Parse(dt.Rows[i]["SDT"].ToString());
              //  K.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                Cus.Add(K);
            }
            return Cus;
          //  DataProvider.DongKetNoi(conn);
        }
        // thêm khách hàng 

        public static bool AddCustomers(KhachHang_DTO KH)
        {
            string sQuery = string.Format(@"insert into KhachHang values('{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}','{7}')", KH.MaKH,KH.TenKH, KH.Cmnd,KH.QuocTich, KH.GioiTinh,KH.NgaySinh,KH.Sdt,KH.MaPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }

        // xóa khách hàng 
        public static bool deleteCustomers(KhachHang_DTO KH)
        {
            string sQuery = string.Format(@"delete from KhachHang where MaKH = '{0}'", KH.MaKH);
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }
    }
    
}
