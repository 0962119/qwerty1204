using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DTO;
using BUS;

namespace Restaurant
{
    public partial class frmChiTietHoaDon : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        public int temp1, temp2, Tong;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            CHITIETPHIEUTT_BUS ChiTietPhieuTTBus = new CHITIETPHIEUTT_BUS();
            balloonTip1.SetBalloonCaption(dgvChiTietPhieuTinhTien, "double click vào dòng để xem chi tiết");
                 

            lbBan.Text = Form1.Ban_DG;
            lbThoiGian.Text = Form1.ThoiGian_DG;
            lbNhanVien.Text = Form1.NhanVien_DG;

           // lbTongTien.Text = ChiTietPhieuTTBus.DonGia_string(int.Parse(Form1.MaPhieuTT_DG));
            lbTongTienThanhToan.Text = ChiTietPhieuTTBus.ThanhTien_string(int.Parse(Form1.MaPhieuTT_DG));

            dgvChiTietPhieuTinhTien.DataSource = ChiTietPhieuTTBus.LoadChiTietPhieuTT(int.Parse(Form1.MaPhieuTT_DG));
            
                     
            
            int temp = dgvChiTietPhieuTinhTien.RowCount;
            
            for (int i = 0; i < temp - 1; i++)
            {
                Tong += int.Parse(dgvChiTietPhieuTinhTien.Rows[i].Cells["SoLuong"].Value.ToString()) * int.Parse(dgvChiTietPhieuTinhTien.Rows[i].Cells["DonGia"].Value.ToString());
            }
            lbTongTien.Text = Tong.ToString();
        }
    }
}