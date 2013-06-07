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

        CHITIETPHIEUTT_BUS ChiTietPhieuTTBus = new CHITIETPHIEUTT_BUS();
        PHIEUTINHTIEN_BUS PhieuTinhTienBus = new PHIEUTINHTIEN_BUS();
        int temp;

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            
            balloonTip1.SetBalloonCaption(dgvChiTietPhieuTinhTien, "double click vào dòng để xem chi tiết");
                 

            lbBan.Text = Form1.Ban_DG;
            lbThoiGian.Text = Form1.ThoiGian_DG;
            lbNhanVien.Text = Form1.NhanVien_DG;
            //load len dgv
            dgvChiTietPhieuTinhTien.DataSource = ChiTietPhieuTTBus.LoadChiTietPhieuTT(int.Parse(Form1.MaPhieuTT_DG));

            //
            TinhTongTien();

           // lbTongTien.Text = ChiTietPhieuTTBus.DonGia_string(int.Parse(Form1.MaPhieuTT_DG));
            lbTongTienThanhToan.Text = ChiTietPhieuTTBus.ThanhTien_string(int.Parse(Form1.MaPhieuTT_DG));     
            
                     
            
            
        }

        public void TinhTongTien()
        {
            temp = dgvChiTietPhieuTinhTien.RowCount;

            for (int i = 0; i < temp - 1; i++)
            {
                Tong += int.Parse(dgvChiTietPhieuTinhTien.Rows[i].Cells["SoLuong"].Value.ToString()) * int.Parse(dgvChiTietPhieuTinhTien.Rows[i].Cells["DonGia"].Value.ToString());
            }
            lbTongTien.Text = Tong.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NguoiDung NguoiDungDTO = new NguoiDung();
            DialogResult DR = MessageBox.Show("Bạn muốn xóa? \n Phiếu: " + Form1.MaPhieuTT_DG, "Thông Báo Xóa Phiếu", MessageBoxButtons.OKCancel);
            
            if (DialogResult.OK == DR)
            {
                try
                {

                    ChiTietPhieuTTBus.XoaChiTietPhieuTT_void(int.Parse(Form1.MaPhieuTT_DG));
                    PhieuTinhTienBus.XoaPhieuTinhTien(int.Parse(Form1.MaPhieuTT_DG));
                    
                    MessageBox.Show("xoá thành công!");
                    this.Close();
                    
                }
                catch
                {
                    MessageBox.Show("mời chọn phiếi cần xoá!");
                }
            }
            else
                return;

            
        }
    }
}