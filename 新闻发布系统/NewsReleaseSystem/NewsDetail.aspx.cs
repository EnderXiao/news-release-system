using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Linq;
using System.Data.SqlClient;
using BLL;

namespace NewsReleaseSystem
{
    public partial class NewsDetail : System.Web.UI.Page
    {
        public string newsContent = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlString = "select * from tb_News";
            DataSet ds = Bll.GetDataSet(sqlString, "tbNews");
            DataRow[] row = ds.Tables["tbNews"].Select("id=" + Request.QueryString["id"]);
            if (Request.QueryString["id"] == null)
            {
                return;
            }
            foreach (DataRow rs in row)
            {
                this.labTitle.Text = rs["title"].ToString();
                newsContent = rs["content"].ToString();
            }
        }

        public string GetContent()
        {
            string str = "";
            str = newsContent;
            return str;
        }
    }
}