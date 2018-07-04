using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public class SqlData
{
    private SqlConnection con;
    private SqlCommand cmd;
    private SqlDataAdapter da;
    
    public SqlData()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
        con = new SqlConnection(ConfigurationManager.AppSettings["ConnenctionStr"]);
        con.Open();
    }
    // 下载于www.mycodes.net 

    public bool ExecuteSQL(string str)//执行SQL语句
    {
        cmd = new SqlCommand(str, con);
        try
        {
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            throw (new Exception(e.Message));//抛出了一个异常。Exception例外。E.Message是异常信息的内容。关于catch()中的参数e: e就是发生异常的异常类对象，可以任意取名。不是必须叫e的。

            return false;
        }

        finally
        {
            con.Close();
        }
    }


    public DataSet ExecuteDateSet(string str)
    {
        try
        {
            cmd = new SqlCommand(str, con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet datesetExecute(string str, string tableName)   //返回DataSet
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            return ds;
        }
        finally                     //一般理解try……catch是异常捕获，try…… finally不管在前面定义的try语句中是否有异常或错误发生，都执行finally中语句。
       
        {
            con.Close();
        }
    }

    public SqlDataReader ExecuteRead(string str)      //1.NewsDetail.aspx中用<%=GetContent()%> 将sdr内容显示在前台
    {                                                 //2.Default.aspx.cs中执行查询
        cmd = new SqlCommand(str, con);
        SqlDataReader sdr = cmd.ExecuteReader();//返回一下数据流，从前往后
        return sdr;
        con.Close();
    }
}