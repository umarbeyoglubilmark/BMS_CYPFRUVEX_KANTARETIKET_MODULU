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
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.CONVERTER;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.SQLCOMMANDS;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class FRM_OPERATOR_YENISATINALMAFATURASI : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        BMS_KE_KANTAR _KANTAR = new BMS_KE_KANTAR();
        SQLINSERTCOMMANDS SIC = new SQLINSERTCOMMANDS();
        string PLAKAKODU = "";
        public string _UOMREF = "0";
        public string _UOSREF = "0";
        double BIRIMFIYAT = 0;
        double TUTAR = 0;
        double TOPLAM = 0;
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
            PLAKAKODU = BMS_DLL.SQL.SELECT2(@"SELECT  
TOP 1 LGMAIN.GCODE   FROM L_TRADGRP LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_KONTRAKTOR.Text = BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_URETICI.Text = BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_BELGENO.Text = _KANTAR.ACIKLAMA;
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);
            _UOMREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.LOGICALREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", SQLCON).Rows[0][0].ToString();

            _UOSREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.UNITSETREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", SQLCON).Rows[0][0].ToString();
        }
        private void INITIALIZEGRID() {
            GRC_OPERATOR_YENISATINALMA.DataSource = BMS_DLL.SQL.SELECT2("SELECT LOGICALREF,URUNID, (SELECT TOP 1 NAME FROM LG_" + _CFG.FIRMNR + "_ITEMS I WHERE I.LOGICALREF=URUNID) URUN,MIKTAR,BIRIM, 0.00 BIRIMFIYAT, 0.00 TOPLAM FROM BMS_KE_KANTAR WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
            GRV_OPERATOR_YENISATINALMA.Columns["LOGICALREF"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["LOGICALREF"].Visible = false;
            GRV_OPERATOR_YENISATINALMA.Columns["URUNID"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["URUNID"].Visible = false;
            GRV_OPERATOR_YENISATINALMA.Columns["URUN"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["BIRIM"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["TOPLAM"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.BestFitColumns();
        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e) {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            //base.DialogResult = DialogResult.OK;
            //LOGICALREF = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "LOGICALREF").ToString();
            //KOD = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "KOD").ToString();
            //AD = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "AD").ToString();
            //this.Close();
        }

        private void SB_VAZGEC_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void SAVE_INVOICE() {
            int INVOICELOGICALREF = 0;
            BM_XXX_XX_INVOICE O = new BM_XXX_XX_INVOICE() {
                AFFECTRISK = 1,
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CLIENTREF = _KANTAR.URETICIID,
                DATE_ = _KANTAR.TARIH,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DOCDATE = _KANTAR.TARIH,
                ENTEGSET = 247,
                ESTATUS = 12,
                FICHENO = TE_FATURANO.Text,
                GENEXCTYP = 1,
                GENEXP2 = _KANTAR.ACIKLAMA,
                GROSSTOTAL = TOPLAM,
                GRPCODE = 1,
                GUID = Guid.NewGuid().ToString(),
                NETTOTAL = TOPLAM,
                RECSTATUS = 1,
                RECVREF = _KANTAR.KONTRAKTORID,
                TIME_ = 254939409,
                TOTALDISCOUNTED = TOPLAM,
                TRADINGGRP = PLAKAKODU,
                TRCODE = 1,
                TRNET = TOPLAM,
                VAT = 18,
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON) {
                if (con.State != ConnectionState.Open) {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try {
                    SqlCommand com = SIC.BM_XXX_XX_INVOICE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    INVOICELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_INVOICE):", ex);
                } finally {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (INVOICELOGICALREF > 0) {
                SAVE_STFICHE(INVOICELOGICALREF);
            }
        }

        private void SAVE_STFICHE(int _INVOICEREF) {
            int STFICHELOGICALREF = 0;
            BM_XXX_XX_STFICHE O = new BM_XXX_XX_STFICHE() {
                GRPCODE = 1,
                TRCODE = 1,
                IOCODE = 1,
                FICHENO = TE_FATURANO.Text,
                DATE_ = _KANTAR.TARIH,
                FTIME = 254939409,
                INVNO = TE_FATURANO.Text,
                INVOICEREF = _INVOICEREF,
                CLIENTREF = _KANTAR.URETICIID,
                RECVREF = _KANTAR.KONTRAKTORID,
                BILLED = 1,
                TOTALDISCOUNTED = TOPLAM,
                GROSSTOTAL = TOPLAM,
                NETTOTAL = TOPLAM,
                FICHECNT = 1,
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CAPIBLOCK_CREATEDSEC = DateTime.Now.Second,
                GENEXCTYP = 1,
                TRADINGGRP = PLAKAKODU,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                AFFECTRISK = 1,
                DISPSTATUS = 1,
                SHIPDATE = _KANTAR.TARIH,
                SHIPTIME = 254939409,
                GUID = Guid.NewGuid().ToString(),
                DOCTIME = 254939409
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON) {
                if (con.State != ConnectionState.Open) {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try {
                    SqlCommand com = SIC.BM_XXX_XX_STFICHE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    STFICHELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_STFICHE):", ex);
                } finally {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (STFICHELOGICALREF > 0) {
                SAVE_STLINE(_INVOICEREF, STFICHELOGICALREF);
            }
        }
        private void SAVE_STLINE(int _INVOICEREF, int _STFICHEREF) {
            int STLINELOGICALREF = 0;
            BM_XXX_XX_STLINE O = new BM_XXX_XX_STLINE() {
                STOCKREF = _KANTAR.URUNID,
                TRCODE = 1,
                DATE_ = _KANTAR.TARIH,
                FTIME = 254939409,
                IOCODE = 1,
                STFICHEREF = _STFICHEREF,
                STFICHELNNO = 1,
                INVOICEREF = _INVOICEREF,
                INVOICELNNO = 1,
                CLIENTREF = _KANTAR.URETICIID,
                AMOUNT = _KANTAR.MIKTAR,
                PRICE = BIRIMFIYAT,
                TOTAL = TOPLAM,
                UOMREF = int.Parse(_UOMREF),
                USREF = int.Parse(_UOSREF),
                UINFO1 = 1,
                UINFO2 = 1,
                VATMATRAH = TOPLAM,
                BILLED = 1,
                LINENET = TOPLAM,
                RECSTATUS = 2,
                YEAR_ = _KANTAR.TARIH.Year,
                AFFECTRISK = 1,
                GUID = Guid.NewGuid().ToString(),
                FUTMONTHBEGDATE = 132385566
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON) {
                if (con.State != ConnectionState.Open) {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try {
                    SqlCommand com = SIC.BM_XXX_XX_STLINE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    STLINELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_STLINE):", ex);
                } finally {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (STLINELOGICALREF > 0) {
                SAVE_PAYTRANS(_INVOICEREF, _STFICHEREF);
            }
        }

        private void SAVE_PAYTRANS(int _INVOICEREF, int _STFICHEREF) {
            int PAYTRANSLOGICALREF = 0;
            BM_XXX_XX_PAYTRANS O = new BM_XXX_XX_PAYTRANS() {
                CARDREF = _KANTAR.URETICIID,
                DATE_ = _KANTAR.TARIH,
                MODULENR = 4,
                SIGN = 1,
                FICHEREF = _INVOICEREF,
                TRCODE = 1,
                TOTAL = TOPLAM,
                PROCDATE = _KANTAR.TARIH,
                DISCDUEDATE = _KANTAR.TARIH,
                PAYNO = 1
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON) {
                if (con.State != ConnectionState.Open) {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try {
                    SqlCommand com = SIC.BM_XXX_XX_PAYTRANS_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    PAYTRANSLOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_PAYTRANS):", ex);
                } finally {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (PAYTRANSLOGICALREF > 0) {
                SAVE_CLFLINE(_INVOICEREF, _STFICHEREF);
            }
        }
        private void SAVE_CLFLINE(int _INVOICEREF, int _STFICHEREF) {
            int CLFLINELOGICALREF = 0;
            BM_XXX_XX_CLFLINE O = new BM_XXX_XX_CLFLINE() {
                CLIENTREF = _KANTAR.URETICIID,
                SOURCEFREF = _INVOICEREF,
                DATE_ = _KANTAR.TARIH,
                MODULENR = 4,
                TRCODE = 31,
                TRANNO = TE_FATURANO.Text,
                SIGN = 1,
                AMOUNT = TOPLAM,
                TRNET = TOPLAM,

                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CAPIBLOCK_CREATEDSEC = DateTime.Now.Second,
                TRADINGGRP = PLAKAKODU,
                MONTH_ = _KANTAR.TARIH.Month,
                YEAR_ = _KANTAR.TARIH.Year,
                AFFECTRISK = 1,
                DOCDATE = _KANTAR.TARIH,
                FTIME = 254939409,
                GUID = Guid.NewGuid().ToString(),
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON) {
                if (con.State != ConnectionState.Open) {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try {
                    SqlCommand com = SIC.BM_XXX_XX_CLFLINE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    CLFLINELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_CLFLINE):", ex);
                } finally {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (CLFLINELOGICALREF > 0) {
                MessageBox.Show("SATIN ALMA FATURASI KAYDEDİLDİ!");
                this.Close();
            }
        }
        private void SB_KAYDET_Click(object sender, EventArgs e) {
            SAVE_INVOICE();
        }

        private void GRV_OPERATOR_YENISATINALMA_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.FieldName == "BIRIMFIYAT" || e.Column.FieldName == "MIKTAR") {
                try { BIRIMFIYAT = double.Parse(GRV_OPERATOR_YENISATINALMA.GetFocusedRowCellValue("BIRIMFIYAT").ToString()); } catch { }

                try { TOPLAM = Math.Round(BIRIMFIYAT * _KANTAR.MIKTAR, 2); } catch { }
                GRV_OPERATOR_YENISATINALMA.SetFocusedRowCellValue("TOPLAM", TOPLAM);
            }
        }
    }
}