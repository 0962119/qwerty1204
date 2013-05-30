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
            string sql = "SELECT * from NGUOIDUNG nd,BOPHAN bp where nd.BoPhan = bp.MaBoPhan ";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable KiemTraDangNhap(NguoiDung dto)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT * from NGUOIDUNG where TaiKhoan ='" + dto.TaiKhoan + "' AND MatKhau='" + dto.MatKhau + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void ThemNguoiDung_void(NguoiDung dto)
        {

            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "INSERT INTO NGUOIDUNG(TaiKhoan, MatKhau,BoPhan,TenNguoiDung,SDT) VALUES(@TaiKhoan, @MatKhau,@BoPhan,@TenNguoiDung,@SDT)";
            // string sql = "INSERT INTO NGUOIDUNG values (?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("TaiKhoan",dto.TaiKhoan);
            //cmd.Parameters.AddWithValue("MatKhau", dto.MatKhau);
            //cmd.Parameters.AddWithValue("BoPhan", dto.BoPhan);
            //cmd.Parameters.AddWithValue("TenNguoiDung", dto.TenNguoiDung);
            //cmd.Parameters.AddWithValue("SDT", dto.SDT);

            OleDbParameter para = cmd.Parameters.AddWithValue("@TaiKhoan", dto.TaiKhoan);
            para = cmd.Parameters.AddWithValue("@MatKhau", dto.MatKhau);
            para = cmd.Parameters.AddWithValue("@BoPhan", dto.BoPhan);
            para = cmd.Parameters.AddWithValue("@TenNguoiDung", dto.TenNguoiDung);
            para = cmd.Parameters.AddWithValue("@SDT", dto.SDT);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void XoaNguoiDung_void(NguoiDung dto)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "DELETE * FROM NGUOIDUNG where TaiKhoan =@TaiKhoan";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbParameter para = cmd.Parameters.AddWithValue("@TaiKhoan", dto.TaiKhoan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SuaNguoiDung_void(NguoiDung dto)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            // string sql = "UPDATE NGUOIDUNG SET  MatKhau=@MatKhau, BoPhan=@BoPhan, TenNguoiDung=@TenNguoiDung, SDT = @SDT where TaiKhoan=@TaiKhoan";
            string sql = "UPDATE NGUOIDUNG SET MatKhau=?,BoPhan=?,TenNguoiDung=?,SDT=? where TaiKhoan=?";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("MatKhau", dto.MatKhau);
            cmd.Parameters.AddWithValue("BoPhan", dto.BoPhan);
            cmd.Parameters.AddWithValue("TenNguoiDung", dto.TenNguoiDung);
            cmd.Parameters.AddWithValue("SDT", dto.SDT);
            cmd.Parameters.AddWithValue("TaiKhoan", dto.TaiKhoan);

            //OleDbParameter para = cmd.Parameters.AddWithValue("@TaiKhoan", dto.TaiKhoan);
            //para = cmd.Parameters.AddWithValue("@MatKhau", dto.MatKhau);
            //para = cmd.Parameters.AddWithValue("@BoPhan", dto.BoPhan);
            //para = cmd.Parameters.AddWithValue("@TenNguoiDung", dto.TenNguoiDung);
            //para = cmd.Parameters.AddWithValue("@SDT", dto.SDT);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
