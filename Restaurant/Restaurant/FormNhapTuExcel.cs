using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.OleDb;

namespace Restaurant
{
    public partial class FormNhapTuExcel : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormNhapTuExcel()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        private void btnBrowser_Click(object sender, EventArgs e)
        {// cai cho conn khong co dc viet kung nhu zay! phai lam cai cho cho ngta thay doi chu// uhm 
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtLinkExcel.Text + ";Extended Properties=Excel 12.0;";
            OleDbConnection con = new OleDbConnection(conn);
            OleDbDataAdapter sda = new OleDbDataAdapter("SELECT * FROM ['" + txtLinkExcel.Text + "$']", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

    }
}