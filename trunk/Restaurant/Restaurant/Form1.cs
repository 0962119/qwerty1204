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
using System.Collections;
using System.IO;
using Microsoft.VisualBasic.Devices;
using Microsoft.Reporting.WinForms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Reflection;
using System.Configuration;
using System.Xml;
using DevComponents.Editors.DateTimeAdv;
using DevComponents.DotNetBar.Controls;


namespace Restaurant
{
    public partial class Form1 : MetroAppForm
    {
        BAN_BUS banBUS = new BAN_BUS();
        KHUVUC_BUS khuVucBus = new KHUVUC_BUS();
        DSMONAN_BUS dsMonAnBus = new DSMONAN_BUS();
        PHIEUTINHTIEN_BUS phieuTT_Bus = new PHIEUTINHTIEN_BUS();
        CHITIETPHIEUTT_BUS ctPhieuTT_BUS = new CHITIETPHIEUTT_BUS();
        LOAIMONAN_BUS dsLoaiMAbus = new LOAIMONAN_BUS();
        NGUOIDUNG_BUS NguoiDungBUS = new NGUOIDUNG_BUS();
        MonneyClass mn = new MonneyClass();
        DotKhuyenMai_BUS dotKMBus = new DotKhuyenMai_BUS();
        ChiTietKhungGio_BUS chitietKGBus = new ChiTietKhungGio_BUS();
        ChiTietKMOFMonAn_BUS chitietKMOfMonAnBus = new ChiTietKMOFMonAn_BUS();
        /// <summary>
        /// mã của bàn hiện đang được chọn:
        /// =-1 là chưa chọn bàn
        /// # -1 là đã chọn bàn
        /// </summary>
        /// 
        //biến static
        public static string TenNVS, ChucVuS, TaiKhoanS, MatKhauS, SDTS;
        public int Quyen;

        public int MaBanDangChon = -1;
        public int TrangThaiBanDangChon = -1;
        private int ImgBanDangChon = -1;
        public NguoiDung nhanVienDangNhap = new NguoiDung();

        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Form1.dtgirdViewTD = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(Form1.dtgirdViewTD)).BeginInit();

            this.metroTabPanel4.Controls.Add(Form1.dtgirdViewTD);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            Form1.dtgirdViewTD.AllowUserToAddRows = false;
            Form1.dtgirdViewTD.AllowUserToDeleteRows = false;
            Form1.dtgirdViewTD.AllowUserToResizeColumns = true;
            Form1.dtgirdViewTD.AllowUserToResizeRows = false;
            Form1.dtgirdViewTD.BackgroundColor = System.Drawing.Color.White;
            Form1.dtgirdViewTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            Form1.dtgirdViewTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;//tam
            Form1.dtgirdViewTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Form1.dtgirdViewTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            dataGridViewTextBoxColumn6});
            Form1.dtgirdViewTD.DefaultCellStyle = dataGridViewCellStyle10;
            Form1.dtgirdViewTD.EnableHeadersVisualStyles = false;
            Form1.dtgirdViewTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            Form1.dtgirdViewTD.Location = new System.Drawing.Point(317, 0);
            Form1.dtgirdViewTD.Name = "dtgirdViewTD";
            Form1.dtgirdViewTD.ReadOnly = true;
            Form1.dtgirdViewTD.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            Form1.dtgirdViewTD.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Form1.dtgirdViewTD.RowsDefaultCellStyle = dataGridViewCellStyle8;
            Form1.dtgirdViewTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            Form1.dtgirdViewTD.Size = new System.Drawing.Size(876, 608);
            Form1.dtgirdViewTD.TabIndex = 1;
            ((System.ComponentModel.ISupportInitialize)(Form1.dtgirdViewTD)).EndInit();
        }
        private void AutoSizeRowsMode(Object sender, EventArgs es)
        {
            dtgirdViewTD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFrmThoiGian.Text = String.Format("{0:d/M/yyyy - HH:mm:ss}", DateTime.Now);
            string dt = String.Format("{0:F}", DateTime.Now);
            string[] arrdt = dt.Split(new char[] { ',', ' ' });
            metroTileItem14.Text = " <font size='+30'>" + DateTime.Now.Hour.ToString() + "h</font>" +
            "<font size='15'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp" +
            ";&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "</font>";
            metroTileItem13.Text = "<br/><font size='+15'>" + arrdt[2].ToString() + "</font><font size='+30'>" + arrdt[3].ToString() + "</font>";
        }
        public string valuerdFrm1XemBanIn;
        public void UpdateValueToConfigFile(string nameControl, string valueControl)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load("configfile.xml");
            foreach (XmlElement xElement in XmlDoc.DocumentElement.ChildNodes)
            {
                if (xElement.Attributes[0].Value == nameControl)
                {
                    xElement.Attributes[1].Value = valueControl;
                }
            }
            XmlDoc.Save("configfile.xml");
        }
        public string SelectValueToConfigFile(string nameControl)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load("configfile.xml");
            string kq = "";
            foreach (XmlElement xElement in XmlDoc.DocumentElement.ChildNodes)
            {
                if (xElement.Attributes[0].Value == nameControl)
                {
                    kq = xElement.Attributes[1].Value;
                }
            }
            return kq;
        }
        /// <summary>
        /// Load Cac control duoc thay doi sau khi tat may
        /// </summary>
        public void LoadConTrol()
        {
            if (SelectValueToConfigFile("rdFrm1XemBanIn") == "true")
                rdFrm1XemBanIn.Checked = true;
            else
                rdFrm1XemBanIn.Checked = false;
            pctLoGo.ImageLocation = SelectValueToConfigFile("pctLoGo");
            lbFrm1DiachiNhaHang.Text = SelectValueToConfigFile("lbFrm1DiachiNhaHang");
            lbFrm1SDTNhaHang.Text = SelectValueToConfigFile("lbFrm1SDTNhaHang");
            lbFrm1TenNhaHang.Text = SelectValueToConfigFile("lbFrm1TenNhaHang");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTreeview_ThongKeMon();
            ShowTreeview_Thongke_Ban_KhuVuc();

            //<br/><font size="+30">22h</font><font size="15">18</font>
            ShowTree_LoadTD();
            LoadConTrol();
            this.HOADONRPTableAdapter.Fill(this.QUANLYNHAHANGDataSet.HOADONRP);// ben may tao bi err dong nay nen khong load dc form1 mah ben may may khong bi
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
            LoadKhuVuc(dsKhuVuc);
            LoadNhanVien();
            lvShowBan.Clear();
            LoadBan(lvShowBan, dsKhuVuc, banBUS.LayDSBan());
            LoadThucDon(dsMonAnBus.LayDSMonAn(), lvShowMonAn);
            balloonTip2.SetBalloonCaption(dtgvFrm1ThucDon, "Kéo Món Ăn Vào Danh Sách Thực Đơn Để Hủy Món\n Kéo Vào Bàn Để Chuyển Món Ăn Qua Bàn Đó");
            balloonTip1.SetBalloonCaption(lvShowBan, "Nhấp Đôi Vào Bàn Để Sử Dụng hoăc để hủy bàn");
            balloonTip3.SetBalloonCaption(pctLoGo, "Nhấp Đôi Để Thây Đôi LoGo Cho Nhà Hàng");
            ballon_hoadon.SetBalloonCaption(dgvHoaDonPhucVu, "Nhấp đôi để xem chi tiết");
            ballon_NhanVien.SetBalloonCaption(dgvNhanVien, "Nhấp đôi để sửa thông tin nhân viên");
            //PhanQuyen(Quyen);

            LoadControlDOnGia();
            this.reportViewer1.RefreshReport();
        }


        //load control trong tab Don Giá
        public void LoadControlDOnGia()
        {
            dateTKetThuc.Value = DateTime.Today;
            dateTKetThuc.Text = DateTime.Today.ToString();

        }

        public void PhanQuyen(int quyen)
        {
            TabPhucVu.Visible = false;
            TabThucDon.Visible = false;
            TabHoaDon.Visible = false;
            TabThongKe.Visible = false;
            TabNhanVien.Visible = false;
            if (quyen == 1)
            {
                TabPhucVu.Visible = true;
                TabThucDon.Visible = true;
                TabHoaDon.Visible = true;
                TabThongKe.Visible = true;
                TabNhanVien.Visible = true;
            }
            if (quyen == 2)
            {
                TabPhucVu.Visible = true;
                TabThucDon.Visible = true;
                TabHoaDon.Visible = true;
            }
            if (quyen == 3)
            {
                TabThucDon.Visible = true;
            }


        }

        public void LoadNhanVien()
        {
            DataTable dsNhanVien = NguoiDungBUS.LoadNguoiDung();
            dgvNhanVien.DataSource = dsNhanVien;
        }

        public void LoadKhuVuc(DataTable dsKhuVuc)
        {
            cbxFrm1KhuVuc.DataSource = dsKhuVuc;
        }
        public void LoadBan(ListView objlv, DataTable dsKhuVuc, DataTable dsBan)
        {
            ListViewItem_SetSpacing(objlv, 75, 95);
            foreach (DataRow dtr in dsKhuVuc.Rows)
            {
                ListViewGroup lvg = new ListViewGroup();
                lvg.Header = dtr[1].ToString();
                lvg.Tag = dtr[0];
                objlv.Groups.Add(lvg);
            }
            foreach (DataRow dtr in dsBan.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                int trangThai = int.Parse(dtr[2].ToString());
                lvi.Tag = dtr[0];
                lvi.Text = dtr[1].ToString();
                lvi.ForeColor = Color.Green;
                FontFamily f = new FontFamily("Forte");
                lvi.Font = new Font(f, lvi.Font.Size + 3);
                if (trangThai == 1)
                    lvi.ImageIndex = 1;
                else if (trangThai == 2)
                    lvi.ImageIndex = 2;
                else
                    lvi.ImageIndex = 0;
                int group = int.Parse(dtr[3].ToString()) ;
                foreach (ListViewGroup lviGR in objlv.Groups)
                {
                    if (group == int.Parse(lviGR.Tag.ToString()))
                    {
                        lvi.Group = lviGR;
                    }
                }
                
                //lvi.UseItemStyleForSubItems = true;
                //ListViewItem_SetSpacing(lvShowBan, 46 + 32, 75 + 16);
                objlv.Items.Add(lvi);
            }
        }

        public void LoadThucDon(DataTable dsma, ListView lvShowThucDon)
        {
            string sql = "select * from LOAIMONAN";
            List<OleDbParameter> ListParam = new List<OleDbParameter>();
            DataProvider dt = new DataProvider();
            DataTable dtbBan = dt.ExecuteQuery(sql, ListParam);
            foreach (DataRow dtr in dtbBan.Rows)
            {
                ListViewGroup lvg = new ListViewGroup();
                lvg.Header = dtr[1].ToString();
                lvg.Tag = dtr[0];
                lvShowThucDon.Groups.Add(lvg);
            }
            dtbBan = new DataTable();
            dtbBan = dsma;
            int n = dtbBan.Rows.Count;
            List<int> rexIndex = new List<int>();
            int nIndex = 0;

            foreach (DataRow dtr in dtbBan.Rows)
            {
                try
                {
                    int ma = int.Parse(dtr[0].ToString());
                    ListViewItem lvi = new ListViewItem();
                    //string pathImage = path + "\\imageThucDon\\" + dtr[5].ToString();
                    //imgFrm1Ban.Images.Add(ma.ToString(), Image.FromFile(pathImage));

                    //rexIndex[ma-1] = nIndex;
                    lvi.Tag = ma;
                    lvi.Text = dtr[1].ToString();

                    lvi.ForeColor = Color.Green;
                    FontFamily f = new FontFamily("Forte");
                    lvi.Font = new Font(f, lvi.Font.Size + 3);

                    lvi.ImageKey = ma.ToString();
                    int group = int.Parse(dtr[2].ToString());
                    foreach (ListViewGroup lviGr in lvShowThucDon.Groups)
                    {
                        if(group==int.Parse(lviGr.Tag.ToString())){
                            lvi.Group = lviGr;
                        }
                    }
                    
                    // = lvShowMonAn.Groups.[group];
                    //lvi.UseItemStyleForSubItems = true;
                    //ListViewItem_SetSpacing(lvShowMonAn, 10, 10);
                    lvi.SubItems.Add(dtr[6].ToString());
                    lvi.SubItems.Add(dtr[4].ToString());
                    string tien = mn.FormatString(dtr[3].ToString());
                    lvi.SubItems.Add(tien);
                    lvShowThucDon.Items.Add(lvi);
                    nIndex++;
                }
                catch
                {

                }
            }
        }


        private void metroTileItem15_Click(object sender, EventArgs e)
        {
            expFrm1MenuMeTro.Expanded = false;
            expFrm1MenuMeTro.TitleHeight = 1;
            TabPhucVu.Select();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            expFrm1MenuMeTro.Expanded = false;
        }

        private void metroStatusBar1_MouseHover(object sender, EventArgs e)
        {
            //expandablePanel1.Expanded = true;
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            expFrm1MenuMeTro.Expanded = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            expFrm1MenuMeTro.Expanded = false;
        }

        private void metroTabItem7_Click(object sender, EventArgs e)
        {
            //dgvThongKe_Ban.DataSource = null ;
            //dgvThongKeMonAn.DataSource = null;
            ShowTreeview_Thongke_Ban_KhuVuc();
            ShowTreeview_ThongKeMon();
        }
        //image =0 dat truoc; image =1 trong ; image =2 co khách
        //tinhtrang= 3 dat truoc; tinhtrang= 2 da tinh; tinhtrang=1 chưa tinh
        private void lvShowBan_DoubleClick(object sender, EventArgs e)
        {
            indexItemliv = lvShowBan.SelectedItems[0].Index;
            int index = int.Parse(lvShowBan.SelectedItems[0].Tag.ToString());
            MaBanDangChon = index;
            ImgBanDangChon = lvShowBan.SelectedItems[0].ImageIndex;
            //MessageBox.Show(index.ToString());
            if (lvShowBan.SelectedItems[0].ImageIndex == 2)//ban da co khách
            {
                DialogResult result = MessageBox.Show("Chọn Yes Nếu Bạn Mốn Hủy Bàn Hay Chọn No Chuyển Sang Trạng Thái Đặt Trước", "Thông Bao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ma = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon, 1);
                    lvShowBan.SelectedItems[0].ImageIndex = 1;// bàn trong
                    banBUS.UpdateTrangThaiBan(1, index);
                    TrangThaiBanDangChon = 1;
                    ctPhieuTT_BUS.XoaCTPhieuTinhTien(ma);
                    phieuTT_Bus.XoaPhieuTinhTien(MaBanDangChon, 1);
                    MaBanDangChon = -1;
                    TrangThaiBanDangChon = -1;
                    dtgvFrm1ThucDon.Rows.Clear();
                    reFrestBaoGia();
                    MaBanDangChon = -1;
                    btnActionTachMon.Enabled = false;
                    btnActionGhepBan.Enabled = false;
                    btnActionDoiBan.Enabled = false;
                    btnInTruoc.Enabled = false;
                    btnFrm1TinhTien.Enabled = false;
                }
                else if (result == DialogResult.No)
                {
                    if (phieuTT_Bus.CapNhatTrangThaiPhieuTT(MaBanDangChon, 3) == true)
                    {
                        lvShowBan.SelectedItems[0].ImageIndex = 0; //dat truoc
                        banBUS.UpdateTrangThaiBan(3, index);
                        TrangThaiBanDangChon = 3;
                        ImgBanDangChon = 0;
                    }
                }
            }
            else if (lvShowBan.SelectedItems[0].ImageIndex == 1)// trong
            {
                lvShowBan.SelectedItems[0].ImageIndex = 2;
                banBUS.UpdateTrangThaiBan(2, index);
                TrangThaiBanDangChon = 2;
                ImgBanDangChon = 2;
                PhieuTinhTien phieuTinhTien_DTO = new PhieuTinhTien();
                phieuTinhTien_DTO.Ban = MaBanDangChon;
                phieuTinhTien_DTO.GhiChu = txtFrm1NhapGhiChu.Text;
                //phieuTinhTien_DTO.NhanVien = "admin";//nhanVienDangNhap.TaiKhoan;
                phieuTinhTien_DTO.TongTien = thanhToan;
                phieuTinhTien_DTO.NgayLapPhieu = DateTime.Now;
                phieuTinhTien_DTO.KhachDuaTruoc = 0;
                phieuTinhTien_DTO.GiamGia = giamGia;
                phieuTinhTien_DTO.VAT = vAT;
                phieuTinhTien_DTO.TinhTrang = 1;
                phieuTT_Bus.ThemPhieuTinhTien(phieuTinhTien_DTO);
                //int maPhieuTT = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon, 1);
            }
            else// dat truoc
            {
                lvShowBan.SelectedItems[0].ImageIndex = 2;
                banBUS.UpdateTrangThaiBan(2, index);
                TrangThaiBanDangChon = 2;
                phieuTT_Bus.CapNhatTrangThaiPhieuTT(MaBanDangChon, 1);
            }
            lvShowBan.Clear();
            LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
        }
        /// <summary>
        /// Cho Biet Đã Click vào Item nào
        /// </summary>
        public int indexItemliv;
        private void lvShowBan_Click(object sender, EventArgs e)
        {
            if (flagTachBan == -1)
            {
                indexItemliv = lvShowBan.SelectedItems[0].Index;
                try
                {
                    int index = int.Parse(lvShowBan.SelectedItems[0].Tag.ToString());
                    RefreshDataGridview(dtgvFrm1ThucDon);
                    if (lvShowBan.SelectedItems[0].ImageIndex != 1)
                    {
                        btnActionTachMon.Enabled = true;
                        btnActionGhepBan.Enabled = true;
                        btnActionDoiBan.Enabled = true;
                        btnInTruoc.Enabled = true;
                        btnFrm1TinhTien.Enabled = true;

                        MaBanDangChon = index;
                        ImgBanDangChon = lvShowBan.SelectedItems[0].ImageIndex;
                        if (lvShowBan.SelectedItems[0].ImageIndex == 2)
                        {
                            TrangThaiBanDangChon = 1;
                        }
                        else
                            TrangThaiBanDangChon = 3;
                        DataTable dsMonAn = ctPhieuTT_BUS.LayDSCTPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon), MaBanDangChon);
                        //DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();

                        foreach (DataRow dtr in dsMonAn.Rows)
                        {
                            DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();
                            try
                            {
                                row.Cells[0].Value = int.Parse(dtgvFrm1ThucDon.Rows[dtgvFrm1ThucDon.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                            }
                            catch
                            {
                                row.Cells[0].Value = 1;
                            }
                            row.Cells[1].Value = dtr[0];
                            row.Cells[2].Value = dtr[1];//sl
                            row.Cells[3].Value = dtr[2];
                            row.Cells[4].Value = mn.FormatString(dtr[3].ToString());
                            row.Cells[5].Value = dtr[4];
                            row.Cells[6].Value = mn.FormatString(dtr[5].ToString());
                            row.Cells[7].Value = dtr[6];

                            dtgvFrm1ThucDon.Rows.Add(row);
                        }
                        duyetdtgvThucDon();
                        DataTable maPhieuTT = new DataTable();
                        maPhieuTT = phieuTT_Bus.LayPhieuTinhTien(MaBanDangChon);
                        DataRow dataRow;
                        dataRow = maPhieuTT.NewRow();
                        dataRow = maPhieuTT.Rows[0];
                        txtFrm1GiaGia.Text = dataRow["GiamGia"].ToString();
                        txtFrm1VAT.Text = dataRow["VAT"].ToString();
                        txtFrm1NhapGhiChu.Text = dataRow[6].ToString();
                    }
                    else
                    {
                        btnActionTachMon.Enabled = false;
                        btnActionGhepBan.Enabled = false;
                        btnActionDoiBan.Enabled = false;
                        btnInTruoc.Enabled = false;
                        btnFrm1TinhTien.Enabled = false;
                        MaBanDangChon = -1;
                        TrangThaiBanDangChon = -1;
                        reFrestBaoGia();/////////
                    }

                    string tenBan = lvShowBan.SelectedItems[0].Text.ToString();
                    lbFrm1TenBanAn.Text = tenBan;
                    //BaoGia(1, 1);
                    soRowCoSan = dtgvFrm1ThucDon.RowCount;
                    //CapNhapMonDuocGoi();
                }
                catch
                {
                }
            }
            else
            {
                DialogResult dal = MessageBox.Show("Các Món Bạn Vừa Chọn Sẽ Được chuyển Qua Bàn: " + lvShowBan.SelectedItems[0].Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dal == DialogResult.OK)
                {
                    try
                    {
                        //image =0 dat truoc; image =1 trong ; image =2 co khách
                        //tinhtrang= 3 dat truoc; tinhtrang= 2 da tinh; tinhtrang=1 chưa tinh
                        int ind = lvShowBan.SelectedItems[0].ImageIndex;

                        if (ind == 1)
                        {
                            banBUS.UpdateTrangThaiBan(2, int.Parse(lvShowBan.SelectedItems[0].Tag.ToString()));
                            lvShowBan.SelectedItems[0].ImageIndex = 2;
                            PhieuTinhTien ptt = new PhieuTinhTien();
                            ptt.Ban = int.Parse(lvShowBan.SelectedItems[0].Tag.ToString());

                            ptt.TongTien = 0;
                            ptt.GhiChu = " được chuyển qua từ bàn: " + tenBan;
                            ptt.TinhTrang = 1;
                            phieuTT_Bus.ThemPhieuTinhTien(ptt);

                            //TrangThaiBanDangChon = 2;
                            lvShowBan.Clear();
                            LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
                            //MaBanDangChon = ptt.Ban;
                            double tongMn = 0;
                            double tongt = phieuTT_Bus.LayTongTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon));
                            int old = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                            int new1 = phieuTT_Bus.LayMaPhieuTinhTien(ptt.Ban);
                            foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                            {
                                if (dtr.Cells[dtgvFrm1ThucDon.Columns.Count - 1].Value != null)
                                {
                                    tongMn += double.Parse(dtr.Cells[6].Value.ToString());
                                    int mama = int.Parse(dtr.Cells[7].Value.ToString());
                                    double tt = double.Parse(dtr.Cells[6].Value.ToString());
                                    ctPhieuTT_BUS.updateMaPTTOfCTPTT(old, mama, new1);
                                }
                            }
                            for (int i = dtgvFrm1ThucDon.Rows.Count - 1; i >= 0; i--)
                            {
                                if (dtgvFrm1ThucDon.Rows[i].Cells[8].Value != null)
                                {
                                    dtgvFrm1ThucDon.Rows.RemoveAt(i);
                                }
                            }

                            phieuTT_Bus.CapNhapTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(ptt.Ban), tongMn);

                            phieuTT_Bus.CapNhapTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon), tongt - tongMn);
                            ClicklvShowBan(MaBanDangChon, 2, lbFrm1TenBanAn.Text);
                        }
                        else// nhap vao ban co khách
                        {
                            double tongMn = 0;
                            double tongt = phieuTT_Bus.LayTongTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon));
                            int mabanchon = int.Parse(lvShowBan.SelectedItems[0].Tag.ToString());

                            int old = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                            int new1 = phieuTT_Bus.LayMaPhieuTinhTien(mabanchon);
                            double tongt1 = phieuTT_Bus.LayTongTienPhieuTT(new1);
                            foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                            {
                                if (dtr.Cells[dtgvFrm1ThucDon.Columns.Count - 1].Value != null)
                                {
                                    tongMn += double.Parse(dtr.Cells[6].Value.ToString());
                                    int mama = int.Parse(dtr.Cells[7].Value.ToString());
                                    try
                                    {
                                        int ktsl = ctPhieuTT_BUS.KiemTraMonTonTai(new1, mama);

                                        if (ktsl > 0)
                                        {
                                            ctPhieuTT_BUS.CapNhatSoLuongCT(new1, mama, ktsl);
                                            ctPhieuTT_BUS.XoaCTPhieuTinhTien(old, mama);
                                        }
                                    }
                                    catch
                                    {
                                        ctPhieuTT_BUS.updateMaPTTOfCTPTT(old, mama, new1);
                                    }
                                }
                            }// doi bung qua may oi!
                            for (int i = dtgvFrm1ThucDon.Rows.Count - 1; i >= 0; i--)
                            {
                                if (dtgvFrm1ThucDon.Rows[i].Cells[8].Value != null)
                                {
                                    dtgvFrm1ThucDon.Rows.RemoveAt(i);
                                }
                            }

                            phieuTT_Bus.CapNhapTienPhieuTT(new1, tongt1 + tongMn);

                            phieuTT_Bus.CapNhapTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon), tongt - tongMn);
                            ClicklvShowBan(MaBanDangChon, 2, lbFrm1TenBanAn.Text);
                        }
                        dtgvFrm1ThucDon.Columns[1].Width = dtgvFrm1ThucDon.Columns[1].Width + 30;
                        flagTachBan = -1;
                        btnActionTachMon.Text = "Tách Món";
                        expandablePanel1.Visible = false;
                        dtgvFrm1ThucDon.Columns.RemoveAt(8);
                    }
                    catch
                    {
                    }
                }
                /// 
            }
        }
        /// <summary>
        /// tuong tu nhu su kien click ban
        /// </summary>
        private void ClicklvShowBan(int MaBanCanClick, int imageid, string tenBan)
        {
            int index = MaBanCanClick;
            RefreshDataGridview(dtgvFrm1ThucDon);
            if (imageid != 1)
            {
                if (imageid == 2)
                {
                    TrangThaiBanDangChon = 1;
                }
                else
                    TrangThaiBanDangChon = 3;
                DataTable dsMonAn = ctPhieuTT_BUS.LayDSCTPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanCanClick), MaBanCanClick);
                //DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();

                foreach (DataRow dtr in dsMonAn.Rows)
                {
                    DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();
                    try
                    {
                        row.Cells[0].Value = int.Parse(dtgvFrm1ThucDon.Rows[dtgvFrm1ThucDon.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                    }
                    catch
                    {
                        row.Cells[0].Value = 1;
                    }
                    row.Cells[1].Value = dtr[0];
                    row.Cells[2].Value = dtr[1];//sl
                    row.Cells[3].Value = dtr[2];
                    row.Cells[4].Value = mn.FormatString(dtr[3].ToString());
                    row.Cells[5].Value = dtr[4];
                    row.Cells[6].Value = mn.FormatString(dtr[5].ToString());
                    row.Cells[7].Value = dtr[6];

                    dtgvFrm1ThucDon.Rows.Add(row);
                }
                duyetdtgvThucDon();
                DataTable maPhieuTT = new DataTable();
                maPhieuTT = phieuTT_Bus.LayPhieuTinhTien(MaBanCanClick);
                DataRow dataRow;
                dataRow = maPhieuTT.NewRow();
                dataRow = maPhieuTT.Rows[0];
                txtFrm1GiaGia.Text = dataRow[7].ToString();
                txtFrm1VAT.Text = dataRow[8].ToString();
            }
            else
            {
                MaBanDangChon = -1;
                TrangThaiBanDangChon = -1;
                reFrestBaoGia();
            }
            lbFrm1TenBanAn.Text = tenBan;
            //BaoGia(1, 1);
            soRowCoSan = dtgvFrm1ThucDon.RowCount;
            //CapNhapMonDuocGoi();
        }
        /// <summary>
        /// những món đã được gọi của bàn đang chón sẽ chuyển màu đỏ
        /// duyet tung dong datagridview lvshowthucdon de tinh lại cái thong số tiền giam gia vat và cap nhat các label hien thị
        /// </summary>
        private void duyetdtgvThucDon()
        {
            double tt = 0;
            double ttgg = 0;
            foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
            {
                try
                {
                    tt += double.Parse(dtr.Cells[6].Value.ToString());
                    //ttgg+=
                }
                catch { }
            }
            tongTien = tt;
            int gg = int.Parse(txtFrm1GiaGia.Text);
            int vat = int.Parse(txtFrm1VAT.Text);
            BaoGia(gg, vat);
        }
        /// <summary>
        /// Kiểm tra xem món ăn đã chọn có được order chưa
        /// </summary>
        /// <param name="maMonAn">nhận vào tham số là mã món ăn cần kiểm tra</param>
        /// <returns>trùng nhau thì trả về false. return true ngược lại</returns>
        private bool KiemTraTrungDsMonAn(int maMonAn)
        {
            foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
            {
                try
                {
                    int ma = int.Parse(dtr.Cells[7].Value.ToString());
                    if (ma == maMonAn)
                        return false;
                }
                catch
                {
                }
            }
            return true;
        }
        private void lvShowMonAn_DoubleClick(object sender, EventArgs e)
        {
            if (MaBanDangChon != -1)
            {

                int index = int.Parse(lvShowMonAn.SelectedItems[0].Tag.ToString());
                string tenMonAn = lvShowMonAn.SelectedItems[0].Text;//sl dongia giam gia
                //int sL=int.Parse(lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString());
                double donGia = double.Parse(lvShowMonAn.SelectedItems[0].SubItems[3].Text.ToString());
                int giamGia;
                try
                {
                    giamGia = int.Parse(lvShowMonAn.SelectedItems[0].SubItems[2].Text.ToString());
                }
                catch { giamGia = 0; }
                string dVT = lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString();
                DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();
                try
                {
                    row.Cells[0].Value = int.Parse(dtgvFrm1ThucDon.Rows[dtgvFrm1ThucDon.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                }
                catch
                {
                    row.Cells[0].Value = 1;
                }
                int maPTT = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                if (KiemTraTrungDsMonAn(index))
                {
                    row.Cells[1].Value = tenMonAn;
                    row.Cells[2].Value = 1;//sl
                    row.Cells[3].Value = dVT;
                    row.Cells[4].Value = mn.FormatString(donGia.ToString());
                    row.Cells[5].Value = giamGia;
                    row.Cells[6].Value = mn.FormatString((donGia - (donGia * giamGia) / 100).ToString());
                    row.Cells[7].Value = index;
                    dtgvFrm1ThucDon.Rows.Add(row);
                    duyetdtgvThucDon();
                    
                    ChiTietPhieuTT ctPhieuTT_DTO = new ChiTietPhieuTT();
                    ctPhieuTT_DTO.MaPhieuTT = maPTT;
                    ctPhieuTT_DTO.MonAn = index;
                    ctPhieuTT_DTO.SoLuong = 1;
                    ctPhieuTT_DTO.GiamGia = giamGia;
                    ctPhieuTT_DTO.DonGia = donGia;
                    ctPhieuTT_DTO.ThanhTien = donGia - (donGia * giamGia) / 100;
                    ctPhieuTT_BUS.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
                }
                else
                {
                    foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                    {
                        try
                        {
                            int ma = int.Parse(dtr.Cells[7].Value.ToString());
                            if (ma == index)
                            {
                                int slnew = int.Parse(dtr.Cells[2].Value.ToString()) + 1;
                                dtr.Cells[2].Value = slnew;
                                double thanhtienma = (donGia * slnew) - ((donGia * slnew * giamGia) / 100);
                                ctPhieuTT_BUS.CapNhatCTPhieuTT(maPTT, ma, slnew, int.Parse(dtr.Cells[5].Value.ToString()), thanhtienma);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                double tongmn = 0.0;
                double tongGG = 0.0;
                foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                {
                    try
                    {
                        tongmn += double.Parse(dtr.Cells[6].Value.ToString());
                        tongGG += double.Parse(dtr.Cells[5].Value.ToString());
                    }
                    catch { }
                }
                phieuTT_Bus.CapNhapTienPhieuTT(maPTT, tongmn, tongGG);
                ClicklvShowBan(MaBanDangChon, ImgBanDangChon, lbFrm1TenBanAn.Text);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn, Nhấp Đôi Chuột Vào Bàn Cần Order");
            }
        }
        double tongTien = 0;
        double thanhToan = 0;
        /// <summary>
        /// thue gia tri gia tang 
        /// </summary>
        double vAT = 0;
        /// <summary>
        /// Bien toan cuc giảm giá tổng trên hóa đơn
        /// </summary>
        double giamGia = 0;
        int giamGiaPT = 0;
        int giamGiavat = 0;
        double khachTra = 0;
        double thoiLai = 0;


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public int MakeLong(short lowPart, short highPart)
        {
            return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        }
        public void ListViewItem_SetSpacing(ListView listview, short leftPadding, short topPadding)
        {
            const int LVM_FIRST = 0x1000;
            const int LVM_SETICONSPACING = LVM_FIRST + 53;
            SendMessage(listview.Handle, LVM_SETICONSPACING, IntPtr.Zero, (IntPtr)MakeLong(leftPadding, topPadding));
        }
        private void dtgvFrm1ThucDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int gg = int.Parse(txtFrm1GiaGia.Text);
            int vat = int.Parse(txtFrm1VAT.Text);

            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 5)
            {
                try
                {
                    int sL = int.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                    double donGia = double.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[4].Value.ToString());
                    int giamGia = int.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[5].Value.ToString());
                    double thanhtienCVC = (donGia * sL) - ((donGia * sL * giamGia) / 100);
                    dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[6].Value = thanhtienCVC;
                    tongTien = 0;
                    foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                    {
                        try
                        {
                            tongTien += double.Parse(dtr.Cells[6].Value.ToString());
                        }
                        catch
                        {
                        }
                    }

                    /// update lai phieu tinh tien
                    DataTable maPhieuTT = new DataTable();
                    maPhieuTT = phieuTT_Bus.LayPhieuTinhTien(MaBanDangChon);
                    DataRow dataRow;
                    dataRow = maPhieuTT.NewRow();
                    dataRow = maPhieuTT.Rows[0];
                    int maMonAn = int.Parse(dtgvFrm1ThucDon.Rows[e.RowIndex].Cells[7].Value.ToString());
                    ctPhieuTT_BUS.CapNhatCTPhieuTT(int.Parse(dataRow[0].ToString()), maMonAn, sL, giamGia, thanhtienCVC);
                    PhieuTinhTien chiTietUpdate = new PhieuTinhTien();
                    chiTietUpdate.MaPhieuTT = int.Parse(dataRow[0].ToString());
                    chiTietUpdate.Ban = int.Parse(dataRow[1].ToString());
                    chiTietUpdate.NhanVien = dataRow[2].ToString();
                    chiTietUpdate.TongTien = tongTien;//double.Parse(dataRow[3].ToString());

                    chiTietUpdate.NgayLapPhieu = DateTime.Parse(dataRow[4].ToString());
                    chiTietUpdate.KhachDuaTruoc = double.Parse(dataRow[5].ToString());
                    chiTietUpdate.GhiChu = dataRow[6].ToString();
                    chiTietUpdate.GiamGia = giamGia;//int.Parse(dataRow[7].ToString());

                    chiTietUpdate.VAT = vat;//int.Parse(dataRow[8].ToString());
                    chiTietUpdate.TinhTrang = int.Parse(dataRow[9].ToString());
                    chiTietUpdate.Giovao = DateTime.Parse(dataRow[10].ToString());
                    chiTietUpdate.Giora = DateTime.Parse(dataRow[11].ToString());

                    phieuTT_Bus.UpDatePhieuTT(chiTietUpdate);
                }
                catch
                {
                }
            }

            BaoGia(gg, vat);

        }
        /// <summary>
        /// cap nhat các giá tri khi giam gia hoac don giá thay đổi
        /// </summary>
        /// <param name="giamgiaphantram"></param>
        /// <param name="vat"></param>
        private void BaoGia(int giamgiaphantram, int vat)
        {
            giamGia = tongTien * giamgiaphantram / 100;
            //vAT = tongTien - (tongTien-( tongTien * vat / 100));
            vAT = (tongTien - giamGia) * vat / 100;
            thanhToan = tongTien - (giamGia + vAT);

            lbFrm1GiamGia.Text = mn.FormatString(giamGia.ToString());
            lbFrm1VAT.Text = mn.FormatString(vAT.ToString());
            thoiLai = khachTra - thanhToan;
            lbFrm1ThoiLai.Text = mn.FormatString(thoiLai.ToString());
            lbFrm1TongTien.Text = mn.FormatString(tongTien.ToString());
            lbFrm1ThanhToan.Text = mn.FormatString(thanhToan.ToString());
            lbFrm1TienBangChu.Text = "* " + mn.So_chu(thanhToan.ToString());
            lbFrm1TienBangChu.ForeColor = Color.Green;
        }
        private void reFrestBaoGia()
        {
            giamGia = 0;
            vAT = 0;
            thanhToan = 0;
            tongTien = 0;
            lbFrm1GiamGia.Text = giamGia.ToString();
            lbFrm1VAT.Text = vAT.ToString();
            thoiLai = 0;
            lbFrm1ThoiLai.Text = thoiLai.ToString();
            lbFrm1TongTien.Text = tongTien.ToString();
            lbFrm1ThanhToan.Text = thanhToan.ToString();
            txtFrm1VAT.Text = "0";
            txtFrm1GiaGia.Text = "0";
            lbFrm1TienBangChu.Text = "* " + mn.So_chu(thanhToan.ToString());
            lbFrm1TienBangChu.ForeColor = Color.Red;
        }

        private void txtFrm1GiaGia_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (MaBanDangChon != -1)
                {
                    giamGiaPT = int.Parse(txtFrm1GiaGia.Text);
                    int vat = int.Parse(txtFrm1VAT.Text);
                    BaoGia(giamGiaPT, vat);
                    /// update lai phieu tinh tien
                    DataTable maPhieuTT = new DataTable();
                    maPhieuTT = phieuTT_Bus.LayPhieuTinhTien(MaBanDangChon);
                    DataRow dataRow;
                    dataRow = maPhieuTT.NewRow();
                    dataRow = maPhieuTT.Rows[0];
                    PhieuTinhTien chiTietUpdate = new PhieuTinhTien();
                    chiTietUpdate.MaPhieuTT = int.Parse(dataRow[0].ToString());
                    chiTietUpdate.Ban = int.Parse(dataRow[1].ToString());
                    chiTietUpdate.NhanVien = dataRow[2].ToString();
                    chiTietUpdate.TongTien = thanhToan;//double.Parse(dataRow[3].ToString());

                    chiTietUpdate.NgayLapPhieu = DateTime.Parse(dataRow[4].ToString());
                    chiTietUpdate.KhachDuaTruoc = double.Parse(dataRow[5].ToString());
                    chiTietUpdate.GhiChu = dataRow[6].ToString();
                    chiTietUpdate.GiamGia = giamGiaPT;//int.Parse(dataRow[7].ToString());

                    chiTietUpdate.VAT = vat;//int.Parse(dataRow[8].ToString());
                    chiTietUpdate.TinhTrang = int.Parse(dataRow[9].ToString());
                    chiTietUpdate.Giovao = DateTime.Parse(dataRow[10].ToString());
                    chiTietUpdate.Giora = DateTime.Parse(dataRow[11].ToString());

                    phieuTT_Bus.UpDatePhieuTT(chiTietUpdate);

                }
            }
            catch
            {
                txtFrm1GiaGia.Text = "";
            }


        }

        private void txtFrm1VAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MaBanDangChon != -1)
                {
                    giamGiavat = int.Parse(txtFrm1VAT.Text);
                    int gg = int.Parse(txtFrm1GiaGia.Text);
                    BaoGia(gg, giamGiavat);

                    /// update lai phieu tinh tien
                    DataTable maPhieuTT = new DataTable();
                    maPhieuTT = phieuTT_Bus.LayPhieuTinhTien(MaBanDangChon);
                    DataRow dataRow;
                    dataRow = maPhieuTT.NewRow();
                    dataRow = maPhieuTT.Rows[0];
                    PhieuTinhTien chiTietUpdate = new PhieuTinhTien();
                    chiTietUpdate.MaPhieuTT = int.Parse(dataRow[0].ToString());
                    chiTietUpdate.Ban = int.Parse(dataRow[1].ToString());
                    chiTietUpdate.NhanVien = dataRow[2].ToString();
                    chiTietUpdate.TongTien = thanhToan;//double.Parse(dataRow[3].ToString());

                    chiTietUpdate.NgayLapPhieu = DateTime.Parse(dataRow[4].ToString());
                    chiTietUpdate.KhachDuaTruoc = double.Parse(dataRow[5].ToString());
                    chiTietUpdate.GhiChu = dataRow[6].ToString();
                    chiTietUpdate.GiamGia = gg;//int.Parse(dataRow[7].ToString());

                    chiTietUpdate.VAT = giamGiavat;//int.Parse(dataRow[8].ToString());
                    chiTietUpdate.TinhTrang = int.Parse(dataRow[9].ToString());
                    chiTietUpdate.Giovao = DateTime.Parse(dataRow[10].ToString());
                    chiTietUpdate.Giora = DateTime.Parse(dataRow[11].ToString());

                    phieuTT_Bus.UpDatePhieuTT(chiTietUpdate);
                }
            }
            catch
            {
                txtFrm1VAT.Text = "";
            }
        }



        private void cbxFrm1KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhuVuc = cbxFrm1KhuVuc.SelectedIndex;
            //banBUS.LayDSBan(maKhuVuc);
            lvShowBan.Clear();
            LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan(maKhuVuc + 1));
        }

        private void btnFrm1LoadBanAll_Click(object sender, EventArgs e)
        {
            lvShowBan.Clear();
            LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
        }

        private void txtFrm1TimBan_TextChanged(object sender, EventArgs e)
        {
            lvShowBan.Clear();
            DataTable dtBan = banBUS.LayDSBan(txtFrm1TimBan.Text);
            LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), dtBan);
        }

        private void txtFrm1NhapGhiChu_Click(object sender, EventArgs e)
        {
            if (txtFrm1NhapGhiChu.Text == "Nhập Ghi Chú Của Bàn.......")
                txtFrm1NhapGhiChu.Text = "";

        }

        private void txtFrm1NhapGhiChu_Validated(object sender, EventArgs e)
        {
            if (txtFrm1NhapGhiChu.Text.Length < 1)
                txtFrm1NhapGhiChu.Text = "Nhập Ghi Chú Của Bàn.......";
        }

        private void dtgvFrm1ThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rowaddedTre == true)
            {

                int column = e.ColumnIndex;
                int rao = e.RowIndex;
                if ((rao < soRowCoSan - 1) && (column != 2 && column != 5 && column != 8))
                {
                    //MessageBox.Show("Bạn Không Được Sữa Giá Trị Này Của Món Ăn");
                    try
                    {
                        dtgvFrm1ThucDon.Rows[rao].Cells[column].ReadOnly = true;
                    }
                    catch (Exception)
                    {
                    }
                    
                }
                else
                {
                    try
                    {
                        int sttnew = int.Parse(dtgvFrm1ThucDon.Rows[rao - 1].Cells[0].Value.ToString()) + 1;
                        dtgvFrm1ThucDon.Rows[rao].Cells[0].Value = sttnew;
                    }
                    catch
                    {
                        try
                        {
                            dtgvFrm1ThucDon.Rows[rao].Cells[0].Value = 1;
                        }
                        catch (Exception)
                        {
                        }
                        
                    }
                }
            }
        }
        private void RefreshDataGridview(DataGridView dtgv)
        {
            for (int i = 0; i < dtgv.Rows.Count; i++)
            {
                try
                {
                    dtgv.Rows.RemoveAt(i);
                    i--;
                }
                catch { break; }
            }
        }
        private void btnFrm1TaoBanDatTruoc_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// xem co chay su kien dtgvFrm1ThucDon_RowsAdded không?
        /// </summary>
        private bool rowaddedTre = false;
        private void lvShowBan_Validated(object sender, EventArgs e)
        {
            rowaddedTre = true;
        }


        /// <summary>
        /// cho biet so row dc tao ra khi nhap vao ban
        /// </summary>
        private int soRowCoSan;
        private void dtgvFrm1ThucDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dtgvFrm1ThucDon_DragOver(object sender, DragEventArgs e)
        {
            //if(e.Data.GetDataPresent(GetType(System.Windows.Forms.ListBox.SelectedObjectCollection)))
            //{

            //}

            e.Effect = DragDropEffects.Move;

            if (e.Y <= PointToScreen(new Point(dtgvFrm1ThucDon.Location.X,
               dtgvFrm1ThucDon.Location.Y)).Y + 40)
                dtgvFrm1ThucDon.FirstDisplayedScrollingRowIndex -= 1;
            if (e.Y >= PointToScreen(new Point(dtgvFrm1ThucDon.Location.X +
               dtgvFrm1ThucDon.Width, dtgvFrm1ThucDon.Location.Y +
               dtgvFrm1ThucDon.Height)).Y - 10)
                dtgvFrm1ThucDon.FirstDisplayedScrollingRowIndex += 1;
        }
        /// <summary>
        /// /////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvFrm1ThucDon_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lvShowBan_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        //image =0 dat truoc; image =1 trong ; image =2 co khách
        //tinhtrang= 3 dat truoc; tinhtrang= 2 da tinh; tinhtrang=1 chưa tinh
        private void lvShowBan_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                DataGridViewRow row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                try
                {

                    int ma = int.Parse(row.Cells[7].Value.ToString());
                    int maphieu = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);

                    Point p = lvShowBan.PointToClient(new Point(e.X, e.Y));
                    ListViewItem lvi = lvShowBan.GetItemAt(p.X, p.Y);
                    int ind = lvi.ImageIndex;
                    if (ind == 1)
                    {
                        banBUS.UpdateTrangThaiBan(2, int.Parse(lvi.Tag.ToString()));
                        lvi.ImageIndex = 2;
                        PhieuTinhTien ptt = new PhieuTinhTien();
                        ptt.Ban = int.Parse(lvi.Tag.ToString());
                        ptt.TongTien = double.Parse(row.Cells[6].Value.ToString());
                        ptt.GhiChu = "Món " + row.Cells[1].Value.ToString() + " được chuyển qua từ bàn " + lvi.Text + ",";
                        ptt.TinhTrang = 1;
                        phieuTT_Bus.ThemPhieuTinhTien(ptt);

                        TrangThaiBanDangChon = 2;
                        lvShowBan.Clear();
                        LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
                        MaBanDangChon = ptt.Ban;
                        ImgBanDangChon = 2;
                    }
                    ctPhieuTT_BUS.XoaCTPhieuTinhTien(maphieu, ma, phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString())));
                    lvi.ImageIndex = ind;
                    dtgvFrm1ThucDon.Rows.Remove(row);
                    ClicklvShowBan(int.Parse(lvi.Tag.ToString()), lvi.ImageIndex, lvi.Text);
                }
                catch
                {
                }
            }
            else
            {
                //image =0 dat truoc; image =1 trong ; image =2 co khách
                //tinhtrang= 3 dat truoc; tinhtrang= 2 da tinh; tinhtrang=1 chưa tinh
                ListViewItem row = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;

                Point p = lvShowBan.PointToClient(new Point(e.X, e.Y));
                ListViewItem lvi = lvShowBan.GetItemAt(p.X, p.Y);
                try
                {
                    double donGia = double.Parse(row.SubItems[3].Text.ToString());
                    string strresultf = "Bạn Muốn Thêm Món Ăn: " + row.Text + " Vào Bàn " + lvi.Text +
                                            " Phải Không ?\nOK : Thêm Vào Bàn " + lvi.Text;
                    DialogResult dlr = MessageBox.Show(strresultf, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlr == DialogResult.OK)
                    {
                        /////////////////
                        if (lvi.ImageIndex != 1)
                        {

                            int index1 = int.Parse(row.Tag.ToString());
                            string tenMonAn1 = row.Text;//sl dongia giam gia
                            //int sL=int.Parse(lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString());
                            double donGia1 = double.Parse(row.SubItems[3].Text.ToString());
                            int giamGia1 = int.Parse(row.SubItems[2].Text.ToString());
                            string dVT1 = row.SubItems[1].Text.ToString();
                            RefreshDataGridview(dtgvFrm1ThucDon);
                            ClicklvShowBan(int.Parse(lvi.Tag.ToString()), lvi.ImageIndex, lvi.Text);
                            DataGridViewRow row1 = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();
                            try
                            {
                                row1.Cells[0].Value = int.Parse(dtgvFrm1ThucDon.Rows[dtgvFrm1ThucDon.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                            }
                            catch
                            {
                                row1.Cells[0].Value = 1;
                            }
                            int maPTT = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));
                            if (KiemTraTrungDsMonAn(index1))
                            {
                                row1.Cells[1].Value = tenMonAn1;
                                row1.Cells[2].Value = 1;//sl
                                row1.Cells[3].Value = dVT1;
                                row1.Cells[4].Value = mn.FormatString(donGia1.ToString());
                                row1.Cells[5].Value = giamGia1;
                                row1.Cells[6].Value = mn.FormatString((donGia1 - (donGia1 * giamGia1) / 100).ToString());
                                row1.Cells[7].Value = index1;
                                dtgvFrm1ThucDon.Rows.Add(row1);
                                duyetdtgvThucDon();


                                ChiTietPhieuTT ctPhieuTT_DTO = new ChiTietPhieuTT();
                                ctPhieuTT_DTO.MaPhieuTT = maPTT;
                                ctPhieuTT_DTO.MonAn = index1;
                                ctPhieuTT_DTO.SoLuong = 1;
                                ctPhieuTT_DTO.GiamGia = giamGia1;
                                ctPhieuTT_DTO.DonGia = donGia1;
                                ctPhieuTT_DTO.ThanhTien = donGia1 - (donGia1 * giamGia1) / 100;
                                ctPhieuTT_BUS.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
                                double tienCapNhat = phieuTT_Bus.LayTongTienPhieuTT(maPTT);
                                phieuTT_Bus.CapNhapTienPhieuTT(maPTT, tienCapNhat);
                            }
                            else
                            {
                                foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                                {
                                    try
                                    {
                                        int ma = int.Parse(dtr.Cells[7].Value.ToString());
                                        if (ma == index1)
                                        {
                                            int slnew = int.Parse(dtr.Cells[2].Value.ToString()) + 1;
                                            dtr.Cells[2].Value = slnew;
                                            double thanhtienma = (donGia * slnew) - ((donGia * slnew * giamGia1) / 100);
                                            ctPhieuTT_BUS.CapNhatCTPhieuTT(maPTT, ma, slnew, int.Parse(dtr.Cells[5].Value.ToString()), thanhtienma);
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Bạn Chưa Chọn Bàn, Nhấp Đôi Chuột Vào Bàn Cần Order");
                            int ind = lvi.Index;
                            lvShowBan.Items[ind].ImageIndex = 2;
                            banBUS.UpdateTrangThaiBan(2, int.Parse(lvi.Tag.ToString()));
                            TrangThaiBanDangChon = 2;

                            PhieuTinhTien phieuTinhTien_DTO = new PhieuTinhTien();
                            phieuTinhTien_DTO.Ban = int.Parse(lvi.Tag.ToString());
                            phieuTinhTien_DTO.GhiChu = txtFrm1NhapGhiChu.Text;
                            phieuTinhTien_DTO.NhanVien = nhanVienDangNhap.TaiKhoan;
                            phieuTinhTien_DTO.TongTien = thanhToan;
                            phieuTinhTien_DTO.NgayLapPhieu = DateTime.Now;
                            phieuTinhTien_DTO.KhachDuaTruoc = 0;
                            phieuTinhTien_DTO.GiamGia = giamGia;
                            phieuTinhTien_DTO.VAT = vAT;
                            phieuTinhTien_DTO.TinhTrang = 1;
                            phieuTT_Bus.ThemPhieuTinhTien(phieuTinhTien_DTO);

                            int index1 = int.Parse(row.Tag.ToString());
                            string tenMonAn1 = row.Text;//sl dongia giam gia
                            //int sL=int.Parse(lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString());
                            double donGia1 = double.Parse(row.SubItems[3].Text.ToString());
                            int giamGia1 = int.Parse(row.SubItems[2].Text.ToString());
                            string dVT1 = row.SubItems[1].Text.ToString();
                            RefreshDataGridview(dtgvFrm1ThucDon);

                            int maPTT = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));
                            ChiTietPhieuTT ctPhieuTT_DTO = new ChiTietPhieuTT();
                            ctPhieuTT_DTO.MaPhieuTT = maPTT;
                            ctPhieuTT_DTO.MonAn = index1;
                            ctPhieuTT_DTO.SoLuong = 1;
                            ctPhieuTT_DTO.GiamGia = giamGia1;
                            ctPhieuTT_DTO.DonGia = donGia1;
                            ctPhieuTT_DTO.ThanhTien = donGia1 - (donGia1 * giamGia1) / 100;
                            ctPhieuTT_BUS.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
                            phieuTT_Bus.CapNhapTienPhieuTT(maPTT, ctPhieuTT_DTO.ThanhTien);
                            ClicklvShowBan(int.Parse(lvi.Tag.ToString()), 2, lvi.Text);

                        }
                        ////////////////
                    }
                }
                catch
                {
                    try
                    {
                        if ((row.Tag != lvi.Tag))
                        {
                            if (row.ImageIndex != 1 && lvi.ImageIndex != 1)
                            {
                                string strresultf = "Bạn Muốn Ghép Hai Bàn " + row.Text + " Và " + lvi.Text +
                                                " Phải Không ?\nYes : Ghép Thành Bàn " + lvi.Text +
                                                "\nNo : Thực Hiện Hoán Đổi Hai Bàn";

                                DialogResult dlr = MessageBox.Show(strresultf, "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (dlr == DialogResult.Yes)
                                {
                                    int newmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));
                                    int oldmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(row.Tag.ToString()));
                                    ctPhieuTT_BUS.GhepBan(oldmaPhieu, newmaPhieu);
                                    double tongTien = phieuTT_Bus.LayTongTienPhieuTT(newmaPhieu);
                                    phieuTT_Bus.CapNhapTienPhieuTT(newmaPhieu, tongTien);
                                    banBUS.UpdateTrangThaiBan(1, int.Parse(row.Tag.ToString()));
                                    foreach (ListViewItem listview in lvShowBan.Items)
                                    {
                                        if (listview.Tag.ToString() == row.Tag.ToString())
                                        {
                                            listview.ImageIndex = 1;
                                            break;
                                        }
                                    }
                                    phieuTT_Bus.XoaPhieuTinhTien(oldmaPhieu);
                                    RefreshDataGridview(dtgvFrm1ThucDon);
                                    reFrestBaoGia();
                                }
                                else if (dlr == DialogResult.No)
                                {
                                    int newBan = int.Parse(lvi.Tag.ToString());
                                    int newmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(newBan);
                                    int oldBan = int.Parse(row.Tag.ToString());
                                    int oldmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(oldBan);
                                    phieuTT_Bus.CapNhatBanChoPhieuTT(newmaPhieu, oldBan);
                                    phieuTT_Bus.CapNhatBanChoPhieuTT(oldmaPhieu, newBan);
                                }
                                ClicklvShowBan(int.Parse(lvi.Tag.ToString()), lvi.ImageIndex, lvi.Text);
                            }
                            else// 1 trong 2 co khách
                            {

                                string strresultf = "Bạn Muốn Đổi Hai Bàn " + row.Text + " Và " + lvi.Text +
                                                " Phải Không ?";

                                DialogResult dlr = MessageBox.Show(strresultf, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (dlr == DialogResult.OK)
                                {// 1 trong 2 co khach
                                    if (lvi.ImageIndex == 1 && row.ImageIndex != 1)
                                    {
                                        int trangThai = 3;
                                        int Maphieudoi;
                                        if (row.ImageIndex == 2)
                                        {
                                            trangThai = 2;
                                            Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(row.Tag.ToString()));
                                        }
                                        else
                                            Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(row.Tag.ToString()));

                                        phieuTT_Bus.CapNhatBanChoPhieuTT(Maphieudoi, int.Parse(lvi.Tag.ToString()));
                                        banBUS.UpdateTrangThaiBan(1, int.Parse(row.Tag.ToString()));
                                        banBUS.UpdateTrangThaiBan(trangThai, int.Parse(lvi.Tag.ToString()));
                                        lvShowBan.Clear();
                                        LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());

                                        ClicklvShowBan(int.Parse(lvi.Tag.ToString()), 2, lvi.Text);
                                    }
                                    else if (lvi.ImageIndex != 1 && row.ImageIndex == 1)
                                    {

                                        int trangThai = 3;
                                        int Maphieudoi;
                                        if (lvi.ImageIndex == 2)
                                        {
                                            trangThai = 2;
                                            Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));
                                        }
                                        else
                                            Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));

                                        phieuTT_Bus.CapNhatBanChoPhieuTT(Maphieudoi, int.Parse(row.Tag.ToString()));
                                        banBUS.UpdateTrangThaiBan(1, int.Parse(lvi.Tag.ToString()));
                                        banBUS.UpdateTrangThaiBan(trangThai, int.Parse(row.Tag.ToString()));
                                        lvShowBan.Clear();
                                        LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
                                        ClicklvShowBan(int.Parse(row.Tag.ToString()), 2, row.Text);
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                    //else if(row.ImageIndex==1 ||lvi.ImageIndex==1)
                }
            }
        }

        private void lvShowMonAn_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewRow row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;

            try
            {
                int ma = int.Parse(row.Cells[7].Value.ToString());
                int maphieu = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                ctPhieuTT_BUS.XoaCTPhieuTinhTien(maphieu, ma);
                dtgvFrm1ThucDon.Rows.Remove(row);
                //ClicklvShowBan(MaBanDangChon, );
            }
            catch
            {
            }
        }

        private void lvShowMonAn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void lvShowBan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = lvShowBan.PointToScreen(e.Location);
                contextMenuStrip1.Show(pt);
            }
        }

        private void lvShowMonAn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvShowMonAn.SelectedItems.Count > 0)
                {
                    lvShowMonAn.DoDragDrop(lvShowMonAn.SelectedItems[0], DragDropEffects.Move);
                }
            }
        }

        private void dtgvFrm1ThucDon_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dtgvFrm1ThucDon_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem row1 = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;

            if (MaBanDangChon != -1)
            {
                int index;
                try
                {
                    index = int.Parse(row1.Tag.ToString());
                }
                catch
                {
                    return;
                }
                string tenMonAn = row1.Text; //sl dongia giam gia
                //int sL=int.Parse(lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString());
                double donGia;
                try
                {
                    donGia = double.Parse(row1.SubItems[3].Text.ToString());
                }
                catch
                {
                    return;
                }
                int giamGia = int.Parse(row1.SubItems[2].Text.ToString());
                string dVT = lvShowMonAn.SelectedItems[0].SubItems[1].Text.ToString();
                DataGridViewRow row = (DataGridViewRow)dtgvFrm1ThucDon.Rows[0].Clone();
                try
                {
                    row.Cells[0].Value = int.Parse(dtgvFrm1ThucDon.Rows[dtgvFrm1ThucDon.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                }
                catch
                {
                    row.Cells[0].Value = 1;
                }
                int maPTT = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                if (KiemTraTrungDsMonAn(index))
                {
                    row.Cells[1].Value = tenMonAn;
                    row.Cells[2].Value = 1;//sl
                    row.Cells[3].Value = dVT;
                    row.Cells[4].Value = mn.FormatString(donGia.ToString());
                    row.Cells[5].Value = giamGia;
                    row.Cells[6].Value = mn.FormatString((donGia - (donGia * giamGia) / 100).ToString());
                    row.Cells[7].Value = index;
                    dtgvFrm1ThucDon.Rows.Add(row);
                    duyetdtgvThucDon();


                    ChiTietPhieuTT ctPhieuTT_DTO = new ChiTietPhieuTT();
                    ctPhieuTT_DTO.MaPhieuTT = maPTT;
                    ctPhieuTT_DTO.MonAn = index;
                    ctPhieuTT_DTO.SoLuong = 1;
                    ctPhieuTT_DTO.GiamGia = giamGia;
                    ctPhieuTT_DTO.DonGia = donGia;
                    ctPhieuTT_DTO.ThanhTien = donGia - (donGia * giamGia) / 100;
                    ctPhieuTT_BUS.ThemCTPhieuTinhTien(ctPhieuTT_DTO);
                }
                else
                {
                    foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                    {
                        try
                        {
                            int ma = int.Parse(dtr.Cells[7].Value.ToString());
                            if (ma == index)
                            {
                                int slnew = int.Parse(dtr.Cells[2].Value.ToString()) + 1;
                                dtr.Cells[2].Value = slnew;
                                double thanhtienma = (donGia * slnew) - ((donGia * slnew * giamGia) / 100);
                                ctPhieuTT_BUS.CapNhatCTPhieuTT(maPTT, ma, slnew, int.Parse(dtr.Cells[5].Value.ToString()), thanhtienma);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                double tongmn = 0.0;
                foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                {
                    try
                    {
                        tongmn += double.Parse(dtr.Cells[6].Value.ToString());
                    }
                    catch { }
                }
                phieuTT_Bus.CapNhapTienPhieuTT(maPTT, tongmn);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn, Nhấp Đôi Chuột Vào Bàn Cần Order");
            }
        }
        private Cursor customCursor = null;
        private void lvShowMonAn_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

            try
            {
                string a = path + "\\imageThucDon\\" + feedback;

                Image image = Image.FromFile(a);
                Bitmap bitmap = new Bitmap(image);
                Graphics graphics = Graphics.FromImage(bitmap);
                IntPtr handle = bitmap.GetHicon();
                Cursor myCursor = new Cursor(handle);

                if (e.Effect == DragDropEffects.Move)
                {
                    if (customCursor == null)
                        Cursor.Current = myCursor;
                    e.UseDefaultCursors = false;
                }
                else
                    e.UseDefaultCursors = true;
            }
            catch
            {
            }
        }
        string feedback = "";
        private void lvShowMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                feedback = dsMonAnBus.LayHinhMonAn(int.Parse(lvShowMonAn.SelectedItems[0].Tag.ToString()));
            }
            catch
            {
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static string path = Application.StartupPath;
        private void dtgvFrm1ThucDon_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            string pathFeedBack = path + "\\imageThucDon\\" + "dragdrop.png";
            Image image = Image.FromFile(pathFeedBack);
            Bitmap bitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(bitmap);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);

            if (e.Effect == DragDropEffects.Move)
            {
                if (customCursor == null)
                    Cursor.Current = myCursor;
                e.UseDefaultCursors = false;
            }
            else
                e.UseDefaultCursors = true;
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            lvShowMonAn.Items.Clear();
            LoadThucDon(dsMonAnBus.LayDSMonAn(txtFrm1TimMonAn.Text), lvShowMonAn);
        }

        private void textBoxX1_Click(object sender, EventArgs e)
        {
            txtFrm1TimMonAn.Text = "";
        }

        private void lvShowBan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvShowBan.SelectedItems.Count > 0)
                {
                    lvShowBan.DoDragDrop(lvShowBan.SelectedItems[0], DragDropEffects.Move);
                }
            }
        }

        private void lvShowBan_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            try
            {
                string pathFeedBack = path + "\\imageThucDon\\" + "addtable.png";
                Image image = Image.FromFile(pathFeedBack);
                Bitmap bitmap = new Bitmap(image);
                Graphics graphics = Graphics.FromImage(bitmap);
                IntPtr handle = bitmap.GetHicon();
                Cursor myCursor = new Cursor(handle);

                if (e.Effect == DragDropEffects.Move)
                {
                    if (customCursor == null)
                        Cursor.Current = myCursor;
                    e.UseDefaultCursors = false;
                }
                else
                    e.UseDefaultCursors = true;
            }
            catch
            {
            }
        }

        private void txtFrm1GiaGia_Click(object sender, EventArgs e)
        {
            if (txtFrm1GiaGia.Text.Trim() == "0")
                txtFrm1GiaGia.Text = "";
        }

        private void txtFrm1GiaGia_Validated(object sender, EventArgs e)
        {
            if (txtFrm1GiaGia.Text.Trim().Length < 1)
                txtFrm1GiaGia.Text = "0";
        }

        private void txtFrm1VAT_Click(object sender, EventArgs e)
        {
            if (txtFrm1VAT.Text.Trim() == "0")
                txtFrm1VAT.Text = "";
        }

        private void txtFrm1VAT_Validated(object sender, EventArgs e)
        {
            if (txtFrm1VAT.Text.Trim().Length < 1)
                txtFrm1VAT.Text = "0";
        }
        private void txtFrm1KhachTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                khachTra = double.Parse(txtFrm1KhachTra.Text);
                int gg = int.Parse(txtFrm1GiaGia.Text);
                int vat = int.Parse(txtFrm1VAT.Text);
                BaoGia(gg, vat);

            }
            catch
            {
                txtFrm1KhachTra.Text = "";
            }
        }
        private void txtFrm1KhachTra_Click(object sender, EventArgs e)
        {
            if (txtFrm1KhachTra.Text.Trim() == "0")
                txtFrm1KhachTra.Text = "";
        }

        private void txtFrm1KhachTra_Validated(object sender, EventArgs e)
        {
            if (txtFrm1KhachTra.Text.Trim().Length < 1)
                txtFrm1KhachTra.Text = "0";
        }

        private void btnFrm1TinhTien_Click(object sender, EventArgs e)
        {

            if (TrangThaiBanDangChon > 0)
            {

                DataTable dthd = SetTableHoaDon();
                ctPhieuTT_BUS.AttackDatainHoaDonRP(dthd);
                ExeReport();
                this.HOADONRPTableAdapter.Fill(this.QUANLYNHAHANGDataSet.HOADONRP);
                this.reportViewer1.RefreshReport();
                if (rdFrm1XemBanIn.Checked == false)
                {
                    grbFrm1Report.Visible = true;
                }
                else
                {
                    if (TrangThaiBanDangChon == 1)
                    {
                        try
                        {
                            SaveFile(path + "\\outputvb.xls");
                            PrintMyExcelFile();
                            lvShowBan.Items[indexItemliv].ImageIndex = 1;
                            banBUS.UpdateTrangThaiBan(1, int.Parse(lvShowBan.Items[indexItemliv].Tag.ToString()));
                            phieuTT_Bus.CapNhatTrangThaiPhieuTT(int.Parse(lvShowBan.Items[indexItemliv].Tag.ToString()), 2);
                            reFrestBaoGia();
                            RefreshDataGridview(dtgvFrm1ThucDon);
                            TrangThaiBanDangChon = -1;
                            MaBanDangChon = -1;
                            MessageBox.Show("Đã Tính Tiền Xong");
                        }
                        catch
                        {
                            if (MessageBox.Show("Lỗi Máy In, Bạn Có Muốn Chọn Máy In Khác Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                reportViewer1.PrintDialog();
                            }
                            else
                            {
                                lvShowBan.Items[indexItemliv].ImageIndex = 1;
                                banBUS.UpdateTrangThaiBan(1, int.Parse(lvShowBan.Items[indexItemliv].Tag.ToString()));
                                phieuTT_Bus.CapNhatTrangThaiPhieuTT(int.Parse(lvShowBan.Items[indexItemliv].Tag.ToString()), 2);
                                reFrestBaoGia();
                                RefreshDataGridview(dtgvFrm1ThucDon);
                                TrangThaiBanDangChon = -1;
                                MaBanDangChon = -1;
                                MessageBox.Show("Đã Tính Tiền Xong");
                            }
                        }
                    }

                }
                ctPhieuTT_BUS.DeleteDatainHoaDonRP();
            }

        }
        private DataTable SetTableHoaDon()
        {
            DataTable conVertTB = new DataTable();
            conVertTB.Columns.Add("TenMonAn", Type.GetType("System.String"));
            conVertTB.Columns.Add("SL", Type.GetType("System.String"));
            conVertTB.Columns.Add("DonGia", Type.GetType("System.String"));
            conVertTB.Columns.Add("GiamGia", Type.GetType("System.String"));
            conVertTB.Columns.Add("TongCong", Type.GetType("System.String"));
            foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
            {
                try
                {
                    DataRow dr = conVertTB.NewRow();
                    dr["TenMonAn"] = dtr.Cells[1].Value.ToString();
                    dr["SL"] = dtr.Cells[2].Value.ToString();
                    dr["DonGia"] = mn.FormatString(dtr.Cells[4].Value.ToString()).Replace(",,", ",");
                    dr["GiamGia"] = dtr.Cells[5].Value.ToString();
                    dr["TongCong"] = mn.FormatString(dtr.Cells[6].Value.ToString()).Replace(",,", ",");
                    conVertTB.Rows.Add(dr);
                }
                catch
                {
                }
            }
            return conVertTB;
        }
        public void ExeReport()
        {
            List<ReportParameter> Parameters = new List<ReportParameter>();
            ReportParameter param;
            param = new ReportParameter("TenNhanVien", "NV: " + nhanVienDangNhap.TenNguoiDung);
            Parameters.Add(param);
            param = new ReportParameter("SoHoaDon", "Số HD: " + phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon).ToString());
            Parameters.Add(param);
            param = new ReportParameter("TongTien", mn.FormatString(tongTien.ToString()) + " VND");
            Parameters.Add(param);
            param = new ReportParameter("GiamGia", mn.FormatString(giamGia.ToString()) + " VND");
            Parameters.Add(param);
            param = new ReportParameter("Vat", mn.FormatString(vAT.ToString()) + " VND");
            Parameters.Add(param);
            param = new ReportParameter("ThanhToan", mn.FormatString(thanhToan.ToString()) + " VND");
            Parameters.Add(param);
            param = new ReportParameter("TienGhichu", lbFrm1TienBangChu.Text);
            Parameters.Add(param);
            param = new ReportParameter("ThoiLai", thoiLai.ToString() + " VND");
            Parameters.Add(param);
            param = new ReportParameter("BanThanhToan", "Bill Thanh Toán Bàn " + lbFrm1TenBanAn.Text);
            Parameters.Add(param);
            param = new ReportParameter("phattram", txtFrm1GiaGia.Text + "%");
            Parameters.Add(param);
            param = new ReportParameter("ptvat", txtFrm1VAT.Text + "%");
            Parameters.Add(param);

            param = new ReportParameter("TenNhaHang", lbFrm1TenNhaHang.Text);
            Parameters.Add(param);
            param = new ReportParameter("SDT", lbFrm1SDTNhaHang.Text);
            Parameters.Add(param);
            param = new ReportParameter("DiaChi", lbFrm1DiachiNhaHang.Text);
            Parameters.Add(param);
            this.reportViewer1.LocalReport.SetParameters(Parameters);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DisplayName = "HoaDon";

        }


        private void btnInTruoc_Click(object sender, EventArgs e)
        {
            grbFrm1Report.Visible = true;
            Point newLocation = new Point();
            newLocation.X = 951;
            newLocation.Y = 8;
            grbFrm1Report.Location = newLocation;
            grbFrm1Report.Width = 240;
            grbFrm1Report.Height = 620;
            ctPhieuTT_BUS.DeleteDatainHoaDonRP();
            DataTable dthd = SetTableHoaDon();
            ctPhieuTT_BUS.AttackDatainHoaDonRP(dthd);
            ExeReport();
            this.HOADONRPTableAdapter.Fill(this.QUANLYNHAHANGDataSet.HOADONRP);
            this.reportViewer1.RefreshReport();
            SaveFile(path + "\\outputvb.xls");
            PrintMyExcelFile();
        }
        public bool isMouseDown;
        public Point vitrichuotdangbam;

        private void reportViewer1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            vitrichuotdangbam.X = e.X;
            vitrichuotdangbam.Y = e.Y;
        }

        private void reportViewer1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void reportViewer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                Point newLocation = new Point();
                newLocation.X = reportViewer1.Location.X + (e.X - vitrichuotdangbam.X);
                newLocation.Y = reportViewer1.Location.Y + (e.Y - vitrichuotdangbam.Y);
                reportViewer1.Location = newLocation;
            }
        }

        private void buttonX1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            vitrichuotdangbam.X = e.X;
            vitrichuotdangbam.Y = e.Y;
        }
        private void groupPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            vitrichuotdangbam.X = e.X;
            vitrichuotdangbam.Y = e.Y;
        }

        private void groupPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void groupPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                Point newLocation = new Point();
                newLocation.X = grbFrm1Report.Location.X + (e.X - vitrichuotdangbam.X);
                newLocation.Y = grbFrm1Report.Location.Y + (e.Y - vitrichuotdangbam.Y);
                grbFrm1Report.Location = newLocation;
            }
        }
        private void picFrm1Close_MouseEnter(object sender, EventArgs e)
        {
            string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\close3.png";
            picFrm1Close.ImageLocation = str;
        }

        private void picFrm1Close_MouseLeave(object sender, EventArgs e)
        {
            string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\close1.png";
            picFrm1Close.ImageLocation = str;
        }
        private void picFrm1Close_MouseDown(object sender, MouseEventArgs e)
        {
            string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\close2.png";
            picFrm1Close.ImageLocation = str;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            grbFrm1Report.Visible = false;
            //240, 620

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picFrm1MiniSize_MouseEnter(object sender, EventArgs e)
        {
            string str = "";
            if (flagMinMax == 2)
            {
                str = path.Replace("\\bin\\Debug", "\\") + "Resources\\max3.png";

                picFrm1MiniSize.ImageLocation = str;
            }
            else
                str = path.Replace("\\bin\\Debug", "\\") + "Resources\\mini3.png";

            picFrm1MiniSize.ImageLocation = str;
        }

        private void picFrm1MiniSize_MouseLeave(object sender, EventArgs e)
        {
            string str = "";
            if (flagMinMax == 2)
            {
                str = path.Replace("\\bin\\Debug", "\\") + "Resources\\max1.png";
                picFrm1MiniSize.ImageLocation = str;
            }
            else
                str = path.Replace("\\bin\\Debug", "\\") + "Resources\\MB_0030_off1.png";

            picFrm1MiniSize.ImageLocation = str;
        }

        private void picFrm1MiniSize_MouseDown(object sender, MouseEventArgs e)
        {
            string str = "";
            if (flagMinMax == 1)
            {
                str = path.Replace("\\bin\\Debug", "\\") + "Resources\\mini2.png";
                picFrm1MiniSize.ImageLocation = str;
            }
            else
                str = path.Replace("\\bin\\Debug", "\\") + "Resources\\max2.png";

            picFrm1MiniSize.ImageLocation = str;
        }
        public int flagMinMax = 1;//max = 2 min =1
        private void picFrm1MiniSize_MouseUp(object sender, MouseEventArgs e)
        {
            if (flagMinMax == 1)//max => min
            {
                //Point newLocation = new Point();
                //newLocation.X = 3;
                //newLocation.Y = 629;
                //grbFrm1Report.Location = newLocation;
                grbFrm1Report.Width = 80;
                grbFrm1Report.Height = 30;
                flagMinMax = 2;// =>min
                string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\max1.png";
                picFrm1MiniSize.ImageLocation = str;
            }
            else if (flagMinMax == 2)// min => max
            {
                //Point newLocation = new Point();
                //newLocation.X = 20;
                //newLocation.Y = 8;
                //grbFrm1Report.Location = newLocation;
                grbFrm1Report.Width = 240;
                grbFrm1Report.Height = 620;
                flagMinMax = 1;// => max
                string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\MB_0030_off1.png";
                picFrm1MiniSize.ImageLocation = str;
            }
        }

        private void grbFrm1Report_DoubleClick(object sender, EventArgs e)
        {
            if (flagMinMax == 1)//max => min
            {
                //Point newLocation = new Point();
                //newLocation.X = 3;
                //newLocation.Y = 629;
                //grbFrm1Report.Location = newLocation;
                grbFrm1Report.Width = 80;
                grbFrm1Report.Height = 30;
                flagMinMax = 2;// =>min
                string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\max1.png";
                picFrm1MiniSize.ImageLocation = str;
            }
            else if (flagMinMax == 2)// min => max
            {
                //Point newLocation = new Point();
                //newLocation.X = 20;
                //newLocation.Y = 8;
                //grbFrm1Report.Location = newLocation;
                grbFrm1Report.Width = 240;
                grbFrm1Report.Height = 620;
                flagMinMax = 1;// => max
                string str = path.Replace("\\bin\\Debug", "\\") + "Resources\\MB_0030_off1.png";
                picFrm1MiniSize.ImageLocation = str;
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.PrintDialog();
            }
            catch
            {
                MessageBox.Show("Chưa Kết Nối Máy In");
            }
        }

        private void btnXuatExCel_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Text file (*.xls)|*.xls|Arff file |*.arff|XML file (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.Title = "Bạn Muốn Lưu File Ở Đâu?";
                saveFileDialog1.InitialDirectory = @"C:/";
                ///////////////////////////////////////////////////////////////////////////////////////bug memory////
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("Luu Thành Công Tại: " + @"C:\Users\QN\Desktop");
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Chọn File Lưu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SaveFile(string pathname)
        {

            string mimeType;
            string encoding;
            string fileNameExtension;
            string[] streams;
            Warning[] warnings;
            try
            {
                File.Delete(pathname);
            }
            catch { }
            byte[] excelContent = reportViewer1.LocalReport.Render("Excel", null, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            FileStream fs = new FileStream(pathname, FileMode.Create);
            fs.Write(excelContent, 0, excelContent.Length);
            fs.Close();
        }
        public void PrintMyExcelFile()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Visible = false;
                ExcelApp.DisplayAlerts = false;

                Microsoft.Office.Interop.Excel.Workbook WBook = ExcelApp.Workbooks.Open
                (path + "\\outputvb.xls", Missing.Value,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value);

                WBook.PrintOut(Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value);

                WBook.Close(false, Missing.Value, Missing.Value);

                ExcelApp.Quit();
            }
            catch
            {
                MessageBox.Show("Quá Trình In Bị dừng Đột Ngột, Xin Kiểm Tra Lại Máy In");
            }
        }
        private void btnFrm1InHoaDon_Click(object sender, EventArgs e)
        {
            if (TrangThaiBanDangChon > 0)
            {
                if (lbFrm1ThoiLai.Text.IndexOf('-') >= 0)
                {
                    DataTable dthd = SetTableHoaDon();
                    ctPhieuTT_BUS.AttackDatainHoaDonRP(dthd);
                    ExeReport();
                    this.HOADONRPTableAdapter.Fill(this.QUANLYNHAHANGDataSet.HOADONRP);
                    this.reportViewer1.RefreshReport();
                    try
                    {
                        if (TrangThaiBanDangChon == 1)
                        {
                            SaveFile(path + "\\outputvb.xls");
                            PrintMyExcelFile();
                            lvShowBan.Items[indexItemliv].ImageIndex = 1;
                            banBUS.UpdateTrangThaiBan(1, int.Parse(lvShowBan.Items[indexItemliv].Tag.ToString()));
                            phieuTT_Bus.CapNhatTrangThaiPhieuTT(int.Parse(lvShowBan.Items[indexItemliv].Tag.ToString()), 2);
                            reFrestBaoGia();
                            RefreshDataGridview(dtgvFrm1ThucDon);
                            TrangThaiBanDangChon = -1;
                            MaBanDangChon = -1;
                            MessageBox.Show("Đã Tính Tiền Xong");

                        }
                    }
                    catch
                    {
                        if (MessageBox.Show("Lỗi Máy In, Bạn Có Muốn Chọn Máy In Khác Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            reportViewer1.PrintDialog();
                        }

                    }
                    ctPhieuTT_BUS.DeleteDatainHoaDonRP();
                }
                else
                {
                    MessageBox.Show("Tiền Khách Trả Còn Thiếu");
                }
            }
        }

        private void rdFrm1XemBanIn_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            if (rdFrm1XemBanIn.Checked == true)
                UpdateValueToConfigFile("rdFrm1XemBanIn", "true");
            else
                UpdateValueToConfigFile("rdFrm1XemBanIn", "false");
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void pctLoGo_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG File (*.png)|*.png|JPG file |*.jpg|All files (*.*)|*.*";
            openFileDialog1.Title = "Chọn Dữ Liệu Huấn Luyện";
            openFileDialog1.Multiselect = true;
            //openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                Size s = new Size(140, 96);
                Image imgcv = resizeImage(img, s);
                File.Delete(path + "\\imageThucDon\\Logo.png");
                imgcv.Save(path + "\\imageThucDon\\Logo.png", System.Drawing.Imaging.ImageFormat.Png);
                UpdateValueToConfigFile("pctLoGo", path + "\\imageThucDon\\Logo.png");
                pctLoGo.Image = imgcv;
            }
            //textBox1.Text = openFileDialog1.FileName;
        }
        private void labelX8_Click(object sender, EventArgs e)
        {
            exPanFrm1DoiThongTin.Expanded = true;
        }

        private void labelX7_Click(object sender, EventArgs e)
        {
            exPanFrm1DoiThongTin.Expanded = true;
        }

        private void labelX6_Click(object sender, EventArgs e)
        {
            exPanFrm1DoiThongTin.Expanded = true;
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {
            exPanFrm1DoiThongTin.Expanded = true;
        }

        private void expandablePanel2_Click(object sender, EventArgs e)
        {
            exPanFrm1DoiThongTin.Expanded = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            exPanFrm1DoiThongTin.Expanded = false;
        }

        private void btnFrm1LuuThongTinNhaHang_Click(object sender, EventArgs e)
        {
            if (txtFrm1TenNhaHang.Text.Length > 0)
            {
                UpdateValueToConfigFile("lbFrm1TenNhaHang", txtFrm1TenNhaHang.Text);
                lbFrm1TenNhaHang.Text = txtFrm1TenNhaHang.Text;
            }
            if (txtFrm1SDTNhaHang.Text.Length > 0)
            {
                UpdateValueToConfigFile("lbFrm1SDTNhaHang", txtFrm1SDTNhaHang.Text);
                lbFrm1DiachiNhaHang.Text = txtFrm1DiaChiNhaHang.Text;
            }
            if (txtFrm1DiaChiNhaHang.Text.Length > 0)
            {
                UpdateValueToConfigFile("lbFrm1DiachiNhaHang", txtFrm1DiaChiNhaHang.Text);
                lbFrm1SDTNhaHang.Text = txtFrm1SDTNhaHang.Text;
            }
            exPanFrm1DoiThongTin.Expanded = false;
        }

        private void btnFrm1XemTruocHD_Click(object sender, EventArgs e)
        {
            grbFrm1Report.Visible = true;
            Point newLocation = new Point();
            newLocation.X = 951;
            newLocation.Y = 14;
            grbFrm1Report.Location = newLocation;
            grbFrm1Report.Width = 240;
            grbFrm1Report.Height = 620;
            ctPhieuTT_BUS.DeleteDatainHoaDonRP();
            DataTable dthd = SetTableHoaDon();
            ctPhieuTT_BUS.AttackDatainHoaDonRP(dthd);
            ExeReport();
            this.HOADONRPTableAdapter.Fill(this.QUANLYNHAHANGDataSet.HOADONRP);
            this.reportViewer1.RefreshReport();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            NguoiDung dto = new NguoiDung();
            //nhanVienDangNhap.TaiKhoan = txtTaiKhoan.Text;
            //nhanVienDangNhap.MatKhau = txtMatKhau.Text;

            dto.TaiKhoan = txtTaiKhoan.Text;
            dto.MatKhau = txtMatKhau.Text;

            NGUOIDUNG_BUS bus = new NGUOIDUNG_BUS();

            BoPhan BoPhanDTO = new BoPhan();
            BOPHAN_BUS BoPhanBUS = new BOPHAN_BUS();
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                lbThongBaoDangNhap.Text = "Tên Tài khoản và Mật Khẩu không được bỏ trống!!!";
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = bus.KiemTraDangNhap(dto);

                    int temp = dt.Rows.Count;
                    if (temp > 0)
                    {
                        expan_DangNhap.Hide();
                        DataRow dr = dt.Rows[0];
                        string TenNV = dr["TenNguoiDung"].ToString();
                        string BoPhan = dr["BoPhan"].ToString();

                        BoPhanDTO.MaBoPhan = int.Parse(dr["BoPhan"].ToString());

                        Quyen = int.Parse(dr["BoPhan"].ToString());
                        PhanQuyen(Quyen);
                        Form1_Load(sender, e);
                        string x = BoPhanBUS.FilterBoPhan_String(BoPhanDTO);
                        lbShow.Text = "Chào: " + TenNV + " | " + x;

                        lbMetroTenNV.Text = TenNV.ToString();
                        lbMetroChucVu.Text = x.ToString();

                        pictureMetro.Image = new Bitmap(@"" + int.Parse(dt.Rows[0][2].ToString()) + ".jpg");

                        //gán giá trị cho nhanvienDangNhap
                        nhanVienDangNhap.BoPhan = int.Parse(dt.Rows[0][2].ToString());
                        nhanVienDangNhap.MatKhau = dt.Rows[0][1].ToString();
                        nhanVienDangNhap.SDT = dt.Rows[0][4].ToString();
                        nhanVienDangNhap.TaiKhoan = dt.Rows[0][0].ToString();
                        nhanVienDangNhap.TenNguoiDung = dt.Rows[0][3].ToString();
                        nhanVienDangNhap.TinhTrang = int.Parse(dt.Rows[0][5].ToString());
                        // test

                        lbMetroTenNV.Text = TenNV.ToString();
                        lbMetroChucVu.Text = x.ToString();




                        //
                    }
                    else
                    {
                        lbThongBaoDangNhap.Text = "sai Tài khoản hoặc Mật khẩu. vui lòng kiểm tra!!!";
                    }
                }
                catch
                {
                    //MessageBox.Show();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
            LoadNhanVien();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            NguoiDung NguoiDungDTO = new NguoiDung();
            DialogResult DR = MessageBox.Show("Bạn muốn xóa? \n Tài khoản: " + TaiKhoanS, "Thông Báo Xóa", MessageBoxButtons.OKCancel);
            NguoiDungDTO.TaiKhoan = TaiKhoanS;
            if (DialogResult.OK == DR)
            {
                try
                {

                    NguoiDungBUS.XoaNguoiDung_void(NguoiDungDTO);
                    Form1_Load(sender, e);
                }
                catch
                {
                    return;//MessageBox.Show("mời chọn nhân viên cần xoá!");
                }
            }
            else
                return;
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaiKhoanS = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            TenNVS = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
            TaiKhoanS = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            MatKhauS = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            ChucVuS = dgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            SDTS = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            frmSuaNhanVien frm = new frmSuaNhanVien();
            frm.ShowDialog();
            LoadNhanVien();
        }

        private void lbLogOut_Click(object sender, EventArgs e)
        {
            expan_DangNhap.Show();
        }

        public void TimNhanVien(string x)
        {
            NguoiDung dto = new NguoiDung();
            dto.TenNguoiDung = x;
            dgvNhanVien.DataSource = NguoiDungBUS.TimNguoiDung_Datatable(dto);
        }

        private void txtTimNhanVien_TextChanged(object sender, EventArgs e)
        {
            TimNhanVien(txtTimNhanVien.Text);
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            LoadThongKeHoaDon(dateTBatDau.Value.ToShortDateString(), dateTKetThuc.Value.ToShortDateString());

            lbHoaDon_TongCOng.Text = (dgvHoaDonPhucVu.RowCount - 1).ToString();

            lbHoaDong_TongTien.Text = phieuTT_Bus.TongTienThongKeHoaDon(dateTBatDau.Value.ToShortDateString(), dateTKetThuc.Value.ToShortDateString()) + " VNĐ";
        }
        public void LoadThongKeHoaDon(string NgayBatDau, string NgayKetThuc)
        {
            dgvHoaDonPhucVu.DataSource = phieuTT_Bus.FilterPhieuTT_Datatable(NgayBatDau, NgayKetThuc);
        }

        private void btnInThongKeHD_Click(object sender, EventArgs e)
        {
            //XuatFileExcel excel = new XuatFileExcel();
            DataTable dt = (DataTable)dgvHoaDonPhucVu.DataSource;
            string title = "THỐNG KÊ HOÁ ĐƠN";
            //excel.Export(dt,"ABC", title);

            xuatExcel.Export_HoaDon(dt, "ABC", title);


        }
        public static string MaPhieuTT_DG, NhanVien_DG, ThoiGian_DG, Ban_DG;

        private void dgvHoaDonPhucVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(i + ": " + dgvHoaDonPhucVu.Rows[e.RowIndex].Cells[i].Value.ToString());
            MaPhieuTT_DG = dgvHoaDonPhucVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            Ban_DG = dgvHoaDonPhucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            NhanVien_DG = dgvHoaDonPhucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            ThoiGian_DG = dgvHoaDonPhucVu.Rows[e.RowIndex].Cells[4].Value.ToString();

            frmChiTietHoaDon frm = new frmChiTietHoaDon();
            frm.ShowDialog();
            LoadThongKeHoaDon(dateTBatDau.Value.ToShortDateString(), dateTKetThuc.Value.ToShortDateString());

        }
        private void btnThemLoaiTD_Click(object sender, EventArgs e)
        {
            FormThemLoaiThucDon frmTLTD = new FormThemLoaiThucDon();
            frmTLTD.ShowDialog();
            ShowTree_LoadTD();
        }
        private void txtTimKiemTD_Click(object sender, EventArgs e)
        {
            if (txtTimKiemTD.Text == "Tìm Kiếm Thực Đơn...")
            {
                txtTimKiemTD.Text = "";
            }
        }

        private void txtTimKiemTD_Validated(object sender, EventArgs e)
        {
            if (txtTimKiemTD.Text.Length < 1)
                txtTimKiemTD.Text = "Tìm Kiếm Thực Đơn...";
        }
        private void btnSuaLoaiTD_Click(object sender, EventArgs e)
        {
            FormSuaLoaiMonAn frm = new FormSuaLoaiMonAn();
            //FormSuaLoaiMonAn frmslma = new FormSuaLoaiMonAn();
            frm.ShowDialog();
            ShowTree_LoadTD();

        }
        private void btnXoaLoaiTD_Click(object sender, EventArgs e)
        {
            FormWarningDelete frm = new FormWarningDelete();
            frm.ShowDialog();
            ShowTree_LoadTD();
        }
        public static int idNode;
        private void advTreeLTD_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {

            idNode = int.Parse(e.Node.TagString.ToString());
            DataTable dtb = new DataTable();
            dtb = dsMonAnBus.LayDanhSachMonAnTheoLoai(idNode);
            dtgirdViewTD.DataSource = dtb;
            int stt = 0;
            for (int i = 0; i < dtb.Rows.Count; ++i)
            {
                stt = stt + 1;
                dtgirdViewTD.Rows[i].Cells[0].Value = stt;
            }
        }

        public void ShowTree_LoadTD()
        {
            advTreeLTD.Nodes.Clear();
            DataTable TreeNode = dsLoaiMAbus.LayDSLoaiMonAn();
            foreach (DataRow dtr in TreeNode.Rows)
            {
                DevComponents.AdvTree.Node node1 = new DevComponents.AdvTree.Node(dtr[1].ToString());
                node1.TagString = dtr[0].ToString();
                advTreeLTD.Nodes.Add(node1);

                //DataTable childnode = dsMonAnBus.LayDanhSachMonAnTheoLoai((int)TreeNode.Rows[idNode][0]);
                //foreach (DataRow dtr1 in childnode.Rows)
                //{
                //    DevComponents.AdvTree.Node node2 = new DevComponents.AdvTree.Node();
                //    node2.TagString = childnode.Rows[idNode][1].ToString();
                //    node2.Tag = int.Parse(childnode.Rows[idNode][0].ToString());
                //    node1.Nodes.Add(node2);

                //}
            }
        }
        public void LoadDatagirdViewTD(int inode1)
        {
            DataTable dtb = new DataTable();
            dtb = dsMonAnBus.LayDanhSachMonAnTheoLoai(inode1);
            dtgirdViewTD.DataSource = dtb;
            int stt = 0;
            for (int i = 0; i < dtb.Rows.Count; ++i)
            {
                stt = stt + 1;
                dtgirdViewTD.Rows[i].Cells[0].Value = stt;
            }
        }

        /// <summary>
        /// PHẦN KHUYÊN LÀM
        /// </summary>
        public string tenBan = "";
        public string tenKhuVuc = "";
        public string tenMon = "";
        public string tenLoaiMon = "";
        // Hiển thị và xử lý danh sách món ăn  treeb AdvTree
        public void ShowTreeview_ThongKeMon()
        {
            DataTable nodeCha = dsLoaiMAbus.LayDSLoaiMonAn();
            for (int i = 0; i < nodeCha.Rows.Count; i++)
            {
                DevComponents.AdvTree.Node node1 = new DevComponents.AdvTree.Node();
                node1.Text = nodeCha.Rows[i][1].ToString();
                node1.Tag = int.Parse(nodeCha.Rows[i][0].ToString());
                node1.TagString = "nodeCha";
                trwTk_MonAn.Nodes.Add(node1);

                DataTable nodeCon = dsMonAnBus.LayDSMonAnTheoLoai((int)nodeCha.Rows[i][0]);
                for (int j = 0; j < nodeCon.Rows.Count; j++)
                {
                    DevComponents.AdvTree.Node node2 = new DevComponents.AdvTree.Node();
                    node2.Text = nodeCon.Rows[j][1].ToString();
                    node2.Tag = int.Parse(nodeCon.Rows[j][0].ToString());
                    node2.TagString = "nodeCon";
                    node1.Nodes.Add(node2);
                }
            }
        }

        private void tabthongKeMonAn_Click(object sender, EventArgs e)
        {
            trwTk_MonAn.Nodes.Clear();
            ShowTreeview_ThongKeMon();
        }

        private void trwTk_MonAn_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (e.Node.TagString == "nodeCha")
            {
                tenLoaiMon = e.Node.Text;
            }
            else
            {
                tenMon = e.Node.Text;
                tenLoaiMon = e.Node.Parent.Text;
            }

        }

        private void btnBaoCao_TKMon_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay_TKMon.Value;
            DateTime denNgay = dtpDenNgay_TKMon.Value;
            try
            {
                if (dtpTuNgay_TKMon.Value <= dtpTuNgay_TKMon.Value)
                {
                    if (tenLoaiMon == "")
                    {
                        dgvThongKeMonAn.DataSource = ctPhieuTT_BUS.ThongKe_TheoTenLoaiMonAn(tuNgay, denNgay, tenLoaiMon);
                    }
                    else
                    {
                        dgvThongKeMonAn.DataSource = ctPhieuTT_BUS.ThongKe_TheoTenMonAn(tuNgay, denNgay, tenMon, tenLoaiMon);

                    }
                    tenMon = tenLoaiMon = "";
                    // dgvThongKeMonAn.Rows.Clear();
                }

            }
            catch (System.Exception)
            {
                MessageBox.Show("Vui long kiem tra lai thong tin den ngay!");
            }


        }
        // Hiển thị và xử lý danh sách món ăn  treeb AdvTree
        public void ShowTreeview_Thongke_Ban_KhuVuc()
        {
            DataTable nodeCha = khuVucBus.LayDSKHUVUC();
            for (int i = 0; i < nodeCha.Rows.Count; i++)
            {
                DevComponents.AdvTree.Node node1 = new DevComponents.AdvTree.Node();
                node1.Text = nodeCha.Rows[i][1].ToString();
                node1.Tag = int.Parse(nodeCha.Rows[i][0].ToString());
                node1.TagString = "nodeCha";
                trwThongKe_Ban.Nodes.Add(node1);

                DataTable nodeCon = banBUS.LayDSBan((int)nodeCha.Rows[i][0]);
                for (int j = 0; j < nodeCon.Rows.Count; j++)
                {
                    DevComponents.AdvTree.Node node2 = new DevComponents.AdvTree.Node();
                    node2.Text = nodeCon.Rows[j][0].ToString();
                    node2.Tag = int.Parse(nodeCon.Rows[j][0].ToString());
                    node2.TagString = "nodeCon";
                    node1.Nodes.Add(node2);
                }
            }

        }

        private void tabItem1_Click(object sender, EventArgs e)
        {
            trwThongKe_Ban.Nodes.Clear();
            ShowTreeview_Thongke_Ban_KhuVuc();
        }
        private void btnBaoCao_Ban_Click(object sender, EventArgs e)
        {

            //dgvThongKe_Ban.Rows.Clear();
            DateTime tuNgay = dtpTuNgay_TKBan.Value;
            DateTime denNgay = dtpDenNgay_TKBan.Value;

            if (tenKhuVuc == "")
            {
                dgvThongKe_Ban.DataSource = phieuTT_Bus.SoPhieuTinhTien_TheoKhuVuc(tuNgay, denNgay, tenKhuVuc);
            }
            else
            {
                dgvThongKe_Ban.DataSource = phieuTT_Bus.SoPhieuTinhTien_TheoBan(tuNgay, denNgay, tenBan, tenKhuVuc);
            }
            tenBan = tenKhuVuc = "";
        }

        private void trwThongKe_Ban_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (e.Node.TagString == "nodeCha")
            {
                tenKhuVuc = e.Node.Text;

            }
            else
            {
                tenKhuVuc = e.Node.Parent.Text;
                tenBan = e.Node.Text;
            }
        }
        private void tabthongKeMonAn_Click_1(object sender, EventArgs e)
        {
            trwTk_MonAn.Nodes.Clear();
            ShowTreeview_ThongKeMon();
        }

        private void tabThongKe_Ban_Click(object sender, EventArgs e)
        {
            trwThongKe_Ban.Nodes.Clear();
            ShowTreeview_Thongke_Ban_KhuVuc();
        }


        ThongKe_XuatExcel xuatExcel = new ThongKe_XuatExcel();
        private void btnXuatEx_TKMon_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay_TKMon.Value;
            DateTime denNgay = dtpDenNgay_TKMon.Value;
            DataTable dt = (DataTable)dgvThongKeMonAn.DataSource;
            string title = tabthongKeMonAn.Text;
            string sheetName = "Thống kê món";
            if (tenLoaiMon == "")
            {
                dt = ctPhieuTT_BUS.ThongKe_TheoTenLoaiMonAn(tuNgay, denNgay, tenLoaiMon);
                xuatExcel.Export_MonAn(dt, sheetName, title);
            }
            else
            {
                dt = ctPhieuTT_BUS.ThongKe_TheoTenMonAn(tuNgay, denNgay, tenMon, tenLoaiMon);
                xuatExcel.Export_MonAn(dt, sheetName, title);

            }
            tenMon = tenLoaiMon = "";
        }

        private void btnXuatEx_Bn_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay_TKBan.Value;
            DateTime denNgay = dtpDenNgay_TKBan.Value;
            DataTable dt = (DataTable)dgvThongKe_Ban.DataSource;
            string title = tabThongKe_Ban.Text;
            string sheetName = "Thống kê bàn";
            if (tenKhuVuc == "")
            {
                dt = phieuTT_Bus.SoPhieuTinhTien_TheoKhuVuc(tuNgay, denNgay, tenKhuVuc);
                xuatExcel.Export_Ban(dt, sheetName, title);
            }
            else
            {
                dt = phieuTT_Bus.SoPhieuTinhTien_TheoBan(tuNgay, denNgay, tenBan, tenKhuVuc);
                xuatExcel.Export_Ban(dt, sheetName, title);
            }
            tenBan = tenKhuVuc = "";

        }
        private void btnThemTD_Click(object sender, EventArgs e)
        {
            FormThemThucDon frm = new FormThemThucDon();
            frm.ShowDialog();
            DataTable dtb = new DataTable();
            dtb = dsMonAnBus.LayDanhSachMonAnTheoLoai(idNode);
            dtgirdViewTD.DataSource = dtb;
            int stt = 0;
            for (int i = 0; i < dtb.Rows.Count; ++i)
            {
                stt = stt + 1;
                dtgirdViewTD.Rows[i].Cells[0].Value = stt;
            }
        }

        private void btnImportExcelTD_Click(object sender, EventArgs e)
        {
            FormNhapTuExcel frm = new FormNhapTuExcel();
            frm.ShowDialog();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            expan_DangNhap.Visible = true;
            txtMatKhau.Text = "";
            expFrm1MenuMeTro.Expanded = true;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            LoadThongKeHoaDon(dateTBatDau.Value.ToShortDateString(), dateTKetThuc.Value.ToShortDateString());

            lbHoaDon_TongCOng.Text = (dgvHoaDonPhucVu.RowCount - 1).ToString();

            lbHoaDong_TongTien.Text = phieuTT_Bus.TongTienThongKeHoaDon(dateTBatDau.Value.ToShortDateString(), dateTKetThuc.Value.ToShortDateString()) + " VNĐ";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //XuatFileExcel excel = new XuatFileExcel();
            DataTable dt = (DataTable)dgvHoaDonPhucVu.DataSource;
            string title = "THỐNG KÊ HOÁ ĐƠN";
            //excel.Export(dt,"ABC", title);

            xuatExcel.Export_HoaDon(dt, "ABC", title);
        }
        public void TimKiemTD(string st)
        {
            DSMONAN_DTO dsmadto = new DSMONAN_DTO();
            dsmadto.TenMonAn = st;
            dtgirdViewTD.DataSource = dsMonAnBus.TimKiemTD(dsmadto);
        }

        private void btnTimKiemTD_Click(object sender, EventArgs e)
        {
            TimKiemTD(txtTimKiemTD.Text);
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            FormSuaThucDon frm = new FormSuaThucDon();
            frm.ShowDialog();
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            //if (btnXoaTD.Text == "")
            //{
            //    btnXoaTD.Text = "Hoan Thanh";
            //    DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            //    cb.Width = 20;
            //    dtgirdViewTD.Columns[1].Width = girdViewTD.Columns[1].Width - 30;
            //    dtgirdViewTD.Columns.Add(cb);
            //}
            //else
            //{
            //    btnXoaTD.Text = "Xóa Thực Đơn";
            //    foreach(DataGridViewRow dtr in dtgirdViewTD.Rows)
            //    {
            //       //if(dtr.Cells[dtgirdViewTD.C]// vs cua may bi benh ah
            //    }
            //}

            FormWarningDeleteTD frm = new FormWarningDeleteTD();
            frm.ShowDialog();
        }
        int flagTachBan = -1;
        private void btnTachMon_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
            groupPanel3.Visible = false;
            if (btnActionTachMon.Text == "Tách Món")
            {
                btnActionDoiBan.Enabled = false;
                btnActionGhepBan.Enabled = false;
                labelX23.Text = "";
                expandablePanel1.Visible = true;
                flagTachBan = 1;
                DataGridViewCheckBoxColumn cbcl = new DataGridViewCheckBoxColumn();
                cbcl.Frozen = true;
                cbcl.Width = 20;
                dtgvFrm1ThucDon.Columns[1].Width = dtgvFrm1ThucDon.Columns[1].Width - 30;
                dtgvFrm1ThucDon.Columns.Add(cbcl);
                DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
                comboBoxEx1.DataSource = dsKhuVuc;
                lvActionTable.Clear();
                LoadBan(lvActionTable, dsKhuVuc, banBUS.LayDSBan());
                btnActionTachMon.Text = "Hủy Bỏ";
                lvShowBan.Enabled = false;
            }
            else
            {
                btnActionDoiBan.Enabled = true;
                btnActionGhepBan.Enabled = true;
                lvShowBan.Enabled = true;
                btnActionTachMon.Text = "Tách Món";
                dtgvFrm1ThucDon.Columns[1].Width = dtgvFrm1ThucDon.Columns[1].Width + 30;
                flagTachBan = -1;
                btnActionTachMon.Enabled = true;
                try
                {
                    dtgvFrm1ThucDon.Columns.RemoveAt(8);/// error
                    /// 
                    expandablePanel1.Visible = false;
                    DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
                    lvShowBan.Clear();
                    LoadBan(lvShowBan, dsKhuVuc, banBUS.LayDSBan());
                }
                catch { };
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            btnActionDoiBan.Enabled = true;
            btnActionGhepBan.Enabled = true;
            lvShowBan.Enabled = true;
            btnActionTachMon.Text = "Tách Món";
            dtgvFrm1ThucDon.Columns[1].Width = dtgvFrm1ThucDon.Columns[1].Width + 30;
            flagTachBan = -1;
            btnActionTachMon.Enabled = true;
            try
            {
                dtgvFrm1ThucDon.Columns.RemoveAt(8);/// error
                /// 
                expandablePanel1.Visible = false;
                DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
                lvShowBan.Clear();
                LoadBan(lvShowBan, dsKhuVuc, banBUS.LayDSBan());
            }
            catch { };
        }
        private int maBanTach;
        private string tenBanTach;
        private int imgBanTach;
        private void listView1_Click(object sender, EventArgs e)
        {////////////error index///////////////////////////////////////////////////////////////////////////////////////////

            tenBanTach = lvActionTable.SelectedItems[0].Text;
            labelX23.Text = "Bàn " + lbFrm1TenBanAn.Text + " Chuyển Qua Bàn " + lvActionTable.SelectedItems[0].Text;
            labelX23.Tag = lvActionTable.SelectedItems[0].Tag;
            maBanTach = int.Parse(lvActionTable.SelectedItems[0].Tag.ToString());
            imgBanTach = lvActionTable.SelectedItems[0].ImageIndex;

            buttonX8.Text = lbFrm1TenBanAn.Text;
            buttonX8.Tag = lbFrm1TenBanAn.Text;

            buttonX11.Text = lvActionTable.SelectedItems[0].Text;
            buttonX11.Tag = lvActionTable.SelectedItems[0].Tag;
        }

        private void textBoxX1_TextChanged_1(object sender, EventArgs e)
        {
            lvActionTable.Clear();
            DataTable dtBan = banBUS.LayDSBan(textBoxX1.Text);
            LoadBan(lvActionTable, khuVucBus.LayDSKHUVUC(), dtBan);
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhuVuc = comboBoxEx1.SelectedIndex;
            //banBUS.LayDSBan(maKhuVuc);
            lvActionTable.Clear();
            LoadBan(lvActionTable, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan(maKhuVuc + 1));
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            lvActionTable.Clear();
            LoadBan(lvActionTable, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                //image =0 dat truoc; image =1 trong ; image =2 co khách
                //tinhtrang= 3 dat truoc; tinhtrang= 2 da tinh; tinhtrang=1 chưa tinh
                int ind = imgBanTach;

                if (ind == 1)
                {
                    banBUS.UpdateTrangThaiBan(2, maBanTach);
                    lvActionTable.SelectedItems[0].ImageIndex = 2;
                    PhieuTinhTien ptt = new PhieuTinhTien();
                    ptt.Ban = maBanTach;

                    ptt.TongTien = 0;
                    ptt.GhiChu = " được chuyển qua từ bàn: " + tenBan;
                    ptt.TinhTrang = 1;
                    phieuTT_Bus.ThemPhieuTinhTien(ptt);

                    //TrangThaiBanDangChon = 2;
                    lvShowBan.Clear();
                    LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
                    //MaBanDangChon = ptt.Ban;
                    double tongMn = 0;
                    double tongt = phieuTT_Bus.LayTongTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon));
                    int old = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                    int new1 = phieuTT_Bus.LayMaPhieuTinhTien(ptt.Ban);
                    foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                    {
                        if (dtr.Cells[dtgvFrm1ThucDon.Columns.Count - 1].Value != null)
                        {
                            tongMn += double.Parse(dtr.Cells[6].Value.ToString());
                            int mama = int.Parse(dtr.Cells[7].Value.ToString());
                            double tt = double.Parse(dtr.Cells[6].Value.ToString());
                            ctPhieuTT_BUS.updateMaPTTOfCTPTT(old, mama, new1);
                        }
                    }
                    for (int i = dtgvFrm1ThucDon.Rows.Count - 1; i >= 0; i--)
                    {
                        if (dtgvFrm1ThucDon.Rows[i].Cells[8].Value != null)
                        {
                            dtgvFrm1ThucDon.Rows.RemoveAt(i);
                        }
                    }

                    phieuTT_Bus.CapNhapTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(ptt.Ban), tongMn);

                    phieuTT_Bus.CapNhapTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon), tongt - tongMn);
                    ClicklvShowBan(MaBanDangChon, 2, lbFrm1TenBanAn.Text);
                }
                else// nhap vao ban co khách
                {
                    double tongMn = 0;
                    double tongt = phieuTT_Bus.LayTongTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon));
                    int mabanchon = maBanTach;
                    int old = phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon);
                    int new1 = phieuTT_Bus.LayMaPhieuTinhTien(mabanchon);
                    double tongt1 = phieuTT_Bus.LayTongTienPhieuTT(new1);
                    foreach (DataGridViewRow dtr in dtgvFrm1ThucDon.Rows)
                    {
                        if (dtr.Cells[dtgvFrm1ThucDon.Columns.Count - 1].Value != null)
                        {
                            tongMn += double.Parse(dtr.Cells[6].Value.ToString());
                            int mama = int.Parse(dtr.Cells[7].Value.ToString());
                            try
                            {
                                int ktsl = ctPhieuTT_BUS.KiemTraMonTonTai(new1, mama);

                                if (ktsl > 0)
                                {
                                    ctPhieuTT_BUS.CapNhatSoLuongCT(new1, mama, ktsl);
                                    ctPhieuTT_BUS.XoaCTPhieuTinhTien(old, mama);
                                }
                            }
                            catch
                            {
                                ctPhieuTT_BUS.updateMaPTTOfCTPTT(old, mama, new1);
                            }
                        }
                    }// doi bung qua may oi!
                    for (int i = dtgvFrm1ThucDon.Rows.Count - 1; i >= 0; i--)
                    {
                        if (dtgvFrm1ThucDon.Rows[i].Cells[8].Value != null)
                        {
                            dtgvFrm1ThucDon.Rows.RemoveAt(i);
                        }
                    }

                    phieuTT_Bus.CapNhapTienPhieuTT(new1, tongt1 + tongMn);

                    phieuTT_Bus.CapNhapTienPhieuTT(phieuTT_Bus.LayMaPhieuTinhTien(MaBanDangChon), tongt - tongMn);
                    ClicklvShowBan(MaBanDangChon, 2, lbFrm1TenBanAn.Text);
                }
                //end tách món
                btnActionDoiBan.Enabled = true;
                btnActionGhepBan.Enabled = true;
                lvShowBan.Enabled = true;
                btnActionTachMon.Text = "Tách Món";
                dtgvFrm1ThucDon.Columns[1].Width = dtgvFrm1ThucDon.Columns[1].Width + 30;
                flagTachBan = -1;
                btnActionTachMon.Enabled = true;
                try
                {
                    dtgvFrm1ThucDon.Columns.RemoveAt(8);/// error
                    /// 
                    expandablePanel1.Visible = false;
                    DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
                    lvShowBan.Clear();
                    LoadBan(lvShowBan, dsKhuVuc, banBUS.LayDSBan());
                }
                catch { };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            btnDoiBan.Visible = false;
            if (btnActionGhepBan.Text == "Ghép Bàn")
            {
                btnActionGhepBan.Text = "Hủy Bỏ";
                groupPanel3.Visible = true;
                expandablePanel1.Visible = true;
                expandablePanel1.Expanded = true;
                DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
                lvActionTable.Clear();
                LoadBan(lvActionTable, dsKhuVuc, banBUS.LayDSBanTheoTrangThai(2));
                lvShowBan.Enabled = false;
                btnDoiBan.Visible = false;
            }
            else
            {
                btnActionGhepBan.Text = "Ghép Bàn";
                expandablePanel1.Visible = false;
                groupPanel3.Visible = false;
                lvShowBan.Enabled = true;
                btnDoiBan.Visible = true;
            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            expandablePanel1.Visible = false;
            groupPanel3.Visible = false;
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            //buttonX9.Visible = false;
            int newmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(labelX23.Tag.ToString()));
            int mb;
            if (labelX23.Tag == buttonX8.Tag)
            {
                mb = int.Parse(buttonX11.Tag.ToString());
            }
            else
                mb = int.Parse(buttonX8.Tag.ToString());
            int oldmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(mb);
            if (oldmaPhieu != newmaPhieu)
            {
                ctPhieuTT_BUS.GhepBan(oldmaPhieu, newmaPhieu);
                double tongTien = phieuTT_Bus.LayTongTienPhieuTT(newmaPhieu);
                phieuTT_Bus.CapNhapTienPhieuTT(newmaPhieu, tongTien);
                banBUS.UpdateTrangThaiBan(1, mb);
                foreach (ListViewItem listview in lvShowBan.Items)
                {
                    if (int.Parse(listview.Tag.ToString()) == mb)
                    {
                        listview.ImageIndex = 1;
                        break;
                    }
                }
                phieuTT_Bus.XoaPhieuTinhTien(oldmaPhieu);
                RefreshDataGridview(dtgvFrm1ThucDon);
                reFrestBaoGia();

                btnActionGhepBan.Text = "Ghép Bàn";
                expandablePanel1.Visible = false;
                groupPanel3.Visible = false;
                lvShowBan.Enabled = true;
                btnDoiBan.Visible = true;
            }
            else
            {
                MessageBox.Show("Không Thể Gép. Bạn Đã Chọn Trùng Bàn Nhau");
            }
        }

        private void buttonX7_Click_1(object sender, EventArgs e)
        {
            if (btnActionDoiBan.Text == "Đổi Bàn")
            {
                btnDoiBan.Visible = true;
                btnActionDoiBan.Text = "Hủy Bỏ";
                groupPanel3.Visible = true;
                expandablePanel1.Visible = true;
                DataTable dsKhuVuc = khuVucBus.LayDSKHUVUC();
                lvActionTable.Clear();
                LoadBan(lvActionTable, dsKhuVuc, banBUS.LayDSBan());
                lvShowBan.Enabled = false;
            }
            else
            {
                btnDoiBan.Visible = false;
                btnActionDoiBan.Text = "Đổi Bàn";
                groupPanel3.Visible = true;
                expandablePanel1.Visible = false;
                lvShowBan.Enabled = true;
            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            btnDoiBan.Visible = false;
            btnActionDoiBan.Text = "Đổi Bàn";
            groupPanel3.Visible = true;
            expandablePanel1.Visible = false;
            lvShowBan.Enabled = true;
            ListViewItem row = lvShowBan.SelectedItems[0];
            ListViewItem lvi = lvActionTable.SelectedItems[0];
            if (row.ImageIndex != 1 && lvi.ImageIndex != 1)
            {
                int newBan = int.Parse(lvi.Tag.ToString());
                int newmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(newBan);
                int oldBan = int.Parse(row.Tag.ToString());
                int oldmaPhieu = phieuTT_Bus.LayMaPhieuTinhTien(oldBan);
                phieuTT_Bus.CapNhatBanChoPhieuTT(newmaPhieu, oldBan);
                phieuTT_Bus.CapNhatBanChoPhieuTT(oldmaPhieu, newBan);
                ClicklvShowBan(int.Parse(lvi.Tag.ToString()), lvi.ImageIndex, lvi.Text);
            }
            else if (lvi.ImageIndex == 1 && row.ImageIndex != 1)
            {
                int trangThai = 3;
                int Maphieudoi;
                if (row.ImageIndex == 2)
                {
                    trangThai = 2;
                    Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(row.Tag.ToString()));
                }
                else
                    Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(row.Tag.ToString()));

                phieuTT_Bus.CapNhatBanChoPhieuTT(Maphieudoi, int.Parse(lvi.Tag.ToString()));
                banBUS.UpdateTrangThaiBan(1, int.Parse(row.Tag.ToString()));
                banBUS.UpdateTrangThaiBan(trangThai, int.Parse(lvi.Tag.ToString()));
                lvShowBan.Clear();
                LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());

                ClicklvShowBan(int.Parse(lvi.Tag.ToString()), 2, lvi.Text);
            }
            else if (lvi.ImageIndex != 1 && row.ImageIndex == 1)
            {

                int trangThai = 3;
                int Maphieudoi;
                if (lvi.ImageIndex == 2)
                {
                    trangThai = 2;
                    Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));
                }
                else
                    Maphieudoi = phieuTT_Bus.LayMaPhieuTinhTien(int.Parse(lvi.Tag.ToString()));

                phieuTT_Bus.CapNhatBanChoPhieuTT(Maphieudoi, int.Parse(row.Tag.ToString()));
                banBUS.UpdateTrangThaiBan(1, int.Parse(lvi.Tag.ToString()));
                banBUS.UpdateTrangThaiBan(trangThai, int.Parse(row.Tag.ToString()));
                lvShowBan.Clear();
                LoadBan(lvShowBan, khuVucBus.LayDSKHUVUC(), banBUS.LayDSBan());
                ClicklvShowBan(int.Parse(row.Tag.ToString()), 2, row.Text);
            }
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            DotKhuyenMai_DTO dotKMDTO = new DotKhuyenMai_DTO();
            dotKMDTO.TenDotKM = txtTenDotKM.Text;
            dotKMDTO.TrangThai = cbxTinhTrangKM.Checked ? 1 : 0;
            dotKMDTO.TgBatDau = dtpkTGTu.Value;
            dotKMDTO.TgKetThuc = dtpkTGDen.Value;
            dotKMDTO.Mua = int.Parse( nUDMua.Value.ToString());
            dotKMDTO.Tang = int.Parse(nUDTang.Value.ToString());
            dotKMDTO.Giam = int.Parse(nUDGiamGia.Value.ToString());
            dotKMDTO.GhiChu = txtGhiChu.Text;
            dotKMBus.ThemDotKhuyenMai(dotKMDTO);
            int maKM =int.Parse( dotKMBus.LayDotKhuyenMaiTheoTen(txtTenDotKM.Text).Rows[0]["ID"].ToString());
            ChiTietKhungGio_DTO ctKhungGioDTO;
            for(int i=2;i<9;i++){
                ctKhungGioDTO = new ChiTietKhungGio_DTO();
                string thu = "";
                thu = i < 8 ? i.ToString() : "CN";
                CheckBox cbxThu = (CheckBox)grKG.Controls.Find("cbxT" + thu, true)[0];//rdbKGCaNgayT2
                if (cbxThu.Checked == true)
                {
                    RadioButton rdbKGCaNgayThu = (RadioButton)grKG.Controls.Find("rdbKGCaNgayT" + thu, true)[0];
                    if (rdbKGCaNgayThu.Checked == true)
                    {
                        ctKhungGioDTO.HBatDau = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day, 1, 0, 0);
                        ctKhungGioDTO.HKetThuc = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day, 23, 59, 59);
                    }
                    else
                    {
                        DateTimeInput dtpkKGTuThu = (DateTimeInput)grKG.Controls.Find("dtpkKGTuT" + thu, true)[0];
                        DateTimeInput dtpkKGDenThu = (DateTimeInput)grKG.Controls.Find("dtpkKGDenT" + thu, true)[0];
                        ctKhungGioDTO.HBatDau = dtpkKGTuThu.Value;
                        ctKhungGioDTO.HKetThuc = dtpkKGDenThu.Value;
                    }
                    ctKhungGioDTO.MaKM = maKM;
                }
                chitietKGBus.ThemChiTietKhungGio(ctKhungGioDTO);
            }
            ChiTietKMOFMonAn_DTO ctKMofMonAn;
            foreach (ListViewItem lvi in lvShowThucDonKhuyenMai.Items)
            {
                if (lvi.Checked == true)
                {
                    ctKMofMonAn = new ChiTietKMOFMonAn_DTO();
                    ctKMofMonAn.MaKM = maKM;
                    ctKMofMonAn.MaMonan=int.Parse(lvi.Tag.ToString());
                    chitietKMOfMonAnBus.ThemChiTietKMMonAn(ctKMofMonAn);
                }
            }
        }

        private void cbxAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 2; i < 9; i++)
            {
                string thu = "";
                thu = i < 8 ? i.ToString() : "CN";
                CheckBoxX cbxThu = (CheckBoxX)grKG.Controls.Find("cbxT" + thu, true)[0];
                cbxThu.Checked = cbxAll.Checked;
                if (cbxAll.Checked == true)
                {
                    RadioButton rdbKGCaNgayThu = (RadioButton)grKG.Controls.Find("rdbKGCaNgayT" + thu, true)[0];
                    RadioButton rdbKGTuThu = (RadioButton)grKG.Controls.Find("rdbKGTuT" + thu, true)[0];
                    rdbKGCaNgayThu.Checked = rdbKGCaNgayAll.Checked;
                    rdbKGTuThu.Checked = rdbKGTuAll.Checked;

                    DateTimeInput dtpkKGDenThu = (DateTimeInput)grKG.Controls.Find("dtpkKGDenT" + thu, true)[0];
                    dtpkKGDenThu.Value = dtpkKGDenAll.Value;

                    DateTimeInput dtpkKGTuThu = (DateTimeInput)grKG.Controls.Find("dtpkKGTuT" + thu, true)[0];
                    dtpkKGTuThu.Value = dtpkKGTuAll.Value;
                }
            }
        }

        private void rdbKGCaNgayAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAll.Checked == true)
            {
                for (int i = 2; i < 9; i++)
                {
                    string thu = "";
                    thu = i < 8 ? i.ToString() : "CN";
                    RadioButton rdbKGCaNgayThu = (RadioButton)grKG.Controls.Find("rdbKGCaNgayT" + thu, true)[0];
                    RadioButton rdbKGTuThu = (RadioButton)grKG.Controls.Find("rdbKGTuT" + thu, true)[0];
                    rdbKGCaNgayThu.Checked = rdbKGCaNgayAll.Checked;
                    rdbKGTuThu.Checked = rdbKGTuAll.Checked;
                }
            }
        }

        private void rdbKGTuAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAll.Checked == true)
            {
                for (int i = 2; i < 9; i++)
                {
                    string thu = "";
                    thu = i < 8 ? i.ToString() : "CN";
                    RadioButton rdbKGCaNgayThu = (RadioButton)grKG.Controls.Find("rdbKGCaNgayT" + thu, true)[0];
                    RadioButton rdbKGTuThu = (RadioButton)grKG.Controls.Find("rdbKGTuT" + thu, true)[0];
                    rdbKGCaNgayThu.Checked = rdbKGCaNgayAll.Checked;
                    rdbKGTuThu.Checked = rdbKGTuAll.Checked;
                }
            }
        }

        private void dtpkKGTuAll_ValueChanged(object sender, EventArgs e)
        {
            if (cbxAll.Checked == true)
            {
                for (int i = 2; i < 9; i++)
                {
                    string thu = "";
                    thu = i < 8 ? i.ToString() : "CN";
                    DateTimeInput dtpkKGTuThu = (DateTimeInput)grKG.Controls.Find("dtpkKGTuT" + thu, true)[0];
                    dtpkKGTuThu.Value = dtpkKGTuAll.Value;
                }
            }
        }

        private void dtpkKGDenAll_ValueChanged(object sender, EventArgs e)
        {
            if (cbxAll.Checked == true)
            {
                for (int i = 2; i < 9; i++)
                {
                    string thu = "";
                    thu = i < 8 ? i.ToString() : "CN";
                    DateTimeInput dtpkKGDenThu = (DateTimeInput)grKG.Controls.Find("dtpkKGDenT" + thu, true)[0];
                    dtpkKGDenThu.Value = dtpkKGDenAll.Value;
                }
            }
        }

        private void metroTabItem3_Click(object sender, EventArgs e)
        {
            LoadThucDon(dsMonAnBus.LayDSMonAn(), lvShowThucDonKhuyenMai);
        }

        private void lvShowThucDonKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //ListViewItem lvi = ((ListView)sender).SelectedItems[0];
            //lvi.Checked = true;
        }

        private void lvShowThucDonKhuyenMai_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem lvi = e.Item;
            lvi.Checked = true;
        }

        private void textBoxX3_Click(object sender, EventArgs e)
        {
            textBoxX3.Text = "";
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            lvShowThucDonKhuyenMai.Items.Clear();
            LoadThucDon(dsMonAnBus.LayDSMonAn(textBoxX3.Text), lvShowThucDonKhuyenMai);
        }

        

    }
}


