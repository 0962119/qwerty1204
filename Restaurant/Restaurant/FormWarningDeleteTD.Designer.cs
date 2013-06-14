namespace Restaurant
{
    partial class FormWarningDeleteTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarningDeleteTD));
            this.btnNoDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnYesDelete = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnNoDelete
            // 
            this.btnNoDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNoDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNoDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNoDelete.Location = new System.Drawing.Point(146, 74);
            this.btnNoDelete.Name = "btnNoDelete";
            this.btnNoDelete.Size = new System.Drawing.Size(71, 23);
            this.btnNoDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnNoDelete.TabIndex = 3;
            this.btnNoDelete.Text = "No";
            // 
            // btnYesDelete
            // 
            this.btnYesDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYesDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYesDelete.Location = new System.Drawing.Point(65, 74);
            this.btnYesDelete.Name = "btnYesDelete";
            this.btnYesDelete.Size = new System.Drawing.Size(71, 23);
            this.btnYesDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnYesDelete.TabIndex = 4;
            this.btnYesDelete.Text = "Yes";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(-1, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(307, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Bạn có chắc chắn muốn xóa thực đơn đang chọn không?";
            // 
            // FormWarningDeleteTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 99);
            this.Controls.Add(this.btnNoDelete);
            this.Controls.Add(this.btnYesDelete);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWarningDeleteTD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhà Hàng QQDKT";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnNoDelete;
        private DevComponents.DotNetBar.ButtonX btnYesDelete;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}