using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BAN_DTO
    {
        private int maBan;

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        private string tenBan;

        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }
        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        private int maKhuVuc;

        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }
        private int soKhach;

        public int SoKhach
        {
            get { return soKhach; }
            set { soKhach = value; }
        }
        public BAN_DTO(int maBan1, string tenBan1, int trangThai1, int maKhuVuc1, int soKhach1)
        {
            maBan = maBan1;
            tenBan = tenBan1;
            trangThai = trangThai1;
            maKhuVuc = maKhuVuc1;
            soKhach = soKhach1;
        }
    }
}
