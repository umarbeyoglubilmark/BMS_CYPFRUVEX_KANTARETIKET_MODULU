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
    public partial class FRM_KANTARURETICI : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_KANTARURETICI(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);

            SQLCON = new SqlConnection(LGCONSTR);
            string where = _CFG.URETICIBASLANGICKODU != "" ? " AND CODE LIKE('" + _CFG.URETICIBASLANGICKODU + "%')" : " ";
            GRC_KANTAR_URETICI.DataSource = BMS_DLL.SQL.SELECT2(@" SELECT  
LGMAIN.LOGICALREF, LGMAIN.CODE  KOD , LGMAIN.DEFINITION_  AD  FROM LG_" + CFG.FIRMNR + @"_CLCARD LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) "+ where + @"  ORDER BY LGMAIN.DEFINITION_
", SQLCON);

            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_URETICI, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_URETICI.Name);

        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_KANTAR_URETICI, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_URETICI.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            base.DialogResult = DialogResult.OK;
            LOGICALREF = GRV_KANTAR_URETICI.GetRowCellValue(GRV_KANTAR_URETICI.FocusedRowHandle, "LOGICALREF").ToString();
            KOD = GRV_KANTAR_URETICI.GetRowCellValue(GRV_KANTAR_URETICI.FocusedRowHandle, "KOD").ToString();
            AD = GRV_KANTAR_URETICI.GetRowCellValue(GRV_KANTAR_URETICI.FocusedRowHandle, "AD").ToString();
            this.Close();


        }
    }
}