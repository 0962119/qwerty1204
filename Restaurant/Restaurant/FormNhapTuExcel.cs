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
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog Exceldialog = new OpenFileDialog();
            if (Exceldialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtLinkExcel.Text = Exceldialog.FileName;     
            } 
        }

        private void btnOKNhapExcel_Click(object sender, EventArgs e)
        {
            if (txtSheetName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên Sheet muốn import!");
            }
            else
            {
                string pathconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtLinkExcel.Text + ";Extended Properties=\"Excel 8.0;HDR=YES;\";";
                OleDbConnection conn = new OleDbConnection(pathconn);

                OleDbDataAdapter ExceldataAdapter = new OleDbDataAdapter("SELECT * FROM [" + txtSheetName.Text + "$]", conn);
                DataTable dt = new DataTable();

                ExceldataAdapter.Fill(dt);
                Form1.dtgirdViewTD.DataSource = dt;
                conn.Close();
            }
        }

    }
}