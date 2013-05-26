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
    public class  NguoiDung_DAO
    {
        public DataTable LoadNguoiDung()
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT * from NGUOIDUNG";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.Fill(dt);
            return dt;
        }

        public  DataTable KiemTraDangNhap(NguoiDung dto)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT * from NGUOIDUNG where TaiKhoan ='" + dto.TaiKhoan + "' AND MatKhau='" + dto.MatKhau + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);            
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
