using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class PhieuTinhTien
    {
        #region Atrributes
        private int _maPhieuTT;
        private int _ban;        
        private string _nhanVien;
        private double _tongTien;
        private double _thanhToan;
        private DateTime _ngayLapPhieu;
        private double _khachDuaTruoc;
        private String _ghiChu;
        private double _giamGia;
        private DateTime _giovao;

        public DateTime Giovao
        {
            get { return _giovao; }
            set { _giovao = value; }
        }
        private DateTime _giora;

        public DateTime Giora
        {
            get { return _giora; }
            set { _giora = value; }
        }

        public double GiamGia
        {
            get { return _giamGia; }
            set { _giamGia = value; }
        }
        private double _vAT;

        public double VAT
        {
            get { return _vAT; }
            set { _vAT = value; }
        }
        private int _tinhTrang;

        public int TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
                             
        #endregion
        #region Default Constructor
        public PhieuTinhTien()
        {
            _maPhieuTT = 0;
            _ban = 0;
            _nhanVien = "admin";
            _tongTien = 0;
            _thanhToan = 0;
            _ngayLapPhieu = DateTime.Now;
            _khachDuaTruoc = 0 ;
            _ghiChu = String.Empty;
            _giamGia = 0;
            _vAT = 0;
            _tinhTrang = - 1;
            _giovao = DateTime.Now;
            _giora = DateTime.Now;
        }
        #endregion
        #region Properties

        public int MaPhieuTT
        {
            get { return _maPhieuTT; }
            set { _maPhieuTT = value; }
        }
        public int Ban
        {
            get { return _ban; }
            set { _ban = value; }
        }
        public string NhanVien
        {
            get { return _nhanVien; }
            set { _nhanVien = value; }
        }
        public double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        public double ThanhToan
        {
            get { return _thanhToan; }
            set { _thanhToan = value; }
        }
        public DateTime NgayLapPhieu
        {
            get { return _ngayLapPhieu; }
            set { _ngayLapPhieu = value; }
        }
        public double KhachDuaTruoc
        {
            get { return _khachDuaTruoc; }
            set { _khachDuaTruoc = value; }
        }
        public String GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        #endregion
    }
}
