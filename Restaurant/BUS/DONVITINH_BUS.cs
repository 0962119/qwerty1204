using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class DONVITINH_BUS
    {
        DonViTinh_DAO dvtdao = new DonViTinh_DAO();
        public DataTable DSDonViTinh()
        {
            return dvtdao.DSDonViTinh();
        }
    }
}
