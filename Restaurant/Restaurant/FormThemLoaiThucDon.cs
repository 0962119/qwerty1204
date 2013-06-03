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
    public partial class FormThemLoaiThucDon : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormThemLoaiThucDon()
        {
            InitializeComponent();
        }

        private void FormThemLoaiThucDon_Load(object sender, EventArgs e)
        {

        }
        LOAIMONAN_BUS dslmabus = new LOAIMONAN_BUS();
        private void btnDongYLoaiTD_Click(object sender, EventArgs e)
        {
            if(txtLoaiThucDon.Text == "")
            {
                FormWarningThemLoaiTD frmwar = new FormWarningThemLoaiTD();
                frmwar.ShowDialog();
            }
            else
            {
                bool kq = dslmabus.ThemLoaiMonAn(txtLoaiThucDon.Text);
                this.Close();
            }
        }

        private void btnHuyboLoaiTD_Click(object sender, EventArgs e)
        {

        }

        private void txtLoaiThucDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
}