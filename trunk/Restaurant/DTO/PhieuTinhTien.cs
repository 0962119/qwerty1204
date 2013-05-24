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
        private int _nhanVien;
        private double _tongTien;
        private DateTime _ngayLapPhieu;
        private String _khachDuaTruoc;
        private String _ghiChu;
                             
        #endregion
        #region Default Constructor
        public PhieuTinhTien()
        {
            _maPhieuTT = 0;
            _ban = 0;
            _nhanVien = 0;
            _tongTien = 0;
            _ngayLapPhieu = DateTime.Now;
            _khachDuaTruoc = String.Empty;
            _ghiChu = String.Empty;
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
        public int NhanVien
        {
            get { return _nhanVien; }
            set { _nhanVien = value; }
        }
        public double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        public DateTime NgayLapPhieu
        {
            get { return _ngayLapPhieu; }
            set { _ngayLapPhieu = value; }
        }
        public String KhachDuaTruoc
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
