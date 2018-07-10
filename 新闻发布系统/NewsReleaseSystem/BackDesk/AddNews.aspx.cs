using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using BLL;

namespace NewsReleaseSystem.BackDesk
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int Category = Convert.ToInt32((Request["id"].ToString()));
            int Category = 1;
            switch (Category)
            {
                case 1:
                    this.labTitle.Text = "时事新闻";
                    break;
                case 2:
                    this.labTitle.Text = "环球经济";
                    break;
                case 3:
                    this.labTitle.Text = "军事世界";
                    break;
                case 4:
                    this.labTitle.Text = "科学技术";
                    break;
                case 5:
                    this.labTitle.Text = "生活理财";
                    break;
                case 6:
                    this.labTitle.Text = "社会百态";
                    break;
                case 7:
                    this.labTitle.Text = "世界体育";
                    break;
                case 8:
                    this.labTitle.Text = "娱乐综艺";
                    break;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlStr = @"INSERT INTO tb_News VALUES
                    ('" + this.txtNewsTitle.Text.Trim() + "'," +
                    "'" + this.txtNewsContent.Text.Trim() + "'," +
                    "'" + this.labTitle.Text.Trim() + "'," +
                    "'" + this.dlstNewsType.SelectedValue.ToString() + "'," +
                    "'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            bool bl = Bll.ExecuteSQL(sqlStr);
            if (bl)
            {
                this.lblMessage.Text = "新闻添加成功！";
            }
            else
            {
                this.lblMessage.Text = "新闻添加失败！";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtNewsContent.Text = "";
            this.txtNewsTitle.Text = "";
            Response.Redirect("~/BackDesk/NewsManage.aspx");
        }
    }
}