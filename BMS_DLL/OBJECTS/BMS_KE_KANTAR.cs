using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_DLL.OBJECTS
{
    public class BMS_KE_KANTAR
    {
        public int LOGICALREF { get; set; }
        public DateTime TARIH { get; set; }
        public int PLAKAID { get; set; }
        public int KONTRAKTORID { get; set; }
        public int URETICIID { get; set; }
        public int URUNID { get; set; }
        public double MIKTAR { get; set; }
        public string BIRIM { get; set; } = string.Empty;
        public string KULLANICI { get; set; } = string.Empty;
        public int BARKODYAZIMMIKTAR { get; set; }
        public string ACIKLAMA { get; set; } = string.Empty;
        public int LOGOAKTARIMI { get; set; }
        public DateTime LOGOAKTARIMTARIHI { get; set; }
        public int LOGOFISID { get; set; }
        public string ERRORMESSAGE { get; set; } = string.Empty;
        public int TSTATUS { get; set; }
        public string TARTI_BELGE_NO { get; set; } = string.Empty;
        public string SOZLESME_NO { get; set; } = string.Empty;

        public int AMBARID_GIDECEGIYERKOD { get; set; }
        public string OZELKOD_BOLGEKOD { get; set; }
        public string YETKIKOD_BOLGEDETAYKOD { get; set; }
        public int ODEMEPLANID_SOZLESMETURUKOD { get; set; }
        public int SALEMANID_SOKOD { get; set; }

        public string AMBARID_GIDECEGIYER { get; set; }
        public string OZELKOD_BOLGE { get; set; }
        public string YETKIKOD_BOLGEDETAY { get; set; }
        public string ODEMEPLANID_SOZLESMETURU { get; set; }
        public string SALEMANID_SO { get; set; }
        public double BINLIKSAYISI { get; set; }
    }
}