//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml;

//namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU
//{
//    public class CONFIG
//    {
//        public static string LGDBSERVER { get; set; } = string.Empty;
//        public static string LGDBDATABASE { get; set; } = string.Empty;
//        public static string RESTURL { get; set; } = string.Empty;
//        public static string LGDBUSERNAME { get; set; } = string.Empty;
//        public static string LGDBPASSWORD { get; set; } = string.Empty;
//        public static int BMSDBSERVERTYPE { get; set; }
//        public static string BMSDBSERVER { get; set; } = string.Empty;
//        public static string BMSDBDATABASE { get; set; } = string.Empty;
//        public static string BMSDBUSERNAME { get; set; } = string.Empty;
//        public static string BMSDBPASSWORD { get; set; } = string.Empty;
//        public static string FIRMNR { get; set; } = string.Empty;
//        public static string PERIOD { get; set; } = string.Empty;
//        public static string PREVIOUSFIRMNR { get; set; } = string.Empty;
//        public static string PREVIOUSPERIOD { get; set; } = string.Empty;
//        public static string BMSDEFAULTUSERNAME { get; set; } = string.Empty;
//        public static string BMSDEFAULTPASSWORD { get; set; } = string.Empty;
//        public static string LOBJECTDEFAULTUSERNAME { get; set; } = string.Empty;
//        public static string LOBJECTDEFAULTPASSWORD { get; set; } = string.Empty;
//        public static int SERVICEPERIOD { get; set; }
//        public static int SERVICEPERIODTYPE { get; set; }
//        public static int SERVICETABLESDBCHOICE { get; set; }
//    }
//    public class Global
//    {
//        public static void _FormAc(bool isMDIForm, Form parentForm, Form mainform, bool isFormBasligi, string FormBasligi)
//        {
//            if (isFormBasligi == true)
//            {
//                parentForm.Text = FormBasligi;
//            }
//            if (isMDIForm == true)
//            {
//                parentForm.MdiParent = mainform;
//            }
//            parentForm.Show();
//        }
//    }
//    public class CFGAYARLARI
//    {
//        public static string _xmlPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.xml";
//        public static string _datPath = AppDomain.CurrentDomain.BaseDirectory + "BMDB.cfg";
//        public static string _key = "0WXOM7IKTM012016";
//        public static void AYARLARIYUKLE()
//        {

//            try
//            {
//                using (RijndaelManaged aes = new RijndaelManaged())
//                {
//                    byte[] key = ASCIIEncoding.UTF8.GetBytes(_key);

//                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(_key);

//                    using (FileStream fsCrypt = new FileStream(_datPath, FileMode.Open))
//                    {
//                        using (FileStream fsOut = new FileStream(_xmlPath, FileMode.Create))
//                        {
//                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
//                            {
//                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
//                                {
//                                    int data;
//                                    while ((data = cs.ReadByte()) != -1)
//                                    {
//                                        fsOut.WriteByte((byte)data);
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//                CONFIG CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU = new CONFIG();
//                XmlDocument xDoc = new XmlDocument();
//                xDoc.Load(_xmlPath);
//                if (File.Exists(_xmlPath))
//                    File.Delete(_xmlPath);
//                XmlNodeList xNode = xDoc.GetElementsByTagName("BILMARKSOFTWARE");
//                XmlNode xNodeLGDB = xNode[0].ChildNodes[0];
//                XmlNode xNodeBMDB = xNode[0].ChildNodes[1];
//                XmlNode xNodeCAPIFIRM = xNode[0].ChildNodes[2];
//                XmlNode xNodeUSERDEFAULTS = xNode[0].ChildNodes[3];
//                XmlNode xNodeWINDOWSSERVICE = xNode[0].ChildNodes[4];

//                try { CONFIG.LGDBUSERNAME = xNodeLGDB.ChildNodes[0].InnerText; } catch { }
//                try { CONFIG.LGDBPASSWORD = xNodeLGDB.ChildNodes[1].InnerText; } catch { }
//                try { CONFIG.LGDBSERVER = xNodeLGDB.ChildNodes[2].InnerText; } catch { }
//                try { CONFIG.LGDBDATABASE = xNodeLGDB.ChildNodes[3].InnerText; } catch { }
//                try { CONFIG.RESTURL = xNodeLGDB.ChildNodes[4].InnerText; } catch { }
//                try { CONFIG.BMSDBSERVERTYPE = int.Parse(xNodeBMDB.ChildNodes[0].InnerText); } catch { }
//                try { CONFIG.BMSDBUSERNAME = xNodeBMDB.ChildNodes[1].InnerText; } catch { }
//                try { CONFIG.BMSDBPASSWORD = xNodeBMDB.ChildNodes[2].InnerText; } catch { }
//                try { CONFIG.BMSDBSERVER = xNodeBMDB.ChildNodes[3].InnerText; } catch { }
//                try { CONFIG.BMSDBDATABASE = xNodeBMDB.ChildNodes[4].InnerText; } catch { }
//                try { CONFIG.FIRMNR = xNodeCAPIFIRM.ChildNodes[0].InnerText; } catch { }
//                try { CONFIG.PERIOD = xNodeCAPIFIRM.ChildNodes[1].InnerText; } catch { }
//                try { CONFIG.PREVIOUSFIRMNR = xNodeCAPIFIRM.ChildNodes[2].InnerText; } catch { }
//                try { CONFIG.PREVIOUSPERIOD = xNodeCAPIFIRM.ChildNodes[3].InnerText; } catch { }
//                try { CONFIG.BMSDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[0].InnerText; } catch { }
//                try { CONFIG.BMSDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[1].InnerText; } catch { }
//                try { CONFIG.LOBJECTDEFAULTUSERNAME = xNodeUSERDEFAULTS.ChildNodes[2].InnerText; } catch { }
//                try { CONFIG.LOBJECTDEFAULTPASSWORD = xNodeUSERDEFAULTS.ChildNodes[3].InnerText; } catch { }
//                try { CONFIG.SERVICEPERIOD = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[0].InnerText); } catch { }
//                try { CONFIG.SERVICEPERIODTYPE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[1].InnerText); } catch { }
//                try { CONFIG.SERVICETABLESDBCHOICE = int.Parse(xNodeWINDOWSSERVICE.ChildNodes[2].InnerText); } catch { }
//            }
//            catch (Exception ex)
//            {

//            }

//}
//        public static void AYARLARIKAYDET(string LS_KULLANICIADI, string LS_PAROLA,string LS_SUNUCU, string LS_VERITABANI,string LS_RESTAPIURL, int BS_VERITABANITIPI, string BS_KULLANICIADI, string BS_PAROLA, string BS_SUNUCU, string BS_VERITABANI, string FB_FIRMANO, string FB_PERIOD, string FB_ONCEKIFIRMANO, string FB_ONCEKIPERIOD, string BMS_KULLANICIKODU, string BMS_PAROLA, string LO_KULLANICIKODU, string LO_PAROLA, string WS_SERVISSURE, int WS_SURECINSI, int WS_SERVISVERITABANIKONTROLTABLOSU)
//        {
//            File.WriteAllText(_xmlPath, string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
//    "<BILMARKSOFTWARE>" +
//        "<LGDB>" + //NODE 0
//            "<USERNAME>" + LS_KULLANICIADI + "</USERNAME>" +
//            "<PASSWORD>" + LS_PAROLA + "</PASSWORD>" +
//            "<SERVER>" + LS_SUNUCU + "</SERVER>" +
//            "<DATABASE>" + LS_VERITABANI + "</DATABASE>" +
//            "<RESTURL>" + LS_RESTAPIURL + "</RESTURL>" +
//        "</LGDB>" +
//        "<BMSDB>" + //NODE 1
//            "<SERVERTYPE>" + (BS_VERITABANITIPI + "</SERVERTYPE>" +
//            "<USERNAME>" + BS_KULLANICIADI + "</USERNAME>" +
//            "<PASSWORD>" + BS_PAROLA + "</PASSWORD>" +
//            "<SERVER>" + BS_SUNUCU + "</SERVER>" +
//            "<DATABASE>" + BS_VERITABANI + "</DATABASE>" +
//        "</BMSDB>" +
//        "<CAPIFIRM>" + //NODE 2
//            "<FIRMNR>" + FB_FIRMANO + "</FIRMNR>" +
//            "<PERIOD>" + FB_PERIOD + "</PERIOD>" +
//            "<PREVFIRMNR>" + FB_ONCEKIFIRMANO + "</PREVFIRMNR>" +
//            "<PREVPERIOD>" + FB_ONCEKIPERIOD + "</PREVPERIOD>" +
//        "</CAPIFIRM>" +
//        "<DEFAULTUSERS>" + //NODE 3 
//            "<BMSUSERNAME>" + BMS_KULLANICIKODU + "</BMSUSERNAME>" +
//            "<BMSPASSWORD>" + BMS_PAROLA + "</BMSPASSWORD>" +
//            "<LOBJECTUSERNAME>" + LO_KULLANICIKODU + "</LOBJECTUSERNAME>" +
//            "<LOBJECTPASSWORD>" + LO_PAROLA + "</LOBJECTPASSWORD>" +
//        "</DEFAULTUSERS>" +
//        "<WINDOWSSERVICE>" + //NODE 4
//            "<SERVICE_PERIOD>" + WS_SERVISSURE + "</SERVICE_PERIOD>" +
//            "<SERVICE_PERIODTYPE>" + WS_SURECINSI + "</SERVICE_PERIODTYPE>" +
//            "<SERVICE_TABLEDBCHOICE>" + WS_SERVISVERITABANIKONTROLTABLOSU + "</SERVICE_TABLEDBCHOICE>" +
//        "</WINDOWSSERVICE>" +
//    "</BILMARKSOFTWARE>")));

//            if (EncryptFile(_xmlPath, _datPath, _key))
//            {
//                try
//                {
//                    DecryptFile(_datPath, _xmlPath, _key);
//                    if (File.Exists(_xmlPath))
//                        File.Delete(_xmlPath);
//                    MessageBox.Show("Ayarlar Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//                catch { }
//            }

//        } 

//        public static bool EncryptFile(string inputFile, string outputFile, string skey)
//        {
//            try
//            {
//                using (RijndaelManaged aes = new RijndaelManaged())
//                {
//                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

//                    /* This is for demostrating purposes only. 
//                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each
//                     encryption in other to achieve maximum security*/
//                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

//                    using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
//                    {
//                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
//                        {
//                            using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
//                            {
//                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
//                                {
//                                    int data;
//                                    while ((data = fsIn.ReadByte()) != -1)
//                                    {
//                                        cs.WriteByte((byte)data);
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            catch
//            {
//                return false;
//            }
//            //if (File.Exists(_xmlPath))
//            //    File.Delete(_xmlPath);
//            return true;
//        }

//        public static void DecryptFile(string inputFile, string outputFile, string skey)
//        {
//            try
//            {
//                using (RijndaelManaged aes = new RijndaelManaged())
//                {
//                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

//                    /* This is for demostrating purposes only. 
//                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
//                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

//                    using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
//                    {
//                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
//                        {
//                            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
//                            {
//                                using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
//                                {
//                                    int data;
//                                    while ((data = cs.ReadByte()) != -1)
//                                    {
//                                        fsOut.WriteByte((byte)data);
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            catch
//            {

//            }
//        }

//    }
//}
