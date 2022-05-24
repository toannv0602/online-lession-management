using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiGiangTrucTuyen.AppCode.Database
{
        public class SQLDatabase
        {
            //lấy chuỗi kết nối
            private static string _connectionString = string.Empty;
            public static string ConnectionString
            {
                get
                {
                    if (_connectionString.Equals(""))
                    {
                        _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    }
                    return _connectionString;
                }
                set
                {
                    _connectionString = value;
                }
            }

            // mở chuỗi kết nối
            public static SqlConnection GetConnection()
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();
                return conn;
            }

            //thực hiện truy vấn ko cần trả về kết quả (delete,update,inser)
            public static void ExecuteNoneQuery(SqlCommand cmd)
            {
                if (cmd.Connection != null)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlConnection conn = GetConnection();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
            }

            //phương thức lấy dữ liệu trả về dataTable
            public static DataTable GetData(SqlCommand cmd)
            {
                if (cmd.Connection != null)
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
                else
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        cmd.Connection = conn;
                        using (DataSet ds = new DataSet())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(ds);
                                return ds.Tables[0];
                            }
                        }
                    }
                }
            }

            //phương thức lấy dữ liệu trả về tất cả các dataTable
            public static DataSet GetData_OverDataset(SqlCommand cmd)
            {
                if (cmd.Connection != null)
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
                else
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        cmd.Connection = conn;
                        using (DataSet ds = new DataSet())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(ds);
                                return ds;
                            }
                        }
                    }
                }
            }
        }
    }
