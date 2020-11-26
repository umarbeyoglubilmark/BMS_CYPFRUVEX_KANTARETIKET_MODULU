namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_KANTARY {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KANTAR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SB_eXCELEKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.CB_MARKET5 = new DevExpress.XtraEditors.CheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.CMS_ENTEGRASYON_GECMISI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BTN_MARKETENTEGRASYONGECMISI = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_MARKET4 = new DevExpress.XtraEditors.CheckEdit();
            this.CB_MARKET3 = new DevExpress.XtraEditors.CheckEdit();
            this.CB_MARKET2 = new DevExpress.XtraEditors.CheckEdit();
            this.CB_MARKET1 = new DevExpress.XtraEditors.CheckEdit();
            this.BTN_URUNFIYATGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_URUNSATISAKAPAT = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_URUNSATISAAC = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_URUNSIL = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRC_MALZEMELISTESI = new DevExpress.XtraGrid.GridControl();
            this.GRV_MALZEMELISTESI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.CMS_ENTEGRASYON_GECMISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRC_MALZEMELISTESI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_MALZEMELISTESI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SB_eXCELEKAYDET);
            this.panel1.Controls.Add(this.CB_MARKET5);
            this.panel1.Controls.Add(this.CB_MARKET4);
            this.panel1.Controls.Add(this.CB_MARKET3);
            this.panel1.Controls.Add(this.CB_MARKET2);
            this.panel1.Controls.Add(this.CB_MARKET1);
            this.panel1.Controls.Add(this.BTN_URUNFIYATGUNCELLE);
            this.panel1.Controls.Add(this.BTN_URUNSATISAKAPAT);
            this.panel1.Controls.Add(this.BTN_URUNSATISAAC);
            this.panel1.Controls.Add(this.BTN_URUNSIL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 106);
            this.panel1.TabIndex = 0;
            // 
            // SB_eXCELEKAYDET
            // 
            this.SB_eXCELEKAYDET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SB_eXCELEKAYDET.Dock = System.Windows.Forms.DockStyle.Right;
            this.SB_eXCELEKAYDET.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SB_eXCELEKAYDET.ImageOptions.SvgImage")));
            this.SB_eXCELEKAYDET.Location = new System.Drawing.Point(984, 0);
            this.SB_eXCELEKAYDET.Name = "SB_eXCELEKAYDET";
            this.SB_eXCELEKAYDET.Size = new System.Drawing.Size(123, 106);
            this.SB_eXCELEKAYDET.TabIndex = 9;
            this.SB_eXCELEKAYDET.Text = "Excele Kaydet";
            this.SB_eXCELEKAYDET.Click += new System.EventHandler(this.SB_eXCELEKAYDET_Click);
            // 
            // CB_MARKET5
            // 
            this.CB_MARKET5.Location = new System.Drawing.Point(431, 83);
            this.CB_MARKET5.MenuManager = this.barManager1;
            this.CB_MARKET5.Name = "CB_MARKET5";
            this.CB_MARKET5.Properties.Caption = "";
            this.CB_MARKET5.Properties.ContextMenuStrip = this.CMS_ENTEGRASYON_GECMISI;
            this.CB_MARKET5.Size = new System.Drawing.Size(269, 20);
            this.CB_MARKET5.TabIndex = 8;
            this.CB_MARKET5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CB_MARKET5_MouseDown);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "MODUL";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "SORGU";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1107, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 522);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1107, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1107, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // CMS_ENTEGRASYON_GECMISI
            // 
            this.CMS_ENTEGRASYON_GECMISI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_MARKETENTEGRASYONGECMISI});
            this.CMS_ENTEGRASYON_GECMISI.Name = "CMS_ENTEGRASYON_GECMISI";
            this.CMS_ENTEGRASYON_GECMISI.Size = new System.Drawing.Size(254, 26);
            // 
            // BTN_MARKETENTEGRASYONGECMISI
            // 
            this.BTN_MARKETENTEGRASYONGECMISI.Name = "BTN_MARKETENTEGRASYONGECMISI";
            this.BTN_MARKETENTEGRASYONGECMISI.Size = new System.Drawing.Size(253, 22);
            this.BTN_MARKETENTEGRASYONGECMISI.Text = "MARKET ENTEGRASYON GEÇMİŞİ";
            this.BTN_MARKETENTEGRASYONGECMISI.Click += new System.EventHandler(this.mARKETENTEGRASYONGEÇMİŞİToolStripMenuItem_Click);
            // 
            // CB_MARKET4
            // 
            this.CB_MARKET4.Location = new System.Drawing.Point(431, 63);
            this.CB_MARKET4.MenuManager = this.barManager1;
            this.CB_MARKET4.Name = "CB_MARKET4";
            this.CB_MARKET4.Properties.Caption = "";
            this.CB_MARKET4.Properties.ContextMenuStrip = this.CMS_ENTEGRASYON_GECMISI;
            this.CB_MARKET4.Size = new System.Drawing.Size(269, 20);
            this.CB_MARKET4.TabIndex = 7;
            this.CB_MARKET4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CB_MARKET4_MouseDown);
            // 
            // CB_MARKET3
            // 
            this.CB_MARKET3.Location = new System.Drawing.Point(431, 43);
            this.CB_MARKET3.MenuManager = this.barManager1;
            this.CB_MARKET3.Name = "CB_MARKET3";
            this.CB_MARKET3.Properties.Caption = "";
            this.CB_MARKET3.Properties.ContextMenuStrip = this.CMS_ENTEGRASYON_GECMISI;
            this.CB_MARKET3.Size = new System.Drawing.Size(269, 20);
            this.CB_MARKET3.TabIndex = 6;
            this.CB_MARKET3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CB_MARKET3_MouseDown);
            // 
            // CB_MARKET2
            // 
            this.CB_MARKET2.Location = new System.Drawing.Point(431, 23);
            this.CB_MARKET2.MenuManager = this.barManager1;
            this.CB_MARKET2.Name = "CB_MARKET2";
            this.CB_MARKET2.Properties.Caption = "";
            this.CB_MARKET2.Properties.ContextMenuStrip = this.CMS_ENTEGRASYON_GECMISI;
            this.CB_MARKET2.Size = new System.Drawing.Size(269, 20);
            this.CB_MARKET2.TabIndex = 5;
            this.CB_MARKET2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CB_MARKET2_MouseDown);
            // 
            // CB_MARKET1
            // 
            this.CB_MARKET1.Location = new System.Drawing.Point(431, 3);
            this.CB_MARKET1.MenuManager = this.barManager1;
            this.CB_MARKET1.Name = "CB_MARKET1";
            this.CB_MARKET1.Properties.Caption = "";
            this.CB_MARKET1.Properties.ContextMenuStrip = this.CMS_ENTEGRASYON_GECMISI;
            this.CB_MARKET1.Size = new System.Drawing.Size(269, 20);
            this.CB_MARKET1.TabIndex = 4;
            this.CB_MARKET1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CB_MARKET1_MouseDown);
            // 
            // BTN_URUNFIYATGUNCELLE
            // 
            this.BTN_URUNFIYATGUNCELLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_URUNFIYATGUNCELLE.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BTN_URUNFIYATGUNCELLE.ImageOptions.SvgImage")));
            this.BTN_URUNFIYATGUNCELLE.Location = new System.Drawing.Point(5, 54);
            this.BTN_URUNFIYATGUNCELLE.Name = "BTN_URUNFIYATGUNCELLE";
            this.BTN_URUNFIYATGUNCELLE.Size = new System.Drawing.Size(207, 43);
            this.BTN_URUNFIYATGUNCELLE.TabIndex = 2;
            this.BTN_URUNFIYATGUNCELLE.Text = "SEÇİLİLERİN FİYATINI GÜNCELLE";
            this.BTN_URUNFIYATGUNCELLE.Click += new System.EventHandler(this.BTN_URUNFIYATGUNCELLE_Click);
            // 
            // BTN_URUNSATISAKAPAT
            // 
            this.BTN_URUNSATISAKAPAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_URUNSATISAKAPAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BTN_URUNSATISAKAPAT.ImageOptions.SvgImage")));
            this.BTN_URUNSATISAKAPAT.Location = new System.Drawing.Point(218, 6);
            this.BTN_URUNSATISAKAPAT.Name = "BTN_URUNSATISAKAPAT";
            this.BTN_URUNSATISAKAPAT.Size = new System.Drawing.Size(207, 43);
            this.BTN_URUNSATISAKAPAT.TabIndex = 1;
            this.BTN_URUNSATISAKAPAT.Text = "SEÇİLİLERİ SATIŞA KAPAT";
            this.BTN_URUNSATISAKAPAT.Click += new System.EventHandler(this.BTN_URUNSATISAKAPAT_Click);
            // 
            // BTN_URUNSATISAAC
            // 
            this.BTN_URUNSATISAAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_URUNSATISAAC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BTN_URUNSATISAAC.ImageOptions.SvgImage")));
            this.BTN_URUNSATISAAC.Location = new System.Drawing.Point(5, 6);
            this.BTN_URUNSATISAAC.Name = "BTN_URUNSATISAAC";
            this.BTN_URUNSATISAAC.Size = new System.Drawing.Size(207, 43);
            this.BTN_URUNSATISAAC.TabIndex = 0;
            this.BTN_URUNSATISAAC.Text = "SEÇİLİLERİ SATIŞA AÇ";
            this.BTN_URUNSATISAAC.Click += new System.EventHandler(this.BTN_URUNSATISAAC_Click);
            // 
            // BTN_URUNSIL
            // 
            this.BTN_URUNSIL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_URUNSIL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BTN_URUNSIL.ImageOptions.SvgImage")));
            this.BTN_URUNSIL.Location = new System.Drawing.Point(218, 54);
            this.BTN_URUNSIL.Name = "BTN_URUNSIL";
            this.BTN_URUNSIL.Size = new System.Drawing.Size(207, 43);
            this.BTN_URUNSIL.TabIndex = 3;
            this.BTN_URUNSIL.Text = "SEÇİLİLERİ SİL";
            this.BTN_URUNSIL.Click += new System.EventHandler(this.BTN_URUNSIL_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GRC_MALZEMELISTESI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 386);
            this.panel2.TabIndex = 1;
            // 
            // GRC_MALZEMELISTESI
            // 
            this.GRC_MALZEMELISTESI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRC_MALZEMELISTESI.Location = new System.Drawing.Point(0, 0);
            this.GRC_MALZEMELISTESI.MainView = this.GRV_MALZEMELISTESI;
            this.GRC_MALZEMELISTESI.Name = "GRC_MALZEMELISTESI";
            this.GRC_MALZEMELISTESI.Size = new System.Drawing.Size(1107, 386);
            this.GRC_MALZEMELISTESI.TabIndex = 0;
            this.GRC_MALZEMELISTESI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRV_MALZEMELISTESI});
            // 
            // GRV_MALZEMELISTESI
            // 
            this.GRV_MALZEMELISTESI.GridControl = this.GRC_MALZEMELISTESI;
            this.GRV_MALZEMELISTESI.Name = "GRV_MALZEMELISTESI";
            this.GRV_MALZEMELISTESI.OptionsBehavior.Editable = false;
            this.GRV_MALZEMELISTESI.OptionsSelection.MultiSelect = true;
            this.GRV_MALZEMELISTESI.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GRV_MALZEMELISTESI.OptionsView.ColumnAutoWidth = false;
            this.GRV_MALZEMELISTESI.OptionsView.ShowFooter = true;
            this.GRV_MALZEMELISTESI.OptionsView.ShowGroupPanel = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 10);
            this.panel3.TabIndex = 2;
            // 
            // FRM_KANTAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FRM_KANTAR";
            this.Text = "KANTAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_MALZEMELISTESI_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.CMS_ENTEGRASYON_GECMISI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_MARKET1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRC_MALZEMELISTESI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_MALZEMELISTESI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl GRC_MALZEMELISTESI;
        private DevExpress.XtraGrid.Views.Grid.GridView GRV_MALZEMELISTESI;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton BTN_URUNSIL;
        private DevExpress.XtraEditors.SimpleButton BTN_URUNSATISAAC;
        private DevExpress.XtraEditors.SimpleButton BTN_URUNSATISAKAPAT;
        private DevExpress.XtraEditors.SimpleButton BTN_URUNFIYATGUNCELLE;
        private DevExpress.XtraEditors.CheckEdit CB_MARKET5;
        private DevExpress.XtraEditors.CheckEdit CB_MARKET4;
        private DevExpress.XtraEditors.CheckEdit CB_MARKET3;
        private DevExpress.XtraEditors.CheckEdit CB_MARKET2;
        private DevExpress.XtraEditors.CheckEdit CB_MARKET1;
        private DevExpress.XtraEditors.SimpleButton SB_eXCELEKAYDET;
        private System.Windows.Forms.ContextMenuStrip CMS_ENTEGRASYON_GECMISI;
        private System.Windows.Forms.ToolStripMenuItem BTN_MARKETENTEGRASYONGECMISI;
    }
}