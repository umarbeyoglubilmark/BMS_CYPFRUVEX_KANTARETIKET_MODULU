using System;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.CONVERTER
{
 public class CONVERTDATATOMODELS
{


public List<BMS_KE_KANTAR> BMS_KE_KANTAR_CONVERT_FROM_DATATABLE(DataTable dt)
{
List<BMS_KE_KANTAR> L = new List<BMS_KE_KANTAR>();
foreach (DataRow r in dt.Rows) {
BMS_KE_KANTAR B = new BMS_KE_KANTAR();
try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
try { B.TARIH = (DateTime)r["TARIH"]; } catch { }
try { B.PLAKAID = (int)r["PLAKAID"]; } catch { }
try { B.KONTRAKTORID = (int)r["KONTRAKTORID"]; } catch { }
try { B.URETICIID = (int)r["URETICIID"]; } catch { }
try { B.URUNID = (int)r["URUNID"]; } catch { }
try { B.MIKTAR = (double)r["MIKTAR"]; } catch { }
try { B.BIRIM = (string)r["BIRIM"]; } catch { }
try { B.KULLANICI = (string)r["KULLANICI"]; } catch { }
try { B.BARKODYAZIMMIKTAR = (int)r["BARKODYAZIMMIKTAR"]; } catch { }
try { B.ACIKLAMA = (string)r["ACIKLAMA"]; } catch { }
try { B.LOGOAKTARIMI = (int)r["LOGOAKTARIMI"]; } catch { }
try { B.LOGOAKTARIMTARIHI = (DateTime)r["LOGOAKTARIMTARIHI"]; } catch { }
try { B.LOGOFISID = (int)r["LOGOFISID"]; } catch { }
try { B.ERRORMESSAGE = (string)r["ERRORMESSAGE"]; } catch { }
try { B.TSTATUS = (int)r["TSTATUS"]; } catch { }
L.Add(B);
}
return L;
}

public BMS_KE_KANTAR BMS_KE_KANTAR_CONVERT_FROM_DATAROW(DataRow r)
{
BMS_KE_KANTAR B = new BMS_KE_KANTAR();
try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
try { B.TARIH = (DateTime)r["TARIH"]; } catch { }
try { B.PLAKAID = (int)r["PLAKAID"]; } catch { }
try { B.KONTRAKTORID = (int)r["KONTRAKTORID"]; } catch { }
try { B.URETICIID = (int)r["URETICIID"]; } catch { }
try { B.URUNID = (int)r["URUNID"]; } catch { }
try { B.MIKTAR = (double)r["MIKTAR"]; } catch { }
try { B.BIRIM = (string)r["BIRIM"]; } catch { }
try { B.KULLANICI = (string)r["KULLANICI"]; } catch { }
try { B.BARKODYAZIMMIKTAR = (int)r["BARKODYAZIMMIKTAR"]; } catch { }
try { B.ACIKLAMA = (string)r["ACIKLAMA"]; } catch { }
try { B.LOGOAKTARIMI = (int)r["LOGOAKTARIMI"]; } catch { }
try { B.LOGOAKTARIMTARIHI = (DateTime)r["LOGOAKTARIMTARIHI"]; } catch { }
try { B.LOGOFISID = (int)r["LOGOFISID"]; } catch { }
try { B.ERRORMESSAGE = (string)r["ERRORMESSAGE"]; } catch { }
try { B.TSTATUS = (int)r["TSTATUS"]; } catch { }
return B;
}
}
}