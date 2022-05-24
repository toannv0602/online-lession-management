using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiGiangTrucTuyen.AppCode.Database;
namespace BaiGiangTrucTuyen.Admin
{
    public partial class DelAccGV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MaGV = "";
            if (Request.QueryString["MaGV"] != null)
            {
                MaGV = Request.QueryString["MaGV"];
            }

            SinhVien.SV_DelAcc(MaGV);
            SinhVien.SV_Del(MaGV);
            Response.Redirect("AccStManagement.aspx");
        }
    }
}