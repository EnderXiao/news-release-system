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
using System.Data.SqlClient;
using BLL;

namespace NewsReleaseSystem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strShiShi = "select top 5 * from tb_News where Categories='时事新闻' order by issueDate desc";
            string strEconomic = "select top 5 * from tb_News where Categories='环球经济' order by issueDate desc";
            string strMilitary = "select top 5 * from tb_News where Categories='军事世界' order by issueDate desc";
            string strScience = "select top 5 * from tb_News where Categories='科学技术' order by issueDate desc";
            string strSocial = "select top 5 * from tb_News where Categories='社会百态' order by issueDate desc";
            string strSports = "select top 5 * from tb_News where Categories='世界体育' order by issueDate desc";
            string strFun = "select top 5 * from tb_News where Categories='娱乐综艺' order by issueDate desc";
            string strLife = "select top 5 * from tb_News where Categories='生活理财' order by issueDate desc";

            SqlDataReader dar = Bll.GetDataReader(strShiShi);
            dlstShiShi.DataSource = dar;
            dlstShiShi.DataKeyField = "id";//这个是设置数据库中的主键字段.
            dlstShiShi.DataBind();
            dar.Close();

            SqlDataReader sdrEco = Bll.GetDataReader(strEconomic);
            dlstEconomic.DataSource = sdrEco;
            dlstEconomic.DataKeyField = "id";
            dlstEconomic.DataBind();
            sdrEco.Close();

            SqlDataReader sdrM = Bll.GetDataReader(strMilitary);
            dlstMilitary.DataSource = sdrM;
            dlstMilitary.DataKeyField = "id";
            dlstMilitary.DataBind();
            sdrM.Close();

            SqlDataReader sdrS = Bll.GetDataReader(strScience);
            dlstScience.DataSource = sdrS;
            dlstScience.DataKeyField = "id";
            dlstScience.DataBind();
            sdrS.Close();

            SqlDataReader sdrSoc = Bll.GetDataReader(strSocial);
            dlstSocial.DataSource = sdrSoc;
            dlstSocial.DataKeyField = "id";
            dlstSocial.DataBind();
            sdrSoc.Close();

            SqlDataReader sdrSp = Bll.GetDataReader(strSports);
            dlstSports.DataSource = sdrSp;
            dlstSports.DataKeyField = "id";
            dlstSports.DataBind();
            sdrSp.Close();

            SqlDataReader sdrFun = Bll.GetDataReader(strFun);
            dlstFun.DataSource = sdrFun;
            dlstFun.DataKeyField = "id";
            dlstFun.DataBind();
            sdrFun.Close();

            SqlDataReader sdrLife = Bll.GetDataReader(strLife);
            dlstLife.DataSource = sdrLife;
            dlstLife.DataKeyField = "id";
            dlstLife.DataBind();
            sdrLife.Close();
        }

        protected void dlstShiShi_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstShiShi.DataKeys[e.Item.ItemIndex].ToString());//DataList1.DataKeys里是一个集和 注意:里面是按照索引的顺序存储了DataKeyField设置的主键,里面的集合的索引设置成DataList中对应的索引,巧妙
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstEconomic_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstEconomic.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstScience_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstScience.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstMilitary_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstMilitary.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstSocial_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstSocial.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstSports_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstSports.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstFun_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstFun.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }

        protected void dlstLife_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(dlstLife.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect("NewsDetail.aspx?id=" + id);
        }
    }
}