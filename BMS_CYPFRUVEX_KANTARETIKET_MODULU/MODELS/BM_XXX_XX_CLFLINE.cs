using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS
{
 public class BM_XXX_XX_CLFLINE
{
public int LOGICALREF { get; set; }
public int CLIENTREF { get; set; }
public int CLACCREF { get; set; }
public int CLCENTERREF { get; set; }
public int CASHCENTERREF { get; set; }
public int CASHACCOUNTREF { get; set; }
public int VIRMANREF { get; set; }
public int SOURCEFREF { get; set; }
public DateTime DATE_ { get; set; }
public int DEPARTMENT { get; set; }
public int BRANCH { get; set; }
public int MODULENR { get; set; }
public int TRCODE { get; set; }
public int LINENR { get; set; }
public string SPECODE { get; set; } = string.Empty;
public string CYPHCODE { get; set; } = string.Empty;
public string TRANNO { get; set; } = string.Empty;
public string DOCODE { get; set; } = string.Empty;
public string LINEEXP { get; set; } = string.Empty;
public int ACCOUNTED { get; set; }
public int SIGN { get; set; }
public double AMOUNT { get; set; }
public int TRCURR { get; set; }
public double TRRATE { get; set; }
public double TRNET { get; set; }
public double REPORTRATE { get; set; }
public double REPORTNET { get; set; }
public int EXTENREF { get; set; }
public int PAYDEFREF { get; set; }
public int ACCFICHEREF { get; set; }
public int PRINTCNT { get; set; }
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
public int CANCELLED { get; set; }
public int TRGFLAG { get; set; }
public string TRADINGGRP { get; set; } = string.Empty;
public int LINEEXCTYP { get; set; }
public int ONLYONEPAYLINE { get; set; }
public int DISCFLAG { get; set; }
public double DISCRATE { get; set; }
public double VATRATE { get; set; }
public double CASHAMOUNT { get; set; }
public int DISCACCREF { get; set; }
public int DISCCENREF { get; set; }
public int VATRACCREF { get; set; }
public int VATRCENREF { get; set; }
public int PAYMENTREF { get; set; }
public double VATAMOUNT { get; set; }
public int SITEID { get; set; }
public int RECSTATUS { get; set; }
public int ORGLOGICREF { get; set; }
public double INFIDX { get; set; }
public int POSCOMMACCREF { get; set; }
public int POSCOMMCENREF { get; set; }
public int POINTCOMMACCREF { get; set; }
public int POINTCOMMCENREF { get; set; }
public string CHEQINFO { get; set; } = string.Empty;
public string CREDITCNO { get; set; } = string.Empty;
public int CLPRJREF { get; set; }
public int STATUS { get; set; }
public int EXIMFILEREF { get; set; }
public int EXIMPROCNR { get; set; }
public int MONTH_ { get; set; }
public int YEAR_ { get; set; }
public double FUNDSHARERAT { get; set; }
public int AFFECTCOLLATRL { get; set; }
public int GRPFIRMTRANS { get; set; }
public int REFLVATACCREF { get; set; }
public int REFLVATOTHACCREF { get; set; }
public int AFFECTRISK { get; set; }
public int BATCHNR { get; set; }
public int APPROVENR { get; set; }
public string BATCHNUM { get; set; } = string.Empty;
public string APPROVENUM { get; set; } = string.Empty;
public int EUVATSTATUS { get; set; }
public string ORGLOGOID { get; set; } = string.Empty;
public int EXIMTYPE { get; set; }
public int EIDISTFLNNR { get; set; }
public int EISRVDSTTYP { get; set; }
public int EXIMDISTTYP { get; set; }
public int SALESMANREF { get; set; }
public int BANKACCREF { get; set; }
public int BNACCREF { get; set; }
public int BNCENTERREF { get; set; }
public DateTime DEVIRPROCDATE { get; set; }
public DateTime DOCDATE { get; set; }
public int INSTALREF { get; set; }
public int DEVIR { get; set; }
public int DEVIRMODULENR { get; set; }
public int FTIME { get; set; }
public int OFFERREF { get; set; }
public int RETCCFCREF { get; set; }
public int EMFLINEREF { get; set; }
public int FROMEXCHDIFF { get; set; }
public int CANDEDUCT { get; set; }
public int DEDUCTIONPART1 { get; set; }
public int DEDUCTIONPART2 { get; set; }
public int UNDERDEDUCTLIMIT { get; set; }
public double VATDEDUCTRATE { get; set; }
public int VATDEDUCTACCREF { get; set; }
public int VATDEDUCTOTHACCREF { get; set; }
public int VATDEDUCTCENREF { get; set; }
public int VATDEDUCTOTHCENREF { get; set; }
public int CANTCREDEDUCT { get; set; }
public string GUID { get; set; } = string.Empty;
public int PAIDINCASH { get; set; }
public double BRUTAMOUNT { get; set; }
public double NETAMOUNT { get; set; }
public double BRUTAMOUNTTR { get; set; }
public double NETAMOUNTTR { get; set; }
public double BRUTAMOUNTREP { get; set; }
public double NETAMOUNTREP { get; set; }
public int BNLNTRCURR { get; set; }
public double BNLNTRRATE { get; set; }
public double BNLNTRNET { get; set; }
public DateTime PRINTDATE { get; set; }
public int INCDEDUCTAMNT { get; set; }
public int AFFECTCOST { get; set; }
public int FOREXIM { get; set; }
public string EXIMFILECODECLF { get; set; } = string.Empty;
public string SPECODE2 { get; set; } = string.Empty;
public string SERVREASONDEF { get; set; } = string.Empty;
}
}