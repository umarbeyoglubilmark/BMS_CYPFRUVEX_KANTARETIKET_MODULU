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
        public static string bitaykaURL = "";
        public static string accessToken = "";
        public static string UserID = "";
        public static string Description = "";
        public static string Fisno = "";
        public static string SECILIMARKET = "";
        public FRM_KANTAR(CONFIG CFG) {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            _CFG = CFG;
            Fisno = BMS_DLL.GLOBAL.NUMARATOR();
            bitaykaURL = _CFG.BITAYKAURL;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);



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
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + GLOB.SORGU_ENTDB_PATH + ";Version=3;");
            m_dbConnection.Open();
            PriceStatus = Type == "UpdateProductPrice" ? PriceStatus.Replace(",", ".") : PriceStatus;
            string PriceStatusFIELD = Type == "UpdateProductPrice" ? "Price" : "Status";
            Type = Type == "UpdateProductPrice" ? "Fiyat Guncelleme" : Type == "UpdateProductStatus" ? "Ürün Durum Güncelleme" : Type;
            //string sql = "create table ENT (Market varchar(200), ProductCode varchar(200), Price float, Fisno varchar(200),Type varchar(200),SYNCDATE datetime)";
            // string sql = "INSERT INTO ENT (Market varchar(200), ProductCode varchar(200), Price float, Fisno varchar(200),Type varchar(200),SYNCDATE datetime)";
            DateTime SYNCDATE = DateTime.Now.Date;
            string sql = @"INSERT INTO ENT (Market,ProductCode," + PriceStatusFIELD + @",Fisno,Type,SYNCDATE) 
                                   values ('" + Market + "','" + ProductCode + "','" + PriceStatus + "','" + Fisno + "','" + Type + "','" + SYNCDATE.ToString("yyyy-MM-dd") + "')";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }


        private void mARKETENTEGRASYONGEÇMİŞİToolStripMenuItem_Click(object sender, EventArgs e) {
            //FRM_ENTEGRASYONGECMISI MEG = new FRM_ENTEGRASYONGECMISI(_CFG, SECILIMARKET, GRC_MALZEMELISTESI.DataSource);
            //MEG.Show();
        }

        private void SB_eXCELEKAYDET_Click(object sender, EventArgs e) {
            FRM_KANTARBARKOD F = new FRM_KANTARBARKOD("LOGICALREF");
            F.Show();
        }
    }
}
