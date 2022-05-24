using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiGiangTrucTuyen.AppCode.Database;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class DelAccSV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MaSV = "";
            if (Request.QueryString["MaSV"] != null)
            {
                MaSV = Request.QueryString["MaSV"];
            }
            
            SinhVien.SV_DelAcc(MaSV);
            SinhVien.SV_Del(MaSV);
            Response.Redirect("AccStManagement.aspx");
        }
    }
}