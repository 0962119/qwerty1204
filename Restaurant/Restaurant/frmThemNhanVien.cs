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
    public partial class frmThemNhanVien : MetroForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnDongYThemNV_Click(object sender, EventArgs e)
        {
            NguoiDung NguoiDungDAO = new NguoiDung();
            NGUOIDUNG_BUS NguoiDungBUS = new NGUOIDUNG_BUS();

            if (txtDienThoai_ThemNV.Text == "" || txtMatKhau_ThemNV.Text == "" || txtNhapLaiMKThemNV.Text == "" || txtTenNV_ThemNV.Text == "" || txtTenTaiKhoanThemNV.Text == "")
            {
                lbThongBao_ThemNV.Text = "cần nhập đầy đủ thông tin";

            }
            else
            {
                if (txtNhapLaiMKThemNV.Text == txtMatKhau_ThemNV.Text)
                {

                    NguoiDungDAO.MatKhau = txtMatKhau_ThemNV.Text;
                    NguoiDungDAO.SDT = txtDienThoai_ThemNV.Text;
                    NguoiDungDAO.TaiKhoan = txtTenTaiKhoanThemNV.Text;
                    NguoiDungDAO.TenNguoiDung = txtTenNV_ThemNV.Text;
                    NguoiDungDAO.BoPhan = int.Parse(cmbChucVuThemNV.SelectedValue.ToString());
                    try
                    {
                        NguoiDungBUS.ThemNguoiDung_void(NguoiDungDAO);
                        this.Close();
                        MessageBox.Show("thêm thành công", "Thông báo");

                    }
                    catch
                    {
                        lbThongBao_ThemNV.Text = "đổi tên tài khoản khác";
                    }
                }
                else
                    lbThongBao_ThemNV.Text = "Mật khẩu nhập lại không trùng khớp";
            }
        }
        public void LoadCmbBoPhan()
        {
            BOPHAN_BUS BoPhanBUS = new BOPHAN_BUS();
            DataTable dt = new DataTable();
            dt = BoPhanBUS.LoadBoPhan_DataTable();
            cmbChucVuThemNV.DataSource = dt;
            cmbChucVuThemNV.DisplayMember = "TenBoPhan";
            cmbChucVuThemNV.ValueMember = "MaBoPhan";
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadCmbBoPhan();
            
        }

        private void btnHuyThemNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
