using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.SQLCOMMANDS;
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

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class FRM_KANTAR : Form {
        string LGCONSTR;
        CONFIG _CFG; 
        SqlConnection SQLCON = new SqlConnection();
        string PLAKALOGICALREF = "0";
        string KONTRAKTORLOGICALREF = "0";
        string URETICILOGICALREF = "0";
        string URUNLOGICALREF = "0";
        SQLINSERTCOMMANDS SIC = new SQLINSERTCOMMANDS();

        public FRM_KANTAR(CONFIG CFG) {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
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


        }
        public DataTable SELECT_ENTDB() {
            DataTable dt = new DataTable();
            try {
                SQLiteConnection cnn = new SQLiteConnection("Data Source=" + GLOB.SORGU_ENTDB_PATH + ";Version=3;");
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = "select LOGICALREF, Market,ProductCode,Price,Status,Fisno, Type, strftime('%d/%m/%Y', SYNCDATE) SYNCDATE from ENT";
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
            return dt;
        }
        public static DataTable SELECT(string sqlQuery, SqlConnection sqlconnection2) {
            SqlDataAdapter sqlDataAdapterItem = new SqlDataAdapter(sqlQuery, sqlconnection2);
            DataTable dataTableItem = new DataTable();
            sqlDataAdapterItem.Fill(dataTableItem);
            return dataTableItem;
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TOPLU_ISLEMLER_SORGU SORGU = new TOPLU_ISLEMLER_SORGU();
            //using (FRM_MALZEMELISTESISORGU SORGU = new FRM_MALZEMELISTESISORGU()) {
            //    if (SORGU.ShowDialog() == DialogResult.OK) {
            //        INITIALIZEGRIDVIEW();
            //    }
            //}
        }



        private void INSERT_ENTDB(string Market, string Type, string ProductCode, string PriceStatus) {
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


        private void mARKETENTEGRASYONGEÇMİŞİToolStripMenuItem_Click(object sender, EventArgs e) {
            //FRM_ENTEGRASYONGECMISI MEG = new FRM_ENTEGRASYONGECMISI(_CFG, SECILIMARKET, GRC_MALZEMELISTESI.DataSource);
            //MEG.Show();
        }

        private void SB_eXCELEKAYDET_Click(object sender, EventArgs e) {
            int logicalref = 0;
            BMS_KE_KANTAR O = new BMS_KE_KANTAR();
            O.ACIKLAMA = TE_ACIKLAMA.Text;
            O.BARKODYAZIMMIKTAR = 0;
            O.BIRIM = TE_BIRIM.Text;
            O.KONTRAKTORID = int.Parse(KONTRAKTORLOGICALREF);
            O.MIKTAR = double.Parse(TE_MIKTAR.Text);
            O.PLAKAID = int.Parse(PLAKALOGICALREF);
            O.TARIH = DateTime.Now;
            O.TSTATUS = 0;
            O.URETICIID = int.Parse(URETICILOGICALREF);
            O.URUNID = int.Parse(URUNLOGICALREF);
            O.ERRORMESSAGE = "";
            O.KULLANICI = ""; 
            SQLCON = new SqlConnection(LGCONSTR);
            using (SqlConnection con = SQLCON) {
                if (con.State != ConnectionState.Open) {
                    con.Open();
                }

                SqlTransaction transaction = con.BeginTransaction();
                try {
                    SqlCommand com = SIC.BMS_KE_KANTAR_INSERT(O, true, false);
                    com.Connection = con;
                    com.Transaction = transaction;
                    logicalref = int.Parse( com.ExecuteScalar().ToString());
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    BMS_DLL.GLOBAL.LOGYAZ("HATA(KANTAR_FIS_KAYIT):", ex);
                } finally {
                    try { transaction.Dispose(); } catch { }
                    try { if (con.State != ConnectionState.Closed) con.Close(); } catch { }
                    try { con.Dispose(); } catch { }
                }
            }
            FRM_KANTARBARKOD F = new FRM_KANTARBARKOD(logicalref.ToString());
            F.Show();
        }

        private void SB_PLAKA_Click(object sender, EventArgs e) {
            using (FRM_KANTARPLAKA F = new FRM_KANTARPLAKA(_CFG)) {
                if (F.ShowDialog() == DialogResult.OK) {
                    TE_PLAKAKODU.Text = F.KOD;
                    TE_PLAKA.Text = F.AD;
                    PLAKALOGICALREF = F.LOGICALREF;
                }
            }
        }

        private void SB_KONTRAKTOR_Click(object sender, EventArgs e) {
            using (FRM_KANTARKONTRAKTOR F = new FRM_KANTARKONTRAKTOR(_CFG)) {
                if (F.ShowDialog() == DialogResult.OK) {
                    TE_KONTRAKTORKODU.Text = F.KOD;
                    TE_KONTRAKTOR.Text = F.AD;
                    KONTRAKTORLOGICALREF = F.LOGICALREF;
                }
            }
        }

        private void SB_URETICI_Click(object sender, EventArgs e) {
            using (FRM_KANTARURETICI F = new FRM_KANTARURETICI(_CFG)) {
                if (F.ShowDialog() == DialogResult.OK) {
                    TE_URETICIKODU.Text = F.KOD;
                    TE_URETICI.Text = F.AD;
                    URETICILOGICALREF = F.LOGICALREF;
                }
            }
        }

        private void SB_URUN_Click(object sender, EventArgs e) {
            using (FRM_KANTARURUN F = new FRM_KANTARURUN(_CFG)) {
                if (F.ShowDialog() == DialogResult.OK) {
                    TE_URUNKODU.Text = F.KOD;
                    TE_URUN.Text = F.AD;
                    URUNLOGICALREF = F.LOGICALREF;
                    TE_BIRIM.Text = F.BIRIM;
                }
            }
        }

        private void TE_URUNKODU_EditValueChanged(object sender, EventArgs e) {
            try {

                TE_URUN.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  ITEMS2.NAME FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.CODE='" + TE_URUNKODU.Text + "'", SQLCON).Rows[0][0].ToString();
                URUNLOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  ITEMS2.LOGICALREF FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.CODE='" + TE_URUNKODU.Text + "'", SQLCON).Rows[0][0].ToString();
                TE_BIRIM.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1  BIRIM.NAME FROM  LG_" + _CFG.FIRMNR + @"_ITEMS ITEMS2 
    LEFT OUTER JOIN LG_" + _CFG.FIRMNR + @"_UNITSETL BIRIM WITH(NOLOCK)
            ON BIRIM.UNITSETREF = ITEMS2.UNITSETREF   WHERE BIRIM.MAINUNIT = 1 AND ITEMS2.LOGICALREF=" + URUNLOGICALREF + "", SQLCON).Rows[0][0].ToString();



            } catch {
                TE_URUN.Text = null;
                URUNLOGICALREF = "0";
                TE_BIRIM.Text = null;
            }
        }

        private void TE_PLAKAKODU_EditValueChanged(object sender, EventArgs e) {
            try {
                TE_PLAKA.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 GDEF FROM L_TRADGRP WHERE GCODE='" + TE_PLAKAKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
                PLAKALOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LOGICALREF FROM L_TRADGRP WHERE GCODE='" + TE_PLAKAKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
            } catch { TE_PLAKA.Text = null; PLAKALOGICALREF = "0"; }
        }

        private void TE_KONTRAKTORKODU_EditValueChanged(object sender, EventArgs e) {
            try {
                TE_KONTRAKTOR.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_KONTRAKTORKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
                KONTRAKTORLOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LOGICALREF FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_KONTRAKTORKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
            } catch { TE_KONTRAKTOR.Text = null; KONTRAKTORLOGICALREF = "0"; }
        }

        private void TE_URETICIKODU_EditValueChanged(object sender, EventArgs e) {
            try {
                TE_URETICI.Text = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 DEFINITION_ FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_URETICIKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
                URETICILOGICALREF = BMS_DLL.SQL.SELECT2(@"SELECT TOP 1 LOGICALREF FROM LG_" + _CFG.FIRMNR + "_CLCARD WHERE CODE='" + TE_URETICIKODU.Text + "' ", SQLCON).Rows[0][0].ToString();
            } catch { TE_URETICI.Text = null; URETICILOGICALREF = "0"; }
        }
    }
}
