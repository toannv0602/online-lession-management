using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiGiangTrucTuyen.AppCode.Database;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class InsertTea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Giangvien.GV_Insert(txtMaGV.Text,txtHoTen.Text,txtPhone.Text,txtEmail.Text);
            Giangvien.GV_InsertAcc(txtMaGV.Text);
            Response.Redirect("AccStManagement.aspx");
            Response.Write("<script>alert('Thêm Thành Công')</script>");
        }
    }
}