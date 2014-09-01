using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BUS;
using DTO;
using System.IO;

namespace Restaurant
{
    public partial class FormThemThucDon : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormThemThucDon()
        {
            InitializeComponent();
            cbbDVT.DisplayMember = "TenDonViTinh";
            cbbDVT.ValueMember = "ID";
            ComboBoxItem cbi = new ComboBoxItem("Thêm Đơn Vị Tính Mới");
            cbbDVT.Items.Add(cbi);
        }
        LOAIMONAN_BUS lmabus = new LOAIMONAN_BUS();
        DONVITINH_BUS dvtbus = new DONVITINH_BUS();
        DSMONAN_BUS dsmabus = new DSMONAN_BUS();
        DSMONAN_DTO dsmadto = new DSMONAN_DTO();
        private void FormThemThucDon_Load(object sender, EventArgs e)
        {
            cbbDVT.DataSource = dvtbus.DSDonViTinh();
           
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if(txtThemThucDon.Text == ""|| txtGiaBan.Text == "")
            {
                FormWarningThemLoaiTD frm = new FormWarningThemLoaiTD();
                frm.ShowDialog();
            }
            else
            {
                DSMA_DTO.TenMonAn = txtThemThucDon.Text;
                DSMA_DTO.DVT = int.Parse(cbbDVT.SelectedValue.ToString());
                DSMA_DTO.DonGia =double.Parse( txtGiaBan.Text);
                DSMA_DTO.LoaiMonAn = Form1.idNode;
                if(DSMA_DTO.HinhAnh==null)
                {
                    DSMA_DTO.HinhAnh = "thoat.jpg";
                }
                dsmabus.ThemThucDon(DSMA_DTO);
                this.Close();
                //MessageBox.Show("Them Thanh Cong");
            }
            
        }

        private int convert(string p)
        {
            throw new NotImplementedException();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(('0' <= e.KeyChar && e.KeyChar <= '9') || e.KeyChar == (int)Keys.Back || e.KeyChar == (int)Keys.Delete))
                //e.Handled = true;
                txtGiaBan.Text = "Bạn phải nhập số!";
        }
        private void cbbDVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbDVT.Text == "Thêm Đơn Vị Tính Mới")
            {
               FormThemDVT frm=new FormThemDVT();
                frm.ShowDialog();
            }
            else
            {
                
            }
        }
        public DSMONAN_DTO DSMA_DTO = new DSMONAN_DTO();
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void pictureboxTD_Click_1(object sender, EventArgs e)
        {
            imagedialog.Filter = "Bitmaps(*.bmp)|*.jpg|All files(*.*)|*.*";
            imagedialog.Title = "Chọn ảnh thực đơn...";

            if(imagedialog.ShowDialog() == DialogResult.OK)
            {
                string str = imagedialog.FileName.Substring(imagedialog.FileName.LastIndexOf("\\")+1);
                Image imgTD = Image.FromFile(imagedialog.FileName);
                Size s = new Size(124, 130);
                Image img = resizeImage(imgTD, s);
                pictureboxTD.Image = img;
                File.Delete(Form1.path + "\\imageThucDon\\" + str);
                img.Save(Form1.path + "\\imageThucDon\\" + str);
                //File.Copy(imagedialog.FileName, Form1.path + "\\imageThucDon\\"+ str);
                DSMA_DTO.HinhAnh = str;

            }
        }

    }
}