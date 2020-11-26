using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class SQLUPDATECOMMANDS {

        public SqlCommand BM_XXX_CLCARD_UPDATE(BM_XXX_CLCARD B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_CLCARD";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " CODE = @CODE, DEFINITION_ = @DEFINITION_, ADDRESS = @ADDRESS, PHONE = @PHONE, DESCRIPTION = @DESCRIPTION, CREATEDDATE = @CREATEDDATE, ACTIVE = @ACTIVE WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@CODE", B.CODE);
                com.Parameters.AddWithValue("@DEFINITION_", B.DEFINITION_);
                com.Parameters.AddWithValue("@ADDRESS", B.ADDRESS);
                com.Parameters.AddWithValue("@PHONE", B.PHONE);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                if (B.CREATEDDATE != new DateTime())
                    com.Parameters.AddWithValue("@CREATEDDATE", B.CREATEDDATE);
                else
                    com.Parameters.AddWithValue("@CREATEDDATE", DBNull.Value);
                com.Parameters.AddWithValue("@ACTIVE", B.ACTIVE);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_CLFICHE_UPDATE(BM_XXX_CLFICHE B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_CLFICHE";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " FICHENO = @FICHENO, TYPE = @TYPE, SIGN = @SIGN, CARDREF = @CARDREF, DATE_ = @DATE_, CREATEDDATE = @CREATEDDATE, DESCRIPTION = @DESCRIPTION WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@FICHENO", B.FICHENO);
                com.Parameters.AddWithValue("@TYPE", B.TYPE);
                com.Parameters.AddWithValue("@SIGN", B.SIGN);
                com.Parameters.AddWithValue("@CARDREF", B.CARDREF);
                if (B.DATE_ != new DateTime())
                    com.Parameters.AddWithValue("@DATE_", B.DATE_);
                else
                    com.Parameters.AddWithValue("@DATE_", DBNull.Value);
                if (B.CREATEDDATE != new DateTime())
                    com.Parameters.AddWithValue("@CREATEDDATE", B.CREATEDDATE);
                else
                    com.Parameters.AddWithValue("@CREATEDDATE", DBNull.Value);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_CLFLINE_UPDATE(BM_XXX_CLFLINE B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_CLFLINE";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " FICHEREF = @FICHEREF, DOVIZ = @DOVIZ, DOVIZ_KUR = @DOVIZ_KUR, AMOUNT = @AMOUNT, DESCRIPTION = @DESCRIPTION, CREATEDDATE = @CREATEDDATE WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@FICHEREF", B.FICHEREF);
                com.Parameters.AddWithValue("@DOVIZ", B.DOVIZ);
                com.Parameters.AddWithValue("@DOVIZ_KUR", B.DOVIZ_KUR);
                com.Parameters.AddWithValue("@AMOUNT", B.AMOUNT);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                if (B.CREATEDDATE != new DateTime())
                    com.Parameters.AddWithValue("@CREATEDDATE", B.CREATEDDATE);
                else
                    com.Parameters.AddWithValue("@CREATEDDATE", DBNull.Value);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_ITEMS_UPDATE(BM_XXX_ITEMS B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_ITEMS";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " CODE = @CODE, DEFINITION_ = @DEFINITION_, UNITREF = @UNITREF, MARKA = @MARKA, MODEL = @MODEL, YIL = @YIL, ARAC = @ARAC, BARKOD = @BARKOD, DESCRIPTION = @DESCRIPTION, CREATEDDATE = @CREATEDDATE, ACTIVE = @ACTIVE WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@CODE", B.CODE);
                com.Parameters.AddWithValue("@DEFINITION_", B.DEFINITION_);
                com.Parameters.AddWithValue("@UNITREF", B.UNITREF);
                com.Parameters.AddWithValue("@MARKA", B.MARKA);
                com.Parameters.AddWithValue("@MODEL", B.MODEL);
                if (B.YIL != new DateTime())
                    com.Parameters.AddWithValue("@YIL", B.YIL);
                else
                    com.Parameters.AddWithValue("@YIL", DBNull.Value);
                com.Parameters.AddWithValue("@ARAC", B.ARAC);
                com.Parameters.AddWithValue("@BARKOD", B.BARKOD);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                if (B.CREATEDDATE != new DateTime())
                    com.Parameters.AddWithValue("@CREATEDDATE", B.CREATEDDATE);
                else
                    com.Parameters.AddWithValue("@CREATEDDATE", DBNull.Value);
                com.Parameters.AddWithValue("@ACTIVE", B.ACTIVE);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_ITEMUNIT_UPDATE(BM_XXX_ITEMUNIT B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_ITEMUNIT";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " CODE = @CODE, DEFINITION_ = @DEFINITION_ WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@CODE", B.CODE);
                com.Parameters.AddWithValue("@DEFINITION_", B.DEFINITION_);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_STFICHE_UPDATE(BM_XXX_STFICHE B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_STFICHE";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " FICHENO = @FICHENO, TYPE = @TYPE, SIGN = @SIGN, CARDREF = @CARDREF, DATE_ = @DATE_, DESCRIPTION = @DESCRIPTION, CREATEDDATE = @CREATEDDATE WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@FICHENO", B.FICHENO);
                com.Parameters.AddWithValue("@TYPE", B.TYPE);
                com.Parameters.AddWithValue("@SIGN", B.SIGN);
                com.Parameters.AddWithValue("@CARDREF", B.CARDREF);
                if (B.DATE_ != new DateTime())
                    com.Parameters.AddWithValue("@DATE_", B.DATE_);
                else
                    com.Parameters.AddWithValue("@DATE_", DBNull.Value);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                if (B.CREATEDDATE != new DateTime())
                    com.Parameters.AddWithValue("@CREATEDDATE", B.CREATEDDATE);
                else
                    com.Parameters.AddWithValue("@CREATEDDATE", DBNull.Value);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_STLINE_UPDATE(BM_XXX_STLINE B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_XXX_STLINE";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " FICHEREF = @FICHEREF, ITEMREF = @ITEMREF, DOVIZ = @DOVIZ, DOVIZ_KUR = @DOVIZ_KUR, UNITPRICE = @UNITPRICE, AMOUNT = @AMOUNT, TOTAL = @TOTAL, DESCRIPTION = @DESCRIPTION, CREATEDDATE = @CREATEDDATE WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@FICHEREF", B.FICHEREF);
                com.Parameters.AddWithValue("@ITEMREF", B.ITEMREF);
                com.Parameters.AddWithValue("@DOVIZ", B.DOVIZ);
                com.Parameters.AddWithValue("@DOVIZ_KUR", B.DOVIZ_KUR);
                com.Parameters.AddWithValue("@UNITPRICE", B.UNITPRICE);
                com.Parameters.AddWithValue("@AMOUNT", B.AMOUNT);
                com.Parameters.AddWithValue("@TOTAL", B.TOTAL);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                if (B.CREATEDDATE != new DateTime())
                    com.Parameters.AddWithValue("@CREATEDDATE", B.CREATEDDATE);
                else
                    com.Parameters.AddWithValue("@CREATEDDATE", DBNull.Value);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_CAPIFIRM_UPDATE(BM_CAPIFIRM B, bool UPDATEBM, bool UPDATELOGICALREF, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_CAPIFIRM";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_");

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + "  DEFITINION_ = @DEFITINION_, PHONE = @PHONE, ADDRESS = @ADDRESS, DESCRIPTION = @DESCRIPTION WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@DEFITINION_", B.DEFITINION_);
                com.Parameters.AddWithValue("@PHONE", B.PHONE);
                com.Parameters.AddWithValue("@ADDRESS", B.ADDRESS);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_USERS_UPDATE(BM_USERS B, bool UPDATEBM, bool UPDATELOGICALREF, string WHERECLAUSE, object WHEREVALUE) {
            try {
                string tableName = "BM_USERS";
                if (!UPDATEBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_");

                SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + "  USERNAME = @USERNAME, PASSWORD = @PASSWORD, BACKGROUND = @BACKGROUND, ACTIVE = @ACTIVE WHERE " + WHERECLAUSE + " = " + WHEREVALUE + " SELECT @@ROWCOUNT");
                com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@USERNAME", B.USERNAME);
                com.Parameters.AddWithValue("@PASSWORD", B.PASSWORD);
                com.Parameters.AddWithValue("@BACKGROUND", B.BACKGROUND);
                com.Parameters.AddWithValue("@ACTIVE", B.ACTIVE);
                com.Parameters.AddWithValue("@WHERECLAUSE", WHERECLAUSE);
                com.Parameters.AddWithValue("@WHEREVALUE", WHEREVALUE);

                return com;
            } catch {
                return null;
            }
        }


    }
}