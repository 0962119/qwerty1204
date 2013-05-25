using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
using System.Data;
namespace DAO
{
    /// <summary>
    /// hàm thêm từng chi tiết của phiếu tính tiền
    /// </summary>
    public class CHITIETPHIEUTT_DAO
    {
//        public DataTable LayDSCTPhieuTT(int maPhieuTT, int maBan)
//        {
//            int kq = -1;
//            string sql = "SELECT DISTINCT "+
//                         "DANHSACHMONAN.TenMonAn, CHITIETPHIEUTT.SoLuong, DONVITINH.TenDonViTinh, CHITIETPHIEUTT.DonGia, CHITIETPHIEUTT.GiamGia, "+
//                         "CHITIETPHIEUTT.ThanhTien"+
//"FROM            (PHIEUTINHTIEN INNER JOIN"+
//                        " BAN ON PHIEUTINHTIEN.Ban = BAN.MaBan), ((DANHSACHMONAN INNER JOIN"+
//                        " CHITIETPHIEUTT ON DANHSACHMONAN.MaMonAn = CHITIETPHIEUTT.MonAn) INNER JOIN"+
//                         "DONVITINH ON DANHSACHMONAN.DonViTinh = DONVITINH.ID)"+
//"WHERE        (CHITIETPHIEUTT.MaPhieuTT = @maPhieuTT)";
//            List<OleDbParameter> ListParam = new List<OleDbParameter>();
//            OleDbParameter paratrangthai = new OleDbParameter("@trangThai", OleDbType.Integer);
//            //paratrangthai.Value = tinhTrang;
//            OleDbParameter paraMaBan = new OleDbParameter("@maBan", OleDbType.Integer);
//            paraMaBan.Value = maBan;
//            ListParam.Add(paratrangthai);
//            ListParam.Add(paraMaBan);
//            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
//            object obj = dt.ExecuteScalar(sql, ListParam);
//            try
//            {
//                kq = int.Parse(obj.ToString());
//            }
//            catch
//            {
//                return -1;
//            }
//            if (kq < 0)
//                return -1;
//            else
//                return kq;
//        }
        public bool ThemCTPhieuTinhTien(ChiTietPhieuTT ctPhieuTT_DTO)
        {
            string sql = "INSERT INTO CHITIETPHIEUTT " +
                "(MaPhieuTT, MonAn, SoLuong, GiamGia, ThanhTien, DonGia)" +
           "VALUES (@maPhieuTT, @monAn, @soLuong,@giamGia, @thanhTien, @donGia)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter maPTT = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            OleDbParameter monAn = new OleDbParameter("@monAn", OleDbType.Integer);
            OleDbParameter SoLuong = new OleDbParameter("@soLuong", OleDbType.Integer);
            OleDbParameter GiamGia = new OleDbParameter("@giamGia", OleDbType.Integer);
            OleDbParameter ThanhTien = new OleDbParameter("@thanhTien", OleDbType.Double);
            OleDbParameter DonGia = new OleDbParameter("@donGia", OleDbType.Double);

            maPTT.Value = ctPhieuTT_DTO.MaPhieuTT;
            monAn.Value = ctPhieuTT_DTO.MonAn;
            SoLuong.Value = ctPhieuTT_DTO.SoLuong;
            GiamGia.Value = ctPhieuTT_DTO.GiamGia;
            ThanhTien.Value = ctPhieuTT_DTO.ThanhTien;
            DonGia.Value = ctPhieuTT_DTO.DonGia;

            ListParam.Add(maPTT);
            ListParam.Add(monAn);
            ListParam.Add(SoLuong);
            ListParam.Add(GiamGia);
            ListParam.Add(ThanhTien);
            ListParam.Add(DonGia);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, ListParam);
            if (kq < 1)
                return false;
            else
                return true;
        }
        public bool XoaCTPhieuTinhTien(int maPhieuTT)
        {
            string sql = "DELETE FROM CHITIETPHIEUTT WHERE  (MaPhieuTT = @maPhieuTT)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paraTinhTrang = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            paraTinhTrang.Value = maPhieuTT;
            listParam.Add(paraTinhTrang);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
    }
}
