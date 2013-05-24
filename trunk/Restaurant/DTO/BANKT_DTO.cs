using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BANKT_DTO: BAN_DTO
    {
        private string tenTrangThai;

        public string TenTrangThai
        {
            get { return tenTrangThai; }
            set { tenTrangThai = value; }
        }
        private string tenKhuVuc;

        public string TenKhuVuc
        {
            get { return tenKhuVuc; }
            set { tenKhuVuc = value; }
        }
        public BANKT_DTO(int maBan1, string tenBan1, int trangThai1, int maKhuVuc1,int soKhach1, string tenTrangThai1, string tenKhuVuc1): base(maBan1, tenBan1, trangThai1, maKhuVuc1, soKhach1)
        {
            tenTrangThai = tenTrangThai1;
            tenKhuVuc = tenKhuVuc1;
        }
    }
}
