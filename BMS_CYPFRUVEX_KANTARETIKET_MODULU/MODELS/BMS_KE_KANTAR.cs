using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS
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
}
}