using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class CHITIETPHIEUTT_BUS
    {
        CHITIETPHIEUTT_DAO ctPhieuTT_DAO = new CHITIETPHIEUTT_DAO();
        public bool ThemCTPhieuTinhTien(ChiTietPhieuTT ctPhieuTT_DTO)
        {
            return ctPhieuTT_DAO.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
        }
        public bool XoaCTPhieuTinhTien(int maPhieuTT)
        {
            return ctPhieuTT_DAO.XoaCTPhieuTinhTien(maPhieuTT);
        }
    }
}
