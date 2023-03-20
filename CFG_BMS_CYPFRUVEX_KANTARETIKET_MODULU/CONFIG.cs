using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU
{
    public class CONFIG
    {
        public string VERITABANITURU { get; set; } = string.Empty;
        public string LGDBSERVER { get; set; } = string.Empty;
        public string LGDBDATABASE { get; set; } = string.Empty;
        public string LGDBUSERNAME { get; set; } = string.Empty;
        public string LGDBPASSWORD { get; set; } = string.Empty;
        public string MLD { get; set; } = string.Empty;
        public string BITAYKAMARKET1 { get; set; } = string.Empty;
        public string BITAYKAUSERNAME1 { get; set; } = string.Empty;
        public string BITAYKAPASSWORD1 { get; set; } = string.Empty;

        public string BITAYKAMARKET2 { get; set; } = string.Empty;
        public string BITAYKAUSERNAME2 { get; set; } = string.Empty;
        public string BITAYKAPASSWORD2 { get; set; } = string.Empty;

        public string BITAYKAMARKET3 { get; set; } = string.Empty;
        public string BITAYKAUSERNAME3 { get; set; } = string.Empty;
        public string BITAYKAPASSWORD3 { get; set; } = string.Empty;

        public string BITAYKAMARKET4 { get; set; } = string.Empty;
        public string BITAYKAUSERNAME4 { get; set; } = string.Empty;
        public string BITAYKAPASSWORD4 { get; set; } = string.Empty;

        public string BITAYKAMARKET5 { get; set; } = string.Empty;
        public string BITAYKAUSERNAME5 { get; set; } = string.Empty;
        public string BITAYKAPASSWORD5 { get; set; } = string.Empty;


        public string BITAYKAURL { get; set; } = string.Empty;
        public string FIRMNR { get; set; } = string.Empty;
        public string PERIOD { get; set; } = string.Empty;
        public string PREVIOUSFIRMNR { get; set; } = string.Empty;
        public string PREVIOUSPERIOD { get; set; } = string.Empty;
        public string URETICIBASLANGICKODU { get; set; } = string.Empty;
        public string KONTRAKTORBASLANGICKODU { get; set; } = string.Empty;
        public string URUNBASLANGICKODU { get; set; } = string.Empty;
        public string BMSDEFAULTUSERNAME { get; set; } = string.Empty;
        public string BMSDEFAULTPASSWORD { get; set; } = string.Empty;
        public string LOBJECTDEFAULTUSERNAME { get; set; } = string.Empty;
        public string LOBJECTDEFAULTPASSWORD { get; set; } = string.Empty;
        public int SERVICEPERIOD { get; set; }
        public int SERVICEPERIODTYPE { get; set; }
        public int SERVICETABLESDBCHOICE { get; set; }
        public string SERVICESTARTTIME { get; set; } = string.Empty;
        public string SERVICEFINISHTIME { get; set; } = string.Empty;
        public string LOGOTYPE { get; set; } = string.Empty;
        public int KantarSonrasiFaturaAc { get; set; } = 0;

    }
}
