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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator7 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.SB_YAZDIR = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TE_DPIX = new System.Windows.Forms.TextBox();
            this.TE_DPIY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TE_MARGINBOTTOM = new System.Windows.Forms.TextBox();
            this.TE_MARGINTOP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.SB_YAZDIR.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SB_YAZDIR.ImageOptions.SvgImage")));
            this.SB_YAZDIR.Location = new System.Drawing.Point(0, 420);
            this.SB_YAZDIR.Name = "SB_YAZDIR";
            this.SB_YAZDIR.Size = new System.Drawing.Size(449, 70);
            this.SB_YAZDIR.TabIndex = 13;
            this.SB_YAZDIR.Text = "YAZDIR";
            this.SB_YAZDIR.Click += new System.EventHandler(this.SB_YAZDIR_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.barCodeControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(449, 365);
            this.panelControl1.TabIndex = 14;
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barCodeControl1.Appearance.Options.UseFont = true;
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barCodeControl1.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.Location = new System.Drawing.Point(2, 2);
            this.barCodeControl1.Module = 8D;
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(445, 361);
            qrCodeGenerator7.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Numeric;
            qrCodeGenerator7.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version2;
            this.barCodeControl1.Symbology = qrCodeGenerator7;
            this.barCodeControl1.TabIndex = 1;
            this.barCodeControl1.Text = "123";
            this.barCodeControl1.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.barCodeControl1.VerticalTextAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TE_MARGINBOTTOM);
            this.panel1.Controls.Add(this.TE_MARGINTOP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TE_DPIY);
            this.panel1.Controls.Add(this.TE_DPIX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 55);
            this.panel1.TabIndex = 15;
            // 
            // TE_DPIX
            // 
            this.TE_DPIX.Location = new System.Drawing.Point(39, 3);
            this.TE_DPIX.Name = "TE_DPIX";
            this.TE_DPIX.Size = new System.Drawing.Size(100, 21);
            this.TE_DPIX.TabIndex = 0;
            this.TE_DPIX.TextChanged += new System.EventHandler(this.TE_DPIX_TextChanged);
            // 
            // TE_DPIY
            // 
            this.TE_DPIY.Location = new System.Drawing.Point(39, 28);
            this.TE_DPIY.Name = "TE_DPIY";
            this.TE_DPIY.Size = new System.Drawing.Size(100, 21);
            this.TE_DPIY.TabIndex = 1;
            this.TE_DPIY.TextChanged += new System.EventHandler(this.TE_DPIY_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DPIX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DPIY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MRG BTM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MRG TOP";
            // 
            // TE_MARGINBOTTOM
            // 
            this.TE_MARGINBOTTOM.Location = new System.Drawing.Point(192, 29);
            this.TE_MARGINBOTTOM.Name = "TE_MARGINBOTTOM";
            this.TE_MARGINBOTTOM.Size = new System.Drawing.Size(100, 21);
            this.TE_MARGINBOTTOM.TabIndex = 5;
            this.TE_MARGINBOTTOM.TextChanged += new System.EventHandler(this.TE_MARGINBOTTOM_TextChanged);
            // 
            // TE_MARGINTOP
            // 
            this.TE_MARGINTOP.Location = new System.Drawing.Point(192, 4);
            this.TE_MARGINTOP.Name = "TE_MARGINTOP";
            this.TE_MARGINTOP.Size = new System.Drawing.Size(100, 21);
            this.TE_MARGINTOP.TabIndex = 4;
            this.TE_MARGINTOP.TextChanged += new System.EventHandler(this.TE_MARGINTOP_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ö";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "DESIGNER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_KANTARBARKOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 490);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SB_YAZDIR);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FRM_KANTARBARKOD.IconOptions.SvgImage")));
            this.Name = "FRM_KANTARBARKOD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCODE";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton SB_YAZDIR;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TE_DPIY;
        private System.Windows.Forms.TextBox TE_DPIX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TE_MARGINBOTTOM;
        private System.Windows.Forms.TextBox TE_MARGINTOP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}