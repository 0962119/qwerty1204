namespace Restaurant
{
    partial class frmBaoCaoDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.metroAppButton1 = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnXuatEx = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgBaoCaoDT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cbxHinhThucBC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHinhThucBC = new System.Windows.Forms.Label();
            this.lbTieuDeDT = new System.Windows.Forms.Label();
            this.userControl11 = new Restaurant.UserControl1();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.metroShell1.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            this.metroTabPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoCaoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroAppButton1,
            this.metroTabItem1,
            this.metroTabItem2});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(0, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.metroShell1.Size = new System.Drawing.Size(583, 445);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 11;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Checked = true;
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&HOME";
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.btnXuatEx);
            this.metroTabPanel1.Controls.Add(this.btnBaoCao);
            this.metroTabPanel1.Controls.Add(this.panel1);
            this.metroTabPanel1.Controls.Add(this.dtpNgayLap);
            this.metroTabPanel1.Controls.Add(this.dtpDenNgay);
            this.metroTabPanel1.Controls.Add(this.dtpTuNgay);
            this.metroTabPanel1.Controls.Add(this.cbxHinhThucBC);
            this.metroTabPanel1.Controls.Add(this.label4);
            this.metroTabPanel1.Controls.Add(this.label2);
            this.metroTabPanel1.Controls.Add(this.label3);
            this.metroTabPanel1.Controls.Add(this.lbHinhThucBC);
            this.metroTabPanel1.Controls.Add(this.lbTieuDeDT);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(583, 394);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&VIEW";
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Controls.Add(this.userControl11);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(583, 394);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.BeginGroup = true;
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // metroAppButton1
            // 
            this.metroAppButton1.AutoExpandOnClick = true;
            this.metroAppButton1.CanCustomize = false;
            this.metroAppButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.metroAppButton1.ImagePaddingHorizontal = 0;
            this.metroAppButton1.ImagePaddingVertical = 0;
            this.metroAppButton1.Name = "metroAppButton1";
            this.metroAppButton1.ShowSubItems = false;
            this.metroAppButton1.Text = "&File";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.BackColor = System.Drawing.Color.White;
            this.btnXuatEx.ForeColor = System.Drawing.Color.Black;
            this.btnXuatEx.Location = new System.Drawing.Point(440, 168);
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.Size = new System.Drawing.Size(99, 23);
            this.btnXuatEx.TabIndex = 19;
            this.btnXuatEx.Text = "Xuất ra Excel";
            this.btnXuatEx.UseVisualStyleBackColor = false;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.White;
            this.btnBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnBaoCao.Location = new System.Drawing.Point(350, 168);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 20;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.dtgBaoCaoDT);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 389);
            this.panel1.TabIndex = 18;
            // 
            // dtgBaoCaoDT
            // 
            this.dtgBaoCaoDT.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaoCaoDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBaoCaoDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaoCaoDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoPhieu,
            this.TongTien,
            this.TrungBinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBaoCaoDT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBaoCaoDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBaoCaoDT.EnableHeadersVisualStyles = false;
            this.dtgBaoCaoDT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgBaoCaoDT.Location = new System.Drawing.Point(0, 0);
            this.dtgBaoCaoDT.Name = "dtgBaoCaoDT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaoCaoDT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBaoCaoDT.RowHeadersVisible = false;
            this.dtgBaoCaoDT.Size = new System.Drawing.Size(582, 389);
            this.dtgBaoCaoDT.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // SoPhieu
            // 
            this.SoPhieu.HeaderText = "Số Phiếu";
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền (VNĐ)";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 200;
            // 
            // TrungBinh
            // 
            this.TrungBinh.HeaderText = "Trung Bình (VNĐ)";
            this.TrungBinh.Name = "TrungBinh";
            this.TrungBinh.Width = 200;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.BackColor = System.Drawing.Color.White;
            this.dtpNgayLap.ForeColor = System.Drawing.Color.Black;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(418, 91);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayLap.TabIndex = 15;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.BackColor = System.Drawing.Color.White;
            this.dtpDenNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(418, 120);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(121, 20);
            this.dtpDenNgay.TabIndex = 16;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.BackColor = System.Drawing.Color.White;
            this.dtpTuNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(128, 121);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(121, 20);
            this.dtpTuNgay.TabIndex = 17;
            // 
            // cbxHinhThucBC
            // 
            this.cbxHinhThucBC.BackColor = System.Drawing.Color.White;
            this.cbxHinhThucBC.ForeColor = System.Drawing.Color.Black;
            this.cbxHinhThucBC.FormattingEnabled = true;
            this.cbxHinhThucBC.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tuần",
            "Theo tháng",
            "Theo quý",
            "Theo năm",
            "<Thời gian bất kỳ>"});
            this.cbxHinhThucBC.Location = new System.Drawing.Point(128, 90);
            this.cbxHinhThucBC.Name = "cbxHinhThucBC";
            this.cbxHinhThucBC.Size = new System.Drawing.Size(121, 21);
            this.cbxHinhThucBC.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(355, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(359, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Từ ngày:";
            // 
            // lbHinhThucBC
            // 
            this.lbHinhThucBC.AutoSize = true;
            this.lbHinhThucBC.BackColor = System.Drawing.Color.White;
            this.lbHinhThucBC.ForeColor = System.Drawing.Color.Black;
            this.lbHinhThucBC.Location = new System.Drawing.Point(24, 94);
            this.lbHinhThucBC.Name = "lbHinhThucBC";
            this.lbHinhThucBC.Size = new System.Drawing.Size(98, 13);
            this.lbHinhThucBC.TabIndex = 12;
            this.lbHinhThucBC.Text = "Hình thức báo cáo:";
            // 
            // lbTieuDeDT
            // 
            this.lbTieuDeDT.AutoSize = true;
            this.lbTieuDeDT.BackColor = System.Drawing.Color.White;
            this.lbTieuDeDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTieuDeDT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeDT.ForeColor = System.Drawing.Color.Black;
            this.lbTieuDeDT.Location = new System.Drawing.Point(182, 32);
            this.lbTieuDeDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTieuDeDT.Name = "lbTieuDeDT";
            this.lbTieuDeDT.Size = new System.Drawing.Size(243, 27);
            this.lbTieuDeDT.TabIndex = 9;
            this.lbTieuDeDT.Text = "BÁO CÁO DOANH THU";
            this.lbTieuDeDT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.ForeColor = System.Drawing.Color.Black;
            this.userControl11.Location = new System.Drawing.Point(9, 18);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(547, 367);
            this.userControl11.TabIndex = 0;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Expanded = false;
            this.expandablePanel1.ExpandedBounds = new System.Drawing.Rectangle(-2, 483, 574, 195);
            this.expandablePanel1.Location = new System.Drawing.Point(-2, 483);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(30, 195);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 12;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Title Bar";
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 682);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.metroShell1);
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            this.metroTabPanel1.PerformLayout();
            this.metroTabPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoCaoDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private System.Windows.Forms.Button btnXuatEx;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgBaoCaoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.ComboBox cbxHinhThucBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHinhThucBC;
        private System.Windows.Forms.Label lbTieuDeDT;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroAppButton metroAppButton1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private UserControl1 userControl11;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;

    }
}