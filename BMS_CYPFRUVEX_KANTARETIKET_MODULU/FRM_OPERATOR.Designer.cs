namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class FRM_OPERATOR {
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
            this.TE_QRKOD = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_QRKOD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TE_QRKOD
            // 
            this.TE_QRKOD.Dock = System.Windows.Forms.DockStyle.Top;
            this.TE_QRKOD.EditValue = "";
            this.TE_QRKOD.Location = new System.Drawing.Point(0, 0);
            this.TE_QRKOD.Name = "TE_QRKOD";
            this.TE_QRKOD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TE_QRKOD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 87.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TE_QRKOD.Properties.Appearance.Options.UseBackColor = true;
            this.TE_QRKOD.Properties.Appearance.Options.UseFont = true;
            this.TE_QRKOD.Properties.NullText = "QRKODU";
            this.TE_QRKOD.Size = new System.Drawing.Size(638, 148);
            this.TE_QRKOD.TabIndex = 0;
            this.TE_QRKOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TE_QRKOD_KeyPress);
            // 
            // FRM_OPERATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 149);
            this.Controls.Add(this.TE_QRKOD);
            this.Name = "FRM_OPERATOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPERATÖR";
            ((System.ComponentModel.ISupportInitialize)(this.TE_QRKOD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TE_QRKOD;
    }
}