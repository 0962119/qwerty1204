﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
using System.Data;
namespace DAO
{
    /// <summary>
    /// hàm thêm từng chi tiết của phiếu tính tiền
    /// </summary>
    public class CHITIETPHIEUTT_DAO
    {
        public DataTable LayDSCTPhieuTT(int maPhieuTT, int maBan)
        {
            //int kq = -1;
            string sql = "SELECT DISTINCT " +
                         " DANHSACHMONAN.TenMonAn, CHITIETPHIEUTT.SoLuong, DONVITINH.TenDonViTinh, CHITIETPHIEUTT.DonGia, CHITIETPHIEUTT.GiamGia, " +
                         " CHITIETPHIEUTT.ThanhTien, CHITIETPHIEUTT.MonAn" +
" FROM            (PHIEUTINHTIEN INNER JOIN" +
                        " BAN ON PHIEUTINHTIEN.Ban = BAN.MaBan), ((DANHSACHMONAN INNER JOIN" +
                        " CHITIETPHIEUTT ON DANHSACHMONAN.MaMonAn = CHITIETPHIEUTT.MonAn) INNER JOIN" +
                         " DONVITINH ON DANHSACHMONAN.DonViTinh = DONVITINH.ID)" +
" WHERE        (CHITIETPHIEUTT.MaPhieuTT = @maPhieuTT)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();

            OleDbParameter paraMaPhieuTT = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            paraMaPhieuTT.Value = maPhieuTT;
            ListParam.Add(paraMaPhieuTT);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return  dt.ExecuteQuery(sql, ListParam);
        }

        public DataTable LayKMCTPhieuTT(int maPhieuTT, int maMonAn)
        {
            //int kq = -1;
            string sql = "SELECT MaPhieuTT From CHITIETPHIEUTT WHERE MaPhieuTT = @maPhieuTT AND MonAn =@monAn";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();

            OleDbParameter paraMaPhieuTT = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            OleDbParameter paraMaMonAn = new OleDbParameter("@monAn", OleDbType.Integer);

            paraMaPhieuTT.Value = maPhieuTT;
            paraMaMonAn.Value = maMonAn;
            ListParam.Add(paraMaPhieuTT);
            ListParam.Add(paraMaMonAn);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, ListParam);
        }

        public bool ThemCTPhieuTinhTien(ChiTietPhieuTT ctPhieuTT_DTO)
        {
            string sql = "INSERT INTO CHITIETPHIEUTT " +
                "(MaPhieuTT, MonAn, SoLuong, GiamGia, ThanhTien, DonGia, DotKM, GioGoiDatMon)" +
           "VALUES (@maPhieuTT, @monAn, @soLuong,@giamGia, @thanhTien, @donGia, @dotKM, @gioGoiDatMon)";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            OleDbParameter maPTT = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            OleDbParameter monAn = new OleDbParameter("@monAn", OleDbType.Integer);
            OleDbParameter SoLuong = new OleDbParameter("@soLuong", OleDbType.Integer);
            OleDbParameter GiamGia = new OleDbParameter("@giamGia", OleDbType.Integer);
            OleDbParameter ThanhTien = new OleDbParameter("@thanhTien", OleDbType.Double);
            OleDbParameter DonGia = new OleDbParameter("@donGia", OleDbType.Double);
            OleDbParameter DotKhuyenMai = new OleDbParameter("@dotKM", OleDbType.Integer);
            OleDbParameter GioGoiMon = new OleDbParameter("@gioGoiDatMon", OleDbType.Date);

            maPTT.Value = ctPhieuTT_DTO.MaPhieuTT;
            monAn.Value = ctPhieuTT_DTO.MonAn;
            SoLuong.Value = ctPhieuTT_DTO.SoLuong;
            GiamGia.Value = ctPhieuTT_DTO.GiamGia;
            ThanhTien.Value = ctPhieuTT_DTO.ThanhTien;
            DonGia.Value = ctPhieuTT_DTO.DonGia;
            DotKhuyenMai.Value = ctPhieuTT_DTO.DotKhuyenMai;
            GioGoiMon.Value = ctPhieuTT_DTO.GioVao;

            ListParam.Add(maPTT);
            ListParam.Add(monAn);
            ListParam.Add(SoLuong);
            ListParam.Add(GiamGia);
            ListParam.Add(ThanhTien);
            ListParam.Add(DonGia);
            ListParam.Add(DotKhuyenMai);
            ListParam.Add(GioGoiMon);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, ListParam);
            if (kq < 1)
                return false;
            else
                return true;
        }
        /// <summary>
        /// xoa tat ca cac chi tiet co maPhieuTT
        /// </summary>
        /// <param name="maPhieuTT"></param>
        /// <returns></returns>
        public bool XoaCTPhieuTinhTien(int maPhieuTT)
        {
            string sql = "DELETE FROM CHITIETPHIEUTT WHERE  (MaPhieuTT = @maPhieuTT)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paraTinhTrang = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            paraTinhTrang.Value = maPhieuTT;
            listParam.Add(paraTinhTrang);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        /// <summary>
        /// xoa nhung chi tiết có MaPhieuTT và có MaMonAn
        /// </summary>
        /// <param name="maPhieuTT"></param>
        /// <param name="maMonAn"></param>
        /// <returns></returns>
        public bool XoaCTPhieuTinhTien(int maPhieuTT, int maMonAn)
        {
            string sql = "DELETE FROM CHITIETPHIEUTT WHERE  (MaPhieuTT = @maPhieuTT) and MonAn=@maMonAn";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paraTinhTrang = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            OleDbParameter paramaMonAn = new OleDbParameter("@maMonAn", OleDbType.Integer);
            paraTinhTrang.Value = maPhieuTT;
            paramaMonAn.Value = maMonAn;
            listParam.Add(paraTinhTrang);
            listParam.Add(paramaMonAn);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        /// <summary>
        /// cập nhật lại Mã Phiếu Tính Tiền <=> tách món
        /// </summary>
        /// <param name="maPhieuTT"></param>
        /// <param name="maMonAn"></param>
        /// <returns></returns>
        public bool XoaCTPhieuTinhTien(int maPhieuTTOld, int maMonAn, int maPhieuTTNew)
        {
            string sql = "UPDATE CHITIETPHIEUTT SET MaPhieuTT=@maPhieuNew where  (MaPhieuTT = @maPhieuOld) and MonAn=@maMonAn";
            List<OleDbParameter> listParam = new List<OleDbParameter>();

            OleDbParameter paraMaNew = new OleDbParameter("@maPhieuNew", OleDbType.Integer);
            OleDbParameter paraMaOld = new OleDbParameter("@maPhieuOld", OleDbType.Integer);
            OleDbParameter paramaMonAn = new OleDbParameter("@maMonAn", OleDbType.Integer);

            paraMaNew.Value = maPhieuTTNew;
            paraMaOld.Value = maPhieuTTOld;
            paramaMonAn.Value = maMonAn;

            listParam.Add(paraMaNew);
            listParam.Add(paraMaOld);
            listParam.Add(paramaMonAn);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        public void updateMaPTTOfCTPTT(int oldmaPhieuTT, int maMonAn, int newmaPhieuTT)
        {
            string sql = "update CHITIETPHIEUTT set MaPhieuTT=@newmaPhieuTT where (MaPhieuTT = @oldmaPhieuTT) " +
                " and (MonAn=@maMonAn)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter newMaPTT = new OleDbParameter("@newmaPhieuTT", OleDbType.Integer);
            OleDbParameter oldMaPTT = new OleDbParameter("@oldmaPhieuTT", OleDbType.Integer);
            OleDbParameter mama = new OleDbParameter("@maMonAn", OleDbType.Integer);
            newMaPTT.Value = newmaPhieuTT;
            oldMaPTT.Value = oldmaPhieuTT;
            mama.Value = maMonAn;
            listParam.Add(newMaPTT);
            listParam.Add(oldMaPTT);
            listParam.Add(mama);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql, listParam);//ham sai roi nhin jup tao koy cho nao sai 2 thang nhin cho nhanh
        }
        public bool CapNhatCTPhieuTT(int maPhieuTT, int maMonAn, int soLuong, int giamGia, double thanhTien)
        {
            string sql = "UPDATE       CHITIETPHIEUTT "+
                         " SET         SoLuong = @soLuong, GiamGia = @giamGia , ThanhTien=@thanhTien "+
                         " WHERE        (MaPhieuTT = @maPhieuTT) AND (MonAn = @maMonAn)";
            
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paraSoLuong = new OleDbParameter("@soLuong", OleDbType.Integer);
            OleDbParameter paraGiamGia = new OleDbParameter("@giamGia", OleDbType.Integer);
            OleDbParameter paraThanhTien = new OleDbParameter("@thanhTien", OleDbType.Double);
            OleDbParameter paraMaPhieuTT = new OleDbParameter("@maPhieuTT", OleDbType.Integer);
            OleDbParameter paraMonAn = new OleDbParameter("@maMonAn", OleDbType.Integer);

            paraSoLuong.Value = soLuong;
            paraGiamGia.Value = giamGia;
            paraThanhTien.Value = thanhTien;
            paraMaPhieuTT.Value = maPhieuTT;
            paraMonAn.Value = maMonAn;

            listParam.Add(paraSoLuong);
            listParam.Add(paraGiamGia);
            listParam.Add(paraThanhTien);
            listParam.Add(paraMaPhieuTT);
            listParam.Add(paraMonAn);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int obj = dt.ExecuteNoneQuery(sql, listParam);
            if (obj < 1)
                return false;
            else
                return true;
        }
        public bool GhepBan(int maPhieuTTOld, int maPhieuTTNew)
        {
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            string newsql = "select *From CHITIETPHIEUTT  where MaPhieuTT=@maPhieuNew";
            List<OleDbParameter> newlistParam = new List<OleDbParameter>();
            OleDbParameter newpara = new OleDbParameter("@maPhieuNew", OleDbType.Integer);
            newpara.Value = maPhieuTTNew;
            newlistParam.Add(newpara);
            DataTable newtable = new DataTable();
            newtable = dt.ExecuteQuery(newsql, newlistParam);

            string oldsql = "select *From CHITIETPHIEUTT  where MaPhieuTT=@maPhieuold";
            List<OleDbParameter> oldlistParam = new List<OleDbParameter>();
            OleDbParameter oldpara = new OleDbParameter("@maPhieuold", OleDbType.Integer);
            oldpara.Value = maPhieuTTOld;
            oldlistParam.Add(oldpara);
            DataTable oldtable = new DataTable();
            oldtable = dt.ExecuteQuery(oldsql, oldlistParam);

            foreach (DataRow newdtr in newtable.Rows)
            {
                foreach (DataRow olddrt in oldtable.Rows)
                {

                    if (newdtr[1].ToString() == olddrt[1].ToString())
                    {
                        
                        double newDonGia = double.Parse(newdtr[5].ToString());
                        double newGiamGia = int.Parse(newdtr[3].ToString());
                        int newSL = int.Parse(newdtr[2].ToString());
                        int oldSL = int.Parse(olddrt[2].ToString());
                        int slTong = newSL + oldSL;
                        double thanhTienTong = (slTong * newDonGia) - ((slTong * newDonGia) * newGiamGia / 100);
                        XoaCTPhieuTinhTien(int.Parse(olddrt[0].ToString()), int.Parse(olddrt[1].ToString()));
                        
                        string sql = "UPDATE CHITIETPHIEUTT SET SoLuong=@slTong, ThanhTien=@thanhTienTong where  (MaPhieuTT = @newMa) and (MonAn=@maMonAn)";
                        List<OleDbParameter> listParam = new List<OleDbParameter>();

                        OleDbParameter paraSoLuong = new OleDbParameter("@slTong", OleDbType.Integer);
                        OleDbParameter paraThanhTien = new OleDbParameter("@thanhTienTong", OleDbType.Double);
                        OleDbParameter paraNewMa = new OleDbParameter("@newMa", OleDbType.Integer);
                        OleDbParameter paraNewMaMonAn = new OleDbParameter("@maMonAn", OleDbType.Integer);

                        paraSoLuong.Value = slTong;
                        paraThanhTien.Value = thanhTienTong;
                        paraNewMa.Value = int.Parse(newdtr[0].ToString());
                        paraNewMaMonAn.Value = int.Parse(olddrt[1].ToString());

                        listParam.Add(paraSoLuong);
                        listParam.Add(paraThanhTien);
                        listParam.Add(paraNewMa);
                        listParam.Add(paraNewMaMonAn);

                        int obj = dt.ExecuteNoneQuery(sql, listParam);
                        if (obj < 1)
                            return false;
                    }
                }
            }
            foreach (DataRow dtrRow in oldtable.Rows)
            {
                string sql = "UPDATE CHITIETPHIEUTT SET MaPhieuTT=@newMaPhieu where  (MaPhieuTT = @oldMa) and (MonAn=@maMonAn)";
                List<OleDbParameter> listParam = new List<OleDbParameter>();

                OleDbParameter paraOldMa = new OleDbParameter("@oldMa", OleDbType.Integer);
                OleDbParameter paraNewMa = new OleDbParameter("@newMaPhieu", OleDbType.Integer);
                OleDbParameter paraNewMaMonAn = new OleDbParameter("@maMonAn", OleDbType.Integer);

                paraOldMa.Value =maPhieuTTOld;
                paraNewMa.Value = maPhieuTTNew;
                paraNewMaMonAn.Value = int.Parse(dtrRow[1].ToString());

                listParam.Add(paraNewMa);
                listParam.Add(paraOldMa);
                listParam.Add(paraNewMaMonAn);

                int obj = dt.ExecuteNoneQuery(sql, listParam);
            }
            return true;
        }
        private bool DoiBan(int maPhieuTTOld, int maPhieuTTNew)
        {
            if (maPhieuTTNew == -1)// 1 ban co khách 1 bàn khong co khac
            {

            }
            else// ca 2 ban deu co khach
            {

            }
            return true;
        }
        public bool AttackDatainHoaDonRP(DataTable tbHoaDon)
        {
            try
            {
                foreach (DataRow dtr in tbHoaDon.Rows)
                {
                    string sql = " INSERT INTO HOADONRP " +
                               " (TenMonAn, SL, DonGia, GiamGia, TongCong) " +
                               " VALUES (@tenMonAn, @sL, @donGia, @giamGia, @tongCOng)";
                    List<OleDbParameter> ListParam = new List<OleDbParameter>();
                    OleDbParameter tenMonAn = new OleDbParameter("@tenMonAn", OleDbType.VarChar);
                    OleDbParameter sL = new OleDbParameter("@sL", OleDbType.VarChar);
                    OleDbParameter donGia = new OleDbParameter("@donGia", OleDbType.VarChar);
                    OleDbParameter giamGia = new OleDbParameter("@giamGia", OleDbType.VarChar);
                    OleDbParameter tongCOng = new OleDbParameter("@tongCOng", OleDbType.VarChar);
                    tenMonAn.Value = dtr[0];
                    sL.Value = dtr[1];
                    donGia.Value = dtr[2];
                    giamGia.Value = dtr[3];
                    tongCOng.Value = dtr[4];
                    ListParam.Add(tenMonAn);
                    ListParam.Add(sL);
                    ListParam.Add(donGia);
                    ListParam.Add(giamGia);
                    ListParam.Add(tongCOng);
                    NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
                    int kq = dt.ExecuteNoneQuery(sql, ListParam);
                    if (kq < 1)
                        return false;
                }
                return true;
            }
            catch
            {
                DeleteDatainHoaDonRP();
            }
            return true;
        }
        public void DeleteDatainHoaDonRP()
        {
            string sql = " Delete From HOADONRP ";
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int kq = dt.ExecuteNoneQuery(sql);
        }


        //NHD 
        public DataTable LoadChiTietPhieuTT_datatable(int MaPhieu)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT * from CHITIETPHIEUTT  where MaPhieuTT = "+MaPhieu;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

       

        //tổng thành tiền sau khi +- khuyen mai
        public string ThanhTien_string(int MaPhieu)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT sum(ThanhTien) as ThanhTien from CHITIETPHIEUTT Where MaPhieuTT = " + MaPhieu;
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        //tổng đơn giá chuẩn        
        public string DonGia_string(int MaPhieu)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "SELECT sum(DonGia) as DonGia from CHITIETPHIEUTT Where MaPhieuTT = " + MaPhieu;
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        ///<summary>
        /// Lấy tổng tiền, trung bình trên từng loại món ăn
        ///</summary>
        /// <param name="tuNgay"></param>
        ///<param name="denNgay"></param>
        ///<param name="tenLoaiMonAn"></param>
        /// <returns></returns>
        public DataTable ThongKe_TheoTenLoaiMonAn(DateTime tuNgay, DateTime denNgay, string tenLoaiMonAn)
        {
            string sql = " SELECT LOAIMONAN.TenLoaiMonAn,DANHSACHMONAN.TenMonAn, sum(CHITIETPHIEUTT.SoLuong) AS SoLuong, count(CHITIETPHIEUTT.MaPhieuTT) as SoHD,sum(CHITIETPHIEUTT.ThanhTien) as TongThanhTien"
     + " FROM (LOAIMONAN INNER JOIN (DANHSACHMONAN INNER JOIN CHITIETPHIEUTT ON DANHSACHMONAN.MaMonAn = CHITIETPHIEUTT.MonAn) ON LOAIMONAN.MaLoaiMonAn = DANHSACHMONAN.LoaiMonAn) INNER JOIN PHIEUTINHTIEN ON CHITIETPHIEUTT.MaPhieuTT = PHIEUTINHTIEN.MaPhieuTT"
     + " WHERE LOAIMONAN.TenLoaiMonAn like '%" + tenLoaiMonAn + "%' and PHIEUTINHTIEN.NgayLapPhieu>= @tuNgay and PHIEUTINHTIEN.NgayLapPhieu<=@denNgay"
     + " GROUP BY LOAIMONAN.TenLoaiMonAn,DANHSACHMONAN.TenMonAn";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paratuNgay = new OleDbParameter("@tuNgay", OleDbType.Date);
            OleDbParameter paraDenNgay = new OleDbParameter("@denNgay", OleDbType.Date);
            paratuNgay.Value = tuNgay;
            paraDenNgay.Value = denNgay;
            listParam.Add(paratuNgay);
            listParam.Add(paraDenNgay);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, listParam);
        }
        ///<summary>
        /// Lấy tổng tiền, trung bình trên từng món ăn
        ///</summary>
        /// <param name="tuNgay"></param>
        ///<param name="denNgay"></param>
        ///<param name="tenLoaiMonAn"></param>
        ///<param name="tenMonAn"></param>
        /// <returns></returns>
        public DataTable ThongKe_TheoTenMonAn(DateTime tuNgay, DateTime denNgay, string tenMon, string tenLoaiMon)
        {
            string sql = " SELECT LOAIMONAN.TenLoaiMonAn,DANHSACHMONAN.TenMonAn, sum(CHITIETPHIEUTT.SoLuong) AS SoLuong, count(CHITIETPHIEUTT.MaPhieuTT) as SoHD,sum(CHITIETPHIEUTT.ThanhTien) as TongThanhTien"
                 + " FROM (LOAIMONAN INNER JOIN (DANHSACHMONAN INNER JOIN CHITIETPHIEUTT ON DANHSACHMONAN.MaMonAn = CHITIETPHIEUTT.MonAn) ON LOAIMONAN.MaLoaiMonAn = DANHSACHMONAN.LoaiMonAn) INNER JOIN PHIEUTINHTIEN ON CHITIETPHIEUTT.MaPhieuTT = PHIEUTINHTIEN.MaPhieuTT"
                 + " WHERE LOAIMONAN.TenLoaiMonAn like '%" + tenLoaiMon + "%' and DANHSACHMONAN.TenMonAn like '%" + tenMon + "%' and PHIEUTINHTIEN.NgayLapPhieu>= @tuNgay and PHIEUTINHTIEN.NgayLapPhieu<=@denNgay"
                 + " GROUP BY LOAIMONAN.TenLoaiMonAn,DANHSACHMONAN.TenMonAn";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter paratuNgay = new OleDbParameter("@tuNgay", OleDbType.Date);
            OleDbParameter paraDenNgay = new OleDbParameter("@denNgay", OleDbType.Date);
            paratuNgay.Value = tuNgay;
            paraDenNgay.Value = denNgay;
            listParam.Add(paratuNgay);
            listParam.Add(paraDenNgay);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            return dt.ExecuteQuery(sql, listParam);
        }

        public void XoaChiTietPhieuTT_void(int maHoaDon)
        {
            OleDbConnection conn = DataProvider.ConnectDB();
            string sql = "DELETE * FROM CHITIETPHIEUTT where MaPhieuTT =" + maHoaDon;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            //OleDbParameter para = cmd.Parameters.AddWithValue("@TaiKhoan", dto.TaiKhoan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int KiemTraMonTonTai(int maPhieu, int maMA)
        {
            string sql = "select SoLuong From CHITIETPHIEUTT where (MonAn = @maMA) and (MaPhieuTT=@maPhieu)";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter monAn = new OleDbParameter("@maMA", OleDbType.Integer);
            OleDbParameter phieu = new OleDbParameter("@maPhieu", OleDbType.Integer);
            monAn.Value = maMA;
            phieu.Value = maPhieu;
            listParam.Add(monAn);
            listParam.Add(phieu);
            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            object result  = dt.ExecuteScalar(sql, listParam);
            return int.Parse(result.ToString());
        }
        public int CapNhatSoLuongCT(int maPhieu, int maMA, int soLuong)
        {//
            string sql = "update CHITIETPHIEUTT set SoLuong = SoLuong + @soLuong  where MaPhieuTT=@maPhieu and MonAn =@maMA";
            List<OleDbParameter> listParam = new List<OleDbParameter>();
            OleDbParameter monAn = new OleDbParameter("@maMA", OleDbType.Integer);
            OleDbParameter phieu = new OleDbParameter("@maPhieu", OleDbType.Integer);
            OleDbParameter sl = new OleDbParameter("@soLuong", OleDbType.Integer);

            monAn.Value = maMA;
            phieu.Value = maPhieu;
            sl.Value = soLuong;

            listParam.Add(sl);
            listParam.Add(phieu);
            listParam.Add(monAn);

            NETDataProviders.DataProvider dt = new NETDataProviders.DataProvider();
            int result = dt.ExecuteNoneQuery(sql, listParam);
            return result;
        }

    }
}
