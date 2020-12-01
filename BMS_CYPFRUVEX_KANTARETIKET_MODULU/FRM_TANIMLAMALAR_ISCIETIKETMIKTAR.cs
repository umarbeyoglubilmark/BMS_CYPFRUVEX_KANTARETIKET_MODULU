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
    public partial class FRM_TANIMLAMALAR_ISCIETIKETMIKTAR : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_TANIMLAMALAR_ISCIETIKETMIKTAR(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            SQLCON = new SqlConnection(LGCONSTR);
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_TANIMLAMALAR_ISCIETIKETMIKTAR, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.Name);
        }
        private void INITIALIZEGRID() {
            string tarih = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString();
            DataTable DT = BMS_DLL.SQL.SELECT2(@"exec ('SELECT  0 LOGICALREF,  personel_kartlari.kartno SICILNO,concat(personel_kartlari.adi,
'' '', personel_kartlari.soyadi)as ADSOYAD, 0 ETIKETMIKTAR 

FROM personel_kartlari INNER JOIN 
personel_giriscikis ON personel_kartlari.id = 
personel_giriscikis.personel_id WHERE personel_kartlari.cikistarihi is null
and personel_giriscikis.tarih=''" + tarih + @"''   ORDER BY personel_giriscikis.id ASC ') at PDKSDB; ", SQLCON);

            foreach (DataRow item in DT.Rows) {
                try { item["LOGICALREF"] = BMS_DLL.SQL.SELECT2("SELECT TOP 1 LOGICALREF FROM BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME WHERE SICILNO='" + item["SICILNO"] + "' ", SQLCON).Rows[0][0].ToString(); } catch { }
                try { item["ETIKETMIKTAR"] = BMS_DLL.SQL.SELECT2("SELECT TOP 1 ETIKETMIKTAR FROM BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME WHERE SICILNO='" + item["SICILNO"] + "' ", SQLCON).Rows[0][0].ToString(); } catch { }
            }
            GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.DataSource = DT; 
        }
        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_TANIMLAMALAR_ISCIETIKETMIKTAR, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_TANIMLAMALAR_ISCIETIKETMIKTAR.Name);
        } 
        private void BTN_UA_Click(object sender, EventArgs e) {
            if (LBL_LOGICALREF.Text == "0") {
                BMS_DLL.SQL.EXECUTE2(this, string.Format("INSERT INTO BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME (SICILNO,ADSOYAD,ETIKETMIKTAR) VALUES ('{0}','{1}','{2}')", TE_SICILNO.Text, TE_ADSOYAD.Text, TE_MIKTAR.Text), SQLCON);
            } else {
                BMS_DLL.SQL.EXECUTE2(this, string.Format("UPDATE BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME SET ETIKETMIKTAR='{0}'  WHERE LOGICALREF={1}", TE_MIKTAR.Text, LBL_LOGICALREF.Text), SQLCON);
            }
            INITIALIZEGRID();
        } 
        private void GRV_TANIMLAMALAR_KULLANICILAR_DoubleClick(object sender, EventArgs e) {
            TE_SICILNO.Text = GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.GetRowCellValue(GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.FocusedRowHandle, "SICILNO").ToString();
            TE_ADSOYAD.Text = GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.GetRowCellValue(GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.FocusedRowHandle, "ADSOYAD").ToString();
            TE_MIKTAR.Text = GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.GetRowCellValue(GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.FocusedRowHandle, "ETIKETMIKTAR").ToString(); 
            LBL_LOGICALREF.Text = GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.GetRowCellValue(GRV_TANIMLAMALAR_ISCIETIKETMIKTAR.FocusedRowHandle, "LOGICALREF").ToString(); 
        } 
    }
}