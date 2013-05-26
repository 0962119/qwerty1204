using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class TrangThaiBan_DTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string tenTrangThai;

        public string TenTrangThai
        {
            get { return tenTrangThai; }
            set { tenTrangThai = value; }
        }
    }
}
