using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiThongKe
    {
        #region Atrrubutes
        private int _maLoaiTK;
        private String _tenLoaiTK;
        #endregion
        #region Default Constructor
        public LoaiThongKe()
        {
            _maLoaiTK = 0;
            _tenLoaiTK = String.Empty;
        }

        #endregion
        #region Properties
        public String TenLoaiTK
        {
            get { return _tenLoaiTK; }
            set { _tenLoaiTK = value; }
        }

        public int MaLoaiTK
        {
            get { return _maLoaiTK; }
            set { _maLoaiTK = value; }
        }
        #endregion
    }
}
