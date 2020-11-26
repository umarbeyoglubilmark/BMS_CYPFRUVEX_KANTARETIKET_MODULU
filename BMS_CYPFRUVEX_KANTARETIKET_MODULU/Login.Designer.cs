namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.sb_LOGIN = new DevExpress.XtraEditors.SimpleButton();
            this.te_PASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.te_USERNAME = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.te_PASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_USERNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sb_LOGIN
            // 
            this.sb_LOGIN.Location = new System.Drawing.Point(365, 146);
            this.sb_LOGIN.Name = "sb_LOGIN";
            this.sb_LOGIN.Size = new System.Drawing.Size(159, 23);
            this.sb_LOGIN.TabIndex = 12;
            this.sb_LOGIN.Text = "LOGIN";
            this.sb_LOGIN.Click += new System.EventHandler(this.sb_LOGIN_Click);
            // 
            // te_PASSWORD
            // 
            this.te_PASSWORD.EditValue = "";
            this.te_PASSWORD.Location = new System.Drawing.Point(365, 87);
            this.te_PASSWORD.Name = "te_PASSWORD";
            this.te_PASSWORD.Properties.PasswordChar = '*';
            this.te_PASSWORD.Size = new System.Drawing.Size(159, 20);
            this.te_PASSWORD.TabIndex = 10;
            // 
            // te_USERNAME
            // 
            this.te_USERNAME.EditValue = "";
            this.te_USERNAME.Location = new System.Drawing.Point(365, 60);
            this.te_USERNAME.Name = "te_USERNAME";
            this.te_USERNAME.Size = new System.Drawing.Size(159, 20);
            this.te_USERNAME.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 24);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(226, 178);
            this.pictureEdit1.TabIndex = 22;
            // 
            // Login
            // 
            this.AcceptButton = this.sb_LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 226);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sb_LOGIN);
            this.Controls.Add(this.te_PASSWORD);
            this.Controls.Add(this.te_USERNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Login.IconOptions.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.te_PASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_USERNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sb_LOGIN;
        private DevExpress.XtraEditors.TextEdit te_PASSWORD;
        private DevExpress.XtraEditors.TextEdit te_USERNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}