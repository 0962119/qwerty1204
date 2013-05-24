using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TinhTrang
    {
        #region Atrrubutes
        private int _maTinhTrang;
        private String _tenTinhTrang;
        #endregion
        #region Default Constructor
        public TinhTrang()
        {
            _maTinhTrang = 0;
            _tenTinhTrang = String.Empty;
        }
        #endregion
        #region Properties
        public String TenTinhTrang
        {
            get { return _tenTinhTrang; }
            set { _tenTinhTrang = value; }
        }

        public int MaTinhTrang
        {
            get { return _maTinhTrang; }
            set { _maTinhTrang = value; }
        }
        #endregion
    }
}
