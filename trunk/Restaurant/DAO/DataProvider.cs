using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Xml;
using System.IO;
namespace DAO
{
    public class DataProvider
    {
        public static OleDbConnection ConnectDB()
        {
            //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=QUANLYNHAHANG.accdb"
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=QUANLYNHAHANG.accdb";
            OleDbConnection conn;
            conn = new OleDbConnection(connectionString);
            conn.Open();
            return conn;
        }
        
    }
}

