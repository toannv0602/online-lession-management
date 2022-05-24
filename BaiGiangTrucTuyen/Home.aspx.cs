using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;
using BaiGiangTrucTuyen.AppCode.Database;

namespace BaiGiangTrucTuyen
{
    public partial class Home : System.Web.UI.Page
    {
        ////int giay = 0, phut = 0, gio = 0;
        //DateTime tg = new DateTime(0000,00,00, 0,0,0);
        DateTime timevao;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            string maSV = "";
            if(Session["SinhVien"] == null)
            {
                Response.Redirect("Dangnhap.aspx");
            }
            else
            {
                maSV = Session["SinhVien"].ToString();
                loadTTSV(maSV);
                loadListMon(maSV);
              
            }
            //HienThi.Text = ""+gio.ToString()+":"+phut.ToString()+":"+giay.ToString()+"";
        }

        public void Tick1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timevao = Convert.ToDateTime(Session["timeLogin"]);
            TimeSpan tsTimevao = new TimeSpan(timevao.Ticks);
            DateTime tgDung = now.Subtract(tsTimevao);
            lbDemtg.Text = tgDung.ToString("mm:ss");

        }

        public void loadTTSV(string maSV)
        {
            DataTable tb = new DataTable();
            tb = SinhVien.getByMaSV(maSV);
            ltrTenSV.Text = tb.Rows[0]["sTenSV"].ToString();
            ltrMaSV.Text = tb.Rows[0]["sMaSV"].ToString();
            ltrLopHC.Text = tb.Rows[0]["sLop"].ToString();
        }

        public void loadListMon(string maSV)
        {
            DataTable tb = new DataTable();
            tb = MonHoc.loadMonDaDK(maSV);
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                //@ lay ca chuoi
                ltrListMon.Text += @"<a href = 'CourseDetail.aspx?maMon=" + tb.Rows[i]["iMaMon"] + @"&maLopTC=" + tb.Rows[i]["iMaLopTC"] + @"' ><div class='featured-item'>
                                    <img src = 'assets/images/khoahoc.jpg' alt='Item 1'>
                                    <h4>" + tb.Rows[i]["sTenMon"] + @"<h4>
                                    <h6>" + tb.Rows[i]["sTenLopTC"] + @"</h6>
                                    </div>
                                    </a>";
            }

        }
        
       
    }
}