namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_TANIMLAMALAR_ISCIETIKETMIKTAR {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TANIMLAMALAR_ISCIETIKETMIKTAR));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.GRC_KANTAR_KONTRAKTOR = new DevExpress.XtraGrid.GridControl();
            this.GRV_KANTAR_KONTRAKTOR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRC_KANTAR_KONTRAKTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_KANTAR_KONTRAKTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(530, 39);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.GRC_KANTAR_KONTRAKTOR);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(530, 400);
            this.panelControl2.TabIndex = 1;
            // 
            // GRC_KANTAR_KONTRAKTOR
            // 
            this.GRC_KANTAR_KONTRAKTOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRC_KANTAR_KONTRAKTOR.Location = new System.Drawing.Point(2, 2);
            this.GRC_KANTAR_KONTRAKTOR.MainView = this.GRV_KANTAR_KONTRAKTOR;
            this.GRC_KANTAR_KONTRAKTOR.Name = "GRC_KANTAR_KONTRAKTOR";
            this.GRC_KANTAR_KONTRAKTOR.Size = new System.Drawing.Size(526, 396);
            this.GRC_KANTAR_KONTRAKTOR.TabIndex = 0;
            this.GRC_KANTAR_KONTRAKTOR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRV_KANTAR_KONTRAKTOR});
            // 
            // GRV_KANTAR_KONTRAKTOR
            // 
            this.GRV_KANTAR_KONTRAKTOR.GridControl = this.GRC_KANTAR_KONTRAKTOR;
            this.GRV_KANTAR_KONTRAKTOR.Name = "GRV_KANTAR_KONTRAKTOR";
            this.GRV_KANTAR_KONTRAKTOR.OptionsBehavior.Editable = false;
            this.GRV_KANTAR_KONTRAKTOR.OptionsView.ColumnAutoWidth = false;
            this.GRV_KANTAR_KONTRAKTOR.OptionsView.ShowGroupPanel = false;
            this.GRV_KANTAR_KONTRAKTOR.DoubleClick += new System.EventHandler(this.GRV_KANTAR_PLAKA_DoubleClick);
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 439);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(530, 41);
            this.panelControl3.TabIndex = 2;
            // 
            // FRM_TANIMLAMALAR_ISCIETIKETMIKTAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 480);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FRM_TANIMLAMALAR_ISCIETIKETMIKTAR.IconOptions.SvgImage")));
            this.Name = "FRM_TANIMLAMALAR_ISCIETIKETMIKTAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞÇİ ETİKET MİKTAR EŞLEŞTİRME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_KANTARPLAKA_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRC_KANTAR_KONTRAKTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_KANTAR_KONTRAKTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl GRC_KANTAR_KONTRAKTOR;
        private DevExpress.XtraGrid.Views.Grid.GridView GRV_KANTAR_KONTRAKTOR;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}