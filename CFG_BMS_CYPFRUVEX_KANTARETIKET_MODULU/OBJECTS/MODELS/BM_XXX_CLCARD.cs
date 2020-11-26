using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class BM_XXX_CLCARD {
        public int LOGICALREF { get; set; }
        public string CODE { get; set; } = string.Empty;
        public string DEFINITION_ { get; set; } = string.Empty;
        public string ADDRESS { get; set; } = string.Empty;
        public string PHONE { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public DateTime CREATEDDATE { get; set; }
        public int ACTIVE { get; set; }
    }
}