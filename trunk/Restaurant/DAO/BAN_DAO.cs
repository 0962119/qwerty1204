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
            OleDbParameter paratrangthai = new OleDbParameter("@tenBan", OleDbType.VarChar);
            paratrangthai.Value = tenBan;
            ListParam.Add(paratrangthai);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            DataTable dtb = new DataTable();
            dtb= dt.ExecuteQuery(sql);
            return dtb;
        }
        public bool UpdateTrangThaiBan(int trangThai, int maBan)
        {
            string sql = "UPDATE BAN SET TrangThai=@trangThai WHERE(MaBan=@maBan)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter paratrangthai = new OleDbParameter("@trangThai", OleDbType.Integer);
            paratrangthai.Value = trangThai;
            OleDbParameter paraMaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            paraMaBan.Value = maBan;
            ListParam.Add(paratrangthai);
            ListParam.Add(paraMaBan);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, ListParam);
            if (kq < 1)
                return false;
            else
                return true;
        }
       
        public int KiemTraBanCoKhach(int tinhTrang, int maBan)
        {
            int kq = -1;
            string sql = "select MaPhieuTT From PHIEUTINHTIEN where  (TinhTrang=@trangThai and MaBan=@maBan)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter paratrangthai = new OleDbParameter("@trangThai", OleDbType.Integer);
            paratrangthai.Value = tinhTrang;
            OleDbParameter paraMaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            paraMaBan.Value = maBan;
            ListParam.Add(paratrangthai);
            ListParam.Add(paraMaBan);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            object obj=dt.ExecuteScalar(sql, ListParam);
            try
            {
                kq = int.Parse(obj.ToString());
            }
            catch
            {
                return -1;
            }
            if (kq < 0)
                return -1;
            else
                return kq;
        }
    }
}
