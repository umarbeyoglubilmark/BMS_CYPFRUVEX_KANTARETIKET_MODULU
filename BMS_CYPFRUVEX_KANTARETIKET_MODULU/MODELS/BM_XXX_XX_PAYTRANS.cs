using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS
{
 public class BM_XXX_XX_PAYTRANS
{
public int LOGICALREF { get; set; }
public int CARDREF { get; set; }
public DateTime DATE_ { get; set; }
public int MODULENR { get; set; }
public int SIGN { get; set; }
public int FICHEREF { get; set; }
public int FICHELINEREF { get; set; }
public int TRCODE { get; set; }
public double TOTAL { get; set; }
public double PAID { get; set; }
public double EARLYINTRATE { get; set; }
public double LATELYINTRATE { get; set; }
public int CROSSREF { get; set; }
public int PAIDINCASH { get; set; }
public int CANCELLED { get; set; }
public DateTime PROCDATE { get; set; }
public int TRCURR { get; set; }
public double TRRATE { get; set; }
public double REPORTRATE { get; set; }
public int MODIFIED { get; set; }
public int REMINDLEV { get; set; }
public int REMINDSENT { get; set; }
public int CROSSCURR { get; set; }
public double CROSSTOTAL { get; set; }
public int DISCFLAG { get; set; }
public int SITEID { get; set; }
public int ORGLOGICREF { get; set; }
public int WFSTATUS { get; set; }
public double CLOSINGRATE { get; set; }
public DateTime DISCDUEDATE { get; set; }
public int OPSTAT { get; set; }
public int RECSTATUS { get; set; }
public double INFIDX { get; set; }
public int PAYNO { get; set; }
public double DELAYTOTAL { get; set; }
public int LASTSENDREMLEV { get; set; }
public int POINTTRANS { get; set; }
public DateTime BANKPAYDATE { get; set; }
public double POSCOMSN { get; set; }
public double POINTCOMSN { get; set; }
public int BANKACCREF { get; set; }
public int PAYMENTTYPE { get; set; }
public int CASHACCREF { get; set; }
public double TRNET { get; set; }
public int REPAYPLANREF { get; set; }
public double DUEDIFFCOMSN { get; set; }
public int CALCTYPE { get; set; }
public double NETTOTAL { get; set; }
public int REPYPLNAPPLIED { get; set; }
public int PAYTRCURR { get; set; }
public double PAYTRRATE { get; set; }
public double PAYTRNET { get; set; }
public int BNTRCREATED { get; set; }
public int BNFCHREF { get; set; }
public int BNFLNREF { get; set; }
public int INSTALTYPE { get; set; }
public int INSTALREF { get; set; }
public int MAININSTALREF { get; set; }
public string ORGLOGOID { get; set; } = string.Empty;
public int STLINEREF { get; set; }
public string SPECODE { get; set; } = string.Empty;
public string CREDITCARDNUM { get; set; } = string.Empty;
public DateTime VALBEGDATE { get; set; }
public string RETREFNO { get; set; } = string.Empty;
public string DOCODE { get; set; } = string.Empty;
public string BATCHNUM { get; set; } = string.Empty;
public string APPROVENUM { get; set; } = string.Empty;
public string POSTERMINALNUM { get; set; } = string.Empty;
public int CLDIFFINV { get; set; }
public string LINEEXP { get; set; } = string.Empty;
public DateTime DEVIRPROCDATE { get; set; }
public int DEVIR { get; set; }
public int DEVIRCARDREF { get; set; }
public string GLOBALCODE { get; set; } = string.Empty;
public string CLBNACCOUNTNO { get; set; } = string.Empty;
public DateTime MATCHDATE { get; set; }
public int DEVIRBRANCH { get; set; }
public int DEVIRDEPARTMENT { get; set; }
public int DEVIRFICHEREF { get; set; }
public int DEVIRLINEREF { get; set; }
public double CURRDIFFRATE { get; set; }
public int CURRDIFFCLOSED { get; set; }
public int CURRDIFFCLSREF { get; set; } 
}
}