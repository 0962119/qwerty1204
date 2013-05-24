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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHinhThucBC = new System.Windows.Forms.Label();
            this.lbTieuDeDT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxHinhThucBC = new System.Windows.Forms.ComboBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgBaoCaoDT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnXuatEx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoCaoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày lập:";
            // 
            // lbHinhThucBC
            // 
            this.lbHinhThucBC.AutoSize = true;
            this.lbHinhThucBC.Location = new System.Drawing.Point(18, 95);
            this.lbHinhThucBC.Name = "lbHinhThucBC";
            this.lbHinhThucBC.Size = new System.Drawing.Size(98, 13);
            this.lbHinhThucBC.TabIndex = 4;
            this.lbHinhThucBC.Text = "Hình thức báo cáo:";
            // 
            // lbTieuDeDT
            // 
            this.lbTieuDeDT.AutoSize = true;
            this.lbTieuDeDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTieuDeDT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeDT.Location = new System.Drawing.Point(176, 33);
            this.lbTieuDeDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTieuDeDT.Name = "lbTieuDeDT";
            this.lbTieuDeDT.Size = new System.Drawing.Size(243, 27);
            this.lbTieuDeDT.TabIndex = 2;
            this.lbTieuDeDT.Text = "BÁO CÁO DOANH THU";
            this.lbTieuDeDT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến ngày:";
            // 
            // cbxHinhThucBC
            // 
            this.cbxHinhThucBC.FormattingEnabled = true;
            this.cbxHinhThucBC.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tuần",
            "Theo tháng",
            "Theo quý",
            "Theo năm",
            "<Thời gian bất kỳ>"});
            this.cbxHinhThucBC.Location = new System.Drawing.Point(122, 91);
            this.cbxHinhThucBC.Name = "cbxHinhThucBC";
            this.cbxHinhThucBC.Size = new System.Drawing.Size(121, 21);
            this.cbxHinhThucBC.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(122, 122);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(121, 20);
            this.dtpTuNgay.TabIndex = 6;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(412, 121);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(121, 20);
            this.dtpDenNgay.TabIndex = 6;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(412, 92);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayLap.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgBaoCaoDT);
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 389);
            this.panel1.TabIndex = 7;
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
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(344, 169);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.Location = new System.Drawing.Point(434, 169);
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.Size = new System.Drawing.Size(99, 23);
            this.btnXuatEx.TabIndex = 8;
            this.btnXuatEx.Text = "Xuất ra Excel";
            this.btnXuatEx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng hóa đơn:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(416, 602);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(128, 20);
            this.txtSoHD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng Doanh Thu:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(416, 630);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(128, 20);
            this.txtDoanhThu.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "VNĐ";
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 662);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuatEx);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.cbxHinhThucBC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHinhThucBC);
            this.Controls.Add(this.lbTieuDeDT);
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoCaoDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHinhThucBC;
        private System.Windows.Forms.Label lbTieuDeDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxHinhThucBC;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgBaoCaoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnXuatEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label6;
    }
}