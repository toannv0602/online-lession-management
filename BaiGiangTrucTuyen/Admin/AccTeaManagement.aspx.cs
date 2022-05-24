using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class AccTeaManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadGV();
            }    
        }
        private void LoadGV()
        {
            DataTable data = AppCode.Database.Giangvien.LoadTea();
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    LitTea.Text += @"
                                    	<tr>
                                            <td>" + data.Rows[i]["sMaGV"] + @"</td>
                                            <td>" + data.Rows[i]["sTenGV"] + @"</td>
                                            <td>" + data.Rows[i]["sSDT"] + @" </td>
                                            <td>" + data.Rows[i]["sEmail"] + @"</td>
                                            <td> <a href=EditAccTea.aspx?MaGV=" + data.Rows[i]["sMaGV"] + @" class= 'btn btn-success'>Sửa</a>
                                                 <a href='DelAccGV.aspx?MaGV=" + data.Rows[i]["sMaGV"] + @"' class= 'btn btn-danger'>Xóa</a>
                                            </td>
                                         </ tr >
                                   ";
                }
            }
        }

        protected void BtnThem_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertTea.aspx");
        }
    }
}