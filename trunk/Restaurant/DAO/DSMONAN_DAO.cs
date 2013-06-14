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
        public DataTable TimKiemTD(DSMONAN_DTO dsmadto)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT TenMonAn,dvt.TenDonViTinh,DonGia,GiamGia,HinhAnh FROM DANHSACHMONAN ds, DONVITINH dvt, LOAIMONAN lma WHERE ds.LoaiMonAn = lma.MaLoaiMonAn and ds.DonViTinh = dvt.ID and TenMonAn like '%" + dsmadto.TenMonAn + "%'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            //conn.Close();
            return dt;
        }
        public bool ThemThucDon(DSMONAN_DTO DSMA_DTO)
        {
            string sql = "INSERT INTO DANHSACHMONAN (TenMonAn,LoaiMonAn,DonViTinh,DonGia,GiamGia,HinhAnh)" +
           "VALUES (@tentd,@lma,@dvt,@dg,@giamgia,@anh) ";
            List<OleDbParameter> Listma = new List<OleDbParameter>();
            OleDbParameter tentd = new OleDbParameter("@tentd", OleDbType.VarChar);
            OleDbParameter lma = new OleDbParameter("@lma", OleDbType.Integer);
            OleDbParameter dvt = new OleDbParameter("@dvt", OleDbType.Integer);
            OleDbParameter dg = new OleDbParameter("@dg", OleDbType.Double);
            OleDbParameter giamgia = new OleDbParameter("@giamgia", OleDbType.Double);
            OleDbParameter anh = new OleDbParameter("@anh", OleDbType.VarChar);

            tentd.Value = DSMA_DTO.TenMonAn;
            lma.Value = DSMA_DTO.LoaiMonAn;
            dvt.Value = DSMA_DTO.DVT;
            dg.Value = DSMA_DTO.DonGia;
            giamgia.Value = DSMA_DTO.GiamGia;
            anh.Value = DSMA_DTO.HinhAnh;

            Listma.Add(tentd);
            Listma.Add(lma);
            Listma.Add(dvt);
            Listma.Add(dg);
            Listma.Add(giamgia);
            Listma.Add(anh);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, Listma);
            if (kq < 1)
                return false;
            else
                return true;
        }
    }
}
