namespace Restaurant
{
    partial class FormSuaLoaiMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaLoaiMonAn));
            this.btnDongYSuaLTD = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyboLoaiTD = new DevComponents.DotNetBar.ButtonX();
            this.txtTenLoaiTD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnDongYSuaLTD
            // 
            this.btnDongYSuaLTD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongYSuaLTD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDongYSuaLTD.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnDongYSuaLTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongYSuaLTD.Location = new System.Drawing.Point(75, 86);
            this.btnDongYSuaLTD.Name = "btnDongYSuaLTD";
            this.btnDongYSuaLTD.Size = new System.Drawing.Size(75, 28);
            this.btnDongYSuaLTD.Symbol = "";
            this.btnDongYSuaLTD.SymbolSize = 13F;
            this.btnDongYSuaLTD.TabIndex = 13;
            this.btnDongYSuaLTD.Text = "Đồng ý";
            this.btnDongYSuaLTD.TextColor = System.Drawing.Color.White;
            this.btnDongYSuaLTD.Click += new System.EventHandler(this.btnDongYSuaLTD_Click);
            // 
            // btnHuyboLoaiTD
            // 
            this.btnHuyboLoaiTD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyboLoaiTD.BackColor = System.Drawing.Color.Chocolate;
            this.btnHuyboLoaiTD.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnHuyboLoaiTD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyboLoaiTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyboLoaiTD.Location = new System.Drawing.Point(156, 86);
            this.btnHuyboLoaiTD.Name = "btnHuyboLoaiTD";
            this.btnHuyboLoaiTD.Size = new System.Drawing.Size(75, 28);
            this.btnHuyboLoaiTD.Symbol = "";
            this.btnHuyboLoaiTD.SymbolSize = 13F;
            this.btnHuyboLoaiTD.TabIndex = 14;
            this.btnHuyboLoaiTD.Text = "Hủy bỏ";
            this.btnHuyboLoaiTD.TextColor = System.Drawing.Color.White;
            // 
            // txtTenLoaiTD
            // 
            this.txtTenLoaiTD.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenLoaiTD.Border.Class = "TextBoxBorder";
            this.txtTenLoaiTD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiTD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiTD.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiTD.Location = new System.Drawing.Point(43, 46);
            this.txtTenLoaiTD.Multiline = true;
            this.txtTenLoaiTD.Name = "txtTenLoaiTD";
            this.txtTenLoaiTD.Size = new System.Drawing.Size(246, 26);
            this.txtTenLoaiTD.TabIndex = 12;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(43, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Nhập Tên Loại Thực Đơn:";
            // 
            // FormSuaLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 118);
            this.Controls.Add(this.btnDongYSuaLTD);
            this.Controls.Add(this.btnHuyboLoaiTD);
            this.Controls.Add(this.txtTenLoaiTD);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuaLoaiMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhà Hàng QQDKT";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDongYSuaLTD;
        private DevComponents.DotNetBar.ButtonX btnHuyboLoaiTD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiTD;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}