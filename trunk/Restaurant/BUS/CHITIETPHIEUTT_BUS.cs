using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class CHITIETPHIEUTT_BUS
    {
        CHITIETPHIEUTT_DAO ctPhieuTT_DAO = new CHITIETPHIEUTT_DAO();
        public bool ThemCTPhieuTinhTien(ChiTietPhieuTT ctPhieuTT_DTO)
        {
            return ctPhieuTT_DAO.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
        }
        /// <summary>
        /// xoa tat ca cac chi tiet co maPhieuTT
        /// </summary>
        /// <param name="maPhieuTT"></param>
        /// <returns></returns>
        public bool XoaCTPhieuTinhTien(int maPhieuTT)
        {
            return ctPhieuTT_DAO.XoaCTPhieuTinhTien(maPhieuTT);
        }
        /// <summary>
        /// xoa nhung chi tiết có MaPhieuTT và có MaMonAn
        /// </summary>
        /// <param name="maPhieuTT"></param>
        /// <param name="maMonAn"></param>
        /// <returns></returns>
        public bool XoaCTPhieuTinhTien(int maPhieuTT, int maMonAn)
        {
            return ctPhieuTT_DAO.XoaCTPhieuTinhTien(maPhieuTT, maMonAn);
        }
        /// <summary>
        /// cập nhật lại Mã Phiếu Tính Tiền <=> tách món
        /// </summary>
        /// <param name="maPhieuTT"></param>
        /// <param name="maMonAn"></param>
        /// <returns></returns>
        public bool XoaCTPhieuTinhTien(int maPhieuTT, int maMonAn, int maPhieuTTNew)
        {
            return ctPhieuTT_DAO.XoaCTPhieuTinhTien(maPhieuTT, maMonAn, maPhieuTTNew);
        }
        public DataTable LayDSCTPhieuTT(int maPhieuTT, int maBan)
        {
            return ctPhieuTT_DAO.LayDSCTPhieuTT(maPhieuTT, maBan);
        }
        public bool CapNhatCTPhieuTT(int maPhieuTT, int maMonAn, int soLuong, int giamGia, double thanhTien)
        {
            return ctPhieuTT_DAO.CapNhatCTPhieuTT(maPhieuTT, maMonAn, soLuong, giamGia, thanhTien);
        }
        public bool GhepBan(int maPhieuTTOld, int maPhieuTTNew)
        {
            return ctPhieuTT_DAO.GhepBan(maPhieuTTOld, maPhieuTTNew);
        }
        public bool AttackDatainHoaDonRP(DataTable tbHoaDon)
        {
            return ctPhieuTT_DAO.AttackDatainHoaDonRP(tbHoaDon);
        }
        public void DeleteDatainHoaDonRP()
        {
            ctPhieuTT_DAO.DeleteDatainHoaDonRP();
        }

        //NHD
        public DataTable LoadChiTietPhieuTT(int MaPhieu)
        {
            return ctPhieuTT_DAO.LoadChiTietPhieuTT_datatable(MaPhieu);
        }

        public string ThanhTien_string(int MaPhieu)
        {
            return ctPhieuTT_DAO.ThanhTien_string(MaPhieu);
        }

        public string DonGia_string(int MaPhieu)
        {
            return ctPhieuTT_DAO.DonGia_string(MaPhieu);
        }
        //Thống kê món ăn (tổng tiền, trung bình)
        public DataTable ThongKe_TheoTenLoaiMonAn(DateTime tuNgay, DateTime denNgay, string tenMon)
        {
            return ctPhieuTT_DAO.ThongKe_TheoTenLoaiMonAn(tuNgay, denNgay, tenMon);
        }
        public DataTable ThongKe_TheoTenMonAn(DateTime tuNgay, DateTime denNgay, string tenMon, string tenLoaiMon)
        {
            return ctPhieuTT_DAO.ThongKe_TheoTenMonAn(tuNgay, denNgay, tenMon, tenLoaiMon);
        }

        public void XoaChiTietPhieuTT_void(int maHoaDon)
        {
             ctPhieuTT_DAO.XoaChiTietPhieuTT_void(maHoaDon);
        }
    }
}
