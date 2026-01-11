using BMS_CYPFRUVEX_KANTARETIKET_MODULU.CONVERTER;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.SQLCOMMANDS;
using BMS_DLL.OBJECTS;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU
{
    public partial class FRM_KANTAR : Form
    {
        string LGCONSTR;
        CONFIG _CFG;
        SqlConnection SQLCON = new SqlConnection();
        string PLAKALOGICALREF = "0";
        string KONTRAKTORLOGICALREF = "0";
        string URETICILOGICALREF = "0";
        string URUNLOGICALREF = "0";
        string AMBARID_GIDECEGIYER = "0";
        string ODEMEPLANID_SOZLESMETURU = "0";
        string SALEMANID_SO = "0";
        SQLINSERTCOMMANDS SIC = new SQLINSERTCOMMANDS();
        CONVERTDATATOMODELS CDM = new CONVERTDATATOMODELS();

        public FRM_KANTAR(CONFIG CFG)
        {
            InitializeComponent();
            DE_TARIH.DateTime = DateTime.Now;

            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            SQLCON = new SqlConnection(LGCONSTR);
            TE_PLAKA.Text = null;
            TE_PLAKAKODU.Text = null;
            TE_KONTRAKTOR.Text = null;
            TE_KONTRAKTORKODU.Text = null;
            TE_URETICI.Text = null;
            TE_URETICIKODU.Text = null;
            TE_URUN.Text = null;
            TE_URUNKODU.Text = null;
            TE_BIRIM.Text = null;
            TE_ACIKLAMA.Text = null;
            TE_FIRE_YUZDE.Text = "0";
            TE_FIRE_MIKTAR.Text = "0";


        }
        public DataTable SELECT_ENTDB()
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection cnn = new SQLiteConnection("Data Source=" + GLOB.SORGU_ENTDB_PATH + ";Version=3;");
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = "select LOGICALREF, Market,ProductCode,Price,Status,Fisno, Type, strftime('%d/%m/%Y', SYNCDATE) SYNCDATE from ENT";
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }
        public static DataTable SELECT(string sqlQuery, SqlConnection sqlconnection2)
        {
            SqlDataAdapter sqlDataAdapterItem = new SqlDataAdapter(sqlQuery, sqlconnection2);
            DataTable dataTableItem = new DataTable();
            sqlDataAdapterItem.Fill(dataTableItem);
            return dataTableItem;
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TOPLU_ISLEMLER_SORGU SORGU = new TOPLU_ISLEMLER_SORGU();
            //using (FRM_MALZEMELISTESISORGU SORGU = new FRM_MALZEMELISTESISORGU()) {
            //    if (SORGU.ShowDialog() == DialogResult.OK) {
            //        INITIALIZEGRIDVIEW();
            //    }
            //}
        }



        private void INSERT_ENTDB(string Market, string Type, string ProductCode, string PriceStatus)
        {
            //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + GLOB.SORGU_ENTDB_PATH + ";Version=3;");
            //m_dbConnection.Open();
            //PriceStatus = Type == "UpdateProductPrice" ? PriceStatus.Replace(",", ".") : PriceStatus;
            //string PriceStatusFIELD = Type == "UpdateProductPrice" ? "Price" : "Status";
            //Type = Type == "UpdateProductPrice" ? "Fiyat Guncelleme" : Type == "UpdateProductStatus" ? "Ürün Durum Güncelleme" : Type;
            ////string sql = "create table ENT (Market varchar(200), ProductCode varchar(200), Price float, Fisno varchar(200),Type varchar(200),SYNCDATE datetime)";
            //// string sql = "INSERT INTO ENT (Market varchar(200), ProductCode varchar(200), Price float, Fisno varchar(200),Type varchar(200),SYNCDATE datetime)";
            //DateTime SYNCDATE = DateTime.Now.Date;
            //string sql = @"INSERT INTO ENT (Market,ProductCode," + PriceStatusFIELD + @",Fisno,Type,SYNCDATE) 
            //                       values ('" + Market + "','" + ProductCode + "','" + PriceStatus + "','" + Fisno + "','" + Type + "','" + SYNCDATE.ToString("yyyy-MM-dd") + "')";

            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();
            //m_dbConnection.Close();
        }


        private void mARKETENTEGRASYONGEÇMİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FRM_ENTEGRASYONGECMISI MEG = new FRM_ENTEGRASYONGECMISI(_CFG, SECILIMARKET, GRC_MALZEMELISTESI.DataSource);
            //MEG.Show();
        }

        private void SB_eXCELEKAYDET_Click(object sender, EventArgs e)
        {
            if (URUNLOGICALREF == "0" || URUNLOGICALREF == "" || KONTRAKTORLOGICALREF == "0" || PLAKALOGICALREF == "0" || URETICILOGICALREF == "0" || string.IsNullOrEmpty(TE_OZELKOD_BOLGE.Text))
            {
                MessageBox.Show("DOLDURULMASI GEREKEN ALANLAR MEVCUT");
                return;
            }
            int logicalref = 0;
            BMS_KE_KANTAR O = new BMS_KE_KANTAR();
            O.BARKODYAZIMMIKTAR = 0;
            O.BIRIM = TE_BIRIM.Text;
            O.KONTRAKTORID = int.Parse(KONTRAKTORLOGICALREF);
            O.MIKTAR = double.Parse(TE_MIKTAR.Text);
            O.PLAKAID = int.Parse(PLAKALOGICALREF);
            O.TARIH = DE_TARIH.DateTime;
            O.TSTATUS = 0;
            O.URETICIID = int.Parse(URETICILOGICALREF);
            O.URUNID = int.Parse(URUNLOGICALREF);
            O.ERRORMESSAGE = "";
            O.KULLANICI = "";
            O.ACIKLAMA = TE_ACIKLAMA.Text == "ZORUNLU DEĞİL" ? "" : TE_ACIKLAMA.Text;
            O.TARTI_BELGE_NO = TE_TARTIBELGENO.Text;
            O.SOZLESME_NO = TE_SOZLESMENO.Text;

            O.AMBARID_GIDECEGIYERKOD = int.Parse(AMBARID_GIDECEGIYER);
            O.OZELKOD_BOLGEKOD = TE_OZELKOD_BOLGEKOD.Text;
            O.YETKIKOD_BOLGEDETAYKOD = TE_YETKIKOD_BOLGEDETAYKOD.Text;
            O.ODEMEPLANID_SOZLESMETURUKOD = int.Parse(ODEMEPLANID_SOZLESMETURU);
            O.SALEMANID_SOKOD = int.Parse(SALEMANID_SO);


            O.AMBARID_GIDECEGIYER = TE_AMBAR_GIDECEGIYER.Text;
            O.OZELKOD_BOLGE = TE_OZELKOD_BOLGE.Text;
            O.YETKIKOD_BOLGEDETAY = TE_YETKIKOD_BOLGEDETAY.Text;
            O.ODEMEPLANID_SOZLESMETURU = TE_ODEMEPLANI_SOZLESMETURU.Text;
            O.SALEMANID_SO = TE_SALEMANID_SO.Text;
            O.BINLIKSAYISI = double.Parse(TE_BINLIKSAYISI.Text);

            // 10 ton (10000 kg) altı yüklemeler için teslimat kodunu kaydet
            if (O.MIKTAR < 10000)
            {
                O.TESLIMAT_KODU = TE_TESLIMAT_KODU.Text;
            }
            else
            {
                O.TESLIMAT_KODU = "";
            }

            // Fire miktarını ekle
            double fireMiktar = 0;
            double.TryParse(TE_FIRE_MIKTAR.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out fireMiktar);
            O.FIRE_MIKTAR = fireMiktar;

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
                    SqlCommand com = SIC.BMS_KE_KANTAR_INSERT(O, true, false);
                    com.Connection = con;
                    com.Transaction = transaction;
                    logicalref = int.Parse(com.ExecuteScalar().ToString());
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
            if (GLOB.YETKI == "YONETICI" && _CFG.KantarSonrasiFaturaAc == 1)
            {
                SQLCON = new SqlConnection(LGCONSTR);
                DataRow dr = BMS_DLL.SQL.SELECT2("SELECT * FROM BMS_KE_KANTAR WHERE LOGICALREF=" + logicalref.ToString(), SQLCON).Rows[0];
                BMS_KE_KANTAR KANTAR = CDM.BMS_KE_KANTAR_CONVERT_FROM_DATAROW(dr);
                FRM_OPERATOR_YENISATINALMAFATURASI SAF = new FRM_OPERATOR_YENISATINALMAFATURASI(_CFG, KANTAR);
                SAF.Show();
                clearComponents();
                //this.Close();
            }
            else if (GLOB.YETKI != "YONETICI")
            {
                BMS_DLL.DX.XTRAREPORT_AC("SELECT * FROM BMS_KE_KANTAR WHERE LOGICALREF=" + logicalref.ToString(), "BARKODDESIGN.repx", false, LGCONSTR);

                clearComponents();
            }

            FRM_KANTARBARKOD F = new FRM_KANTARBARKOD(logicalref.ToString(),LGCONSTR);
            F.Show();

            // Fire miktarı 0'ın üzerindeyse satınalma iade faturası oluştur (TRCODE = 6)
            if (fireMiktar > 0)
            {
                SQLCON = new SqlConnection(LGCONSTR);
                DataRow drFire = BMS_DLL.SQL.SELECT2("SELECT * FROM BMS_KE_KANTAR WHERE LOGICALREF=" + logicalref.ToString(), SQLCON).Rows[0];
                BMS_KE_KANTAR KANTAR_FIRE = CDM.BMS_KE_KANTAR_CONVERT_FROM_DATAROW(drFire);
                CreateFireIadeFaturasi(KANTAR_FIRE, fireMiktar);
            }
        }
        void clearComponents()
        {
            TE_PLAKAKODU.Text = TE_PLAKA.Text = "";
            PLAKALOGICALREF = "0";

            TE_URETICIKODU.Text = TE_URETICI.Text = "";
            URETICILOGICALREF = "0";

            TE_KONTRAKTORKODU.Text = TE_KONTRAKTOR.Text = "";
            KONTRAKTORLOGICALREF = "0";

            TE_MIKTAR.Text = "0";
            TE_FIRE_YUZDE.Text = "0";
            TE_FIRE_MIKTAR.Text = "0";
            _previousFireYuzde = "0";
            _previousFireMiktar = "0";

            TE_YETKIKOD_BOLGEDETAYKOD.Text = TE_YETKIKOD_BOLGEDETAY.Text = "";

            TE_ACIKLAMA.Text = "";
            TE_BINLIKSAYISI.Text = "0";
            TE_TESLIMAT_KODU.Text = "";
        }
        private void SB_PLAKA_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARPLAKA F = new FRM_KANTARPLAKA(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_PLAKAKODU.Text = F.KOD;
                    TE_PLAKA.Text = F.AD;
                    PLAKALOGICALREF = F.LOGICALREF;
                }
            }
        }

        private void SB_KONTRAKTOR_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARKONTRAKTOR F = new FRM_KANTARKONTRAKTOR(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_KONTRAKTORKODU.Text = F.KOD;
                    TE_KONTRAKTOR.Text = F.AD;
                    KONTRAKTORLOGICALREF = F.LOGICALREF;
                }
            }
        }

        private void SB_URETICI_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARURETICI F = new FRM_KANTARURETICI(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_URETICIKODU.Text = F.KOD;
                    TE_URETICI.Text = F.AD;
                    URETICILOGICALREF = F.LOGICALREF;
                }
            }
        }

        private void SB_URUN_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARURUN F = new FRM_KANTARURUN(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_URUNKODU.Text = F.KOD;
                    TE_URUN.Text = F.AD;
                    URUNLOGICALREF = F.LOGICALREF;
                    TE_BIRIM.Text = F.BIRIM;
                }
            }
        }

        private void TE_URUNKODU_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string where = _CFG.URUNBASLANGICKODU != "" ? " AND ITEMS2.CODE LIKE('" + _CFG.URUNBASLANGICKODU + "%')" : " ";
                TE_URUN.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  ITEMS2.NAME FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.CODE='" + TE_URUNKODU.Text + "'" + where, SQLCON).Rows[0][0].ToString();
                URUNLOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  ITEMS2.LOGICALREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.CODE='" + TE_URUNKODU.Text + "'" + where, SQLCON).Rows[0][0].ToString();
                TE_BIRIM.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.NAME FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF=" + URUNLOGICALREF + "" + where, SQLCON).Rows[0][0].ToString();



            }
            catch
            {
                TE_URUN.Text = null;
                URUNLOGICALREF = "0";
                TE_BIRIM.Text = null;
            }
        }

        private void TE_PLAKAKODU_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TE_PLAKA.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 GDEF FROM L_TRADGRP WHERE GCODE='" + TE_PLAKAKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
                PLAKALOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LOGICALREF FROM L_TRADGRP WHERE GCODE='" + TE_PLAKAKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
            }
            catch { TE_PLAKA.Text = null; PLAKALOGICALREF = "0"; }
        }

        private void TE_KONTRAKTORKODU_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string where = _CFG.KONTRAKTORBASLANGICKODU != "" ? " AND CODE LIKE('" + _CFG.KONTRAKTORBASLANGICKODU + "%')" : " ";
                TE_KONTRAKTOR.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_KONTRAKTORKODU.Text + "' " + where, SQLCON).Rows[0][0].ToString();
                KONTRAKTORLOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LOGICALREF FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_KONTRAKTORKODU.Text + "' " + where, SQLCON).Rows[0][0].ToString();
            }
            catch { TE_KONTRAKTOR.Text = null; KONTRAKTORLOGICALREF = "0"; }
        }

        private void TE_URETICIKODU_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string where = _CFG.URETICIBASLANGICKODU != "" ? " AND CODE LIKE('" + _CFG.URETICIBASLANGICKODU + "%')" : " ";
                TE_URETICI.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_URETICIKODU.Text + "' " + where, SQLCON).Rows[0][0].ToString();
                URETICILOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LOGICALREF FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_URETICIKODU.Text + "' " + where, SQLCON).Rows[0][0].ToString();
            }
            catch { TE_URETICI.Text = null; URETICILOGICALREF = "0"; }
        }



        private void SB_BOLGE_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARBOLGE F = new FRM_KANTARBOLGE(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_OZELKOD_BOLGEKOD.Text = F.KOD;
                    TE_OZELKOD_BOLGE.Text = F.AD;
                }
            }
        }

        private void SB_BOLGEDETAY_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARBOLGEDETAY F = new FRM_KANTARBOLGEDETAY(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_YETKIKOD_BOLGEDETAYKOD.Text = F.KOD;
                    TE_YETKIKOD_BOLGEDETAY.Text = F.AD;

                }
            }
        }

        private void SB_SOZLESMETURU_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARSOZLESMETURU F = new FRM_KANTARSOZLESMETURU(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_ODEMEPLANI_SOZLESMETURUKOD.Text = F.KOD;
                    TE_ODEMEPLANI_SOZLESMETURU.Text = F.AD;
                    ODEMEPLANID_SOZLESMETURU = F.LOGICALREF;
                }
            }
        }

        private void SB_SO_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARSO F = new FRM_KANTARSO(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_SALEMANID_SO.Text = F.AD;
                    TE_SALEMANID_SOKOD.Text = F.KOD;
                    SALEMANID_SO = F.LOGICALREF;
                }
            }
        }

        private bool _isFireCalculating = false;
        private string _previousFireYuzde = "0";
        private string _previousFireMiktar = "0";

        private void TE_MIKTAR_EditValueChanged(object sender, EventArgs e)
        {
            // Miktar değiştiğinde fire hesaplamalarını güncelle (yüzde sabit kalır)
            if (_isFireCalculating) return;
            _isFireCalculating = true;
            try
            {
                double miktar = 0;
                double fireYuzde = 0;

                if (double.TryParse(TE_MIKTAR.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out miktar) &&
                    double.TryParse(TE_FIRE_YUZDE.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out fireYuzde))
                {
                    double fireMiktar = miktar * (fireYuzde / 100);
                    TE_FIRE_MIKTAR.Text = fireMiktar.ToString("N2");
                    _previousFireMiktar = TE_FIRE_MIKTAR.Text;
                }
            }
            finally
            {
                _isFireCalculating = false;
            }
        }

        private void TE_FIRE_YUZDE_EditValueChanged(object sender, EventArgs e)
        {
            if (_isFireCalculating) return;
            _isFireCalculating = true;
            try
            {
                double miktar = 0;
                double fireYuzde = 0;

                if (double.TryParse(TE_MIKTAR.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out miktar) &&
                    double.TryParse(TE_FIRE_YUZDE.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out fireYuzde))
                {
                    // Validasyon: %0-100 arasında olmalı
                    if (fireYuzde < 0 || fireYuzde > 100)
                    {
                        MessageBox.Show("Fire yüzdesi %0 ile %100 arasında olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TE_FIRE_YUZDE.Text = _previousFireYuzde;
                        return;
                    }

                    // Miktar hesapla
                    double fireMiktar = miktar * (fireYuzde / 100);
                    TE_FIRE_MIKTAR.Text = fireMiktar.ToString("N2");

                    // Önceki değerleri güncelle
                    _previousFireYuzde = TE_FIRE_YUZDE.Text;
                    _previousFireMiktar = TE_FIRE_MIKTAR.Text;
                }
            }
            finally
            {
                _isFireCalculating = false;
            }
        }

        private void TE_FIRE_MIKTAR_EditValueChanged(object sender, EventArgs e)
        {
            if (_isFireCalculating) return;
            _isFireCalculating = true;
            try
            {
                double miktar = 0;
                double fireMiktar = 0;

                if (double.TryParse(TE_MIKTAR.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out miktar) && miktar > 0 &&
                    double.TryParse(TE_FIRE_MIKTAR.Text.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out fireMiktar))
                {
                    // Validasyon: 0 ile ana miktar arasında olmalı
                    if (fireMiktar < 0 || fireMiktar > miktar)
                    {
                        MessageBox.Show("Fire miktarı 0 ile toplam miktar (" + miktar.ToString("N0") + ") arasında olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TE_FIRE_MIKTAR.Text = _previousFireMiktar;
                        return;
                    }

                    // Yüzde hesapla
                    double fireYuzde = (fireMiktar / miktar) * 100;
                    TE_FIRE_YUZDE.Text = fireYuzde.ToString("N2");

                    // Önceki değerleri güncelle
                    _previousFireYuzde = TE_FIRE_YUZDE.Text;
                    _previousFireMiktar = TE_FIRE_MIKTAR.Text;
                }
            }
            finally
            {
                _isFireCalculating = false;
            }
        }

        private void SB_GIDECEGIYER_Click(object sender, EventArgs e)
        {
            using (FRM_KANTARGIDECEGIYER F = new FRM_KANTARGIDECEGIYER(_CFG))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    TE_AMBAR_GIDECEGIYERKOD.Text = F.LOGICALREF;
                    TE_AMBAR_GIDECEGIYER.Text = F.AD;
                    AMBARID_GIDECEGIYER = F.LOGICALREF;
                }
            }
        }

        #region Fire Satınalma İade Faturası (TRCODE = 6)

        private void CreateFireIadeFaturasi(BMS_KE_KANTAR kantar, double fireMiktar)
        {
            try
            {
                // Plaka kodunu al
                string PLAKAKODU = "";
                if (kantar.PLAKAID > 0)
                {
                    try
                    {
                        PLAKAKODU = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LGMAIN.GCODE FROM L_TRADGRP LGMAIN WITH(NOLOCK) WHERE (LGMAIN.ACTIVE=0) AND LOGICALREF=" + kantar.PLAKAID.ToString(), new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
                    }
                    catch { }
                }

                // Birim fiyatı al
                double BIRIMFIYAT = 0;
                try
                {
                    BIRIMFIYAT = double.Parse(BMS_DLL.SQL.SELECT2(@"
                        SELECT TOP 1 ISNULL(P.PRICE, 0) FROM LG_" + _CFG.FIRMNR + @"_PRCLIST P
                        WHERE P.CARDREF=" + kantar.URUNID + @" AND P.PTYPE=1 AND P.ACTIVE=0
                        AND P.PAYPLANREF='" + kantar.ODEMEPLANID_SOZLESMETURUKOD + @"'
                        ORDER BY LOGICALREF DESC", new SqlConnection(LGCONSTR)).Rows[0][0].ToString());
                }
                catch { }

                double TOPLAM = Math.Round(BIRIMFIYAT * fireMiktar, 2);

                // Fatura numarası oluştur (satınalma iade için TRCODE=6)
                int CARD_CODE_NO = 0;
                try
                {
                    CARD_CODE_NO = int.Parse(BMS_DLL.SQL.SELECT2(string.Format(@"SELECT RIGHT(FICHENO,5) F FROM (
                        SELECT MAX(FICHENO) FICHENO FROM LG_" + _CFG.FIRMNR + @"_01_INVOICE where TRCODE=6 AND FICHENO LIKE 'FRE.%'
                        ) AS T"), new SqlConnection(LGCONSTR)).Rows[0][0].ToString()) + 1;
                }
                catch { }
                string FATURANO = "FRE." + CARD_CODE_NO.ToString().PadLeft(5, '0');

                // UOMREF ve UOSREF al
                string _UOMREF = "0";
                string _UOSREF = "0";
                try
                {
                    _UOMREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 BIRIM.LOGICALREF FROM LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2
                        LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
                        ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + kantar.URUNID + "'", new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
                }
                catch { }
                try
                {
                    _UOSREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 BIRIM.UNITSETREF FROM LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2
                        LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
                        ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF='" + kantar.URUNID + "'", new SqlConnection(LGCONSTR)).Rows[0][0].ToString();
                }
                catch { }

                // 1. INVOICE kaydet (TRCODE = 6)
                int INVOICELOGICALREF = SaveFireInvoice(kantar, fireMiktar, TOPLAM, FATURANO, PLAKAKODU);

                if (INVOICELOGICALREF > 0)
                {
                    // 2. STFICHE kaydet
                    int STFICHELOGICALREF = SaveFireStfiche(kantar, fireMiktar, TOPLAM, FATURANO, PLAKAKODU, INVOICELOGICALREF);

                    if (STFICHELOGICALREF > 0)
                    {
                        // 3. STLINE kaydet
                        SaveFireStline(kantar, fireMiktar, BIRIMFIYAT, TOPLAM, INVOICELOGICALREF, STFICHELOGICALREF, _UOMREF, _UOSREF);

                        // 4. PAYTRANS kaydet
                        SaveFirePaytrans(kantar, TOPLAM, INVOICELOGICALREF);

                        // 5. CLFLINE kaydet
                        SaveFireClfline(kantar, TOPLAM, FATURANO, PLAKAKODU, INVOICELOGICALREF);

                        MessageBox.Show("FİRE İÇİN SATINALMA İADE FATURASI OLUŞTURULDU!\nFatura No: " + FATURANO, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                BMS_DLL.GLOBAL.LOGYAZ("HATA(CreateFireIadeFaturasi):", ex);
                MessageBox.Show("Fire iade faturası oluşturulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int SaveFireInvoice(BMS_KE_KANTAR kantar, double fireMiktar, double toplam, string faturano, string plakakodu)
        {
            int INVOICELOGICALREF = 0;
            BM_XXX_XX_INVOICE O = new BM_XXX_XX_INVOICE()
            {
                AFFECTRISK = 1,
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CLIENTREF = kantar.URETICIID,
                DATE_ = kantar.TARIH.Date,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DOCDATE = kantar.TARIH,
                ENTEGSET = 247,
                ESTATUS = 12,
                FICHENO = faturano,
                GENEXCTYP = 1,
                GENEXP2 = "SOZLESME NO:" + kantar.SOZLESME_NO,
                DOCODE = kantar.TARTI_BELGE_NO,
                GENEXP1 = "FIRE IADE - " + kantar.ACIKLAMA,
                GROSSTOTAL = toplam,
                GRPCODE = 1,
                GUID = Guid.NewGuid().ToString(),
                NETTOTAL = toplam,
                RECSTATUS = 1,
                RECVREF = kantar.KONTRAKTORID,
                TIME_ = 254939409,
                TOTALDISCOUNTED = toplam,
                TRADINGGRP = plakakodu,
                TRCODE = 6, // Satınalma İade Faturası
                TRNET = toplam,
                VAT = 18,
                SOURCEINDEX = kantar.AMBARID_GIDECEGIYERKOD,
                SOURCECOSTGRP = kantar.AMBARID_GIDECEGIYERKOD,
                SPECODE = kantar.OZELKOD_BOLGEKOD,
                CYPHCODE = kantar.YETKIKOD_BOLGEDETAYKOD,
                PAYDEFREF = kantar.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = kantar.SALEMANID_SOKOD,
                GENEXP3 = "FIRE MIKTARI:" + fireMiktar.ToString("N2")
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
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SaveFireInvoice):", ex);
                }
            }
            return INVOICELOGICALREF;
        }

        private int SaveFireStfiche(BMS_KE_KANTAR kantar, double fireMiktar, double toplam, string faturano, string plakakodu, int invoiceRef)
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
                CLIENTREF = kantar.URETICIID,
                GENEXP2 = "SOZLESME NO:" + kantar.SOZLESME_NO,
                DATE_ = kantar.TARIH.Date,
                DEDUCTIONPART1 = 2,
                DEDUCTIONPART2 = 3,
                DISPSTATUS = 1,
                DOCTIME = 254939409,
                FICHECNT = 1,
                FICHENO = faturano,
                FTIME = 254939409,
                GENEXCTYP = 1,
                GROSSTOTAL = toplam,
                GRPCODE = 1,
                DOCODE = kantar.TARTI_BELGE_NO,
                GENEXP1 = "FIRE IADE - " + kantar.ACIKLAMA,
                GUID = Guid.NewGuid().ToString(),
                INVNO = faturano,
                INVOICEREF = invoiceRef,
                IOCODE = 2, // Stoktan çıkış (iade)
                NETTOTAL = toplam,
                RECVREF = kantar.KONTRAKTORID,
                SHIPDATE = kantar.TARIH,
                SHIPTIME = 254939409,
                TOTALDISCOUNTED = toplam,
                TRADINGGRP = plakakodu,
                TRCODE = 6, // Satınalma İade
                SOURCEINDEX = kantar.AMBARID_GIDECEGIYERKOD,
                SOURCECOSTGRP = kantar.AMBARID_GIDECEGIYERKOD,
                SPECODE = kantar.OZELKOD_BOLGEKOD,
                CYPHCODE = kantar.YETKIKOD_BOLGEDETAYKOD,
                PAYDEFREF = kantar.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = kantar.SALEMANID_SOKOD,
                GENEXP3 = "FIRE MIKTARI:" + fireMiktar.ToString("N2")
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
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SaveFireStfiche):", ex);
                }
            }
            return STFICHELOGICALREF;
        }

        private void SaveFireStline(BMS_KE_KANTAR kantar, double fireMiktar, double birimfiyat, double toplam, int invoiceRef, int stficheRef, string uomref, string uosref)
        {
            BM_XXX_XX_STLINE O = new BM_XXX_XX_STLINE()
            {
                STOCKREF = kantar.URUNID,
                TRCODE = 6, // Satınalma İade
                DATE_ = kantar.TARIH.Date,
                FTIME = 254939409,
                IOCODE = 2, // Stoktan çıkış
                STFICHEREF = stficheRef,
                STFICHELNNO = 1,
                INVOICEREF = invoiceRef,
                INVOICELNNO = 1,
                CLIENTREF = kantar.URETICIID,
                AMOUNT = fireMiktar,
                PRICE = birimfiyat,
                TOTAL = toplam,
                UOMREF = int.Parse(uomref),
                USREF = int.Parse(uosref),
                UINFO1 = 1,
                UINFO2 = 1,
                VATMATRAH = toplam,
                BILLED = 1,
                LINENET = toplam,
                RECSTATUS = 2,
                YEAR_ = kantar.TARIH.Year,
                AFFECTRISK = 1,
                GUID = Guid.NewGuid().ToString(),
                FUTMONTHBEGDATE = 132385566,
                SOURCEINDEX = kantar.AMBARID_GIDECEGIYERKOD,
                SOURCECOSTGRP = kantar.AMBARID_GIDECEGIYERKOD,
                SPECODE = kantar.OZELKOD_BOLGEKOD,
                PAYDEFREF = kantar.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = kantar.SALEMANID_SOKOD,
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
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SaveFireStline):", ex);
                }
            }
        }

        private void SaveFirePaytrans(BMS_KE_KANTAR kantar, double toplam, int invoiceRef)
        {
            BM_XXX_XX_PAYTRANS O = new BM_XXX_XX_PAYTRANS()
            {
                CARDREF = kantar.URETICIID,
                DATE_ = kantar.TARIH,
                MODULENR = 4,
                SIGN = 0, // İade için ters işaret
                FICHEREF = invoiceRef,
                TRCODE = 6, // Satınalma İade
                TOTAL = toplam,
                PROCDATE = kantar.TARIH,
                DISCDUEDATE = kantar.TARIH,
                PAYNO = 1,
                SPECODE = kantar.OZELKOD_BOLGEKOD,
            };

            using (SqlConnection con = new SqlConnection(LGCONSTR))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_PAYTRANS_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    com.ExecuteScalar();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SaveFirePaytrans):", ex);
                }
            }
        }

        private void SaveFireClfline(BMS_KE_KANTAR kantar, double toplam, string faturano, string plakakodu, int invoiceRef)
        {
            BM_XXX_XX_CLFLINE O = new BM_XXX_XX_CLFLINE()
            {
                CLIENTREF = kantar.URETICIID,
                SOURCEFREF = invoiceRef,
                DATE_ = kantar.TARIH,
                DOCODE = kantar.TARTI_BELGE_NO,
                MODULENR = 4,
                TRCODE = 32, // Satınalma İade için cari hareket kodu
                TRANNO = faturano,
                SIGN = 0, // İade için ters işaret
                AMOUNT = toplam,
                TRNET = toplam,
                CAPIBLOCK_CREADEDDATE = DateTime.Now,
                CAPIBLOCK_CREATEDBY = 1,
                CAPIBLOCK_CREATEDHOUR = DateTime.Now.Hour,
                CAPIBLOCK_CREATEDMIN = DateTime.Now.Minute,
                CAPIBLOCK_CREATEDSEC = DateTime.Now.Second,
                TRADINGGRP = plakakodu,
                MONTH_ = kantar.TARIH.Month,
                YEAR_ = kantar.TARIH.Year,
                AFFECTRISK = 1,
                DOCDATE = kantar.TARIH,
                FTIME = 254939409,
                GUID = Guid.NewGuid().ToString(),
                SPECODE = kantar.OZELKOD_BOLGEKOD,
                PAYDEFREF = kantar.ODEMEPLANID_SOZLESMETURUKOD,
                SALESMANREF = kantar.SALEMANID_SOKOD
            };

            using (SqlConnection con = new SqlConnection(LGCONSTR))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand com = SIC.BM_XXX_XX_CLFLINE_INSERT(O, false, false, _CFG.FIRMNR, "01");
                    com.Connection = con;
                    com.Transaction = transaction;
                    com.ExecuteScalar();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(SaveFireClfline):", ex);
                }
            }
        }

        #endregion

    }
}
