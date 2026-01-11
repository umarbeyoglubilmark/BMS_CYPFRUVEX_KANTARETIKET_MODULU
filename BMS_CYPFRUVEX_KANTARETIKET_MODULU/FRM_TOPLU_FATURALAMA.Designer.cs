namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_TOPLU_FATURALAMA {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SB_KAPAT = new DevExpress.XtraEditors.SimpleButton();
            this.SB_TOPLU_FATURALA = new DevExpress.XtraEditors.SimpleButton();
            this.SB_SECIMI_KALDIR = new DevExpress.XtraEditors.SimpleButton();
            this.SB_TUMUNU_SEC = new DevExpress.XtraEditors.SimpleButton();
            this.SB_FILTRELE = new DevExpress.XtraEditors.SimpleButton();
            this.DT_BITIS = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.DT_BASLANGIC = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.GRC_KAYITLAR = new DevExpress.XtraGrid.GridControl();
            this.GRV_KAYITLAR = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BITIS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BITIS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BASLANGIC.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BASLANGIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRC_KAYITLAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_KAYITLAR)).BeginInit();
            this.SuspendLayout();
            //
            // panelControl1
            //
            this.panelControl1.Controls.Add(this.SB_KAPAT);
            this.panelControl1.Controls.Add(this.SB_TOPLU_FATURALA);
            this.panelControl1.Controls.Add(this.SB_SECIMI_KALDIR);
            this.panelControl1.Controls.Add(this.SB_TUMUNU_SEC);
            this.panelControl1.Controls.Add(this.SB_FILTRELE);
            this.panelControl1.Controls.Add(this.DT_BITIS);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.DT_BASLANGIC);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1100, 70);
            this.panelControl1.TabIndex = 0;
            //
            // SB_KAPAT
            //
            this.SB_KAPAT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SB_KAPAT.Appearance.Options.UseFont = true;
            this.SB_KAPAT.Location = new System.Drawing.Point(980, 20);
            this.SB_KAPAT.Name = "SB_KAPAT";
            this.SB_KAPAT.Size = new System.Drawing.Size(100, 30);
            this.SB_KAPAT.TabIndex = 8;
            this.SB_KAPAT.Text = "KAPAT";
            this.SB_KAPAT.Click += new System.EventHandler(this.SB_KAPAT_Click);
            //
            // SB_TOPLU_FATURALA
            //
            this.SB_TOPLU_FATURALA.Appearance.BackColor = System.Drawing.Color.Green;
            this.SB_TOPLU_FATURALA.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.SB_TOPLU_FATURALA.Appearance.ForeColor = System.Drawing.Color.White;
            this.SB_TOPLU_FATURALA.Appearance.Options.UseBackColor = true;
            this.SB_TOPLU_FATURALA.Appearance.Options.UseFont = true;
            this.SB_TOPLU_FATURALA.Appearance.Options.UseForeColor = true;
            this.SB_TOPLU_FATURALA.Location = new System.Drawing.Point(780, 20);
            this.SB_TOPLU_FATURALA.Name = "SB_TOPLU_FATURALA";
            this.SB_TOPLU_FATURALA.Size = new System.Drawing.Size(180, 30);
            this.SB_TOPLU_FATURALA.TabIndex = 7;
            this.SB_TOPLU_FATURALA.Text = "TOPLU FATURALA";
            this.SB_TOPLU_FATURALA.Click += new System.EventHandler(this.SB_TOPLU_FATURALA_Click);
            //
            // SB_SECIMI_KALDIR
            //
            this.SB_SECIMI_KALDIR.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SB_SECIMI_KALDIR.Appearance.Options.UseFont = true;
            this.SB_SECIMI_KALDIR.Location = new System.Drawing.Point(640, 20);
            this.SB_SECIMI_KALDIR.Name = "SB_SECIMI_KALDIR";
            this.SB_SECIMI_KALDIR.Size = new System.Drawing.Size(120, 30);
            this.SB_SECIMI_KALDIR.TabIndex = 6;
            this.SB_SECIMI_KALDIR.Text = "Secimi Kaldir";
            this.SB_SECIMI_KALDIR.Click += new System.EventHandler(this.SB_SECIMI_KALDIR_Click);
            //
            // SB_TUMUNU_SEC
            //
            this.SB_TUMUNU_SEC.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SB_TUMUNU_SEC.Appearance.Options.UseFont = true;
            this.SB_TUMUNU_SEC.Location = new System.Drawing.Point(520, 20);
            this.SB_TUMUNU_SEC.Name = "SB_TUMUNU_SEC";
            this.SB_TUMUNU_SEC.Size = new System.Drawing.Size(100, 30);
            this.SB_TUMUNU_SEC.TabIndex = 5;
            this.SB_TUMUNU_SEC.Text = "Tumunu Sec";
            this.SB_TUMUNU_SEC.Click += new System.EventHandler(this.SB_TUMUNU_SEC_Click);
            //
            // SB_FILTRELE
            //
            this.SB_FILTRELE.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SB_FILTRELE.Appearance.Options.UseFont = true;
            this.SB_FILTRELE.Location = new System.Drawing.Point(420, 20);
            this.SB_FILTRELE.Name = "SB_FILTRELE";
            this.SB_FILTRELE.Size = new System.Drawing.Size(80, 30);
            this.SB_FILTRELE.TabIndex = 4;
            this.SB_FILTRELE.Text = "Filtrele";
            this.SB_FILTRELE.Click += new System.EventHandler(this.SB_FILTRELE_Click);
            //
            // DT_BITIS
            //
            this.DT_BITIS.EditValue = null;
            this.DT_BITIS.Location = new System.Drawing.Point(280, 22);
            this.DT_BITIS.Name = "DT_BITIS";
            this.DT_BITIS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DT_BITIS.Properties.Appearance.Options.UseFont = true;
            this.DT_BITIS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DT_BITIS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DT_BITIS.Size = new System.Drawing.Size(120, 24);
            this.DT_BITIS.TabIndex = 3;
            //
            // labelControl2
            //
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(240, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bitis:";
            //
            // DT_BASLANGIC
            //
            this.DT_BASLANGIC.EditValue = null;
            this.DT_BASLANGIC.Location = new System.Drawing.Point(80, 22);
            this.DT_BASLANGIC.Name = "DT_BASLANGIC";
            this.DT_BASLANGIC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DT_BASLANGIC.Properties.Appearance.Options.UseFont = true;
            this.DT_BASLANGIC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DT_BASLANGIC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DT_BASLANGIC.Size = new System.Drawing.Size(120, 24);
            this.DT_BASLANGIC.TabIndex = 1;
            //
            // labelControl1
            //
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Baslangic:";
            //
            // panelControl2
            //
            this.panelControl2.Controls.Add(this.GRC_KAYITLAR);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 70);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1100, 480);
            this.panelControl2.TabIndex = 1;
            //
            // GRC_KAYITLAR
            //
            this.GRC_KAYITLAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRC_KAYITLAR.Location = new System.Drawing.Point(2, 2);
            this.GRC_KAYITLAR.MainView = this.GRV_KAYITLAR;
            this.GRC_KAYITLAR.Name = "GRC_KAYITLAR";
            this.GRC_KAYITLAR.Size = new System.Drawing.Size(1096, 476);
            this.GRC_KAYITLAR.TabIndex = 0;
            this.GRC_KAYITLAR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRV_KAYITLAR});
            //
            // GRV_KAYITLAR
            //
            this.GRV_KAYITLAR.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.GRV_KAYITLAR.Appearance.HeaderPanel.Options.UseFont = true;
            this.GRV_KAYITLAR.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GRV_KAYITLAR.Appearance.Row.Options.UseFont = true;
            this.GRV_KAYITLAR.GridControl = this.GRC_KAYITLAR;
            this.GRV_KAYITLAR.Name = "GRV_KAYITLAR";
            this.GRV_KAYITLAR.OptionsView.ColumnAutoWidth = false;
            this.GRV_KAYITLAR.OptionsView.ShowGroupPanel = false;
            //
            // FRM_TOPLU_FATURALAMA
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FRM_TOPLU_FATURALAMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPLU FATURALAMA";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BITIS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BITIS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BASLANGIC.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BASLANGIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRC_KAYITLAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_KAYITLAR)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl GRC_KAYITLAR;
        private DevExpress.XtraGrid.Views.Grid.GridView GRV_KAYITLAR;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit DT_BASLANGIC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit DT_BITIS;
        private DevExpress.XtraEditors.SimpleButton SB_FILTRELE;
        private DevExpress.XtraEditors.SimpleButton SB_TUMUNU_SEC;
        private DevExpress.XtraEditors.SimpleButton SB_SECIMI_KALDIR;
        private DevExpress.XtraEditors.SimpleButton SB_TOPLU_FATURALA;
        private DevExpress.XtraEditors.SimpleButton SB_KAPAT;
    }
}
