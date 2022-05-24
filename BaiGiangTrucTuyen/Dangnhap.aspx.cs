using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BaiGiangTrucTuyen
{
    
    public partial class Login : System.Web.UI.Page
    {
        static int dangnhapsai = 0;
        DateTime timevao;
        protected void Page_Load(object sender, EventArgs e)
        {
            //btnSubmit.OnClientClick = "return checklogin()";
            lbDemtg.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["timeLogin"] = DateTime.Now;
            DataTable data = AppCode.Database.Taikhoan.Login(txtUsername.Text, txtPassWord.Text);
            DataTable data1 = AppCode.Database.Taikhoan.LoginTe(txtUsername.Text, txtPassWord.Text);
            DataTable data2 = AppCode.Database.Taikhoan.LoginAd(txtUsername.Text, txtPassWord.Text);
            if (data.Rows.Count > 0)
            {    
                Session["SinhVien"] = txtUsername.Text;
                Response.Redirect("Home.aspx");
            }
            if(data1.Rows.Count>0)
            {
                Session["Giangvien"] = txtUsername.Text;
                Response.Redirect("Teacher/UnitManagement.aspx");
            } 
            if(data2.Rows.Count>0)
            {
                Session["QuanTri"] = txtUsername.Text;
                Response.Redirect("Admin/AccStManagement.aspx");
            }    
            else
            {
                dangnhapsai = dangnhapsai + 1;

                if(dangnhapsai>3)
                {
                    Session["thoigian"] = DateTime.Now.AddSeconds(5);
                    btnSubmit.Visible = false;
                    if (DateTime.Now > (DateTime)Session["thoigian"])
                    {
                        Session["lock"] = false;
                        dangnhapsai = 0;
                        btnSubmit.Visible = true;
                        //Session["Count"] = count;
                        //Response.Redirect("Dangnhap.aspx");
                    }
                   
                }
                Response.Write("<script>alert('Sai tên tài khoản hoặc mật khẩu')</script>");
            }
        }
        public void Tick1(object sender, EventArgs e)
        {
            
            if(dangnhapsai > 3)
            {
                DateTime now = DateTime.Now;
                timevao = Convert.ToDateTime(Session["thoigian"]);
                TimeSpan tsTimevao = new TimeSpan(now.Ticks);
                DateTime tgDung = timevao.Subtract(tsTimevao);
                lbDemtg.Text = "Xin moi cho trong: "+ tgDung.ToString("mm:ss");
                if (tgDung.ToString("mm:ss") == "00:00")
                {
                    Session["lock"] = false;
                    dangnhapsai = 0;
                    Response.Redirect("Dangnhap.aspx");
                }
            }
        }

        
    }
}