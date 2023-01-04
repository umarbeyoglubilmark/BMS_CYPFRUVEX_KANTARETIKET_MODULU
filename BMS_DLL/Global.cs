using BMS_DLL.OBJECTS;
using DevExpress.Data;
using DevExpress.DataAccess.Excel;
using DevExpress.DataAccess.Sql;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Excel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace BMS_DLL
{

    public class CFGICERIK
    {
        public static string LGDBSERVER { get; set; } = string.Empty;
        public static string LGDBDATABASE { get; set; } = string.Empty;
        public static string RESTURL { get; set; } = string.Empty;
        public static string RESTCLIENTID { get; set; } = string.Empty;
        public static string RESTCLIENTSECRET { get; set; } = string.Empty;
        public static string LGDBUSERNAME { get; set; } = string.Empty;
        public static string LGDBPASSWORD { get; set; } = string.Empty;
        public static int BMSDBSERVERTYPE { get; set; }
        public static string BMSDBSERVER { get; set; } = string.Empty;
        public static string BMSDBDATABASE { get; set; } = string.Empty;
        public static string BMSDBUSERNAME { get; set; } = string.Empty;
        public static string BMSDBPASSWORD { get; set; } = string.Empty;
        public static string FIRMNR { get; set; } = string.Empty;
        public static string PERIOD { get; set; } = string.Empty;
        public static string PREVIOUSFIRMNR { get; set; } = string.Empty;
        public static string PREVIOUSPERIOD { get; set; } = string.Empty;
        public static string BMSDEFAULTUSERNAME { get; set; } = string.Empty;
        public static string BMSDEFAULTPASSWORD { get; set; } = string.Empty;
        public static string LOBJECTDEFAULTUSERNAME { get; set; } = string.Empty;
        public static string LOBJECTDEFAULTPASSWORD { get; set; } = string.Empty;
        public static int SERVICEPERIOD { get; set; }
        public static int SERVICEPERIODTYPE { get; set; }
        public static int SERVICETABLESDBCHOICE { get; set; }
        public static int SAYIM { get; set; }
    }
    public class CFGGETSET
    {
        /// <summary>
        /// <para>Aciklama: CFGICERIK ayarlarını çeker (şifreli cfg dosyasından) - Önce AYARLARIKAYDET'ten kaydedilir</para>
        /// Ornek Kod: AYARLARIYUKLE();
        /// </summary>
        public static void AYARLARIYUKLE()
        {
            //CFGAYARLARI.AYARLARIYUKLE();
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(_key);

                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(_key);

                    using (FileStream fsCrypt = new FileStream(_datPath, FileMode.Open))
                    {
                        using (FileStream fsOut = new FileStream(_xmlPath, FileMode.Create))
                        {
                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                            {
                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        fsOut.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
                CFGICERIK CFG = new CFGICERIK();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(_xmlPath);
                if (File.Exists(_xmlPath))
                    File.Delete(_xmlPath);
                XmlNodeList xNode = xDoc.GetElementsByTagName("BILMARKSOFTWARE");
                XmlNode xNodeLGDB = xNode[0].ChildNodes[0];
                XmlNode xNodeBMDB = xNode[0].ChildNodes[1];
                XmlNode xNodeCAPIFIRM = xNode[0].ChildNodes[2];
                XmlNode xNodeUSERDEFAULTS = xNode[0].ChildNodes[3];
                XmlNode xNodeWINDOWSSERVICE = xNode[0].ChildNodes[4];

                try { CFGICERIK.LGDBUSERNAME = xNodeLGDB.ChildNodes[0].InnerText; } catch { }
                try { CFGICERIK.LGDBPASSWORD = xNodeLGDB.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.LGDBSERVER = xNodeLGDB.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.LGDBDATABASE = xNodeLGDB.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.RESTURL = xNodeLGDB.ChildNodes[4].InnerText; } catch { }
                try { CFGICERIK.BMSDBSERVERTYPE = int.Parse(xNodeBMDB.ChildNodes[0].InnerText); } catch { }
                try { CFGICERIK.BMSDBUSERNAME = xNodeBMDB.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.BMSDBPASSWORD = xNodeBMDB.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.BMSDBSERVER = xNodeBMDB.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.BMSDBDATABASE = xNodeBMDB.ChildNodes[4].InnerText; } catch { }
                try { CFGICERIK.FIRMNR = xNodeCAPIFIRM.ChildNodes[0].InnerText; } catch { }
                try { CFGICERIK.PERIOD = xNodeCAPIFIRM.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.PREVIOUSFIRMNR = xNodeCAPIFIRM.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.PREVIOUSPERIOD = xNodeCAPIFIRM.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.BMSDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[0].InnerText; } catch { }
                try { CFGICERIK.BMSDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.LOBJECTDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.LOBJECTDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.SERVICEPERIOD = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[0].InnerText); } catch { }
                try { CFGICERIK.SERVICEPERIODTYPE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[1].InnerText); } catch { }
                try { CFGICERIK.SERVICETABLESDBCHOICE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[2].InnerText); } catch { }
                try { CFGICERIK.SAYIM = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[3].InnerText); } catch { }
            }
            catch (Exception ex)
            {

            }

        }
        public static void AYARLARIYUKLEREST()
        {
            //CFGAYARLARI.AYARLARIYUKLE();
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(_key);

                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(_key);

                    using (FileStream fsCrypt = new FileStream(_datPath, FileMode.Open))
                    {
                        using (FileStream fsOut = new FileStream(_xmlPath, FileMode.Create))
                        {
                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                            {
                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        fsOut.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
                CFGICERIK CFG = new CFGICERIK();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(_xmlPath);
                if (File.Exists(_xmlPath))
                    File.Delete(_xmlPath);
                XmlNodeList xNode = xDoc.GetElementsByTagName("BILMARKSOFTWARE");
                XmlNode xNodeLGDB = xNode[0].ChildNodes[0];
                XmlNode xNodeBMDB = xNode[0].ChildNodes[1];
                XmlNode xNodeCAPIFIRM = xNode[0].ChildNodes[2];
                XmlNode xNodeUSERDEFAULTS = xNode[0].ChildNodes[3];
                XmlNode xNodeWINDOWSSERVICE = xNode[0].ChildNodes[4];

                try { CFGICERIK.LGDBUSERNAME = xNodeLGDB.ChildNodes[0].InnerText; } catch { }
                try { CFGICERIK.LGDBPASSWORD = xNodeLGDB.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.LGDBSERVER = xNodeLGDB.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.LGDBDATABASE = xNodeLGDB.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.RESTURL = xNodeLGDB.ChildNodes[4].InnerText; } catch { }
                try { CFGICERIK.RESTCLIENTID = xNodeLGDB.ChildNodes[5].InnerText; } catch { }
                try { CFGICERIK.RESTCLIENTSECRET = xNodeLGDB.ChildNodes[6].InnerText; } catch { }
                try { CFGICERIK.BMSDBSERVERTYPE = int.Parse(xNodeBMDB.ChildNodes[0].InnerText); } catch { }
                try { CFGICERIK.BMSDBUSERNAME = xNodeBMDB.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.BMSDBPASSWORD = xNodeBMDB.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.BMSDBSERVER = xNodeBMDB.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.BMSDBDATABASE = xNodeBMDB.ChildNodes[4].InnerText; } catch { }
                try { CFGICERIK.FIRMNR = xNodeCAPIFIRM.ChildNodes[0].InnerText; } catch { }
                try { CFGICERIK.PERIOD = xNodeCAPIFIRM.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.PREVIOUSFIRMNR = xNodeCAPIFIRM.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.PREVIOUSPERIOD = xNodeCAPIFIRM.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.BMSDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[0].InnerText; } catch { }
                try { CFGICERIK.BMSDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[1].InnerText; } catch { }
                try { CFGICERIK.LOBJECTDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[2].InnerText; } catch { }
                try { CFGICERIK.LOBJECTDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[3].InnerText; } catch { }
                try { CFGICERIK.SERVICEPERIOD = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[0].InnerText); } catch { }
                try { CFGICERIK.SERVICEPERIODTYPE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[1].InnerText); } catch { }
                try { CFGICERIK.SERVICETABLESDBCHOICE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[2].InnerText); } catch { }
            }
            catch (Exception ex)
            {

            }

        }
        /// <summary>
        /// <para>Aciklama: CFGICERIK ayarlarını cfg dosyasına kaydeder</para>
        /// Ornek Kod: BMS_DLL.CFGGETSET.AYARLARIKAYDET(textEditLS_KULLANICIADI.Text, textEditLS_PAROLA.Text, textEditLS_SUNUCU.Text, textEditLS_VERITABANI.Text, textEditLS_RESTAPIURL.Text, comboBoxEditBS_VERITABANITIPI.SelectedIndex, textEditBS_KULLANICIADI.Text, textEditBS_PAROLA.Text, textEditBS_SUNUCU.Text, textEditBS_VERITABANI.Text, textEditFB_FIRMANO.Text, textEditFB_PERIOD.Text, textEditFB_ONCEKIFIRMANO.Text, textEditFB_ONCEKIPERIOD.Text, textEditKB_BMSKULLANICIKODU.Text, textEditKB_BMSPAROLA.Text, textEditKB_LOKULLANICIKODU.Text, textEditKB_LOPAROLA.Text, textEditWS_SERVISSURE.Text, comboBoxEditWS_SURECINSI.SelectedIndex, comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex);
        /// </summary>
        public static void AYARLARIKAYDET(string LS_KULLANICIADI, string LS_PAROLA, string LS_SUNUCU, string LS_VERITABANI, string LS_RESTAPIURL, int BS_VERITABANITIPI, string BS_KULLANICIADI, string BS_PAROLA, string BS_SUNUCU, string BS_VERITABANI, string FB_FIRMANO, string FB_PERIOD, string FB_ONCEKIFIRMANO, string FB_ONCEKIPERIOD, string BMS_KULLANICIKODU, string BMS_PAROLA, string LO_KULLANICIKODU, string LO_PAROLA, string WS_SERVISSURE, int WS_SURECINSI, int WS_SERVISVERITABANIKONTROLTABLOSU, int SAYIM)
        {
            //            CFGAYARLARI.AYARLARIKAYDET(textEditLS_KULLANICIADI.Text, textEditLS_PAROLA.Text, textEditLS_SUNUCU.Text, textEditLS_VERITABANI.Text, textEditLS_RESTAPIURL.Text, comboBoxEditBS_VERITABANITIPI.SelectedIndex, textEditBS_KULLANICIADI.Text, textEditBS_PAROLA.Text, textEditBS_SUNUCU.Text, textEditBS_VERITABANI.Text, textEditFB_FIRMANO.Text, textEditFB_PERIOD.Text, textEditFB_ONCEKIFIRMANO.Text, textEditFB_ONCEKIPERIOD.Text, textEditKB_BMSKULLANICIKODU.Text, textEditKB_BMSPAROLA.Text, textEditKB_LOKULLANICIKODU.Text, textEditKB_LOPAROLA.Text, textEditWS_SERVISSURE.Text, comboBoxEditWS_SURECINSI.SelectedIndex, comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex);
            File.WriteAllText(_xmlPath, string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
    "<BILMARKSOFTWARE>" +
        "<LGDB>" + //NODE 0
            "<USERNAME>" + LS_KULLANICIADI + "</USERNAME>" +
            "<PASSWORD>" + LS_PAROLA + "</PASSWORD>" +
            "<SERVER>" + LS_SUNUCU + "</SERVER>" +
            "<DATABASE>" + LS_VERITABANI + "</DATABASE>" +
            "<RESTURL>" + LS_RESTAPIURL + "</RESTURL>" +
        "</LGDB>" +
        "<BMSDB>" + //NODE 1
            "<SERVERTYPE>" + (BS_VERITABANITIPI + "</SERVERTYPE>" +
            "<USERNAME>" + BS_KULLANICIADI + "</USERNAME>" +
            "<PASSWORD>" + BS_PAROLA + "</PASSWORD>" +
            "<SERVER>" + BS_SUNUCU + "</SERVER>" +
            "<DATABASE>" + BS_VERITABANI + "</DATABASE>" +
        "</BMSDB>" +
        "<CAPIFIRM>" + //NODE 2
            "<FIRMNR>" + FB_FIRMANO + "</FIRMNR>" +
            "<PERIOD>" + FB_PERIOD + "</PERIOD>" +
            "<PREVFIRMNR>" + FB_ONCEKIFIRMANO + "</PREVFIRMNR>" +
            "<PREVPERIOD>" + FB_ONCEKIPERIOD + "</PREVPERIOD>" +
        "</CAPIFIRM>" +
        "<DEFAULTUSERS>" + //NODE 3 
            "<BMSUSERNAME>" + BMS_KULLANICIKODU + "</BMSUSERNAME>" +
            "<BMSPASSWORD>" + BMS_PAROLA + "</BMSPASSWORD>" +
            "<LOBJECTUSERNAME>" + LO_KULLANICIKODU + "</LOBJECTUSERNAME>" +
            "<LOBJECTPASSWORD>" + LO_PAROLA + "</LOBJECTPASSWORD>" +
        "</DEFAULTUSERS>" +
        "<WINDOWSSERVICE>" + //NODE 4
            "<SERVICE_PERIOD>" + WS_SERVISSURE + "</SERVICE_PERIOD>" +
            "<SERVICE_PERIODTYPE>" + WS_SURECINSI + "</SERVICE_PERIODTYPE>" +
            "<SERVICE_TABLEDBCHOICE>" + WS_SERVISVERITABANIKONTROLTABLOSU + "</SERVICE_TABLEDBCHOICE>" +
            "<SERVICE_SAYIM>" + SAYIM + "</SERVICE_SAYIM>" +
        "</WINDOWSSERVICE>" +
    "</BILMARKSOFTWARE>")));
            if (EncryptFile(_xmlPath, _datPath, _key))
            {
                try
                {
                    DecryptFile(_datPath, _xmlPath, _key);
                    if (File.Exists(_xmlPath))
                        File.Delete(_xmlPath);
                    MessageBox.Show("Ayarlar Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
            }
        }
        public static void AYARLARIKAYDETREST(string LS_KULLANICIADI, string LS_PAROLA, string LS_SUNUCU, string LS_VERITABANI, string LS_RESTAPIURL, string RESTCLIENTID, string RESTCLIENTSECRET, int BS_VERITABANITIPI, string BS_KULLANICIADI, string BS_PAROLA, string BS_SUNUCU, string BS_VERITABANI, string FB_FIRMANO, string FB_PERIOD, string FB_ONCEKIFIRMANO, string FB_ONCEKIPERIOD, string BMS_KULLANICIKODU, string BMS_PAROLA, string LO_KULLANICIKODU, string LO_PAROLA, string WS_SERVISSURE, int WS_SURECINSI, int WS_SERVISVERITABANIKONTROLTABLOSU)
        {
            //            CFGAYARLARI.AYARLARIKAYDET(textEditLS_KULLANICIADI.Text, textEditLS_PAROLA.Text, textEditLS_SUNUCU.Text, textEditLS_VERITABANI.Text, textEditLS_RESTAPIURL.Text, comboBoxEditBS_VERITABANITIPI.SelectedIndex, textEditBS_KULLANICIADI.Text, textEditBS_PAROLA.Text, textEditBS_SUNUCU.Text, textEditBS_VERITABANI.Text, textEditFB_FIRMANO.Text, textEditFB_PERIOD.Text, textEditFB_ONCEKIFIRMANO.Text, textEditFB_ONCEKIPERIOD.Text, textEditKB_BMSKULLANICIKODU.Text, textEditKB_BMSPAROLA.Text, textEditKB_LOKULLANICIKODU.Text, textEditKB_LOPAROLA.Text, textEditWS_SERVISSURE.Text, comboBoxEditWS_SURECINSI.SelectedIndex, comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex);
            File.WriteAllText(_xmlPath, string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
    "<BILMARKSOFTWARE>" +
        "<LGDB>" + //NODE 0
            "<USERNAME>" + LS_KULLANICIADI + "</USERNAME>" +
            "<PASSWORD>" + LS_PAROLA + "</PASSWORD>" +
            "<SERVER>" + LS_SUNUCU + "</SERVER>" +
            "<DATABASE>" + LS_VERITABANI + "</DATABASE>" +
            "<RESTURL>" + LS_RESTAPIURL + "</RESTURL>" +
            "<RESTCLIENTID>" + RESTCLIENTID + "</RESTCLIENTID>" +
            "<RESTCLIENTSECRET>" + RESTCLIENTSECRET + "</RESTCLIENTSECRET>" +
        "</LGDB>" +
        "<BMSDB>" + //NODE 1
            "<SERVERTYPE>" + (BS_VERITABANITIPI + "</SERVERTYPE>" +
            "<USERNAME>" + BS_KULLANICIADI + "</USERNAME>" +
            "<PASSWORD>" + BS_PAROLA + "</PASSWORD>" +
            "<SERVER>" + BS_SUNUCU + "</SERVER>" +
            "<DATABASE>" + BS_VERITABANI + "</DATABASE>" +
        "</BMSDB>" +
        "<CAPIFIRM>" + //NODE 2
            "<FIRMNR>" + FB_FIRMANO + "</FIRMNR>" +
            "<PERIOD>" + FB_PERIOD + "</PERIOD>" +
            "<PREVFIRMNR>" + FB_ONCEKIFIRMANO + "</PREVFIRMNR>" +
            "<PREVPERIOD>" + FB_ONCEKIPERIOD + "</PREVPERIOD>" +
        "</CAPIFIRM>" +
        "<DEFAULTUSERS>" + //NODE 3 
            "<BMSUSERNAME>" + BMS_KULLANICIKODU + "</BMSUSERNAME>" +
            "<BMSPASSWORD>" + BMS_PAROLA + "</BMSPASSWORD>" +
            "<LOBJECTUSERNAME>" + LO_KULLANICIKODU + "</LOBJECTUSERNAME>" +
            "<LOBJECTPASSWORD>" + LO_PAROLA + "</LOBJECTPASSWORD>" +
        "</DEFAULTUSERS>" +
        "<WINDOWSSERVICE>" + //NODE 4
            "<SERVICE_PERIOD>" + WS_SERVISSURE + "</SERVICE_PERIOD>" +
            "<SERVICE_PERIODTYPE>" + WS_SURECINSI + "</SERVICE_PERIODTYPE>" +
            "<SERVICE_TABLEDBCHOICE>" + WS_SERVISVERITABANIKONTROLTABLOSU + "</SERVICE_TABLEDBCHOICE>" +
        "</WINDOWSSERVICE>" +
    "</BILMARKSOFTWARE>")));
            if (EncryptFile(_xmlPath, _datPath, _key))
            {
                try
                {
                    DecryptFile(_datPath, _xmlPath, _key);
                    if (File.Exists(_xmlPath))
                        File.Delete(_xmlPath);
                    MessageBox.Show("Ayarlar Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
            }
        }

        private static readonly string _xmlPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.xml";
        private static readonly string _datPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.cfg";
        private static readonly string _key = "0WXOM7IKTM012016";
        private static bool EncryptFile(string inputFile, string outputFile, string skey)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each
                     encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                    {
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                                {
                                    int data;
                                    while ((data = fsIn.ReadByte()) != -1)
                                    {
                                        cs.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            //if (File.Exists(_xmlPath))
            //    File.Delete(_xmlPath);
            return true;
        }
        private static void DecryptFile(string inputFile, string outputFile, string skey)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                    {
                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                        {
                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                            {
                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    int data;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        fsOut.WriteByte((byte)data);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
    public class GLOBAL
    {
        /// <summary>
        /// <para>Aciklama: Sayının küsüratını ikiye düşürür ve yuvarlar</para>
        /// Ornek Kod: MATH_YUVARLA(55.6)
        /// </summary>
        public static double MATH_YUVARLA(double SAYI)
        {
            try
            {
                return Math.Round(SAYI, 2, MidpointRounding.AwayFromZero);
            }
            catch { return 0; }
        }
        /// <summary>
        /// <para>Aciklama: Mail atar</para>
        /// Ornek Kod: MAILAT(587, "testmail@bil.com, "parola123", "mail.bil.com", "destek@bil.com, "xmusteri@gmail.com", "direktor@bil.com","Talep Hk.", "X tarihinde talebiniz oluştu teşekkürler.")
        /// </summary>
        public static void MAILAT(int SMTPPORT, string SMTPUSERNAME, string SMPTPPASSWORD, string SMTPHOST, string FROM, string MAILTO, string MAILTOSIRKETICI, string SUBJECT, string BODY)
        {
            //GIDEN MAIL ADRESLERI ; ILE AYRILIR
            //DateTime myDateTime = DateTime.Parse(dateEditTarih.Text);
            //string sqlFormattedDate = myDateTime.ToString("dd-MM-yyyy");
            MailMessage mail = new MailMessage
            {
                From = new System.Net.Mail.MailAddress(FROM)
            };
            SmtpClient smtp = new SmtpClient
            {
                //smtp.Port = 587;
                Port = SMTPPORT,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                //smtp.Credentials = new NetworkCredential("callcenter@bilmarkltd.com", "bm12975/*");
                Credentials = new NetworkCredential(SMTPUSERNAME, SMPTPPASSWORD),
                //smtp.Host = "mail.bilmarkltd.com";
                Host = SMTPHOST
            };

            //Müşterilere
            string addressesMUSTERI = MAILTO;
            foreach (var address in addressesMUSTERI.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                mail.To.Add(address);
            }

            //Şirket içine
            string addressesIC = MAILTOSIRKETICI;
            foreach (var address in addressesIC.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                mail.Bcc.Add(address);
            }
            //mail.To.Add(new MailAddress("semihyilmazbms@gmail.com"));
            //Formatted mail body
            mail.IsBodyHtml = true;
            mail.Subject = SUBJECT;
            mail.Body = BODY;
            smtp.Send(mail);
        }
        /// <summary>
        /// <para>Aciklama: Programın bulunduğu klasorun altına log isminde klasor oluşturulan tarihlerin adında txt dosyası oluşturup içine log yazar</para>
        /// Ornek Kod:  try{InitializeComponent();}catch (Exception e){BMS_DLL.GLOBAL.LOGYAZ("HATA", e.Message);}
        /// </summary>
        public static void LOGYAZ(string hata, Exception E)
        {
            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "logs\\";
                Directory.CreateDirectory(directory);
                string path = directory + DateTime.Now.ToString("yyyy.MM.dd") + ".txt";
                if (!File.Exists(path))
                    File.Create(path).Close();
                else
                    File.AppendAllText(path, Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(path, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + " : " + hata +
                    Environment.NewLine + (E != null ? " ----- HATA : ----- " + E.ToString() : ""));
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Mdi yada yeni ekranda form açar. Örnek Ayarlar adında bir form oluştur</para>
        /// <para> Ornek Kod: Mdi Form:  BMS_DLL.GLOBAL.FORMAC(true, new Ayarlar(), this, false, null);</para>
        /// <para> Ornek Kod: Normal Form:  BMS_DLL.GLOBAL.FORMAC(false, new Ayarlar(), this, false, null);</para>
        /// </summary>
        public static void FORMAC(bool isMDIForm, Form parentForm, Form mainform, bool isFormBasligi, string FormBasligi)
        {
            //Global._FormAc(false, new MainForm(), this, false, null);

            if (isFormBasligi == true)
            {
                parentForm.Text = FormBasligi;
            }
            if (isMDIForm == true)
            {
                parentForm.MdiParent = mainform;
            }
            parentForm.Show();
        }
        /// <summary>
        /// <para>Aciklama: String değerinde mevcut tarih saat dk saniyeyi verir fiş nolarında kullanılabilir</para>
        /// string fisno = BMS_DLL.GLOBAL.NUMARATOR();
        /// </summary>
        public static string NUMARATOR()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
        }
        /// <summary>
        /// <para>Aciklama: Registrye isdenilen değerleri kaydeder(Computer\HKEY_CURRENT_USER\Software\SuperErp KULLANICIADI:XKULLANICI)</para>
        /// BMS_DLL.GLOBAL.REGISTIRYSET("KULLANICIADI", "XKULLANICI", "SuperErp");
        /// </summary>
        public static void REGISTIRYSET(string NAME, string VALUE, string PROJEADI)
        {
            //Computer\HKEY_CURRENT_USER\Software\PROJEADI
            RegistryKey SoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
            //RegistryKey AppNameKey = SoftwareKey.CreateSubKey("BMS_CC");
            RegistryKey AppNameKey = SoftwareKey.CreateSubKey(PROJEADI);
            AppNameKey.SetValue(NAME, VALUE);
        }
        /// <summary>
        /// <para>Aciklama: Registryden isdenilen değerleri alır(/Computer\HKEY_CURRENT_USER\Software\SuperErp KULLANICIADININ KARŞISINDAKİ DEĞER)</para>
        /// string KULLANICIADI = BMS_DLL.GLOBAL.REGISTIRYGET("KULLANICIADI", "SuperErp");
        /// </summary>
        public static string REGISTIRYGET(string NAME, string PROJEADI)
        {
            //Computer\HKEY_CURRENT_USER\Software\PROJEADI
            RegistryKey SoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey AppNameKey = SoftwareKey.CreateSubKey(PROJEADI);
            return AppNameKey.GetValue(NAME).ToString();
        }
        /// <summary>
        /// <para>Aciklama: İşlem yapan bilgisayarın ipsini alır</para>
        /// string USERIP = BMS_DLL.GLOBAL.GETIPADDRESS();
        /// </summary>
        public static string GETIPADDRESS()

        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }
            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);
            return address;
        }
        /// <summary>
        /// <para>Aciklama: Kelimedeki aralıkları alır.Aşağıdaki kod 2 döndürür</para>
        /// string ARALIK = BMS_DLL.GLOBAL.BETWEEN("123","1","3");
        /// </summary>
        public static string BETWEEN(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
        public static class STRING_SIFRELEME
        {
            private const string initVector = "0WXOM7ITKM_.,01EG";
            private const string passPhrase = "0WXOM7IKTM012016";
            private const int keysize = 256;
            /// <summary>
            /// <para>Aciklama: Stringi şifreler aşağıda dönen değer: xkRk4n3KqZBFyI6RetjHuw==</para>
            /// string PAROLA = BMS_DLL.GLOBAL.EncryptString("123456");
            /// </summary>
            public static string EncryptString(string plainText)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged
                {
                    Mode = CipherMode.CBC
                };
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(cipherTextBytes);
            }
            /// <summary>
            /// <para>Aciklama: EncryptString ile Şifreleneni Çözer. Aşağıda dönen değer 123456</para>
            /// string PAROLA = BMS_DLL.GLOBAL.DecryptString("xkRk4n3KqZBFyI6RetjHuw==");
            /// </summary>
            public static string DecryptString(string cipherText)
            {
                try
                {
                    byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                    byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                    PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                    byte[] keyBytes = password.GetBytes(keysize / 8);
                    RijndaelManaged symmetricKey = new RijndaelManaged
                    {
                        Mode = CipherMode.CBC
                    };
                    ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                    MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                    byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                    memoryStream.Close();
                    cryptoStream.Close();
                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
    public class SQL
    {
        /// <summary>
        /// gridControl1.DataSource = BMS_DLL.SQL.SELECT("SELECT * FROM BM_PDKS_ADIM2");
        /// </summary>
        public static DataTable SELECT(string sqlQuery)
        {
            //            gridControl1.DataSource = sqlhelper.getDataTable("SELECT DISTINCT FIRMAKOD,(SELECT NAME FROM B_CAPIFIRM WHERE NR=A2.FIRMAKOD) FIRMAADI, YIL,AY FROM BM_PDKS_ADIM2 A2");
            SqlDataAdapter sqlDataAdapterItem = new SqlDataAdapter(sqlQuery, sqlConnectionSource);
            sqlDataAdapterItem.SelectCommand.CommandTimeout = 0;
            DataTable dataTableItem = new DataTable();
            sqlDataAdapterItem.Fill(dataTableItem);
            return dataTableItem;
        }
        public static DataTable SELECT2(string sqlQuery, SqlConnection sqlconnection2)
        {
            //            gridControl1.DataSource = sqlhelper.getDataTable("SELECT DISTINCT FIRMAKOD,(SELECT NAME FROM B_CAPIFIRM WHERE NR=A2.FIRMAKOD) FIRMAADI, YIL,AY FROM BM_PDKS_ADIM2 A2");
            SqlDataAdapter sqlDataAdapterItem = new SqlDataAdapter(sqlQuery, sqlconnection2);
            DataTable dataTableItem = new DataTable();
            sqlDataAdapterItem.Fill(dataTableItem);
            return dataTableItem;
        }
        public DataTable CONVERT_EXCEL_TO_DATATABLE(bool ISXLSX, bool ISFIRSTROWCOLUMNNAME, string PATH, int RETURNEDTABLENR)
        {
            FileStream stream = File.Open(PATH, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = null;

            if (ISXLSX)
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            else
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);

            excelReader.IsFirstRowAsColumnNames = ISFIRSTROWCOLUMNNAME;

            DataSet result = excelReader.AsDataSet();


            ////5. Data Reader methods
            //while (excelReader.Read())
            //{
            //    //excelReader.GetInt32(0);
            //}

            excelReader.Close();

            return result.Tables[RETURNEDTABLENR];
        }
        public DataTable GET_DATATABLE_WITH_TRANSACTION(SqlCommand COM, SqlTransaction TRANSACTION, int TABLEINDEX)
        {
            try
            {
                COM.Transaction = TRANSACTION;
                COM.Connection = sqlConnectionSource;
                SqlDataAdapter DA = new SqlDataAdapter
                {
                    SelectCommand = COM
                };
                DataSet DS = new DataSet();
                DA.Fill(DS);
                return DS.Tables[TABLEINDEX];
            }
            catch (Exception E)
            {
                GLOBAL.LOGYAZ("GET_DATATABLE_WITH_TRANSACTION + COM : " + COM.CommandText, E);
                return null;
            }
        }
        public static void EXECUTE(Form _this, string sqlQuery)
        {
            SqlCommand sqlCommandItem = new SqlCommand(sqlQuery, sqlConnectionSource);
            sqlCommandItem.Connection.Open();
            sqlCommandItem.ExecuteNonQuery();
            sqlCommandItem.Connection.Close();
            sqlConnectionSource.Close();
        }
        /// <summary>
        /// <para>Aciklama: Önce ana projeye add devitem Progress Indicator ekle adını PROGRESSFORM yap. Cfgye bağlı veritabanında gerekli tablo , view , fonks vb. oluşturur.</para>
        /// <para>Ornek Kod :</para>
        /// <para>  public static SqlConnection sqlConnectionSource = new SqlConnection(string.Format(@"Server={0}; Database={1}; User Id ={2};Password ={3}", CFGICERIK.LGDBSERVER, CFGICERIK.LGDBDATABASE, CFGICERIK.LGDBUSERNAME, CFGICERIK.LGDBPASSWORD));</para>
        /// </summary>
        public static void EXECUTE2(Form _this, string sqlQuery, SqlConnection sqlConnectionSource2)
        {
            SqlCommand sqlCommandItem = new SqlCommand(sqlQuery, sqlConnectionSource2);
            sqlCommandItem.Connection.Open();
            sqlCommandItem.ExecuteNonQuery();
            sqlCommandItem.Connection.Close();
            sqlConnectionSource.Close();


        }

        /// <summary>
        /// <para>Aciklama: Önce ana projeye add devitem Progress Indicator ekle adını PROGRESSFORM yap. Cfgye bağlı veritabanında gerekli tablo , view , fonks vb. oluşturur.</para>
        /// <para>Ornek Kod :</para>
        /// <para>string[] LG_TABLES =  {</para>
        /// <para> "create table test",</para>
        ///<para>  "create table test2"</para>
        /// <para>   };</para>
        /// <para>   BMS_DLL.SQL.TABLOLARIOLUSTUR(typeof(PROGRESSFORM),this,LG_TABLES);</para>
        /// </summary>
        public static void TABLOLARIOLUSTUR(Type _PROGRESSFORM, Form _this, string[] LG_TABLES, bool isCS, string connectionstring)
        {

            //string[] LG_TABLES = new string[] {"create table test",
            //"create table test2"};
            //yada
            //string[] LG_TABLES =  {
            //  "create table test",
            //  "create table test2"
            //                      };

            SqlDatabase sqlLGDB;

            SplashScreenManager.ShowForm(_this, _PROGRESSFORM, true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("TABLOLAR OLUŞTURULUYOR.");
            SplashScreenManager.Default.SetWaitFormDescription("");
            if (connectionstring == null)
            {
                sqlLGDB = new SqlDatabase(string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;", CFGICERIK.LGDBSERVER, CFGICERIK.LGDBDATABASE, CFGICERIK.LGDBUSERNAME, CFGICERIK.LGDBPASSWORD));
            }
            else
            {
                if (isCS == false)
                {
                    sqlLGDB = new SqlDatabase(sqlConnectionSource.ToString());
                }
                else
                    sqlLGDB = new SqlDatabase(connectionstring);
            }
            foreach (string S in LG_TABLES)
            {
                try { sqlLGDB.ExecuteNonQuery(new SqlCommand(string.Format(S, CFGICERIK.FIRMNR))); }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SplashScreenManager.CloseForm(false);
            MessageBox.Show("TAMAMLANDI", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void TABLOLARIOLUSTUR2UYARISIZ(string[] LG_TABLES, bool isCS, string connectionstring)
        {

            //string[] LG_TABLES = new string[] {"create table test",
            //"create table test2"};
            //yada
            //string[] LG_TABLES =  {
            //  "create table test",
            //  "create table test2"
            //                      };

            SqlDatabase sqlLGDB;


            if (connectionstring == null)
            {
                sqlLGDB = new SqlDatabase(string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;", CFGICERIK.LGDBSERVER, CFGICERIK.LGDBDATABASE, CFGICERIK.LGDBUSERNAME, CFGICERIK.LGDBPASSWORD));
            }
            else
            {
                if (isCS == false)
                {
                    sqlLGDB = new SqlDatabase(sqlConnectionSource.ToString());
                }
                else
                    sqlLGDB = new SqlDatabase(connectionstring);

            }
            foreach (string S in LG_TABLES)
            {
                try { sqlLGDB.ExecuteNonQuery(new SqlCommand(string.Format(S, CFGICERIK.FIRMNR))); }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public static SqlConnection sqlConnectionSource = new SqlConnection(string.Format(@"Server={0}; Database={1}; User Id ={2};Password ={3}", CFGICERIK.LGDBSERVER, CFGICERIK.LGDBDATABASE, CFGICERIK.LGDBUSERNAME, CFGICERIK.LGDBPASSWORD));
        public static SqlConnection sqlConnectionSource2 = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;", CFGICERIK.LGDBSERVER, CFGICERIK.LGDBDATABASE, CFGICERIK.LGDBUSERNAME, CFGICERIK.LGDBPASSWORD));
        public static SqlConnection sqlConnectionSourcebms = new SqlConnection(string.Format(@"Server={0}; Database={1}; User Id ={2};Password ={3}", CFGICERIK.BMSDBSERVER, CFGICERIK.BMSDBDATABASE, CFGICERIK.BMSDBUSERNAME, CFGICERIK.BMSDBPASSWORD));

        //public static string  SqlConnection sqlconnection()
        //{
        //    SqlConnection sqlConnectionSource = new SqlConnection(string.Format("Server={0}; Database={1}; User Id ={2};Password ={3}", CFGICERIK.LGDBSERVER, CFGICERIK.LGDBDATABASE, CFGICERIK.LGDBUSERNAME, CFGICERIK.LGDBPASSWORD));
        //    return sqlConnectionSource;
        //}

        /// <summary>
        /// <para>Aciklama: Transactionlar Sql insert update delete işlemi yapar</para>
        /// <para>Ornek Kod :</para>
        /// <para>int REF;</para>
        /// <para>   BMS_DLL.SQL.EXECTRANSACTION("INSERT INTO KAYITLAR (FISNO) VALUES ('123')",out REF);</para>
        /// </summary>
        public static void EXECTRANSACTION(string SORGU, out int ID)
        {
            int _ID = new int();
            DateTime TRANSACTIONDATE = DateTime.Now;
            SqlConnection CON = new SqlConnection(SQL.sqlConnectionSource.ConnectionString);
            SqlCommand COM = null;
            SqlTransaction TRANSACTION = null;
            // int LOGICALREF = 0;
            try
            {
                if (CON.State != ConnectionState.Open)
                    CON.Open();
                TRANSACTION = CON.BeginTransaction();
                //COM = INSERT_KAYIT_COMMAND(K, CON, TRANSACTION);
                {
                    COM = new SqlCommand(string.Format(SORGU + "  SELECT SCOPE_IDENTITY()"), CON, TRANSACTION);
                    //COM.Parameters.AddWithValue("@LOGICALREF", K.LOGICALREF);
                    try
                    {
                        _ID = int.Parse(COM.ExecuteScalar().ToString());
                    }
                    catch (Exception)
                    {
                        _ID = 0;
                    }


                    // foreach (DETAY D in B.DETAY)
                    //foreach (KAYITLAR._KAYITLAR_DETAY D in K.KAYITLAR_DETAY)
                    //{
                    //    COM = new SqlCommand(string.Format("INSERT INTO KAYITLAR_DETAY (LOGICALREF,KAYITLARREF,MALZEMEKODU) VALUES (@LOGICALREF,@KAYITLARREF,@MALZEMEKODU) SELECT SCOPE_IDENTITY()"));
                    //    COM.Parameters.AddWithValue("@LOGICALREF", D.LOGICALREF);
                    //    COM.Parameters.AddWithValue("@KAYITLARREF",LOGICALREF);
                    //    COM.Parameters.AddWithValue("@MALZEMEKODU", D.MALZEMEKODU);
                    //    COM.ExecuteNonQuery();
                    //}
                    // COM.ExecuteNonQuery();
                }
                TRANSACTION.Commit();

            }
            catch (Exception E)
            {
                GLOBAL.LOGYAZ("HATA-", E);
                try { TRANSACTION.Rollback(); } catch { }
            }
            finally
            {
                try { if (CON.State != ConnectionState.Closed) CON.Close(); } catch { }
                try { TRANSACTION.Dispose(); } catch { }
            }

            ID = _ID;


        }


    }
    public class DX
    {
        public static string XTRAGRIDCONNECTIONSTRINGIFNOTFROMCFG;
        /// <summary>
        /// <para>Aciklama: Dx Gridview popup menuye aşağıya menu ekler. Not: gridviewin PopupMenuShowing eventina eklenmeli</para>
        ///  <para>ORNEK KOD: DXGRID_POPUPMENUEKLE(Gridview1, e, "GEÇERLİ FİLTREYİ KAYDET", DXMenuItem_Click)</para>
        ///  <para>     private void DXMenuItem_Click(object sender, EventArgs e)</para>
        ///  <para>     {</para>
        ///  <para>       if (((DXMenuItem)sender).Caption == "GEÇERLİ FİLTREYİ KAYDET")</para>
        ///  <para>       {</para>
        /// <para>           MessageBox.Show("test");</para>
        ///  <para>       }</para>
        ///   <para>    }</para>
        /// </summary>
        public static void DXGRID_POPUPMENUEKLE(GridView GV, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e, string KOMUTADI, EventHandler KOMUT)
        {
            e.Menu.Items.Add(new DXMenuItem(KOMUTADI, KOMUT));
        }
        public static void DXGRIDCOLUMNGIZLE(GridView gridView, string COLUMNNAME)
        {
            gridView.Columns[COLUMNNAME].Visible = false;
        }
        public static string DXGRIDSECILENINDEGERINIAL(GridView gridView, string COLUMNNAME)
        {
            return gridView.GetFocusedRowCellValue(COLUMNNAME).ToString();
        }
        public static void DXGRIDTAZELE(GridControl gridcontrol, SqlDataSource sqldatasource)
        {
            gridcontrol.BeginUpdate();
            try
            {
                sqldatasource.ClearRows();
                sqldatasource.Fill();
                gridcontrol.DataSource = sqldatasource;
            }
            finally
            {
                gridcontrol.EndUpdate();
            }
        }
        public static void DXGRIDEXCELEKAYDET(GridView gridview, bool KAYITSONRASIEXCELACILSINMI)
        {
            string filename;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            saveFileDialog1.ShowDialog();
            filename = saveFileDialog1.FileName;
            if (filename == "") filename = "";
            else
            {
                gridview.ExportToXlsx(filename);
                if (KAYITSONRASIEXCELACILSINMI == true)
                {
                    System.Diagnostics.Process.Start(filename);
                }

            }
        }
        /// <summary>
        /// <para>Aciklama: Dx SearchLookupEdit Veri bağlar.</para>
        /// Ornek Kod: BMS_DLL.DX.DXSEARCHLOOKUPEDIT_DATASOURCE(searchLookUpEdit1, "select LOGICALREF,FICHENO from BM_219_SIPARIS", "FICHENO", "LOGICALREF");
        /// </summary>
        public static void DXSEARCHLOOKUPEDIT_DATASOURCE(SearchLookUpEdit _SearchLookUpEdit, string QUERY, string DisplayMember, string ValueMember)
        {
            _SearchLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            _SearchLookUpEdit.Properties.DataSource = SQL.SELECT(QUERY);
            _SearchLookUpEdit.Properties.DisplayMember = DisplayMember;
            _SearchLookUpEdit.Properties.ValueMember = ValueMember;
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview layoutu kaydeder. Registryden : DevExpress\XtraGrid\Layouts\SuperErp\Satislar</para>
        /// Ornek Kod: DXGRID_SAVELAYOUTTO_REGISTIRY(gridcontrol,"SuperErp", "Satislar")
        /// </summary>
        public static void DXGRID_SAVELAYOUTTO_REGISTIRY(GridControl gridcontrol, string PROJEADI, string GRIDADI)
        {
            gridcontrol.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\" + PROJEADI + "\\" + GRIDADI);
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview layoutu alır. Registryden : DevExpress\XtraGrid\Layouts\SuperErp\Satislar</para>
        /// Ornek Kod: DXGRID_LOADLAYOUTFROM_REGISTIRY(gridcontrol,"SuperErp", "Satislar")
        /// </summary>
        public static void DXGRID_LOADLAYOUTFROM_REGISTIRY(GridControl gridcontrol, string PROJEADI, string GRIDADI)
        {
            gridcontrol.MainView.RestoreLayoutFromRegistry("DevExpress\\XtraGrid\\Layouts\\" + PROJEADI + "\\" + GRIDADI);
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview layoutu kaydeder. Bulunduğu Klasöre : Satislar.xml</para>
        /// Ornek Kod: DXGRID_SAVELAYOUTTO_XML(GridView1, "Satislar")
        /// </summary>
        public static void DXGRID_SAVELAYOUTTO_XML(GridView GV, string XMLFILE)
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Layouts"))
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Layouts");
                GV.SaveLayoutToXml(AppDomain.CurrentDomain.BaseDirectory + "\\Layouts\\" + XMLFILE + ".xml");
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview en son layoutu Xmlden alır</para>
        /// Ornek Kod: DXGRID_SAVELAYOUTTO_XML(GridView1, "Satislar")
        /// </summary>
        public static void DXGRID_LOADLAYOUTFROM_XML(GridView _GridView, string XMLLAYOUTNAME)
        {
            try
            {
                _GridView.RestoreLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + "\\Layouts\\" + XMLLAYOUTNAME + ".xml");
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview isdenilen columna summary kor.</para>
        /// Ornek Kod: BMS_DLL.DX.DXGRID_SUMMARY(gridView1, SummaryItemType.Sum, "TOPLAM", "TOPLAMSATIS");
        /// </summary>
        public static void DXGRID_SUMMARY(GridView _GridView, SummaryItemType SummaryType, string Baslangic_Ornek_Toplam, string HeaderColumn)
        {
            _GridView.OptionsView.ShowFooter = true;
            switch (SummaryType)
            {
                case SummaryItemType.Sum:
                    _GridView.Columns[HeaderColumn].SummaryItem.DisplayFormat = Baslangic_Ornek_Toplam + "={0:0.##}";
                    break;
                case SummaryItemType.Min:
                    _GridView.Columns[HeaderColumn].SummaryItem.DisplayFormat = Baslangic_Ornek_Toplam + "={0}";
                    break;
                case SummaryItemType.Max:
                    _GridView.Columns[HeaderColumn].SummaryItem.DisplayFormat = Baslangic_Ornek_Toplam + "={0}";
                    break;
                case SummaryItemType.Count:
                    _GridView.Columns[HeaderColumn].SummaryItem.DisplayFormat = Baslangic_Ornek_Toplam + "={0}";
                    break;
                case SummaryItemType.Average:
                    _GridView.Columns[HeaderColumn].SummaryItem.DisplayFormat = Baslangic_Ornek_Toplam + "={0:0.##}";
                    break;
                default:
                    break;
            }
            _GridView.Columns[HeaderColumn].SummaryItem.SummaryType = SummaryType;
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview View_CustomDrawCell isdenilen sayı column 1000den kucukse  renk koy.</para>
        /// Ornek Kod:  BMS_DLL.DX.DXGRID_KUCUKSERENKDEGIS_SAYI(e, "TOPLAMSATIS", 1000, Color.AliceBlue);
        /// </summary>
        public static void DXGRID_KUCUKSERENKDEGIS_SAYI(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e, string COLUMNNAME, float deger, Color HangiRenkOlsun)
        {
            //View_CustomDrawCell olayına ekle gridviewdki
            if (e.Column.FieldName == COLUMNNAME)
                if (Convert.ToDouble(e.CellValue) < deger)
                {
                    e.Appearance.BackColor = HangiRenkOlsun;
                    e.DefaultDraw();
                    e.Handled = true;
                }
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview View_CustomDrawCell isdenilen sayı column 1000den buyukse  renk koy.</para>
        /// Ornek Kod:  BMS_DLL.DX.DXGRID_BUYUKSERENKDEGIS_SAYI(e, "TOPLAMSATIS", 1000, Color.AliceBlue);
        /// </summary>
        public static void DXGRID_BUYUKSERENKDEGIS_SAYI(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e, string COLUMNNAME, float deger, Color HangiRenkOlsun)
        {
            //View_CustomDrawCell olayına ekle gridviewdki
            if (e.Column.FieldName == COLUMNNAME)
                if (Convert.ToDouble(e.CellValue) > deger)
                {
                    e.Appearance.BackColor = HangiRenkOlsun;
                    e.DefaultDraw();
                    e.Handled = true;
                }
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview View_CustomDrawCell isdenilen sayı column 1000e eşitse  renk koy.</para>
        /// Ornek Kod:  BMS_DLL.DX.DXGRID_ESITSERENKKDEGIS_SAYI(e, "TOPLAMSATIS", 1000, Color.AliceBlue);
        /// </summary>
        public static void DXGRID_ESITSERENKKDEGIS_SAYI(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e, string COLUMNNAME, float deger, Color HangiRenkOlsun)
        {
            //View_CustomDrawCell olayına ekle gridviewdki
            if (e.Column.FieldName == COLUMNNAME)
                if (Convert.ToDouble(e.CellValue) == deger)
                {
                    e.Appearance.BackColor = HangiRenkOlsun;
                    e.DefaultDraw();
                    e.Handled = true;
                }
        }
        /// <summary>
        /// <para>Aciklama: Dx Gridview View_CustomDrawCell isdenilen string column iptal yazarsa  renk koy.</para>
        /// Ornek Kod:  BMS_DLL.DX.DXGRID_ESITSERENKKDEGIS_STRING(e, "TOPLAMSATIS", "iptal", Color.AliceBlue);
        /// </summary>
        public static void DXGRID_ESITSERENKKDEGIS_STRING(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e, string COLUMNNAME, string deger, Color HangiRenkOlsun)
        {
            //View_CustomDrawCell olayına ekle gridviewdki
            if (e.Column.FieldName == COLUMNNAME)
                if (e.CellValue.ToString() == deger)
                {
                    e.Appearance.BackColor = HangiRenkOlsun;
                    e.DefaultDraw();
                    e.Handled = true;
                }
        }
        /// <summary>
        /// <para>Aciklama: Dx RibbonControl Eklenmeli--Kullanılan pc registerinde kayıt oluşturur://Computer\HKEY_CURRENT_USER\Software\SuperErp</para> ve içine Key Tema - Value Tema Adı atar
        /// Ornek Kod: TEMAREGISTRYKAYDET("SuperErp");
        /// </summary>
        public static void TEMAREGISTRYKAYDET(string PROJEADI)
        {
            try
            {
                GLOBAL.REGISTIRYSET("TEMA", UserLookAndFeel.Default.SkinName.ToString(), PROJEADI);
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Dx RibbonControl Eklenmeli--Kullanılan pc registerden kaydedilen temayı alır register://Computer\HKEY_CURRENT_USER\Software\SuperErp</para>
        /// Ornek Kod: TEMAREGISTRYYUKLE("SuperErp");
        /// </summary>
        public static void TEMAREGISTRYYUKLE(string PROJEADI)
        {

            try
            {
                UserLookAndFeel.Default.SkinName = GLOBAL.REGISTIRYGET("TEMA", PROJEADI);
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Dx RibbonControl Eklenmeli--Programın bulunduğu klasorun içine USERS diye bir klasor yaratır. içine username adında txt oluşturur içine temanın adını kaydeder</para>
        /// Ornek Kod: TEMAFOLDERUSERSKAYDET(Username.Text);
        /// </summary>
        public static void TEMAFOLDERUSERSKAYDET(string USERNAME)
        {
            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "USERS\\";
                Directory.CreateDirectory(directory);
                string path = directory + USERNAME + ".txt";
                if (!File.Exists(path)) { }
                File.Create(path).Close();
                File.AppendAllText(path, UserLookAndFeel.Default.SkinName.ToString());
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Dx RibbonControl Eklenmeli--Programın bulunduğu klasorun içine USERS diye bir klasor vardır içine username adında txt  vardır en son kaydettiği temayı ordan yükler</para>
        /// Ornek Kod: TEMAFOLDERUSERSYUKLE(Username.Text);
        /// </summary>
        public static void TEMAFOLDERUSERSYUKLE(string USERNAME)
        {
            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "USERS\\";
                Directory.CreateDirectory(directory);
                string path = directory + USERNAME + ".txt";
                UserLookAndFeel.Default.SkinName = File.ReadAllText(path);
            }
            catch { }
        }
        /// <summary>
        /// <para>Aciklama: Önce ana projeye add devitem Progress Indicator ekle adını PROGRESSFORM yap</para>
        /// Ornek Kod: BMS_DLL.DX.SPLASHSCREENBASLA(typeof(PROGRESSFORM), this, "Oluşturluuyor");
        /// </summary>
        public static void SPLASHSCREENBASLA(Type _PROGRESSFORM, Form _this, string _NEYAPILIYOR)
        {
            try
            {
                SplashScreenManager.ShowForm(_this, _PROGRESSFORM, true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption(_NEYAPILIYOR);
                SplashScreenManager.Default.SetWaitFormDescription("");
            }
            catch { }
        }
        /// <summary>
        /// Ornek Kod: BMS_DLL.DX.SPLASHSCREENBITIR(typeof(PROGRESSFORM), this, "İşlem Tamamlandı");
        /// </summary>
        public static void SPLASHSCREENBITIR(string BITTIMESAJI)
        {
            try
            {
                SplashScreenManager.CloseForm(false);
                MessageBox.Show(BITTIMESAJI, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
        /// <summary>
        /// Ornek Kod: DXGRID_GETFOCUSEDROWVALUE(Gridview1, "LOGICALREF");
        /// </summary>
        public static string DXGRID_GETFOCUSEDROWVALUE(GridView _GridView, string GRIDCOLUMNHEADERFIELD)
        {
            return _GridView.GetFocusedRowCellValue(GRIDCOLUMNHEADERFIELD).ToString();
        }
        /// <summary>
        /// <para>Ornek Kod YesNosuz: DXMESSAGEBOX(false, "Baslik", "Icerik")</para>
        /// Ornek Kod YesNolu: DXMESSAGEBOX(true, "Baslik", "Icerik");
        /// </summary>
        public static bool DXMESSAGEBOX(bool isYesNo, string Baslik, string Icerik)
        {
            if (isYesNo == true)
            {
                if (XtraMessageBox.Show(Icerik, Baslik, MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    return true;
                }

            }
            else XtraMessageBox.Show(Icerik, Baslik, MessageBoxButtons.OK);
            return false;
        }
        /// <summary>
        /// <para>Aciklama: Önce ana projeye add devitem Progress Indicator ekle adını PROGRESSFORM yap</para>
        /// Ornek Kod: DXGRIDEXCELAC(typeof(PROGRESSFORM), this,GridControl1, GridView1,"A1","R2000");
        /// </summary>
        public static void DXGRIDEXCELAC(Type _PROGRESSFORM, Form _this, GridControl _gridcontrol, GridView _gridview, string FirstColumn = "A1", string LastColumn = "R2000")
        {
            // BMS_DLL.DX.SPLASHSCREENBASLA(typeof(PROGRESSFORM), this, "test");

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Excel Dosyası|*.xls;*.xlsx",
                Title = "Transfer Edilecek Excel Dosyasını Seçin"
            };
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SplashScreenManager.ShowForm(_this, _PROGRESSFORM, true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("LÜTFEN BEKLEYİN.");
                SplashScreenManager.Default.SetWaitFormDescription("");

                ExcelDataSource excelDataSource = new ExcelDataSource
                {
                    Name = "Excel Data Source",
                    FileName = openFileDialog1.FileName
                };
                DXGRIDEXCELAC_processExcel(openFileDialog1.FileName);
                ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings(DXGRIDEXCELAC_processExcelSheetName, FirstColumn + ":" + LastColumn);
                excelDataSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
                excelDataSource.Fill();
                _gridcontrol.DataSource = null;
                _gridview.Columns.Clear();
                _gridcontrol.DataSource = excelDataSource;
                _gridview.BestFitColumns();
                SplashScreenManager.CloseForm(false);
            }
        }
        private static string _XTRAREPORTSORGU, _XTRAREPORTDOSYA;
        private static bool _XTRAREPORTisYENIYARAT;
        /// <summary>
        /// <para>Aciklama: programın bulundugu klasorun altınta reports/-isim-.repx olmalı--burda PROJEDE rapor1.repx var</para>
        /// <para>Ornek Kod:</para>
        /// <para>BMS_DLL.CFGGETSET.AYARLARIYUKLE();</para>
        /// <para>BMS_DLL.DX.XTRAREPORT_AC("SELECT * FROM TABLO","rapor1.repx");</para>
        /// <para>CONNECTIONSTRINGIFNOTFROMCFG : "Server=server; Database=dbtest; User Id =sa;Password =sa"</para>
        /// </summary>
        public static void XTRAREPORT_AC(string SORGU, string DOSYA, bool isYENIYARAT, string CONNECTIONSTRINGIFNOTFROMCFG)
        {
            _XTRAREPORTisYENIYARAT = isYENIYARAT;
            _XTRAREPORTSORGU = SORGU;
            _XTRAREPORTDOSYA = DOSYA;
            SqlDataAdapter WCDS = new SqlDataAdapter(SORGU, new SqlConnection(string.Format("Server={0}; Database={1}; User Id ={2};Password ={3}", BMS_DLL.CFGICERIK.LGDBSERVER, BMS_DLL.CFGICERIK.LGDBDATABASE, BMS_DLL.CFGICERIK.LGDBUSERNAME, BMS_DLL.CFGICERIK.LGDBPASSWORD)));
            if (CONNECTIONSTRINGIFNOTFROMCFG != "")
            {
                WCDS = new SqlDataAdapter(SORGU, new SqlConnection(CONNECTIONSTRINGIFNOTFROMCFG));
                XTRAGRIDCONNECTIONSTRINGIFNOTFROMCFG = CONNECTIONSTRINGIFNOTFROMCFG;
            }
            DataTable WCD = new DataTable();
            WCDS.Fill(WCD);
            try
            {
                XtraReport rep = new XtraReport();
                if (isYENIYARAT == false)
                {
                    rep.LoadLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + "\\reports\\" + DOSYA);
                }
                rep.DataSource = WCD;
                XTRAREPORT_InitBands(rep);
                XTRAREPORT_InitStyles(rep);
                ReportPrintTool tool = new ReportPrintTool(rep);
                RibbonControl ribbonControl = (tool.PreviewRibbonForm as PrintPreviewRibbonFormEx).Ribbon as RibbonControl;
                RibbonPageGroup group = new RibbonPageGroup("Options");
                ribbonControl.Pages[0].Groups.Add(group);
                BarButtonItem showDesigner = new BarButtonItem(ribbonControl.Manager, "Show Designer");

                showDesigner.ItemClick += XTRAREPORT_showDesigner_ItemClick1;

                group.ItemLinks.Add(showDesigner);
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception E)
            {
                XtraMessageBox.Show(E.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static List<BMS_KE_KANTAR_FOR_PRINT> KANTARETIKET_FOR_PRINT = new List<BMS_KE_KANTAR_FOR_PRINT>();
        public static void XTRAREPORT_AC_KANTARETIKET_WO_DB(List<BMS_KE_KANTAR_FOR_PRINT> KE, string DOSYA, bool isYENIYARAT)
        {
            KANTARETIKET_FOR_PRINT = new List<BMS_KE_KANTAR_FOR_PRINT>();
            KANTARETIKET_FOR_PRINT = KE;
            _XTRAREPORTisYENIYARAT = isYENIYARAT;
            _XTRAREPORTDOSYA = DOSYA;
            try
            {
                XtraReport rep = new XtraReport();
                if (isYENIYARAT == false)
                {
                    rep.LoadLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + "\\reports\\" + DOSYA);
                }
                rep.DataSource = KE;
                XTRAREPORT_InitBands(rep);
                XTRAREPORT_InitStyles(rep);
                ReportPrintTool tool = new ReportPrintTool(rep);
                RibbonControl ribbonControl = (tool.PreviewRibbonForm as PrintPreviewRibbonFormEx).Ribbon as RibbonControl;
                RibbonPageGroup group = new RibbonPageGroup("Options");
                ribbonControl.Pages[0].Groups.Add(group);
                BarButtonItem showDesigner = new BarButtonItem(ribbonControl.Manager, "Show Designer");

                showDesigner.ItemClick += XTRAREPORT_KANTARETIKET_WO_DB_showDesigner_ItemClick1;

                group.ItemLinks.Add(showDesigner);
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception E)
            {
                XtraMessageBox.Show(E.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void XTRAREPORT_KANTARETIKET_WO_DB_showDesigner_ItemClick1(object sender, ItemClickEventArgs e)
        {
            try
            {
                XtraReport rep = new XtraReport();
                if (_XTRAREPORTisYENIYARAT == false)
                {
                    rep.LoadLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + "\\reports\\" + _XTRAREPORTDOSYA);
                }


                rep.DataSource = KANTARETIKET_FOR_PRINT;
                XTRAREPORT_InitBands(rep);
                XTRAREPORT_InitStyles(rep);
                ReportDesignTool tool = new ReportDesignTool(rep);
                tool.ShowRibbonDesignerDialog();
            }
            catch (Exception E)
            {
                XtraMessageBox.Show(E.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void XTRAREPORT_showDesigner_ItemClick1(object sender, ItemClickEventArgs e)
        {
            SqlDataAdapter WCDS = new SqlDataAdapter(_XTRAREPORTSORGU, new SqlConnection(string.Format("Server={0}; Database={1}; User Id ={2};Password ={3}", BMS_DLL.CFGICERIK.LGDBSERVER, BMS_DLL.CFGICERIK.LGDBDATABASE, BMS_DLL.CFGICERIK.LGDBUSERNAME, BMS_DLL.CFGICERIK.LGDBPASSWORD)));

            if (XTRAGRIDCONNECTIONSTRINGIFNOTFROMCFG != "")
            {
                WCDS = new SqlDataAdapter(_XTRAREPORTSORGU, new SqlConnection(XTRAGRIDCONNECTIONSTRINGIFNOTFROMCFG));
            }


            DataTable WCD = new DataTable();
            WCDS.Fill(WCD);
            try
            {
                XtraReport rep = new XtraReport();
                if (_XTRAREPORTisYENIYARAT == false)
                {
                    rep.LoadLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + "\\reports\\" + _XTRAREPORTDOSYA);
                }


                rep.DataSource = WCD;
                XTRAREPORT_InitBands(rep);
                XTRAREPORT_InitStyles(rep);
                ReportDesignTool tool = new ReportDesignTool(rep);
                tool.ShowRibbonDesignerDialog();
            }
            catch (Exception E)
            {
                XtraMessageBox.Show(E.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void XTRAREPORT_InitBands(XtraReport rep)
        {
            // Create bands
            DetailBand detail = new DetailBand();
            PageHeaderBand pageHeader = new PageHeaderBand();
            ReportFooterBand reportFooter = new ReportFooterBand();
            detail.Height = 20;
            reportFooter.Height = 380;
            pageHeader.Height = 20;

            // Place the bands onto a report
            rep.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] { detail, pageHeader, reportFooter });
        }
        private static void XTRAREPORT_InitStyles(XtraReport rep)
        {
            // Create different odd and even styles
            XRControlStyle oddStyle = new XRControlStyle();
            XRControlStyle evenStyle = new XRControlStyle();

            // Specify the odd style appearance
            oddStyle.BackColor = Color.LightBlue;
            oddStyle.StyleUsing.UseBackColor = true;
            oddStyle.StyleUsing.UseBorders = false;
            oddStyle.Name = "OddStyle";

            // Specify the even style appearance
            evenStyle.BackColor = Color.LightPink;
            evenStyle.StyleUsing.UseBackColor = true;
            evenStyle.StyleUsing.UseBorders = false;
            evenStyle.Name = "EvenStyle";

            // Add styles to report's style sheet
            rep.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] { oddStyle, evenStyle });
        }
        private static string DXGRIDEXCELAC_processExcelSheetName;
        private static void DXGRIDEXCELAC_releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private static void DXGRIDEXCELAC_processExcel(string filename)
        {
            //gridControl1.DataSource = null;
            //gridView1.Columns.Clear();
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            var missing = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(filename, false, true, missing, missing, missing, true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, '\t', false, false, 0, false, true, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            DXGRIDEXCELAC_processExcelSheetName = xlWorkSheet.Name;

            xlWorkBook.Close(true, missing, missing);
            xlApp.Quit();

            DXGRIDEXCELAC_releaseObject(xlWorkSheet);
            DXGRIDEXCELAC_releaseObject(xlWorkBook);
            DXGRIDEXCELAC_releaseObject(xlApp);
        }
    }
    public class WINDOWSSERVICE
    {
        /// <summary>
        /// <para>Aciklama: Önce ilk başa private Timer timer; sonra Servisin OnStarına Koy.</para>
        /// <para>Ornek Kod: BMS_DLL.WINDOWSSERVICE._OnStart(false,START_PROCESS,timer );</para>
        /// <para>base.OnStart(args);</para> 
        /// </summary>
        public static void _OnStart(bool isDebug, TimerCallback _START_PROCESS, System.Threading.Timer _Timer)
        {

            if (isDebug == true)
            {
                System.Diagnostics.Debugger.Launch();
            }
            try
            {
                try
                {
                    BMS_DLL.CFGGETSET.AYARLARIYUKLE();
                }
                catch (Exception E)
                {
                    BMS_DLL.GLOBAL.LOGYAZ("GET_CONFIG", E);
                }
                int FACTOR = 1000;
                try
                {
                    if (BMS_DLL.CFGICERIK.SERVICEPERIODTYPE == 1)
                        FACTOR = FACTOR * 60;
                    else if (BMS_DLL.CFGICERIK.SERVICEPERIODTYPE == 2)
                        FACTOR = FACTOR * 60 * 60;
                }
                catch { }
                _Timer = new System.Threading.Timer(new TimerCallback(_START_PROCESS), null, 10000, BMS_DLL.CFGICERIK.SERVICEPERIOD * FACTOR);
            }
            catch
            {
                _Timer = new System.Threading.Timer(new TimerCallback(_START_PROCESS), null, 10000, 60000 * 60);//60 MINUTES DEFAULT
            }
        }
        public static SqlDatabase sqlSERVICEDB;
        /// <summary>
        /// <para>Aciklama: Önce ilk başa yoksa private Timer timer; sonra Servisin OnStopa Koy.</para>
        /// <para>Ornek Kod: BMS_DLL.WINDOWSSERVICE._OnStop(timer);</para>
        /// </summary>
        public static void _OnStop(System.Threading.Timer _Timer)
        {
            try
            {
                sqlSERVICEDB.ExecuteNonQuery(new SqlCommand(string.Format("UPDATE BM_{0}_DKS_LOGO_SERVICE SET SYNC = '0'", BMS_DLL.CFGICERIK.FIRMNR)));
            }
            catch (Exception Ex) { BMS_DLL.GLOBAL.LOGYAZ("BM_SERVICE STATUS UPDATE ERROR - ONSTOP", Ex); }
            _Timer.Dispose();
        }
    }
    public class ASPX
    {
        public static void SET_WEBCONFIG_CONENCTIONSTRING(string ConnectionStringname, string server, string database, string userid, string password)
        {
            string str = "server=" + server + ";database=" + database + "; User ID=" + userid + "; Password=" + password + "";
            System.Configuration.Configuration Config1 = WebConfigurationManager.OpenWebConfiguration("~");
            ConnectionStringsSection conSetting = (ConnectionStringsSection)Config1.GetSection("connectionStrings");
            ConnectionStringSettings StringSettings = new ConnectionStringSettings(ConnectionStringname, "Data Source=" + server + ";Database=" + database + ";User ID=" + userid + ";Password=" + password + "; ");
            StringSettings.ProviderName = "System.Data.SqlClient";
            conSetting.ConnectionStrings.Remove(StringSettings);
            conSetting.ConnectionStrings.Add(StringSettings);
            Config1.Save(ConfigurationSaveMode.Modified);
        }
        public static void GET_WEBCONFIG_CONENCTIONSTRING(string ConnectionStringname, out string server, out string database, out string userid, out string password)
        {
            string mainconn = ConfigurationManager.ConnectionStrings[ConnectionStringname].ConnectionString;
            server = BMS_DLL.GLOBAL.BETWEEN(mainconn, "Data Source=", ";Database=");
            database = BMS_DLL.GLOBAL.BETWEEN(mainconn, ";Database=", ";User ID=");
            userid = BMS_DLL.GLOBAL.BETWEEN(mainconn, ";User ID=", ";Password=");
            password = BMS_DLL.GLOBAL.BETWEEN(mainconn, ";Password=", "; ");
        }
        /// <summary>
        /// <para>Aciklama:veritabanında gerekli tablo , view , fonks vb. oluşturur.</para>
        /// <para>Ornek Kod :</para>
        /// <para>string[] LG_TABLES =  {</para>
        /// <para> "create table test",</para>
        ///<para>  "create table test2"</para>
        /// <para>   };</para>
        /// <para>   BMS_DLL.SQL.TABLOLARIOLUSTUR(LG_TABLES,connstring);</para>
        /// </summary>
        public static void TABLOLARIOLUSTUR(string[] LG_TABLES, string connectionstring)
        {

            //string[] LG_TABLES = new string[] {"create table test",
            //"create table test2"};
            //yada
            //string[] LG_TABLES =  {
            //  "create table test",
            //  "create table test2"
            //                      };

            SqlDatabase sqlLGDB;
            sqlLGDB = new SqlDatabase(connectionstring);

            foreach (string S in LG_TABLES)
            {
                try { sqlLGDB.ExecuteNonQuery(new SqlCommand(S)); }
                catch { }
            }
        }
    }
    public class GUNCELLEMEMODULU
    {
        /// <summary>
        /// <para>Aciklama: UYGULAMA GÜNCELLEME MODULU</para>
        /// Ornek Kod: GUNCELLEMEYAP(This,typeof(PROGRESSFORM), "ftp://bms@ftp.bilmarkltd.com/SATISMATIK/","BM_SATISMATIK.zip", "bms", string "_BM/2017/*-s_.,", "SATISMATIK");
        /// </summary>
        public static void GUNCELLEMEYAP(Form _This, Type _PROGRESSFORM, string FTPADDRESS, string ZIPDOSYAADI, string FTPUSERNAME, string FTPPASSWORD, string UYGULAMAPROCCESADI)
        {
            try
            {
                GLOBAL.LOGYAZ("GÜNCELLEME BAŞLADI", null);
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPADDRESS + ZIPDOSYAADI);
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(FTPUSERNAME, FTPPASSWORD);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                long size = response.ContentLength;
                GLOBAL.LOGYAZ("DOSYA BOYUTU : " + size, null);
                response.Close();

                request = null;
                request = (FtpWebRequest)FtpWebRequest.Create(FTPADDRESS + ZIPDOSYAADI);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(FTPUSERNAME, FTPPASSWORD);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;


                response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                SplashScreenManager.ShowForm(_This, _PROGRESSFORM, true, true, false);

                using (FileStream writer = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\" + ZIPDOSYAADI, FileMode.Create))
                {

                    long length = response.ContentLength;
                    int bufferSize = 2048;
                    int readCount;
                    byte[] buffer = new byte[2048];

                    readCount = responseStream.Read(buffer, 0, bufferSize);
                    long totalsize = 0;
                    GLOBAL.LOGYAZ("DOSYA İNDİRİLİYOR.", null);

                    while (readCount > 0)
                    {
                        writer.Write(buffer, 0, readCount);
                        readCount = responseStream.Read(buffer, 0, bufferSize);
                        totalsize += readCount;
                        SplashScreenManager.Default.SetWaitFormDescription("DOSYA İNDİRİLİYOR... " + Math.Round((100 * totalsize * 1.0 / size), 2, MidpointRounding.AwayFromZero));
                    }
                }
                GLOBAL.LOGYAZ("İNDİRME TAMAMLANDI.", null);
                reader.Close();
                response.Close();

                SplashScreenManager.Default.SetWaitFormDescription("GÜNCELLENİYOR");

                foreach (Process p in System.Diagnostics.Process.GetProcessesByName(UYGULAMAPROCCESADI))
                {
                    try
                    {
                        p.Kill();
                        p.WaitForExit();
                    }
                    catch (Exception E)
                    {
                        GLOBAL.LOGYAZ("p.Kill() p.WaitForExit() ", E);
                    }
                }



                string zipPath = AppDomain.CurrentDomain.BaseDirectory + ZIPDOSYAADI;
                string extractPath = AppDomain.CurrentDomain.BaseDirectory + "tmp";


                Directory.CreateDirectory(extractPath);
                //System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                string[] files = System.IO.Directory.GetFiles(extractPath);

                GLOBAL.LOGYAZ("ZİP DOSYASI ÇIKARTILIYOR.", null);

                GLOBAL.LOGYAZ("DOSYA SAYISI : " + files.Length, null);
                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    string fileName = System.IO.Path.GetFileName(s);
                    GLOBAL.LOGYAZ("ÇIKARTILAN DOSYA : " + s, null);
                    string destFile = System.IO.Path.Combine(extractPath.Replace("\\tmp", ""), fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
                GLOBAL.LOGYAZ("ZİP DOSYASI ÇIKARTMA İŞLEMİ TAMAMLANDI.", null);
                GLOBAL.LOGYAZ("GEÇİCİ KLASÖR TEMİZLENİYOR.", null);

                foreach (string s in files)
                {
                    GLOBAL.LOGYAZ("SİLİNEN DOSYA : " + s, null);
                    File.Delete(s);
                }
                GLOBAL.LOGYAZ("ZİP DOSYASI SİLİNİYOR.", null);
                File.Delete(zipPath);
                GLOBAL.LOGYAZ("GEÇİCİ KLASÖR SİLİNİYOR.", null);
                Directory.Delete(extractPath, true);

                SplashScreenManager.Default.SetWaitFormDescription("TABLOLAR GÜNCELLENİYOR");

                SplashScreenManager.CloseForm(false);
                /*Process firstProc = new Process();
                firstProc.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "SATISMATIK.exe";
                firstProc.EnableRaisingEvents = true;
                firstProc.Start();*/
                MessageBox.Show("UYGULAMA GÜNCELLENDİ.");
                GLOBAL.LOGYAZ("GÜNCELLEME TAMAMLANDI.", null);
                Application.Exit();
                Environment.Exit(1);
            }
            catch (Exception E)
            {
                SplashScreenManager.CloseForm(false);
                MessageBox.Show("HATA OLUŞTU." + E.Message);
                GLOBAL.LOGYAZ("UPDATER - GET_UPDATE_FILE", E);
                string zipPath = AppDomain.CurrentDomain.BaseDirectory + ZIPDOSYAADI;
                string extractPath = AppDomain.CurrentDomain.BaseDirectory + "tmp";
                try
                {
                    string[] files = System.IO.Directory.GetFiles(extractPath);
                    foreach (string s in files)
                        File.Delete(s);
                }
                catch { }
                try { File.Delete(zipPath); } catch { }
                try { Directory.Delete(extractPath); } catch { }
                Application.Exit();
                Environment.Exit(1);
            }
        }
        /// <summary>
        /// <para>Aciklama: VERSION KONTROLU</para>
        /// <para>Programın Versionunu öğrenmek için :string mevcutverion=  Assembly.GetExecutingAssembly().GetName().Version.ToString()</para>
        /// Ornek Kod:string version = VERSIYONBILGISIAL("ftp://bms@ftp.bilmarkltd.com/SATISMATIK/","version_satismatik.txt", "bms",  "_BM/2017/*-s_.,");
        /// </summary>
        public static string VERSIYONBILGISIAL(string FTPADDRESS, string VERSIONTXTDOSYAADI, string FTPUSERNAME, string FTPPASSWORD)
        {

            WebClient request = new WebClient();



            string url = FTPADDRESS + VERSIONTXTDOSYAADI;
            request.Credentials = new NetworkCredential(FTPUSERNAME, FTPPASSWORD);
            try
            {
                byte[] newFileData = request.DownloadData(url);

                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                return fileString;
            }
            //catch (WebException ex)
            catch (Exception ex)
            {
                GLOBAL.LOGYAZ("HATA-", ex);
                return "HATA-" + ex.Message;
            }
        }
    }
}
