using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using NETDataProviders;

namespace DAO
{
    public class BAN_DAO
    {
        public DataTable LayDSBan()
        {
            string sql = "select * from BAN";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
        public DataTable LayDSBan(int maKhuVuc)
        {
            string sql = "select * from BAN where MaKhuVuc=@maKhuVuc";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter para = new OleDbParameter("@maKhuVuc", OleDbType.Integer);
            para.Value = maKhuVuc;
            ListParam.Add(para);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
        public DataTable LayDSBan(string tenBan)
        {
            string sql = "SELECT MaBan, TenBan, TrangThai, MaKhuVuc, SoKhach FROM BAN WHERE (TenBan like '%"+tenBan+"%')";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
        
    }
}
