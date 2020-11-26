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
    public partial class FRM_KANTARY : Form {
        string LGCONSTR;
        CONFIG _CFG;
        public static string bitaykaURL = "";
        public static string accessToken = "";
        public static string UserID = "";
        public static string Description = "";
        public static string Fisno = "";
        public static string SECILIMARKET = "";
        public FRM_KANTARY(CONFIG CFG) {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            _CFG = CFG;
            Fisno = BMS_DLL.GLOBAL.NUMARATOR();
            bitaykaURL = _CFG.BITAYKAURL;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            CB_MARKET1.Text = _CFG.BITAYKAMARKET1;
            CB_MARKET2.Text = _CFG.BITAYKAMARKET2;
            CB_MARKET3.Text = _CFG.BITAYKAMARKET3;
            CB_MARKET4.Text = _CFG.BITAYKAMARKET4;
            CB_MARKET5.Text = _CFG.BITAYKAMARKET5;
            CB_MARKET1.Checked = CB_MARKET1.Visible = _CFG.BITAYKAMARKET1 == "" ? false : true;
            CB_MARKET2.Checked = CB_MARKET2.Visible = _CFG.BITAYKAMARKET2 == "" ? false : true;
            CB_MARKET3.Checked = CB_MARKET3.Visible = _CFG.BITAYKAMARKET3 == "" ? false : true;
            CB_MARKET4.Checked = CB_MARKET4.Visible = _CFG.BITAYKAMARKET4 == "" ? false : true;
            CB_MARKET5.Checked = CB_MARKET5.Visible = _CFG.BITAYKAMARKET5 == "" ? false : true;
            INITIALIZEGRIDVIEW();
            GRV_MALZEMELISTESI.OptionsBehavior.Editable = _CFG.MLD == "EVET" ? true : false;
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
        private void RESULTGRIDVIEW(DataTable ODT) {
            //  DataTable BAKIYELER = BMS_DLL.SQL.SELECT(string.Format("SELECT * FROM  BMF_" + LE_FIRMA.EditValue.ToString() + @"_AO_RAPOR2_CARIBAKIYELER320('" + TARIHFILTRE.ToString("yyyy-MM-dd") + "')"));
            DataTable ENTDB_SELECT = SELECT_ENTDB();

            ODT.Columns.Add("DURUM1", typeof(System.String));
            ODT.Columns.Add("DURUM2", typeof(System.String));
            ODT.Columns.Add("DURUM3", typeof(System.String));
            ODT.Columns.Add("DURUM4", typeof(System.String));
            ODT.Columns.Add("DURUM5", typeof(System.String));

            foreach (DataRow R in ODT.Rows) {
                string ProductCode = R["ProductCode"].ToString();
                if (CB_MARKET1.Checked == true) {
                    try {
                        //input.Substring(0, input.IndexOf("/") + 1);
                        DataRow[] DURUM = ENTDB_SELECT.Select("ProductCode = '" + ProductCode + "' and Market='" + CB_MARKET1.Text + "'", "LOGICALREF DESC");
                        string PriceStatusTitle = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Fiyat" : "Durum";
                        string PriceStatus = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Price" : "Status";
                        R["DURUM1"] = DURUM[0]["SYNCDATE"] + " Tarihinde " + DURUM[0]["Type"] + " " + PriceStatusTitle + ":" + DURUM[0][PriceStatus];
                    } catch (Exception ex) { }
                }
                if (CB_MARKET2.Checked == true) {
                    try {
                        DataRow[] DURUM = ENTDB_SELECT.Select("ProductCode = '" + ProductCode + "' and Market='" + CB_MARKET2.Text + "'", "LOGICALREF DESC");
                        string PriceStatusTitle = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Fiyat" : "Durum";
                        string PriceStatus = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Price" : "Status";
                        R["DURUM2"] = DURUM[0]["SYNCDATE"] + " Tarihinde " + DURUM[0]["Type"] + " " + PriceStatusTitle + ":" + DURUM[0][PriceStatus];
                    } catch (Exception ex) { }
                }
                if (CB_MARKET3.Checked == true) {
                    try {
                        DataRow[] DURUM = ENTDB_SELECT.Select("ProductCode = '" + ProductCode + "' and Market='" + CB_MARKET3.Text + "'", "LOGICALREF DESC");
                        string PriceStatusTitle = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Fiyat" : "Durum";
                        string PriceStatus = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Price" : "Status";
                        R["DURUM3"] = DURUM[0]["SYNCDATE"] + " Tarihinde " + DURUM[0]["Type"] + " " + PriceStatusTitle + ":" + DURUM[0][PriceStatus];
                    } catch (Exception ex) { }
                }
                if (CB_MARKET4.Checked == true) {
                    try {
                        DataRow[] DURUM = ENTDB_SELECT.Select("ProductCode = '" + ProductCode + "' and Market='" + CB_MARKET4.Text + "'", "LOGICALREF DESC");
                        string PriceStatusTitle = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Fiyat" : "Durum";
                        string PriceStatus = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Price" : "Status";
                        R["DURUM4"] = DURUM[0]["SYNCDATE"] + " Tarihinde " + DURUM[0]["Type"] + " " + PriceStatusTitle + ":" + DURUM[0][PriceStatus];
                    } catch (Exception ex) { }
                }
                if (CB_MARKET5.Checked == true) {
                    try {
                        DataRow[] DURUM = ENTDB_SELECT.Select("ProductCode = '" + ProductCode + "' and Market='" + CB_MARKET5.Text + "'", "LOGICALREF DESC");
                        string PriceStatusTitle = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Fiyat" : "Durum";
                        string PriceStatus = DURUM[0]["Type"].ToString().Contains("Durum") != true ? "Price" : "Status";
                        R["DURUM5"] = DURUM[0]["SYNCDATE"] + " Tarihinde " + DURUM[0]["Type"] + " " + PriceStatusTitle + ":" + DURUM[0][PriceStatus];
                    } catch (Exception ex) { }
                }
            }

            GRC_MALZEMELISTESI.DataSource = ODT;
        }
        private void INITIALIZEGRIDVIEW() {
            SplashScreenManager.ShowForm((Form)this, typeof(PROGRESSFORM), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Rapor Getiriliyor..");
            SplashScreenManager.Default.SetWaitFormDescription("Lütfen bekleyin...");
            try {
                GRV_MALZEMELISTESI.Columns.Clear();
                DataTable dt = SELECT(File.ReadAllText(GLOB.SORGU_MALZEMELISTESI_PATH), new SqlConnection(LGCONSTR));
                RESULTGRIDVIEW(dt);
                GRV_MALZEMELISTESI.Columns["DURUM1"].Caption = _CFG.BITAYKAMARKET1 == "" ? "DURUM1" : _CFG.BITAYKAMARKET1;
                GRV_MALZEMELISTESI.Columns["DURUM2"].Caption = _CFG.BITAYKAMARKET2 == "" ? "DURUM2" : _CFG.BITAYKAMARKET2;
                GRV_MALZEMELISTESI.Columns["DURUM3"].Caption = _CFG.BITAYKAMARKET3 == "" ? "DURUM3" : _CFG.BITAYKAMARKET3;
                GRV_MALZEMELISTESI.Columns["DURUM4"].Caption = _CFG.BITAYKAMARKET4 == "" ? "DURUM4" : _CFG.BITAYKAMARKET4;
                GRV_MALZEMELISTESI.Columns["DURUM5"].Caption = _CFG.BITAYKAMARKET5 == "" ? "DURUM5" : _CFG.BITAYKAMARKET5;
                GRV_MALZEMELISTESI.Columns["DURUM1"].Visible = _CFG.BITAYKAMARKET1 == "" ? false : true;
                GRV_MALZEMELISTESI.Columns["DURUM2"].Visible = _CFG.BITAYKAMARKET2 == "" ? false : true;
                GRV_MALZEMELISTESI.Columns["DURUM3"].Visible = _CFG.BITAYKAMARKET3 == "" ? false : true;
                GRV_MALZEMELISTESI.Columns["DURUM4"].Visible = _CFG.BITAYKAMARKET4 == "" ? false : true;
                GRV_MALZEMELISTESI.Columns["DURUM5"].Visible = _CFG.BITAYKAMARKET5 == "" ? false : true;
                BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_MALZEMELISTESI, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_MALZEMELISTESI.Name);
            } catch (Exception EX) {
                BMS_DLL.GLOBAL.LOGYAZ("HATA:", EX);
            }




            SplashScreenManager.CloseForm(false);
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TOPLU_ISLEMLER_SORGU SORGU = new TOPLU_ISLEMLER_SORGU();
            //using (FRM_MALZEMELISTESISORGU SORGU = new FRM_MALZEMELISTESISORGU()) {
            //    if (SORGU.ShowDialog() == DialogResult.OK) {
            //        INITIALIZEGRIDVIEW();
            //    }
            //}
        }
        public static string BITAYKA_getAccessToken(string userName, string password) {
            //   string accesstokenurl = @"http://api.bitayka.com/BiTaykaTest/batchoperations.php";
            string result = null;
            try {
                HttpWebRequest req = WebRequest.Create(new Uri(bitaykaURL)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Accept = "application/json";
                byte[] formData = UTF8Encoding.UTF8.GetBytes("Operation=APILogin"
                    + "&Username=" + userName
                    + "&Password=" + password);
                req.ContentLength = formData.Length;
                using (Stream post = req.GetRequestStream()) {
                    post.Write(formData, 0, formData.Length);
                }
                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse) {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                dynamic j = JsonConvert.DeserializeObject(result);
                UserID = j.UserID;
                accessToken = j.SessionToken;
            } catch (Exception ex) {
                BMS_DLL.GLOBAL.LOGYAZ("HATA BITAYKA_getAccessToken:", ex);
                accessToken = result;
            }
            return accessToken;
        }

        public static string BITAYKA_urunIslemleri(string Operation, string UserID, string SessionToken, string ProductCode, string Status_or_Price, string StatusValueorPriceValue) {
            //   string url = @"http://api.bitayka.com/BiTaykaTest/batchoperations.php?Operation=UpdateProductStatus&UserID=2&SessionToken=uF1OAzJ13Q2mXkOb&ProductCode=5011309084719&Status=1";
            //Operation = APILogin, UpdateProductStatus ,UpdateProductPrice
            //Status = UpdateProductStatus sa eğer Status -1 sil, 0 satışa kapat , 1 satışa aç ,,,,,, UpdateProductPrice tutar atılır
            StatusValueorPriceValue = Status_or_Price == "Price" ? StatusValueorPriceValue.Replace(",", ".") : StatusValueorPriceValue;
            string result = null;
            try {
                HttpWebRequest req = WebRequest.Create(new Uri(bitaykaURL)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Accept = "application/json";
                byte[] formData = UTF8Encoding.UTF8.GetBytes(
                      "Operation=" + Operation
                    + "&UserID=" + UserID
                    + "&SessionToken=" + accessToken
                    + "&ProductCode=" + ProductCode
                    + "&" + Status_or_Price + "=" + StatusValueorPriceValue);

                req.ContentLength = formData.Length;
                using (Stream post = req.GetRequestStream()) {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse) {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                dynamic j = JsonConvert.DeserializeObject(result);
                Description = j.Description;
                Description = Description.Length < 1 ? j.Result : Description;
            } catch (Exception ex) {
                BMS_DLL.GLOBAL.LOGYAZ("HATA BITAYKA_urunIslemleri:", ex);
                Description = result;
            }
            return Description;
        }
        private void ACCESSTOKKENAL(string USERNAME, string PASSWORD) {
            accessToken = BITAYKA_getAccessToken(USERNAME, PASSWORD);
        }
        private void FRM_MALZEMELISTESI_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_MALZEMELISTESI, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_MALZEMELISTESI.Name);
        }
        private void SB_eXCELEKAYDET_Click(object sender, EventArgs e) {
            BMS_DLL.DX.DXGRIDEXCELEKAYDET(GRV_MALZEMELISTESI, true);
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
        private void BTN_URUNSATISAAC_Click(object sender, EventArgs e) {
            SplashScreenManager.ShowForm((Form)this, typeof(PROGRESSFORM), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("İşleminiz Yapılıyor..");
            SplashScreenManager.Default.SetWaitFormDescription("Lütfen bekleyin...");
            string Operation = "UpdateProductStatus";
            string Status = "1";

            int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
            if (CB_MARKET1.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME1, _CFG.BITAYKAPASSWORD1);
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM1", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET1.Text, Operation, BITAYKAProductCode, "Satışa Açıldı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET1.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET2.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME2, _CFG.BITAYKAPASSWORD2);
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM2", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET2.Text, Operation, BITAYKAProductCode, "Satışa Açıldı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET2.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET3.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME3, _CFG.BITAYKAPASSWORD3);
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM3", RESULT);
                    if (RESULT == "Update succeded!") {
                        INSERT_ENTDB(CB_MARKET3.Text, Operation, BITAYKAProductCode, "Satışa Açıldı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET3.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET4.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME4, _CFG.BITAYKAPASSWORD4);
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM4", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET4.Text, Operation, BITAYKAProductCode, "Satışa Açıldı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET4.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET5.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME5, _CFG.BITAYKAPASSWORD5);
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM5", BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status));
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET5.Text, Operation, BITAYKAProductCode, "Satışa Açıldı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET5.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            SplashScreenManager.CloseForm(false);
        }
        private void BTN_URUNSATISAKAPAT_Click(object sender, EventArgs e) {
            SplashScreenManager.ShowForm((Form)this, typeof(PROGRESSFORM), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("İşleminiz Yapılıyor..");
            SplashScreenManager.Default.SetWaitFormDescription("Lütfen bekleyin...");
            string Operation = "UpdateProductStatus";
            string Status = "0";
            if (CB_MARKET1.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME1, _CFG.BITAYKAPASSWORD1);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM1", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET1.Text, Operation, BITAYKAProductCode, "Satışa Kapandı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET1.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET2.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME2, _CFG.BITAYKAPASSWORD2);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM2", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET2.Text, Operation, BITAYKAProductCode, "Satışa Kapandı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET2.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET3.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME3, _CFG.BITAYKAPASSWORD3);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM3", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET3.Text, Operation, BITAYKAProductCode, "Satışa Kapandı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET3.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET4.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME4, _CFG.BITAYKAPASSWORD4);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM4", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET4.Text, Operation, BITAYKAProductCode, "Satışa Kapandı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET4.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET5.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME5, _CFG.BITAYKAPASSWORD5);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM5", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET5.Text, Operation, BITAYKAProductCode, "Satışa Kapandı");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET5.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }
            SplashScreenManager.CloseForm(false);
        }
        private void BTN_URUNFIYATGUNCELLE_Click(object sender, EventArgs e) {
            SplashScreenManager.ShowForm((Form)this, typeof(PROGRESSFORM), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("İşleminiz Yapılıyor..");
            SplashScreenManager.Default.SetWaitFormDescription("Lütfen bekleyin...");
            string Operation = "UpdateProductPrice";
            if (CB_MARKET1.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME1, _CFG.BITAYKAPASSWORD1);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string BITAYKAPrice = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "Price").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Price", BITAYKAPrice);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM1", RESULT);
                    if (RESULT == "Update succeded!") {
                        INSERT_ENTDB(CB_MARKET1.Text, Operation, BITAYKAProductCode, BITAYKAPrice);
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET1.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET2.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME2, _CFG.BITAYKAPASSWORD2);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string BITAYKAPrice = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "Price").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Price", BITAYKAPrice);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM2", RESULT);
                    if (RESULT == "Update succeded!") {
                        INSERT_ENTDB(CB_MARKET2.Text, Operation, BITAYKAProductCode, BITAYKAPrice);
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET2.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET3.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME3, _CFG.BITAYKAPASSWORD3);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string BITAYKAPrice = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "Price").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Price", BITAYKAPrice);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM3", RESULT);
                    if (RESULT == "Update succeded!") {
                        INSERT_ENTDB(CB_MARKET3.Text, Operation, BITAYKAProductCode, BITAYKAPrice);
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET3.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET4.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME4, _CFG.BITAYKAPASSWORD4);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string BITAYKAPrice = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "Price").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Price", BITAYKAPrice);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM4", RESULT);
                    if (RESULT == "Update succeded!") {
                        INSERT_ENTDB(CB_MARKET4.Text, Operation, BITAYKAProductCode, BITAYKAPrice);
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET4.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }

            if (CB_MARKET5.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME5, _CFG.BITAYKAPASSWORD5);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string BITAYKAPrice = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "Price").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Price", BITAYKAPrice);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM5", RESULT);
                    if (RESULT == "Update succeded!") {
                        INSERT_ENTDB(CB_MARKET5.Text, Operation, BITAYKAProductCode, BITAYKAPrice);
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET5.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }

            }
            SplashScreenManager.CloseForm(false);
        }
        private void BTN_URUNSIL_Click(object sender, EventArgs e) {
            SplashScreenManager.ShowForm((Form)this, typeof(PROGRESSFORM), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("İşleminiz Yapılıyor..");
            SplashScreenManager.Default.SetWaitFormDescription("Lütfen bekleyin...");
            string Operation = "UpdateProductStatus";
            string Status = "-1";

            if (CB_MARKET1.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME1, _CFG.BITAYKAPASSWORD1);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM1", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET1.Text, Operation, BITAYKAProductCode, "Ürün Silindi");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET1.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }
            }

            if (CB_MARKET2.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME2, _CFG.BITAYKAPASSWORD2);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM2", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET2.Text, Operation, BITAYKAProductCode, "Ürün Silindi");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET2.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }
            }

            if (CB_MARKET3.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME3, _CFG.BITAYKAPASSWORD3);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM3", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET3.Text, Operation, BITAYKAProductCode, "Ürün Silindi");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET3.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }
            }

            if (CB_MARKET4.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME4, _CFG.BITAYKAPASSWORD4);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM4", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET4.Text, Operation, BITAYKAProductCode, "Ürün Silindi");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET4.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }
            }

            if (CB_MARKET5.Checked == true) {

                ACCESSTOKKENAL(_CFG.BITAYKAUSERNAME5, _CFG.BITAYKAPASSWORD5);
                int[] SROW = GRV_MALZEMELISTESI.GetSelectedRows();
                for (int i = 0; i < SROW.Length; i++) {
                    string BITAYKAProductCode = GRV_MALZEMELISTESI.GetRowCellValue(SROW[i], "ProductCode").ToString();
                    string RESULT = BITAYKA_urunIslemleri(Operation, UserID, accessToken, BITAYKAProductCode, "Status", Status);
                    GRV_MALZEMELISTESI.SetRowCellValue(SROW[i], "DURUM5", RESULT);
                    if (RESULT.Contains("Update suc")) {
                        INSERT_ENTDB(CB_MARKET5.Text, Operation, BITAYKAProductCode, "Ürün Silindi");
                    }
                    SplashScreenManager.Default.SetWaitFormDescription(CB_MARKET5.Text + "-Toplam:" + SROW.Length + " / Yapılan:" + (i).ToString());
                }
            }


            SplashScreenManager.CloseForm(false);
        }

        private void mARKETENTEGRASYONGEÇMİŞİToolStripMenuItem_Click(object sender, EventArgs e) {
            //FRM_ENTEGRASYONGECMISI MEG = new FRM_ENTEGRASYONGECMISI(_CFG, SECILIMARKET, GRC_MALZEMELISTESI.DataSource);
            //MEG.Show();
        }

        private void CB_MARKET1_MouseDown(object sender, MouseEventArgs e) {
            SECILIMARKET = CB_MARKET1.Text;
        }

        private void CB_MARKET2_MouseDown(object sender, MouseEventArgs e) {
            SECILIMARKET = CB_MARKET2.Text;
        }

        private void CB_MARKET3_MouseDown(object sender, MouseEventArgs e) {
            SECILIMARKET = CB_MARKET3.Text;
        }

        private void CB_MARKET4_MouseDown(object sender, MouseEventArgs e) {
            SECILIMARKET = CB_MARKET4.Text;
        }

        private void CB_MARKET5_MouseDown(object sender, MouseEventArgs e) {
            SECILIMARKET = CB_MARKET5.Text;
        }
    }
}
