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
    public partial class frmSuaNhanVien : MetroForm
    {
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }

        private void btnDongYSuaNV_Click(object sender, EventArgs e)
        {
            NguoiDung NguoiDungDAO = new NguoiDung();
            NGUOIDUNG_BUS NguoiDungBUS = new NGUOIDUNG_BUS();

            if (txtDienThoai_SuaNV.Text == "" || txtMatKhau_SuaNV.Text == "" || txtNhapLaiMKSuaNV.Text == "" || txtTenNV_SuaNV.Text == "" || txtTenTaiKhoanSuaNV.Text == "")
            {
                lbThongBao_SuaNV.Text = "cần nhập đầy đủ thông tin";

            }
            else
            {
                if (txtNhapLaiMKSuaNV.Text == txtMatKhau_SuaNV.Text)
                {

                    NguoiDungDAO.MatKhau = txtMatKhau_SuaNV.Text;
                    NguoiDungDAO.SDT = txtDienThoai_SuaNV.Text;
                    NguoiDungDAO.TaiKhoan = txtTenTaiKhoanSuaNV.Text;
                    NguoiDungDAO.TenNguoiDung = txtTenNV_SuaNV.Text;
                    NguoiDungDAO.BoPhan = int.Parse(cmbChucVuSuaNV.SelectedValue.ToString());
                    try
                    {
                        //MessageBox.Show(NguoiDungDAO.TenNguoiDung);
                        NguoiDungBUS.SuaNguoiDung_void(NguoiDungDAO);
                        this.Close();
                        MessageBox.Show("Sửa thành công", "Thông báo");

                    }
                    catch
                    {
                        //lbThongBao_SuaNV.Text = "đổi tên tài khoản khác";
                    }
                }
                else
                    lbThongBao_SuaNV.Text = "Mật khẩu nhập lại không trùng khớp";
            }
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            BOPHAN_BUS BoPhanBUS = new BOPHAN_BUS();
            DataTable dt = new DataTable();
            dt = BoPhanBUS.LoadBoPhan_DataTable();
            cmbChucVuSuaNV.DataSource = dt;
            cmbChucVuSuaNV.DisplayMember = "TenBoPhan";
            cmbChucVuSuaNV.ValueMember = "MaBoPhan";

            txtDienThoai_SuaNV.Text = (Form1.SDTS).ToString();
            txtMatKhau_SuaNV.Text = Form1.MatKhauS;
            txtNhapLaiMKSuaNV.Text = "";
            txtTenNV_SuaNV.Text = Form1.TenNVS;
            txtTenTaiKhoanSuaNV.Text = Form1.TaiKhoanS;
            cmbChucVuSuaNV.Text = Form1.ChucVuS;
        }

        private void btnHuySuaNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
