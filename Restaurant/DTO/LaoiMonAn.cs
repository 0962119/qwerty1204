using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LaoiMonAn
    {
        #region Atrrubutes
        private int _maLoaiMonAn;
        private String _tenLoaiMonAn;
        #endregion
        #region Default Constructor
        public LaoiMonAn()
        {
            _maLoaiMonAn = 0;
            _tenLoaiMonAn = String.Empty;
        }
        #endregion
        #region Properties
        public String TenLoaiMonAn
        {
            get { return _tenLoaiMonAn; }
            set { _tenLoaiMonAn = value; }
        }

        public int MaLoaiMonAn
        {
            get { return _maLoaiMonAn; }
            set { _maLoaiMonAn = value; }
        }
        #endregion
    }
}
