using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiGiangTrucTuyen.AppCode.Database;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class DocumentManager : System.Web.UI.Page
    {
        string fileName = "";
        int MaMon = 0;
        int MaLop = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadMon();
            LoadLop();
            loadTaiLieu();
        }
        void LoadMon()
        {
            DataTable tb = new DataTable();
            tb = MonHoc.loadDDLMon();
            DDLLop.DataSource = tb;
            DDLLop.DataTextField = "sTenMon";
            DDLLop.DataValueField = "iMaMon";
            DDLLop.DataBind();
            MaMon = Convert.ToInt32(DDLLop.SelectedValue);
            //for (int i = 0; i < tb.Rows.Count; i++)
            //{
            //    DDLLop.Text = tb.Rows[i]["sTenMon"].ToString();
            //    DDLLop.SelectedValue = tb.Rows[i]["iMaMon"].ToString();
            //}
        }
        void LoadLop()
        {
            DataTable tb = new DataTable();
            tb = MonHoc.loadDDLLop();
            DDLMon.DataSource = tb;
            DDLMon.DataTextField = "sTenLopTC";
            DDLMon.DataValueField = "iMaLopTC";
            DDLMon.DataBind();
            MaLop = Convert.ToInt32(DDLLop.SelectedValue);
            //for (int i = 0; i < tb.Rows.Count; i++)
            //{
            //    DDLLop.Text = tb.Rows[i]["sTenLopTC"].ToString();
            //    DDLLop.SelectedValue= tb.Rows[i]["iMaLopTC"].ToString();
            //}
        }
        void UpLoadFile()
        {
            if (Page.IsValid && FileUpload.HasFile)
            {
                fileName = "../TaiLieu/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + FileUpload.FileName;
                string filePath = MapPath(fileName);
                FileUpload.SaveAs(filePath);
            }
        }

        void loadTaiLieu()
        {
            DataTable tb = new DataTable();
            tb = TaiLieu.getAllTaiLieu();
            
            List<string> filePaths = new List<string>();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                filePaths.Add(tb.Rows[i]["sTenFile"].ToString());

            }
            
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Tên tài liệu", typeof(string));
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                
                dt1.Rows.Add(tb.Rows[i]["sTenTL"].ToString());
            }

            GridView1.DataSource = dt1;
            GridView1.DataBind();

            DataTable dt = new DataTable();
            dt.Columns.Add("Danh sách tài liệu", typeof(string));
            foreach (string filePath in filePaths)
            {
                
                FileInfo fi = new FileInfo(filePath);
                dt.Rows.Add(fi.Name);
            }
            GridView.DataSource = dt;
            GridView.DataBind();
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
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

            void ThemTaiLieu()
        {
            TaiLieu.InsertTaiLieu(MaMon, MaLop, fileName,txtTenTL.Text);
        }
        protected void btnUpLoad_Click(object sender, EventArgs e)
        {
            UpLoadFile();
            ThemTaiLieu();
        }

        
        protected void btnXemTL_Click(object sender, EventArgs e)
        {
            loadTaiLieu();
        }
    }
}