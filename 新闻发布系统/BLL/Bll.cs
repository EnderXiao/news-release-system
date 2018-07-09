using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Bll
    {
        public static DataSet GetDataSet(string sqlStr)
        {
            DataSet ds = Dal.GetDataSet(sqlStr);
            return ds;
        }

        public static DataSet GetDataSet(string sqlStr, string tableName)
        {
            DataSet ds = Dal.GetDataSet(sqlStr, tableName);
            return ds;
        }

        public static SqlDataReader GetDataReader(string sqlStr)
        {
            SqlDataReader reader = Dal.GetDataReader(sqlStr);
            return reader;
        }

        public static bool ExecuteSQL(string sqlStr)
        {
            bool bl = Dal.ExecuteSQL(sqlStr);
            return bl;
        }
    }
}
