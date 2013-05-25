using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
namespace DAO
{
    public class PHIEUTINHTIEN_DAO
    {

        public bool ThemPhieuTinhTien(PhieuTinhTien phieuTT_DTO)
        {
            string sql = "INSERT INTO PHIEUTINHTIEN "+
                "(Ban, NhanVien, TongTien, NgayLapPhieu, KhachDuaTruoc, GhiChu, GiamGia, VAT, TinhTrang, Giovao, Giora)"+
           "VALUES (@maBan, @tenNhanVien, @tongTien, @ngayLap, @duaTruoc,@ghiChu, @giamGia, @vAT, @tinhTrang, @gioVao, @gioRa)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter maBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter tenNhanVien = new OleDbParameter("@tenNhanVien", OleDbType.VarChar);
            OleDbParameter tongTien = new OleDbParameter("@tongTien", OleDbType.Double);
            OleDbParameter ngayLap = new OleDbParameter("@ngayLap", OleDbType.Date);
            OleDbParameter duaTruoc = new OleDbParameter("@duaTruoc", OleDbType.Double);
            OleDbParameter ghiChu = new OleDbParameter("@ghiChu", OleDbType.VarChar);
            OleDbParameter giamGia = new OleDbParameter("@giamGia", OleDbType.Integer);
            OleDbParameter vAT = new OleDbParameter("@vAT", OleDbType.Integer);
            OleDbParameter tinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            OleDbParameter gioVao = new OleDbParameter("@Giovao", OleDbType.Date);
            OleDbParameter gioRa = new OleDbParameter("@Giora", OleDbType.Date);

            maBan.Value = phieuTT_DTO.Ban;
            tenNhanVien.Value = phieuTT_DTO.NhanVien;
            tongTien.Value = phieuTT_DTO.TongTien;
            ngayLap.Value = phieuTT_DTO.NgayLapPhieu;
            duaTruoc.Value = phieuTT_DTO.KhachDuaTruoc;
            ghiChu.Value = phieuTT_DTO.GhiChu;
            giamGia.Value = phieuTT_DTO.GiamGia;
            vAT.Value = phieuTT_DTO.VAT;
            tinhTrang .Value = phieuTT_DTO.TinhTrang;
            gioVao.Value = phieuTT_DTO.Giovao;
            gioRa.Value = phieuTT_DTO.Giora;

            ListParam.Add( maBan);
            ListParam.Add( tenNhanVien);
            ListParam.Add( tongTien);
            ListParam.Add( ngayLap);
            ListParam.Add( duaTruoc);
            ListParam.Add( ghiChu);
            ListParam.Add( giamGia);
            ListParam.Add( vAT);
            ListParam.Add( tinhTrang);
            ListParam.Add(gioVao);
            ListParam.Add(gioRa);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, ListParam);
            if (kq < 1)
                return false;
            else
                return true;
        }
        public int LayMaPhieuTinhTien(int maBan, int tinhTrang)
        {
            string sql = "select MaPhieuTT from PHIEUTINHTIEN where Ban=@maBan and TinhTrang=@tinhTrang";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paraTinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            paramaBan.Value = maBan;
            paraTinhTrang.Value = tinhTrang;
            listParam.Add(paramaBan);
            listParam.Add(paraTinhTrang);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            object obj = dt.ExecuteScalar(sql, listParam);
            try
            {
                int kq = int.Parse(obj.ToString());
                return kq;
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// lấy mã phiêu tinh tien cua ban có khách hoặc bàn được đặt trước là tồn tại duy nhất
        /// </summary>
        /// <param name="maBan"></param>
        /// <returns></returns>
        public int LayMaPhieuTinhTien(int maBan)
        {
            string sql = "select MaPhieuTT from PHIEUTINHTIEN where( Ban=@maBan and TinhTrang < 3)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            paramaBan.Value = maBan;
            listParam.Add(paramaBan);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            object obj = dt.ExecuteScalar(sql, listParam);
            try
            {
                int kq = int.Parse(obj.ToString());
                return kq;
            }
            catch
            {
                return -1;
            }
        }
        public bool XoaPhieuTinhTien(int maBan, int tinhTrang)
        {
            string sql = "DELETE FROM PHIEUTINHTIEN WHERE  (Ban = @maBan) AND (TinhTrang = @tinhTrang)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paraTinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            paramaBan.Value = maBan;
            paraTinhTrang.Value = tinhTrang;
            listParam.Add(paramaBan);
            listParam.Add(paraTinhTrang);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        public bool CapNhatTrangThaiPhieuTT(int maBan, int tinhTrang)
        {
            string sql = "UPDATE PHIEUTINHTIEN SET TinhTrang= @tinhTrang WHERE Ban = @maBan";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paraTinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            paraTinhTrang.Value = tinhTrang;
            listParam.Add(paraTinhTrang);
            paramaBan.Value = maBan;
            listParam.Add(paramaBan);

            
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
    }
}
