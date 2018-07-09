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

namespace NewsReleaseSystem.BackDesk
{
    public partial class UserManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        protected void Bind()
        {
            string sqlStr = "select * from tb_User";
            DataSet ds = Bll.GetDataSet(sqlStr);
            this.gdvUserManage.DataSource = ds;
            this.gdvUserManage.DataBind();
        }

        protected void gdvUserManage_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gdvUserManage.PageIndex = e.NewPageIndex;
            this.gdvUserManage.DataBind();
        }

        protected void gvEditAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gdvUserManage.DataKeys[e.RowIndex].Value.ToString());
            string sqlStr = "Delete from tb_User where ID='" + id + "'";
            Bll.ExecuteSQL(sqlStr);
            Bind();
        }

        protected void gvEditAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gdvUserManage.EditIndex = -1;
            Bind();
        }

        protected void gvEditAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvUserManage.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void gvEditAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(gdvUserManage.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)(gdvUserManage.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
            string pwd = ((TextBox)(gdvUserManage.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
            string sqlStr = "Update tb_User set Name='" + name + "',PassWord='" + pwd + "' where ID='" + id + "'";
            Bll.ExecuteSQL(sqlStr);
            gdvUserManage.EditIndex = -1;
            Bind();
        }
    }
}