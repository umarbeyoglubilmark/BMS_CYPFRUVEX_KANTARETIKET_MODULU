using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.IO;
using System.Xml;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            BMS_DLL.CFGGETSET.AYARLARIYUKLE();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            BMS_DLL.GLOBAL.FORMAC(true, new Ayarlar(), this, false, null);
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            BMS_DLL.CFGGETSET.AYARLARIYUKLE();
            // BMS_DLL.GLOBAL.NUMARATOR();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            string[] LG_TABLES =  {
            @"CREATE TABLE [dbo].[BMS_KE_KANTAR](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[TARIH] [datetime] NULL,
	[PLAKAID] [int] NULL,
	[KONTRAKTORID] [int] NULL,
	[URETICIID] [int] NULL,
	[URUNID] [int] NULL,
	[MIKTAR] [float] NULL,
	[BIRIM] [varchar](50) NULL,
	[KULLANICI] [varchar](255) NULL,
	[BARKODYAZIMMIKTAR] [int] NULL,
	[ACIKLAMA] [varchar](255) NULL,
	[LOGOAKTARIMI] [int] NULL,
	[LOGOAKTARIMTARIHI] [datetime] NULL,
	[LOGOFISID] [int] NULL,
	[ERRORMESSAGE] [varchar](255) NULL,
	[TSTATUS] [int] NULL,
 CONSTRAINT [PK_BMS_KE_KANTAR] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]"   };
            BMS_DLL.SQL.TABLOLARIOLUSTUR(typeof(PROGRESSFORM), this, LG_TABLES, false, null);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // BMS_DLL.GLOBAL.FORMAC(true, new KULLANICILAR(), this, false, null);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //     BMS_DLL.GLOBAL.FORMAC(true, new FIRMA(), this, false, null);
        }
    }
}