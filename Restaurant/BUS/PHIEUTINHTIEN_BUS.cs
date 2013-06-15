using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class PHIEUTINHTIEN_BUS
    {
        PHIEUTINHTIEN_DAO phieuTinhTienDAO = new PHIEUTINHTIEN_DAO();

        /// <summary>
        /// thêm 1 phiêu tính tiền
        /// </summary>
        /// <param name="phieuTT_DTO"></param>
        /// <returns></returns>
        public bool ThemPhieuTinhTien(PhieuTinhTien phieuTT_DTO)
        {
            return phieuTinhTienDAO.ThemPhieuTinhTien(phieuTT_DTO);
        }
        /// <summary>
        /// lấy maPhieuTT 
        /// </summary>
        /// <param name="maBan"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public int LayMaPhieuTinhTien(int maBan, int tinhTrang)
        {
            return phieuTinhTienDAO.LayMaPhieuTinhTien(maBan, tinhTrang);
        }
        /// <summary>
        /// lấy mã phiêu tinh tien cua ban có khách hoặc bàn được đặt trước là tồn tại duy nhất
        /// </summary>
        /// <param name="maBan"></param>
        /// <returns></returns>
        public int LayMaPhieuTinhTien(int maBan)
        {
            return phieuTinhTienDAO.LayMaPhieuTinhTien(maBan);
        }
        public DataTable LayPhieuTinhTien(int maBan)
        {
            return phieuTinhTienDAO.LayPhieuTinhTien(maBan);

        }
        public bool XoaPhieuTinhTien(int maBan, int tinhTrang)
        {
            return phieuTinhTienDAO.XoaPhieuTinhTien(maBan, tinhTrang);
        }
        public bool CapNhatTrangThaiPhieuTT(int maBan, int tinhTrang)
        {
            return phieuTinhTienDAO.CapNhatTrangThaiPhieuTT(maBan, tinhTrang);
        }
        public bool UpDatePhieuTT(PhieuTinhTien phieuTT_DTO)
        {
            return phieuTinhTienDAO.UpDatePhieuTT(phieuTT_DTO);
        }
        public double LayTongTienPhieuTT(int maPhieu)
        {
            return phieuTinhTienDAO.LayTongTienPhieuTT(maPhieu);
        }
        public bool CapNhapTienPhieuTT(int maPhieuTT, double tongTien)
        {
            return phieuTinhTienDAO.CapNhapTienPhieuTT(maPhieuTT, tongTien);
        }
        public bool XoaPhieuTinhTien(int maPhieu)
        {
            return phieuTinhTienDAO.XoaPhieuTinhTien(maPhieu);
        }
        public bool CapNhatBanChoPhieuTT(int maPhieu, int maBan)
        {
            return phieuTinhTienDAO.CapNhatBanChoPhieuTT(maPhieu, maBan);
        }

        public DataTable FilterPhieuTT_Datatable(string NgayDau, string NgayCuoi)
        {
            return phieuTinhTienDAO.FilterPhieuTT_Datatable(NgayDau, NgayCuoi);
        }

        public string TongTienThongKeHoaDon(string NgayDau, string NgayCuoi)
        {
            return phieuTinhTienDAO.TongTienThongKeHoaDon(NgayDau, NgayCuoi);
        }
        // Thong ke theo khu vuc
        public DataTable SoPhieuTinhTien_TheoKhuVuc(DateTime tuNgay, DateTime denNgay, string tenKV)
        {
            return phieuTinhTienDAO.SoPhieuTinhTien_TheoKhuVuc(tuNgay, denNgay, tenKV);
        }
        public DataTable SoPhieuTinhTien_TheoBan(DateTime tungay, DateTime denngay, string tenBan, string tenKhuVuc)
        {
            return phieuTinhTienDAO.SoPhieuTinhTien_TheoBan(tungay, denngay, tenBan, tenKhuVuc);
        }

        
    }
}
