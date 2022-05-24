using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
    public class SinhVien
    {
        public static DataTable LoadST()
        {
            SqlCommand cmd = new SqlCommand("infoAccSt");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable LoadSVByMaSV( string MaSV)
        {
            SqlCommand cmd = new SqlCommand("infoAccStBy_MaSV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", MaSV);
            return SQLDatabase.GetData(cmd);
        }
        public static void AccountST_Update(string hoten, string lop, string gioiTinh, string ngaysinh,
          string email,string MaSV)
        {
            SqlCommand cmd = new SqlCommand("updatestudent");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
            cmd.Parameters.AddWithValue("@lop ", lop);
            cmd.Parameters.AddWithValue("@ngaysinh",ngaysinh);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@masv", MaSV);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void ST_Insert(string maSV, string tenSV, string lop,string gioitinh,string ngaysinh, string email)
        {
            SqlCommand cmd = new SqlCommand("insertST");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            cmd.Parameters.AddWithValue("@tenSV ", tenSV);
            cmd.Parameters.AddWithValue("@sGioiTinh", gioitinh);
            cmd.Parameters.AddWithValue("@tenLop", lop);
            cmd.Parameters.AddWithValue("@dNgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@email ", email);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void ST_InsertAcc(string Tendangnhap)
        {
            SqlCommand cmd = new SqlCommand("insertaccST");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", Tendangnhap);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void SV_DelAcc(string MaSV)
        {
            SqlCommand cmd = new SqlCommand("delaccSV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", MaSV);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void SV_Del(string MaSV)
        {
            SqlCommand cmd = new SqlCommand("delSV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", MaSV);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable getByMaSV(string maSV)
        {
            SqlCommand cmd = new SqlCommand("getSVByMa");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            return SQLDatabase.GetData(cmd);
        }


    }
}