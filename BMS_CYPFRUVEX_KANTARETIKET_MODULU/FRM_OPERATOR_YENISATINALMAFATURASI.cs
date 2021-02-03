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

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU
{
    public partial class FRM_OPERATOR_YENISATINALMAFATURASI : DevExpress.XtraEditors.XtraForm
    {
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
        double MIKTAR = 0;
        double BIRIMFIYAT = 0;
        double TUTAR = 0;
        double TOPLAM = 0;
        string FICHENO = "";
        public FRM_OPERATOR_YENISATINALMAFATURASI(CONFIG CFG, BMS_KE_KANTAR KANTAR)
        {
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
            PLAKAKODU = BMS_DLL.SQL.SELECT2(@"SELECT  
TOP 1 LGMAIN.GCODE   FROM L_TRADGRP LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_PLAKA.Text = PLAKAKODU + " - " + BMS_DLL.SQL.SELECT2(@"SELECT  
TOP 1 LGMAIN.GDEF  AD  FROM L_TRADGRP LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();

            string KONTAKTORKODU = BMS_DLL.SQL.SELECT2("SELECT TOP 1 CODE FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_KONTRAKTOR.Text = KONTAKTORKODU + " - " + BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
            string URETICIKODU = BMS_DLL.SQL.SELECT2("SELECT TOP 1 CODE FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_URETICI.Text = URETICIKODU + " - " + BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
            TE_BELGENO.Text = _KANTAR.TARTI_BELGE_NO;
            TE_ACIKLAMA.Text = _KANTAR.ACIKLAMA;
            TE_SOZLESME_NO.Text = _KANTAR.SOZLESME_NO;
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);

            MIKTAR = _KANTAR.MIKTAR;
            //TE_AMBAR.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 NAME  FROM L_CAPIWHOUSE WHERE NR=" + _KANTAR.AMBARID_GIDECEGIYERKOD + " AND FIRMNR=" + CFG.FIRMNR, SQLCON).Rows[0][0].ToString();
            TE_AMBAR.Text = _KANTAR.AMBARID_GIDECEGIYERKOD + " - " + _KANTAR.AMBARID_GIDECEGIYER;
            TE_BOLGEOZELKOD.Text = _KANTAR.OZELKOD_BOLGE;
            TE_BOLGEDETAYYETKIKOD.Text = _KANTAR.YETKIKOD_BOLGEDETAY;

            //TE_SOZLESMETURU_ODEMETAHSILATPLANI.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 DEFINITION_  FROM LG_" + CFG.FIRMNR + "_PAYPLANS WHERE LOGICALREF=" + _KANTAR.ODEMEPLANID_SOZLESMETURUKOD, SQLCON).Rows[0][0].ToString();
            TE_SOZLESMETURU_ODEMETAHSILATPLANI.Text = _KANTAR.ODEMEPLANID_SOZLESMETURU;
            //TE_SOSATISELEMANI.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 DEFINITION_  FROM LG_SLSMAN WHERE LOGICALREF=" + _KANTAR.SALEMANID_SOKOD + " AND FIRMNR=" + CFG.FIRMNR, SQLCON).Rows[0][0].ToString();
            TE_SOSATISELEMANI.Text = _KANTAR.SALEMANID_SO;
            DT_TARIH.DateTime = _KANTAR.TARIH;
            if (_KANTAR.TSTATUS == 1)
            {
                MessageBox.Show("BU FİŞ DAHA ÖNCE LOGOYA AKTARILMIŞTIR"); 
            }
        }
        private void INITIALIZEGRID()
        {
            _UOMREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.LOGICALREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", SQLCON).Rows[0][0].ToString();

            _UOSREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.UNITSETREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", SQLCON).Rows[0][0].ToString();
            //GRC_OPERATOR_YENISATINALMA.DataSource = BMS_DLL.SQL.SELECT2("SELECT LOGICALREF,URUNID, (SELECT TOP 1 NAME FROM LG_" + _CFG.FIRMNR + "_ITEMS I WHERE I.LOGICALREF=URUNID) URUN,MIKTAR,BIRIM, 0.00 BIRIMFIYAT, 0.00 TOPLAM FROM BMS_KE_KANTAR WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
            GRC_OPERATOR_YENISATINALMA.DataSource = BMS_DLL.SQL.SELECT2(@"
SELECT *, MIKTAR*BIRIMFIYAT TOPLAM FROM (
SELECT *, 
ISNULL(
ISNULL(
(SELECT TOP 1 P.PRICE FROM LG_" + _CFG.FIRMNR + @"_PRCLIST P WHERE 
P.CARDREF=" + _KANTAR.URUNID + @" AND P.PTYPE=1 AND P.ACTIVE=0 AND
P.CLIENTCODE=T.CLIENTCODE ORDER BY LOGICALREF DESC),
(SELECT TOP 1 P.PRICE FROM LG_" + _CFG.FIRMNR + @"_PRCLIST P WHERE 
P.CARDREF=" + _KANTAR.URUNID + @" AND P.PTYPE=1 AND P.ACTIVE=0  ORDER BY LOGICALREF DESC)
),0) BIRIMFIYAT 
FROM (
SELECT LOGICALREF, (SELECT C.CODE FROM LG_" + _CFG.FIRMNR + @"_CLCARD C WHERE C.LOGICALREF=URETICIID) CLIENTCODE," + _KANTAR.URUNID + @" URUNID,
(SELECT TOP 1 NAME FROM LG_" + _CFG.FIRMNR + @"_ITEMS I
 WHERE I.LOGICALREF=" + _KANTAR.URUNID + @") URUN,MIKTAR,'" + _KANTAR.BIRIM + @"' BIRIM /*, 0.00 BIRIMFIYAT, 0.00 TOPLAM*/ FROM BMS_KE_KANTAR
 ) AS T) AS T2 WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
            GRV_OPERATOR_YENISATINALMA.Columns["LOGICALREF"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["LOGICALREF"].Visible = false;
            GRV_OPERATOR_YENISATINALMA.Columns["URUNID"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["CLIENTCODE"].Visible = false;
            GRV_OPERATOR_YENISATINALMA.Columns["URUN"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["BIRIM"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.Columns["TOPLAM"].OptionsColumn.ReadOnly = true;
            GRV_OPERATOR_YENISATINALMA.BestFitColumns();
            try { BIRIMFIYAT = double.Parse(GRV_OPERATOR_YENISATINALMA.GetRowCellValue(0, "BIRIMFIYAT").ToString()); } catch { }
            try { TOPLAM = double.Parse(GRV_OPERATOR_YENISATINALMA.GetRowCellValue(0, "TOPLAM").ToString()); } catch { }
            try { TE_URUN.Text = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(0, "URUN").ToString(); } catch { }
        }

        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e)
        {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);
        }

        private void GRV_KANTAR_PLAKA_DoubleClick(object sender, EventArgs e)
        {
            //string ADI = int.Parse(GV_CFG_FIRMA_TANIMLARI.GetRowCellValue(GV_CFG_FIRMA_TANIMLARI.FocusedRowHandle, "ID").ToString()).ToString("D3");
            //base.DialogResult = DialogResult.OK;
            //LOGICALREF = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "LOGICALREF").ToString();
            //KOD = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "KOD").ToString();
            //AD = GRV_OPERATOR_YENISATINALMA.GetRowCellValue(GRV_OPERATOR_YENISATINALMA.FocusedRowHandle, "AD").ToString();
            //this.Close();
        }

        private void SB_VAZGEC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SAVE_INVOICE()
        {
            _KANTAR.TARIH = DT_TARIH.DateTime.Date;
            int INVOICELOGICALREF = 0;
            BM_XXX_XX_INVOICE O = new BM_XXX_XX_INVOICE()
            {
                AFFECTRISK = 1,
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CLIENTREF = _KANTAR.URETICIID,
                DATE_ = _KANTAR.TARIH.Date,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DOCDATE = _KANTAR.TARIH,
                ENTEGSET = 247,
                ESTATUS = 12,
                FICHENO = TE_FATURANO.Text,
                GENEXCTYP = 1,
                GENEXP2 = _KANTAR.SOZLESME_NO,
                DOCODE = TE_BELGENO.Text,
                GENEXP1 = TE_ACIKLAMA.Text,
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
                SOURCEINDEX = _KANTAR.AMBARID_GIDECEGIYERKOD,
                SOURCECOSTGRP = _KANTAR.AMBARID_GIDECEGIYERKOD,
                SPECODE = _KANTAR.OZELKOD_BOLGEKOD,
                CYPHCODE = _KANTAR.YETKIKOD_BOLGEDETAYKOD,
                PAYDEFREF = _KANTAR.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = _KANTAR.SALEMANID_SOKOD
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_INVOICE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    INVOICELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_INVOICE):", ex);
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (INVOICELOGICALREF > 0)
            {
                SAVE_STFICHE(INVOICELOGICALREF);
            }
        }

        private void SAVE_STFICHE(int _INVOICEREF)
        {
            int STFICHELOGICALREF = 0;
            BM_XXX_XX_STFICHE O = new BM_XXX_XX_STFICHE()
            {
                AFFECTRISK = 1,
                BILLED = 1,
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CAPIBLOCK_CREATEDSEC = DateTime.Now.Second,
                CLIENTREF = _KANTAR.URETICIID,
                GENEXP2 = _KANTAR.SOZLESME_NO,
                DATE_ = _KANTAR.TARIH.Date,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DISPSTATUS = 1,
                DOCTIME = 254939409,
                FICHECNT = 1,
                FICHENO = TE_FATURANO.Text,
                FTIME = 254939409,
                GENEXCTYP = 1,
                GROSSTOTAL = TOPLAM,
                GRPCODE = 1,
                DOCODE = TE_BELGENO.Text,
                GENEXP1 = TE_ACIKLAMA.Text,
                GUID = Guid.NewGuid().ToString(),
                INVNO = TE_FATURANO.Text,
                INVOICEREF = _INVOICEREF,
                IOCODE = 1,
                NETTOTAL = TOPLAM,
                RECVREF = _KANTAR.KONTRAKTORID,
                SHIPDATE = _KANTAR.TARIH,
                SHIPTIME = 254939409,
                TOTALDISCOUNTED = TOPLAM,
                TRADINGGRP = PLAKAKODU,
                TRCODE = 1,
                SOURCEINDEX = _KANTAR.AMBARID_GIDECEGIYERKOD,
                SOURCECOSTGRP = _KANTAR.AMBARID_GIDECEGIYERKOD,
                SPECODE = _KANTAR.OZELKOD_BOLGEKOD,
                CYPHCODE = _KANTAR.YETKIKOD_BOLGEDETAYKOD,
                PAYDEFREF = _KANTAR.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = _KANTAR.SALEMANID_SOKOD
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_STFICHE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    STFICHELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_STFICHE):", ex);
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (STFICHELOGICALREF > 0)
            {
                SAVE_STLINE(_INVOICEREF, STFICHELOGICALREF);
            }
        }
        private void SAVE_STLINE(int _INVOICEREF, int _STFICHEREF)
        {
            int STLINELOGICALREF = 0;
            BM_XXX_XX_STLINE O = new BM_XXX_XX_STLINE()
            {
                STOCKREF = _KANTAR.URUNID,
                TRCODE = 1,
                DATE_ = _KANTAR.TARIH.Date,
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
                FUTMONTHBEGDATE = 132385566,
                SOURCEINDEX = _KANTAR.AMBARID_GIDECEGIYERKOD,
                SOURCECOSTGRP = _KANTAR.AMBARID_GIDECEGIYERKOD,
                SPECODE = _KANTAR.OZELKOD_BOLGEKOD,
                PAYDEFREF = _KANTAR.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = _KANTAR.SALEMANID_SOKOD
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_STLINE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    STLINELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_STLINE):", ex);
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (STLINELOGICALREF > 0)
            {
                SAVE_PAYTRANS(_INVOICEREF, _STFICHEREF);
            }
        }

        private void SAVE_PAYTRANS(int _INVOICEREF, int _STFICHEREF)
        {
            int PAYTRANSLOGICALREF = 0;
            BM_XXX_XX_PAYTRANS O = new BM_XXX_XX_PAYTRANS()
            {
                CARDREF = _KANTAR.URETICIID,
                DATE_ = _KANTAR.TARIH,
                MODULENR = 4,
                SIGN = 1,
                FICHEREF = _INVOICEREF,
                TRCODE = 1,
                TOTAL = TOPLAM,
                PROCDATE = _KANTAR.TARIH,
                DISCDUEDATE = _KANTAR.TARIH,
                PAYNO = 1,
                SPECODE = _KANTAR.OZELKOD_BOLGEKOD,

            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_PAYTRANS_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    PAYTRANSLOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_PAYTRANS):", ex);
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (PAYTRANSLOGICALREF > 0)
            {
                SAVE_CLFLINE(_INVOICEREF, _STFICHEREF);
            }
        }
        private void SAVE_CLFLINE(int _INVOICEREF, int _STFICHEREF)
        {
            int CLFLINELOGICALREF = 0;
            BM_XXX_XX_CLFLINE O = new BM_XXX_XX_CLFLINE()
            {
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
                SPECODE = _KANTAR.OZELKOD_BOLGE,
                PAYDEFREF = _KANTAR.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = _KANTAR.SALEMANID_SOKOD
            };

            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_CLFLINE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    CLFLINELOGICALREF = int.Parse(com.ExecuteScalar().ToString());
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_CLFLINE):", ex);
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            if (CLFLINELOGICALREF > 0)
            {
                MessageBox.Show("SATIN ALMA FATURASI KAYDEDİLDİ!");
                SQLCON = new SqlConnection(LGCONSTR);
                BMS_DLL.SQL.EXECUTE2(this, "UPDATE BMS_KE_KANTAR SET LOGOAKTARIMI=1,LOGOAKTARIMTARIHI=GETDATE(),LOGOFISID="+_INVOICEREF+", TSTATUS=1 WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
                this.Close();
            }
        }
        private void UPDATE()
        {
            SQLCON = new SqlConnection(LGCONSTR);
            BMS_KE_KANTAR O = new BMS_KE_KANTAR();
            O.LOGICALREF = _KANTAR.LOGICALREF;
            O.BARKODYAZIMMIKTAR = 0;
            O.BIRIM = _KANTAR.BIRIM;
            O.KONTRAKTORID = _KANTAR.KONTRAKTORID;
            O.MIKTAR = MIKTAR;
            O.PLAKAID = _KANTAR.PLAKAID;
            O.TARIH = DT_TARIH.DateTime.Date;
            O.TSTATUS = 0;
            O.URETICIID = _KANTAR.URETICIID;
            O.URUNID = _KANTAR.URUNID;
            O.ERRORMESSAGE = "";
            O.KULLANICI = "";
            O.ACIKLAMA = TE_ACIKLAMA.Text == "ZORUNLU DEĞİL" ? "" : TE_ACIKLAMA.Text;
            O.TARTI_BELGE_NO = TE_BELGENO.Text;
            O.SOZLESME_NO = TE_SOZLESME_NO.Text;

            O.AMBARID_GIDECEGIYERKOD = _KANTAR.AMBARID_GIDECEGIYERKOD;
            O.OZELKOD_BOLGEKOD = _KANTAR.OZELKOD_BOLGEKOD;
            O.YETKIKOD_BOLGEDETAYKOD = _KANTAR.YETKIKOD_BOLGEDETAYKOD;
            O.ODEMEPLANID_SOZLESMETURUKOD = _KANTAR.ODEMEPLANID_SOZLESMETURUKOD;
            O.SALEMANID_SOKOD = _KANTAR.SALEMANID_SOKOD;


            O.AMBARID_GIDECEGIYER = _KANTAR.AMBARID_GIDECEGIYER;
            O.OZELKOD_BOLGE = _KANTAR.OZELKOD_BOLGE;
            O.YETKIKOD_BOLGEDETAY = _KANTAR.YETKIKOD_BOLGEDETAY;
            O.ODEMEPLANID_SOZLESMETURU = _KANTAR.ODEMEPLANID_SOZLESMETURU;
            O.SALEMANID_SO = _KANTAR.SALEMANID_SO;
            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BMS_KE_KANTAR_UPDATE(O, true, false);
                    com.Connection = con;
                    com.Transaction = transaction;
                    com.ExecuteScalar();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(KANTAR_FIS_KAYIT):", ex);
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            SQLCON = new SqlConnection(LGCONSTR);
        }
        private void SB_KAYDET_Click(object sender, EventArgs e)
        {
            if (_KANTAR.TSTATUS == 1)
            {
                MessageBox.Show("BU FİŞ DAHA ÖNCE LOGOYA AKTARILMIŞTIR");
                return;
            }
            int CARD_CODE_NO = 0;
            try { CARD_CODE_NO = int.Parse(BMS_DLL.SQL.SELECT2(string.Format(@"SELECT RIGHT(FICHENO,5) F FROM (
SELECT MAX(FICHENO) FICHENO FROM LG_" + _CFG.FIRMNR + @"_01_INVOICE where TRCODE=1 AND FICHENO LIKE 'BMS.%'
) AS T
"), SQLCON).Rows[0][0].ToString()) + 1; } catch { }

            TE_FATURANO.Text = "BMS." + CARD_CODE_NO.ToString().PadLeft(5, '0'); ;
            UPDATE();
            SAVE_INVOICE();
        }

        private void GRV_OPERATOR_YENISATINALMA_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "BIRIMFIYAT" || e.Column.FieldName == "MIKTAR")
            {
                MIKTAR = _KANTAR.MIKTAR;
                try { BIRIMFIYAT = double.Parse(GRV_OPERATOR_YENISATINALMA.GetFocusedRowCellValue("BIRIMFIYAT").ToString()); } catch { }
                try { MIKTAR = double.Parse(GRV_OPERATOR_YENISATINALMA.GetFocusedRowCellValue("MIKTAR").ToString()); } catch { }
                try { TOPLAM = Math.Round(BIRIMFIYAT * MIKTAR, 2); } catch { }
                GRV_OPERATOR_YENISATINALMA.SetFocusedRowCellValue("TOPLAM", TOPLAM);
            }
        }

        private void SB_PLAKA_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARPLAKA F = new FRM_KANTARPLAKA(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.PLAKAID = int.Parse(F.LOGICALREF);
                    PLAKAKODU = F.KOD;
                    //TE_PLAKAKODU.Text = F.KOD;
                    //TE_PLAKA.Text = F.AD;
                    //PLAKALOGICALREF = F.LOGICALREF;
                    TE_PLAKA.Text = PLAKAKODU + " - " + BMS_DLL.SQL.SELECT2(@"SELECT  
TOP 1 LGMAIN.GDEF  AD  FROM L_TRADGRP LGMAIN WITH(NOLOCK) 
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();
                }
            }
        }

        private void SB_URETICI_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARURETICI F = new FRM_KANTARURETICI(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    //TE_URETICIKODU.Text = F.KOD;
                    //TE_URETICI.Text = F.AD;
                    //URETICILOGICALREF = F.LOGICALREF;
                    _KANTAR.URETICIID = int.Parse(F.LOGICALREF);
                    string URETICIKODU = BMS_DLL.SQL.SELECT2("SELECT TOP 1 CODE FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
                    TE_URETICI.Text = URETICIKODU + " - " + BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
                }
            }
        }

        private void SB_KONTRAKTOR_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARKONTRAKTOR F = new FRM_KANTARKONTRAKTOR(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.KONTRAKTORID = int.Parse(F.LOGICALREF);
                    string KONTAKTORKODU = BMS_DLL.SQL.SELECT2("SELECT TOP 1 CODE FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
                    TE_KONTRAKTOR.Text = KONTAKTORKODU + " - " + BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
                }
            }
        }

        private void SB_GIDECEGIYER_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARGIDECEGIYER F = new FRM_KANTARGIDECEGIYER(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    //TE_AMBAR_GIDECEGIYERKOD.Text = F.LOGICALREF;
                    //TE_AMBAR_GIDECEGIYER.Text = F.AD;
                    //AMBARID_GIDECEGIYER = F.LOGICALREF;
                    _KANTAR.AMBARID_GIDECEGIYERKOD = int.Parse(F.LOGICALREF);
                    _KANTAR.AMBARID_GIDECEGIYER = F.AD;

                    TE_AMBAR.Text = _KANTAR.AMBARID_GIDECEGIYERKOD + " - " + _KANTAR.AMBARID_GIDECEGIYER;
                }
            }
        }

        private void SB_BOLGE_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARBOLGE F = new FRM_KANTARBOLGE(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.OZELKOD_BOLGE = F.AD;
                    _KANTAR.OZELKOD_BOLGEKOD = F.KOD;
                    TE_BOLGEOZELKOD.Text = _KANTAR.OZELKOD_BOLGE;
                }
            }
        }

        private void SB_BOLGEDETAY_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARBOLGEDETAY F = new FRM_KANTARBOLGEDETAY(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.YETKIKOD_BOLGEDETAY = F.AD;
                    _KANTAR.YETKIKOD_BOLGEDETAYKOD = F.KOD;
                    TE_BOLGEDETAYYETKIKOD.Text = _KANTAR.YETKIKOD_BOLGEDETAY;

                }
            }
        }

        private void SB_SOZLESMETURU_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARSOZLESMETURU F = new FRM_KANTARSOZLESMETURU(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.ODEMEPLANID_SOZLESMETURU = F.AD;
                    _KANTAR.ODEMEPLANID_SOZLESMETURUKOD = int.Parse(F.LOGICALREF);
                    TE_SOZLESMETURU_ODEMETAHSILATPLANI.Text = _KANTAR.ODEMEPLANID_SOZLESMETURU;

                }
            }
        }

        private void SB_SO_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARSO F = new FRM_KANTARSO(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.SALEMANID_SO = F.AD;
                    _KANTAR.SALEMANID_SOKOD = int.Parse(F.LOGICALREF);
                    TE_SOSATISELEMANI.Text = _KANTAR.SALEMANID_SO;
                }
            }
        }

        private void SB_URUN_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARURUN F = new FRM_KANTARURUN(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    _KANTAR.URUNID = int.Parse(F.LOGICALREF);
                    TE_URUN.Text = F.AD;
                    _KANTAR.BIRIM = F.BIRIM;
                    INITIALIZEGRID();
                }
            }
        }


    }
}