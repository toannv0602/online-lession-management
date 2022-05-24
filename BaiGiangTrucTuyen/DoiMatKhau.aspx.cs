using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiGiangTrucTuyen
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChangepass_Click(object sender, EventArgs e)
        {
            DataTable data = AppCode.Database.Taikhoan.CheckPass(txtOldPass.Text);
            if (Session["SinhVien"] == null)
            {
                Response.Redirect("Dangnhap.aspx");
            }
            if(data.Rows.Count ==0)
            {
                lbThongBao.Text = "Bạn nhập sai mật khẩu cũ";
            }    
            else
            {
                string username = Session["SinhVien"].ToString();
                AppCode.Database.Taikhoan.ChangePass(username, txtOldPass.Text, txtNewPassWord.Text);
                Response.Redirect("Home.aspx");
                Response.Write("<script>alert('Đổi mật khẩu thành công')</script>");
            }
        }
    }
}