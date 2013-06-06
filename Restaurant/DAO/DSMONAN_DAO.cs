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
        public DataTable LayDanhSachMonAnTheoLoai(int maloaima)
        {
            string sql = "SELECT ds.TenMonAn,dv.TenDonViTinh,ds.DonGia,ds.HinhAnh FROM DANHSACHMONAN ds, DONVITINH dv, LOAIMONAN lma "+
                " WHERE ds.DonViTinh= dv.ID and ds.LoaiMonAn= lma.MaLoaiMonAn and lma.MaLoaiMonAn=@maloaima";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter para = new OleDbParameter("@maLoai", OleDbType.Integer);
            para.Value = maloaima;
            ListParam.Add(para);
            List<OleDbParameter> listPara = new List<OleDbParameter>();
            listPara.Add(para);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            DataTable dtb = new DataTable();
            dtb = dt.ExecuteQuery(sql, listPara);
            return dtb;

        }
        public DataTable LayDSMonAnTheoLoai(int maLoaiMonAn)
        {
            string sql = "select * from DANHSACHMONAN where DANHSACHMONAN.LoaiMonAn=@maLoaiMonAn";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter para = new OleDbParameter("@maLoaiMonAn", OleDbType.Integer);
            para.Value = maLoaiMonAn;
            ListParam.Add(para);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);

        }
        public bool ThemThucDon(string TenThucDon, int DonGia, int GiamGia)
        {
            string sql = "INSERT INTO DANHSACHMONAN (TenMonAn,DonGia,GiamGia) VALUES(@ten,@dg,@giamgia)";
            List<OleDbParameter> listma = new List<OleDbParameter>();
            OleDbParameter para = new OleDbParameter("@ten", OleDbType.VarChar);
            OleDbParameter para1 = new OleDbParameter("@dg", OleDbType.Integer);
            OleDbParameter para2 = new OleDbParameter("@giamgia", OleDbType.Integer);
            para.Value = TenThucDon;
            para1.Value = DonGia;
            para2.Value = GiamGia;
            listma.Add(para);
            listma.Add(para1);
            listma.Add(para2);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();

            int kq = dt.ExecuteNoneQuery(sql, listma);
            if (kq < 1)
                return false;
            else
                return true;
        }

    }
}
