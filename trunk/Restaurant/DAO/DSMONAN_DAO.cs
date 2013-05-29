using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;
namespace DAO
{
    public class DSMONAN_DAO
    {
        public DataTable LayDSMonAn()
        {
            string sql = "SELECT        dsma.MaMonAn, dsma.TenMonAn, dsma.LoaiMonAn, dsma.DonGia, dsma.GiamGia, dsma.HinhAnh, dv.TenDonViTinh  FROM (DANHSACHMONAN dsma INNER JOIN DONVITINH dv ON dsma.DonViTinh = dv.ID)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
        public string LayHinhMonAn(int maMonAn)
        {
            string sql = "SELECT HinhAnh  FROM DANHSACHMONAN where MaMonAn=@maMonAn";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter paraMaMA = new OleDbParameter("@maMonAn", OleDbType.Integer);
            paraMaMA.Value = maMonAn;
            ListParam.Add(paraMaMA);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            object path= dt.ExecuteScalar(sql, ListParam);
            return path.ToString();
        }

        public DataTable  LayDSMonAn(string tenBan)
        {
            string sql = "SELECT  "+
            " dsma.MaMonAn, dsma.TenMonAn, dsma.LoaiMonAn, dsma.DonGia, dsma.GiamGia, dsma.HinhAnh, dv.TenDonViTinh  "+
            " FROM (DANHSACHMONAN dsma INNER JOIN DONVITINH dv ON dsma.DonViTinh = dv.ID) where TenMonAn like '%" + tenBan + "%'";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter paratrangthai = new OleDbParameter("@tenMonAn", OleDbType.VarChar);
            paratrangthai.Value = tenBan;
            ListParam.Add(paratrangthai);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            DataTable dtb = new DataTable();
            dtb = dt.ExecuteQuery(sql);
            return dtb;
        }
    }
}
