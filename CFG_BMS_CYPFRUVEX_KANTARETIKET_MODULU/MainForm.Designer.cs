namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class MainForm {
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
            DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
            DevExpress.XtraBars.BarButtonItem barButtonItem1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.BarButtonItem barButtonItem2;
            DevExpress.XtraBars.BarButtonItem barButtonItem3;
            DevExpress.XtraBars.BarButtonItem barButtonItem4;
            DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
            DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
            DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
            this.SB_KULLANICILAR = new DevExpress.XtraBars.BarButtonItem();
            this.SB_ESLESTIRME = new DevExpress.XtraBars.BarButtonItem();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            ribbonControl1.ExpandCollapseItem,
            ribbonControl1.SearchEditItem,
            barButtonItem1,
            barButtonItem2,
            barButtonItem3,
            barButtonItem4,
            this.SB_KULLANICILAR,
            this.SB_ESLESTIRME});
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            ribbonPage1});
            ribbonControl1.Size = new System.Drawing.Size(910, 150);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Veritabanı,Servis,Kullanıcı Ayarları";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "TABLOLARI OLUŞTUR";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.VisibleInSearchMenu = false;
            barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "KULLANICILAR";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "FIRMA";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // SB_KULLANICILAR
            // 
            this.SB_KULLANICILAR.Caption = "Kullanıcılar";
            this.SB_KULLANICILAR.Id = 5;
            this.SB_KULLANICILAR.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SB_KULLANICILAR.ImageOptions.SvgImage")));
            this.SB_KULLANICILAR.Name = "SB_KULLANICILAR";
            // 
            // SB_ESLESTIRME
            // 
            this.SB_ESLESTIRME.Caption = "İşçi Etiket Miktar Eşleştirmesi";
            this.SB_ESLESTIRME.Id = 6;
            this.SB_ESLESTIRME.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SB_ESLESTIRME.ImageOptions.SvgImage")));
            this.SB_ESLESTIRME.Name = "SB_ESLESTIRME";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            ribbonPageGroup1});
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Ayarlar";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 565);
            this.Controls.Add(ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS KANTAR ETIKET MODULU - AYARLAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem SB_KULLANICILAR;
        private DevExpress.XtraBars.BarButtonItem SB_ESLESTIRME;
    }
}