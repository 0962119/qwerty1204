using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class NGUOIDUNG_BUS
    {
        NguoiDung_DAO dao = new NguoiDung_DAO();
        public DataTable KiemTraDangNhap(NguoiDung dto)
        {
            DataTable dt = new DataTable();
            dt = dao.KiemTraDangNhap(dto);
            return dt;
        }

        public DataTable TimNguoiDung_Datatable(NguoiDung dto)
        {
            return dao.TimNguoiDung_Datatable(dto);
        }


        public DataTable LoadNguoiDung()
        {
            return dao.LoadNguoiDung();
        }

        public void ThemNguoiDung_void(NguoiDung dto)
        {
            dao.ThemNguoiDung_void(dto);
        }

        public void XoaNguoiDung_void(NguoiDung dto)
        {
            dao.XoaNguoiDung_void(dto);
        }

        public void SuaNguoiDung_void(NguoiDung dto)
        {
            dao.SuaNguoiDung_void(dto);
        }
    }
}
