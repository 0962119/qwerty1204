using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class DSMONAN_BUS
    {
        DSMONAN_DAO dsMonAnDAO = new DSMONAN_DAO();
        public DataTable LayDSMonAn()
        {
            return dsMonAnDAO.LayDSMonAn();
        }
        public string LayHinhMonAn(int maMonAn)
        {
            return dsMonAnDAO.LayHinhMonAn(maMonAn);
        }
        public DataTable LayDSMonAn(string tenBan)
        {
            return dsMonAnDAO.LayDSMonAn(tenBan);
        }
        public DataTable LayDanhSachMonAnTheoLoai(int maloaima)
        {
            return dsMonAnDAO.LayDanhSachMonAnTheoLoai(maloaima);
        }
        public DataTable LayDSMonAnTheoLoai(int maLoai)
        {
            return dsMonAnDAO.LayDSMonAnTheoLoai(maLoai);
        }
        public bool ThemThucDon(DSMONAN_DTO DSMA_DTO)
        {
            return dsMonAnDAO.ThemThucDon(DSMA_DTO);
        }
        public DataTable TimKiemTD(DSMONAN_DTO dsmadto)
        {
            return dsMonAnDAO.TimKiemTD(dsmadto);
        }
        public bool ThemThucDon(string p, string p_2, string p_3)
        {
            throw new NotImplementedException();
        }
    }
}
