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
    public class NhanVien_DAO
    {
        static SqlConnection conn;
        public static List<NhanVien_DTO> takeEmployees()
        {
            string sQuery = @"select *from NhanVien";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> Emp = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO N = new NhanVien_DTO();
                N.MaNV = dt.Rows[i]["MaNV"].ToString();
                N.TenNV = dt.Rows[i]["TenNV"].ToString();
                N.ChucVu = dt.Rows[i]["ChucVu"].ToString();
               N.NamSinh = DateTime.Parse(dt.Rows[i]["NamSinh"].ToString());
                N.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();

                Emp.Add(N);
            }
            return Emp;
        }

        // lấy chức vụ nhân viên
        public static List<NhanVien_DTO> loadChucVu()
        {
            string sQuery = @" select *from NhanVien where ChucVu like N'%n%'";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> Emp = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO N = new NhanVien_DTO();
                N.MaNV = dt.Rows[i]["MaNV"].ToString();
                N.TenNV = dt.Rows[i]["TenNV"].ToString();
                N.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                N.NamSinh = DateTime.Parse(dt.Rows[i]["NamSinh"].ToString());
                N.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();

                Emp.Add(N);
            }
            return Emp;
        }
        //   tìm nhân viên theo mã
        public static NhanVien_DTO takeIDEmployees(string ID)
        {
            string sQuery = @"select N.MaNV  from nhanvien N where N.MaNV = '" + ID + "'";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO N = new NhanVien_DTO();
            N.MaNV = dt.Rows[0]["MaNV"].ToString();
            N.TenNV = dt.Rows[0]["TenNV"].ToString();
            N.ChucVu = dt.Rows[0]["ChucVu"].ToString();
            N.NamSinh = DateTime.Parse(dt.Rows[0]["NamSinh"].ToString());
            N.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            return N;
        }
        // thêm nhân viên
        public static bool AddEmployees(NhanVien_DTO nv)
        {
            string sQuery = string.Format(@"insert into NhanVien values('{0}',N'{1}',N'{2}','{3}',N'{4}')",nv.MaNV,nv.TenNV,nv.ChucVu,nv.NamSinh,nv.GioiTinh );
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery,conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }

        public static bool UpdateEmployees(NhanVien_DTO nv)
        {
            string sQuery = string.Format(@"update NhanVien set TenNV=N'{0}',ChucVu=N'{1}',NamSinh='{2}',GioiTinh='{3}' where MaNV=N'{4}'",nv.TenNV, nv.ChucVu, nv.NamSinh, nv.GioiTinh,nv.MaNV);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }

        public static bool deleteEmployees(NhanVien_DTO nv)
        {
            string sQuery = string.Format(@"delete from nhanvien where manv=N'{0}'",nv.MaNV);
            conn = DataProvider.Connect();
            bool kq = DataProvider.queryWithoutData(sQuery, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }
    }
}
