using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class BoPhan
    {
#region Atrrubutes
        private int _maBoPhan;
        private String _tenBoPhan;

       
#endregion
#region Default Constructor
       public BoPhan()
        {
            _maBoPhan = 0;
            _tenBoPhan = String.Empty;
        }
#endregion
#region Properties
        public String TenBoPhan
        {
            get { return _tenBoPhan; }
            set { _tenBoPhan = value; }
        }

        public int MaBoPhan
        {
            get { return _maBoPhan; }
            set { _maBoPhan = value; }
        }
#endregion
    }
}
