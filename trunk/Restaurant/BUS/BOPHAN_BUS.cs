using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BOPHAN_BUS
    {
        public DataTable LoadBoPhan_DataTable()
        {
            BoPhan_DAO dao = new BoPhan_DAO();
            DataTable dt = new DataTable();
            dt = dao.LoadBoPhan_DataTable();
            return dt;
        }

        public string FilterBoPhan_String(BoPhan dto)
        {
            BoPhan_DAO dao = new BoPhan_DAO();
            string x = dao.FilterBoPhan_String(dto);
            return x;
        }
    }
}
