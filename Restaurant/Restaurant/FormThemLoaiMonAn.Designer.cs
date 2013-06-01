namespace Restaurant
{
    partial class FormThemLoaiMonAn
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtLoaiMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnno = new DevComponents.DotNetBar.ButtonX();
            this.btndongy = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(116, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(137, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nhap ten loai mon an";
            // 
            // txtLoaiMonAn
            // 
            this.txtLoaiMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLoaiMonAn.Border.Class = "TextBoxBorder";
            this.txtLoaiMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoaiMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiMonAn.Location = new System.Drawing.Point(85, 43);
            this.txtLoaiMonAn.Name = "txtLoaiMonAn";
            this.txtLoaiMonAn.Size = new System.Drawing.Size(182, 22);
            this.txtLoaiMonAn.TabIndex = 1;
            // 
            // btnno
            // 
            this.btnno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnno.Location = new System.Drawing.Point(225, 80);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(90, 44);
            this.btnno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnno.TabIndex = 2;
            this.btnno.Text = "Cancel";
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btndongy
            // 
            this.btndongy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndongy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndongy.Location = new System.Drawing.Point(99, 80);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(90, 44);
            this.btndongy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndongy.TabIndex = 2;
            this.btndongy.Text = "Dong y";
            // 
            // FormThemLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 153);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.txtLoaiMonAn);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormThemLoaiMonAn";
            this.Text = "MetroForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoaiMonAn;
        private DevComponents.DotNetBar.ButtonX btnno;
        private DevComponents.DotNetBar.ButtonX btndongy;
    }
}