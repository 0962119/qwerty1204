using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DonViTinh
    {
        #region Atrrubutes
        private int _iD;
        private String _tenDonViTinh;
        #endregion
        #region Default Constructor
        public DonViTinh()
        {
            _iD = 0;
            _tenDonViTinh = String.Empty;
        }
        #endregion
        #region Properties
        public String TenDonViTinh
        {
            get { return _tenDonViTinh; }
            set { _tenDonViTinh = value; }
        }

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        #endregion
    }
}
