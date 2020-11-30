using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS
{
 public class BM_XXX_XX_INVOICE
{
public int LOGICALREF { get; set; }
public int GRPCODE { get; set; }
public int TRCODE { get; set; }
public string FICHENO { get; set; } = string.Empty;
public DateTime DATE_ { get; set; }
public int TIME_ { get; set; }
public string DOCODE { get; set; } = string.Empty;
public string SPECODE { get; set; } = string.Empty;
public string CYPHCODE { get; set; } = string.Empty;
public int CLIENTREF { get; set; }
public int RECVREF { get; set; }
public int CENTERREF { get; set; }
public int ACCOUNTREF { get; set; }
public int SOURCEINDEX { get; set; }
public int SOURCECOSTGRP { get; set; }
public int CANCELLED { get; set; }
public int ACCOUNTED { get; set; }
public int PAIDINCASH { get; set; }
public int FROMKASA { get; set; }
public int ENTEGSET { get; set; }
public double VAT { get; set; }
public double ADDDISCOUNTS { get; set; }
public double TOTALDISCOUNTS { get; set; }
public double TOTALDISCOUNTED { get; set; }
public double ADDEXPENSES { get; set; }
public double TOTALEXPENSES { get; set; }
public double DISTEXPENSE { get; set; }
public double TOTALDEPOZITO { get; set; }
public double TOTALPROMOTIONS { get; set; }
public double VATINCGROSS { get; set; }
public double TOTALVAT { get; set; }
public double GROSSTOTAL { get; set; }
public double NETTOTAL { get; set; }
public string GENEXP1 { get; set; } = string.Empty;
public string GENEXP2 { get; set; } = string.Empty;
public string GENEXP3 { get; set; } = string.Empty;
public string GENEXP4 { get; set; } = string.Empty;
public string GENEXP5 { get; set; } = string.Empty;
public string GENEXP6 { get; set; } = string.Empty;
public double INTERESTAPP { get; set; }
public int TRCURR { get; set; }
public double TRRATE { get; set; }
public double TRNET { get; set; }
public double REPORTRATE { get; set; }
public double REPORTNET { get; set; }
public int ONLYONEPAYLINE { get; set; }
public int KASTRANSREF { get; set; }
public int PAYDEFREF { get; set; }
public int PRINTCNT { get; set; }
public int GVATINC { get; set; }
public int BRANCH { get; set; }
public int DEPARTMENT { get; set; }
public int ACCFICHEREF { get; set; }
public int ADDEXPACCREF { get; set; }
public int ADDEXPCENTREF { get; set; }
public int DECPRDIFF { get; set; }
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
public int FACTORYNR { get; set; }
public int WFSTATUS { get; set; }
public int SHIPINFOREF { get; set; }
public int DISTORDERREF { get; set; }
public int SENDCNT { get; set; }
public int DLVCLIENT { get; set; }
public int COSTOFSALEFCREF { get; set; }
public int OPSTAT { get; set; }
public string DOCTRACKINGNR { get; set; } = string.Empty;
public double TOTALADDTAX { get; set; }
public int PAYMENTTYPE { get; set; }
public double INFIDX { get; set; }
public int ACCOUNTEDCNT { get; set; }
public string ORGLOGOID { get; set; } = string.Empty;
public int FROMEXIM { get; set; }
public string FRGTYPCOD { get; set; } = string.Empty;
public int EXIMFCTYPE { get; set; }
public int FROMORDWITHPAY { get; set; }
public int PROJECTREF { get; set; }
public int WFLOWCRDREF { get; set; }
public int STATUS { get; set; }
public int DEDUCTIONPART1 { get; set; }
public int DEDUCTIONPART2 { get; set; }
public double TOTALEXADDTAX { get; set; }
public int EXACCOUNTED { get; set; }
public int FROMBANK { get; set; }
public int BNTRANSREF { get; set; }
public int AFFECTCOLLATRL { get; set; }
public int GRPFIRMTRANS { get; set; }
public int AFFECTRISK { get; set; }
public int CONTROLINFO { get; set; }
public int POSTRANSFERINFO { get; set; }
public int TAXFREECHX { get; set; }
public string PASSPORTNO { get; set; } = string.Empty;
public string CREDITCARDNO { get; set; } = string.Empty;
public int INEFFECTIVECOST { get; set; }
public int REFLECTED { get; set; }
public int REFLACCFICHEREF { get; set; }
public int CANCELLEDREFLACC { get; set; }
public string CREDITCARDNUM { get; set; } = string.Empty;
public int APPROVE { get; set; }
public DateTime APPROVEDATE { get; set; }
public int CANTCREDEDUCT { get; set; }
public int ENTRUST { get; set; }
public DateTime DOCDATE { get; set; }
public int EINVOICE { get; set; }
public int PROFILEID { get; set; }
public string GUID { get; set; } = string.Empty;
public int ESTATUS { get; set; }
public DateTime ESTARTDATE { get; set; }
public DateTime EENDDATE { get; set; }
public string EDESCRIPTION { get; set; } = string.Empty;
public double EDURATION { get; set; }
public int EDURATIONTYPE { get; set; }
public int DEVIR { get; set; }
public double DISTADJPRICEUFRS { get; set; }
public int COSFCREFUFRS { get; set; }
public string GLOBALID { get; set; } = string.Empty;
public double TOTALSERVICES { get; set; }
public int FROMLEASING { get; set; }
public string CANCELEXP { get; set; } = string.Empty;
public string UNDOEXP { get; set; } = string.Empty;
public string VATEXCEPTREASON { get; set; } = string.Empty;
public string CAMPAIGNCODE { get; set; } = string.Empty;
public int CANCELDESPSINV { get; set; }
public int FROMEXCHDIFF { get; set; }
public int EXIMVAT { get; set; }
public string SERIALCODE { get; set; } = string.Empty;
public int APPCLDEDUCTLIM { get; set; }
public int EINVOICETYP { get; set; }
public string VATEXCEPTCODE { get; set; } = string.Empty;
public int OFFERREF { get; set; }
public string ATAXEXCEPTREASON { get; set; } = string.Empty;
public string ATAXEXCEPTCODE { get; set; } = string.Empty;
public int FROMSTAFFOTHEREX { get; set; }
public int NOCALCULATE { get; set; }
public int INSTEADOFDESP { get; set; }
public int OKCFICHE { get; set; }
public DateTime CANCELDATE { get; set; }
public string FRGTYPDESC { get; set; } = string.Empty;
public int MARKREF { get; set; }
public DateTime PRINTDATE { get; set; }
public string DELIVERCODE { get; set; } = string.Empty;
public int ACCEPTEINVPUBLIC { get; set; }
public int PUBLICBNACCREF { get; set; }
public string TYPECODE { get; set; } = string.Empty;
public int FUTMNTHYREXPINC { get; set; }
}
}