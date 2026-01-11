using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS
{
 public class BM_XXX_XX_STFICHE
{
public int LOGICALREF { get; set; }
public int GRPCODE { get; set; }
public int TRCODE { get; set; }
public int IOCODE { get; set; }
public string FICHENO { get; set; } = string.Empty;
public DateTime DATE_ { get; set; }
public int FTIME { get; set; }
public string DOCODE { get; set; } = string.Empty;
public string INVNO { get; set; } = string.Empty;
public string SPECODE { get; set; } = string.Empty;
public string CYPHCODE { get; set; } = string.Empty;
public int INVOICEREF { get; set; }
public int CLIENTREF { get; set; }
public int RECVREF { get; set; }
public int ACCOUNTREF { get; set; }
public int CENTERREF { get; set; }
public int PRODORDERREF { get; set; }
public string PORDERFICHENO { get; set; } = string.Empty;
public int SOURCETYPE { get; set; }
public int SOURCEINDEX { get; set; }
public int SOURCEWSREF { get; set; }
public int SOURCEPOLNREF { get; set; }
public int SOURCECOSTGRP { get; set; }
public int DESTTYPE { get; set; }
public int DESTINDEX { get; set; }
public int DESTWSREF { get; set; }
public int DESTPOLNREF { get; set; }
public int DESTCOSTGRP { get; set; }
public int FACTORYNR { get; set; }
public int BRANCH { get; set; }
public int DEPARTMENT { get; set; }
public int COMPBRANCH { get; set; }
public int COMPDEPARTMENT { get; set; }
public int COMPFACTORY { get; set; }
public int PRODSTAT { get; set; }
public int DEVIR { get; set; }
public int CANCELLED { get; set; }
public int BILLED { get; set; }
public int ACCOUNTED { get; set; }
public int UPDCURR { get; set; }
public int INUSE { get; set; }
public int INVKIND { get; set; }
public double ADDDISCOUNTS { get; set; }
public double TOTALDISCOUNTS { get; set; }
public double TOTALDISCOUNTED { get; set; }
public double ADDEXPENSES { get; set; }
public double TOTALEXPENSES { get; set; }
public double TOTALDEPOZITO { get; set; }
public double TOTALPROMOTIONS { get; set; }
public double TOTALVAT { get; set; }
public double GROSSTOTAL { get; set; }
public double NETTOTAL { get; set; }
public string GENEXP1 { get; set; } = string.Empty;
public string GENEXP2 { get; set; } = string.Empty;
public string GENEXP3 { get; set; } = string.Empty;
public string GENEXP4 { get; set; } = string.Empty;
public string GENEXP5 { get; set; } = string.Empty;
public string GENEXP6 { get; set; } = string.Empty;
public double REPORTRATE { get; set; }
public double REPORTNET { get; set; }
public int EXTENREF { get; set; }
public int PAYDEFREF { get; set; }
public int PRINTCNT { get; set; }
public int FICHECNT { get; set; }
public int ACCFICHEREF { get; set; }
public int CAPIBLOCK_CREATEDBY { get; set; }
public DateTime CAPIBLOCK_CREADEDDATE { get; set; }
public int CAPIBLOCK_CREATEDHOUR { get; set; }
public int CAPIBLOCK_CREATEDMIN { get; set; }
public int CAPIBLOCK_CREATEDSEC { get; set; }
public int CAPIBLOCK_MODIFIEDBY { get; set; }
public DateTime CAPIBLOCK_MODIFIEDDATE { get; set; }
public int CAPIBLOCK_MODIFIEDHOUR { get; set; }
public int CAPIBLOCK_MODIFIEDMIN { get; set; }
public int CAPIBLOCK_MODIFIEDSEC { get; set; }
public int SALESMANREF { get; set; }
public int CANCELLEDACC { get; set; }
public string SHPTYPCOD { get; set; } = string.Empty;
public string SHPAGNCOD { get; set; } = string.Empty;
public string TRACKNR { get; set; } = string.Empty;
public int GENEXCTYP { get; set; }
public int LINEEXCTYP { get; set; }
public string TRADINGGRP { get; set; } = string.Empty;
public int TEXTINC { get; set; }
public int SITEID { get; set; }
public int RECSTATUS { get; set; }
public int ORGLOGICREF { get; set; }
public int WFSTATUS { get; set; }
public int SHIPINFOREF { get; set; }
public int DISTORDERREF { get; set; }
public int SENDCNT { get; set; }
public int DLVCLIENT { get; set; }
public string DOCTRACKINGNR { get; set; } = string.Empty;
public int ADDTAXCALC { get; set; }
public double TOTALADDTAX { get; set; }
public string UGIRTRACKINGNO { get; set; } = string.Empty;
public int QPRODFCREF { get; set; }
public int VAACCREF { get; set; }
public int VACENTERREF { get; set; }
public string ORGLOGOID { get; set; } = string.Empty;
public int FROMEXIM { get; set; }
public string FRGTYPCOD { get; set; } = string.Empty;
public int TRCURR { get; set; }
public double TRRATE { get; set; }
public double TRNET { get; set; }
public int EXIMWHFCREF { get; set; }
public int EXIMFCTYPE { get; set; }
public int MAINSTFCREF { get; set; }
public int FROMORDWITHPAY { get; set; }
public int PROJECTREF { get; set; }
public int WFLOWCRDREF { get; set; }
public int STATUS { get; set; }
public int UPDTRCURR { get; set; }
public double TOTALEXADDTAX { get; set; }
public int AFFECTCOLLATRL { get; set; }
public int DEDUCTIONPART1 { get; set; }
public int DEDUCTIONPART2 { get; set; }
public int GRPFIRMTRANS { get; set; }
public int AFFECTRISK { get; set; }
public int DISPSTATUS { get; set; }
public int APPROVE { get; set; }
public DateTime APPROVEDATE { get; set; }
public int CANTCREDEDUCT { get; set; }
public DateTime SHIPDATE { get; set; }
public int SHIPTIME { get; set; }
public int ENTRUSTDEVIR { get; set; }
public int RELTRANSFCREF { get; set; }
public int FROMTRANSFER { get; set; }
public string GUID { get; set; } = string.Empty;
public string GLOBALID { get; set; } = string.Empty;
public int COMPSTFCREF { get; set; }
public int COMPINVREF { get; set; }
public double TOTALSERVICES { get; set; }
public string CAMPAIGNCODE { get; set; } = string.Empty;
public int OFFERREF { get; set; }
public int EINVOICETYP { get; set; }
public int EINVOICE { get; set; }
public int NOCALCULATE { get; set; }
public int PRODORDERTYP { get; set; }
public int QPRODFCTYP { get; set; }
public DateTime PRINTDATE { get; set; }
public int PRDORDSLPLNRESERVE { get; set; }
public int CONTROLINFO { get; set; }
public int EDESPATCH { get; set; }
public DateTime DOCDATE { get; set; }
public int DOCTIME { get; set; }
public int EDESPSTATUS { get; set; }
public int PROFILEID { get; set; }
public string DELIVERYCODE { get; set; } = string.Empty;
public int DESTSTATUS { get; set; }
public string CANCELEXP { get; set; } = string.Empty;
public string UNDOEXP { get; set; } = string.Empty;
public DateTime CANCELDATE { get; set; }
public int CREATEWHERE { get; set; }
public int PUBLICBNACCREF { get; set; }
public int ACCEPTEINVPUBLIC { get; set; }
public string VATEXCEPTCODE { get; set; } = string.Empty;
public string VATEXCEPTREASON { get; set; } = string.Empty;
public string ATAXEXCEPTCODE { get; set; } = string.Empty;
public string ATAXEXCEPTREASON { get; set; } = string.Empty;
public int TAXFREECHX { get; set; }
  
}
}