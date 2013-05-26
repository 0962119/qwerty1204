using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using BUS;
using DTO;
using System.Data.OleDb;
using NETDataProviders;
using System.Runtime.InteropServices;
namespace Restaurant
{
    public partial class Form1 : MetroAppForm
    {
        BAN_BUS banBUS = new BAN_BUS();
        KHUVUC_BUS khuVucBus = new KHUVUC_BUS();
        DSMONAN_BUS dsMonAnBus = new DSMONAN_BUS();
        PHIEUTINHTIEN_BUS phieuTT_Bus = new PHIEUTINHTIEN_BUS();
        CHITIETPHIEUTT_BUS ctPhieuTT_BUS = new CHITIETPHIEUTT_BUS();
        /// <summary>
        /// mã của bàn hiện đang được chọn:
        /// =-1 là chưa chọn bàn
        /// # -1 là đã chọn bàn
        /// </summary>
        public int MaBanDangChon = -1;
        public int TrangThaiBanDangChon = -1;
        public NguoiDung nhanVienDangNhap = new NguoiDung();
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFrmThoiGian.Text = String.Format("{0:d/M/yyyy - HH:mm:ss}", DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            DataTable dsKhuVuc=khuVucBus.LayDSKHUVUC();
            LoadKhuVuc(dsKhuVuc);
            lvShowBan.Clear();
            LoadBan(dsKhuVuc, banBUS.LayDSBan());
            LoadThucDon();
            
        }
        public void LoadKhuVuc(DataTable dsKhuVuc)
        {
            cbxFrm1KhuVuc.DataSource = dsKhuVuc;
        }
        public void LoadBan(DataTable dsKhuVuc, DataTable dsBan)
        {
           
            foreach (DataRow dtr in dsKhuVuc.Rows)
            {
                ListViewGroup lvg = new ListViewGroup();
                lvg.Header = dtr[1].ToString();
                lvShowBan.Groups.Add(lvg);
            }
            foreach (DataRow dtr in dsBan.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                int trangThai = int.Parse(dtr[2].ToString());
                lvi.Tag = dtr[0];
                lvi.Text = dtr[1].ToString();
                lvi.ForeColor = Color.Green;
                FontFamily f = new FontFamily("Forte");
                lvi.Font = new Font(f, lvi.Font.Size+3);
                if(trangThai==1)
                    lvi.ImageIndex = 1;
                else if(trangThai==2)
                    lvi.ImageIndex = 2;
                else
                    lvi.ImageIndex = 0;
                int group = int.Parse(dtr[3].ToString()) - 1;
                lvi.Group = lvShowBan.Groups[group];
                //lvi.UseItemStyleForSubItems = true;
                lvShowBan.Items.Add(lvi);
            }
        }
        public void LoadThucDon()
        {
            

            string sql = "select * from LOAIMONAN";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            DataProvider dt = new DataProvider();
            DataTable dtbBan = new DataTable();
            dtbBan = dt.ExecuteQuery(sql, ListParam);
            foreach (DataRow dtr in dtbBan.Rows)
            {
                ListViewGroup lvg = new ListViewGroup();
                lvg.Header = dtr[1].ToString();
                lvShowMonAn.Groups.Add(lvg);
            }
            dtbBan = new DataTable();
            dtbBan = dsMonAnBus.LayDSMonAn();
            int n=dtbBan.Rows.Count;
            int[] rexIndex = new int[n];
            int nIndex=0;
            foreach (DataRow dtr in dtbBan.Rows)
            {
                int ma=int.Parse( dtr[0].ToString());
                ListViewItem lvi = new ListViewItem();
                imageList2.Images.Add(Image.FromFile(dtr[5].ToString()));
                rexIndex[ma-1] = nIndex;
                lvi.Tag = ma;
                lvi.Text = dtr[1].ToString();
                lvi.ImageIndex = rexIndex[ma-1];
                int group = int.Parse(dtr[2].ToString()) - 1;
                lvi.Group = lvShowMonAn.Groups[group];
                lvi.UseItemStyleForSubItems = true;
                lvi.SubItems.Add(dtr[6].ToString());
                lvi.SubItems.Add(dtr[4].ToString());
                lvi.SubItems.Add(dtr[3].ToString());
                lvShowMonAn.Items.Add(lvi);
                nIndex++;
            }
        }
         
        
        private void metroTileItem15_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
            expandablePanel1.TitleHeight = 1;
            metroTabItem3.Select();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void metroStatusBar1_MouseHover(object sender, EventArgs e)
        {
            //expandablePanel1.Expanded = true;
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void metroTabItem7_Click(object sender, EventArgs e)
        {

            frmBaoCaoDoanhThu frmbaoCaoDT = new frmBaoCaoDoanhThu();
            frmbaoCaoDT.Show();
        }
        //image =0 dat truoc; image =1 trong ; image =2 co khách
        //tinhtrang= 3 dat truoc; tinhtrang= 2 da tinh; tinhtrang=1 chưa tinh
        private void lvShowBan_DoubleClick(object sender, EventArgs e)
        {
            int index=int.Parse( lvShowBan.SelectedItems[0].Tag.ToString());
            MaBanDangChon = index;
            //MessageBox.Show(index.ToString());
            if (lvShowBan.SelectedItems[0].ImageIndex == 2)//ban da co khách
            {
                DialogResult result =MessageBox.Show("Chọn Yes Nếu Bạn Mốn Hủy Bàn Hay Chọn No Chuyển Sang Trạng Thái Đặt Trước", "Thông Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ma = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon, 1);
                    lvShowBan.SelectedItems[0].ImageIndex = 1;// bàn trong
                    banBUS.UpdateTrangThaiBan(1, index);
                    TrangThaiBanDangChon = 1;
                    ctPhieuTT_BUS.XoaCTPhieuTinhTien(ma);
                    phieuTT_Bus.XoaPhieuTinhTien(MaBanDangChon, 1);
                    MaBanDangChon = -1;
                    TrangThaiBanDangChon = -1;
                }
                else if (result == DialogResult.No)
                {
                    if (phieuTT_Bus.CapNhatTrangThaiPhieuTT(MaBanDangChon, 3) == true)
                    {
                        lvShowBan.SelectedItems[0].ImageIndex = 0; //dat truoc
                        banBUS.UpdateTrangThaiBan(3, index);
                        TrangThaiBanDangChon = 3;
                    }
                }
            }
            else if (lvShowBan.SelectedItems[0].ImageIndex == 1)// trong
            {
                lvShowBan.SelectedItems[0].ImageIndex = 2;
                banBUS.UpdateTrangThaiBan(2, index);
                TrangThaiBanDangChon = 2;

                PhieuTinhTien phieuTinhTien_DTO = new PhieuTinhTien();
                phieuTinhTien_DTO.Ban = MaBanDangChon;
                phieuTinhTien_DTO.GhiChu = txtFrm1NhapGhiChu.Text;
                phieuTinhTien_DTO.NhanVien = "admin";//nhanVienDangNhap.TaiKhoan;
                phieuTinhTien_DTO.TongTien = thanhToan;
                phieuTinhTien_DTO.NgayLapPhieu = DateTime.Now;
                phieuTinhTien_DTO.KhachDuaTruoc = 0;
                phieuTinhTien_DTO.GiamGia = giamGia;
                phieuTinhTien_DTO.VAT = vAT;
                phieuTinhTien_DTO.TinhTrang = 1;
                phieuTT_Bus.ThemPhieuTinhTien(phieuTinhTien_DTO);
                //int maPhieuTT = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon, 1);
            }
            else// dat truoc
            {
                lvShowBan.SelectedItems[0].ImageIndex = 2;
                banBUS.UpdateTrangThaiBan(2, index);
                TrangThaiBanDangChon = 2;
                phieuTT_Bus.CapNhatTrangThaiPhieuTT(MaBanDangChon, 1);
            }
            lvShowBan.Clear();
            LoadBan(khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
            labelX16.Text = MaBanDangChon.ToString();
            labelX34.Text = TrangThaiBanDangChon.ToString();
        }
        private void lvShowBan_Click(object sender, EventArgs e)
        {
            int index = int.Parse(lvShowBan.SelectedItems[0].Tag.ToString());
            if (lvShowBan.SelectedItems[0].ImageIndex != 1)
            {
                MaBanDangChon = index;
                if (lvShowBan.SelectedItems[0].ImageIndex == 2)
                {
                    TrangThaiBanDangChon = 1;
                }
                else
                    TrangThaiBanDangChon = 3;

            }
            else
            {
                MaBanDangChon = -1;
                TrangThaiBanDangChon = -1;
            }
            string tenBan = lvShowBan.SelectedItems[0].Text.ToString();
            lbFrm1TenBanAn.Text=tenBan;
            labelX34.Text = TrangThaiBanDangChon.ToString();
            labelX16.Text = MaBanDangChon.ToString();
        }
        private void lvShowMonAn_DoubleClick(object sender, EventArgs e)
        {
            if (MaBanDangChon != -1)
            {
                int index = int.Parse(lvShowMonAn.SelectedItems[0].Tag.ToString());
                string tenMonAn = lvShowMonAn.SelectedItems[0].Text;//sl dongia giam gia
                //int sL=int.Parse(lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString());
                double donGia = double.Parse(lvShowMonAn.SelectedItems[0].SubItems[3].Text.ToString());
                int giamGia = int.Parse(lvShowMonAn.SelectedItems[0].SubItems[2].Text.ToString());
                string dVT = lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString();
                DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();
                try
                {
                    row.Cells[0].Value = int.Parse(dtgvFrm1ThucDon.Rows[dtgvFrm1ThucDon.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                }
                catch
                {
                    row.Cells[0].Value = 1;
                }
                row.Cells[1].Value = tenMonAn;
                row.Cells[2].Value = 1;//sl
                row.Cells[3].Value = dVT;
                row.Cells[4].Value = donGia;
                row.Cells[5].Value = giamGia;
                row.Cells[6].Value = donGia - (donGia * giamGia) / 100;
                dtgvFrm1ThucDon.Rows.Add(row);
                double tt = 0;
                foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                {
                    try
                    {
                        tt += double.Parse(dtr.Cells[6].Value.ToString());
                    }
                    catch { }
                }
                tongTien = tt;
                int gg = int.Parse(txtFrm1GiaGia.Text);
                int vat = int.Parse(txtFrm1VAT.Text);
                BaoGia(gg, vat);
                int maPTT= phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                ChiTietPhieuTT ctPhieuTT_DTO = new ChiTietPhieuTT();
                ctPhieuTT_DTO.MaPhieuTT = maPTT;
                ctPhieuTT_DTO.MonAn = index;
                ctPhieuTT_DTO.SoLuong = 1;
                ctPhieuTT_DTO.GiamGia = giamGia;
                ctPhieuTT_DTO.DonGia = donGia;
                ctPhieuTT_DTO.ThanhTien = donGia - (donGia * giamGia) / 100;
                ctPhieuTT_BUS.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn, Nhấp Đôi Chuột Vào Bàn Cần Order");
            }
        }
        double tongTien = 0;
        double thanhToan = 0;
        /// <summary>
        /// thue gia tri gia tang 
        /// </summary>
        double vAT = 0;
        /// <summary>
        /// Bien toan cuc giảm giá tổng trên hóa đơn
        /// </summary>
        double giamGia = 0;
        int giamGiaPT = 0;
        int giamGiavat = 0;
        double khachTra = 0;
        double thoiLai = 0;
        private void dtgvFrm1ThucDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex==2|| e.ColumnIndex==4||e.ColumnIndex==5)
                {
                    int sL = int.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                    double donGia = double.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[4].Value.ToString());
                    int giamGia = int.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[5].Value.ToString());
                    dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[6].Value = (donGia * sL) - ((donGia * sL * giamGia) / 100);
                    
                    foreach(DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                    {
                        tongTien+=double.Parse( dtr.Cells[6].Value.ToString());
                    }
                }
            }
            catch
            {
            }
            int gg = int.Parse(txtFrm1GiaGia.Text);
            int vat = int.Parse(txtFrm1VAT.Text);
            BaoGia(gg, vat);
        }
        private void BaoGia(int giamgiaphantram, int vat)
        {
            giamGia= tongTien -(tongTien-( tongTien*giamgiaphantram/100));
            vAT = tongTien - (tongTien-( tongTien * vat / 100));
            thanhToan = tongTien - (giamGia + vAT);
            lbFrm1GiamGia.Text = giamGia.ToString();
            lbFrm1VAT.Text = vAT.ToString();
            thoiLai=khachTra-thanhToan;
            lbFrm1ThoiLai.Text = thoiLai.ToString();
            lbFrm1TongTien.Text = tongTien.ToString();
            lbFrm1ThanhToan.Text = thanhToan.ToString();
        }

        private void txtFrm1GiaGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                giamGiaPT = int.Parse(txtFrm1GiaGia.Text);
                int vat = int.Parse(txtFrm1VAT.Text);
                BaoGia(giamGiaPT, vat);
            }
            catch
            {
                txtFrm1GiaGia.Text = "0";
            }

        }

        private void txtFrm1VAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                giamGiavat = int.Parse(txtFrm1VAT.Text);
                int gg = int.Parse(txtFrm1GiaGia.Text);
                BaoGia(gg, giamGiavat);
            }
            catch
            {
                txtFrm1VAT.Text = "0";
            }
        }

        private void txtFrm1KhachTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                khachTra = int.Parse(txtFrm1KhachTra.Text);
                int gg= int.Parse(txtFrm1GiaGia.Text);
                int vat=int.Parse(txtFrm1VAT.Text);
                BaoGia(gg, vat);
            }
            catch
            {
                txtFrm1KhachTra.Text = "0";
            }
        }

        private void cbxFrm1KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhuVuc = cbxFrm1KhuVuc.SelectedIndex;
            //banBUS.LayDSBan(maKhuVuc);
            lvShowBan.Clear();
            LoadBan(khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan(maKhuVuc+1));
        }

        private void btnFrm1LoadBanAll_Click(object sender, EventArgs e)
        {
            lvShowBan.Clear();
            LoadBan(khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
        }

        private void txtFrm1TimBan_TextChanged(object sender, EventArgs e)
        {
            lvShowBan.Clear();
            DataTable dtBan=banBUS.LayDSBan(txtFrm1TimBan.Text);
            LoadBan(khuVucBus.LayDSKHUVUC(), dtBan);
        }

        private void txtFrm1NhapGhiChu_Click(object sender, EventArgs e)
        {
            if (txtFrm1NhapGhiChu.Text == "Nhập Ghi Chú Của Bàn.......")
                txtFrm1NhapGhiChu.Text = "";
                
        }

        private void txtFrm1NhapGhiChu_Validated(object sender, EventArgs e)
        {
            if(txtFrm1NhapGhiChu.Text.Length<1)
                txtFrm1NhapGhiChu.Text = "Nhập Ghi Chú Của Bàn.......";
        }

        private void lvShowBan_Validated(object sender, EventArgs e)
        {

        }



        //2 event button thất lạc --
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDung dto = new NguoiDung();
            dto.TaiKhoan = txtTaiKhoan.Text;
            dto.MatKhau = txtMatKhau.Text;
            NGUOIDUNG_BUS bus = new NGUOIDUNG_BUS();
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                lbThongBaoDangNhap.Text = "Tên Tài khoản và Mật Khẩu không được bỏ trống!!!";
            }
            else
            {

                try
                {
                    int temp = bus.KiemTraDangNhap(dto).Rows.Count;
                    if (temp > 0)
                    {
                        expan_DangNhap.Hide();                        

                    }
                    else
                    {
                        lbThongBaoDangNhap.Text = "sai Tài khoản hoặc Mật khẩu. vui lòng kiểm tra!!!";
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi hệ thống");
                }

                

            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--./.
        

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            NguoiDung dto = new NguoiDung();
            dto.TaiKhoan = txtTaiKhoan.Text;
            dto.MatKhau = txtMatKhau.Text;
            NGUOIDUNG_BUS bus = new NGUOIDUNG_BUS();
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                lbThongBaoDangNhap.Text = "Tên Tài khoản và Mật Khẩu không được bỏ trống!!!";
            }
            else
            {
                try
                {
                    int temp = bus.KiemTraDangNhap(dto).Rows.Count;
                    if (temp > 0)
                    {
                        expan_DangNhap.Hide();
                    }
                    else{
                        lbThongBaoDangNhap.Text = "sai Tài khoản hoặc Mật khẩu. vui lòng kiểm tra!!!";
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi hệ thống");
                }
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
