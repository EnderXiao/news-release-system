using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using BLL;

namespace NewsReleaseSystem.BackDesk
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.verifyCode.Text = Convert.ToString(GetCode());
            }
            //文本框获得焦点改变背景颜色
            username.Attributes.Add("onfocus", "ChgBgColor(this,'#eeeeee')");
            //文本款失去焦点改变背景颜色
            username.Attributes.Add("onblur", "ChgBgColor(this,'#ffffff')");
            //文本框获得焦点改变背景颜色
            pwd.Attributes.Add("onfocus", "ChgBgColor(this,'#eeeeee')");
            //文本款失去焦点改变背景颜色
            pwd.Attributes.Add("onblur", "ChgBgColor(this,'#ffffff')");
            //文本框获得焦点改变背景颜色
            checkCode.Attributes.Add("onfocus", "ChgBgColor(this,'#eeeeee')");
            //文本款失去焦点改变背景颜色
            checkCode.Attributes.Add("onblur", "ChgBgColor(this,'#ffffff')");
        }

        public int GetCode()
        {
            //生成验证码
            Random rand = new Random();
            int code = rand.Next(1000, 9999);
            return code;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            //数据库查询
            string sqlStr = "select * from tb_User where Name='" + this.username.Text.Trim() + "' and PassWord='" + this.pwd.Text.Trim() + "'";
            SqlDataReader sdr = Bll.GetDataReader(sqlStr);
            sdr.Read();

            if (sdr.HasRows)
            {
                if (this.checkCode.Text.Trim() == this.verifyCode.Text.Trim())
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('输入的验证码错误!')</script>");
                    Server.Transfer("Login.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('输入的姓名或密码错误误！请重新输入')</script>");
                Server.Transfer("Login.aspx");
            }
        }

        protected void cancel_Click1(object sender, EventArgs e)
        {
            Response.Write("<script>window.close();location='javascript:history.go(-1)';</script>");
        }
    }
}