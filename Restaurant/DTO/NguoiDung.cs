using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NguoiDung
    {
        #region Atrributes
        private String _taiKhoan;
        private String _matKhau;
        private int _boPhan;
        private String _tenNguoiDung;
        private String _sDT;
        private int _tinhTrang;
        #endregion
        #region Default Constructor
        public NguoiDung()
        {
            _taiKhoan = "-1";
            _matKhau = "-1";
            _boPhan = 0;
            _tenNguoiDung = "-1";
            _sDT = "-1";
            _tinhTrang = 0;
        }
        #endregion
        #region Properties
        public int TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }

        public String SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }

        public String TenNguoiDung
        {
            get { return _tenNguoiDung; }
            set { _tenNguoiDung = value; }
        }

        public int BoPhan
        {
            get { return _boPhan; }
            set { _boPhan = value; }
        }

        public String MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        public String TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }
        #endregion
    }
}
