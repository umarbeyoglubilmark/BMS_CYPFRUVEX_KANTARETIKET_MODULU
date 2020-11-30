using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU.SQLCOMMANDS
{
 public class SQLUPDATECOMMANDS 
{

public SqlCommand BMS_KE_KANTAR_UPDATE(BMS_KE_KANTAR B, bool UPDATEBM, bool UPDATELOGICALREF, string WHERECLAUSE, object WHEREVALUE)
{
   try
   {
      string tableName = "BMS_KE_KANTAR";
   if (!UPDATEBM)
   tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_") ; 
 
SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " TARIH = @TARIH, PLAKAID = @PLAKAID, KONTRAKTORID = @KONTRAKTORID, URETICIID = @URETICIID, URUNID = @URUNID, MIKTAR = @MIKTAR, BIRIM = @BIRIM, KULLANICI = @KULLANICI, BARKODYAZIMMIKTAR = @BARKODYAZIMMIKTAR, ACIKLAMA = @ACIKLAMA, LOGOAKTARIMI = @LOGOAKTARIMI, LOGOAKTARIMTARIHI = @LOGOAKTARIMTARIHI, LOGOFISID = @LOGOFISID, ERRORMESSAGE = @ERRORMESSAGE, TSTATUS = @TSTATUS WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
 try { com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF); } catch {  com.Parameters.AddWithValue("@LOGICALREF",  DBNull.Value); }
if (B.TARIH != new DateTime()) 
      com.Parameters.AddWithValue("@TARIH", B.TARIH);
else 
       com.Parameters.AddWithValue("@TARIH", DBNull.Value);
 try { com.Parameters.AddWithValue("@PLAKAID", B.PLAKAID); } catch {  com.Parameters.AddWithValue("@PLAKAID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@KONTRAKTORID", B.KONTRAKTORID); } catch {  com.Parameters.AddWithValue("@KONTRAKTORID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@URETICIID", B.URETICIID); } catch {  com.Parameters.AddWithValue("@URETICIID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@URUNID", B.URUNID); } catch {  com.Parameters.AddWithValue("@URUNID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@MIKTAR", B.MIKTAR); } catch {  com.Parameters.AddWithValue("@MIKTAR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BIRIM", B.BIRIM); } catch {  com.Parameters.AddWithValue("@BIRIM",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@KULLANICI", B.KULLANICI); } catch {  com.Parameters.AddWithValue("@KULLANICI",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@BARKODYAZIMMIKTAR", B.BARKODYAZIMMIKTAR); } catch {  com.Parameters.AddWithValue("@BARKODYAZIMMIKTAR",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ACIKLAMA", B.ACIKLAMA); } catch {  com.Parameters.AddWithValue("@ACIKLAMA",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@LOGOAKTARIMI", B.LOGOAKTARIMI); } catch {  com.Parameters.AddWithValue("@LOGOAKTARIMI",  DBNull.Value); }
if (B.LOGOAKTARIMTARIHI != new DateTime()) 
      com.Parameters.AddWithValue("@LOGOAKTARIMTARIHI", B.LOGOAKTARIMTARIHI);
else 
       com.Parameters.AddWithValue("@LOGOAKTARIMTARIHI", DBNull.Value);
 try { com.Parameters.AddWithValue("@LOGOFISID", B.LOGOFISID); } catch {  com.Parameters.AddWithValue("@LOGOFISID",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@ERRORMESSAGE", B.ERRORMESSAGE); } catch {  com.Parameters.AddWithValue("@ERRORMESSAGE",  DBNull.Value); }
 try { com.Parameters.AddWithValue("@TSTATUS", B.TSTATUS); } catch {  com.Parameters.AddWithValue("@TSTATUS",  DBNull.Value); }
      com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

      return com;
   }
   catch
   {
      return null;
   }
}


}
}