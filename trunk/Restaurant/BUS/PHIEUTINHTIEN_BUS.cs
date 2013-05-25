using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
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
        public bool XoaPhieuTinhTien(int maBan, int tinhTrang)
        {
            return phieuTinhTienDAO.XoaPhieuTinhTien(maBan, tinhTrang);
        }
        public bool CapNhatTrangThaiPhieuTT(int maBan, int tinhTrang)
        {
            return phieuTinhTienDAO.CapNhatTrangThaiPhieuTT(maBan, tinhTrang);
        }
    }
}
