using BaiGiangTrucTuyen.AppCode.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiGiangTrucTuyen
{
    public partial class Courses : System.Web.UI.Page
    {
        string maSV = "";

        public string MaSV { get => maSV; set => maSV = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["SinhVien"] == null)
            {
                Response.Redirect("Dangnhap.aspx");
            }
            else
            {
                MaSV = Session["SinhVien"].ToString();
                loadListMon(MaSV);
                string tenMon = Request.Form.Get("tenMon");
            }
            

        }

        public void loadListMon(string maSV)
        {

            int index = 1;
            DataTable tb = new DataTable();
            tb = MonHoc.loadMonChuaDK(maSV);
            ltrListMon.Text = "";
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                //@ lay ca chuoi
                ltrListMon.Text += @" <div id='" + index + @"' class='item col-md-4'>
                                     <a href = 'CourseDetail.aspx?maMon=" + tb.Rows[i]["iMaMon"] + @"&maLopTC=" + tb.Rows[i]["iMaLopTC"] + @"' >
                                      <div class='featured-item'>
                                      <img src = 'assets/images/khoahoc2.jpg' alt=''>
                                      <h4>" + tb.Rows[i]["sTenMon"] + @"</h4>
                                      <h6>" + tb.Rows[i]["sTenLopTC"] + @"</h6>
                                       <div class='mx-auto mt-5'>
                                            <a href = 'CourseDetail.aspx?maMon=" + tb.Rows[i]["iMaMon"] + @"&maLopTC=" + tb.Rows[i]["iMaLopTC"] + @"&status=dangky' class='btn btn-success'>Đăng ký</a>
                                       </div>
                                    </div>
                                  </a>
                                </div>";

                index++;
            }
        }

        private void searchMonHocByName(string maSV, string tenMon)
        {
            int index = 1;
            DataTable tb = new DataTable();
            tb = MonHoc.searchMonHocByTen(maSV, tenMon);
            ltrListMon.Text = "";
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                //@ lay ca chuoi
                ltrListMon.Text += @" <div id='" + index + @"' class='item col-md-4'>
                                     <a href = 'CourseDetail.aspx?maMon=" + tb.Rows[i]["iMaMon"] + @"&maLopTC=" + tb.Rows[i]["iMaLopTC"] + @"' >
                                      <div class='featured-item'>
                                      <img src = 'assets/images/khoahoc2.jpg' alt=''>
                                      <h4>" + tb.Rows[i]["sTenMon"] + @"</h4>
                                      <h6>" + tb.Rows[i]["sTenLopTC"] + @"</h6>
                                       <div class='mx-auto mt-5'>
                                            <a href = 'CourseDetail.aspx?maMon=" + tb.Rows[i]["iMaMon"] + @"&maLopTC=" + tb.Rows[i]["iMaLopTC"] + @"&status=dangky' class='btn btn-success'>Đăng ký</a>
                                       </div>
                                    </div>
                                  </a>
                                </div>";

                index++;
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "" || txtTimKiem.Text == null)
            {
                    loadListMon(MaSV);

            }
            else
            {
                searchMonHocByName(MaSV, txtTimKiem.Text);
                //Response.Redirect("Courses.aspx");
            }

  //          Response.Redirect("SearchCourses.aspx");
        }

    }
}