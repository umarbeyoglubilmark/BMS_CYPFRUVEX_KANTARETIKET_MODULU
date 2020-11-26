using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class BM_XXX_CLFICHE {
        public int LOGICALREF { get; set; }
        public string FICHENO { get; set; } = string.Empty;
        public string TYPE { get; set; } = string.Empty;
        public string SIGN { get; set; } = string.Empty;
        public int CARDREF { get; set; }
        public DateTime DATE_ { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string DESCRIPTION { get; set; } = string.Empty;
    }
}