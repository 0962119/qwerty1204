using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
namespace BUS
{
    public class KHUVUC_BUS
    {
        KHUVUC_DAO khuVucDAO = new KHUVUC_DAO();
        public DataTable LayDSKHUVUC()
        {
            return khuVucDAO.LayDSKHUVUC();
        }
    }
}
