using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BUS;

namespace Restaurant
{
    public partial class FormThemThucDon : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormThemThucDon()
        {
            InitializeComponent();
            cbbLoaiTD.DisplayMember = "TenLoaiMonAn";
            cbbLoaiTD.ValueMember = "MaLoaiMonAn";
            cbbDVT.DisplayMember = "TenDonViTinh";
            cbbDVT.ValueMember = "ID";
            ComboBoxItem cbi = new ComboBoxItem("Thêm Đơn Vị Tính Mới");
            cbbDVT.Items.Add(cbi);
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void txtThemThucDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
        LOAIMONAN_BUS lmabus = new LOAIMONAN_BUS();
        DONVITINH_BUS dvtbus = new DONVITINH_BUS();
        DSMONAN_BUS dsmabus = new DSMONAN_BUS();
        private void FormThemThucDon_Load(object sender, EventArgs e)
        {
            cbbLoaiTD.DataSource = lmabus.LayDSLoaiMonAn();
            cbbDVT.DataSource = dvtbus.DSDonViTinh();
        }
        
        private void cbbLoaiTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void pictureboxTD_Click(object sender, EventArgs e)
        {

        }
        
        private void btOK_Click(object sender, EventArgs e)
        {
            if(txtThemThucDon.Text == "" || txtGiamGia.Text == "" || txtGiaBan.Text == "")
            {
                FormWarningThemLoaiTD frm = new FormWarningThemLoaiTD();
                frm.ShowDialog();
            }
            else
            {
                bool kq = dsmabus.ThemThucDon(txtThemThucDon.Text, txtGiaBan.Text, txtGiamGia.Text);
                this.Close();
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                txtGiaBan.Text = "Bạn phải nhập số!";
            }
            else
            {
                if(Char.IsDigit(e.KeyChar))
                {
                    txtGiaBan.Text = "";
                }
                    
            }
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
               txtGiamGia.Text = "Bạn phải nhập số!";
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    txtGiamGia.Text = "";
                }

            }
        }

        private void cbbDVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbDVT.Text=="Thêm Đơn Vị Tính Mới")
            {
               FormThemDVT frm=new FormThemDVT();
                frm.ShowDialog();
            }
            else
            {
                
            }
        }
    }
}