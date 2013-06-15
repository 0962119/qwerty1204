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
    public partial class FormWarningDeleteTD : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormWarningDeleteTD()
        {
            InitializeComponent();
        }
        DSMONAN_BUS dsmabus = new DSMONAN_BUS();
        private void btnYesDelete_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = Form1.dtgirdViewTD.SelectedRows.Count;
            if (icountSelectedRow == 0)
            {
                MessageBox.Show("Bạn hãy chọn dòng cần xoá!");
            }
            else
            {
                //string id = Form1.dtgirdViewTD.Rows[Form1.dtgirdViewTD.CurrentRow.Index].Cells[0].Value.ToString();
                foreach (DataGridViewRow row in Form1.dtgirdViewTD.SelectedRows)
                {
                    if (!row.IsNewRow) Form1.dtgirdViewTD.Rows.Remove(row);
                }
                this.Close();
            }
        }
    }
}