using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class BAN_BUS
    {
        BAN_DAO banDAO = new BAN_DAO();
        public DataTable LayDSBan()
        {
            return banDAO.LayDSBan();
        }
        public DataTable LayDSBan(int maKhuVuc)
        {
            return banDAO.LayDSBan(maKhuVuc);
        }
        public DataTable LayDSBan(string tenBan)
        {
            return banDAO.LayDSBan(tenBan);
        }
        public bool UpdateTrangThaiBan(int trangThai, int maBan)
        {
            return banDAO.UpdateTrangThaiBan(trangThai, maBan);
        }
        public bool KiemTraBanCoKhach(int trangThai, int maBan)
        {
            return banDAO.KiemTraBanCoKhach(trangThai, maBan);
        }
    }
}
