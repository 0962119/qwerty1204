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
    public partial class FormWarningDelete : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormWarningDelete()
        {
            InitializeComponent();
        }
        LOAIMONAN_BUS loaimabus = new LOAIMONAN_BUS();
        private void btnYesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                loaimabus.XoaLoaiMonAn(Form1.idNode);
                this.Close();  
            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa!");
            }
            
        }
    }
}