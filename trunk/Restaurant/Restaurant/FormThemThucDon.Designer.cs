namespace Restaurant
{
    partial class FormThemThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemThucDon));
            this.labelTD = new DevComponents.DotNetBar.LabelX();
            this.txtThemThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelGiaBan = new DevComponents.DotNetBar.LabelX();
            this.labelGiamGia = new DevComponents.DotNetBar.LabelX();
            this.txtGiaBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiamGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbLoaiTD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbDVT = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btOK = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelTD
            // 
            this.labelTD.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelTD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelTD.ForeColor = System.Drawing.Color.Black;
            this.labelTD.Location = new System.Drawing.Point(2, 28);
            this.labelTD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTD.Name = "labelTD";
            this.labelTD.Size = new System.Drawing.Size(112, 37);
            this.labelTD.TabIndex = 0;
            this.labelTD.Text = "Tên Thực Đơn:";
            this.labelTD.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // txtThemThucDon
            // 
            this.txtThemThucDon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtThemThucDon.Border.Class = "TextBoxBorder";
            this.txtThemThucDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThemThucDon.ForeColor = System.Drawing.Color.Black;
            this.txtThemThucDon.Location = new System.Drawing.Point(122, 34);
            this.txtThemThucDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThemThucDon.Multiline = true;
            this.txtThemThucDon.Name = "txtThemThucDon";
            this.txtThemThucDon.Size = new System.Drawing.Size(213, 29);
            this.txtThemThucDon.TabIndex = 1;
            this.txtThemThucDon.TextChanged += new System.EventHandler(this.txtThemThucDon_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(2, 75);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(112, 37);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Loại Thực Đơn:";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(2, 122);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(112, 37);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Đơn Vị Tính:";
            // 
            // labelGiaBan
            // 
            this.labelGiaBan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelGiaBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGiaBan.ForeColor = System.Drawing.Color.Black;
            this.labelGiaBan.Location = new System.Drawing.Point(2, 168);
            this.labelGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelGiaBan.Name = "labelGiaBan";
            this.labelGiaBan.Size = new System.Drawing.Size(112, 37);
            this.labelGiaBan.TabIndex = 0;
            this.labelGiaBan.Text = "Giá Bán:";
            // 
            // labelGiamGia
            // 
            this.labelGiamGia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelGiamGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelGiamGia.ForeColor = System.Drawing.Color.Black;
            this.labelGiamGia.Location = new System.Drawing.Point(2, 207);
            this.labelGiamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelGiamGia.Name = "labelGiamGia";
            this.labelGiamGia.Size = new System.Drawing.Size(112, 37);
            this.labelGiamGia.TabIndex = 0;
            this.labelGiamGia.Text = "Giảm Giá:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGiaBan.Border.Class = "TextBoxBorder";
            this.txtGiaBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaBan.FocusHighlightEnabled = true;
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.Location = new System.Drawing.Point(121, 174);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(189, 29);
            this.txtGiaBan.TabIndex = 1;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGiamGia.Border.Class = "TextBoxBorder";
            this.txtGiamGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiamGia.FocusHighlightEnabled = true;
            this.txtGiamGia.ForeColor = System.Drawing.Color.Black;
            this.txtGiamGia.Location = new System.Drawing.Point(121, 213);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(189, 29);
            this.txtGiamGia.TabIndex = 1;
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // cbbLoaiTD
            // 
            this.cbbLoaiTD.DisplayMember = "Text";
            this.cbbLoaiTD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiTD.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiTD.FormattingEnabled = true;
            this.cbbLoaiTD.ItemHeight = 23;
            this.cbbLoaiTD.Location = new System.Drawing.Point(121, 83);
            this.cbbLoaiTD.Name = "cbbLoaiTD";
            this.cbbLoaiTD.Size = new System.Drawing.Size(214, 29);
            this.cbbLoaiTD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbLoaiTD.TabIndex = 3;
            this.cbbLoaiTD.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiTD_SelectedIndexChanged);
            // 
            // cbbDVT
            // 
            this.cbbDVT.DisplayMember = "Text";
            this.cbbDVT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDVT.ForeColor = System.Drawing.Color.Black;
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.ItemHeight = 23;
            this.cbbDVT.Location = new System.Drawing.Point(121, 127);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(214, 29);
            this.cbbDVT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbDVT.TabIndex = 4;
            this.cbbDVT.SelectedIndexChanged += new System.EventHandler(this.cbbDVT_SelectedIndexChanged);
            // 
            // btOK
            // 
            this.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btOK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btOK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(133, 269);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.TextColor = System.Drawing.Color.White;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(238, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX1.Location = new System.Drawing.Point(342, 174);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(194, 32);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Ảnh thực đơn";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FormThemThucDon
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(564, 303);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbbDVT);
            this.Controls.Add(this.cbbLoaiTD);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtThemThucDon);
            this.Controls.Add(this.labelGiamGia);
            this.Controls.Add(this.labelGiaBan);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelTD);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhà Hàng QQDKT";
            this.Load += new System.EventHandler(this.FormThemThucDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelTD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThemThucDon;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelGiaBan;
        private DevComponents.DotNetBar.LabelX labelGiamGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiamGia;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLoaiTD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbDVT;
        private DevComponents.DotNetBar.ButtonX btOK;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}