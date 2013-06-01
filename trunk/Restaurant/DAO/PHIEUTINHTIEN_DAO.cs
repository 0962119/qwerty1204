using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
using System.Data;
namespace DAO
{
    public class PHIEUTINHTIEN_DAO
    {

        public bool ThemPhieuTinhTien(PhieuTinhTien phieuTT_DTO)
        {
            string sql = "INSERT INTO PHIEUTINHTIEN "+
                "(Ban, NhanVien, TongTien, NgayLapPhieu, KhachDuaTruoc, GhiChu, GiamGia, VAT, TinhTrang, Giovao, Giora)"+
           "VALUES (@maBan, @tenNhanVien, @tongTien, @ngayLap, @duaTruoc,@ghiChu, @giamGia, @vAT, @tinhTrang, @gioVao, @gioRa)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter maBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter tenNhanVien = new OleDbParameter("@tenNhanVien", OleDbType.VarChar);
            OleDbParameter tongTien = new OleDbParameter("@tongTien", OleDbType.Double);
            OleDbParameter ngayLap = new OleDbParameter("@ngayLap", OleDbType.Date);
            OleDbParameter duaTruoc = new OleDbParameter("@duaTruoc", OleDbType.Double);
            OleDbParameter ghiChu = new OleDbParameter("@ghiChu", OleDbType.VarChar);
            OleDbParameter giamGia = new OleDbParameter("@giamGia", OleDbType.Integer);
            OleDbParameter vAT = new OleDbParameter("@vAT", OleDbType.Integer);
            OleDbParameter tinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            OleDbParameter gioVao = new OleDbParameter("@Giovao", OleDbType.Date);
            OleDbParameter gioRa = new OleDbParameter("@Giora", OleDbType.Date);

            maBan.Value = phieuTT_DTO.Ban;
            tenNhanVien.Value = phieuTT_DTO.NhanVien;
            tongTien.Value = phieuTT_DTO.TongTien;
            ngayLap.Value = phieuTT_DTO.NgayLapPhieu;
            duaTruoc.Value = phieuTT_DTO.KhachDuaTruoc;
            ghiChu.Value = phieuTT_DTO.GhiChu;
            giamGia.Value = phieuTT_DTO.GiamGia;
            vAT.Value = phieuTT_DTO.VAT;
            tinhTrang .Value = phieuTT_DTO.TinhTrang;
            gioVao.Value = phieuTT_DTO.Giovao;
            gioRa.Value = phieuTT_DTO.Giora;

            ListParam.Add( maBan);
            ListParam.Add( tenNhanVien);
            ListParam.Add( tongTien);
            ListParam.Add( ngayLap);
            ListParam.Add( duaTruoc);
            ListParam.Add( ghiChu);
            ListParam.Add( giamGia);
            ListParam.Add( vAT);
            ListParam.Add( tinhTrang);
            ListParam.Add(gioVao);
            ListParam.Add(gioRa);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, ListParam);
            if (kq < 1)
                return false;
            else
                return true;
        }
        public int LayMaPhieuTinhTien(int maBan, int tinhTrang)
        {
            string sql = "select MaPhieuTT from PHIEUTINHTIEN where Ban=@maBan and TinhTrang=@tinhTrang";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paraTinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            paramaBan.Value = maBan;
            paraTinhTrang.Value = tinhTrang;
            listParam.Add(paramaBan);
            listParam.Add(paraTinhTrang);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            object obj = dt.ExecuteScalar(sql, listParam);
            try
            {
                int kq = int.Parse(obj.ToString());
                return kq;
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// lấy mã phiêu tinh tien cua ban có khách hoặc bàn được đặt trước là tồn tại duy nhất
        /// </summary>
        /// <param name="maBan"></param>
        /// <returns></returns>
        public int LayMaPhieuTinhTien(int maBan)
        {
            string sql = "select MaPhieuTT from PHIEUTINHTIEN where( Ban=@maBan and ( TinhTrang=1 or TinhTrang = 3))";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            paramaBan.Value = maBan;
            listParam.Add(paramaBan);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();

            object obj = dt.ExecuteScalar(sql, listParam);
            try
            {
                int kq = int.Parse(obj.ToString());
                return kq;
            }
            catch
            {
                return -1;
            }
        }
        //public double TinhTongTienPhieuTT(int maPhieuTinhTien)
        //{

        //}
        public DataTable LayPhieuTinhTien(int maBan)
        {
            string sql = "select * from PHIEUTINHTIEN where( Ban=@maBan and (TinhTrang=1 or TinhTrang = 3))";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            paramaBan.Value = maBan;
            listParam.Add(paramaBan);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, listParam);
            
        }
        public bool XoaPhieuTinhTien(int maBan, int tinhTrang)
        {
            string sql = "DELETE FROM PHIEUTINHTIEN WHERE  (Ban = @maBan) AND (TinhTrang = @tinhTrang)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paraTinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            paramaBan.Value = maBan;
            paraTinhTrang.Value = tinhTrang;
            listParam.Add(paramaBan);
            listParam.Add(paraTinhTrang);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        public bool XoaPhieuTinhTien(int maPhieu)
        {
            string sql = "DELETE FROM PHIEUTINHTIEN WHERE  (MaPhieuTT=@maPhieu)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaPhieu = new OleDbParameter("@maPhieu", OleDbType.Integer);
            paramaPhieu.Value = maPhieu;
            listParam.Add(paramaPhieu);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }



        public bool CapNhatTrangThaiPhieuTT(int maBan, int tinhTrang)
        {
            string sql = "UPDATE PHIEUTINHTIEN SET TinhTrang= @tinhTrang WHERE Ban = @maBan";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paraTinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            paraTinhTrang.Value = tinhTrang;
            listParam.Add(paraTinhTrang);
            paramaBan.Value = maBan;
            listParam.Add(paramaBan);

            
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        public bool UpDatePhieuTT(PhieuTinhTien phieuTT_DTO)
        {
            string sql = "UPDATE PHIEUTINHTIEN SET " +
                "Ban=@maBan, NhanVien=@tenNhanVien, TongTien=@tongTien, NgayLapPhieu= @ngayLap, KhachDuaTruoc=@duaTruoc, GhiChu=@ghiChu, GiamGia=@giamGia, VAT=@vAT, TinhTrang=@tinhTrang, Giovao=@gioVao, Giora= @gioRa " +
           "where MaPhieuTT=@maPhieuTT";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter maBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter tenNhanVien = new OleDbParameter("@tenNhanVien", OleDbType.VarChar);
            OleDbParameter tongTien = new OleDbParameter("@tongTien", OleDbType.Double);
            OleDbParameter ngayLap = new OleDbParameter("@ngayLap", OleDbType.Date);
            OleDbParameter duaTruoc = new OleDbParameter("@duaTruoc", OleDbType.Double);
            OleDbParameter ghiChu = new OleDbParameter("@ghiChu", OleDbType.VarChar);
            OleDbParameter giamGia = new OleDbParameter("@giamGia", OleDbType.Integer);
            OleDbParameter vAT = new OleDbParameter("@vAT", OleDbType.Integer);
            OleDbParameter tinhTrang = new OleDbParameter("@tinhTrang", OleDbType.Integer);
            OleDbParameter gioVao = new OleDbParameter("@Giovao", OleDbType.Date);
            OleDbParameter gioRa = new OleDbParameter("@Giora", OleDbType.Date);
            OleDbParameter maPhieuTT = new OleDbParameter("@maPhieuTT", OleDbType.Integer);

            maBan.Value = phieuTT_DTO.Ban;
            tenNhanVien.Value = phieuTT_DTO.NhanVien;
            tongTien.Value = phieuTT_DTO.TongTien;
            ngayLap.Value = phieuTT_DTO.NgayLapPhieu;
            duaTruoc.Value = phieuTT_DTO.KhachDuaTruoc;
            ghiChu.Value = phieuTT_DTO.GhiChu;
            giamGia.Value = phieuTT_DTO.GiamGia;
            vAT.Value = phieuTT_DTO.VAT;
            tinhTrang.Value = phieuTT_DTO.TinhTrang;
            gioVao.Value = phieuTT_DTO.Giovao;
            gioRa.Value = phieuTT_DTO.Giora;
            maPhieuTT.Value = phieuTT_DTO.MaPhieuTT;

            ListParam.Add(maBan);
            ListParam.Add(tenNhanVien);
            ListParam.Add(tongTien);
            ListParam.Add(ngayLap);
            ListParam.Add(duaTruoc);
            ListParam.Add(ghiChu);
            ListParam.Add(giamGia);
            ListParam.Add(vAT);
            ListParam.Add(tinhTrang);
            ListParam.Add(gioVao);
            ListParam.Add(gioRa);
            ListParam.Add(maPhieuTT);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, ListParam);
            if (kq < 1)
                return false;
            else
                return true;
        }
        public double LayTongTienPhieuTT(int maPhieu)
        {
            string sql = "SELECT SUM(ThanhTien) FROM CHITIETPHIEUTT ct WHERE (MaPhieuTT = @maPhieu)";
            List<OleDbParameter> listPara = new List<OleDbParameter>();
            OleDbParameter paraMaPhieu=new OleDbParameter("@maPhieu", OleDbType.Integer);
            paraMaPhieu.Value=maPhieu;
            listPara.Add(paraMaPhieu);
            NETDataProviders.DataProvider dt=new NETDataProviders.DataProvider();
            object obj= dt.ExecuteScalar(sql, listPara);
            double kq=-1;
            kq=double.Parse(obj.ToString());
            sql = "SELECT GiamGia, VAT FROM PHIEUTINHTIEN WHERE (MaPhieuTT = @maPhieu)";
            List<OleDbParameter> listPara1 = new List<OleDbParameter>();
            OleDbParameter paraMaPhieu1 = new OleDbParameter("@maPhieu", OleDbType.Integer);
            paraMaPhieu1.Value = maPhieu;
            listPara1.Add(paraMaPhieu1);
            DataTable dtr = dt.ExecuteQuery(sql, listPara1);
            int vat =int.Parse( dtr.Rows[0][0].ToString());
            int giamGia = int.Parse(dtr.Rows[0][1].ToString());
            double result =(kq - kq * giamGia / 100) - (kq - kq * giamGia / 100)*vat/100;
            return result;
        }
        public bool CapNhapTienPhieuTT(int maPhieuTT, double tongTien)
        {
            string sql = "UPDATE PHIEUTINHTIEN SET TongTien=@tongTien" +
                " WHERE MaPhieuTT = @maPhieu";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paraTongTien = new OleDbParameter("@tongTien", OleDbType.Double);
            OleDbParameter paraMaPhieu = new OleDbParameter("@maPhieu", OleDbType.Integer);
            paraTongTien.Value = tongTien;
            listParam.Add(paraTongTien);
            paraMaPhieu.Value = maPhieuTT;
            listParam.Add(paraMaPhieu);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        public bool CapNhatBanChoPhieuTT(int maPhieu, int maBan)
        {
            string sql = "UPDATE PHIEUTINHTIEN SET Ban= @maBan WHERE MaPhieuTT = @maPhieu";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paramaBan = new OleDbParameter("@maBan", OleDbType.Integer);
            OleDbParameter paramaPhieu = new OleDbParameter("@maPhieu", OleDbType.Integer);
            paramaBan.Value = maBan;
            listParam.Add(paramaBan);
            paramaPhieu.Value = maPhieu;
            listParam.Add(paramaPhieu);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }

        public DataTable FilterPhieuTT_Datatable(string NgayDau, string NgayCuoi)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT MaPhieuTT,Ban,NhanVien,TongTien,NgayLapPhieu,Giovao, Giora from PhieuTinhTien Where NgayLapPhieu between #" + NgayDau + "# and #" + NgayCuoi + "#";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            ////OleDbParameter para = cmd.Parameters.AddWithValue("@NgayDau", NgayDau);
            ////para = cmd.Parameters.AddWithValue("@NgayCuoi", NgayCuoi);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public string TongTienThongKeHoaDon(string NgayDau, string NgayCuoi)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT sum(TongTien) as TongTienAll from PhieuTinhTien Where NgayLapPhieu between #" + NgayDau + "# and #" + NgayCuoi + "#";
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(sql, conn);            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
    }
}
