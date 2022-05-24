using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiGiangTrucTuyen.AppCode.Database;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class EditAccTea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MaGV = "";
            if (Request.QueryString["MaGV"] != null)
            {
                MaGV = Request.QueryString["MaGV"];
            }
            if (!IsPostBack)
            {
                LoadThongTinHocSinh(MaGV);
            }
           
        }
        private void LoadThongTinHocSinh(string MaGV)
        {
            DataTable data = Giangvien.LoadGVByMaGV(MaGV);
            if (data.Rows.Count > 0)
            {
                txtMaGV.ReadOnly = true;
                txtMaGV.Text = data.Rows[0]["sMaGV"].ToString();
                txtHoTen.Text = data.Rows[0]["sTenGV"].ToString();
                txtEmail.Text = data.Rows[0]["sEmail"].ToString();
                txtPhone.Text = data.Rows[0]["sSDT"].ToString();
            }
        }

        protected void txtEdit_Click(object sender, EventArgs e)
        {
            string MaGV = "";
            if (Request.QueryString["MaGV"] != null)
            {
                MaGV = Request.QueryString["MaGV"];
            }
            Giangvien.AccountGV_Update(txtHoTen.Text,txtPhone.Text,txtEmail.Text,MaGV);
            Response.Redirect("AccTeaManagement.aspx");
            Response.Write("<script>alert('Sửa thành công')</script>");
        }
    }
}