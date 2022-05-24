using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiGiangTrucTuyen.Admin
{
    public partial class AccManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHocSinh();
            }
        }
        private void LoadHocSinh()
        {
            //string username = Session["admin"].ToString();
            DataTable data = AppCode.Database.SinhVien.LoadST();
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    LitST.Text += @"
                                    	<tr>
                                            <td>" + data.Rows[i]["sMaSV"]+ @"</td>
                                            <td>" + data.Rows[i]["sTenSV"] + @"</td>
                                            <td>" + data.Rows[i]["sLop"] + @" </td>
                                            <td>" + data.Rows[i]["sGioiTinh"] + @"</td>
                                            <td>" + data.Rows[i]["dNgaySinh"] + @" </td>
                                            <td>" + data.Rows[i]["sEmail"]+ @"</td>
                                            <td> <a href='EditAccSt.aspx?MaSV="+data.Rows[i]["sMaSV"]+ @"' class= 'btn btn-success'>Sửa</a>
                                                 <a href='DelAccSV.aspx?MaSV=" + data.Rows[i]["sMaSV"] + @"' class= 'btn btn-danger'>Xóa</a>
                                            </td>
                                         </ tr >
                                   ";
                }
            }
        }

        protected void BtnThem_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertST.aspx");
        }
    }
}