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
    public partial class FRM_KANTARURUN : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        public string BIRIM = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_KANTARURUN(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);

            SQLCON = new SqlConnection(LGCONSTR);
            //            GRC_KANTAR_URETICI.DataSource = BMS_DLL.SQL.SELECT2(@" SELECT  
            //LGMAIN.LOGICALREF, LGMAIN.CODE  KOD , LGMAIN.NAME  AD  FROM LG_"+CFG.FIRMNR+ @"_ITEMS LGMAIN WITH(NOLOCK) 
            // WHERE (LGMAIN.ACTIVE=0)  ORDER BY LGMAIN.NAME
            //", SQLCON);
            string where = _CFG.URUNBASLANGICKODU != "" ? " AND ITEMS2.CODE LIKE('" + _CFG.URUNBASLANGICKODU + "%')" : " ";
            GRC_KANTAR_URUN.DataSource = BMS_DLL.SQL.SELECT2(@"SELECT ITEMS2.LOGICALREF,ITEMS2.CODE KOD,ITEMS2.NAME AD,  BIRIM.NAME BIRIM FROM  LG_" + CFG.FIRMNR+@"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_"+CFG.FIRMNR+@"_UNITSETL BIRIM WITH (NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF
			WHERE BIRIM.MAINUNIT=1
"+where, SQLCON);

            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_KANTAR_URUN, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_URUN.Name);

        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_KANTAR_URUN, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_KANTAR_URUN.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            base.DialogResult = DialogResult.OK;
            LOGICALREF = GRV_KANTAR_URUN.GetRowCellValue(GRV_KANTAR_URUN.FocusedRowHandle, "LOGICALREF").ToString();
            KOD = GRV_KANTAR_URUN.GetRowCellValue(GRV_KANTAR_URUN.FocusedRowHandle, "KOD").ToString();
            AD = GRV_KANTAR_URUN.GetRowCellValue(GRV_KANTAR_URUN.FocusedRowHandle, "AD").ToString();
            BIRIM = GRV_KANTAR_URUN.GetRowCellValue(GRV_KANTAR_URUN.FocusedRowHandle, "BIRIM").ToString();
            this.Close();


        }
    }
}