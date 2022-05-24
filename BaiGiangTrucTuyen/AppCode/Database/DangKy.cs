using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
    public class DangKy
    {
        public static void insertDangKy(string maSV, int maLopTC, DateTime tgDK)
        {
            SqlCommand cmd = new SqlCommand("insertDangKy");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSV", maSV);
            cmd.Parameters.AddWithValue("@maLopTC", maLopTC);
            cmd.Parameters.AddWithValue("@tGDK", tgDK);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}