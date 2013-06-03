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
    public class LoaiMonAn_DAO
    {
        public DataTable LayDSLoaiMonAn()
        {
            string sql = "SELECT * FROM LOAIMONAN";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
        public bool ThemLoaiMonAn(string TenLoaiMA)
        {
            string sql = "INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES(@ten)";
            List<OleDbParameter> lis = new List<OleDbParameter>();
            OleDbParameter para = new OleDbParameter("@ten", OleDbType.VarChar);
            para.Value = TenLoaiMA;
            lis.Add(para);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();

            int kq = dt.ExecuteNoneQuery(sql, lis);
            if (kq < 1)
                return false;
            else
                return true;
        }
    }
}
