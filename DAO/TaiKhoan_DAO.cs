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
   public class TaiKhoan_DAO
    {
        static SqlConnection conn;
        public static List<TaiKhoan_DTO> takeAccount(string TenNV)
        {
            string sQuery = @" select T.* from TaiKhoan T where FullName =N'" + TenNV+ "' ";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.dataSQuery(sQuery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> Acc = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO K = new TaiKhoan_DTO();
                K.MaTk = dt.Rows[i]["MaTK"].ToString();
                K.TaiKhoan = dt.Rows[i]["TaiKhoan"].ToString();
                K.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                K.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                K.ChuTich = dt.Rows[i]["ChuTich"].ToString();
                K.FullName = dt.Rows[i]["FullName"].ToString();
                K.MaNV = dt.Rows[i]["MaNV"].ToString();
                Acc.Add(K);
            }
            return Acc;
        }
        //public static bool SubmitPass(string id)
        //{
        //    string sQuery = @"select MatKhau from TaiKhoan where TaiKhoan = '" + id + "' ";
        //    conn = DataProvider.Connect();
        //    bool kq = DataProvider.queryWithoutData(sQuery, conn);
        //    DataProvider.DongKetNoi(conn);
        //    return kq;
        //}

        //public static List<TaiKhoan_DTO> SubmitPass(string id)
        //{
        //    string sQuery = @"select T.MatKhau from TaiKhoan T where TaiKhoan = '" + id + "' ";
        //    conn = DataProvider.Connect();
        //    DataTable dt = DataProvider.dataSQuery(sQuery, conn);
        //    if (dt.Rows.Count == 0)
        //    {           
        //        return null;
        //    }
        //    List<TaiKhoan_DTO> Acc = new List<TaiKhoan_DTO>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        TaiKhoan_DTO K = new TaiKhoan_DTO();
        //     //   K.MaTk = dt.Rows[i]["MaTK"].ToString();
        //      //  K.TaiKhoan = dt.Rows[i]["TaiKhoan"].ToString();
        //        K.MatKhau = dt.Rows[i]["MatKhau"].ToString();
        //        //K.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
        //        //K.ChuTich = dt.Rows[i]["ChuTich"].ToString();
        //        //K.FullName = dt.Rows[i]["FullName"].ToString();
        //        //K.MaNV = dt.Rows[i]["MaNV"].ToString();
        //        Acc.Add(K);
        //    }
        //    return Acc;
        //}
    }
}
