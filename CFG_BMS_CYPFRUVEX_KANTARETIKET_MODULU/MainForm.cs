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
                @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CLCARD](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[CODE] [varchar](255) NULL,
	[DEFINITION_] [varchar](255) NULL,
	[ADDRESS] [varchar](255) NULL,
	[PHONE] [varchar](255) NULL,
	[DESCRIPTION] [varchar](255) NULL,
	[CREATEDDATE] [datetime] NULL,
	[ACTIVE] [int] NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CLCARD] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CLFICHE](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[FICHENO] [varchar](255) NULL,
	[TYPE] [varchar](255) NULL,
	[SIGN] [varchar](255) NULL,
	[CARDREF] [int] NULL,
	[DATE_] [datetime] NULL,
	[CREATEDDATE] [datetime] NULL,
	[DESCRIPTION] [varchar](255) NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CLFICHE] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",

                  @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CLFLINE](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[FICHEREF] [int] NULL,
	[DOVIZ] [varchar](255) NULL,
	[DOVIZ_KUR] [float] NULL,
	[AMOUNT] [float] NULL,
	[DESCRIPTION] [varchar](255) NULL,
	[CREATEDDATE] [datetime] NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CLFLINE] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                    @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_ITEMS](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[CODE] [varchar](255) NULL,
	[DEFINITION_] [varchar](255) NULL,
	[UNITREF] [int] NULL,
	[MARKA] [varchar](255) NULL,
	[MODEL] [varchar](255) NULL,
	[YIL] [datetime] NULL,
	[ARAC] [varchar](255) NULL,
	[BARKOD] [varchar](255) NULL,
	[DESCRIPTION] [varchar](255) NULL,
	[CREATEDDATE] [datetime] NULL,
	[ACTIVE] [int] NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_ITEMS] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                      @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_ITEMUNIT](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[CODE] [varchar](255) NULL,
	[DEFINITION_] [varchar](255) NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_ITEMUNIT] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                        @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_STFICHE](
	[LOGICALREF] [int] IDENTITY(1,1) NOT NULL,
	[FICHENO] [varchar](255) NULL,
	[TYPE] [varchar](255) NULL,
	[SIGN] [varchar](255) NULL,
	[CARDREF] [int] NULL,
	[DATE_] [datetime] NULL,
	[DESCRIPTION] [varchar](255) NULL,
	[CREATEDDATE] [datetime] NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_STFICHE] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                          @"CREATE TABLE [dbo].[LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_STLINE](
	[LOGICALREF] [INT] IDENTITY(1,1) NOT NULL,
	[FICHEREF] [INT] NULL,
	[ITEMREF] [INT] NULL,
	[DOVIZ] [VARCHAR](255) NULL,
	[DOVIZ_KUR] [FLOAT] NULL,
	[UNITPRICE] [FLOAT] NULL,
	[AMOUNT] [FLOAT] NULL,
	[TOTAL] [FLOAT] NULL,
	[DESCRIPTION] [VARCHAR](255) NULL,
	[CREATEDDATE] [DATETIME] NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_STLINE] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                          @"CREATE TABLE [dbo].[LG_CAPIFIRM](
	[LOGICALREF] [INT] IDENTITY(1,1) NOT NULL,
	[DEFINITION_] [VARCHAR](255) NULL,
	[PHONE] [VARCHAR](255) NULL,
	[ADDRESS] [VARCHAR](255) NULL,
	[DESCRIPTION] [VARCHAR](255) NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_CAPIFIRM] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]",
                          @"CREATE TABLE [dbo].[LG_USERS](
	[LOGICALREF] [INT] IDENTITY(1,1) NOT NULL, 
	[USERNAME] [VARCHAR](255) NULL,
	[PASSWORD] [VARCHAR](255) NULL,
	[BACKGROUND] [IMAGE] NULL,
	[ACTIVE] [INT] NULL,
 CONSTRAINT [PK_LG_"+BMS_DLL.CFGICERIK.FIRMNR+@"_USERS] PRIMARY KEY CLUSTERED 
(
	[LOGICALREF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]",
                          " INSERT INTO [dbo].[BM_CAPIFIRM] ([DEFITINION_] ,[PHONE] ,[ADDRESS] ,[DESCRIPTION]) VALUES ('XXX FIRMA' ,'0000000' ,'LEFKOŞA' ,'X@FIRMA.COM') ",
            };
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