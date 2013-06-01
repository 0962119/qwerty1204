namespace Restaurant
{
    partial class frmChiTietHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietPhieuTinhTien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.lbTongTien = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.lbTongTienThanhToan = new DevComponents.DotNetBar.LabelX();
            this.lbThoiGian = new DevComponents.DotNetBar.LabelX();
            this.lbBan = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lbNhanVien = new DevComponents.DotNetBar.LabelX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuTinhTien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietPhieuTinhTien
            // 
            this.dgvChiTietPhieuTinhTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuTinhTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonAn,
            this.SoLuong,
            this.Column5,
            this.Column6,
            this.DonGia,
            this.Column3,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietPhieuTinhTien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietPhieuTinhTien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvChiTietPhieuTinhTien.Location = new System.Drawing.Point(4, 84);
            this.dgvChiTietPhieuTinhTien.Name = "dgvChiTietPhieuTinhTien";
            this.dgvChiTietPhieuTinhTien.Size = new System.Drawing.Size(617, 245);
            this.dgvChiTietPhieuTinhTien.TabIndex = 0;
            // 
            // MonAn
            // 
            this.MonAn.DataPropertyName = "MonAn";
            this.MonAn.HeaderText = "Tên món ăn";
            this.MonAn.Name = "MonAn";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiamGia";
            this.Column5.HeaderText = "Giảm giá";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "VAT";
            this.Column6.HeaderText = "VAT";
            this.Column6.Name = "Column6";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ThanhTien";
            this.Column3.HeaderText = "Tổng tiền";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaPhieuTT";
            this.Column2.HeaderText = "maphieu";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // lb
            // 
            // 
            // 
            // 
            this.lb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb.Location = new System.Drawing.Point(1, -4);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(75, 27);
            this.lb.TabIndex = 1;
            this.lb.Text = "Thời gian:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(371, -4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(29, 27);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Bàn:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 51);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 27);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Ghi chú:";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(298, 343);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 27);
            this.labelX10.TabIndex = 1;
            this.labelX10.Text = "Tổng tiền:";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(464, 343);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 27);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "VNĐ";
            // 
            // lbTongTien
            // 
            // 
            // 
            // 
            this.lbTongTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTongTien.Location = new System.Drawing.Point(359, 343);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(99, 27);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = ".........";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(298, 374);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(114, 27);
            this.labelX13.TabIndex = 1;
            this.labelX13.Text = "Tổng tiền thanh toán:";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(464, 398);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(75, 27);
            this.labelX14.TabIndex = 1;
            this.labelX14.Text = "VNĐ";
            // 
            // lbTongTienThanhToan
            // 
            // 
            // 
            // 
            this.lbTongTienThanhToan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTongTienThanhToan.Location = new System.Drawing.Point(359, 398);
            this.lbTongTienThanhToan.Name = "lbTongTienThanhToan";
            this.lbTongTienThanhToan.Size = new System.Drawing.Size(99, 27);
            this.lbTongTienThanhToan.TabIndex = 1;
            this.lbTongTienThanhToan.Text = ".........";
            // 
            // lbThoiGian
            // 
            // 
            // 
            // 
            this.lbThoiGian.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbThoiGian.Location = new System.Drawing.Point(73, -4);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(190, 27);
            this.lbThoiGian.TabIndex = 1;
            this.lbThoiGian.Text = ".............";
            // 
            // lbBan
            // 
            // 
            // 
            // 
            this.lbBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbBan.Location = new System.Drawing.Point(406, -4);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(133, 27);
            this.lbBan.TabIndex = 1;
            this.lbBan.Text = "..........";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(342, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 27);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Nhân viên:";
            // 
            // lbNhanVien
            // 
            // 
            // 
            // 
            this.lbNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbNhanVien.Location = new System.Drawing.Point(406, 29);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(133, 27);
            this.lbNhanVien.TabIndex = 1;
            this.lbNhanVien.Text = "..........";
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 429);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lbTongTienThanhToan);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.dgvChiTietPhieuTinhTien);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuTinhTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChiTietPhieuTinhTien;
        private DevComponents.DotNetBar.LabelX lb;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX lbTongTien;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX lbTongTienThanhToan;
        private DevComponents.DotNetBar.LabelX lbThoiGian;
        private DevComponents.DotNetBar.LabelX lbBan;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lbNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
    }
}