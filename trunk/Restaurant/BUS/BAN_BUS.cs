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
        /// <summary>
        /// Kiểm tra bàn với maBan và trang thái đã có hóa đơn hay chưa?
        /// =-1 với maBan và trangThai này thì chưa có phieutinhtien nao.
        /// #-1 return mã phiếu tính tiền.
        /// </summary>
        /// <param name="tinhTrang">một số int là trạng thái của hóa đơn có thể là chưa tính tiền hoặc là tính rồi....</param>
        /// <param name="maBan">một số int là mã của bàn đang được chọn để kiểm tra</param>
        /// <returns>return mã phiếu tính tiền.</returns>
        public int KiemTraBanCoKhach(int trangThai, int maBan)
        {
            return banDAO.KiemTraBanCoKhach(trangThai, maBan);
        }
        public DataTable LayDSBanTheoTrangThai(int maTrangThai)
        {
            return banDAO.LayDSBanTheoTrangThai(maTrangThai);
        }
    }
}
