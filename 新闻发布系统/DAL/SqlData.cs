using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;

public class SqlData
{
    private SqlConnection con;
    private SqlCommand cmd;
    private SqlDataAdapter da;
    
    public SqlData()
    {
        con = new SqlConnection(ConfigurationManager.AppSettings["ConnenctionStr"]);
        con.Open();
    }

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
            return false;
            throw (new Exception(e.Message));
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

    public DataSet datesetExecute(string str, string tableName)
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            return ds;
        }
        finally                     
        {
            con.Close();
        }
    }

    public SqlDataReader ExecuteRead(string str)      
    {                                               
        cmd = new SqlCommand(str, con);
        SqlDataReader sdr = cmd.ExecuteReader();//返回数据流，从前往后
        return sdr;
    }
}