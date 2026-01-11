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
    public partial class FRM_KANTARKONTRAKTOR : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_KANTARKONTRAKTOR(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            string where = _CFG.KONTRAKTORBASLANGICKODU != "" ? " AND CODE LIKE('" + _CFG.KONTRAKTORBASLANGICKODU + "%')" : " ";
            SQLCON = new SqlConnection(LGCONSTR);
            GRC_KANTAR_KONTRAKTOR.DataSource = BMS_DLL.SQL.SELECT2(@" SELECT  
LGMAIN.LOGICALREF, LGMAIN.CODE  KOD , LGMAIN.DEFINITION_  AD  FROM LG_"+CFG.FIRMNR+ @"_CLCARD LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) "+ where + @"  ORDER BY LGMAIN.DEFINITION_
", SQLCON);
       
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_KONTRAKTOR, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_KONTRAKTOR.Name);

        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_KANTAR_KONTRAKTOR, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_KONTRAKTOR.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            base.DialogResult = DialogResult.OK;
            LOGICALREF = GRV_KANTAR_KONTRAKTOR.GetRowCellValue(GRV_KANTAR_KONTRAKTOR.FocusedRowHandle, "LOGICALREF").ToString();
            KOD = GRV_KANTAR_KONTRAKTOR.GetRowCellValue(GRV_KANTAR_KONTRAKTOR.FocusedRowHandle, "KOD").ToString();
            AD = GRV_KANTAR_KONTRAKTOR.GetRowCellValue(GRV_KANTAR_KONTRAKTOR.FocusedRowHandle, "AD").ToString();
            this.Close();


        }
    }
}