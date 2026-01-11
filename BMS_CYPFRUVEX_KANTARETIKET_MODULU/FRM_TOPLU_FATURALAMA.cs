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
    public partial class FRM_TOPLU_FATURALAMA : DevExpress.XtraEditors.XtraForm
    {
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        SQLINSERTCOMMANDS SIC = new SQLINSERTCOMMANDS();
        SQLUPDATECOMMANDS SUC = new SQLUPDATECOMMANDS();
        List<int> SECILI_KAYITLAR = new List<int>();

        public FRM_TOPLU_FATURALAMA(CONFIG CFG)
        {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
                _CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            SQLCON = new SqlConnection(LGCONSTR);
            DT_BASLANGIC.DateTime = DateTime.Now.AddDays(-30);
            DT_BITIS.DateTime = DateTime.Now;
            GRIDRESTORE();
        }

        private void GRIDRESTORE()
        {
            try
            {
                string TARIH1 = DT_BASLANGIC.DateTime.ToString("yyyy-MM-dd");
                string TARIH2 = DT_BITIS.DateTime.ToString("yyyy-MM-dd");

                GRC_KAYITLAR.DataSource = BMS_DLL.SQL.SELECT2(@"
SELECT
    K.LOGICALREF,
    CAST(0 AS BIT) AS SEC,
    K.TARIH,
    K.TARTI_BELGE_NO AS BELGENO,
    (SELECT TOP 1 GDEF FROM L_TRADGRP T WHERE T.LOGICALREF = K.PLAKAID) AS PLAKA,
    (SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + @"_CLCARD C WHERE C.LOGICALREF = K.URETICIID) AS URETICI,
    (SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + @"_CLCARD C WHERE C.LOGICALREF = K.KONTRAKTORID) AS KONTRAKTOR,
    (SELECT TOP 1 NAME FROM LG_" + _CFG.FIRMNR + @"_ITEMS I WHERE I.LOGICALREF = K.URUNID) AS URUN,
    K.MIKTAR,
    K.BIRIM,
    K.SOZLESME_NO,
    K.ACIKLAMA,
    CASE K.TSTATUS
        WHEN 0 THEN 'BEKLIYOR'
        WHEN 1 THEN 'FATURALANMIS'
        WHEN 2 THEN 'IRSALIYE'
    END AS DURUM
FROM BMS_KE_KANTAR K
WHERE K.TSTATUS = 0
AND K.TARIH BETWEEN '" + TARIH1 + @"' AND '" + TARIH2 + @"'
ORDER BY K.TARIH DESC, K.LOGICALREF DESC
", SQLCON);

                GRV_KAYITLAR.Columns["LOGICALREF"].Visible = false;
                GRV_KAYITLAR.Columns["SEC"].Caption = "Sec";
                GRV_KAYITLAR.Columns["TARIH"].Caption = "Tarih";
                GRV_KAYITLAR.Columns["BELGENO"].Caption = "Belge No";
                GRV_KAYITLAR.Columns["PLAKA"].Caption = "Plaka";
                GRV_KAYITLAR.Columns["URETICI"].Caption = "Uretici";
                GRV_KAYITLAR.Columns["KONTRAKTOR"].Caption = "Kontraktor";
                GRV_KAYITLAR.Columns["URUN"].Caption = "Urun";
                GRV_KAYITLAR.Columns["MIKTAR"].Caption = "Miktar";
                GRV_KAYITLAR.Columns["BIRIM"].Caption = "Birim";
                GRV_KAYITLAR.Columns["SOZLESME_NO"].Caption = "Sozlesme No";
                GRV_KAYITLAR.Columns["ACIKLAMA"].Caption = "Aciklama";
                GRV_KAYITLAR.Columns["DURUM"].Caption = "Durum";
                GRV_KAYITLAR.BestFitColumns();
            }
            catch (Exception ex)
            {
                BMS_DLL.GLOBAL.LOGYAZ("TOPLU_FATURALAMA GRIDRESTORE HATA", ex);
            }
        }

        private void SB_FILTRELE_Click(object sender, EventArgs e)
        {
            GRIDRESTORE();
        }

        private void SB_TUMUNU_SEC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GRV_KAYITLAR.RowCount; i++)
            {
                GRV_KAYITLAR.SetRowCellValue(i, "SEC", true);
            }
        }

        private void SB_SECIMI_KALDIR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GRV_KAYITLAR.RowCount; i++)
            {
                GRV_KAYITLAR.SetRowCellValue(i, "SEC", false);
            }
        }

        private void SB_TOPLU_FATURALA_Click(object sender, EventArgs e)
        {
            SECILI_KAYITLAR.Clear();
            int TOPLAM_SECILI = 0;

            for (int i = 0; i < GRV_KAYITLAR.RowCount; i++)
            {
                bool secili = false;
                try { secili = bool.Parse(GRV_KAYITLAR.GetRowCellValue(i, "SEC").ToString()); } catch { }
                if (secili)
                {
                    int logicalref = int.Parse(GRV_KAYITLAR.GetRowCellValue(i, "LOGICALREF").ToString());
                    SECILI_KAYITLAR.Add(logicalref);
                    TOPLAM_SECILI++;
                }
            }

            if (TOPLAM_SECILI == 0)
            {
                MessageBox.Show("Lutfen en az bir kayit seciniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(TOPLAM_SECILI + " adet kayit faturalanacak. Devam etmek istiyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int BASARILI = 0;
                int HATALI = 0;

                foreach (int kantarRef in SECILI_KAYITLAR)
                {
                    try
                    {
                        BMS_KE_KANTAR kantar = KANTAR_GETIR(kantarRef);
                        if (kantar != null && kantar.LOGICALREF > 0)
                        {
                            FATURA_OLUSTUR(kantar);
                            BASARILI++;
                        }
                        else
                        {
                            HATALI++;
                        }
                    }
                    catch (Exception ex)
                    {
                        BMS_DLL.GLOBAL.LOGYAZ("TOPLU FATURALAMA HATA - REF:" + kantarRef, ex);
                        HATALI++;
                    }
                }

                MessageBox.Show("Islem tamamlandi!\nBasarili: " + BASARILI + "\nHatali: " + HATALI, "SONUC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GRIDRESTORE();
            }
        }

        private BMS_KE_KANTAR KANTAR_GETIR(int logicalref)
        {
            BMS_KE_KANTAR kantar = new BMS_KE_KANTAR();
            try
            {
                DataTable dt = BMS_DLL.SQL.SELECT2(@"SELECT * FROM BMS_KE_KANTAR WHERE LOGICALREF=" + logicalref, new SqlConnection(LGCONSTR));
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    kantar.LOGICALREF = int.Parse(row["LOGICALREF"].ToString());
                    kantar.TARIH = DateTime.Parse(row["TARIH"].ToString());
                    kantar.PLAKAID = int.Parse(row["PLAKAID"].ToString());
                    kantar.KONTRAKTORID = int.Parse(row["KONTRAKTORID"].ToString());
                    kantar.URETICIID = int.Parse(row["URETICIID"].ToString());
                    kantar.URUNID = int.Parse(row["URUNID"].ToString());
                    kantar.MIKTAR = double.Parse(row["MIKTAR"].ToString());
                    kantar.BIRIM = row["BIRIM"].ToString();
                    kantar.TARTI_BELGE_NO = row["TARTI_BELGE_NO"].ToString();
                    kantar.SOZLESME_NO = row["SOZLESME_NO"].ToString();
                    kantar.ACIKLAMA = row["ACIKLAMA"].ToString();
                    try { kantar.AMBARID_GIDECEGIYERKOD = int.Parse(row["AMBARID_GIDECEGIYERKOD"].ToString()); } catch { }
                    try { kantar.OZELKOD_BOLGEKOD = row["OZELKOD_BOLGEKOD"].ToString(); } catch { }
                    try { kantar.YETKIKOD_BOLGEDETAYKOD = row["YETKIKOD_BOLGEDETAYKOD"].ToString(); } catch { }
                    try { kantar.ODEMEPLANID_SOZLESMETURUKOD = int.Parse(row["ODEMEPLANID_SOZLESMETURUKOD"].ToString()); } catch { }
                    try { kantar.SALEMANID_SOKOD = int.Parse(row["SALEMANID_SOKOD"].ToString()); } catch { }
                    try { kantar.BINLIKSAYISI = double.Parse(row["BINLIKSAYISI"].ToString()); } catch { }
                }
            }
            catch (Exception ex)
            {
                BMS_DLL.GLOBAL.LOGYAZ("KANTAR_GETIR HATA", ex);
            }
            return kantar;
        }

        private void FATURA_OLUSTUR(BMS_KE_KANTAR _KANTAR)
        {
            string PLAKAKODU = "";
            try
            {
                PLAKAKODU = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LGMAIN.GCODE FROM L_TRADGRP LGMAIN WITH(NOLOCK) WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + _KANTAR.PLAKAID.ToString(), new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
            }
            catch { }

            string _UOMREF = "0";
            string _UOSREF = "0";
            try
            {
                _UOMREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 BIRIM.LOGICALREF FROM LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2
                    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
                    ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
            }
            catch { }
            try
            {
                _UOSREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 BIRIM.UNITSETREF FROM LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2
                    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
                    ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + _KANTAR.URUNID + "'", new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
            }
            catch { }

            double BIRIMFIYAT = 0;
            try
            {
                string clientCode = BMS_DLL.SQL.SELECT2("SELECT C.CODE FROM LG_" + _CFG.FIRMNR + "_CLCARD C WHERE C.LOGICALREF=" + _KANTAR.URETICIID, new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
                BIRIMFIYAT = double.Parse(BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 P.PRICE FROM LG_" + _CFG.FIRMNR + @"_PRCLIST P WHERE
                    P.CARDREF=" + _KANTAR.URUNID + @" AND P.PTYPE=1 AND P.ACTIVE=0 AND P.PAYPLANREF='" + _KANTAR.ODEMEPLANID_SOZLESMETURUKOD + @"'
                    ORDER BY LOGICALREF DESC", new SqlConnection(LGCONSTR)).Rows[0][0].ToString());
            }
            catch { }

            double TOPLAM = Math.Round(BIRIMFIYAT * _KANTAR.MIKTAR, 2);

            // Fatura numarasi olustur
            int CARD_CODE_NO = 0;
            try
            {
                CARD_CODE_NO = int.Parse(BMS_DLL.SQL.SELECT2(@"SELECT RIGHT(FICHENO,5) F FROM (
                    SELECT MAX(FICHENO) FICHENO FROM LG_" + _CFG.FIRMNR + @"_01_INVOICE where TRCODE=1 AND FICHENO LIKE 'BMS.%'
                    ) AS T", new SqlConnection(LGCONSTR)).Rows[0][0].ToString()) + 1;
            }
            catch { }
            string FATURANO = "BMS." + CARD_CODE_NO.ToString().PadLeft(5, '0');

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
                FICHENO = FATURANO,
                GENEXCTYP = 1,
                GENEXP2 = "SOZLESME NO:" + _KANTAR.SOZLESME_NO,
                DOCODE = _KANTAR.TARTI_BELGE_NO,
                GENEXP1 = _KANTAR.ACIKLAMA,
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
                SALESMANREF = _KANTAR.SALEMANID_SOKOD,
                GENEXP3 = "BINLIK SAYISI:" + _KANTAR.BINLIKSAYISI.ToString()
            };

            using (SqlConnection con = new SqlConnection(LGCONSTR))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

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
                    throw ex;
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                }
            }

            if (INVOICELOGICALREF > 0)
            {
                SAVE_STFICHE_TOPLU(INVOICELOGICALREF, _KANTAR, PLAKAKODU, TOPLAM, FATURANO, int.Parse(_UOMREF), int.Parse(_UOSREF), BIRIMFIYAT);
            }
        }

        private void SAVE_STFICHE_TOPLU(int _INVOICEREF, BMS_KE_KANTAR _KANTAR, string PLAKAKODU, double TOPLAM, string FATURANO, int _UOMREF, int _UOSREF, double BIRIMFIYAT)
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
                GENEXP2 = "SOZLESME NO:" + _KANTAR.SOZLESME_NO,
                DATE_ = _KANTAR.TARIH.Date,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DISPSTATUS = 1,
                DOCTIME = 254939409,
                FICHECNT = 1,
                FICHENO = FATURANO,
                FTIME = 254939409,
                GENEXCTYP = 1,
                GROSSTOTAL = TOPLAM,
                GRPCODE = 1,
                DOCODE = _KANTAR.TARTI_BELGE_NO,
                GENEXP1 = _KANTAR.ACIKLAMA,
                GUID = Guid.NewGuid().ToString(),
                INVNO = FATURANO,
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
                SALESMANREF = _KANTAR.SALEMANID_SOKOD,
                GENEXP3 = "BINLIK SAYISI:" + _KANTAR.BINLIKSAYISI.ToString()
            };

            using (SqlConnection con = new SqlConnection(LGCONSTR))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

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
                    throw ex;
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                }
            }

            if (STFICHELOGICALREF > 0)
            {
                SAVE_STLINE_TOPLU(_INVOICEREF, STFICHELOGICALREF, _KANTAR, TOPLAM, _UOMREF, _UOSREF, BIRIMFIYAT);
            }
        }

        private void SAVE_STLINE_TOPLU(int _INVOICEREF, int _STFICHEREF, BMS_KE_KANTAR _KANTAR, double TOPLAM, int _UOMREF, int _UOSREF, double BIRIMFIYAT)
        {
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
                UOMREF = _UOMREF,
                USREF = _UOSREF,
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
                SALESMANREF = _KANTAR.SALEMANID_SOKOD,
            };

            using (SqlConnection con = new SqlConnection(LGCONSTR))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_STLINE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    com.ExecuteScalar();
                    transaction.Commit();

                    // Kantar kaydini guncelle
                    BMS_DLL.SQL.EXECUTE2(this, "UPDATE BMS_KE_KANTAR SET LOGOAKTARIMI=1,LOGOAKTARIMTARIHI=GETDATE(),LOGOFISID=" + _INVOICEREF + ", TSTATUS=1 WHERE LOGICALREF=" + _KANTAR.LOGICALREF.ToString(), new SqlConnection(LGCONSTR));
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                }
            }
        }

        private void SB_KAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
