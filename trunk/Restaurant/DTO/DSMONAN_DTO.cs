using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DSMONAN_DTO
    {
        private int maMonAN;

        public int MaMonAN
        {
            get { return maMonAN; }
            set { maMonAN = value; }
        }
        private string tenMonAn;

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }
        private int loaiMonAn;

        public int LoaiMonAn
        {
            get { return loaiMonAn; }
            set { loaiMonAn = value; }
        }
        private double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private int giamGia;

        public int GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        private string hinhAnh;

        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        private int dVT;

        public int DVT
        {
            get { return dVT; }
            set { dVT = value; }
        }
    }
}
