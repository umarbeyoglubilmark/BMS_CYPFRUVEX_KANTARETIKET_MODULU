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
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class FRM_OPERATOR_YENISATINALMAFATURASI : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        BMS_KE_KANTAR _KANTAR = new BMS_KE_KANTAR();
        public FRM_OPERATOR_YENISATINALMAFATURASI(CONFIG CFG, BMS_KE_KANTAR KANTAR) {
            InitializeComponent();
            _CFG = CFG;
            _KANTAR = KANTAR;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);

            SQLCON = new SqlConnection(LGCONSTR);
            DT_TARIH.DateTime = DateTime.Now;
            //TE_URETICI.Text = _KANTAR.URETICIID.ToString();
            //TE_PLAKA.Text = _KANTAR.PLAKAID.ToString();
            //TE_KONTRAKTOR.Text = _KANTAR.KONTRAKTORID.ToString();
            TE_PLAKA.Text = BMS_DLL.SQL.SELECT2(@"SELECT  
TOP 1 LGMAIN.GDEF  AD  FROM L_TRADGRP LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_KONTRAKTOR.Text = BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_URETICI.Text = BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_BELGENO.Text = _KANTAR.ACIKLAMA;
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);

        }
        private void INITIALIZEGRID() {
            GRC_OPERATOR_YENISATINALMA.DataSource = BMS_DLL.SQL.SELECT2("SELECT LOGICALREF,URUNID, (SELECT TOP 1 NAME FROM LG_" + _CFG.FIRMNR + "_ITEMS I WHERE I.LOGICALREF=URUNID) URUN,MIKTAR,BIRIM FROM BMS_KE_KANTAR WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
            GRV_OPERATOR_YENISATINALMA.Columns["LOGICALREF"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["LOGICALREF"].Visible = false;
            GRV_OPERATOR_YENISATINALMA.Columns["URUNID"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["URUNID"].Visible = false;
            GRV_OPERATOR_YENISATINALMA.Columns["URUN"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["BIRIM"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.BestFitColumns();
        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            base.DialogResult = DialogResult.OK;
            LOGICALREF = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "LOGICALREF").ToString();
            KOD = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "KOD").ToString();
            AD = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "AD").ToString();
            this.Close(); 
        }

        private void SB_VAZGEC_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}