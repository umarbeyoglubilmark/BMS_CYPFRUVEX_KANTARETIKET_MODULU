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
            this.TE_SICILNO = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR = new DevExpress.XtraGrid.GridControl();
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GR_LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_SICILNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_ADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_ETIKETMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BTN_UA = new System.Windows.Forms.Button();
            this.LBL_LOGICALREF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TE_ADSOYAD = new System.Windows.Forms.TextBox();
            this.TE_MIKTAR = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TE_SICILNO
            // 
            this.TE_SICILNO.Location = new System.Drawing.Point(111, 39);
            this.TE_SICILNO.Name = "TE_SICILNO";
            this.TE_SICILNO.ReadOnly = true;
            this.TE_SICILNO.Size = new System.Drawing.Size(261, 21);
            this.TE_SICILNO.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 273);
            this.panel2.TabIndex = 5;
            // 
            // GRC_TANIMLAMALAR_ISCIETIKETMIKTAR
            // 
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.Location = new System.Drawing.Point(0, 0);
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.MainView = this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR;
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.Name = "GRC_TANIMLAMALAR_ISCIETIKETMIKTAR";
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.Size = new System.Drawing.Size(568, 273);
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.TabIndex = 0;
            this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR});
            // 
            // GRV_TANIMLAMALAR_ISCIETIKETMIKTAR
            // 
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GR_LOGICALREF,
            this.GR_SICILNO,
            this.GR_ADSOYAD,
            this.GR_ETIKETMIKTAR});
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.GridControl = this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR;
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.Name = "GRV_TANIMLAMALAR_ISCIETIKETMIKTAR";
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.OptionsBehavior.Editable = false;
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.OptionsCustomization.AllowSort = false;
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.OptionsView.ColumnAutoWidth = false;
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.OptionsView.ShowFooter = true;
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.OptionsView.ShowGroupPanel = false;
            this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.DoubleClick += new System.EventHandler(this.GRV_TANIMLAMALAR_KULLANICILAR_DoubleClick);
            // 
            // GR_LOGICALREF
            // 
            this.GR_LOGICALREF.Caption = "LOGICALREF";
            this.GR_LOGICALREF.FieldName = "LOGICALREF";
            this.GR_LOGICALREF.Name = "GR_LOGICALREF";
            this.GR_LOGICALREF.OptionsColumn.AllowEdit = false;
            this.GR_LOGICALREF.Width = 96;
            // 
            // GR_SICILNO
            // 
            this.GR_SICILNO.Caption = "Sicil No";
            this.GR_SICILNO.FieldName = "SICILNO";
            this.GR_SICILNO.Name = "GR_SICILNO";
            this.GR_SICILNO.OptionsColumn.AllowEdit = false;
            this.GR_SICILNO.Visible = true;
            this.GR_SICILNO.VisibleIndex = 0;
            this.GR_SICILNO.Width = 159;
            // 
            // GR_ADSOYAD
            // 
            this.GR_ADSOYAD.Caption = "Ad Soyad";
            this.GR_ADSOYAD.FieldName = "ADSOYAD";
            this.GR_ADSOYAD.Name = "GR_ADSOYAD";
            this.GR_ADSOYAD.OptionsColumn.AllowEdit = false;
            this.GR_ADSOYAD.Visible = true;
            this.GR_ADSOYAD.VisibleIndex = 1;
            // 
            // GR_ETIKETMIKTAR
            // 
            this.GR_ETIKETMIKTAR.Caption = "Miktar";
            this.GR_ETIKETMIKTAR.FieldName = "ETIKETMIKTAR";
            this.GR_ETIKETMIKTAR.Name = "GR_ETIKETMIKTAR";
            this.GR_ETIKETMIKTAR.OptionsColumn.AllowEdit = false;
            this.GR_ETIKETMIKTAR.Visible = true;
            this.GR_ETIKETMIKTAR.VisibleIndex = 2;
            // 
            // BTN_UA
            // 
            this.BTN_UA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UA.Location = new System.Drawing.Point(378, 42);
            this.BTN_UA.Name = "BTN_UA";
            this.BTN_UA.Size = new System.Drawing.Size(140, 71);
            this.BTN_UA.TabIndex = 7;
            this.BTN_UA.Text = "Güncelle";
            this.BTN_UA.UseVisualStyleBackColor = true;
            this.BTN_UA.Click += new System.EventHandler(this.BTN_UA_Click);
            // 
            // LBL_LOGICALREF
            // 
            this.LBL_LOGICALREF.AutoSize = true;
            this.LBL_LOGICALREF.Location = new System.Drawing.Point(108, 9);
            this.LBL_LOGICALREF.Name = "LBL_LOGICALREF";
            this.LBL_LOGICALREF.Size = new System.Drawing.Size(0, 13);
            this.LBL_LOGICALREF.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGICALREF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miktar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sicil No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TE_ADSOYAD);
            this.panel1.Controls.Add(this.BTN_UA);
            this.panel1.Controls.Add(this.LBL_LOGICALREF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TE_MIKTAR);
            this.panel1.Controls.Add(this.TE_SICILNO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 128);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ad Soyad:";
            // 
            // TE_ADSOYAD
            // 
            this.TE_ADSOYAD.Location = new System.Drawing.Point(111, 66);
            this.TE_ADSOYAD.Name = "TE_ADSOYAD";
            this.TE_ADSOYAD.ReadOnly = true;
            this.TE_ADSOYAD.Size = new System.Drawing.Size(261, 21);
            this.TE_ADSOYAD.TabIndex = 8;
            // 
            // TE_MIKTAR
            // 
            this.TE_MIKTAR.Location = new System.Drawing.Point(111, 93);
            this.TE_MIKTAR.Name = "TE_MIKTAR";
            this.TE_MIKTAR.Size = new System.Drawing.Size(261, 21);
            this.TE_MIKTAR.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 100);
            this.panel3.TabIndex = 4;
            // 
            // FRM_TANIMLAMALAR_ISCIETIKETMIKTAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FRM_TANIMLAMALAR_ISCIETIKETMIKTAR.IconOptions.SvgImage")));
            this.Name = "FRM_TANIMLAMALAR_ISCIETIKETMIKTAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞÇİ ETİKET MİKTAR EŞLEŞTİRME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_KANTARPLAKA_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRC_TANIMLAMALAR_ISCIETIKETMIKTAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_TANIMLAMALAR_ISCIETIKETMIKTAR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TE_SICILNO;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl GRC_TANIMLAMALAR_ISCIETIKETMIKTAR;
        private DevExpress.XtraGrid.Views.Grid.GridView GRV_TANIMLAMALAR_ISCIETIKETMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn GR_LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn GR_SICILNO;
        private DevExpress.XtraGrid.Columns.GridColumn GR_ADSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn GR_ETIKETMIKTAR;
        private System.Windows.Forms.Button BTN_UA;
        private System.Windows.Forms.Label LBL_LOGICALREF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TE_MIKTAR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TE_ADSOYAD;
    }
}