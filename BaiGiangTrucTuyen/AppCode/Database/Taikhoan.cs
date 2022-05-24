using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
    public class Taikhoan
    {
        public static DataTable Login(string nameLogin, string password)
        {
            SqlCommand cmd = new SqlCommand("LoginTaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sTenDangNhap", nameLogin);
            cmd.Parameters.AddWithValue("@sPassword", password);

            return SQLDatabase.GetData(cmd);
        }
        public static DataTable LoginAd(string nameLogin, string password)
        {
            SqlCommand cmd = new SqlCommand("LoginTaiKhoanAd");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sTenDangNhap", nameLogin);
            cmd.Parameters.AddWithValue("@sPassword", password);

            return SQLDatabase.GetData(cmd);
        }
        public static DataTable LoginTe(string nameLogin, string password)
        {
            SqlCommand cmd = new SqlCommand("LoginTaiKhoanTea");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sTenDangNhap", nameLogin);
            cmd.Parameters.AddWithValue("@sPassword", password);

            return SQLDatabase.GetData(cmd);
        }
        public static void ChangePass(string taikhoan, string matkhaucu,string matkhaumoi)
        {
            SqlCommand cmd = new SqlCommand("changePass");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nameLogin", taikhoan);
            cmd.Parameters.AddWithValue("@matKhauCu", matkhaucu);
            cmd.Parameters.AddWithValue("@matKhau", matkhaumoi);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable CheckPass(string matkhau)
        {
            SqlCommand cmd = new SqlCommand("TakePass");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sPassword ", matkhau);

            return SQLDatabase.GetData(cmd);
        }

    }
}