namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_ETIKET_ETIKETBAS {
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ETIKET_ETIKETBAS));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRC_ETIKET_ETIKETBAS = new DevExpress.XtraGrid.GridControl();
            this.GRV_ETIKET_ETIKETBAS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GR_LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_SICILNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_ADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_ETIKETMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_GIRISSAAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_ISLEMLER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RI_ETIKETBAS = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRC_ETIKET_ETIKETBAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_ETIKET_ETIKETBAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RI_ETIKETBAS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GRC_ETIKET_ETIKETBAS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 440);
            this.panel2.TabIndex = 5;
            // 
            // GRC_ETIKET_ETIKETBAS
            // 
            this.GRC_ETIKET_ETIKETBAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRC_ETIKET_ETIKETBAS.Location = new System.Drawing.Point(0, 0);
            this.GRC_ETIKET_ETIKETBAS.MainView = this.GRV_ETIKET_ETIKETBAS;
            this.GRC_ETIKET_ETIKETBAS.Name = "GRC_ETIKET_ETIKETBAS";
            this.GRC_ETIKET_ETIKETBAS.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RI_ETIKETBAS});
            this.GRC_ETIKET_ETIKETBAS.Size = new System.Drawing.Size(568, 440);
            this.GRC_ETIKET_ETIKETBAS.TabIndex = 0;
            this.GRC_ETIKET_ETIKETBAS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRV_ETIKET_ETIKETBAS});
            // 
            // GRV_ETIKET_ETIKETBAS
            // 
            this.GRV_ETIKET_ETIKETBAS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GR_LOGICALREF,
            this.GR_SICILNO,
            this.GR_ADSOYAD,
            this.GR_ETIKETMIKTAR,
            this.GR_GIRISSAAT,
            this.GR_ISLEMLER});
            this.GRV_ETIKET_ETIKETBAS.GridControl = this.GRC_ETIKET_ETIKETBAS;
            this.GRV_ETIKET_ETIKETBAS.Name = "GRV_ETIKET_ETIKETBAS";
            this.GRV_ETIKET_ETIKETBAS.OptionsCustomization.AllowSort = false;
            this.GRV_ETIKET_ETIKETBAS.OptionsView.ColumnAutoWidth = false;
            this.GRV_ETIKET_ETIKETBAS.OptionsView.ShowFooter = true;
            this.GRV_ETIKET_ETIKETBAS.OptionsView.ShowGroupPanel = false;
            this.GRV_ETIKET_ETIKETBAS.DoubleClick += new System.EventHandler(this.GRV_TANIMLAMALAR_KULLANICILAR_DoubleClick);
            // 
            // GR_LOGICALREF
            // 
            this.GR_LOGICALREF.Caption = "LOGICALREF";
            this.GR_LOGICALREF.FieldName = "LOGICALREF";
            this.GR_LOGICALREF.Name = "GR_LOGICALREF";
            this.GR_LOGICALREF.OptionsColumn.AllowEdit = false;
            this.GR_LOGICALREF.OptionsColumn.ReadOnly = true;
            this.GR_LOGICALREF.Width = 96;
            // 
            // GR_SICILNO
            // 
            this.GR_SICILNO.Caption = "Sicil No";
            this.GR_SICILNO.FieldName = "SICILNO";
            this.GR_SICILNO.Name = "GR_SICILNO";
            this.GR_SICILNO.OptionsColumn.AllowEdit = false;
            this.GR_SICILNO.OptionsColumn.ReadOnly = true;
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
            this.GR_ADSOYAD.OptionsColumn.ReadOnly = true;
            this.GR_ADSOYAD.Visible = true;
            this.GR_ADSOYAD.VisibleIndex = 1;
            // 
            // GR_ETIKETMIKTAR
            // 
            this.GR_ETIKETMIKTAR.Caption = "Miktar";
            this.GR_ETIKETMIKTAR.FieldName = "ETIKETMIKTAR";
            this.GR_ETIKETMIKTAR.Name = "GR_ETIKETMIKTAR";
            this.GR_ETIKETMIKTAR.OptionsColumn.AllowEdit = false;
            this.GR_ETIKETMIKTAR.OptionsColumn.ReadOnly = true;
            this.GR_ETIKETMIKTAR.Visible = true;
            this.GR_ETIKETMIKTAR.VisibleIndex = 2;
            // 
            // GR_GIRISSAAT
            // 
            this.GR_GIRISSAAT.Caption = "Giriş Saati";
            this.GR_GIRISSAAT.FieldName = "GIRISSAAT";
            this.GR_GIRISSAAT.Name = "GR_GIRISSAAT";
            this.GR_GIRISSAAT.OptionsColumn.ReadOnly = true;
            this.GR_GIRISSAAT.Visible = true;
            this.GR_GIRISSAAT.VisibleIndex = 3;
            // 
            // GR_ISLEMLER
            // 
            this.GR_ISLEMLER.Caption = "Etiket Bas";
            this.GR_ISLEMLER.ColumnEdit = this.RI_ETIKETBAS;
            this.GR_ISLEMLER.FieldName = "ISLEMLER";
            this.GR_ISLEMLER.Name = "GR_ISLEMLER";
            this.GR_ISLEMLER.Visible = true;
            this.GR_ISLEMLER.VisibleIndex = 4;
            // 
            // RI_ETIKETBAS
            // 
            this.RI_ETIKETBAS.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.RI_ETIKETBAS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Etiket Bas", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.RI_ETIKETBAS.Name = "RI_ETIKETBAS";
            this.RI_ETIKETBAS.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RI_ETIKETBAS.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RI_ETIKETBAS_ButtonClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 30);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 31);
            this.panel3.TabIndex = 4;
            // 
            // FRM_ETIKET_ETIKETBAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FRM_ETIKET_ETIKETBAS.IconOptions.SvgImage")));
            this.Name = "FRM_ETIKET_ETIKETBAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETİKET BAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_KANTARPLAKA_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRC_ETIKET_ETIKETBAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_ETIKET_ETIKETBAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RI_ETIKETBAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl GRC_ETIKET_ETIKETBAS;
        private DevExpress.XtraGrid.Views.Grid.GridView GRV_ETIKET_ETIKETBAS;
        private DevExpress.XtraGrid.Columns.GridColumn GR_LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn GR_SICILNO;
        private DevExpress.XtraGrid.Columns.GridColumn GR_ADSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn GR_ETIKETMIKTAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn GR_GIRISSAAT;
        private DevExpress.XtraGrid.Columns.GridColumn GR_ISLEMLER;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RI_ETIKETBAS;
    }
}