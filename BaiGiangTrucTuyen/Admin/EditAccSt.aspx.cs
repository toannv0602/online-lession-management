using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiGiangTrucTuyen.AppCode.Database;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class EditAccSt : System.Web.UI.Page     
    {
      

        protected void Page_Load(object sender, EventArgs e)
        {
            string MaSV = "";
            if (Request.QueryString["MaSV"] != null)
            {
               MaSV = Request.QueryString["MaSV"];
            }
            if(!IsPostBack)
            {
                LoadThongTinHocSinh(MaSV);
            }    
            
        }
        private void LoadThongTinHocSinh( string MaSV)
        {
            DataTable data = SinhVien.LoadSVByMaSV(MaSV);
            if(data.Rows.Count>0)
            {
                txtMaSV.ReadOnly = true;
                txtMaSV.Text = data.Rows[0]["sMaSV"].ToString();
                txtHoTen.Text = data.Rows[0]["sTenSV"].ToString();
                txtLop.Text = data.Rows[0]["sLop"].ToString();
                txtGioiTinh.Text = data.Rows[0]["sGioiTinh"].ToString();
                txtNgaySinh.Text = data.Rows[0]["dNgaySinh"].ToString();
                txtEmail.Text = data.Rows[0]["sEmail"].ToString();
            }
        }
        protected void txtEdit_Click(object sender, EventArgs e)
        {
            string MaSV = "";
            if (Request.QueryString["MaSV"] != null)
            {
                MaSV = Request.QueryString["MaSV"];
            }
            SinhVien.AccountST_Update(txtHoTen.Text,txtLop.Text,txtGioiTinh.Text,txtNgaySinh.Text,txtEmail.Text,MaSV);
            Response.Redirect("AccStManagement.aspx");
            Response.Write("<script>alert('Sửa thành công')</script>");
        }
    }
}