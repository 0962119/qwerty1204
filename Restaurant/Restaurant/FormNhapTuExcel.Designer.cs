namespace Restaurant
{
    partial class FormNhapTuExcel
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
            this.txtLinkExcel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBrowser = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnOKNhapExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelExcel = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSheetName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txtLinkExcel
            // 
            this.txtLinkExcel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLinkExcel.Border.Class = "TextBoxBorder";
            this.txtLinkExcel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLinkExcel.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLinkExcel.ForeColor = System.Drawing.Color.Black;
            this.txtLinkExcel.Location = new System.Drawing.Point(42, 127);
            this.txtLinkExcel.Name = "txtLinkExcel";
            this.txtLinkExcel.Size = new System.Drawing.Size(357, 22);
            this.txtLinkExcel.TabIndex = 0;
            // 
            // btnBrowser
            // 
            this.btnBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBrowser.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(406, 126);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnBrowser.Symbol = "";
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(42, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Đường dẫn:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(42, 227);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(469, 36);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Lưu ý: File Excel thực đơn phải được trình bày như file thực đơn mẫu mà chúng tôi" +
    " cung cấp! ";
            this.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnOKNhapExcel
            // 
            this.btnOKNhapExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOKNhapExcel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOKNhapExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnOKNhapExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKNhapExcel.Location = new System.Drawing.Point(163, 279);
            this.btnOKNhapExcel.Name = "btnOKNhapExcel";
            this.btnOKNhapExcel.Size = new System.Drawing.Size(75, 23);
            this.btnOKNhapExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnOKNhapExcel.TabIndex = 4;
            this.btnOKNhapExcel.Text = "OK";
            this.btnOKNhapExcel.TextColor = System.Drawing.Color.White;
            this.btnOKNhapExcel.Click += new System.EventHandler(this.btnOKNhapExcel_Click);
            // 
            // btnCancelExcel
            // 
            this.btnCancelExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelExcel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnCancelExcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelExcel.Location = new System.Drawing.Point(270, 279);
            this.btnCancelExcel.Name = "btnCancelExcel";
            this.btnCancelExcel.Size = new System.Drawing.Size(75, 23);
            this.btnCancelExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelExcel.TabIndex = 4;
            this.btnCancelExcel.Text = "Cancel";
            this.btnCancelExcel.TextColor = System.Drawing.Color.White;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(42, 165);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "SheetName:";
            // 
            // txtSheetName
            // 
            this.txtSheetName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSheetName.Border.Class = "TextBoxBorder";
            this.txtSheetName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSheetName.ForeColor = System.Drawing.Color.Black;
            this.txtSheetName.Location = new System.Drawing.Point(42, 189);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(357, 22);
            this.txtSheetName.TabIndex = 6;
            // 
            // FormNhapTuExcel
            // 
            this.AcceptButton = this.btnOKNhapExcel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelExcel;
            this.ClientSize = new System.Drawing.Size(509, 320);
            this.Controls.Add(this.txtSheetName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnCancelExcel);
            this.Controls.Add(this.btnOKNhapExcel);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtLinkExcel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhapTuExcel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhà Hàng QQDKT";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtLinkExcel;
        private DevComponents.DotNetBar.ButtonX btnBrowser;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnOKNhapExcel;
        private DevComponents.DotNetBar.ButtonX btnCancelExcel;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSheetName;
    }
}