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
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from tb_User where Name='" + this.username.Text.Trim() + "' and PassWord='" + this.pwd.Text.Trim() + "'";
                string sqlStr1 = "insert into tb_User (Name,PassWord) values('" + this.username.Text.Trim() + "','" + this.pwd.Text.Trim() + "')";
                SqlDataReader dr = Bll.GetDataReader(sqlStr);
                dr.Read();
                if (dr.HasRows)
                {
                    this.lblMessage.Text = "该用户已存在";
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    if (Bll.ExecuteSQL(sqlStr1))
                    {
                        this.lblMessage.Text = "用户添加成功";
                    }
                    else
                    {
                        this.lblMessage.Text = "用户添加失败";
                    }
                }
            }
            catch
            {
                this.lblMessage.Text = "添加失败";
            }
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            this.username.Text = "";
            this.pwd.Text = "";
            this.lblMessage.Text = "";
            Response.Redirect("~/BackDesk/NewsManage.aspx");
        }
    }
}