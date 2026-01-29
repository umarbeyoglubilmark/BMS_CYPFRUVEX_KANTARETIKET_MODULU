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
using System.Data.SqlClient;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class FRM_KANTARPLAKA : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        public bool KENDI_PLAKASI_MI = false;
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_KANTARPLAKA(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_PLAKA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_PLAKA.Name);
            SQLCON = new SqlConnection(LGCONSTR);
            GRC_KANTAR_PLAKA.DataSource = BMS_DLL.SQL.SELECT2(@" SELECT  
LGMAIN.LOGICALREF, LGMAIN.GCODE  KOD , LGMAIN.GDEF  AD  FROM L_TRADGRP LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0)  ORDER BY LGMAIN.GCODE, LGMAIN.LOGICALREF
", SQLCON);
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_PLAKA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_PLAKA.Name);
        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {

            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_KANTAR_PLAKA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_PLAKA.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            base.DialogResult = DialogResult.OK;
            LOGICALREF = GRV_KANTAR_PLAKA.GetRowCellValue(GRV_KANTAR_PLAKA.FocusedRowHandle, "LOGICALREF").ToString();
            KOD = GRV_KANTAR_PLAKA.GetRowCellValue(GRV_KANTAR_PLAKA.FocusedRowHandle, "KOD").ToString();
            AD = GRV_KANTAR_PLAKA.GetRowCellValue(GRV_KANTAR_PLAKA.FocusedRowHandle, "AD").ToString();
            KENDI_PLAKASI_MI = CHK_KENDI_PLAKASI.Checked;

            // Kendi plakası değilse uyarı ver
            if (!KENDI_PLAKASI_MI)
            {
                MessageBox.Show("DİKKAT: Bu plaka kendi plakası olarak işaretlenmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }
    }
}