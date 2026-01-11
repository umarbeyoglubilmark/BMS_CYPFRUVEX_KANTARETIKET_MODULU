using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_DLL.OBJECTS
{
    public class KAYITLAR
    {
        public int LOGICALREF { get; set; }
        public string FISNO { get; set; }
        public List<_KAYITLAR_DETAY> KAYITLAR_DETAY { get; set; }
        public class _KAYITLAR_DETAY
        {
            public int LOGICALREF { get; set; }
            public int KAYITLARREF { get; set; }
            public string MALZEMEKODU { get; set; }
        }

    }

}
