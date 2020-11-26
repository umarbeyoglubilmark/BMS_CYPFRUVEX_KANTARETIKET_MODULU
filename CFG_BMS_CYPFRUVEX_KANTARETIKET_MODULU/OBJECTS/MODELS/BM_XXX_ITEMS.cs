using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class BM_XXX_ITEMS {
        public int LOGICALREF { get; set; }
        public string CODE { get; set; } = string.Empty;
        public string DEFINITION_ { get; set; } = string.Empty;
        public int UNITREF { get; set; }
        public string MARKA { get; set; } = string.Empty;
        public string MODEL { get; set; } = string.Empty;
        public DateTime YIL { get; set; }
        public string ARAC { get; set; } = string.Empty;
        public string BARKOD { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public DateTime CREATEDDATE { get; set; }
        public int ACTIVE { get; set; }
    }
}