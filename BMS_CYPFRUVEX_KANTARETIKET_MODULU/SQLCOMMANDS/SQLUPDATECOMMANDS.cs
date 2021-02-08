using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.SQLCOMMANDS
{
 public class SQLUPDATECOMMANDS 
{

public SqlCommand BMS_KE_KANTAR_UPDATE(BMS_KE_KANTAR B, bool UPDATEBM, bool UPDATELOGICALREF, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BMS_KE_KANTAR";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") ; 
 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " TARIH = @TARIH, PLAKAID = @PLAKAID, KONTRAKTORID = @KONTRAKTORID, URETICIID = @URETICIID, URUNID = @URUNID, MIKTAR = @MIKTAR, BIRIM = @BIRIM, KULLANICI = @KULLANICI, BARKODYAZIMMIKTAR = @BARKODYAZIMMIKTAR, ACIKLAMA = @ACIKLAMA, LOGOAKTARIMI = @LOGOAKTARIMI, LOGOAKTARIMTARIHI = @LOGOAKTARIMTARIHI, LOGOFISID = @LOGOFISID, ERRORMESSAGE = @ERRORMESSAGE, TSTATUS = @TSTATUS WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
if (B.TARIH != new DateTime()) 
      com.Parameters.AddWithValue("@TARIH", B.TARIH);
else 
       com.Parameters.AddWithValue("@TARIH", DBNull.Value);
 try { com.Parameters.AddWithValue("@PLAKAID", B.PLAKAID); } catch {  com.Parameters.AddWithValue("@PLAKAID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@KONTRAKTORID", B.KONTRAKTORID); } catch {  com.Parameters.AddWithValue("@KONTRAKTORID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@URETICIID", B.URETICIID); } catch {  com.Parameters.AddWithValue("@URETICIID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@URUNID", B.URUNID); } catch {  com.Parameters.AddWithValue("@URUNID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MIKTAR", B.MIKTAR); } catch {  com.Parameters.AddWithValue("@MIKTAR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BIRIM", B.BIRIM); } catch {  com.Parameters.AddWithValue("@BIRIM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@KULLANICI", B.KULLANICI); } catch {  com.Parameters.AddWithValue("@KULLANICI",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BARKODYAZIMMIKTAR", B.BARKODYAZIMMIKTAR); } catch {  com.Parameters.AddWithValue("@BARKODYAZIMMIKTAR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACIKLAMA", B.ACIKLAMA); } catch {  com.Parameters.AddWithValue("@ACIKLAMA",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LOGOAKTARIMI", B.LOGOAKTARIMI); } catch {  com.Parameters.AddWithValue("@LOGOAKTARIMI",  DBNull.Value); }
if (B.LOGOAKTARIMTARIHI != new DateTime()) 
      com.Parameters.AddWithValue("@LOGOAKTARIMTARIHI", B.LOGOAKTARIMTARIHI);
else 
       com.Parameters.AddWithValue("@LOGOAKTARIMTARIHI", DBNull.Value);
 try { com.Parameters.AddWithValue("@LOGOFISID", B.LOGOFISID); } catch {  com.Parameters.AddWithValue("@LOGOFISID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ERRORMESSAGE", B.ERRORMESSAGE); } catch {  com.Parameters.AddWithValue("@ERRORMESSAGE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TSTATUS", B.TSTATUS); } catch {  com.Parameters.AddWithValue("@TSTATUS",  DBNull.Value); }
      com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

      return com;
   }
   catch
   {
      return null;
   }
}

public SqlCommand BM_XXX_XX_CLFLINE_UPDATE(BM_XXX_XX_CLFLINE B, bool UPDATEBM, bool UPDATELOGICALREF ,string FIRMNR ,string PERIODNR, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BM_XXX_XX_CLFLINE";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") .Replace("XXX", FIRMNR) 
.Replace("XX", PERIODNR); 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " CLIENTREF = @CLIENTREF, CLACCREF = @CLACCREF, CLCENTERREF = @CLCENTERREF, CASHCENTERREF = @CASHCENTERREF, CASHACCOUNTREF = @CASHACCOUNTREF, VIRMANREF = @VIRMANREF, SOURCEFREF = @SOURCEFREF, DATE_ = @DATE_, DEPARTMENT = @DEPARTMENT, BRANCH = @BRANCH, MODULENR = @MODULENR, TRCODE = @TRCODE, LINENR = @LINENR, SPECODE = @SPECODE, CYPHCODE = @CYPHCODE, TRANNO = @TRANNO, DOCODE = @DOCODE, LINEEXP = @LINEEXP, ACCOUNTED = @ACCOUNTED, SIGN = @SIGN, AMOUNT = @AMOUNT, TRCURR = @TRCURR, TRRATE = @TRRATE, TRNET = @TRNET, REPORTRATE = @REPORTRATE, REPORTNET = @REPORTNET, EXTENREF = @EXTENREF, PAYDEFREF = @PAYDEFREF, ACCFICHEREF = @ACCFICHEREF, PRINTCNT = @PRINTCNT, CAPIBLOCK_CREATEDBY = @CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE = @CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR = @CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN = @CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC = @CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY = @CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE = @CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR = @CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN = @CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC = @CAPIBLOCK_MODIFIEDSEC, CANCELLED = @CANCELLED, TRGFLAG = @TRGFLAG, TRADINGGRP = @TRADINGGRP, LINEEXCTYP = @LINEEXCTYP, ONLYONEPAYLINE = @ONLYONEPAYLINE, DISCFLAG = @DISCFLAG, DISCRATE = @DISCRATE, VATRATE = @VATRATE, CASHAMOUNT = @CASHAMOUNT, DISCACCREF = @DISCACCREF, DISCCENREF = @DISCCENREF, VATRACCREF = @VATRACCREF, VATRCENREF = @VATRCENREF, PAYMENTREF = @PAYMENTREF, VATAMOUNT = @VATAMOUNT, SITEID = @SITEID, RECSTATUS = @RECSTATUS, ORGLOGICREF = @ORGLOGICREF, INFIDX = @INFIDX, POSCOMMACCREF = @POSCOMMACCREF, POSCOMMCENREF = @POSCOMMCENREF, POINTCOMMACCREF = @POINTCOMMACCREF, POINTCOMMCENREF = @POINTCOMMCENREF, CHEQINFO = @CHEQINFO, CREDITCNO = @CREDITCNO, CLPRJREF = @CLPRJREF, STATUS = @STATUS, EXIMFILEREF = @EXIMFILEREF, EXIMPROCNR = @EXIMPROCNR, MONTH_ = @MONTH_, YEAR_ = @YEAR_, FUNDSHARERAT = @FUNDSHARERAT, AFFECTCOLLATRL = @AFFECTCOLLATRL, GRPFIRMTRANS = @GRPFIRMTRANS, REFLVATACCREF = @REFLVATACCREF, REFLVATOTHACCREF = @REFLVATOTHACCREF, AFFECTRISK = @AFFECTRISK, BATCHNR = @BATCHNR, APPROVENR = @APPROVENR, BATCHNUM = @BATCHNUM, APPROVENUM = @APPROVENUM, EUVATSTATUS = @EUVATSTATUS, ORGLOGOID = @ORGLOGOID, EXIMTYPE = @EXIMTYPE, EIDISTFLNNR = @EIDISTFLNNR, EISRVDSTTYP = @EISRVDSTTYP, EXIMDISTTYP = @EXIMDISTTYP, SALESMANREF = @SALESMANREF, BANKACCREF = @BANKACCREF, BNACCREF = @BNACCREF, BNCENTERREF = @BNCENTERREF, DEVIRPROCDATE = @DEVIRPROCDATE, DOCDATE = @DOCDATE, INSTALREF = @INSTALREF, DEVIR = @DEVIR, DEVIRMODULENR = @DEVIRMODULENR, FTIME = @FTIME, OFFERREF = @OFFERREF, RETCCFCREF = @RETCCFCREF, EMFLINEREF = @EMFLINEREF, FROMEXCHDIFF = @FROMEXCHDIFF, CANDEDUCT = @CANDEDUCT, DEDUCTIONPART1 = @DEDUCTIONPART1, DEDUCTIONPART2 = @DEDUCTIONPART2, UNDERDEDUCTLIMIT = @UNDERDEDUCTLIMIT, VATDEDUCTRATE = @VATDEDUCTRATE, VATDEDUCTACCREF = @VATDEDUCTACCREF, VATDEDUCTOTHACCREF = @VATDEDUCTOTHACCREF, VATDEDUCTCENREF = @VATDEDUCTCENREF, VATDEDUCTOTHCENREF = @VATDEDUCTOTHCENREF, CANTCREDEDUCT = @CANTCREDEDUCT, GUID = @GUID, PAIDINCASH = @PAIDINCASH, BRUTAMOUNT = @BRUTAMOUNT, NETAMOUNT = @NETAMOUNT, BRUTAMOUNTTR = @BRUTAMOUNTTR, NETAMOUNTTR = @NETAMOUNTTR, BRUTAMOUNTREP = @BRUTAMOUNTREP, NETAMOUNTREP = @NETAMOUNTREP, BNLNTRCURR = @BNLNTRCURR, BNLNTRRATE = @BNLNTRRATE, BNLNTRNET = @BNLNTRNET, PRINTDATE = @PRINTDATE, INCDEDUCTAMNT = @INCDEDUCTAMNT, AFFECTCOST = @AFFECTCOST, FOREXIM = @FOREXIM, EXIMFILECODECLF = @EXIMFILECODECLF, SPECODE2 = @SPECODE2, SERVREASONDEF = @SERVREASONDEF WHERE " + WHERECLAUSE + " = " + WHEREVALUE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLIENTREF", B.CLIENTREF); } catch {  com.Parameters.AddWithValue("@CLIENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLACCREF", B.CLACCREF); } catch {  com.Parameters.AddWithValue("@CLACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLCENTERREF", B.CLCENTERREF); } catch {  com.Parameters.AddWithValue("@CLCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CASHCENTERREF", B.CASHCENTERREF); } catch {  com.Parameters.AddWithValue("@CASHCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CASHACCOUNTREF", B.CASHACCOUNTREF); } catch {  com.Parameters.AddWithValue("@CASHACCOUNTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VIRMANREF", B.VIRMANREF); } catch {  com.Parameters.AddWithValue("@VIRMANREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEFREF", B.SOURCEFREF); } catch {  com.Parameters.AddWithValue("@SOURCEFREF",  DBNull.Value); }
if (B.DATE_ != new DateTime()) 
      com.Parameters.AddWithValue("@DATE_", B.DATE_);
else 
       com.Parameters.AddWithValue("@DATE_", DBNull.Value);
 try { com.Parameters.AddWithValue("@DEPARTMENT", B.DEPARTMENT); } catch {  com.Parameters.AddWithValue("@DEPARTMENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BRANCH", B.BRANCH); } catch {  com.Parameters.AddWithValue("@BRANCH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MODULENR", B.MODULENR); } catch {  com.Parameters.AddWithValue("@MODULENR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCODE", B.TRCODE); } catch {  com.Parameters.AddWithValue("@TRCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINENR", B.LINENR); } catch {  com.Parameters.AddWithValue("@LINENR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE", B.SPECODE); } catch {  com.Parameters.AddWithValue("@SPECODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CYPHCODE", B.CYPHCODE); } catch {  com.Parameters.AddWithValue("@CYPHCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRANNO", B.TRANNO); } catch {  com.Parameters.AddWithValue("@TRANNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DOCODE", B.DOCODE); } catch {  com.Parameters.AddWithValue("@DOCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINEEXP", B.LINEEXP); } catch {  com.Parameters.AddWithValue("@LINEEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTED", B.ACCOUNTED); } catch {  com.Parameters.AddWithValue("@ACCOUNTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SIGN", B.SIGN); } catch {  com.Parameters.AddWithValue("@SIGN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AMOUNT", B.AMOUNT); } catch {  com.Parameters.AddWithValue("@AMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCURR", B.TRCURR); } catch {  com.Parameters.AddWithValue("@TRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRRATE", B.TRRATE); } catch {  com.Parameters.AddWithValue("@TRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRNET", B.TRNET); } catch {  com.Parameters.AddWithValue("@TRNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTRATE", B.REPORTRATE); } catch {  com.Parameters.AddWithValue("@REPORTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTNET", B.REPORTNET); } catch {  com.Parameters.AddWithValue("@REPORTNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXTENREF", B.EXTENREF); } catch {  com.Parameters.AddWithValue("@EXTENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYDEFREF", B.PAYDEFREF); } catch {  com.Parameters.AddWithValue("@PAYDEFREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCFICHEREF", B.ACCFICHEREF); } catch {  com.Parameters.AddWithValue("@ACCFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRINTCNT", B.PRINTCNT); } catch {  com.Parameters.AddWithValue("@PRINTCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY", B.CAPIBLOCK_CREATEDBY); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY",  DBNull.Value); }
if (B.CAPIBLOCK_CREADEDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", B.CAPIBLOCK_CREADEDDATE);
else 
       com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR", B.CAPIBLOCK_CREATEDHOUR); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN", B.CAPIBLOCK_CREATEDMIN); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC", B.CAPIBLOCK_CREATEDSEC); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY", B.CAPIBLOCK_MODIFIEDBY); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY",  DBNull.Value); }
if (B.CAPIBLOCK_MODIFIEDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", B.CAPIBLOCK_MODIFIEDDATE);
else 
       com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR", B.CAPIBLOCK_MODIFIEDHOUR); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN", B.CAPIBLOCK_MODIFIEDMIN); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC", B.CAPIBLOCK_MODIFIEDSEC); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLED", B.CANCELLED); } catch {  com.Parameters.AddWithValue("@CANCELLED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRGFLAG", B.TRGFLAG); } catch {  com.Parameters.AddWithValue("@TRGFLAG",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRADINGGRP", B.TRADINGGRP); } catch {  com.Parameters.AddWithValue("@TRADINGGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINEEXCTYP", B.LINEEXCTYP); } catch {  com.Parameters.AddWithValue("@LINEEXCTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ONLYONEPAYLINE", B.ONLYONEPAYLINE); } catch {  com.Parameters.AddWithValue("@ONLYONEPAYLINE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISCFLAG", B.DISCFLAG); } catch {  com.Parameters.AddWithValue("@DISCFLAG",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISCRATE", B.DISCRATE); } catch {  com.Parameters.AddWithValue("@DISCRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATRATE", B.VATRATE); } catch {  com.Parameters.AddWithValue("@VATRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CASHAMOUNT", B.CASHAMOUNT); } catch {  com.Parameters.AddWithValue("@CASHAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISCACCREF", B.DISCACCREF); } catch {  com.Parameters.AddWithValue("@DISCACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISCCENREF", B.DISCCENREF); } catch {  com.Parameters.AddWithValue("@DISCCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATRACCREF", B.VATRACCREF); } catch {  com.Parameters.AddWithValue("@VATRACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATRCENREF", B.VATRCENREF); } catch {  com.Parameters.AddWithValue("@VATRCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYMENTREF", B.PAYMENTREF); } catch {  com.Parameters.AddWithValue("@PAYMENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATAMOUNT", B.VATAMOUNT); } catch {  com.Parameters.AddWithValue("@VATAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SITEID", B.SITEID); } catch {  com.Parameters.AddWithValue("@SITEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECSTATUS", B.RECSTATUS); } catch {  com.Parameters.AddWithValue("@RECSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGICREF", B.ORGLOGICREF); } catch {  com.Parameters.AddWithValue("@ORGLOGICREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INFIDX", B.INFIDX); } catch {  com.Parameters.AddWithValue("@INFIDX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POSCOMMACCREF", B.POSCOMMACCREF); } catch {  com.Parameters.AddWithValue("@POSCOMMACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POSCOMMCENREF", B.POSCOMMCENREF); } catch {  com.Parameters.AddWithValue("@POSCOMMCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCOMMACCREF", B.POINTCOMMACCREF); } catch {  com.Parameters.AddWithValue("@POINTCOMMACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCOMMCENREF", B.POINTCOMMCENREF); } catch {  com.Parameters.AddWithValue("@POINTCOMMCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CHEQINFO", B.CHEQINFO); } catch {  com.Parameters.AddWithValue("@CHEQINFO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CREDITCNO", B.CREDITCNO); } catch {  com.Parameters.AddWithValue("@CREDITCNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLPRJREF", B.CLPRJREF); } catch {  com.Parameters.AddWithValue("@CLPRJREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STATUS", B.STATUS); } catch {  com.Parameters.AddWithValue("@STATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFILEREF", B.EXIMFILEREF); } catch {  com.Parameters.AddWithValue("@EXIMFILEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMPROCNR", B.EXIMPROCNR); } catch {  com.Parameters.AddWithValue("@EXIMPROCNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MONTH_", B.MONTH_); } catch {  com.Parameters.AddWithValue("@MONTH_",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@YEAR_", B.YEAR_); } catch {  com.Parameters.AddWithValue("@YEAR_",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FUNDSHARERAT", B.FUNDSHARERAT); } catch {  com.Parameters.AddWithValue("@FUNDSHARERAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTCOLLATRL", B.AFFECTCOLLATRL); } catch {  com.Parameters.AddWithValue("@AFFECTCOLLATRL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GRPFIRMTRANS", B.GRPFIRMTRANS); } catch {  com.Parameters.AddWithValue("@GRPFIRMTRANS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLVATACCREF", B.REFLVATACCREF); } catch {  com.Parameters.AddWithValue("@REFLVATACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLVATOTHACCREF", B.REFLVATOTHACCREF); } catch {  com.Parameters.AddWithValue("@REFLVATOTHACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTRISK", B.AFFECTRISK); } catch {  com.Parameters.AddWithValue("@AFFECTRISK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BATCHNR", B.BATCHNR); } catch {  com.Parameters.AddWithValue("@BATCHNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@APPROVENR", B.APPROVENR); } catch {  com.Parameters.AddWithValue("@APPROVENR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BATCHNUM", B.BATCHNUM); } catch {  com.Parameters.AddWithValue("@BATCHNUM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@APPROVENUM", B.APPROVENUM); } catch {  com.Parameters.AddWithValue("@APPROVENUM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EUVATSTATUS", B.EUVATSTATUS); } catch {  com.Parameters.AddWithValue("@EUVATSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGOID", B.ORGLOGOID); } catch {  com.Parameters.AddWithValue("@ORGLOGOID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMTYPE", B.EXIMTYPE); } catch {  com.Parameters.AddWithValue("@EXIMTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EIDISTFLNNR", B.EIDISTFLNNR); } catch {  com.Parameters.AddWithValue("@EIDISTFLNNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EISRVDSTTYP", B.EISRVDSTTYP); } catch {  com.Parameters.AddWithValue("@EISRVDSTTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMDISTTYP", B.EXIMDISTTYP); } catch {  com.Parameters.AddWithValue("@EXIMDISTTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SALESMANREF", B.SALESMANREF); } catch {  com.Parameters.AddWithValue("@SALESMANREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BANKACCREF", B.BANKACCREF); } catch {  com.Parameters.AddWithValue("@BANKACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNACCREF", B.BNACCREF); } catch {  com.Parameters.AddWithValue("@BNACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNCENTERREF", B.BNCENTERREF); } catch {  com.Parameters.AddWithValue("@BNCENTERREF",  DBNull.Value); }
if (B.DEVIRPROCDATE != new DateTime()) 
      com.Parameters.AddWithValue("@DEVIRPROCDATE", B.DEVIRPROCDATE);
else 
       com.Parameters.AddWithValue("@DEVIRPROCDATE", DBNull.Value);
if (B.DOCDATE != new DateTime()) 
      com.Parameters.AddWithValue("@DOCDATE", B.DOCDATE);
else 
       com.Parameters.AddWithValue("@DOCDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@INSTALREF", B.INSTALREF); } catch {  com.Parameters.AddWithValue("@INSTALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIR", B.DEVIR); } catch {  com.Parameters.AddWithValue("@DEVIR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIRMODULENR", B.DEVIRMODULENR); } catch {  com.Parameters.AddWithValue("@DEVIRMODULENR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FTIME", B.FTIME); } catch {  com.Parameters.AddWithValue("@FTIME",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OFFERREF", B.OFFERREF); } catch {  com.Parameters.AddWithValue("@OFFERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETCCFCREF", B.RETCCFCREF); } catch {  com.Parameters.AddWithValue("@RETCCFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EMFLINEREF", B.EMFLINEREF); } catch {  com.Parameters.AddWithValue("@EMFLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMEXCHDIFF", B.FROMEXCHDIFF); } catch {  com.Parameters.AddWithValue("@FROMEXCHDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANDEDUCT", B.CANDEDUCT); } catch {  com.Parameters.AddWithValue("@CANDEDUCT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART1", B.DEDUCTIONPART1); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART2", B.DEDUCTIONPART2); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UNDERDEDUCTLIMIT", B.UNDERDEDUCTLIMIT); } catch {  com.Parameters.AddWithValue("@UNDERDEDUCTLIMIT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATDEDUCTRATE", B.VATDEDUCTRATE); } catch {  com.Parameters.AddWithValue("@VATDEDUCTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATDEDUCTACCREF", B.VATDEDUCTACCREF); } catch {  com.Parameters.AddWithValue("@VATDEDUCTACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATDEDUCTOTHACCREF", B.VATDEDUCTOTHACCREF); } catch {  com.Parameters.AddWithValue("@VATDEDUCTOTHACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATDEDUCTCENREF", B.VATDEDUCTCENREF); } catch {  com.Parameters.AddWithValue("@VATDEDUCTCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATDEDUCTOTHCENREF", B.VATDEDUCTOTHCENREF); } catch {  com.Parameters.AddWithValue("@VATDEDUCTOTHCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANTCREDEDUCT", B.CANTCREDEDUCT); } catch {  com.Parameters.AddWithValue("@CANTCREDEDUCT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GUID", B.GUID); } catch {  com.Parameters.AddWithValue("@GUID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAIDINCASH", B.PAIDINCASH); } catch {  com.Parameters.AddWithValue("@PAIDINCASH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BRUTAMOUNT", B.BRUTAMOUNT); } catch {  com.Parameters.AddWithValue("@BRUTAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETAMOUNT", B.NETAMOUNT); } catch {  com.Parameters.AddWithValue("@NETAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BRUTAMOUNTTR", B.BRUTAMOUNTTR); } catch {  com.Parameters.AddWithValue("@BRUTAMOUNTTR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETAMOUNTTR", B.NETAMOUNTTR); } catch {  com.Parameters.AddWithValue("@NETAMOUNTTR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BRUTAMOUNTREP", B.BRUTAMOUNTREP); } catch {  com.Parameters.AddWithValue("@BRUTAMOUNTREP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETAMOUNTREP", B.NETAMOUNTREP); } catch {  com.Parameters.AddWithValue("@NETAMOUNTREP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNLNTRCURR", B.BNLNTRCURR); } catch {  com.Parameters.AddWithValue("@BNLNTRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNLNTRRATE", B.BNLNTRRATE); } catch {  com.Parameters.AddWithValue("@BNLNTRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNLNTRNET", B.BNLNTRNET); } catch {  com.Parameters.AddWithValue("@BNLNTRNET",  DBNull.Value); }
if (B.PRINTDATE != new DateTime()) 
      com.Parameters.AddWithValue("@PRINTDATE", B.PRINTDATE);
else 
       com.Parameters.AddWithValue("@PRINTDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@INCDEDUCTAMNT", B.INCDEDUCTAMNT); } catch {  com.Parameters.AddWithValue("@INCDEDUCTAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTCOST", B.AFFECTCOST); } catch {  com.Parameters.AddWithValue("@AFFECTCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FOREXIM", B.FOREXIM); } catch {  com.Parameters.AddWithValue("@FOREXIM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFILECODECLF", B.EXIMFILECODECLF); } catch {  com.Parameters.AddWithValue("@EXIMFILECODECLF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE2", B.SPECODE2); } catch {  com.Parameters.AddWithValue("@SPECODE2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SERVREASONDEF", B.SERVREASONDEF); } catch {  com.Parameters.AddWithValue("@SERVREASONDEF",  DBNull.Value); }
      com.Parameters.AddWithValue("@WHERECLAUSE", WHERECLAUSE);

      return com;
   }
   catch
   {
      return null;
   }
}

public SqlCommand BM_XXX_XX_INVOICE_UPDATE(BM_XXX_XX_INVOICE B, bool UPDATEBM, bool UPDATELOGICALREF ,string FIRMNR ,string PERIODNR, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BM_XXX_XX_INVOICE";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") .Replace("XXX", FIRMNR) 
.Replace("XX", PERIODNR); 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " GRPCODE = @GRPCODE, TRCODE = @TRCODE, FICHENO = @FICHENO, DATE_ = @DATE_, TIME_ = @TIME_, DOCODE = @DOCODE, SPECODE = @SPECODE, CYPHCODE = @CYPHCODE, CLIENTREF = @CLIENTREF, RECVREF = @RECVREF, CENTERREF = @CENTERREF, ACCOUNTREF = @ACCOUNTREF, SOURCEINDEX = @SOURCEINDEX, SOURCECOSTGRP = @SOURCECOSTGRP, CANCELLED = @CANCELLED, ACCOUNTED = @ACCOUNTED, PAIDINCASH = @PAIDINCASH, FROMKASA = @FROMKASA, ENTEGSET = @ENTEGSET, VAT = @VAT, ADDDISCOUNTS = @ADDDISCOUNTS, TOTALDISCOUNTS = @TOTALDISCOUNTS, TOTALDISCOUNTED = @TOTALDISCOUNTED, ADDEXPENSES = @ADDEXPENSES, TOTALEXPENSES = @TOTALEXPENSES, DISTEXPENSE = @DISTEXPENSE, TOTALDEPOZITO = @TOTALDEPOZITO, TOTALPROMOTIONS = @TOTALPROMOTIONS, VATINCGROSS = @VATINCGROSS, TOTALVAT = @TOTALVAT, GROSSTOTAL = @GROSSTOTAL, NETTOTAL = @NETTOTAL, GENEXP1 = @GENEXP1, GENEXP2 = @GENEXP2, GENEXP3 = @GENEXP3, GENEXP4 = @GENEXP4, GENEXP5 = @GENEXP5, GENEXP6 = @GENEXP6, INTERESTAPP = @INTERESTAPP, TRCURR = @TRCURR, TRRATE = @TRRATE, TRNET = @TRNET, REPORTRATE = @REPORTRATE, REPORTNET = @REPORTNET, ONLYONEPAYLINE = @ONLYONEPAYLINE, KASTRANSREF = @KASTRANSREF, PAYDEFREF = @PAYDEFREF, PRINTCNT = @PRINTCNT, GVATINC = @GVATINC, BRANCH = @BRANCH, DEPARTMENT = @DEPARTMENT, ACCFICHEREF = @ACCFICHEREF, ADDEXPACCREF = @ADDEXPACCREF, ADDEXPCENTREF = @ADDEXPCENTREF, DECPRDIFF = @DECPRDIFF, CAPIBLOCK_CREATEDBY = @CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE = @CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR = @CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN = @CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC = @CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY = @CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE = @CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR = @CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN = @CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC = @CAPIBLOCK_MODIFIEDSEC, SALESMANREF = @SALESMANREF, CANCELLEDACC = @CANCELLEDACC, SHPTYPCOD = @SHPTYPCOD, SHPAGNCOD = @SHPAGNCOD, TRACKNR = @TRACKNR, GENEXCTYP = @GENEXCTYP, LINEEXCTYP = @LINEEXCTYP, TRADINGGRP = @TRADINGGRP, TEXTINC = @TEXTINC, SITEID = @SITEID, RECSTATUS = @RECSTATUS, ORGLOGICREF = @ORGLOGICREF, FACTORYNR = @FACTORYNR, WFSTATUS = @WFSTATUS, SHIPINFOREF = @SHIPINFOREF, DISTORDERREF = @DISTORDERREF, SENDCNT = @SENDCNT, DLVCLIENT = @DLVCLIENT, COSTOFSALEFCREF = @COSTOFSALEFCREF, OPSTAT = @OPSTAT, DOCTRACKINGNR = @DOCTRACKINGNR, TOTALADDTAX = @TOTALADDTAX, PAYMENTTYPE = @PAYMENTTYPE, INFIDX = @INFIDX, ACCOUNTEDCNT = @ACCOUNTEDCNT, ORGLOGOID = @ORGLOGOID, FROMEXIM = @FROMEXIM, FRGTYPCOD = @FRGTYPCOD, EXIMFCTYPE = @EXIMFCTYPE, FROMORDWITHPAY = @FROMORDWITHPAY, PROJECTREF = @PROJECTREF, WFLOWCRDREF = @WFLOWCRDREF, STATUS = @STATUS, DEDUCTIONPART1 = @DEDUCTIONPART1, DEDUCTIONPART2 = @DEDUCTIONPART2, TOTALEXADDTAX = @TOTALEXADDTAX, EXACCOUNTED = @EXACCOUNTED, FROMBANK = @FROMBANK, BNTRANSREF = @BNTRANSREF, AFFECTCOLLATRL = @AFFECTCOLLATRL, GRPFIRMTRANS = @GRPFIRMTRANS, AFFECTRISK = @AFFECTRISK, CONTROLINFO = @CONTROLINFO, POSTRANSFERINFO = @POSTRANSFERINFO, TAXFREECHX = @TAXFREECHX, PASSPORTNO = @PASSPORTNO, CREDITCARDNO = @CREDITCARDNO, INEFFECTIVECOST = @INEFFECTIVECOST, REFLECTED = @REFLECTED, REFLACCFICHEREF = @REFLACCFICHEREF, CANCELLEDREFLACC = @CANCELLEDREFLACC, CREDITCARDNUM = @CREDITCARDNUM, APPROVE = @APPROVE, APPROVEDATE = @APPROVEDATE, CANTCREDEDUCT = @CANTCREDEDUCT, ENTRUST = @ENTRUST, DOCDATE = @DOCDATE, EINVOICE = @EINVOICE, PROFILEID = @PROFILEID, GUID = @GUID, ESTATUS = @ESTATUS, ESTARTDATE = @ESTARTDATE, EENDDATE = @EENDDATE, EDESCRIPTION = @EDESCRIPTION, EDURATION = @EDURATION, EDURATIONTYPE = @EDURATIONTYPE, DEVIR = @DEVIR, DISTADJPRICEUFRS = @DISTADJPRICEUFRS, COSFCREFUFRS = @COSFCREFUFRS, GLOBALID = @GLOBALID, TOTALSERVICES = @TOTALSERVICES, FROMLEASING = @FROMLEASING, CANCELEXP = @CANCELEXP, UNDOEXP = @UNDOEXP, VATEXCEPTREASON = @VATEXCEPTREASON, CAMPAIGNCODE = @CAMPAIGNCODE, CANCELDESPSINV = @CANCELDESPSINV, FROMEXCHDIFF = @FROMEXCHDIFF, EXIMVAT = @EXIMVAT, SERIALCODE = @SERIALCODE, APPCLDEDUCTLIM = @APPCLDEDUCTLIM, EINVOICETYP = @EINVOICETYP, VATEXCEPTCODE = @VATEXCEPTCODE, OFFERREF = @OFFERREF, ATAXEXCEPTREASON = @ATAXEXCEPTREASON, ATAXEXCEPTCODE = @ATAXEXCEPTCODE, FROMSTAFFOTHEREX = @FROMSTAFFOTHEREX, NOCALCULATE = @NOCALCULATE, INSTEADOFDESP = @INSTEADOFDESP, OKCFICHE = @OKCFICHE, CANCELDATE = @CANCELDATE, FRGTYPDESC = @FRGTYPDESC, MARKREF = @MARKREF, PRINTDATE = @PRINTDATE, DELIVERCODE = @DELIVERCODE, ACCEPTEINVPUBLIC = @ACCEPTEINVPUBLIC, PUBLICBNACCREF = @PUBLICBNACCREF, TYPECODE = @TYPECODE, FUTMNTHYREXPINC = @FUTMNTHYREXPINC WHERE " + WHERECLAUSE + " = " + WHEREVALUE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GRPCODE", B.GRPCODE); } catch {  com.Parameters.AddWithValue("@GRPCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCODE", B.TRCODE); } catch {  com.Parameters.AddWithValue("@TRCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FICHENO", B.FICHENO); } catch {  com.Parameters.AddWithValue("@FICHENO",  DBNull.Value); }
if (B.DATE_ != new DateTime()) 
      com.Parameters.AddWithValue("@DATE_", B.DATE_);
else 
       com.Parameters.AddWithValue("@DATE_", DBNull.Value);
 try { com.Parameters.AddWithValue("@TIME_", B.TIME_); } catch {  com.Parameters.AddWithValue("@TIME_",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DOCODE", B.DOCODE); } catch {  com.Parameters.AddWithValue("@DOCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE", B.SPECODE); } catch {  com.Parameters.AddWithValue("@SPECODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CYPHCODE", B.CYPHCODE); } catch {  com.Parameters.AddWithValue("@CYPHCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLIENTREF", B.CLIENTREF); } catch {  com.Parameters.AddWithValue("@CLIENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECVREF", B.RECVREF); } catch {  com.Parameters.AddWithValue("@RECVREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CENTERREF", B.CENTERREF); } catch {  com.Parameters.AddWithValue("@CENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTREF", B.ACCOUNTREF); } catch {  com.Parameters.AddWithValue("@ACCOUNTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEINDEX", B.SOURCEINDEX); } catch {  com.Parameters.AddWithValue("@SOURCEINDEX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCECOSTGRP", B.SOURCECOSTGRP); } catch {  com.Parameters.AddWithValue("@SOURCECOSTGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLED", B.CANCELLED); } catch {  com.Parameters.AddWithValue("@CANCELLED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTED", B.ACCOUNTED); } catch {  com.Parameters.AddWithValue("@ACCOUNTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAIDINCASH", B.PAIDINCASH); } catch {  com.Parameters.AddWithValue("@PAIDINCASH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMKASA", B.FROMKASA); } catch {  com.Parameters.AddWithValue("@FROMKASA",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ENTEGSET", B.ENTEGSET); } catch {  com.Parameters.AddWithValue("@ENTEGSET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VAT", B.VAT); } catch {  com.Parameters.AddWithValue("@VAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDDISCOUNTS", B.ADDDISCOUNTS); } catch {  com.Parameters.AddWithValue("@ADDDISCOUNTS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALDISCOUNTS", B.TOTALDISCOUNTS); } catch {  com.Parameters.AddWithValue("@TOTALDISCOUNTS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALDISCOUNTED", B.TOTALDISCOUNTED); } catch {  com.Parameters.AddWithValue("@TOTALDISCOUNTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDEXPENSES", B.ADDEXPENSES); } catch {  com.Parameters.AddWithValue("@ADDEXPENSES",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALEXPENSES", B.TOTALEXPENSES); } catch {  com.Parameters.AddWithValue("@TOTALEXPENSES",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTEXPENSE", B.DISTEXPENSE); } catch {  com.Parameters.AddWithValue("@DISTEXPENSE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALDEPOZITO", B.TOTALDEPOZITO); } catch {  com.Parameters.AddWithValue("@TOTALDEPOZITO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALPROMOTIONS", B.TOTALPROMOTIONS); } catch {  com.Parameters.AddWithValue("@TOTALPROMOTIONS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATINCGROSS", B.VATINCGROSS); } catch {  com.Parameters.AddWithValue("@VATINCGROSS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALVAT", B.TOTALVAT); } catch {  com.Parameters.AddWithValue("@TOTALVAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GROSSTOTAL", B.GROSSTOTAL); } catch {  com.Parameters.AddWithValue("@GROSSTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETTOTAL", B.NETTOTAL); } catch {  com.Parameters.AddWithValue("@NETTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP1", B.GENEXP1); } catch {  com.Parameters.AddWithValue("@GENEXP1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP2", B.GENEXP2); } catch {  com.Parameters.AddWithValue("@GENEXP2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP3", B.GENEXP3); } catch {  com.Parameters.AddWithValue("@GENEXP3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP4", B.GENEXP4); } catch {  com.Parameters.AddWithValue("@GENEXP4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP5", B.GENEXP5); } catch {  com.Parameters.AddWithValue("@GENEXP5",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP6", B.GENEXP6); } catch {  com.Parameters.AddWithValue("@GENEXP6",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INTERESTAPP", B.INTERESTAPP); } catch {  com.Parameters.AddWithValue("@INTERESTAPP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCURR", B.TRCURR); } catch {  com.Parameters.AddWithValue("@TRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRRATE", B.TRRATE); } catch {  com.Parameters.AddWithValue("@TRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRNET", B.TRNET); } catch {  com.Parameters.AddWithValue("@TRNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTRATE", B.REPORTRATE); } catch {  com.Parameters.AddWithValue("@REPORTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTNET", B.REPORTNET); } catch {  com.Parameters.AddWithValue("@REPORTNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ONLYONEPAYLINE", B.ONLYONEPAYLINE); } catch {  com.Parameters.AddWithValue("@ONLYONEPAYLINE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@KASTRANSREF", B.KASTRANSREF); } catch {  com.Parameters.AddWithValue("@KASTRANSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYDEFREF", B.PAYDEFREF); } catch {  com.Parameters.AddWithValue("@PAYDEFREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRINTCNT", B.PRINTCNT); } catch {  com.Parameters.AddWithValue("@PRINTCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GVATINC", B.GVATINC); } catch {  com.Parameters.AddWithValue("@GVATINC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BRANCH", B.BRANCH); } catch {  com.Parameters.AddWithValue("@BRANCH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEPARTMENT", B.DEPARTMENT); } catch {  com.Parameters.AddWithValue("@DEPARTMENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCFICHEREF", B.ACCFICHEREF); } catch {  com.Parameters.AddWithValue("@ACCFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDEXPACCREF", B.ADDEXPACCREF); } catch {  com.Parameters.AddWithValue("@ADDEXPACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDEXPCENTREF", B.ADDEXPCENTREF); } catch {  com.Parameters.AddWithValue("@ADDEXPCENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DECPRDIFF", B.DECPRDIFF); } catch {  com.Parameters.AddWithValue("@DECPRDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY", B.CAPIBLOCK_CREATEDBY); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY",  DBNull.Value); }
if (B.CAPIBLOCK_CREADEDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", B.CAPIBLOCK_CREADEDDATE);
else 
       com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR", B.CAPIBLOCK_CREATEDHOUR); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN", B.CAPIBLOCK_CREATEDMIN); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC", B.CAPIBLOCK_CREATEDSEC); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY", B.CAPIBLOCK_MODIFIEDBY); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY",  DBNull.Value); }
if (B.CAPIBLOCK_MODIFIEDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", B.CAPIBLOCK_MODIFIEDDATE);
else 
       com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR", B.CAPIBLOCK_MODIFIEDHOUR); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN", B.CAPIBLOCK_MODIFIEDMIN); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC", B.CAPIBLOCK_MODIFIEDSEC); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SALESMANREF", B.SALESMANREF); } catch {  com.Parameters.AddWithValue("@SALESMANREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLEDACC", B.CANCELLEDACC); } catch {  com.Parameters.AddWithValue("@CANCELLEDACC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SHPTYPCOD", B.SHPTYPCOD); } catch {  com.Parameters.AddWithValue("@SHPTYPCOD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SHPAGNCOD", B.SHPAGNCOD); } catch {  com.Parameters.AddWithValue("@SHPAGNCOD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRACKNR", B.TRACKNR); } catch {  com.Parameters.AddWithValue("@TRACKNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXCTYP", B.GENEXCTYP); } catch {  com.Parameters.AddWithValue("@GENEXCTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINEEXCTYP", B.LINEEXCTYP); } catch {  com.Parameters.AddWithValue("@LINEEXCTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRADINGGRP", B.TRADINGGRP); } catch {  com.Parameters.AddWithValue("@TRADINGGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TEXTINC", B.TEXTINC); } catch {  com.Parameters.AddWithValue("@TEXTINC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SITEID", B.SITEID); } catch {  com.Parameters.AddWithValue("@SITEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECSTATUS", B.RECSTATUS); } catch {  com.Parameters.AddWithValue("@RECSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGICREF", B.ORGLOGICREF); } catch {  com.Parameters.AddWithValue("@ORGLOGICREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FACTORYNR", B.FACTORYNR); } catch {  com.Parameters.AddWithValue("@FACTORYNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@WFSTATUS", B.WFSTATUS); } catch {  com.Parameters.AddWithValue("@WFSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SHIPINFOREF", B.SHIPINFOREF); } catch {  com.Parameters.AddWithValue("@SHIPINFOREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTORDERREF", B.DISTORDERREF); } catch {  com.Parameters.AddWithValue("@DISTORDERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SENDCNT", B.SENDCNT); } catch {  com.Parameters.AddWithValue("@SENDCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DLVCLIENT", B.DLVCLIENT); } catch {  com.Parameters.AddWithValue("@DLVCLIENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTOFSALEFCREF", B.COSTOFSALEFCREF); } catch {  com.Parameters.AddWithValue("@COSTOFSALEFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OPSTAT", B.OPSTAT); } catch {  com.Parameters.AddWithValue("@OPSTAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DOCTRACKINGNR", B.DOCTRACKINGNR); } catch {  com.Parameters.AddWithValue("@DOCTRACKINGNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALADDTAX", B.TOTALADDTAX); } catch {  com.Parameters.AddWithValue("@TOTALADDTAX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYMENTTYPE", B.PAYMENTTYPE); } catch {  com.Parameters.AddWithValue("@PAYMENTTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INFIDX", B.INFIDX); } catch {  com.Parameters.AddWithValue("@INFIDX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTEDCNT", B.ACCOUNTEDCNT); } catch {  com.Parameters.AddWithValue("@ACCOUNTEDCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGOID", B.ORGLOGOID); } catch {  com.Parameters.AddWithValue("@ORGLOGOID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMEXIM", B.FROMEXIM); } catch {  com.Parameters.AddWithValue("@FROMEXIM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FRGTYPCOD", B.FRGTYPCOD); } catch {  com.Parameters.AddWithValue("@FRGTYPCOD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFCTYPE", B.EXIMFCTYPE); } catch {  com.Parameters.AddWithValue("@EXIMFCTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMORDWITHPAY", B.FROMORDWITHPAY); } catch {  com.Parameters.AddWithValue("@FROMORDWITHPAY",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROJECTREF", B.PROJECTREF); } catch {  com.Parameters.AddWithValue("@PROJECTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@WFLOWCRDREF", B.WFLOWCRDREF); } catch {  com.Parameters.AddWithValue("@WFLOWCRDREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STATUS", B.STATUS); } catch {  com.Parameters.AddWithValue("@STATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART1", B.DEDUCTIONPART1); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART2", B.DEDUCTIONPART2); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALEXADDTAX", B.TOTALEXADDTAX); } catch {  com.Parameters.AddWithValue("@TOTALEXADDTAX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXACCOUNTED", B.EXACCOUNTED); } catch {  com.Parameters.AddWithValue("@EXACCOUNTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMBANK", B.FROMBANK); } catch {  com.Parameters.AddWithValue("@FROMBANK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNTRANSREF", B.BNTRANSREF); } catch {  com.Parameters.AddWithValue("@BNTRANSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTCOLLATRL", B.AFFECTCOLLATRL); } catch {  com.Parameters.AddWithValue("@AFFECTCOLLATRL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GRPFIRMTRANS", B.GRPFIRMTRANS); } catch {  com.Parameters.AddWithValue("@GRPFIRMTRANS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTRISK", B.AFFECTRISK); } catch {  com.Parameters.AddWithValue("@AFFECTRISK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CONTROLINFO", B.CONTROLINFO); } catch {  com.Parameters.AddWithValue("@CONTROLINFO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POSTRANSFERINFO", B.POSTRANSFERINFO); } catch {  com.Parameters.AddWithValue("@POSTRANSFERINFO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TAXFREECHX", B.TAXFREECHX); } catch {  com.Parameters.AddWithValue("@TAXFREECHX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PASSPORTNO", B.PASSPORTNO); } catch {  com.Parameters.AddWithValue("@PASSPORTNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CREDITCARDNO", B.CREDITCARDNO); } catch {  com.Parameters.AddWithValue("@CREDITCARDNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INEFFECTIVECOST", B.INEFFECTIVECOST); } catch {  com.Parameters.AddWithValue("@INEFFECTIVECOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLECTED", B.REFLECTED); } catch {  com.Parameters.AddWithValue("@REFLECTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLACCFICHEREF", B.REFLACCFICHEREF); } catch {  com.Parameters.AddWithValue("@REFLACCFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLEDREFLACC", B.CANCELLEDREFLACC); } catch {  com.Parameters.AddWithValue("@CANCELLEDREFLACC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CREDITCARDNUM", B.CREDITCARDNUM); } catch {  com.Parameters.AddWithValue("@CREDITCARDNUM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@APPROVE", B.APPROVE); } catch {  com.Parameters.AddWithValue("@APPROVE",  DBNull.Value); }
if (B.APPROVEDATE != new DateTime()) 
      com.Parameters.AddWithValue("@APPROVEDATE", B.APPROVEDATE);
else 
       com.Parameters.AddWithValue("@APPROVEDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CANTCREDEDUCT", B.CANTCREDEDUCT); } catch {  com.Parameters.AddWithValue("@CANTCREDEDUCT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ENTRUST", B.ENTRUST); } catch {  com.Parameters.AddWithValue("@ENTRUST",  DBNull.Value); }
if (B.DOCDATE != new DateTime()) 
      com.Parameters.AddWithValue("@DOCDATE", B.DOCDATE);
else 
       com.Parameters.AddWithValue("@DOCDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@EINVOICE", B.EINVOICE); } catch {  com.Parameters.AddWithValue("@EINVOICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROFILEID", B.PROFILEID); } catch {  com.Parameters.AddWithValue("@PROFILEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GUID", B.GUID); } catch {  com.Parameters.AddWithValue("@GUID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ESTATUS", B.ESTATUS); } catch {  com.Parameters.AddWithValue("@ESTATUS",  DBNull.Value); }
if (B.ESTARTDATE != new DateTime()) 
      com.Parameters.AddWithValue("@ESTARTDATE", B.ESTARTDATE);
else 
       com.Parameters.AddWithValue("@ESTARTDATE", DBNull.Value);
if (B.EENDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@EENDDATE", B.EENDDATE);
else 
       com.Parameters.AddWithValue("@EENDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@EDESCRIPTION", B.EDESCRIPTION); } catch {  com.Parameters.AddWithValue("@EDESCRIPTION",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EDURATION", B.EDURATION); } catch {  com.Parameters.AddWithValue("@EDURATION",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EDURATIONTYPE", B.EDURATIONTYPE); } catch {  com.Parameters.AddWithValue("@EDURATIONTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIR", B.DEVIR); } catch {  com.Parameters.AddWithValue("@DEVIR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTADJPRICEUFRS", B.DISTADJPRICEUFRS); } catch {  com.Parameters.AddWithValue("@DISTADJPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSFCREFUFRS", B.COSFCREFUFRS); } catch {  com.Parameters.AddWithValue("@COSFCREFUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GLOBALID", B.GLOBALID); } catch {  com.Parameters.AddWithValue("@GLOBALID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALSERVICES", B.TOTALSERVICES); } catch {  com.Parameters.AddWithValue("@TOTALSERVICES",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMLEASING", B.FROMLEASING); } catch {  com.Parameters.AddWithValue("@FROMLEASING",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELEXP", B.CANCELEXP); } catch {  com.Parameters.AddWithValue("@CANCELEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UNDOEXP", B.UNDOEXP); } catch {  com.Parameters.AddWithValue("@UNDOEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATEXCEPTREASON", B.VATEXCEPTREASON); } catch {  com.Parameters.AddWithValue("@VATEXCEPTREASON",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNCODE", B.CAMPAIGNCODE); } catch {  com.Parameters.AddWithValue("@CAMPAIGNCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELDESPSINV", B.CANCELDESPSINV); } catch {  com.Parameters.AddWithValue("@CANCELDESPSINV",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMEXCHDIFF", B.FROMEXCHDIFF); } catch {  com.Parameters.AddWithValue("@FROMEXCHDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMVAT", B.EXIMVAT); } catch {  com.Parameters.AddWithValue("@EXIMVAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SERIALCODE", B.SERIALCODE); } catch {  com.Parameters.AddWithValue("@SERIALCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@APPCLDEDUCTLIM", B.APPCLDEDUCTLIM); } catch {  com.Parameters.AddWithValue("@APPCLDEDUCTLIM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EINVOICETYP", B.EINVOICETYP); } catch {  com.Parameters.AddWithValue("@EINVOICETYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATEXCEPTCODE", B.VATEXCEPTCODE); } catch {  com.Parameters.AddWithValue("@VATEXCEPTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OFFERREF", B.OFFERREF); } catch {  com.Parameters.AddWithValue("@OFFERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ATAXEXCEPTREASON", B.ATAXEXCEPTREASON); } catch {  com.Parameters.AddWithValue("@ATAXEXCEPTREASON",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ATAXEXCEPTCODE", B.ATAXEXCEPTCODE); } catch {  com.Parameters.AddWithValue("@ATAXEXCEPTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMSTAFFOTHEREX", B.FROMSTAFFOTHEREX); } catch {  com.Parameters.AddWithValue("@FROMSTAFFOTHEREX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NOCALCULATE", B.NOCALCULATE); } catch {  com.Parameters.AddWithValue("@NOCALCULATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INSTEADOFDESP", B.INSTEADOFDESP); } catch {  com.Parameters.AddWithValue("@INSTEADOFDESP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OKCFICHE", B.OKCFICHE); } catch {  com.Parameters.AddWithValue("@OKCFICHE",  DBNull.Value); }
if (B.CANCELDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CANCELDATE", B.CANCELDATE);
else 
       com.Parameters.AddWithValue("@CANCELDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@FRGTYPDESC", B.FRGTYPDESC); } catch {  com.Parameters.AddWithValue("@FRGTYPDESC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MARKREF", B.MARKREF); } catch {  com.Parameters.AddWithValue("@MARKREF",  DBNull.Value); }
if (B.PRINTDATE != new DateTime()) 
      com.Parameters.AddWithValue("@PRINTDATE", B.PRINTDATE);
else 
       com.Parameters.AddWithValue("@PRINTDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@DELIVERCODE", B.DELIVERCODE); } catch {  com.Parameters.AddWithValue("@DELIVERCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCEPTEINVPUBLIC", B.ACCEPTEINVPUBLIC); } catch {  com.Parameters.AddWithValue("@ACCEPTEINVPUBLIC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PUBLICBNACCREF", B.PUBLICBNACCREF); } catch {  com.Parameters.AddWithValue("@PUBLICBNACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TYPECODE", B.TYPECODE); } catch {  com.Parameters.AddWithValue("@TYPECODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FUTMNTHYREXPINC", B.FUTMNTHYREXPINC); } catch {  com.Parameters.AddWithValue("@FUTMNTHYREXPINC",  DBNull.Value); }
      com.Parameters.AddWithValue("@WHERECLAUSE", WHERECLAUSE);

      return com;
   }
   catch
   {
      return null;
   }
}

public SqlCommand BM_XXX_XX_STFICHE_UPDATE(BM_XXX_XX_STFICHE B, bool UPDATEBM, bool UPDATELOGICALREF ,string FIRMNR ,string PERIODNR, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BM_XXX_XX_STFICHE";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") .Replace("XXX", FIRMNR) 
.Replace("XX", PERIODNR); 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " GRPCODE = @GRPCODE, TRCODE = @TRCODE, IOCODE = @IOCODE, FICHENO = @FICHENO, DATE_ = @DATE_, FTIME = @FTIME, DOCODE = @DOCODE, INVNO = @INVNO, SPECODE = @SPECODE, CYPHCODE = @CYPHCODE, INVOICEREF = @INVOICEREF, CLIENTREF = @CLIENTREF, RECVREF = @RECVREF, ACCOUNTREF = @ACCOUNTREF, CENTERREF = @CENTERREF, PRODORDERREF = @PRODORDERREF, PORDERFICHENO = @PORDERFICHENO, SOURCETYPE = @SOURCETYPE, SOURCEINDEX = @SOURCEINDEX, SOURCEWSREF = @SOURCEWSREF, SOURCEPOLNREF = @SOURCEPOLNREF, SOURCECOSTGRP = @SOURCECOSTGRP, DESTTYPE = @DESTTYPE, DESTINDEX = @DESTINDEX, DESTWSREF = @DESTWSREF, DESTPOLNREF = @DESTPOLNREF, DESTCOSTGRP = @DESTCOSTGRP, FACTORYNR = @FACTORYNR, BRANCH = @BRANCH, DEPARTMENT = @DEPARTMENT, COMPBRANCH = @COMPBRANCH, COMPDEPARTMENT = @COMPDEPARTMENT, COMPFACTORY = @COMPFACTORY, PRODSTAT = @PRODSTAT, DEVIR = @DEVIR, CANCELLED = @CANCELLED, BILLED = @BILLED, ACCOUNTED = @ACCOUNTED, UPDCURR = @UPDCURR, INUSE = @INUSE, INVKIND = @INVKIND, ADDDISCOUNTS = @ADDDISCOUNTS, TOTALDISCOUNTS = @TOTALDISCOUNTS, TOTALDISCOUNTED = @TOTALDISCOUNTED, ADDEXPENSES = @ADDEXPENSES, TOTALEXPENSES = @TOTALEXPENSES, TOTALDEPOZITO = @TOTALDEPOZITO, TOTALPROMOTIONS = @TOTALPROMOTIONS, TOTALVAT = @TOTALVAT, GROSSTOTAL = @GROSSTOTAL, NETTOTAL = @NETTOTAL, GENEXP1 = @GENEXP1, GENEXP2 = @GENEXP2, GENEXP3 = @GENEXP3, GENEXP4 = @GENEXP4, GENEXP5 = @GENEXP5, GENEXP6 = @GENEXP6, REPORTRATE = @REPORTRATE, REPORTNET = @REPORTNET, EXTENREF = @EXTENREF, PAYDEFREF = @PAYDEFREF, PRINTCNT = @PRINTCNT, FICHECNT = @FICHECNT, ACCFICHEREF = @ACCFICHEREF, CAPIBLOCK_CREATEDBY = @CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE = @CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR = @CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN = @CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC = @CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY = @CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE = @CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR = @CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN = @CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC = @CAPIBLOCK_MODIFIEDSEC, SALESMANREF = @SALESMANREF, CANCELLEDACC = @CANCELLEDACC, SHPTYPCOD = @SHPTYPCOD, SHPAGNCOD = @SHPAGNCOD, TRACKNR = @TRACKNR, GENEXCTYP = @GENEXCTYP, LINEEXCTYP = @LINEEXCTYP, TRADINGGRP = @TRADINGGRP, TEXTINC = @TEXTINC, SITEID = @SITEID, RECSTATUS = @RECSTATUS, ORGLOGICREF = @ORGLOGICREF, WFSTATUS = @WFSTATUS, SHIPINFOREF = @SHIPINFOREF, DISTORDERREF = @DISTORDERREF, SENDCNT = @SENDCNT, DLVCLIENT = @DLVCLIENT, DOCTRACKINGNR = @DOCTRACKINGNR, ADDTAXCALC = @ADDTAXCALC, TOTALADDTAX = @TOTALADDTAX, UGIRTRACKINGNO = @UGIRTRACKINGNO, QPRODFCREF = @QPRODFCREF, VAACCREF = @VAACCREF, VACENTERREF = @VACENTERREF, ORGLOGOID = @ORGLOGOID, FROMEXIM = @FROMEXIM, FRGTYPCOD = @FRGTYPCOD, TRCURR = @TRCURR, TRRATE = @TRRATE, TRNET = @TRNET, EXIMWHFCREF = @EXIMWHFCREF, EXIMFCTYPE = @EXIMFCTYPE, MAINSTFCREF = @MAINSTFCREF, FROMORDWITHPAY = @FROMORDWITHPAY, PROJECTREF = @PROJECTREF, WFLOWCRDREF = @WFLOWCRDREF, STATUS = @STATUS, UPDTRCURR = @UPDTRCURR, TOTALEXADDTAX = @TOTALEXADDTAX, AFFECTCOLLATRL = @AFFECTCOLLATRL, DEDUCTIONPART1 = @DEDUCTIONPART1, DEDUCTIONPART2 = @DEDUCTIONPART2, GRPFIRMTRANS = @GRPFIRMTRANS, AFFECTRISK = @AFFECTRISK, DISPSTATUS = @DISPSTATUS, APPROVE = @APPROVE, APPROVEDATE = @APPROVEDATE, CANTCREDEDUCT = @CANTCREDEDUCT, SHIPDATE = @SHIPDATE, SHIPTIME = @SHIPTIME, ENTRUSTDEVIR = @ENTRUSTDEVIR, RELTRANSFCREF = @RELTRANSFCREF, FROMTRANSFER = @FROMTRANSFER, GUID = @GUID, GLOBALID = @GLOBALID, COMPSTFCREF = @COMPSTFCREF, COMPINVREF = @COMPINVREF, TOTALSERVICES = @TOTALSERVICES, CAMPAIGNCODE = @CAMPAIGNCODE, OFFERREF = @OFFERREF, EINVOICETYP = @EINVOICETYP, EINVOICE = @EINVOICE, NOCALCULATE = @NOCALCULATE, PRODORDERTYP = @PRODORDERTYP, QPRODFCTYP = @QPRODFCTYP, PRINTDATE = @PRINTDATE, PRDORDSLPLNRESERVE = @PRDORDSLPLNRESERVE, CONTROLINFO = @CONTROLINFO, EDESPATCH = @EDESPATCH, DOCDATE = @DOCDATE, DOCTIME = @DOCTIME, EDESPSTATUS = @EDESPSTATUS, PROFILEID = @PROFILEID, DELIVERYCODE = @DELIVERYCODE, DESTSTATUS = @DESTSTATUS, CANCELEXP = @CANCELEXP, UNDOEXP = @UNDOEXP, CANCELDATE = @CANCELDATE, CREATEWHERE = @CREATEWHERE, PUBLICBNACCREF = @PUBLICBNACCREF, ACCEPTEINVPUBLIC = @ACCEPTEINVPUBLIC, VATEXCEPTCODE = @VATEXCEPTCODE, VATEXCEPTREASON = @VATEXCEPTREASON, ATAXEXCEPTCODE = @ATAXEXCEPTCODE, ATAXEXCEPTREASON = @ATAXEXCEPTREASON, TAXFREECHX = @TAXFREECHX  WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GRPCODE", B.GRPCODE); } catch {  com.Parameters.AddWithValue("@GRPCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCODE", B.TRCODE); } catch {  com.Parameters.AddWithValue("@TRCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@IOCODE", B.IOCODE); } catch {  com.Parameters.AddWithValue("@IOCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FICHENO", B.FICHENO); } catch {  com.Parameters.AddWithValue("@FICHENO",  DBNull.Value); }
if (B.DATE_ != new DateTime()) 
      com.Parameters.AddWithValue("@DATE_", B.DATE_);
else 
       com.Parameters.AddWithValue("@DATE_", DBNull.Value);
 try { com.Parameters.AddWithValue("@FTIME", B.FTIME); } catch {  com.Parameters.AddWithValue("@FTIME",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DOCODE", B.DOCODE); } catch {  com.Parameters.AddWithValue("@DOCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INVNO", B.INVNO); } catch {  com.Parameters.AddWithValue("@INVNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE", B.SPECODE); } catch {  com.Parameters.AddWithValue("@SPECODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CYPHCODE", B.CYPHCODE); } catch {  com.Parameters.AddWithValue("@CYPHCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INVOICEREF", B.INVOICEREF); } catch {  com.Parameters.AddWithValue("@INVOICEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLIENTREF", B.CLIENTREF); } catch {  com.Parameters.AddWithValue("@CLIENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECVREF", B.RECVREF); } catch {  com.Parameters.AddWithValue("@RECVREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTREF", B.ACCOUNTREF); } catch {  com.Parameters.AddWithValue("@ACCOUNTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CENTERREF", B.CENTERREF); } catch {  com.Parameters.AddWithValue("@CENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRODORDERREF", B.PRODORDERREF); } catch {  com.Parameters.AddWithValue("@PRODORDERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PORDERFICHENO", B.PORDERFICHENO); } catch {  com.Parameters.AddWithValue("@PORDERFICHENO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCETYPE", B.SOURCETYPE); } catch {  com.Parameters.AddWithValue("@SOURCETYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEINDEX", B.SOURCEINDEX); } catch {  com.Parameters.AddWithValue("@SOURCEINDEX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEWSREF", B.SOURCEWSREF); } catch {  com.Parameters.AddWithValue("@SOURCEWSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEPOLNREF", B.SOURCEPOLNREF); } catch {  com.Parameters.AddWithValue("@SOURCEPOLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCECOSTGRP", B.SOURCECOSTGRP); } catch {  com.Parameters.AddWithValue("@SOURCECOSTGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTTYPE", B.DESTTYPE); } catch {  com.Parameters.AddWithValue("@DESTTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTINDEX", B.DESTINDEX); } catch {  com.Parameters.AddWithValue("@DESTINDEX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTWSREF", B.DESTWSREF); } catch {  com.Parameters.AddWithValue("@DESTWSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTPOLNREF", B.DESTPOLNREF); } catch {  com.Parameters.AddWithValue("@DESTPOLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTCOSTGRP", B.DESTCOSTGRP); } catch {  com.Parameters.AddWithValue("@DESTCOSTGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FACTORYNR", B.FACTORYNR); } catch {  com.Parameters.AddWithValue("@FACTORYNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BRANCH", B.BRANCH); } catch {  com.Parameters.AddWithValue("@BRANCH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEPARTMENT", B.DEPARTMENT); } catch {  com.Parameters.AddWithValue("@DEPARTMENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COMPBRANCH", B.COMPBRANCH); } catch {  com.Parameters.AddWithValue("@COMPBRANCH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COMPDEPARTMENT", B.COMPDEPARTMENT); } catch {  com.Parameters.AddWithValue("@COMPDEPARTMENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COMPFACTORY", B.COMPFACTORY); } catch {  com.Parameters.AddWithValue("@COMPFACTORY",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRODSTAT", B.PRODSTAT); } catch {  com.Parameters.AddWithValue("@PRODSTAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIR", B.DEVIR); } catch {  com.Parameters.AddWithValue("@DEVIR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLED", B.CANCELLED); } catch {  com.Parameters.AddWithValue("@CANCELLED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BILLED", B.BILLED); } catch {  com.Parameters.AddWithValue("@BILLED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTED", B.ACCOUNTED); } catch {  com.Parameters.AddWithValue("@ACCOUNTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UPDCURR", B.UPDCURR); } catch {  com.Parameters.AddWithValue("@UPDCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INUSE", B.INUSE); } catch {  com.Parameters.AddWithValue("@INUSE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INVKIND", B.INVKIND); } catch {  com.Parameters.AddWithValue("@INVKIND",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDDISCOUNTS", B.ADDDISCOUNTS); } catch {  com.Parameters.AddWithValue("@ADDDISCOUNTS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALDISCOUNTS", B.TOTALDISCOUNTS); } catch {  com.Parameters.AddWithValue("@TOTALDISCOUNTS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALDISCOUNTED", B.TOTALDISCOUNTED); } catch {  com.Parameters.AddWithValue("@TOTALDISCOUNTED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDEXPENSES", B.ADDEXPENSES); } catch {  com.Parameters.AddWithValue("@ADDEXPENSES",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALEXPENSES", B.TOTALEXPENSES); } catch {  com.Parameters.AddWithValue("@TOTALEXPENSES",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALDEPOZITO", B.TOTALDEPOZITO); } catch {  com.Parameters.AddWithValue("@TOTALDEPOZITO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALPROMOTIONS", B.TOTALPROMOTIONS); } catch {  com.Parameters.AddWithValue("@TOTALPROMOTIONS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALVAT", B.TOTALVAT); } catch {  com.Parameters.AddWithValue("@TOTALVAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GROSSTOTAL", B.GROSSTOTAL); } catch {  com.Parameters.AddWithValue("@GROSSTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETTOTAL", B.NETTOTAL); } catch {  com.Parameters.AddWithValue("@NETTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP1", B.GENEXP1); } catch {  com.Parameters.AddWithValue("@GENEXP1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP2", B.GENEXP2); } catch {  com.Parameters.AddWithValue("@GENEXP2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP3", B.GENEXP3); } catch {  com.Parameters.AddWithValue("@GENEXP3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP4", B.GENEXP4); } catch {  com.Parameters.AddWithValue("@GENEXP4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP5", B.GENEXP5); } catch {  com.Parameters.AddWithValue("@GENEXP5",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXP6", B.GENEXP6); } catch {  com.Parameters.AddWithValue("@GENEXP6",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTRATE", B.REPORTRATE); } catch {  com.Parameters.AddWithValue("@REPORTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTNET", B.REPORTNET); } catch {  com.Parameters.AddWithValue("@REPORTNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXTENREF", B.EXTENREF); } catch {  com.Parameters.AddWithValue("@EXTENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYDEFREF", B.PAYDEFREF); } catch {  com.Parameters.AddWithValue("@PAYDEFREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRINTCNT", B.PRINTCNT); } catch {  com.Parameters.AddWithValue("@PRINTCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FICHECNT", B.FICHECNT); } catch {  com.Parameters.AddWithValue("@FICHECNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCFICHEREF", B.ACCFICHEREF); } catch {  com.Parameters.AddWithValue("@ACCFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY", B.CAPIBLOCK_CREATEDBY); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY",  DBNull.Value); }
if (B.CAPIBLOCK_CREADEDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", B.CAPIBLOCK_CREADEDDATE);
else 
       com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR", B.CAPIBLOCK_CREATEDHOUR); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN", B.CAPIBLOCK_CREATEDMIN); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC", B.CAPIBLOCK_CREATEDSEC); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY", B.CAPIBLOCK_MODIFIEDBY); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY",  DBNull.Value); }
if (B.CAPIBLOCK_MODIFIEDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", B.CAPIBLOCK_MODIFIEDDATE);
else 
       com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR", B.CAPIBLOCK_MODIFIEDHOUR); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN", B.CAPIBLOCK_MODIFIEDMIN); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC", B.CAPIBLOCK_MODIFIEDSEC); } catch {  com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SALESMANREF", B.SALESMANREF); } catch {  com.Parameters.AddWithValue("@SALESMANREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLEDACC", B.CANCELLEDACC); } catch {  com.Parameters.AddWithValue("@CANCELLEDACC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SHPTYPCOD", B.SHPTYPCOD); } catch {  com.Parameters.AddWithValue("@SHPTYPCOD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SHPAGNCOD", B.SHPAGNCOD); } catch {  com.Parameters.AddWithValue("@SHPAGNCOD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRACKNR", B.TRACKNR); } catch {  com.Parameters.AddWithValue("@TRACKNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GENEXCTYP", B.GENEXCTYP); } catch {  com.Parameters.AddWithValue("@GENEXCTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINEEXCTYP", B.LINEEXCTYP); } catch {  com.Parameters.AddWithValue("@LINEEXCTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRADINGGRP", B.TRADINGGRP); } catch {  com.Parameters.AddWithValue("@TRADINGGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TEXTINC", B.TEXTINC); } catch {  com.Parameters.AddWithValue("@TEXTINC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SITEID", B.SITEID); } catch {  com.Parameters.AddWithValue("@SITEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECSTATUS", B.RECSTATUS); } catch {  com.Parameters.AddWithValue("@RECSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGICREF", B.ORGLOGICREF); } catch {  com.Parameters.AddWithValue("@ORGLOGICREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@WFSTATUS", B.WFSTATUS); } catch {  com.Parameters.AddWithValue("@WFSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SHIPINFOREF", B.SHIPINFOREF); } catch {  com.Parameters.AddWithValue("@SHIPINFOREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTORDERREF", B.DISTORDERREF); } catch {  com.Parameters.AddWithValue("@DISTORDERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SENDCNT", B.SENDCNT); } catch {  com.Parameters.AddWithValue("@SENDCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DLVCLIENT", B.DLVCLIENT); } catch {  com.Parameters.AddWithValue("@DLVCLIENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DOCTRACKINGNR", B.DOCTRACKINGNR); } catch {  com.Parameters.AddWithValue("@DOCTRACKINGNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXCALC", B.ADDTAXCALC); } catch {  com.Parameters.AddWithValue("@ADDTAXCALC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALADDTAX", B.TOTALADDTAX); } catch {  com.Parameters.AddWithValue("@TOTALADDTAX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UGIRTRACKINGNO", B.UGIRTRACKINGNO); } catch {  com.Parameters.AddWithValue("@UGIRTRACKINGNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QPRODFCREF", B.QPRODFCREF); } catch {  com.Parameters.AddWithValue("@QPRODFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VAACCREF", B.VAACCREF); } catch {  com.Parameters.AddWithValue("@VAACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VACENTERREF", B.VACENTERREF); } catch {  com.Parameters.AddWithValue("@VACENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGOID", B.ORGLOGOID); } catch {  com.Parameters.AddWithValue("@ORGLOGOID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMEXIM", B.FROMEXIM); } catch {  com.Parameters.AddWithValue("@FROMEXIM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FRGTYPCOD", B.FRGTYPCOD); } catch {  com.Parameters.AddWithValue("@FRGTYPCOD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCURR", B.TRCURR); } catch {  com.Parameters.AddWithValue("@TRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRRATE", B.TRRATE); } catch {  com.Parameters.AddWithValue("@TRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRNET", B.TRNET); } catch {  com.Parameters.AddWithValue("@TRNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMWHFCREF", B.EXIMWHFCREF); } catch {  com.Parameters.AddWithValue("@EXIMWHFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFCTYPE", B.EXIMFCTYPE); } catch {  com.Parameters.AddWithValue("@EXIMFCTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MAINSTFCREF", B.MAINSTFCREF); } catch {  com.Parameters.AddWithValue("@MAINSTFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMORDWITHPAY", B.FROMORDWITHPAY); } catch {  com.Parameters.AddWithValue("@FROMORDWITHPAY",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROJECTREF", B.PROJECTREF); } catch {  com.Parameters.AddWithValue("@PROJECTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@WFLOWCRDREF", B.WFLOWCRDREF); } catch {  com.Parameters.AddWithValue("@WFLOWCRDREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STATUS", B.STATUS); } catch {  com.Parameters.AddWithValue("@STATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UPDTRCURR", B.UPDTRCURR); } catch {  com.Parameters.AddWithValue("@UPDTRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALEXADDTAX", B.TOTALEXADDTAX); } catch {  com.Parameters.AddWithValue("@TOTALEXADDTAX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTCOLLATRL", B.AFFECTCOLLATRL); } catch {  com.Parameters.AddWithValue("@AFFECTCOLLATRL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART1", B.DEDUCTIONPART1); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART2", B.DEDUCTIONPART2); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GRPFIRMTRANS", B.GRPFIRMTRANS); } catch {  com.Parameters.AddWithValue("@GRPFIRMTRANS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTRISK", B.AFFECTRISK); } catch {  com.Parameters.AddWithValue("@AFFECTRISK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISPSTATUS", B.DISPSTATUS); } catch {  com.Parameters.AddWithValue("@DISPSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@APPROVE", B.APPROVE); } catch {  com.Parameters.AddWithValue("@APPROVE",  DBNull.Value); }
if (B.APPROVEDATE != new DateTime()) 
      com.Parameters.AddWithValue("@APPROVEDATE", B.APPROVEDATE);
else 
       com.Parameters.AddWithValue("@APPROVEDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CANTCREDEDUCT", B.CANTCREDEDUCT); } catch {  com.Parameters.AddWithValue("@CANTCREDEDUCT",  DBNull.Value); }
if (B.SHIPDATE != new DateTime()) 
      com.Parameters.AddWithValue("@SHIPDATE", B.SHIPDATE);
else 
       com.Parameters.AddWithValue("@SHIPDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@SHIPTIME", B.SHIPTIME); } catch {  com.Parameters.AddWithValue("@SHIPTIME",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ENTRUSTDEVIR", B.ENTRUSTDEVIR); } catch {  com.Parameters.AddWithValue("@ENTRUSTDEVIR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RELTRANSFCREF", B.RELTRANSFCREF); } catch {  com.Parameters.AddWithValue("@RELTRANSFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMTRANSFER", B.FROMTRANSFER); } catch {  com.Parameters.AddWithValue("@FROMTRANSFER",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GUID", B.GUID); } catch {  com.Parameters.AddWithValue("@GUID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GLOBALID", B.GLOBALID); } catch {  com.Parameters.AddWithValue("@GLOBALID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COMPSTFCREF", B.COMPSTFCREF); } catch {  com.Parameters.AddWithValue("@COMPSTFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COMPINVREF", B.COMPINVREF); } catch {  com.Parameters.AddWithValue("@COMPINVREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTALSERVICES", B.TOTALSERVICES); } catch {  com.Parameters.AddWithValue("@TOTALSERVICES",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNCODE", B.CAMPAIGNCODE); } catch {  com.Parameters.AddWithValue("@CAMPAIGNCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OFFERREF", B.OFFERREF); } catch {  com.Parameters.AddWithValue("@OFFERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EINVOICETYP", B.EINVOICETYP); } catch {  com.Parameters.AddWithValue("@EINVOICETYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EINVOICE", B.EINVOICE); } catch {  com.Parameters.AddWithValue("@EINVOICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NOCALCULATE", B.NOCALCULATE); } catch {  com.Parameters.AddWithValue("@NOCALCULATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRODORDERTYP", B.PRODORDERTYP); } catch {  com.Parameters.AddWithValue("@PRODORDERTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QPRODFCTYP", B.QPRODFCTYP); } catch {  com.Parameters.AddWithValue("@QPRODFCTYP",  DBNull.Value); }
if (B.PRINTDATE != new DateTime()) 
      com.Parameters.AddWithValue("@PRINTDATE", B.PRINTDATE);
else 
       com.Parameters.AddWithValue("@PRINTDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@PRDORDSLPLNRESERVE", B.PRDORDSLPLNRESERVE); } catch {  com.Parameters.AddWithValue("@PRDORDSLPLNRESERVE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CONTROLINFO", B.CONTROLINFO); } catch {  com.Parameters.AddWithValue("@CONTROLINFO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EDESPATCH", B.EDESPATCH); } catch {  com.Parameters.AddWithValue("@EDESPATCH",  DBNull.Value); }
if (B.DOCDATE != new DateTime()) 
      com.Parameters.AddWithValue("@DOCDATE", B.DOCDATE);
else 
       com.Parameters.AddWithValue("@DOCDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@DOCTIME", B.DOCTIME); } catch {  com.Parameters.AddWithValue("@DOCTIME",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EDESPSTATUS", B.EDESPSTATUS); } catch {  com.Parameters.AddWithValue("@EDESPSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROFILEID", B.PROFILEID); } catch {  com.Parameters.AddWithValue("@PROFILEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DELIVERYCODE", B.DELIVERYCODE); } catch {  com.Parameters.AddWithValue("@DELIVERYCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTSTATUS", B.DESTSTATUS); } catch {  com.Parameters.AddWithValue("@DESTSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELEXP", B.CANCELEXP); } catch {  com.Parameters.AddWithValue("@CANCELEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UNDOEXP", B.UNDOEXP); } catch {  com.Parameters.AddWithValue("@UNDOEXP",  DBNull.Value); }
if (B.CANCELDATE != new DateTime()) 
      com.Parameters.AddWithValue("@CANCELDATE", B.CANCELDATE);
else 
       com.Parameters.AddWithValue("@CANCELDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@CREATEWHERE", B.CREATEWHERE); } catch {  com.Parameters.AddWithValue("@CREATEWHERE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PUBLICBNACCREF", B.PUBLICBNACCREF); } catch {  com.Parameters.AddWithValue("@PUBLICBNACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCEPTEINVPUBLIC", B.ACCEPTEINVPUBLIC); } catch {  com.Parameters.AddWithValue("@ACCEPTEINVPUBLIC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATEXCEPTCODE", B.VATEXCEPTCODE); } catch {  com.Parameters.AddWithValue("@VATEXCEPTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATEXCEPTREASON", B.VATEXCEPTREASON); } catch {  com.Parameters.AddWithValue("@VATEXCEPTREASON",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ATAXEXCEPTCODE", B.ATAXEXCEPTCODE); } catch {  com.Parameters.AddWithValue("@ATAXEXCEPTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ATAXEXCEPTREASON", B.ATAXEXCEPTREASON); } catch {  com.Parameters.AddWithValue("@ATAXEXCEPTREASON",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TAXFREECHX", B.TAXFREECHX); } catch {  com.Parameters.AddWithValue("@TAXFREECHX",  DBNull.Value); }
 
      com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

      return com;
   }
   catch
   {
      return null;
   }
}

public SqlCommand BM_XXX_XX_STLINE_UPDATE(BM_XXX_XX_STLINE B, bool UPDATEBM, bool UPDATELOGICALREF ,string FIRMNR ,string PERIODNR, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BM_XXX_XX_STLINE";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") .Replace("XXX", FIRMNR) 
.Replace("XX", PERIODNR); 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " STOCKREF = @STOCKREF, LINETYPE = @LINETYPE, PREVLINEREF = @PREVLINEREF, PREVLINENO = @PREVLINENO, DETLINE = @DETLINE, TRCODE = @TRCODE, DATE_ = @DATE_, FTIME = @FTIME, GLOBTRANS = @GLOBTRANS, CALCTYPE = @CALCTYPE, PRODORDERREF = @PRODORDERREF, SOURCETYPE = @SOURCETYPE, SOURCEINDEX = @SOURCEINDEX, SOURCECOSTGRP = @SOURCECOSTGRP, SOURCEWSREF = @SOURCEWSREF, SOURCEPOLNREF = @SOURCEPOLNREF, DESTTYPE = @DESTTYPE, DESTINDEX = @DESTINDEX, DESTCOSTGRP = @DESTCOSTGRP, DESTWSREF = @DESTWSREF, DESTPOLNREF = @DESTPOLNREF, FACTORYNR = @FACTORYNR, IOCODE = @IOCODE, STFICHEREF = @STFICHEREF, STFICHELNNO = @STFICHELNNO, INVOICEREF = @INVOICEREF, INVOICELNNO = @INVOICELNNO, CLIENTREF = @CLIENTREF, ORDTRANSREF = @ORDTRANSREF, ORDFICHEREF = @ORDFICHEREF, CENTERREF = @CENTERREF, ACCOUNTREF = @ACCOUNTREF, VATACCREF = @VATACCREF, VATCENTERREF = @VATCENTERREF, PRACCREF = @PRACCREF, PRCENTERREF = @PRCENTERREF, PRVATACCREF = @PRVATACCREF, PRVATCENREF = @PRVATCENREF, PROMREF = @PROMREF, PAYDEFREF = @PAYDEFREF, SPECODE = @SPECODE, DELVRYCODE = @DELVRYCODE, AMOUNT = @AMOUNT, PRICE = @PRICE, TOTAL = @TOTAL, PRCURR = @PRCURR, PRPRICE = @PRPRICE, TRCURR = @TRCURR, TRRATE = @TRRATE, REPORTRATE = @REPORTRATE, DISTCOST = @DISTCOST, DISTDISC = @DISTDISC, DISTEXP = @DISTEXP, DISTPROM = @DISTPROM, DISCPER = @DISCPER, LINEEXP = @LINEEXP, UOMREF = @UOMREF, USREF = @USREF, UINFO1 = @UINFO1, UINFO2 = @UINFO2, UINFO3 = @UINFO3, UINFO4 = @UINFO4, UINFO5 = @UINFO5, UINFO6 = @UINFO6, UINFO7 = @UINFO7, UINFO8 = @UINFO8, PLNAMOUNT = @PLNAMOUNT, VATINC = @VATINC, VAT = @VAT, VATAMNT = @VATAMNT, VATMATRAH = @VATMATRAH, BILLEDITEM = @BILLEDITEM, BILLED = @BILLED, CPSTFLAG = @CPSTFLAG, RETCOSTTYPE = @RETCOSTTYPE, SOURCELINK = @SOURCELINK, RETCOST = @RETCOST, RETCOSTCURR = @RETCOSTCURR, OUTCOST = @OUTCOST, OUTCOSTCURR = @OUTCOSTCURR, RETAMOUNT = @RETAMOUNT, FAREGREF = @FAREGREF, FAATTRIB = @FAATTRIB, CANCELLED = @CANCELLED, LINENET = @LINENET, DISTADDEXP = @DISTADDEXP, FADACCREF = @FADACCREF, FADCENTERREF = @FADCENTERREF, FARACCREF = @FARACCREF, FARCENTERREF = @FARCENTERREF, DIFFPRICE = @DIFFPRICE, DIFFPRCOST = @DIFFPRCOST, DECPRDIFF = @DECPRDIFF, LPRODSTAT = @LPRODSTAT, PRDEXPTOTAL = @PRDEXPTOTAL, DIFFREPPRICE = @DIFFREPPRICE, DIFFPRCRCOST = @DIFFPRCRCOST, SALESMANREF = @SALESMANREF, FAPLACCREF = @FAPLACCREF, FAPLCENTERREF = @FAPLCENTERREF, OUTPUTIDCODE = @OUTPUTIDCODE, DREF = @DREF, COSTRATE = @COSTRATE, XPRICEUPD = @XPRICEUPD, XPRICE = @XPRICE, XREPRATE = @XREPRATE, DISTCOEF = @DISTCOEF, TRANSQCOK = @TRANSQCOK, SITEID = @SITEID, RECSTATUS = @RECSTATUS, ORGLOGICREF = @ORGLOGICREF, WFSTATUS = @WFSTATUS, POLINEREF = @POLINEREF, PLNSTTRANSREF = @PLNSTTRANSREF, NETDISCFLAG = @NETDISCFLAG, NETDISCPERC = @NETDISCPERC, NETDISCAMNT = @NETDISCAMNT, VATCALCDIFF = @VATCALCDIFF, CONDITIONREF = @CONDITIONREF, DISTORDERREF = @DISTORDERREF, DISTORDLINEREF = @DISTORDLINEREF, CAMPAIGNREFS1 = @CAMPAIGNREFS1, CAMPAIGNREFS2 = @CAMPAIGNREFS2, CAMPAIGNREFS3 = @CAMPAIGNREFS3, CAMPAIGNREFS4 = @CAMPAIGNREFS4, CAMPAIGNREFS5 = @CAMPAIGNREFS5, POINTCAMPREF = @POINTCAMPREF, CAMPPOINT = @CAMPPOINT, PROMCLASITEMREF = @PROMCLASITEMREF, CMPGLINEREF = @CMPGLINEREF, PLNSTTRANSPERNR = @PLNSTTRANSPERNR, PORDCLSPLNAMNT = @PORDCLSPLNAMNT, VENDCOMM = @VENDCOMM, PREVIOUSOUTCOST = @PREVIOUSOUTCOST, COSTOFSALEACCREF = @COSTOFSALEACCREF, PURCHACCREF = @PURCHACCREF, COSTOFSALECNTREF = @COSTOFSALECNTREF, PURCHCENTREF = @PURCHCENTREF, PREVOUTCOSTCURR = @PREVOUTCOSTCURR, ABVATAMOUNT = @ABVATAMOUNT, ABVATSTATUS = @ABVATSTATUS, PRRATE = @PRRATE, ADDTAXRATE = @ADDTAXRATE, ADDTAXCONVFACT = @ADDTAXCONVFACT, ADDTAXAMOUNT = @ADDTAXAMOUNT, ADDTAXPRCOST = @ADDTAXPRCOST, ADDTAXRETCOST = @ADDTAXRETCOST, ADDTAXRETCOSTCURR = @ADDTAXRETCOSTCURR, GROSSUINFO1 = @GROSSUINFO1, GROSSUINFO2 = @GROSSUINFO2, ADDTAXPRCOSTCURR = @ADDTAXPRCOSTCURR, ADDTAXACCREF = @ADDTAXACCREF, ADDTAXCENTERREF = @ADDTAXCENTERREF, ADDTAXAMNTISUPD = @ADDTAXAMNTISUPD, INFIDX = @INFIDX, ADDTAXCOSACCREF = @ADDTAXCOSACCREF, ADDTAXCOSCNTREF = @ADDTAXCOSCNTREF, PREVIOUSATAXPRCOST = @PREVIOUSATAXPRCOST, PREVATAXPRCOSTCURR = @PREVATAXPRCOSTCURR, PRDORDTOTCOEF = @PRDORDTOTCOEF, DEMPEGGEDAMNT = @DEMPEGGEDAMNT, STDUNITCOST = @STDUNITCOST, STDRPUNITCOST = @STDRPUNITCOST, COSTDIFFACCREF = @COSTDIFFACCREF, COSTDIFFCENREF = @COSTDIFFCENREF, TEXTINC = @TEXTINC, ADDTAXDISCAMOUNT = @ADDTAXDISCAMOUNT, ORGLOGOID = @ORGLOGOID, EXIMFICHENO = @EXIMFICHENO, EXIMFCTYPE = @EXIMFCTYPE, TRANSEXPLINE = @TRANSEXPLINE, INSEXPLINE = @INSEXPLINE, EXIMWHFCREF = @EXIMWHFCREF, EXIMWHLNREF = @EXIMWHLNREF, EXIMFILEREF = @EXIMFILEREF, EXIMPROCNR = @EXIMPROCNR, EISRVDSTTYP = @EISRVDSTTYP, MAINSTLNREF = @MAINSTLNREF, MADEOFSHRED = @MADEOFSHRED, FROMORDWITHPAY = @FROMORDWITHPAY, PROJECTREF = @PROJECTREF, STATUS = @STATUS, DORESERVE = @DORESERVE, POINTCAMPREFS1 = @POINTCAMPREFS1, POINTCAMPREFS2 = @POINTCAMPREFS2, POINTCAMPREFS3 = @POINTCAMPREFS3, POINTCAMPREFS4 = @POINTCAMPREFS4, CAMPPOINTS1 = @CAMPPOINTS1, CAMPPOINTS2 = @CAMPPOINTS2, CAMPPOINTS3 = @CAMPPOINTS3, CAMPPOINTS4 = @CAMPPOINTS4, CMPGLINEREFS1 = @CMPGLINEREFS1, CMPGLINEREFS2 = @CMPGLINEREFS2, CMPGLINEREFS3 = @CMPGLINEREFS3, CMPGLINEREFS4 = @CMPGLINEREFS4, PRCLISTREF = @PRCLISTREF, PORDSYMOUTLN = @PORDSYMOUTLN, MONTH_ = @MONTH_, YEAR_ = @YEAR_, EXADDTAXRATE = @EXADDTAXRATE, EXADDTAXCONVF = @EXADDTAXCONVF, EXADDTAXAREF = @EXADDTAXAREF, EXADDTAXCREF = @EXADDTAXCREF, OTHRADDTAXAREF = @OTHRADDTAXAREF, OTHRADDTAXCREF = @OTHRADDTAXCREF, EXADDTAXAMNT = @EXADDTAXAMNT, AFFECTCOLLATRL = @AFFECTCOLLATRL, ALTPROMFLAG = @ALTPROMFLAG, EIDISTFLNNR = @EIDISTFLNNR, EXIMTYPE = @EXIMTYPE, VARIANTREF = @VARIANTREF, CANDEDUCT = @CANDEDUCT, OUTREMAMNT = @OUTREMAMNT, OUTREMCOST = @OUTREMCOST, OUTREMCOSTCURR = @OUTREMCOSTCURR, REFLVATACCREF = @REFLVATACCREF, REFLVATOTHACCREF = @REFLVATOTHACCREF, PARENTLNREF = @PARENTLNREF, AFFECTRISK = @AFFECTRISK, INEFFECTIVECOST = @INEFFECTIVECOST, ADDTAXVATMATRAH = @ADDTAXVATMATRAH, REFLACCREF = @REFLACCREF, REFLOTHACCREF = @REFLOTHACCREF, CAMPPAYDEFREF = @CAMPPAYDEFREF, FAREGBINDDATE = @FAREGBINDDATE, RELTRANSLNREF = @RELTRANSLNREF, FROMTRANSFER = @FROMTRANSFER, COSTDISTPRICE = @COSTDISTPRICE, COSTDISTREPPRICE = @COSTDISTREPPRICE, DIFFPRICEUFRS = @DIFFPRICEUFRS, DIFFREPPRICEUFRS = @DIFFREPPRICEUFRS, OUTCOSTUFRS = @OUTCOSTUFRS, OUTCOSTCURRUFRS = @OUTCOSTCURRUFRS, DIFFPRCOSTUFRS = @DIFFPRCOSTUFRS, DIFFPRCRCOSTUFRS = @DIFFPRCRCOSTUFRS, RETCOSTUFRS = @RETCOSTUFRS, RETCOSTCURRUFRS = @RETCOSTCURRUFRS, OUTREMCOSTUFRS = @OUTREMCOSTUFRS, OUTREMCOSTCURRUFRS = @OUTREMCOSTCURRUFRS, INFIDXUFRS = @INFIDXUFRS, ADJPRICEUFRS = @ADJPRICEUFRS, ADJREPPRICEUFRS = @ADJREPPRICEUFRS, ADJPRCOSTUFRS = @ADJPRCOSTUFRS, ADJPRCRCOSTUFRS = @ADJPRCRCOSTUFRS, COSTDISTPRICEUFRS = @COSTDISTPRICEUFRS, COSTDISTREPPRICEUFRS = @COSTDISTREPPRICEUFRS, PURCHACCREFUFRS = @PURCHACCREFUFRS, PURCHCENTREFUFRS = @PURCHCENTREFUFRS, COSACCREFUFRS = @COSACCREFUFRS, COSCNTREFUFRS = @COSCNTREFUFRS, PROUTCOSTUFRSDIFF = @PROUTCOSTUFRSDIFF, PROUTCOSTCRUFRSDIFF = @PROUTCOSTCRUFRSDIFF, UNDERDEDUCTLIMIT = @UNDERDEDUCTLIMIT, GLOBALID = @GLOBALID, DEDUCTIONPART1 = @DEDUCTIONPART1, DEDUCTIONPART2 = @DEDUCTIONPART2, GUID = @GUID, SPECODE2 = @SPECODE2, OFFERREF = @OFFERREF, OFFTRANSREF = @OFFTRANSREF, VATEXCEPTREASON = @VATEXCEPTREASON, PLNDEFSERILOTNO = @PLNDEFSERILOTNO, PLNUNRSRVAMOUNT = @PLNUNRSRVAMOUNT, PORDCLSPLNUNRSRVAMNT = @PORDCLSPLNUNRSRVAMNT, LPRODRSRVSTAT = @LPRODRSRVSTAT, FALINKTYPE = @FALINKTYPE, DEDUCTCODE = @DEDUCTCODE, UPDTHISLINE = @UPDTHISLINE, VATEXCEPTCODE = @VATEXCEPTCODE, PORDERFICHENO = @PORDERFICHENO, QPRODFCREF = @QPRODFCREF, RELTRANSFCREF = @RELTRANSFCREF, ATAXEXCEPTREASON = @ATAXEXCEPTREASON, ATAXEXCEPTCODE = @ATAXEXCEPTCODE, PRODORDERTYP = @PRODORDERTYP, SUBCONTORDERREF = @SUBCONTORDERREF, QPRODFCTYP = @QPRODFCTYP, PRDORDSLPLNRESERVE = @PRDORDSLPLNRESERVE, INFDATE = @INFDATE, DESTSTATUS = @DESTSTATUS, REGTYPREF = @REGTYPREF, FAPROFITACCREF = @FAPROFITACCREF, FAPROFITCENTREF = @FAPROFITCENTREF, FALOSSACCREF = @FALOSSACCREF, FALOSSCENTREF = @FALOSSCENTREF, CPACODE = @CPACODE, GTIPCODE = @GTIPCODE, PUBLICCOUNTRYREF = @PUBLICCOUNTRYREF, QPRODITEMTYPE = @QPRODITEMTYPE, FUTMONTHCNT = @FUTMONTHCNT, FUTMONTHBEGDATE = @FUTMONTHBEGDATE, QCTRANSFERREF = @QCTRANSFERREF, QCTRANSFERAMNT = @QCTRANSFERAMNT, FUTMONTHENDDATE = @FUTMONTHENDDATE  WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STOCKREF", B.STOCKREF); } catch {  com.Parameters.AddWithValue("@STOCKREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINETYPE", B.LINETYPE); } catch {  com.Parameters.AddWithValue("@LINETYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PREVLINEREF", B.PREVLINEREF); } catch {  com.Parameters.AddWithValue("@PREVLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PREVLINENO", B.PREVLINENO); } catch {  com.Parameters.AddWithValue("@PREVLINENO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DETLINE", B.DETLINE); } catch {  com.Parameters.AddWithValue("@DETLINE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCODE", B.TRCODE); } catch {  com.Parameters.AddWithValue("@TRCODE",  DBNull.Value); }
if (B.DATE_ != new DateTime()) 
      com.Parameters.AddWithValue("@DATE_", B.DATE_);
else 
       com.Parameters.AddWithValue("@DATE_", DBNull.Value);
 try { com.Parameters.AddWithValue("@FTIME", B.FTIME); } catch {  com.Parameters.AddWithValue("@FTIME",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GLOBTRANS", B.GLOBTRANS); } catch {  com.Parameters.AddWithValue("@GLOBTRANS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CALCTYPE", B.CALCTYPE); } catch {  com.Parameters.AddWithValue("@CALCTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRODORDERREF", B.PRODORDERREF); } catch {  com.Parameters.AddWithValue("@PRODORDERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCETYPE", B.SOURCETYPE); } catch {  com.Parameters.AddWithValue("@SOURCETYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEINDEX", B.SOURCEINDEX); } catch {  com.Parameters.AddWithValue("@SOURCEINDEX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCECOSTGRP", B.SOURCECOSTGRP); } catch {  com.Parameters.AddWithValue("@SOURCECOSTGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEWSREF", B.SOURCEWSREF); } catch {  com.Parameters.AddWithValue("@SOURCEWSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCEPOLNREF", B.SOURCEPOLNREF); } catch {  com.Parameters.AddWithValue("@SOURCEPOLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTTYPE", B.DESTTYPE); } catch {  com.Parameters.AddWithValue("@DESTTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTINDEX", B.DESTINDEX); } catch {  com.Parameters.AddWithValue("@DESTINDEX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTCOSTGRP", B.DESTCOSTGRP); } catch {  com.Parameters.AddWithValue("@DESTCOSTGRP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTWSREF", B.DESTWSREF); } catch {  com.Parameters.AddWithValue("@DESTWSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DESTPOLNREF", B.DESTPOLNREF); } catch {  com.Parameters.AddWithValue("@DESTPOLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FACTORYNR", B.FACTORYNR); } catch {  com.Parameters.AddWithValue("@FACTORYNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@IOCODE", B.IOCODE); } catch {  com.Parameters.AddWithValue("@IOCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STFICHEREF", B.STFICHEREF); } catch {  com.Parameters.AddWithValue("@STFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STFICHELNNO", B.STFICHELNNO); } catch {  com.Parameters.AddWithValue("@STFICHELNNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INVOICEREF", B.INVOICEREF); } catch {  com.Parameters.AddWithValue("@INVOICEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INVOICELNNO", B.INVOICELNNO); } catch {  com.Parameters.AddWithValue("@INVOICELNNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLIENTREF", B.CLIENTREF); } catch {  com.Parameters.AddWithValue("@CLIENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORDTRANSREF", B.ORDTRANSREF); } catch {  com.Parameters.AddWithValue("@ORDTRANSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORDFICHEREF", B.ORDFICHEREF); } catch {  com.Parameters.AddWithValue("@ORDFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CENTERREF", B.CENTERREF); } catch {  com.Parameters.AddWithValue("@CENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACCOUNTREF", B.ACCOUNTREF); } catch {  com.Parameters.AddWithValue("@ACCOUNTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATACCREF", B.VATACCREF); } catch {  com.Parameters.AddWithValue("@VATACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATCENTERREF", B.VATCENTERREF); } catch {  com.Parameters.AddWithValue("@VATCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRACCREF", B.PRACCREF); } catch {  com.Parameters.AddWithValue("@PRACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRCENTERREF", B.PRCENTERREF); } catch {  com.Parameters.AddWithValue("@PRCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRVATACCREF", B.PRVATACCREF); } catch {  com.Parameters.AddWithValue("@PRVATACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRVATCENREF", B.PRVATCENREF); } catch {  com.Parameters.AddWithValue("@PRVATCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROMREF", B.PROMREF); } catch {  com.Parameters.AddWithValue("@PROMREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYDEFREF", B.PAYDEFREF); } catch {  com.Parameters.AddWithValue("@PAYDEFREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE", B.SPECODE); } catch {  com.Parameters.AddWithValue("@SPECODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DELVRYCODE", B.DELVRYCODE); } catch {  com.Parameters.AddWithValue("@DELVRYCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AMOUNT", B.AMOUNT); } catch {  com.Parameters.AddWithValue("@AMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRICE", B.PRICE); } catch {  com.Parameters.AddWithValue("@PRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTAL", B.TOTAL); } catch {  com.Parameters.AddWithValue("@TOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRCURR", B.PRCURR); } catch {  com.Parameters.AddWithValue("@PRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRPRICE", B.PRPRICE); } catch {  com.Parameters.AddWithValue("@PRPRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCURR", B.TRCURR); } catch {  com.Parameters.AddWithValue("@TRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRRATE", B.TRRATE); } catch {  com.Parameters.AddWithValue("@TRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTRATE", B.REPORTRATE); } catch {  com.Parameters.AddWithValue("@REPORTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTCOST", B.DISTCOST); } catch {  com.Parameters.AddWithValue("@DISTCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTDISC", B.DISTDISC); } catch {  com.Parameters.AddWithValue("@DISTDISC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTEXP", B.DISTEXP); } catch {  com.Parameters.AddWithValue("@DISTEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTPROM", B.DISTPROM); } catch {  com.Parameters.AddWithValue("@DISTPROM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISCPER", B.DISCPER); } catch {  com.Parameters.AddWithValue("@DISCPER",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINEEXP", B.LINEEXP); } catch {  com.Parameters.AddWithValue("@LINEEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UOMREF", B.UOMREF); } catch {  com.Parameters.AddWithValue("@UOMREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@USREF", B.USREF); } catch {  com.Parameters.AddWithValue("@USREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO1", B.UINFO1); } catch {  com.Parameters.AddWithValue("@UINFO1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO2", B.UINFO2); } catch {  com.Parameters.AddWithValue("@UINFO2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO3", B.UINFO3); } catch {  com.Parameters.AddWithValue("@UINFO3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO4", B.UINFO4); } catch {  com.Parameters.AddWithValue("@UINFO4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO5", B.UINFO5); } catch {  com.Parameters.AddWithValue("@UINFO5",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO6", B.UINFO6); } catch {  com.Parameters.AddWithValue("@UINFO6",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO7", B.UINFO7); } catch {  com.Parameters.AddWithValue("@UINFO7",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UINFO8", B.UINFO8); } catch {  com.Parameters.AddWithValue("@UINFO8",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PLNAMOUNT", B.PLNAMOUNT); } catch {  com.Parameters.AddWithValue("@PLNAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATINC", B.VATINC); } catch {  com.Parameters.AddWithValue("@VATINC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VAT", B.VAT); } catch {  com.Parameters.AddWithValue("@VAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATAMNT", B.VATAMNT); } catch {  com.Parameters.AddWithValue("@VATAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATMATRAH", B.VATMATRAH); } catch {  com.Parameters.AddWithValue("@VATMATRAH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BILLEDITEM", B.BILLEDITEM); } catch {  com.Parameters.AddWithValue("@BILLEDITEM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BILLED", B.BILLED); } catch {  com.Parameters.AddWithValue("@BILLED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CPSTFLAG", B.CPSTFLAG); } catch {  com.Parameters.AddWithValue("@CPSTFLAG",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETCOSTTYPE", B.RETCOSTTYPE); } catch {  com.Parameters.AddWithValue("@RETCOSTTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SOURCELINK", B.SOURCELINK); } catch {  com.Parameters.AddWithValue("@SOURCELINK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETCOST", B.RETCOST); } catch {  com.Parameters.AddWithValue("@RETCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETCOSTCURR", B.RETCOSTCURR); } catch {  com.Parameters.AddWithValue("@RETCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTCOST", B.OUTCOST); } catch {  com.Parameters.AddWithValue("@OUTCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTCOSTCURR", B.OUTCOSTCURR); } catch {  com.Parameters.AddWithValue("@OUTCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETAMOUNT", B.RETAMOUNT); } catch {  com.Parameters.AddWithValue("@RETAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FAREGREF", B.FAREGREF); } catch {  com.Parameters.AddWithValue("@FAREGREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FAATTRIB", B.FAATTRIB); } catch {  com.Parameters.AddWithValue("@FAATTRIB",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLED", B.CANCELLED); } catch {  com.Parameters.AddWithValue("@CANCELLED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINENET", B.LINENET); } catch {  com.Parameters.AddWithValue("@LINENET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTADDEXP", B.DISTADDEXP); } catch {  com.Parameters.AddWithValue("@DISTADDEXP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FADACCREF", B.FADACCREF); } catch {  com.Parameters.AddWithValue("@FADACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FADCENTERREF", B.FADCENTERREF); } catch {  com.Parameters.AddWithValue("@FADCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FARACCREF", B.FARACCREF); } catch {  com.Parameters.AddWithValue("@FARACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FARCENTERREF", B.FARCENTERREF); } catch {  com.Parameters.AddWithValue("@FARCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFPRICE", B.DIFFPRICE); } catch {  com.Parameters.AddWithValue("@DIFFPRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFPRCOST", B.DIFFPRCOST); } catch {  com.Parameters.AddWithValue("@DIFFPRCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DECPRDIFF", B.DECPRDIFF); } catch {  com.Parameters.AddWithValue("@DECPRDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LPRODSTAT", B.LPRODSTAT); } catch {  com.Parameters.AddWithValue("@LPRODSTAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRDEXPTOTAL", B.PRDEXPTOTAL); } catch {  com.Parameters.AddWithValue("@PRDEXPTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFREPPRICE", B.DIFFREPPRICE); } catch {  com.Parameters.AddWithValue("@DIFFREPPRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFPRCRCOST", B.DIFFPRCRCOST); } catch {  com.Parameters.AddWithValue("@DIFFPRCRCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SALESMANREF", B.SALESMANREF); } catch {  com.Parameters.AddWithValue("@SALESMANREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FAPLACCREF", B.FAPLACCREF); } catch {  com.Parameters.AddWithValue("@FAPLACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FAPLCENTERREF", B.FAPLCENTERREF); } catch {  com.Parameters.AddWithValue("@FAPLCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTPUTIDCODE", B.OUTPUTIDCODE); } catch {  com.Parameters.AddWithValue("@OUTPUTIDCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DREF", B.DREF); } catch {  com.Parameters.AddWithValue("@DREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTRATE", B.COSTRATE); } catch {  com.Parameters.AddWithValue("@COSTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@XPRICEUPD", B.XPRICEUPD); } catch {  com.Parameters.AddWithValue("@XPRICEUPD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@XPRICE", B.XPRICE); } catch {  com.Parameters.AddWithValue("@XPRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@XREPRATE", B.XREPRATE); } catch {  com.Parameters.AddWithValue("@XREPRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTCOEF", B.DISTCOEF); } catch {  com.Parameters.AddWithValue("@DISTCOEF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRANSQCOK", B.TRANSQCOK); } catch {  com.Parameters.AddWithValue("@TRANSQCOK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SITEID", B.SITEID); } catch {  com.Parameters.AddWithValue("@SITEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECSTATUS", B.RECSTATUS); } catch {  com.Parameters.AddWithValue("@RECSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGICREF", B.ORGLOGICREF); } catch {  com.Parameters.AddWithValue("@ORGLOGICREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@WFSTATUS", B.WFSTATUS); } catch {  com.Parameters.AddWithValue("@WFSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POLINEREF", B.POLINEREF); } catch {  com.Parameters.AddWithValue("@POLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PLNSTTRANSREF", B.PLNSTTRANSREF); } catch {  com.Parameters.AddWithValue("@PLNSTTRANSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETDISCFLAG", B.NETDISCFLAG); } catch {  com.Parameters.AddWithValue("@NETDISCFLAG",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETDISCPERC", B.NETDISCPERC); } catch {  com.Parameters.AddWithValue("@NETDISCPERC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETDISCAMNT", B.NETDISCAMNT); } catch {  com.Parameters.AddWithValue("@NETDISCAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATCALCDIFF", B.VATCALCDIFF); } catch {  com.Parameters.AddWithValue("@VATCALCDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CONDITIONREF", B.CONDITIONREF); } catch {  com.Parameters.AddWithValue("@CONDITIONREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTORDERREF", B.DISTORDERREF); } catch {  com.Parameters.AddWithValue("@DISTORDERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISTORDLINEREF", B.DISTORDLINEREF); } catch {  com.Parameters.AddWithValue("@DISTORDLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNREFS1", B.CAMPAIGNREFS1); } catch {  com.Parameters.AddWithValue("@CAMPAIGNREFS1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNREFS2", B.CAMPAIGNREFS2); } catch {  com.Parameters.AddWithValue("@CAMPAIGNREFS2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNREFS3", B.CAMPAIGNREFS3); } catch {  com.Parameters.AddWithValue("@CAMPAIGNREFS3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNREFS4", B.CAMPAIGNREFS4); } catch {  com.Parameters.AddWithValue("@CAMPAIGNREFS4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPAIGNREFS5", B.CAMPAIGNREFS5); } catch {  com.Parameters.AddWithValue("@CAMPAIGNREFS5",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCAMPREF", B.POINTCAMPREF); } catch {  com.Parameters.AddWithValue("@POINTCAMPREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPPOINT", B.CAMPPOINT); } catch {  com.Parameters.AddWithValue("@CAMPPOINT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROMCLASITEMREF", B.PROMCLASITEMREF); } catch {  com.Parameters.AddWithValue("@PROMCLASITEMREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CMPGLINEREF", B.CMPGLINEREF); } catch {  com.Parameters.AddWithValue("@CMPGLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PLNSTTRANSPERNR", B.PLNSTTRANSPERNR); } catch {  com.Parameters.AddWithValue("@PLNSTTRANSPERNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PORDCLSPLNAMNT", B.PORDCLSPLNAMNT); } catch {  com.Parameters.AddWithValue("@PORDCLSPLNAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VENDCOMM", B.VENDCOMM); } catch {  com.Parameters.AddWithValue("@VENDCOMM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PREVIOUSOUTCOST", B.PREVIOUSOUTCOST); } catch {  com.Parameters.AddWithValue("@PREVIOUSOUTCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTOFSALEACCREF", B.COSTOFSALEACCREF); } catch {  com.Parameters.AddWithValue("@COSTOFSALEACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PURCHACCREF", B.PURCHACCREF); } catch {  com.Parameters.AddWithValue("@PURCHACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTOFSALECNTREF", B.COSTOFSALECNTREF); } catch {  com.Parameters.AddWithValue("@COSTOFSALECNTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PURCHCENTREF", B.PURCHCENTREF); } catch {  com.Parameters.AddWithValue("@PURCHCENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PREVOUTCOSTCURR", B.PREVOUTCOSTCURR); } catch {  com.Parameters.AddWithValue("@PREVOUTCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ABVATAMOUNT", B.ABVATAMOUNT); } catch {  com.Parameters.AddWithValue("@ABVATAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ABVATSTATUS", B.ABVATSTATUS); } catch {  com.Parameters.AddWithValue("@ABVATSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRRATE", B.PRRATE); } catch {  com.Parameters.AddWithValue("@PRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXRATE", B.ADDTAXRATE); } catch {  com.Parameters.AddWithValue("@ADDTAXRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXCONVFACT", B.ADDTAXCONVFACT); } catch {  com.Parameters.AddWithValue("@ADDTAXCONVFACT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXAMOUNT", B.ADDTAXAMOUNT); } catch {  com.Parameters.AddWithValue("@ADDTAXAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXPRCOST", B.ADDTAXPRCOST); } catch {  com.Parameters.AddWithValue("@ADDTAXPRCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXRETCOST", B.ADDTAXRETCOST); } catch {  com.Parameters.AddWithValue("@ADDTAXRETCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXRETCOSTCURR", B.ADDTAXRETCOSTCURR); } catch {  com.Parameters.AddWithValue("@ADDTAXRETCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GROSSUINFO1", B.GROSSUINFO1); } catch {  com.Parameters.AddWithValue("@GROSSUINFO1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GROSSUINFO2", B.GROSSUINFO2); } catch {  com.Parameters.AddWithValue("@GROSSUINFO2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXPRCOSTCURR", B.ADDTAXPRCOSTCURR); } catch {  com.Parameters.AddWithValue("@ADDTAXPRCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXACCREF", B.ADDTAXACCREF); } catch {  com.Parameters.AddWithValue("@ADDTAXACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXCENTERREF", B.ADDTAXCENTERREF); } catch {  com.Parameters.AddWithValue("@ADDTAXCENTERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXAMNTISUPD", B.ADDTAXAMNTISUPD); } catch {  com.Parameters.AddWithValue("@ADDTAXAMNTISUPD",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INFIDX", B.INFIDX); } catch {  com.Parameters.AddWithValue("@INFIDX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXCOSACCREF", B.ADDTAXCOSACCREF); } catch {  com.Parameters.AddWithValue("@ADDTAXCOSACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXCOSCNTREF", B.ADDTAXCOSCNTREF); } catch {  com.Parameters.AddWithValue("@ADDTAXCOSCNTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PREVIOUSATAXPRCOST", B.PREVIOUSATAXPRCOST); } catch {  com.Parameters.AddWithValue("@PREVIOUSATAXPRCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PREVATAXPRCOSTCURR", B.PREVATAXPRCOSTCURR); } catch {  com.Parameters.AddWithValue("@PREVATAXPRCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRDORDTOTCOEF", B.PRDORDTOTCOEF); } catch {  com.Parameters.AddWithValue("@PRDORDTOTCOEF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEMPEGGEDAMNT", B.DEMPEGGEDAMNT); } catch {  com.Parameters.AddWithValue("@DEMPEGGEDAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STDUNITCOST", B.STDUNITCOST); } catch {  com.Parameters.AddWithValue("@STDUNITCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STDRPUNITCOST", B.STDRPUNITCOST); } catch {  com.Parameters.AddWithValue("@STDRPUNITCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTDIFFACCREF", B.COSTDIFFACCREF); } catch {  com.Parameters.AddWithValue("@COSTDIFFACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTDIFFCENREF", B.COSTDIFFCENREF); } catch {  com.Parameters.AddWithValue("@COSTDIFFCENREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TEXTINC", B.TEXTINC); } catch {  com.Parameters.AddWithValue("@TEXTINC",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXDISCAMOUNT", B.ADDTAXDISCAMOUNT); } catch {  com.Parameters.AddWithValue("@ADDTAXDISCAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGOID", B.ORGLOGOID); } catch {  com.Parameters.AddWithValue("@ORGLOGOID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFICHENO", B.EXIMFICHENO); } catch {  com.Parameters.AddWithValue("@EXIMFICHENO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFCTYPE", B.EXIMFCTYPE); } catch {  com.Parameters.AddWithValue("@EXIMFCTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRANSEXPLINE", B.TRANSEXPLINE); } catch {  com.Parameters.AddWithValue("@TRANSEXPLINE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INSEXPLINE", B.INSEXPLINE); } catch {  com.Parameters.AddWithValue("@INSEXPLINE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMWHFCREF", B.EXIMWHFCREF); } catch {  com.Parameters.AddWithValue("@EXIMWHFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMWHLNREF", B.EXIMWHLNREF); } catch {  com.Parameters.AddWithValue("@EXIMWHLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMFILEREF", B.EXIMFILEREF); } catch {  com.Parameters.AddWithValue("@EXIMFILEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMPROCNR", B.EXIMPROCNR); } catch {  com.Parameters.AddWithValue("@EXIMPROCNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EISRVDSTTYP", B.EISRVDSTTYP); } catch {  com.Parameters.AddWithValue("@EISRVDSTTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MAINSTLNREF", B.MAINSTLNREF); } catch {  com.Parameters.AddWithValue("@MAINSTLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MADEOFSHRED", B.MADEOFSHRED); } catch {  com.Parameters.AddWithValue("@MADEOFSHRED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMORDWITHPAY", B.FROMORDWITHPAY); } catch {  com.Parameters.AddWithValue("@FROMORDWITHPAY",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROJECTREF", B.PROJECTREF); } catch {  com.Parameters.AddWithValue("@PROJECTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STATUS", B.STATUS); } catch {  com.Parameters.AddWithValue("@STATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DORESERVE", B.DORESERVE); } catch {  com.Parameters.AddWithValue("@DORESERVE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCAMPREFS1", B.POINTCAMPREFS1); } catch {  com.Parameters.AddWithValue("@POINTCAMPREFS1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCAMPREFS2", B.POINTCAMPREFS2); } catch {  com.Parameters.AddWithValue("@POINTCAMPREFS2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCAMPREFS3", B.POINTCAMPREFS3); } catch {  com.Parameters.AddWithValue("@POINTCAMPREFS3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCAMPREFS4", B.POINTCAMPREFS4); } catch {  com.Parameters.AddWithValue("@POINTCAMPREFS4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPPOINTS1", B.CAMPPOINTS1); } catch {  com.Parameters.AddWithValue("@CAMPPOINTS1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPPOINTS2", B.CAMPPOINTS2); } catch {  com.Parameters.AddWithValue("@CAMPPOINTS2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPPOINTS3", B.CAMPPOINTS3); } catch {  com.Parameters.AddWithValue("@CAMPPOINTS3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPPOINTS4", B.CAMPPOINTS4); } catch {  com.Parameters.AddWithValue("@CAMPPOINTS4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CMPGLINEREFS1", B.CMPGLINEREFS1); } catch {  com.Parameters.AddWithValue("@CMPGLINEREFS1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CMPGLINEREFS2", B.CMPGLINEREFS2); } catch {  com.Parameters.AddWithValue("@CMPGLINEREFS2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CMPGLINEREFS3", B.CMPGLINEREFS3); } catch {  com.Parameters.AddWithValue("@CMPGLINEREFS3",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CMPGLINEREFS4", B.CMPGLINEREFS4); } catch {  com.Parameters.AddWithValue("@CMPGLINEREFS4",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRCLISTREF", B.PRCLISTREF); } catch {  com.Parameters.AddWithValue("@PRCLISTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PORDSYMOUTLN", B.PORDSYMOUTLN); } catch {  com.Parameters.AddWithValue("@PORDSYMOUTLN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MONTH_", B.MONTH_); } catch {  com.Parameters.AddWithValue("@MONTH_",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@YEAR_", B.YEAR_); } catch {  com.Parameters.AddWithValue("@YEAR_",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXADDTAXRATE", B.EXADDTAXRATE); } catch {  com.Parameters.AddWithValue("@EXADDTAXRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXADDTAXCONVF", B.EXADDTAXCONVF); } catch {  com.Parameters.AddWithValue("@EXADDTAXCONVF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXADDTAXAREF", B.EXADDTAXAREF); } catch {  com.Parameters.AddWithValue("@EXADDTAXAREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXADDTAXCREF", B.EXADDTAXCREF); } catch {  com.Parameters.AddWithValue("@EXADDTAXCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OTHRADDTAXAREF", B.OTHRADDTAXAREF); } catch {  com.Parameters.AddWithValue("@OTHRADDTAXAREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OTHRADDTAXCREF", B.OTHRADDTAXCREF); } catch {  com.Parameters.AddWithValue("@OTHRADDTAXCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXADDTAXAMNT", B.EXADDTAXAMNT); } catch {  com.Parameters.AddWithValue("@EXADDTAXAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTCOLLATRL", B.AFFECTCOLLATRL); } catch {  com.Parameters.AddWithValue("@AFFECTCOLLATRL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ALTPROMFLAG", B.ALTPROMFLAG); } catch {  com.Parameters.AddWithValue("@ALTPROMFLAG",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EIDISTFLNNR", B.EIDISTFLNNR); } catch {  com.Parameters.AddWithValue("@EIDISTFLNNR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EXIMTYPE", B.EXIMTYPE); } catch {  com.Parameters.AddWithValue("@EXIMTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VARIANTREF", B.VARIANTREF); } catch {  com.Parameters.AddWithValue("@VARIANTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANDEDUCT", B.CANDEDUCT); } catch {  com.Parameters.AddWithValue("@CANDEDUCT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTREMAMNT", B.OUTREMAMNT); } catch {  com.Parameters.AddWithValue("@OUTREMAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTREMCOST", B.OUTREMCOST); } catch {  com.Parameters.AddWithValue("@OUTREMCOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTREMCOSTCURR", B.OUTREMCOSTCURR); } catch {  com.Parameters.AddWithValue("@OUTREMCOSTCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLVATACCREF", B.REFLVATACCREF); } catch {  com.Parameters.AddWithValue("@REFLVATACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLVATOTHACCREF", B.REFLVATOTHACCREF); } catch {  com.Parameters.AddWithValue("@REFLVATOTHACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PARENTLNREF", B.PARENTLNREF); } catch {  com.Parameters.AddWithValue("@PARENTLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@AFFECTRISK", B.AFFECTRISK); } catch {  com.Parameters.AddWithValue("@AFFECTRISK",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INEFFECTIVECOST", B.INEFFECTIVECOST); } catch {  com.Parameters.AddWithValue("@INEFFECTIVECOST",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADDTAXVATMATRAH", B.ADDTAXVATMATRAH); } catch {  com.Parameters.AddWithValue("@ADDTAXVATMATRAH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLACCREF", B.REFLACCREF); } catch {  com.Parameters.AddWithValue("@REFLACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REFLOTHACCREF", B.REFLOTHACCREF); } catch {  com.Parameters.AddWithValue("@REFLOTHACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CAMPPAYDEFREF", B.CAMPPAYDEFREF); } catch {  com.Parameters.AddWithValue("@CAMPPAYDEFREF",  DBNull.Value); }
if (B.FAREGBINDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@FAREGBINDDATE", B.FAREGBINDDATE);
else 
       com.Parameters.AddWithValue("@FAREGBINDDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@RELTRANSLNREF", B.RELTRANSLNREF); } catch {  com.Parameters.AddWithValue("@RELTRANSLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FROMTRANSFER", B.FROMTRANSFER); } catch {  com.Parameters.AddWithValue("@FROMTRANSFER",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTDISTPRICE", B.COSTDISTPRICE); } catch {  com.Parameters.AddWithValue("@COSTDISTPRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTDISTREPPRICE", B.COSTDISTREPPRICE); } catch {  com.Parameters.AddWithValue("@COSTDISTREPPRICE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFPRICEUFRS", B.DIFFPRICEUFRS); } catch {  com.Parameters.AddWithValue("@DIFFPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFREPPRICEUFRS", B.DIFFREPPRICEUFRS); } catch {  com.Parameters.AddWithValue("@DIFFREPPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTCOSTUFRS", B.OUTCOSTUFRS); } catch {  com.Parameters.AddWithValue("@OUTCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTCOSTCURRUFRS", B.OUTCOSTCURRUFRS); } catch {  com.Parameters.AddWithValue("@OUTCOSTCURRUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFPRCOSTUFRS", B.DIFFPRCOSTUFRS); } catch {  com.Parameters.AddWithValue("@DIFFPRCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DIFFPRCRCOSTUFRS", B.DIFFPRCRCOSTUFRS); } catch {  com.Parameters.AddWithValue("@DIFFPRCRCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETCOSTUFRS", B.RETCOSTUFRS); } catch {  com.Parameters.AddWithValue("@RETCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RETCOSTCURRUFRS", B.RETCOSTCURRUFRS); } catch {  com.Parameters.AddWithValue("@RETCOSTCURRUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTREMCOSTUFRS", B.OUTREMCOSTUFRS); } catch {  com.Parameters.AddWithValue("@OUTREMCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OUTREMCOSTCURRUFRS", B.OUTREMCOSTCURRUFRS); } catch {  com.Parameters.AddWithValue("@OUTREMCOSTCURRUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INFIDXUFRS", B.INFIDXUFRS); } catch {  com.Parameters.AddWithValue("@INFIDXUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADJPRICEUFRS", B.ADJPRICEUFRS); } catch {  com.Parameters.AddWithValue("@ADJPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADJREPPRICEUFRS", B.ADJREPPRICEUFRS); } catch {  com.Parameters.AddWithValue("@ADJREPPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADJPRCOSTUFRS", B.ADJPRCOSTUFRS); } catch {  com.Parameters.AddWithValue("@ADJPRCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ADJPRCRCOSTUFRS", B.ADJPRCRCOSTUFRS); } catch {  com.Parameters.AddWithValue("@ADJPRCRCOSTUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTDISTPRICEUFRS", B.COSTDISTPRICEUFRS); } catch {  com.Parameters.AddWithValue("@COSTDISTPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSTDISTREPPRICEUFRS", B.COSTDISTREPPRICEUFRS); } catch {  com.Parameters.AddWithValue("@COSTDISTREPPRICEUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PURCHACCREFUFRS", B.PURCHACCREFUFRS); } catch {  com.Parameters.AddWithValue("@PURCHACCREFUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PURCHCENTREFUFRS", B.PURCHCENTREFUFRS); } catch {  com.Parameters.AddWithValue("@PURCHCENTREFUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSACCREFUFRS", B.COSACCREFUFRS); } catch {  com.Parameters.AddWithValue("@COSACCREFUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@COSCNTREFUFRS", B.COSCNTREFUFRS); } catch {  com.Parameters.AddWithValue("@COSCNTREFUFRS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROUTCOSTUFRSDIFF", B.PROUTCOSTUFRSDIFF); } catch {  com.Parameters.AddWithValue("@PROUTCOSTUFRSDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PROUTCOSTCRUFRSDIFF", B.PROUTCOSTCRUFRSDIFF); } catch {  com.Parameters.AddWithValue("@PROUTCOSTCRUFRSDIFF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UNDERDEDUCTLIMIT", B.UNDERDEDUCTLIMIT); } catch {  com.Parameters.AddWithValue("@UNDERDEDUCTLIMIT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GLOBALID", B.GLOBALID); } catch {  com.Parameters.AddWithValue("@GLOBALID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART1", B.DEDUCTIONPART1); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART1",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTIONPART2", B.DEDUCTIONPART2); } catch {  com.Parameters.AddWithValue("@DEDUCTIONPART2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GUID", B.GUID); } catch {  com.Parameters.AddWithValue("@GUID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE2", B.SPECODE2); } catch {  com.Parameters.AddWithValue("@SPECODE2",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OFFERREF", B.OFFERREF); } catch {  com.Parameters.AddWithValue("@OFFERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@OFFTRANSREF", B.OFFTRANSREF); } catch {  com.Parameters.AddWithValue("@OFFTRANSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATEXCEPTREASON", B.VATEXCEPTREASON); } catch {  com.Parameters.AddWithValue("@VATEXCEPTREASON",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PLNDEFSERILOTNO", B.PLNDEFSERILOTNO); } catch {  com.Parameters.AddWithValue("@PLNDEFSERILOTNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PLNUNRSRVAMOUNT", B.PLNUNRSRVAMOUNT); } catch {  com.Parameters.AddWithValue("@PLNUNRSRVAMOUNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PORDCLSPLNUNRSRVAMNT", B.PORDCLSPLNUNRSRVAMNT); } catch {  com.Parameters.AddWithValue("@PORDCLSPLNUNRSRVAMNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LPRODRSRVSTAT", B.LPRODRSRVSTAT); } catch {  com.Parameters.AddWithValue("@LPRODRSRVSTAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FALINKTYPE", B.FALINKTYPE); } catch {  com.Parameters.AddWithValue("@FALINKTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEDUCTCODE", B.DEDUCTCODE); } catch {  com.Parameters.AddWithValue("@DEDUCTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@UPDTHISLINE", B.UPDTHISLINE); } catch {  com.Parameters.AddWithValue("@UPDTHISLINE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@VATEXCEPTCODE", B.VATEXCEPTCODE); } catch {  com.Parameters.AddWithValue("@VATEXCEPTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PORDERFICHENO", B.PORDERFICHENO); } catch {  com.Parameters.AddWithValue("@PORDERFICHENO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QPRODFCREF", B.QPRODFCREF); } catch {  com.Parameters.AddWithValue("@QPRODFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RELTRANSFCREF", B.RELTRANSFCREF); } catch {  com.Parameters.AddWithValue("@RELTRANSFCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ATAXEXCEPTREASON", B.ATAXEXCEPTREASON); } catch {  com.Parameters.AddWithValue("@ATAXEXCEPTREASON",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ATAXEXCEPTCODE", B.ATAXEXCEPTCODE); } catch {  com.Parameters.AddWithValue("@ATAXEXCEPTCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRODORDERTYP", B.PRODORDERTYP); } catch {  com.Parameters.AddWithValue("@PRODORDERTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SUBCONTORDERREF", B.SUBCONTORDERREF); } catch {  com.Parameters.AddWithValue("@SUBCONTORDERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QPRODFCTYP", B.QPRODFCTYP); } catch {  com.Parameters.AddWithValue("@QPRODFCTYP",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PRDORDSLPLNRESERVE", B.PRDORDSLPLNRESERVE); } catch {  com.Parameters.AddWithValue("@PRDORDSLPLNRESERVE",  DBNull.Value); }
if (B.INFDATE != new DateTime()) 
      com.Parameters.AddWithValue("@INFDATE", B.INFDATE);
else 
       com.Parameters.AddWithValue("@INFDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@DESTSTATUS", B.DESTSTATUS); } catch {  com.Parameters.AddWithValue("@DESTSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REGTYPREF", B.REGTYPREF); } catch {  com.Parameters.AddWithValue("@REGTYPREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FAPROFITACCREF", B.FAPROFITACCREF); } catch {  com.Parameters.AddWithValue("@FAPROFITACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FAPROFITCENTREF", B.FAPROFITCENTREF); } catch {  com.Parameters.AddWithValue("@FAPROFITCENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FALOSSACCREF", B.FALOSSACCREF); } catch {  com.Parameters.AddWithValue("@FALOSSACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FALOSSCENTREF", B.FALOSSCENTREF); } catch {  com.Parameters.AddWithValue("@FALOSSCENTREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CPACODE", B.CPACODE); } catch {  com.Parameters.AddWithValue("@CPACODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GTIPCODE", B.GTIPCODE); } catch {  com.Parameters.AddWithValue("@GTIPCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PUBLICCOUNTRYREF", B.PUBLICCOUNTRYREF); } catch {  com.Parameters.AddWithValue("@PUBLICCOUNTRYREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QPRODITEMTYPE", B.QPRODITEMTYPE); } catch {  com.Parameters.AddWithValue("@QPRODITEMTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FUTMONTHCNT", B.FUTMONTHCNT); } catch {  com.Parameters.AddWithValue("@FUTMONTHCNT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FUTMONTHBEGDATE", B.FUTMONTHBEGDATE); } catch {  com.Parameters.AddWithValue("@FUTMONTHBEGDATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QCTRANSFERREF", B.QCTRANSFERREF); } catch {  com.Parameters.AddWithValue("@QCTRANSFERREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@QCTRANSFERAMNT", B.QCTRANSFERAMNT); } catch {  com.Parameters.AddWithValue("@QCTRANSFERAMNT",  DBNull.Value); }
if (B.FUTMONTHENDDATE != new DateTime()) 
      com.Parameters.AddWithValue("@FUTMONTHENDDATE", B.FUTMONTHENDDATE);
else 
       com.Parameters.AddWithValue("@FUTMONTHENDDATE", DBNull.Value);
 
      com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

      return com;
   }
   catch
   {
      return null;
   }
}

public SqlCommand BM_XXX_XX_PAYTRANS_UPDATE(BM_XXX_XX_PAYTRANS B, bool UPDATEBM, bool UPDATELOGICALREF ,string FIRMNR ,string PERIODNR, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BM_XXX_XX_PAYTRANS";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") .Replace("XXX", FIRMNR) 
.Replace("XX", PERIODNR); 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " CARDREF = @CARDREF, DATE_ = @DATE_, MODULENR = @MODULENR, SIGN = @SIGN, FICHEREF = @FICHEREF, FICHELINEREF = @FICHELINEREF, TRCODE = @TRCODE, TOTAL = @TOTAL, PAID = @PAID, EARLYINTRATE = @EARLYINTRATE, LATELYINTRATE = @LATELYINTRATE, CROSSREF = @CROSSREF, PAIDINCASH = @PAIDINCASH, CANCELLED = @CANCELLED, PROCDATE = @PROCDATE, TRCURR = @TRCURR, TRRATE = @TRRATE, REPORTRATE = @REPORTRATE, MODIFIED = @MODIFIED, REMINDLEV = @REMINDLEV, REMINDSENT = @REMINDSENT, CROSSCURR = @CROSSCURR, CROSSTOTAL = @CROSSTOTAL, DISCFLAG = @DISCFLAG, SITEID = @SITEID, ORGLOGICREF = @ORGLOGICREF, WFSTATUS = @WFSTATUS, CLOSINGRATE = @CLOSINGRATE, DISCDUEDATE = @DISCDUEDATE, OPSTAT = @OPSTAT, RECSTATUS = @RECSTATUS, INFIDX = @INFIDX, PAYNO = @PAYNO, DELAYTOTAL = @DELAYTOTAL, LASTSENDREMLEV = @LASTSENDREMLEV, POINTTRANS = @POINTTRANS, BANKPAYDATE = @BANKPAYDATE, POSCOMSN = @POSCOMSN, POINTCOMSN = @POINTCOMSN, BANKACCREF = @BANKACCREF, PAYMENTTYPE = @PAYMENTTYPE, CASHACCREF = @CASHACCREF, TRNET = @TRNET, REPAYPLANREF = @REPAYPLANREF, DUEDIFFCOMSN = @DUEDIFFCOMSN, CALCTYPE = @CALCTYPE, NETTOTAL = @NETTOTAL, REPYPLNAPPLIED = @REPYPLNAPPLIED, PAYTRCURR = @PAYTRCURR, PAYTRRATE = @PAYTRRATE, PAYTRNET = @PAYTRNET, BNTRCREATED = @BNTRCREATED, BNFCHREF = @BNFCHREF, BNFLNREF = @BNFLNREF, INSTALTYPE = @INSTALTYPE, INSTALREF = @INSTALREF, MAININSTALREF = @MAININSTALREF, ORGLOGOID = @ORGLOGOID, STLINEREF = @STLINEREF, SPECODE = @SPECODE, CREDITCARDNUM = @CREDITCARDNUM, VALBEGDATE = @VALBEGDATE, RETREFNO = @RETREFNO, DOCODE = @DOCODE, BATCHNUM = @BATCHNUM, APPROVENUM = @APPROVENUM, POSTERMINALNUM = @POSTERMINALNUM, CLDIFFINV = @CLDIFFINV, LINEEXP = @LINEEXP, DEVIRPROCDATE = @DEVIRPROCDATE, DEVIR = @DEVIR, DEVIRCARDREF = @DEVIRCARDREF, GLOBALCODE = @GLOBALCODE, CLBNACCOUNTNO = @CLBNACCOUNTNO, MATCHDATE = @MATCHDATE, DEVIRBRANCH = @DEVIRBRANCH, DEVIRDEPARTMENT = @DEVIRDEPARTMENT, DEVIRFICHEREF = @DEVIRFICHEREF, DEVIRLINEREF = @DEVIRLINEREF, CURRDIFFRATE = @CURRDIFFRATE, CURRDIFFCLOSED = @CURRDIFFCLOSED, CURRDIFFCLSREF = @CURRDIFFCLSREF  WHERE " + WHERECLAUSE + " = " + WHEREVALUE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CARDREF", B.CARDREF); } catch {  com.Parameters.AddWithValue("@CARDREF",  DBNull.Value); }
if (B.DATE_ != new DateTime()) 
      com.Parameters.AddWithValue("@DATE_", B.DATE_);
else 
       com.Parameters.AddWithValue("@DATE_", DBNull.Value);
 try { com.Parameters.AddWithValue("@MODULENR", B.MODULENR); } catch {  com.Parameters.AddWithValue("@MODULENR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SIGN", B.SIGN); } catch {  com.Parameters.AddWithValue("@SIGN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FICHEREF", B.FICHEREF); } catch {  com.Parameters.AddWithValue("@FICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@FICHELINEREF", B.FICHELINEREF); } catch {  com.Parameters.AddWithValue("@FICHELINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRCODE", B.TRCODE); } catch {  com.Parameters.AddWithValue("@TRCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TOTAL", B.TOTAL); } catch {  com.Parameters.AddWithValue("@TOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAID", B.PAID); } catch {  com.Parameters.AddWithValue("@PAID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@EARLYINTRATE", B.EARLYINTRATE); } catch {  com.Parameters.AddWithValue("@EARLYINTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LATELYINTRATE", B.LATELYINTRATE); } catch {  com.Parameters.AddWithValue("@LATELYINTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CROSSREF", B.CROSSREF); } catch {  com.Parameters.AddWithValue("@CROSSREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAIDINCASH", B.PAIDINCASH); } catch {  com.Parameters.AddWithValue("@PAIDINCASH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CANCELLED", B.CANCELLED); } catch {  com.Parameters.AddWithValue("@CANCELLED",  DBNull.Value); }
if (B.PROCDATE != new DateTime()) 
      com.Parameters.AddWithValue("@PROCDATE", B.PROCDATE);
else 
       com.Parameters.AddWithValue("@PROCDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@TRCURR", B.TRCURR); } catch {  com.Parameters.AddWithValue("@TRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRRATE", B.TRRATE); } catch {  com.Parameters.AddWithValue("@TRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPORTRATE", B.REPORTRATE); } catch {  com.Parameters.AddWithValue("@REPORTRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MODIFIED", B.MODIFIED); } catch {  com.Parameters.AddWithValue("@MODIFIED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REMINDLEV", B.REMINDLEV); } catch {  com.Parameters.AddWithValue("@REMINDLEV",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REMINDSENT", B.REMINDSENT); } catch {  com.Parameters.AddWithValue("@REMINDSENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CROSSCURR", B.CROSSCURR); } catch {  com.Parameters.AddWithValue("@CROSSCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CROSSTOTAL", B.CROSSTOTAL); } catch {  com.Parameters.AddWithValue("@CROSSTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DISCFLAG", B.DISCFLAG); } catch {  com.Parameters.AddWithValue("@DISCFLAG",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SITEID", B.SITEID); } catch {  com.Parameters.AddWithValue("@SITEID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGICREF", B.ORGLOGICREF); } catch {  com.Parameters.AddWithValue("@ORGLOGICREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@WFSTATUS", B.WFSTATUS); } catch {  com.Parameters.AddWithValue("@WFSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLOSINGRATE", B.CLOSINGRATE); } catch {  com.Parameters.AddWithValue("@CLOSINGRATE",  DBNull.Value); }
if (B.DISCDUEDATE != new DateTime()) 
      com.Parameters.AddWithValue("@DISCDUEDATE", B.DISCDUEDATE);
else 
       com.Parameters.AddWithValue("@DISCDUEDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@OPSTAT", B.OPSTAT); } catch {  com.Parameters.AddWithValue("@OPSTAT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@RECSTATUS", B.RECSTATUS); } catch {  com.Parameters.AddWithValue("@RECSTATUS",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INFIDX", B.INFIDX); } catch {  com.Parameters.AddWithValue("@INFIDX",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYNO", B.PAYNO); } catch {  com.Parameters.AddWithValue("@PAYNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DELAYTOTAL", B.DELAYTOTAL); } catch {  com.Parameters.AddWithValue("@DELAYTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LASTSENDREMLEV", B.LASTSENDREMLEV); } catch {  com.Parameters.AddWithValue("@LASTSENDREMLEV",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTTRANS", B.POINTTRANS); } catch {  com.Parameters.AddWithValue("@POINTTRANS",  DBNull.Value); }
if (B.BANKPAYDATE != new DateTime()) 
      com.Parameters.AddWithValue("@BANKPAYDATE", B.BANKPAYDATE);
else 
       com.Parameters.AddWithValue("@BANKPAYDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@POSCOMSN", B.POSCOMSN); } catch {  com.Parameters.AddWithValue("@POSCOMSN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POINTCOMSN", B.POINTCOMSN); } catch {  com.Parameters.AddWithValue("@POINTCOMSN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BANKACCREF", B.BANKACCREF); } catch {  com.Parameters.AddWithValue("@BANKACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYMENTTYPE", B.PAYMENTTYPE); } catch {  com.Parameters.AddWithValue("@PAYMENTTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CASHACCREF", B.CASHACCREF); } catch {  com.Parameters.AddWithValue("@CASHACCREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TRNET", B.TRNET); } catch {  com.Parameters.AddWithValue("@TRNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPAYPLANREF", B.REPAYPLANREF); } catch {  com.Parameters.AddWithValue("@REPAYPLANREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DUEDIFFCOMSN", B.DUEDIFFCOMSN); } catch {  com.Parameters.AddWithValue("@DUEDIFFCOMSN",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CALCTYPE", B.CALCTYPE); } catch {  com.Parameters.AddWithValue("@CALCTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@NETTOTAL", B.NETTOTAL); } catch {  com.Parameters.AddWithValue("@NETTOTAL",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@REPYPLNAPPLIED", B.REPYPLNAPPLIED); } catch {  com.Parameters.AddWithValue("@REPYPLNAPPLIED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYTRCURR", B.PAYTRCURR); } catch {  com.Parameters.AddWithValue("@PAYTRCURR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYTRRATE", B.PAYTRRATE); } catch {  com.Parameters.AddWithValue("@PAYTRRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@PAYTRNET", B.PAYTRNET); } catch {  com.Parameters.AddWithValue("@PAYTRNET",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNTRCREATED", B.BNTRCREATED); } catch {  com.Parameters.AddWithValue("@BNTRCREATED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNFCHREF", B.BNFCHREF); } catch {  com.Parameters.AddWithValue("@BNFCHREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BNFLNREF", B.BNFLNREF); } catch {  com.Parameters.AddWithValue("@BNFLNREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INSTALTYPE", B.INSTALTYPE); } catch {  com.Parameters.AddWithValue("@INSTALTYPE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@INSTALREF", B.INSTALREF); } catch {  com.Parameters.AddWithValue("@INSTALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MAININSTALREF", B.MAININSTALREF); } catch {  com.Parameters.AddWithValue("@MAININSTALREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ORGLOGOID", B.ORGLOGOID); } catch {  com.Parameters.AddWithValue("@ORGLOGOID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@STLINEREF", B.STLINEREF); } catch {  com.Parameters.AddWithValue("@STLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@SPECODE", B.SPECODE); } catch {  com.Parameters.AddWithValue("@SPECODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CREDITCARDNUM", B.CREDITCARDNUM); } catch {  com.Parameters.AddWithValue("@CREDITCARDNUM",  DBNull.Value); }
if (B.VALBEGDATE != new DateTime()) 
      com.Parameters.AddWithValue("@VALBEGDATE", B.VALBEGDATE);
else 
       com.Parameters.AddWithValue("@VALBEGDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@RETREFNO", B.RETREFNO); } catch {  com.Parameters.AddWithValue("@RETREFNO",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DOCODE", B.DOCODE); } catch {  com.Parameters.AddWithValue("@DOCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BATCHNUM", B.BATCHNUM); } catch {  com.Parameters.AddWithValue("@BATCHNUM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@APPROVENUM", B.APPROVENUM); } catch {  com.Parameters.AddWithValue("@APPROVENUM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@POSTERMINALNUM", B.POSTERMINALNUM); } catch {  com.Parameters.AddWithValue("@POSTERMINALNUM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLDIFFINV", B.CLDIFFINV); } catch {  com.Parameters.AddWithValue("@CLDIFFINV",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LINEEXP", B.LINEEXP); } catch {  com.Parameters.AddWithValue("@LINEEXP",  DBNull.Value); }
if (B.DEVIRPROCDATE != new DateTime()) 
      com.Parameters.AddWithValue("@DEVIRPROCDATE", B.DEVIRPROCDATE);
else 
       com.Parameters.AddWithValue("@DEVIRPROCDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@DEVIR", B.DEVIR); } catch {  com.Parameters.AddWithValue("@DEVIR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIRCARDREF", B.DEVIRCARDREF); } catch {  com.Parameters.AddWithValue("@DEVIRCARDREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@GLOBALCODE", B.GLOBALCODE); } catch {  com.Parameters.AddWithValue("@GLOBALCODE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CLBNACCOUNTNO", B.CLBNACCOUNTNO); } catch {  com.Parameters.AddWithValue("@CLBNACCOUNTNO",  DBNull.Value); }
if (B.MATCHDATE != new DateTime()) 
      com.Parameters.AddWithValue("@MATCHDATE", B.MATCHDATE);
else 
       com.Parameters.AddWithValue("@MATCHDATE", DBNull.Value);
 try { com.Parameters.AddWithValue("@DEVIRBRANCH", B.DEVIRBRANCH); } catch {  com.Parameters.AddWithValue("@DEVIRBRANCH",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIRDEPARTMENT", B.DEVIRDEPARTMENT); } catch {  com.Parameters.AddWithValue("@DEVIRDEPARTMENT",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIRFICHEREF", B.DEVIRFICHEREF); } catch {  com.Parameters.AddWithValue("@DEVIRFICHEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@DEVIRLINEREF", B.DEVIRLINEREF); } catch {  com.Parameters.AddWithValue("@DEVIRLINEREF",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CURRDIFFRATE", B.CURRDIFFRATE); } catch {  com.Parameters.AddWithValue("@CURRDIFFRATE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CURRDIFFCLOSED", B.CURRDIFFCLOSED); } catch {  com.Parameters.AddWithValue("@CURRDIFFCLOSED",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@CURRDIFFCLSREF", B.CURRDIFFCLSREF); } catch {  com.Parameters.AddWithValue("@CURRDIFFCLSREF",  DBNull.Value); }
 
      com.Parameters.AddWithValue("@WHERECLAUSE", WHERECLAUSE);

      return com;
   }
   catch
   {
      return null;
   }
}


}
}