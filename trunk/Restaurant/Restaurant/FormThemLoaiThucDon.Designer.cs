namespace Restaurant
{
    partial class FormThemLoaiThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemLoaiThucDon));
            this.btnDongYLoaiTD = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyboLoaiTD = new DevComponents.DotNetBar.ButtonX();
            this.txtLoaiThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnDongYLoaiTD
            // 
            this.btnDongYLoaiTD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongYLoaiTD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDongYLoaiTD.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnDongYLoaiTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongYLoaiTD.Location = new System.Drawing.Point(92, 79);
            this.btnDongYLoaiTD.Name = "btnDongYLoaiTD";
            this.btnDongYLoaiTD.Size = new System.Drawing.Size(75, 28);
            this.btnDongYLoaiTD.Symbol = "";
            this.btnDongYLoaiTD.SymbolSize = 13F;
            this.btnDongYLoaiTD.TabIndex = 9;
            this.btnDongYLoaiTD.Text = "Đồng ý";
            this.btnDongYLoaiTD.TextColor = System.Drawing.Color.White;
            this.btnDongYLoaiTD.Click += new System.EventHandler(this.btnDongYLoaiTD_Click);
            // 
            // btnHuyboLoaiTD
            // 
            this.btnHuyboLoaiTD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyboLoaiTD.BackColor = System.Drawing.Color.Chocolate;
            this.btnHuyboLoaiTD.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnHuyboLoaiTD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyboLoaiTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyboLoaiTD.Location = new System.Drawing.Point(173, 79);
            this.btnHuyboLoaiTD.Name = "btnHuyboLoaiTD";
            this.btnHuyboLoaiTD.Size = new System.Drawing.Size(75, 28);
            this.btnHuyboLoaiTD.Symbol = "";
            this.btnHuyboLoaiTD.SymbolSize = 13F;
            this.btnHuyboLoaiTD.TabIndex = 10;
            this.btnHuyboLoaiTD.Text = "Hủy bỏ";
            this.btnHuyboLoaiTD.TextColor = System.Drawing.Color.White;
            this.btnHuyboLoaiTD.Click += new System.EventHandler(this.btnHuyboLoaiTD_Click);
            // 
            // txtLoaiThucDon
            // 
            this.txtLoaiThucDon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLoaiThucDon.Border.Class = "TextBoxBorder";
            this.txtLoaiThucDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoaiThucDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiThucDon.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiThucDon.Location = new System.Drawing.Point(49, 39);
            this.txtLoaiThucDon.Multiline = true;
            this.txtLoaiThucDon.Name = "txtLoaiThucDon";
            this.txtLoaiThucDon.Size = new System.Drawing.Size(246, 26);
            this.txtLoaiThucDon.TabIndex = 8;
            this.txtLoaiThucDon.TextChanged += new System.EventHandler(this.txtLoaiThucDon_TextChanged);
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
            this.labelX1.Location = new System.Drawing.Point(49, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Nhập Tên Loại Thực Đơn:";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // FormThemLoaiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 112);
            this.Controls.Add(this.btnDongYLoaiTD);
            this.Controls.Add(this.btnHuyboLoaiTD);
            this.Controls.Add(this.txtLoaiThucDon);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemLoaiThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhà Hàng QQDKT";
            this.Load += new System.EventHandler(this.FormThemLoaiThucDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDongYLoaiTD;
        private DevComponents.DotNetBar.ButtonX btnHuyboLoaiTD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoaiThucDon;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}