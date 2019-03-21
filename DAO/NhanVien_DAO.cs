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
               N.NamSinh = dt.Rows[i]["NamSinh"].ToString();
                N.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();

                Emp.Add(N);
            }
            return Emp;
        }
    }
}
