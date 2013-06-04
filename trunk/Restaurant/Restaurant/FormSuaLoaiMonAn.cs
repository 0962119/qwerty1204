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
    public partial class FormSuaLoaiMonAn : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormSuaLoaiMonAn()
        {
            InitializeComponent();
        }
        LOAIMONAN_BUS dslmabus = new LOAIMONAN_BUS();
        private void btnDongYSuaLTD_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiTD.Text == "")
            {
                FormWarningSuaLoaiTD frm = new FormWarningSuaLoaiTD();
                frm.ShowDialog();
            }
            else
            {
                dslmabus.SuaTenLoaiMonAn(txtTenLoaiTD.Text,Form1.idNode);
                this.Close();
            }
        }

        public int maloaima { get; set; }
    }
}