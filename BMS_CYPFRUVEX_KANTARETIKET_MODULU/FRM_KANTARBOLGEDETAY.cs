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
    public partial class FRM_KANTARBOLGEDETAY : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_KANTARBOLGEDETAY(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_BOLGEDETAY, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_BOLGEDETAY.Name);
            SQLCON = new SqlConnection(LGCONSTR);
            GRC_KANTAR_BOLGEDETAY.DataSource = BMS_DLL.SQL.SELECT2(@" SELECT  SPECODE,DEFINITION_ FROM LG_" + CFG.FIRMNR + "_SPECODES WHERE CODETYPE=2", SQLCON);
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_BOLGEDETAY, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_BOLGEDETAY.Name);
        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {

            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_KANTAR_BOLGEDETAY, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_BOLGEDETAY.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            base.DialogResult = DialogResult.OK; 
            AD = GRV_KANTAR_BOLGEDETAY.GetRowCellValue(GRV_KANTAR_BOLGEDETAY.FocusedRowHandle, "SPECODE").ToString();
            this.Close();


        }
    }
}