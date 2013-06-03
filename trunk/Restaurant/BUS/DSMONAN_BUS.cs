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
        public DataTable LayDanhSachMonAnTheoLoai(int maLoai)
        {
            return dsMonAnDAO.LayDanhSachMonAnTheoLoai(maLoai);
        }
    }
}
