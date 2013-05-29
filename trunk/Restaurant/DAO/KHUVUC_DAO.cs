using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class KHUVUC_DAO
    {
        public DataTable LayDSKHUVUC()
        {
            string sql = "select * from KHUVUC";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
    }
}
