using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
    public class TaiLieu
    {
        public static DataTable getTaiLieuByMon(int maMon)
        {
            SqlCommand cmd = new SqlCommand("getByMaMon");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maMon", maMon);
            return SQLDatabase.GetData(cmd);
        }
        public static void InsertTaiLieu(int iMaMon, int iMaLopTC, string sTenFile, string sTenTL)
        {
            SqlCommand cmd = new SqlCommand("insertTaiLieu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iMaMon", iMaMon);
            cmd.Parameters.AddWithValue("@iMaLopTC", iMaLopTC);
            cmd.Parameters.AddWithValue("@sTenFile", sTenFile);
            cmd.Parameters.AddWithValue("@sTenTL", sTenTL);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable getAllTaiLieu()
        {
            SqlCommand cmd = new SqlCommand("getAllTaiLieu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}