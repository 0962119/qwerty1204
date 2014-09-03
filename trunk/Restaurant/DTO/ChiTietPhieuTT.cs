using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;



namespace DTO
{
    public class ChiTietPhieuTT
    {
        #region Atrributes
        private int _maPhieuTT;
        private DateTime _gioVao;
        private DateTime _gioRa;
        private int _monAn;
        private int _soLuong;
        private int _giamGia;
        private double _thanhTien;
        private double _donGia;
        private int _dotKM;
        
              
        #endregion
        #region Default Constructor
        public ChiTietPhieuTT()
        {
            _maPhieuTT = 0;
            _gioVao = DateTime.Now;
            _gioRa = DateTime.Now;
            _monAn = 0;
            _soLuong = 0;
            _giamGia = 0;
            _thanhTien = 0;
            _donGia = 0;
            _dotKM = 0;
        }
        #endregion
        #region Properties
        public double ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
        public double DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        public int GiamGia
        {
            get { return _giamGia; }
            set { _giamGia = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public int MonAn
        {
            get { return _monAn; }
            set { _monAn = value; }
        }

        public DateTime GioRa
        {
            get { return _gioRa; }
            set { _gioRa = value; }
        }

        public DateTime GioVao
        {
            get { return _gioVao; }
            set { _gioVao = value; }
        }

        public int MaPhieuTT
        {
            get { return _maPhieuTT; }
            set { _maPhieuTT = value; }
        }
        public int DotKhuyenMai
        {
            get { return _dotKM; }
            set { _dotKM = value; }
        }
#endregion
    }
}
