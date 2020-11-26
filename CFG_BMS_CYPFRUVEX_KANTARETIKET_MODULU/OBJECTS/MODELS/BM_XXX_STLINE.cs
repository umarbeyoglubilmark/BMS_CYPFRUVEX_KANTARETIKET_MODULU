using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class BM_XXX_STLINE {
        public int LOGICALREF { get; set; }
        public int FICHEREF { get; set; }
        public int ITEMREF { get; set; }
        public string DOVIZ { get; set; } = string.Empty;
        public double DOVIZ_KUR { get; set; }
        public double UNITPRICE { get; set; }
        public double AMOUNT { get; set; }
        public double TOTAL { get; set; }
        public string DESCRIPTION { get; set; } = string.Empty;
        public DateTime CREATEDDATE { get; set; }
    }
}