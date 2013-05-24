using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;
namespace DAO
{
    public class DSMONAN_DAO
    {
        public DataTable LayDSMonAn()
        {
            string sql = "SELECT        dsma.MaMonAn, dsma.TenMonAn, dsma.LoaiMonAn, dsma.DonGia, dsma.GiamGia, dsma.HinhAnh, dv.TenDonViTinh  FROM (DANHSACHMONAN dsma INNER JOIN DONVITINH dv ON dsma.DonViTinh = dv.ID)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }
    }
}
