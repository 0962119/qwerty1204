using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiMonAnDTOcs
    {
        private int? _MaLoaiMonAn;

        public int? MaLoaiMonAn
        {
            get { return _MaLoaiMonAn; }
            set { _MaLoaiMonAn = value; }
        }
        private string _TenLoaiMonAn;

        public string TenLoaiMonAn
        {
            get { return _TenLoaiMonAn; }
            set { _TenLoaiMonAn = value; }
        }
    }
}
