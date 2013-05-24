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
    }
}
