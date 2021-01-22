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
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.SqlClient;
using BMS_DLL;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Data.SQLite;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class Login : DevExpress.XtraEditors.XtraForm {
        string _xmlPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.xml";
        string _datPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.cfg";
        string _key = "0WXOM7IKTM012016";
        CONFIG CFG;
        string USERNAME = "";
        string PASSWORD = "";
        SqlConnection SQLCON = new SqlConnection();
        public Login() {
            InitializeComponent();

            CFG = GET_CONFIG();
            INITIALIZE_VALUES();
            //if (!File.Exists(GLOB.SORGU_ENTDB_PATH)) {
            //    CREATE_ENTDB();
            //}

        }
        private void CREATE_ENTDB() {
            SQLiteConnection.CreateFile(GLOB.SORGU_ENTDB_PATH);
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + GLOB.SORGU_ENTDB_PATH + ";Version=3;");
            m_dbConnection.Open();
            string sql = "create table ENT (LOGICALREF INTEGER PRIMARY KEY AUTOINCREMENT,Market varchar(200), ProductCode varchar(200), Price float,Status varchar(200), Fisno varchar(200),Type varchar(200),SYNCDATE date)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        private void INITIALIZE_VALUES() {
            if (CFG != null) {

                try { USERNAME = CFG.BMSDEFAULTUSERNAME; } catch { }
                try { PASSWORD = CFG.BMSDEFAULTPASSWORD; } catch { }

            }
        }
        private CONFIG GET_CONFIG() {
            try {
                using (RijndaelManaged aes = new RijndaelManaged()) {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(_key);

                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(_key);

                    using (FileStream fsCrypt = new FileStream(_datPath, FileMode.Open)) {
                        using (FileStream fsOut = new FileStream(_xmlPath, FileMode.Create)) {
                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV)) {
                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read)) {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1) {
                                        fsOut.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
                CONFIG CFG = new CONFIG();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(_xmlPath);
                if (File.Exists(_xmlPath))
                    File.Delete(_xmlPath);
                XmlNodeList xNode = xDoc.GetElementsByTagName("BILMARKSOFTWARE");
                XmlNode xNodeLGDB = xNode[0].ChildNodes[0];
                XmlNode xNodeBITAYKA = xNode[0].ChildNodes[1];
                XmlNode xNodeCAPIFIRM = xNode[0].ChildNodes[2];
                XmlNode xNodeUSERDEFAULTS = xNode[0].ChildNodes[3];
                XmlNode xNodeWINDOWSSERVICE = xNode[0].ChildNodes[4];
                try { CFG.VERITABANITURU = xNodeLGDB.ChildNodes[0].InnerText; } catch { }
                try { CFG.LGDBUSERNAME = xNodeLGDB.ChildNodes[1].InnerText; } catch { }
                try { CFG.LGDBPASSWORD = xNodeLGDB.ChildNodes[2].InnerText; } catch { }
                try { CFG.LGDBSERVER = xNodeLGDB.ChildNodes[3].InnerText; } catch { }
                try { CFG.LGDBDATABASE = xNodeLGDB.ChildNodes[4].InnerText; } catch { }
                try { CFG.MLD = xNodeLGDB.ChildNodes[5].InnerText; } catch { }

                try { CFG.BITAYKAURL = xNodeBITAYKA.ChildNodes[0].InnerText; } catch { }
                try { CFG.BITAYKAMARKET1 = xNodeBITAYKA.ChildNodes[1].InnerText; } catch { }
                try { CFG.BITAYKAUSERNAME1 = xNodeBITAYKA.ChildNodes[2].InnerText; } catch { }
                try { CFG.BITAYKAPASSWORD1 = xNodeBITAYKA.ChildNodes[3].InnerText; } catch { }

                try { CFG.BITAYKAMARKET2 = xNodeBITAYKA.ChildNodes[4].InnerText; } catch { }
                try { CFG.BITAYKAUSERNAME2 = xNodeBITAYKA.ChildNodes[5].InnerText; } catch { }
                try { CFG.BITAYKAPASSWORD2 = xNodeBITAYKA.ChildNodes[6].InnerText; } catch { }

                try { CFG.BITAYKAMARKET3 = xNodeBITAYKA.ChildNodes[7].InnerText; } catch { }
                try { CFG.BITAYKAUSERNAME3 = xNodeBITAYKA.ChildNodes[8].InnerText; } catch { }
                try { CFG.BITAYKAPASSWORD3 = xNodeBITAYKA.ChildNodes[9].InnerText; } catch { }

                try { CFG.BITAYKAMARKET4 = xNodeBITAYKA.ChildNodes[10].InnerText; } catch { }
                try { CFG.BITAYKAUSERNAME4 = xNodeBITAYKA.ChildNodes[11].InnerText; } catch { }
                try { CFG.BITAYKAPASSWORD4 = xNodeBITAYKA.ChildNodes[12].InnerText; } catch { }

                try { CFG.BITAYKAMARKET5 = xNodeBITAYKA.ChildNodes[13].InnerText; } catch { }
                try { CFG.BITAYKAUSERNAME5 = xNodeBITAYKA.ChildNodes[14].InnerText; } catch { }
                try { CFG.BITAYKAPASSWORD5 = xNodeBITAYKA.ChildNodes[15].InnerText; } catch { }

                try { CFG.FIRMNR = xNodeCAPIFIRM.ChildNodes[0].InnerText; } catch { }
                try { CFG.PERIOD = xNodeCAPIFIRM.ChildNodes[1].InnerText; } catch { }
                try { CFG.PREVIOUSFIRMNR = xNodeCAPIFIRM.ChildNodes[2].InnerText; } catch { }
                try { CFG.PREVIOUSPERIOD = xNodeCAPIFIRM.ChildNodes[3].InnerText; } catch { }
                try { CFG.URETICIBASLANGICKODU = xNodeCAPIFIRM.ChildNodes[4].InnerText; } catch { }
                try { CFG.KONTRAKTORBASLANGICKODU = xNodeCAPIFIRM.ChildNodes[5].InnerText; } catch { }
                try { CFG.BMSDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[0].InnerText; } catch { }
                try { CFG.BMSDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[1].InnerText; } catch { }
                try { CFG.LOBJECTDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[2].InnerText; } catch { }
                try { CFG.LOBJECTDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[3].InnerText; } catch { }
                try { CFG.SERVICEPERIOD = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[0].InnerText); } catch { }
                try { CFG.SERVICEPERIODTYPE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[1].InnerText); } catch { }
                try { CFG.SERVICETABLESDBCHOICE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[2].InnerText); } catch { }
                return CFG;
            } catch {
                return null;
            }
        }
        private void LOGIN() {

        }

        private void sb_LOGIN_Click(object sender, EventArgs e) {
            try {
                string LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
    CFG.LGDBSERVER, CFG.LGDBDATABASE, CFG.LGDBUSERNAME, CFG.LGDBPASSWORD);
                string YETKI = "";
                try {
                    SQLCON = new SqlConnection(LGCONSTR);
                    /*YETKI TUR KANTAR YONETICI OPERATOR */
                    YETKI = BMS_DLL.SQL.SELECT2(string.Format(@" SELECT TUR FROM BMS_KE_KULLANICILAR WHERE KULLANICIADI='{0}' AND PAROLA='{1}'", te_USERNAME.Text, te_PASSWORD.Text), SQLCON).Rows[0][0].ToString();
                } catch {
                    return;
                }
                if (YETKI!="") {
                    this.Hide();
                    BMS_DLL.GLOBAL.FORMAC(false, new MainForm(CFG,YETKI), this, false, "");
                } else {
                    MessageBox.Show("KULLANICI ADI PAROLA HATASI");
                }

            } catch { MessageBox.Show("HATA"); }

        }
    }
}