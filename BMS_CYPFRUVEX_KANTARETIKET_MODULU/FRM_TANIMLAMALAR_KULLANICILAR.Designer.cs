namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_TANIMLAMALAR_KULLANICILAR {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TANIMLAMALAR_KULLANICILAR));
            this.TE_KULLANICIADI = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRC_TANIMLAMALAR_KULLANICILAR = new DevExpress.XtraGrid.GridControl();
            this.GRV_TANIMLAMALAR_KULLANICILAR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GR_LOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_KULLANICIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_PAROLA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR_TUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BTN_UA = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.LBL_LOGICALREF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TE_TUR = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TE_PAROLA = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_YENI = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRC_TANIMLAMALAR_KULLANICILAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_TANIMLAMALAR_KULLANICILAR)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TE_TUR.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TE_KULLANICIADI
            // 
            this.TE_KULLANICIADI.Location = new System.Drawing.Point(111, 39);
            this.TE_KULLANICIADI.Name = "TE_KULLANICIADI";
            this.TE_KULLANICIADI.Size = new System.Drawing.Size(261, 21);
            this.TE_KULLANICIADI.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GRC_TANIMLAMALAR_KULLANICILAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 273);
            this.panel2.TabIndex = 5;
            // 
            // GRC_TANIMLAMALAR_KULLANICILAR
            // 
            this.GRC_TANIMLAMALAR_KULLANICILAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRC_TANIMLAMALAR_KULLANICILAR.Location = new System.Drawing.Point(0, 0);
            this.GRC_TANIMLAMALAR_KULLANICILAR.MainView = this.GRV_TANIMLAMALAR_KULLANICILAR;
            this.GRC_TANIMLAMALAR_KULLANICILAR.Name = "GRC_TANIMLAMALAR_KULLANICILAR";
            this.GRC_TANIMLAMALAR_KULLANICILAR.Size = new System.Drawing.Size(568, 273);
            this.GRC_TANIMLAMALAR_KULLANICILAR.TabIndex = 0;
            this.GRC_TANIMLAMALAR_KULLANICILAR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRV_TANIMLAMALAR_KULLANICILAR});
            // 
            // GRV_TANIMLAMALAR_KULLANICILAR
            // 
            this.GRV_TANIMLAMALAR_KULLANICILAR.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GR_LOGICALREF,
            this.GR_KULLANICIADI,
            this.GR_PAROLA,
            this.GR_TUR});
            this.GRV_TANIMLAMALAR_KULLANICILAR.GridControl = this.GRC_TANIMLAMALAR_KULLANICILAR;
            this.GRV_TANIMLAMALAR_KULLANICILAR.Name = "GRV_TANIMLAMALAR_KULLANICILAR";
            this.GRV_TANIMLAMALAR_KULLANICILAR.OptionsBehavior.Editable = false;
            this.GRV_TANIMLAMALAR_KULLANICILAR.OptionsView.ColumnAutoWidth = false;
            this.GRV_TANIMLAMALAR_KULLANICILAR.OptionsView.ShowGroupPanel = false;
            this.GRV_TANIMLAMALAR_KULLANICILAR.DoubleClick += new System.EventHandler(this.GRV_TANIMLAMALAR_KULLANICILAR_DoubleClick);
            // 
            // GR_LOGICALREF
            // 
            this.GR_LOGICALREF.Caption = "LOGICALREF";
            this.GR_LOGICALREF.FieldName = "LOGICALREF";
            this.GR_LOGICALREF.Name = "GR_LOGICALREF";
            this.GR_LOGICALREF.OptionsColumn.AllowEdit = false;
            this.GR_LOGICALREF.Visible = true;
            this.GR_LOGICALREF.VisibleIndex = 0;
            this.GR_LOGICALREF.Width = 96;
            // 
            // GR_KULLANICIADI
            // 
            this.GR_KULLANICIADI.Caption = "Kullanıcı Adı";
            this.GR_KULLANICIADI.FieldName = "KULLANICIADI";
            this.GR_KULLANICIADI.Name = "GR_KULLANICIADI";
            this.GR_KULLANICIADI.OptionsColumn.AllowEdit = false;
            this.GR_KULLANICIADI.Visible = true;
            this.GR_KULLANICIADI.VisibleIndex = 1;
            this.GR_KULLANICIADI.Width = 159;
            // 
            // GR_PAROLA
            // 
            this.GR_PAROLA.Caption = "Parola";
            this.GR_PAROLA.FieldName = "PAROLA";
            this.GR_PAROLA.Name = "GR_PAROLA";
            this.GR_PAROLA.OptionsColumn.AllowEdit = false;
            // 
            // GR_TUR
            // 
            this.GR_TUR.Caption = "Tür";
            this.GR_TUR.FieldName = "TUR";
            this.GR_TUR.Name = "GR_TUR";
            this.GR_TUR.OptionsColumn.AllowEdit = false;
            this.GR_TUR.Visible = true;
            this.GR_TUR.VisibleIndex = 2;
            // 
            // BTN_UA
            // 
            this.BTN_UA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UA.Location = new System.Drawing.Point(378, 42);
            this.BTN_UA.Name = "BTN_UA";
            this.BTN_UA.Size = new System.Drawing.Size(140, 37);
            this.BTN_UA.TabIndex = 7;
            this.BTN_UA.Text = "Güncelle/Kaydet";
            this.BTN_UA.UseVisualStyleBackColor = true;
            this.BTN_UA.Click += new System.EventHandler(this.BTN_UA_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DELETE.Enabled = false;
            this.BTN_DELETE.Location = new System.Drawing.Point(378, 82);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(140, 32);
            this.BTN_DELETE.TabIndex = 6;
            this.BTN_DELETE.Text = "Sil";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
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
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_YENI);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TE_TUR);
            this.panel1.Controls.Add(this.BTN_UA);
            this.panel1.Controls.Add(this.BTN_DELETE);
            this.panel1.Controls.Add(this.LBL_LOGICALREF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TE_PAROLA);
            this.panel1.Controls.Add(this.TE_KULLANICIADI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 128);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tür";
            // 
            // TE_TUR
            // 
            this.TE_TUR.Location = new System.Drawing.Point(111, 94);
            this.TE_TUR.Name = "TE_TUR";
            this.TE_TUR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TE_TUR.Properties.Items.AddRange(new object[] {
            "KANTAR",
            "OPERATOR",
            "YONETICI"});
            this.TE_TUR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TE_TUR.Size = new System.Drawing.Size(261, 20);
            this.TE_TUR.TabIndex = 8;
            // 
            // TE_PAROLA
            // 
            this.TE_PAROLA.Location = new System.Drawing.Point(111, 66);
            this.TE_PAROLA.Name = "TE_PAROLA";
            this.TE_PAROLA.Size = new System.Drawing.Size(261, 21);
            this.TE_PAROLA.TabIndex = 1;
            this.TE_PAROLA.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 100);
            this.panel3.TabIndex = 4;
            // 
            // BTN_YENI
            // 
            this.BTN_YENI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_YENI.Location = new System.Drawing.Point(378, 2);
            this.BTN_YENI.Name = "BTN_YENI";
            this.BTN_YENI.Size = new System.Drawing.Size(140, 37);
            this.BTN_YENI.TabIndex = 10;
            this.BTN_YENI.Text = "Yeni";
            this.BTN_YENI.UseVisualStyleBackColor = true;
            this.BTN_YENI.Click += new System.EventHandler(this.BTN_YENI_Click);
            // 
            // FRM_TANIMLAMALAR_KULLANICILAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FRM_TANIMLAMALAR_KULLANICILAR.IconOptions.SvgImage")));
            this.Name = "FRM_TANIMLAMALAR_KULLANICILAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICILAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_KANTARPLAKA_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRC_TANIMLAMALAR_KULLANICILAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRV_TANIMLAMALAR_KULLANICILAR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TE_TUR.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TE_KULLANICIADI;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl GRC_TANIMLAMALAR_KULLANICILAR;
        private DevExpress.XtraGrid.Views.Grid.GridView GRV_TANIMLAMALAR_KULLANICILAR;
        private DevExpress.XtraGrid.Columns.GridColumn GR_LOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn GR_KULLANICIADI;
        private DevExpress.XtraGrid.Columns.GridColumn GR_PAROLA;
        private DevExpress.XtraGrid.Columns.GridColumn GR_TUR;
        private System.Windows.Forms.Button BTN_UA;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Label LBL_LOGICALREF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit TE_TUR;
        private System.Windows.Forms.TextBox TE_PAROLA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_YENI;
    }
}