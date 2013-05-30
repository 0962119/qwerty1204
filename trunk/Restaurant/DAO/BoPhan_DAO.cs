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
    public class BoPhan_DAO
    {
        public DataTable LoadBoPhan_DataTable()
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT * from BOPHAN";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public string FilterBoPhan_String(BoPhan dto)
        {

            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT TenBoPhan from BOPHAN where MaBoPhan =" + dto.MaBoPhan;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);


            //DataRow dr = dt.Rows[0];                
            //string x =  dr["TenBoPhan"].ToString();
            string x = dt.Rows[0][0].ToString();
            // conn.Close();
            return x;
        }
    }
}
