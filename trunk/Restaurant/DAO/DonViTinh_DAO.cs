using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using NETDataProviders;
using DTO;

namespace DAO
{
    public class DonViTinh_DAO
    {
        public DataTable DSDonViTinh()
        {
            string sql = "SELECT * FROM DonViTinh";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
    }
}
