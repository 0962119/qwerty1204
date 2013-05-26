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
        public  DataTable KiemTraDangNhap(NguoiDung dto)
        {
            NguoiDung_DAO dao = new NguoiDung_DAO();
            DataTable dt = new DataTable();
            dt = dao.KiemTraDangNhap(dto);
            return dt;
        }
    }
}
