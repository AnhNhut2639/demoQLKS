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
   public class Phong_DAO
    {

        static SqlConnection conn;//= new SqlConnection(@"Data Source=DELIMA\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");      
        public static List<Phong_DTO> takeEmptyRooms()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select *from Phong where TinhTrang LIKE '%n%'", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            string sQuery = @"select *from Phong where TinhTrang LIKE '%n%'";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> lst = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                P.TenPhong = dt.Rows[i]["TenPhong"].ToString();
                P.LoaiPhong = dt.Rows[i]["LoaiPhong"].ToString();
                P.GiaPhong = int.Parse(dt.Rows[i]["GiaPhong"].ToString());
                P.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                P.NgayDatPhong = DateTime.Parse(dt.Rows[i]["NgayDatPhong"].ToString());
                P.MaNV = dt.Rows[i]["MaNV"].ToString();
                P.MaDV = dt.Rows[i]["MaDV"].ToString();
                lst.Add(P);
            }
            return lst;

        }
        public static List<Phong_DTO> takeOderedRooms()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select *from Phong where TinhTrang LIKE N'%đ%'", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            string sQuery = @"select *from Phong where TinhTrang LIKE N'%đ%'";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> lst = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                P.TenPhong = dt.Rows[i]["TenPhong"].ToString();
                P.LoaiPhong = dt.Rows[i]["LoaiPhong"].ToString();
                P.GiaPhong = int.Parse(dt.Rows[i]["GiaPhong"].ToString());
                P.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                P.NgayDatPhong = DateTime.Parse(dt.Rows[i]["NgayDatPhong"].ToString());
                P.MaNV = dt.Rows[i]["MaNV"].ToString();
                P.MaDV = dt.Rows[i]["MaDV"].ToString();
                lst.Add(P);
            }
            return lst;

        }
        public static List<Phong_DTO> takeRooms()
        {
            string sQuery = @"select *from Phong";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> lst = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                P.TenPhong = dt.Rows[i]["TenPhong"].ToString();
                P.LoaiPhong = dt.Rows[i]["LoaiPhong"].ToString();
                P.GiaPhong = int.Parse(dt.Rows[i]["GiaPhong"].ToString());
                P.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                P.NgayDatPhong = DateTime.Parse(dt.Rows[i]["NgayDatPhong"].ToString());
                P.MaNV = dt.Rows[i]["MaNV"].ToString();
                P.MaDV = dt.Rows[i]["MaDV"].ToString();
                lst.Add(P);
            }
            return lst;

        }
        public static List<Phong_DTO> takeRoomsFId(string id)
        {
            string sQuery = @"select * from Phong P where P.TinhTrang like N'%đ%' AND P.MaPhong= '"+id+"' ";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> lst = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                P.TenPhong = dt.Rows[i]["TenPhong"].ToString();
                P.LoaiPhong = dt.Rows[i]["LoaiPhong"].ToString();
                P.GiaPhong = int.Parse(dt.Rows[i]["GiaPhong"].ToString());
                P.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                P.NgayDatPhong = DateTime.Parse(dt.Rows[i]["NgayDatPhong"].ToString());
                P.MaNV = dt.Rows[i]["MaNV"].ToString();
                P.MaDV = dt.Rows[i]["MaDV"].ToString();
                lst.Add(P);
            }
            return lst;

        }
        //chọn phọng theo loại phòng
        public static List<Phong_DTO> takeKindRoom(string id)
        {
            string sQuery = @"select P.* from Phong P where LoaiPhong = N'" + id + "' ";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> lst = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO P = new Phong_DTO();
                P.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                P.TenPhong = dt.Rows[i]["TenPhong"].ToString();
                P.LoaiPhong = dt.Rows[i]["LoaiPhong"].ToString();
                P.GiaPhong = int.Parse(dt.Rows[i]["GiaPhong"].ToString());
                P.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                P.NgayDatPhong = DateTime.Parse(dt.Rows[i]["NgayDatPhong"].ToString());
                P.MaNV = dt.Rows[i]["MaNV"].ToString();
                P.MaDV = dt.Rows[i]["MaDV"].ToString();
                lst.Add(P);
            }
            return lst;

        }
        // update Phòng

        public static bool UpdateStatusRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"update Phong set TinhTrang = N'Đã đặt' where MaPhong='{0}'",P.MaPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        // update Ngày đặt phòng

        public static bool UpdateDateRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"update Phong set NgayDatPhong = '{0}' where MaPhong = '{1}'", P.NgayDatPhong,P.MaPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // update Dịch vụ Phòng
        public static bool UpdateServiceRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"update Phong set MaDV = '{0}' where MaPhong = '{1}'", P.MaDV, P.MaPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // thêm Phòng
        public static bool AddRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"insert into Phong(MaPhong,TenPhong,LoaiPhong,GiaPhong,TinhTrang,NgayDatPhong) values('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}')", P.MaPhong, P.TenPhong, P.LoaiPhong, P.GiaPhong, P.TinhTrang,P.NgayDatPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // xóa phòng 

        public static bool DeleteRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"delete from Phong where MaPhong = '{0}' ", P.MaPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // sửa giá phòng 
        public static bool UpdatePriceRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"update Phong set GiaPhong = '{0}' where LoaiPhong = N'{1}' ", P.GiaPhong,P.LoaiPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool UpdateEmptyRoom(Phong_DTO P)
        {
            string sQuery = string.Format(@"update Phong set TinhTrang = N'Trống' where MaPhong='{0}'", P.MaPhong);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

    }



}
