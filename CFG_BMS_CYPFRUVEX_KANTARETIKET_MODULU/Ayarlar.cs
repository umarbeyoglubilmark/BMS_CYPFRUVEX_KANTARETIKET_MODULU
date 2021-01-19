using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class Ayarlar : DevExpress.XtraEditors.XtraForm {
        string _xmlPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.xml";
        string _datPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.cfg";
        string _key = "0WXOM7IKTM012016";
        CONFIG CFG;
        public Ayarlar() {
            InitializeComponent();
            CFG = GET_CONFIG();
            INITIALIZE_VALUES();
        }

        private void simpleButtonKAYDET_Click(object sender, EventArgs e) {
            // BMS_DLL.CFGGETSET.AYARLARIKAYDET(textEditLS_KULLANICIADI.Text, textEditLS_PAROLA.Text, textEditLS_SUNUCU.Text, textEditLS_VERITABANI.Text, textEditLS_RESTAPIURL.Text, comboBoxEditBS_VERITABANITIPI.SelectedIndex, textEditBS_KULLANICIADI.Text, textEditBS_PAROLA.Text, textEditBS_SUNUCU.Text, textEditBS_VERITABANI.Text, textEditFB_FIRMANO.Text, textEditFB_PERIOD.Text, textEditFB_ONCEKIFIRMANO.Text, textEditFB_ONCEKIPERIOD.Text, textEditKB_BMSKULLANICIKODU.Text, textEditKB_BMSPAROLA.Text, textEditKB_LOKULLANICIKODU.Text, textEditKB_LOPAROLA.Text, textEditWS_SERVISSURE.Text, comboBoxEditWS_SURECINSI.SelectedIndex, comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex);
            sb_SAVE_Click_();
        }
        private void INITIALIZE_VALUES() {
            if (CFG != null) {
                try { CB_VERITABANITURU.Text = CFG.VERITABANITURU; } catch { }
                try { textEditLS_KULLANICIADI.Text = CFG.LGDBUSERNAME; } catch { }
                try { textEditLS_PAROLA.Text = CFG.LGDBPASSWORD; } catch { }
                try { textEditLS_SUNUCU.Text = CFG.LGDBSERVER; } catch { }
                try { textEditLS_VERITABANI.Text = CFG.LGDBDATABASE; } catch { }
                try { TE_MLD.Text = CFG.MLD; } catch { }

                try { textEditBS_URL.Text = CFG.BITAYKAURL; } catch { }

                try { textEditBS_MARKET1.Text = CFG.BITAYKAMARKET1; } catch { }
                try { textEditBS_KULLANICIADI1.Text = CFG.BITAYKAUSERNAME1; } catch { }
                try { textEditBS_PAROLA1.Text = CFG.BITAYKAPASSWORD1; } catch { }

                try { textEditBS_MARKET2.Text = CFG.BITAYKAMARKET2; } catch { }
                try { textEditBS_KULLANICIADI2.Text = CFG.BITAYKAUSERNAME2; } catch { }
                try { textEditBS_PAROLA2.Text = CFG.BITAYKAPASSWORD2; } catch { }

                try { textEditBS_MARKET3.Text = CFG.BITAYKAMARKET3; } catch { }
                try { textEditBS_KULLANICIADI3.Text = CFG.BITAYKAUSERNAME3; } catch { }
                try { textEditBS_PAROLA3.Text = CFG.BITAYKAPASSWORD3; } catch { }

                try { textEditBS_MARKET4.Text = CFG.BITAYKAMARKET4; } catch { }
                try { textEditBS_KULLANICIADI4.Text = CFG.BITAYKAUSERNAME4; } catch { }
                try { textEditBS_PAROLA4.Text = CFG.BITAYKAPASSWORD4; } catch { }

                try { textEditBS_MARKET5.Text = CFG.BITAYKAMARKET5; } catch { }
                try { textEditBS_KULLANICIADI5.Text = CFG.BITAYKAUSERNAME5; } catch { }
                try { textEditBS_PAROLA5.Text = CFG.BITAYKAPASSWORD5; } catch { }


                try { textEditFB_FIRMANO.Text = CFG.FIRMNR; } catch { }
                try { textEditFB_PERIOD.Text = CFG.PERIOD; } catch { }
                try { textEditFB_ONCEKIFIRMANO.Text = CFG.PREVIOUSFIRMNR; } catch { }
                try { textEditFB_ONCEKIPERIOD.Text = CFG.PREVIOUSPERIOD; } catch { }
                try { TE_URETICIBASLANGICKODU.Text = CFG.URETICIBASLANGICKODU; } catch { }
                try { TE_KONTRAKTORBASLANGICKODU.Text = CFG.KONTRAKTORBASLANGICKODU; } catch { }
                try { textEditKB_BMSKULLANICIKODU.Text = CFG.BMSDEFAULTUSERNAME; } catch { }
                try { textEditKB_BMSPAROLA.Text = CFG.BMSDEFAULTPASSWORD; } catch { }
                try { textEditKB_LOKULLANICIKODU.Text = CFG.LOBJECTDEFAULTUSERNAME; } catch { }
                try { textEditKB_LOPAROLA.Text = CFG.LOBJECTDEFAULTPASSWORD; } catch { }
                try { textEditWS_SERVISSURE.Text = CFG.SERVICEPERIOD.ToString(); } catch { }
                try { comboBoxEditWS_SURECINSI.SelectedIndex = CFG.SERVICEPERIODTYPE; } catch { }
                try { comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex = CFG.SERVICETABLESDBCHOICE; } catch { }

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

        private void sb_SAVE_Click_() {
            File.WriteAllText(_xmlPath, string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                "<BILMARKSOFTWARE>" +
                    "<LGDB>" + //NODE 0
                        "<VERITABANITURU>" + CB_VERITABANITURU.Text + "</VERITABANITURU>" +
                        "<USERNAME>" + textEditLS_KULLANICIADI.Text + "</USERNAME>" +
                        "<PASSWORD>" + textEditLS_PAROLA.Text + "</PASSWORD>" +
                        "<SERVER>" + textEditLS_SUNUCU.Text + "</SERVER>" +
                        "<DATABASE>" + textEditLS_VERITABANI.Text + "</DATABASE>" +
                        "<MLD>" + TE_MLD.Text + "</MLD>" +
                    "</LGDB>" +
                    "<BITAYKA>" + //NODE 1 
                       "<BITAYKAURL>" + (textEditBS_URL.Text + "</BITAYKAURL>" +
                        "<BITAYKAMARKET1>" + textEditBS_MARKET1.Text + "</BITAYKAMARKET1>" +
                        "<BITAYKAUSERNAME1>" + textEditBS_KULLANICIADI1.Text + "</BITAYKAUSERNAME1>" +
                        "<BITAYKAPASSWORD1>" + textEditBS_PAROLA1.Text + "</BITAYKAPASSWORD1>" +

                        "<BITAYKAMARKET2>" + textEditBS_MARKET2.Text + "</BITAYKAMARKET2>" +
                        "<BITAYKAUSERNAME2>" + textEditBS_KULLANICIADI2.Text + "</BITAYKAUSERNAME2>" +
                        "<BITAYKAPASSWORD2>" + textEditBS_PAROLA2.Text + "</BITAYKAPASSWORD2>" +

                        "<BITAYKAMARKET3>" + textEditBS_MARKET3.Text + "</BITAYKAMARKET3>" +
                        "<BITAYKAUSERNAME3>" + textEditBS_KULLANICIADI3.Text + "</BITAYKAUSERNAME3>" +
                        "<BITAYKAPASSWORD3>" + textEditBS_PAROLA3.Text + "</BITAYKAPASSWORD3>" +

                        "<BITAYKAMARKET4>" + textEditBS_MARKET4.Text + "</BITAYKAMARKET4>" +
                        "<BITAYKAUSERNAME4>" + textEditBS_KULLANICIADI4.Text + "</BITAYKAUSERNAME4>" +
                        "<BITAYKAPASSWORD4>" + textEditBS_PAROLA4.Text + "</BITAYKAPASSWORD4>" +

                        "<BITAYKAMARKET5>" + textEditBS_MARKET5.Text + "</BITAYKAMARKET5>" +
                        "<BITAYKAUSERNAME5>" + textEditBS_KULLANICIADI5.Text + "</BITAYKAUSERNAME5>" +
                        "<BITAYKAPASSWORD5>" + textEditBS_PAROLA5.Text + "</BITAYKAPASSWORD5>" +

                    "</BITAYKA>" +
                    "<CAPIFIRM>" + //NODE 2
                        "<FIRMNR>" + textEditFB_FIRMANO.Text + "</FIRMNR>" +
                        "<PERIOD>" + textEditFB_PERIOD.Text + "</PERIOD>" +
                        "<PREVFIRMNR>" + textEditFB_ONCEKIFIRMANO.Text + "</PREVFIRMNR>" +
                        "<PREVPERIOD>" + textEditFB_ONCEKIPERIOD.Text + "</PREVPERIOD>" +
                        "<URETICIBASLANGICKODU>" + TE_URETICIBASLANGICKODU.Text + "</URETICIBASLANGICKODU>" +
                        "<KONTRAKTORBASLANGICKODU>" + TE_KONTRAKTORBASLANGICKODU.Text + "</KONTRAKTORBASLANGICKODU>" +
                    "</CAPIFIRM>" +
                    "<DEFAULTUSERS>" + //NODE 3 
                        "<BMSUSERNAME>" + textEditKB_BMSKULLANICIKODU.Text + "</BMSUSERNAME>" +
                        "<BMSPASSWORD>" + textEditKB_BMSPAROLA.Text + "</BMSPASSWORD>" +
                        "<LOBJECTUSERNAME>" + textEditKB_LOKULLANICIKODU.Text + "</LOBJECTUSERNAME>" +
                        "<LOBJECTPASSWORD>" + textEditKB_LOPAROLA.Text + "</LOBJECTPASSWORD>" +
                    "</DEFAULTUSERS>" +
                    "<WINDOWSSERVICE>" + //NODE 4
                        "<SERVICE_PERIOD>" + textEditWS_SERVISSURE.Text + "</SERVICE_PERIOD>" +
                        "<SERVICE_PERIODTYPE>" + comboBoxEditWS_SURECINSI.SelectedIndex + "</SERVICE_PERIODTYPE>" +
                        "<SERVICE_TABLEDBCHOICE>" + comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex + "</SERVICE_TABLEDBCHOICE>" +
                    "</WINDOWSSERVICE>" +
                "</BILMARKSOFTWARE>")));

            if (EncryptFile(_xmlPath, _datPath, _key)) {
                try {
                    DecryptFile(_datPath, _xmlPath, _key);
                    if (File.Exists(_xmlPath))
                        File.Delete(_xmlPath);
                } catch { }
            }
            MessageBox.Show("VERİTABANI KONFİGÜRASYON DOSYASI KAYDEDİLDİ.\n\nDEĞİŞİKLİKLERİN ETKİLİ OLABİLMESİ İÇİN PROGRAMA YENİDEN GİRİŞ YAPILMASI GEREKMEKTEDİR.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        private bool EncryptFile(string inputFile, string outputFile, string skey) {
            try {
                using (RijndaelManaged aes = new RijndaelManaged()) {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each
                     encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create)) {
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV)) {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write)) {
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open)) {
                                    int data;
                                    while ((data = fsIn.ReadByte()) != -1) {
                                        cs.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
            } catch {
                return false;
            }
            //if (File.Exists(_xmlPath))
            //    File.Delete(_xmlPath);
            return true;
        }

        private void DecryptFile(string inputFile, string outputFile, string skey) {
            try {
                using (RijndaelManaged aes = new RijndaelManaged()) {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open)) {
                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create)) {
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
            } catch {

            }
        }

        private void Ayarlar_Shown(object sender, EventArgs e) {
            //BMS_DLL.CFGGETSET.AYARLARIYUKLE();
            ////BMS_DLL.CFGGETSET CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU = new BMS_DLL.CFGGETSET();
            //try { textEditLS_KULLANICIADI.Text = BMS_DLL.CFGICERIK.LGDBUSERNAME; } catch { }
            //try { textEditLS_PAROLA.Text = BMS_DLL.CFGICERIK.LGDBPASSWORD; } catch { }
            //try { textEditLS_SUNUCU.Text = BMS_DLL.CFGICERIK.LGDBSERVER; } catch { }
            //try { textEditLS_VERITABANI.Text = BMS_DLL.CFGICERIK.LGDBDATABASE; } catch { }
            //try { textEditLS_RESTAPIURL.Text = BMS_DLL.CFGICERIK.RESTURL; } catch { }

            //try { comboBoxEditBS_VERITABANITIPI.SelectedIndex = BMS_DLL.CFGICERIK.BMSDBSERVERTYPE; } catch { }
            //try { textEditBS_KULLANICIADI.Text = BMS_DLL.CFGICERIK.BMSDBUSERNAME; } catch { }
            //try { textEditBS_PAROLA.Text = BMS_DLL.CFGICERIK.BMSDBPASSWORD; } catch { }
            //try { textEditBS_SUNUCU.Text = BMS_DLL.CFGICERIK.BMSDBSERVER; } catch { }
            //try { textEditBS_VERITABANI.Text = BMS_DLL.CFGICERIK.BMSDBDATABASE; } catch { }

            //try { textEditFB_FIRMANO.Text = BMS_DLL.CFGICERIK.FIRMNR; } catch { }
            //try { textEditFB_PERIOD.Text = BMS_DLL.CFGICERIK.PERIOD; } catch { }
            //try { textEditFB_ONCEKIFIRMANO.Text = BMS_DLL.CFGICERIK.PREVIOUSFIRMNR; } catch { }
            //try { textEditFB_ONCEKIPERIOD.Text = BMS_DLL.CFGICERIK.PREVIOUSPERIOD; } catch { }

            //try { textEditKB_BMSKULLANICIKODU.Text = BMS_DLL.CFGICERIK.BMSDEFAULTUSERNAME; } catch { }
            //try { textEditKB_BMSPAROLA.Text = BMS_DLL.CFGICERIK.BMSDEFAULTPASSWORD; } catch { }
            //try { textEditKB_LOKULLANICIKODU.Text = BMS_DLL.CFGICERIK.LOBJECTDEFAULTUSERNAME; } catch { }
            //try { textEditKB_LOPAROLA.Text = BMS_DLL.CFGICERIK.LOBJECTDEFAULTPASSWORD; } catch { }

            //try { textEditWS_SERVISSURE.Text = BMS_DLL.CFGICERIK.SERVICEPERIOD.ToString(); } catch { }
            //try { comboBoxEditWS_SURECINSI.SelectedIndex = BMS_DLL.CFGICERIK.SERVICEPERIODTYPE; } catch { }
            //try { comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex = BMS_DLL.CFGICERIK.SERVICETABLESDBCHOICE; } catch { }
        }
    }
}