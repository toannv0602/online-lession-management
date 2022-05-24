using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
    public class Giangvien
    {
        public static DataTable LoadTea()
        {
            SqlCommand cmd = new SqlCommand("infoAccTea");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable LoadGVByMaGV(string MaGV)
        {
            SqlCommand cmd = new SqlCommand("infoAccTeBy_MaGV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maGV", MaGV);
            return SQLDatabase.GetData(cmd);
        }
        public static void AccountGV_Update(string hoten, string phone,
          string email, string MaGV)
        {
            SqlCommand cmd = new SqlCommand("updateteacher");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@maGV", MaGV);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void GV_Insert(string maGV, string tenGV,string sdt, string email)
        {
            SqlCommand cmd = new SqlCommand("insertGV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maGV", maGV);
            cmd.Parameters.AddWithValue("@tenGV", tenGV);
            cmd.Parameters.AddWithValue("@phone", sdt);
            cmd.Parameters.AddWithValue("@email ", email);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void GV_InsertAcc(string Tendangnhap)
        {
            SqlCommand cmd = new SqlCommand("insertaccGV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", Tendangnhap);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void GV_Del(string MaGV)
        {
            SqlCommand cmd = new SqlCommand("delGV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maGV", MaGV);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void GV_DelAcc(string MaGV)
        {
            SqlCommand cmd = new SqlCommand("delaccGV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maGV", MaGV);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}