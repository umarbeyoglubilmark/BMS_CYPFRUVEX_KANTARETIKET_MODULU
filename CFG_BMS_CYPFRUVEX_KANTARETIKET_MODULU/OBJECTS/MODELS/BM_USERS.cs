using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class BM_USERS {
        public int LOGICALREF { get; set; }

        public string USERNAME { get; set; } = string.Empty;
        public string PASSWORD { get; set; } = string.Empty;
        public byte[] BACKGROUND { get; set; }
        public int ACTIVE { get; set; }
    }
}