using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
    public class MonHoc
    {
        
        public static DataTable loadMonDaDK(string maSV)
        {
            SqlCommand cmd = new SqlCommand("getMonByMaSV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable loadMonChuaDK(string maSV)
        {
            SqlCommand cmd = new SqlCommand("getMonChuaDKByMaSV");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable loadMonDaDKConLai(string maSV, int maMon)
        {
            SqlCommand cmd = new SqlCommand("getMonConLaiDaDK");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            cmd.Parameters.AddWithValue("@maMon", maMon);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable searchMonHocByTen(string maSV, string tenMon)
        {
            SqlCommand cmd = new SqlCommand("searchMonChuaDK");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            cmd.Parameters.AddWithValue("@tenMon", tenMon);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable loadTTMonHoc(int maMon, int maLopTC)
        {
            SqlCommand cmd = new SqlCommand("getTenMonGiangVien");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maMon", maMon);
            cmd.Parameters.AddWithValue("@maLopTC", maLopTC);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable loadDDLMon()
        {
            SqlCommand cmd = new SqlCommand("Laytenmonmamon");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable loadDDLLop()
        {
            SqlCommand cmd = new SqlCommand("LaytenLoptinchimaloptinchi");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}