namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_KANTARBARKOD {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KANTARBARKOD));
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.SB_YAZDIR = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SB_YAZDIR
            // 
            this.SB_YAZDIR.Appearance.BackColor = System.Drawing.Color.Aquamarine;
            this.SB_YAZDIR.Appearance.BorderColor = System.Drawing.Color.Black;
            this.SB_YAZDIR.Appearance.Font = new System.Drawing.Font("Tahoma", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SB_YAZDIR.Appearance.Options.UseBackColor = true;
            this.SB_YAZDIR.Appearance.Options.UseBorderColor = true;
            this.SB_YAZDIR.Appearance.Options.UseFont = true;
            this.SB_YAZDIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SB_YAZDIR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SB_YAZDIR.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.SB_YAZDIR.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SB_eXCELEKAYDET.ImageOptions.SvgImage")));
            this.SB_YAZDIR.Location = new System.Drawing.Point(0, 420);
            this.SB_YAZDIR.Name = "SB_YAZDIR";
            this.SB_YAZDIR.Size = new System.Drawing.Size(449, 70);
            this.SB_YAZDIR.TabIndex = 13;
            this.SB_YAZDIR.Text = "YAZDIR";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.barCodeControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(449, 420);
            this.panelControl1.TabIndex = 14;
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barCodeControl1.Appearance.Options.UseFont = true;
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.Location = new System.Drawing.Point(2, 2);
            this.barCodeControl1.Module = 8D;
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.ShowText = false;
            this.barCodeControl1.Size = new System.Drawing.Size(445, 416);
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version3;
            this.barCodeControl1.Symbology = qrCodeGenerator1;
            this.barCodeControl1.TabIndex = 1;
            this.barCodeControl1.VerticalTextAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // FRM_KANTARBARKOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 490);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.SB_YAZDIR);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FRM_KANTARBARKOD.IconOptions.SvgImage")));
            this.Name = "FRM_KANTARBARKOD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCODE";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton SB_YAZDIR;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
    }
}