using System.Collections.Generic;
using System.Data;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.METHODS {
    public class BM_DEVIR_YANSITMA_SABLON {
        public int LOGICALREF { get; set; }
        public int FIRMANR { get; set; }
        public string GIDER_HESAP_KODU { get; set; }
        public string YANSITMA1_YANSITSINMI { get; set; }
        public string YANSITMA2_YANSITSINMI { get; set; }
        public string OZEL_KOD { get; set; }
        public string YETKI_KODU { get; set; }
    }
    public class BM_DEVIR_YANSITMA_SABLONL {
        public int LOGICALREF { get; set; }
        public int LOGICALREFM { get; set; }
        public int FIRMNR { get; set; }
        public string GIDER_BASLANGIC_HESAP { get; set; }
        public string GIDER_BITIS_HESAP { get; set; }
        public double GIDER_BA_BI_ORAN { get; set; }
        public string GIDER_YANSITMA_HESAP { get; set; }
        public double GIDER_YA_ORAN { get; set; }
        public string GELIR_YANSITMA_HESAP { get; set; }
        public double GELIR_YA_ORAN { get; set; }
        public string MASRAF_MERKEZI { get; set; }
        public string PROJE_KODU { get; set; }
    }


}
