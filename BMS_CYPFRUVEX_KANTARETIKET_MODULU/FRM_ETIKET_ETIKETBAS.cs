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
    public partial class FRM_ETIKET_ETIKETBAS : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_ETIKET_ETIKETBAS(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            SQLCON = new SqlConnection(LGCONSTR);
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_ETIKET_ETIKETBAS, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_ETIKET_ETIKETBAS.Name);
        }
        private void INITIALIZEGRID() {
            string tarih = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString();
            DataTable DT = BMS_DLL.SQL.SELECT2(@"exec ('SELECT  0 LOGICALREF,  personel_kartlari.kartno SICILNO,concat(personel_kartlari.adi,
'' '', personel_kartlari.soyadi)as ADSOYAD,giris_saat GIRISSAAT,0 ETIKETMIKTAR 

FROM personel_kartlari INNER JOIN 
personel_giriscikis ON personel_kartlari.id = 
personel_giriscikis.personel_id WHERE personel_kartlari.cikistarihi is null
and personel_giriscikis.tarih=''" + tarih + @"''   ORDER BY personel_giriscikis.id ASC ') at PDKSDB; ", SQLCON);

            foreach (DataRow item in DT.Rows) {
                try { item["LOGICALREF"] = BMS_DLL.SQL.SELECT2("SELECT TOP 1 LOGICALREF FROM BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME WHERE SICILNO='" + item["SICILNO"] + "' ", SQLCON).Rows[0][0].ToString(); } catch { }
                try { item["ETIKETMIKTAR"] = BMS_DLL.SQL.SELECT2("SELECT TOP 1 ETIKETMIKTAR FROM BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME WHERE SICILNO='" + item["SICILNO"] + "' ", SQLCON).Rows[0][0].ToString(); } catch { }
            }
            GRC_ETIKET_ETIKETBAS.DataSource = DT;
            GRV_ETIKET_ETIKETBAS.BestFitColumns();
        }
        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_ETIKET_ETIKETBAS, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_ETIKET_ETIKETBAS.Name);
        }
        private void BTN_UA_Click(object sender, EventArgs e) {
            //if (LBL_LOGICALREF.Text == "0") {
            //    BMS_DLL.SQL.EXECUTE2(this, string.Format("INSERT INTO BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME (SICILNO,ADSOYAD,ETIKETMIKTAR) VALUES ('{0}','{1}','{2}')", TE_SICILNO.Text, TE_ADSOYAD.Text, TE_MIKTAR.Text), SQLCON);
            //} else {
            //    BMS_DLL.SQL.EXECUTE2(this, string.Format("UPDATE BMS_KE_KANTARISCIETIKETMIKTARESLESTIRME SET ETIKETMIKTAR='{0}'  WHERE LOGICALREF={1}", TE_MIKTAR.Text, LBL_LOGICALREF.Text), SQLCON);
            //}
            //INITIALIZEGRID();
        }
        private void GRV_TANIMLAMALAR_KULLANICILAR_DoubleClick(object sender, EventArgs e) {
            //TE_SICILNO.Text = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "SICILNO").ToString();
            //TE_ADSOYAD.Text = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "ADSOYAD").ToString();
            //TE_MIKTAR.Text = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "ETIKETMIKTAR").ToString(); 
            //LBL_LOGICALREF.Text = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "LOGICALREF").ToString(); 
        }

        private void RI_ETIKETBAS_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            try {
                string SICILNO = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "SICILNO").ToString();
                string ADSOYAD = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "ADSOYAD").ToString();
                string ETIKETMIKTAR = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "ETIKETMIKTAR").ToString();
                string LOGICALREF = GRV_ETIKET_ETIKETBAS.GetRowCellValue(GRV_ETIKET_ETIKETBAS.FocusedRowHandle, "LOGICALREF").ToString();
                MessageBox.Show("SICILNO:" + SICILNO + " / ADSOYAD:" + ADSOYAD + " / ETİKET MİKTAR:" + ETIKETMIKTAR);

            } catch (Exception EX) {
                MessageBox.Show(EX.Message);
                throw;
            }
        }
    }
}