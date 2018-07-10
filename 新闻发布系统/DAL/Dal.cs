using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Dal
    {
        public static DataSet GetDataSet(string sqlStr)
        {
            SqlData sql = new SqlData();
            DataSet ds = sql.ExecuteDateSet(sqlStr);
            return ds;
        }

        public static DataSet GetDataSet(string sqlStr, string tableName)
        {
            SqlData sql = new SqlData();
            DataSet ds = sql.datesetExecute(sqlStr,tableName);
            return ds;
        }

        public static SqlDataReader GetDataReader(string sqlstr)
        {
            SqlData sql = new SqlData();
            SqlDataReader reader = sql.ExecuteRead(sqlstr);
            return reader;
        }

        public static bool ExecuteSQL(string sqlStr)
        {
            SqlData sql = new SqlData();
            bool bl = sql.ExecuteSQL(sqlStr);
            return bl;
        }

        public static bool Add_news(string title, string time, string content)
        {
            SqlData sql = new SqlData();
            string sqlStr = @"INSERT INTO tb_News VALUES
                            ('" + title.Trim() + "'," +
                            "'" + content + "'," +
                            "'" + "娱乐综艺" + "'," +
                            "'" + "国内新闻" + "'," +
                            "'" + time + "')";
            bool bl = sql.ExecuteSQL(sqlStr);
            return bl;
        }
    }
}
