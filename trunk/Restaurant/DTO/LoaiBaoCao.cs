using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class LoaiBaoCao
    {
        #region Atrrubutes
        private int _maLoaiBC;
        private String _tenLoaiBaoCao;

       
        #endregion
        #region Default Constructor
        public LoaiBaoCao()
        {
            _maLoaiBC = 0;
            _tenLoaiBaoCao = String.Empty;
        }
        #endregion
        #region Properties
        public String TenLoaiBaoCao
        {
            get { return _tenLoaiBaoCao; }
            set { _tenLoaiBaoCao = value; }
        }

        public int MaLoaiBC
        {
            get { return _maLoaiBC; }
            set { _maLoaiBC = value; }
        }
        #endregion
    }
}
