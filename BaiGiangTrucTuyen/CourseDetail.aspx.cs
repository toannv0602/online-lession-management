using BaiGiangTrucTuyen.AppCode.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiGiangTrucTuyen
{
    public partial class CourseDetail : System.Web.UI.Page
    {
        private int maMon = -1, maLopTC = -1;
        private string status = "";
        private  string maSV = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["maMon"] != null)
            {
                maMon = Int32.Parse(Request.QueryString["maMon"]);
            }
            if (Request.QueryString["maLopTC"] != null)
            {
                maLopTC = Int32.Parse(Request.QueryString["maLopTC"]);
            }
            if (Request.QueryString["status"] != null)
            {
                status = Request.QueryString["status"];
                if (status == "dangky")
                {
                    insertDK(maLopTC, maSV);
                }
            }

            if (Session["SinhVien"] == null)
            {
                Response.Redirect("Dangnhap.aspx");
            }
            else
            {
                maSV = Session["SinhVien"].ToString();
                loadFileMonHoc(maMon);
                hienTTMonHoc(maMon, maLopTC);
                hienListMonConLai(maSV, maMon);
            }
        }

        private void loadFileMonHoc(int maMon)
        {
            DataTable tb = new DataTable();
            tb = TaiLieu.getTaiLieuByMon(maMon);
            List<string> filePaths = new List<string>();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                filePaths.Add(tb.Rows[i]["sTenFile"].ToString());
            }
            //string[] filePaths = Directory.GetFiles(Server.MapPath("~/TaiLieu/"));
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Tên tài liệu", typeof(string));
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                dt1.Rows.Add(tb.Rows[i]["sTenTL"].ToString());
            }

            GridView2.DataSource = dt1;
            GridView2.DataBind();

            DataTable dt = new DataTable();
            dt.Columns.Add("Danh sách tài liệu", typeof(string));
            foreach (string filePath in filePaths)
            {
                FileInfo fi = new FileInfo(filePath);
                dt.Rows.Add(fi.Name);
                //    ltr.Text += @"<input type='button' value='"+fi.Name+ @"' runat='server'>";
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                Response.Clear();
                Response.ContentType = "application/octect-stream";
                Response.AppendHeader("content-disposition", "filename="
                    + e.CommandArgument);
                Response.TransmitFile(Server.MapPath("~/TaiLieu/")
                    + e.CommandArgument);
                Response.End();
            }
        }

        private void hienListMonConLai(string maSV, int maMon)
        {
            int index = 1;
            DataTable tb = new DataTable();
            tb = MonHoc.loadMonDaDKConLai(maSV, maMon);
            ltrListMon.Text = "";
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                //@ lay ca chuoi
                ltrListMon.Text += @"<a href = 'CourseDetail.aspx?maMon=" + tb.Rows[i]["iMaMon"] + @"&maLopTC=" + tb.Rows[i]["iMaLopTC"] + @"' ><div class='featured-item'>
                                    <img src = 'assets/images/khoahoc.jpg' alt='Item 1'>
                                    <h4>" + tb.Rows[i]["sTenMon"] + @"<h4>
                                    <h6>" + tb.Rows[i]["sTenLopTC"] + @"</h6>
                                    </div>
                                    </a>";
            }
        }

        private void hienTTMonHoc(int maMon, int maLopTC)
        {
            DataTable tb = new DataTable();
            tb = MonHoc.loadTTMonHoc(maMon, maLopTC);
            ltrTenMon.Text = tb.Rows[0]["sTenMon"].ToString();
            ltrTenLopTC.Text = tb.Rows[0]["sTenLopTc"].ToString();
            ltrTenGV.Text = tb.Rows[0]["sTenGV"].ToString();
            ltrEmailGV.Text = tb.Rows[0]["sEmail"].ToString();
        }

        private void insertDK(int maLopTC, string MaHS)
        {
            if (maLopTC != -1)
            {
                MaHS = Session["SinhVien"].ToString();
                DateTime tGDK = DateTime.Now;
                DangKy.insertDangKy(MaHS, maLopTC, tGDK);
                Response.Write("<script>alert('Ban da dang ky thanh cong!')</script>");
            }
        }
    }
}