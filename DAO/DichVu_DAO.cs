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

        public static List<DichVu_DTO> takeServicesFId(string id)
        {
            string sQuery = @"select D.* from Phong P , DichVu D where P.MaDV = D.MaDV AND P.TinhTrang like N'%đ%' AND P.MaPhong = '" + id + "' ";
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
                K.TenDV = dt.Rows[i]["TenDV"].ToString();
                K.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                K.GiaDV = int.Parse(dt.Rows[i]["GiaDV"].ToString());

                Ser.Add(K);
            }
            return Ser;

        }

        public static List<DichVu_DTO> takeServicesTest()
        {
            string sQuery = @"select D.* from DichVu D";
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
                K.TenDV = dt.Rows[i]["TenDV"].ToString();
                K.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                K.GiaDV = int.Parse(dt.Rows[i]["GiaDV"].ToString());

                Ser.Add(K);
            }
            return Ser;

        }

        public static List<DichVu_DTO> takeServiceFIDSer(string IDDV)
        {
            string sQuery = @" select * from DichVu where MaDV ='" + IDDV + "' ";
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
                K.TenDV = dt.Rows[i]["TenDV"].ToString();
                K.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                K.GiaDV = int.Parse(dt.Rows[i]["GiaDV"].ToString());

                Ser.Add(K);
            }
            return Ser;
        }

        // thêm dịch vụ

        //public static bool AddService(DichVu_DTO dv)
        //{
        //    string sQuery = string.Format(@"insert into NhanVien values('{0}',N'{1}',N'{2}','{3}',N'{4}')", nv.MaNV, nv.TenNV, nv.ChucVu, nv.NamSinh, nv.GioiTinh);
        //    conn = DataProvider.Connect();
        //    bool kq = DataProvider.queryWithoutData(sQuery, conn);
        //    DataProvider.DongKetNoi(conn);
        //    return kq;

        //}

        // thêm update số lượng dịch vụ 
        public static bool UpdateSoLuong(DichVu_DTO  DT)
        {
            string sQuery = string.Format(@"update DichVu set SoLuong='{0}' where MaDV='{1}'",DT.SoLuong,DT.MaDV);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }
    }
}
