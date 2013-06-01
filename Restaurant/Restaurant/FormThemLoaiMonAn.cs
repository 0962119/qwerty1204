using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Restaurant
{
    public partial class FormThemLoaiMonAn : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormThemLoaiMonAn()
        {
            InitializeComponent();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}