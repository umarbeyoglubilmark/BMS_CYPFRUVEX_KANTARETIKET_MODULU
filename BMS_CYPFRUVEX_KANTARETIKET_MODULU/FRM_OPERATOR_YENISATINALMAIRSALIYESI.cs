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
using BMS_DLL.OBJECTS;
using System.Globalization;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU
{
    public partial class FRM_OPERATOR_YENISATINALMAIRSALIYESI : DevExpress.XtraEditors.XtraForm
    {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        BMS_KE_KANTAR _KANTAR = new BMS_KE_KANTAR();
        SQLINSERTCOMMANDS SIC = new SQLINSERTCOMMANDS();
        SQLUPDATECOMMANDS SUC = new SQLUPDATECOMMANDS();
        string PLAKAKODU = "";
        public string _UOMREF = "0";
        public string _UOSREF = "0";
        double MIKTAR = 0;
        double BINLIKSAYISI = 0;
        double BIRIMFIYAT = 0;
        double TUTAR = 0;
        double TOPLAM = 0;
        string FICHENO = "";
        double ARAC_TONAJ = 0;
        double EKSIK_YUKLEME = 0;

        public FRM_OPERATOR_YENISATINALMAIRSALIYESI(CONFIG CFG, BMS_KE_KANTAR KANTAR)
        {
            InitializeComponent();
            _CFG = CFG;
            _KANTAR = KANTAR;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);

            SQLCON = new SqlConnection(LGCONSTR);
            DT_TARIH.DateTime = DateTime.Now;
            l_Barcode.Text = _KANTAR.LOGICALREF.ToString();
            if (_KANTAR.PLAKAID > 0)
                PLAKAKODU = BMS_DLL.SQL.SELECT2(@"SELECT
TOP 1 LGMAIN.GCODE   FROM L_TRADGRP LGMAIN WITH(NOLOCK)
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();

            if (_KANTAR.PLAKAID > 0)
                TE_PLAKA.Text = PLAKAKODU + " - " + BMS_DLL.SQL.SELECT2(@"SELECT
TOP 1 LGMAIN.GDEF  AD  FROM L_TRADGRP LGMAIN WITH(NOLOCK)
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();

            // Arac tonajini al
            try
            {
                ARAC_TONAJ = double.Parse(BMS_DLL.SQL.SELECT2(@"SELECT ISNULL(TONAJ, 0) FROM BM_" + CFG.FIRMNR + "_CYPFRUVEX_ARACKAYIT WHERE TRADINGGRP='" + PLAKAKODU + "'", SQLCON).Rows[0][0].ToString());
            }
            catch { ARAC_TONAJ = 0; }

            EKSIK_YUKLEME = ARAC_TONAJ - _KANTAR.MIKTAR;
            if (EKSIK_YUKLEME < 0) EKSIK_YUKLEME = 0;
            UpdateEksikYuklemeDisplay();

            string KONTAKTORKODU = "0";
            try { KONTAKTORKODU = BMS_DLL.SQL.SELECT2("SELECT TOP 1 CODE FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString(); }
            catch (Exception EX) { BMS_DLL.GLOBAL.LOGYAZ("KONTAKTORKODU HATA", EX); }
            TE_KONTRAKTOR.Text = KONTAKTORKODU + " - " + BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.KONTRAKTORID.ToString(), SQLCON).Rows[0][0].ToString();
            string URETICIKODU = "0";
            try { URETICIKODU = BMS_DLL.SQL.SELECT2("SELECT TOP 1 CODE FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString(); }
            catch (Exception EX) { BMS_DLL.GLOBAL.LOGYAZ("URETICIKODU HATA", EX); }
            try
            {
                TE_URETICI.Text = URETICIKODU + " - " + BMS_DLL.SQL.SELECT2("SELECT TOP 1 DEFINITION_ FROM LG_" + CFG.FIRMNR + "_CLCARD WHERE LOGICALREF=" + _KANTAR.URETICIID.ToString(), SQLCON).Rows[0][0].ToString();
            }
            catch (Exception EX) { BMS_DLL.GLOBAL.LOGYAZ("CLCARD DEFINITION_ HATA", EX); }
            TE_BELGENO.Text = _KANTAR.TARTI_BELGE_NO;
            TE_ACIKLAMA.Text = _KANTAR.ACIKLAMA;
            TE_SOZLESME_NO.Text = _KANTAR.SOZLESME_NO;
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);

            MIKTAR = _KANTAR.MIKTAR;
            TE_AMBAR.Text = _KANTAR.AMBARID_GIDECEGIYERKOD + " - " + _KANTAR.AMBARID_GIDECEGIYER;
            TE_BOLGEOZELKOD.Text = _KANTAR.OZELKOD_BOLGE;
            TE_BOLGEDETAYYETKIKOD.Text = _KANTAR.YETKIKOD_BOLGEDETAY;
            TE_SOZLESMETURU_ODEMETAHSILATPLANI.Text = _KANTAR.ODEMEPLANID_SOZLESMETURU;
            TE_SOSATISELEMANI.Text = _KANTAR.SALEMANID_SO;
            BINLIKSAYISI = _KANTAR.BINLIKSAYISI;
            TE_BINLIKSAYISI.Text = BINLIKSAYISI.ToString();
            DT_TARIH.DateTime = _KANTAR.TARIH;
            if (_KANTAR.TSTATUS == 2)
            {
                MessageBox.Show("BU FIS DAHA ONCE IRSALIYE OLARAK LOGOYA AKTARILMISTIR");
                TE_IRSALIYENO.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 FICHENO FROM LG_" + _CFG.FIRMNR + "_01_STFICHE WHERE LOGICALREF=" + _KANTAR.LOGOFISID, new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
            }
        }

        private void UpdateEksikYuklemeDisplay()
        {
            if (ARAC_TONAJ > 0 && _KANTAR.MIKTAR < ARAC_TONAJ)
            {
                EKSIK_YUKLEME = ARAC_TONAJ - _KANTAR.MIKTAR;
                TE_EKSIK_YUKLEME.Text = EKSIK_YUKLEME.ToString("N2") + " KG EKSIK";
                TE_EKSIK_YUKLEME.Appearance.ForeColor = System.Drawing.Color.Red;
                TE_ARAC_TONAJ.Text = ARAC_TONAJ.ToString("N2") + " KG";
            }
            else if (ARAC_TONAJ > 0)
            {
                TE_EKSIK_YUKLEME.Text = "TAM YUKLEME";
                TE_EKSIK_YUKLEME.Appearance.ForeColor = System.Drawing.Color.Green;
                TE_ARAC_TONAJ.Text = ARAC_TONAJ.ToString("N2") + " KG";
            }
            else
            {
                TE_EKSIK_YUKLEME.Text = "-";
                TE_ARAC_TONAJ.Text = "TANIMSIZ";
            }
        }

        private void INITIALIZEGRID()
        {
            try
            {
                _UOMREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.LOGICALREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", SQLCON).Rows[0][0].ToString();
            }
            catch (Exception EX)
            {
                BMS_DLL.GLOBAL.LOGYAZ("INITIALIZEGRID _UOMREF HATA", EX);
            }
            try
            {
                _UOSREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.UNITSETREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", SQLCON).Rows[0][0].ToString();
            }
            catch (Exception EX)
            {
                BMS_DLL.GLOBAL.LOGYAZ("INITIALIZEGRID _UOSREF HATA", EX);
            }
            try
            {
                GRC_OPERATOR_YENISATINALMA.DataSource = BMS_DLL.SQL.SELECT2(@"
SELECT *, MIKTAR*BIRIMFIYAT TOPLAM FROM (
SELECT *,
ISNULL(
ISNULL(
(SELECT TOP 1 P.PRICE FROM LG_" + _CFG.FIRMNR + @"_PRCLIST P WHERE
P.CARDREF=" + _KANTAR.URUNID + @" AND P.PTYPE=1 AND P.ACTIVE=0 AND P.PAYPLANREF='" + _KANTAR.ODEMEPLANID_SOZLESMETURUKOD + @"' AND
P.CLIENTCODE=T.CLIENTCODE ORDER BY LOGICALREF DESC),
(SELECT TOP 1 P.PRICE FROM LG_" + _CFG.FIRMNR + @"_PRCLIST P WHERE
P.CARDREF=" + _KANTAR.URUNID + @" AND P.PTYPE=1 AND P.ACTIVE=0 AND P.PAYPLANREF='" + _KANTAR.ODEMEPLANID_SOZLESMETURUKOD + @"' AND ISNULL(P.CLIENTCODE,'')=''  ORDER BY LOGICALREF DESC)
),0) BIRIMFIYAT
FROM (
SELECT LOGICALREF, (SELECT C.CODE FROM LG_" + _CFG.FIRMNR + @"_CLCARD C WHERE C.LOGICALREF=URETICIID) CLIENTCODE," + _KANTAR.URUNID + @" URUNID,
(SELECT TOP 1 NAME FROM LG_" + _CFG.FIRMNR + @"_ITEMS I
 WHERE I.LOGICALREF=" + _KANTAR.URUNID + @") URUN,MIKTAR,'" + _KANTAR.BIRIM + @"' BIRIM FROM BMS_KE_KANTAR
 ) AS T) AS T2 WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
            }
            catch (Exception EX)
            {
                BMS_DLL.GLOBAL.LOGYAZ("INITIALIZEGRID GRC_OPERATOR_YENISATINALMA.DataSource HATA", EX);
            }
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

        private void FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_OPERATOR_YENISATINALMA, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRV_OPERATOR_YENISATINALMA.Name);
        }

        private void SB_VAZGEC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SAVE_STFICHE_IRSALIYE()
        {
            _KANTAR.TARIH = DT_TARIH.DateTime.Date;
            int STFICHELOGICALREF = 0;
            BM_XXX_XX_STFICHE O = new BM_XXX_XX_STFICHE()
            {
                AFFECTRISK = 1,
                BILLED = 0, // IRSALIYE ICIN BILLED=0
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CAPIBLOCK_CREATEDSEC = DateTime.Now.Second,
                CLIENTREF = _KANTAR.URETICIID,
                GENEXP2 = "SOZLESME NO:" + _KANTAR.SOZLESME_NO,
                DATE_ = _KANTAR.TARIH.Date,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DISPSTATUS = 1,
                DOCTIME = 254939409,
                FICHECNT = 1,
                FICHENO = TE_IRSALIYENO.Text,
                FTIME = 254939409,
                GENEXCTYP = 1,
                GROSSTOTAL = TOPLAM,
                GRPCODE = 1,
                DOCODE = TE_BELGENO.Text,
                GENEXP1 = TE_ACIKLAMA.Text,
                GUID = Guid.NewGuid().ToString(),
                INVNO = "",
                INVOICEREF = 0, // IRSALIYE ICIN INVOICEREF=0
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
                SALESMANREF = _KANTAR.SALEMANID_SOKOD,
                GENEXP3 = "BINLIK SAYISI:" + _KANTAR.BINLIKSAYISI.ToString()
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
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_STFICHE_IRSALIYE):", ex);
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
                SAVE_STLINE_IRSALIYE(STFICHELOGICALREF);
            }
        }

        private void SAVE_STLINE_IRSALIYE(int _STFICHEREF)
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
                INVOICEREF = 0, // IRSALIYE ICIN INVOICEREF=0
                INVOICELNNO = 0,
                CLIENTREF = _KANTAR.URETICIID,
                AMOUNT = _KANTAR.MIKTAR,
                PRICE = BIRIMFIYAT,
                TOTAL = TOPLAM,
                UOMREF = int.Parse(_UOMREF),
                USREF = int.Parse(_UOSREF),
                UINFO1 = 1,
                UINFO2 = 1,
                VATMATRAH = TOPLAM,
                BILLED = 0, // IRSALIYE ICIN BILLED=0
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
                SALESMANREF = _KANTAR.SALEMANID_SOKOD,
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
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SAVE_STLINE_IRSALIYE):", ex);
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
                MessageBox.Show("SATINALMA IRSALIYESI KAYDEDILDI!");
                SQLCON = new SqlConnection(LGCONSTR);
                BMS_DLL.SQL.EXECUTE2(this, "UPDATE BMS_KE_KANTAR SET LOGOAKTARIMI=1,LOGOAKTARIMTARIHI=GETDATE(),LOGOFISID=" + _STFICHEREF + ", TSTATUS=2 WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), SQLCON);
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
            O.LOGOFISID = _KANTAR.LOGOFISID > 0 ? _KANTAR.LOGOFISID : 0;
            O.KONTRAKTORID = _KANTAR.KONTRAKTORID;
            O.MIKTAR = _KANTAR.MIKTAR;
            O.PLAKAID = _KANTAR.PLAKAID;
            O.TARIH = DT_TARIH.DateTime.Date;
            O.TSTATUS = _KANTAR.LOGOFISID > 0 ? 2 : 0;
            O.URETICIID = _KANTAR.URETICIID;
            O.URUNID = _KANTAR.URUNID;
            O.ERRORMESSAGE = "";
            O.KULLANICI = "";
            O.ACIKLAMA = TE_ACIKLAMA.Text == "ZORUNLU DEGIL" ? "" : TE_ACIKLAMA.Text;
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
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(KANTAR_IRSALIYE_KAYIT):", ex);
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
            if (_KANTAR.TSTATUS == 2)
            {
                MessageBox.Show("BU FIS DAHA ONCE IRSALIYE OLARAK KAYDEDILMISTIR");
                return;
            }

            int CARD_CODE_NO = 0;
            try
            {
                CARD_CODE_NO = int.Parse(BMS_DLL.SQL.SELECT2(string.Format(@"SELECT RIGHT(FICHENO,5) F FROM (
SELECT MAX(FICHENO) FICHENO FROM LG_" + _CFG.FIRMNR + @"_01_STFICHE where TRCODE=1 AND FICHENO LIKE 'IRS.%'
) AS T
"), SQLCON).Rows[0][0].ToString()) + 1;
            }
            catch { }

            TE_IRSALIYENO.Text = "IRS." + CARD_CODE_NO.ToString().PadLeft(5, '0');

            UPDATE();
            SAVE_STFICHE_IRSALIYE();
        }

        private void GRV_OPERATOR_YENISATINALMA_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "BIRIMFIYAT" || e.Column.FieldName == "MIKTAR")
            {
                try { _KANTAR.MIKTAR = double.Parse(GRV_OPERATOR_YENISATINALMA.GetFocusedRowCellValue("MIKTAR").ToString()); } catch { }
                try { BIRIMFIYAT = double.Parse(GRV_OPERATOR_YENISATINALMA.GetFocusedRowCellValue("BIRIMFIYAT").ToString()); } catch { }
                try { TOPLAM = Math.Round(BIRIMFIYAT * _KANTAR.MIKTAR, 2); } catch { }
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
                    TE_PLAKA.Text = PLAKAKODU + " - " + BMS_DLL.SQL.SELECT2(@"SELECT
TOP 1 LGMAIN.GDEF  AD  FROM L_TRADGRP LGMAIN WITH(NOLOCK)
 WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), SQLCON).Rows[0][0].ToString();

                    // Tonaj guncelle
                    try
                    {
                        ARAC_TONAJ = double.Parse(BMS_DLL.SQL.SELECT2(@"SELECT ISNULL(TONAJ, 0) FROM BM_" + _CFG.FIRMNR + "_CYPFRUVEX_ARACKAYIT WHERE TRADINGGRP='" + PLAKAKODU + "'", SQLCON).Rows[0][0].ToString());
                    }
                    catch { ARAC_TONAJ = 0; }
                    UpdateEksikYuklemeDisplay();
                }
            }
        }

        private void SB_URETICI_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARURETICI F = new FRM_KANTARURETICI(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
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
