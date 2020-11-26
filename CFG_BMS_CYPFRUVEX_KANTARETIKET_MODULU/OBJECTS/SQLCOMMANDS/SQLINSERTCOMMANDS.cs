using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class SQLINSERTCOMMANDS {

        public SqlCommand BM_XXX_CLCARD_INSERT(BM_XXX_CLCARD B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_CLCARD";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "CODE, DEFINITION_, ADDRESS, PHONE, DESCRIPTION, CREATEDDATE, ACTIVE) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@CODE, @DEFINITION_, @ADDRESS, @PHONE, @DESCRIPTION, @CREATEDDATE, @ACTIVE) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
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

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_CLFICHE_INSERT(BM_XXX_CLFICHE B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_CLFICHE";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "FICHENO, TYPE, SIGN, CARDREF, DATE_, CREATEDDATE, DESCRIPTION) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@FICHENO, @TYPE, @SIGN, @CARDREF, @DATE_, @CREATEDDATE, @DESCRIPTION) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
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

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_CLFLINE_INSERT(BM_XXX_CLFLINE B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_CLFLINE";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "FICHEREF, DOVIZ, DOVIZ_KUR, AMOUNT, DESCRIPTION, CREATEDDATE) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@FICHEREF, @DOVIZ, @DOVIZ_KUR, @AMOUNT, @DESCRIPTION, @CREATEDDATE) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
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

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_ITEMS_INSERT(BM_XXX_ITEMS B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_ITEMS";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "CODE, DEFINITION_, UNITREF, MARKA, MODEL, YIL, ARAC, BARKOD, DESCRIPTION, CREATEDDATE, ACTIVE) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@CODE, @DEFINITION_, @UNITREF, @MARKA, @MODEL, @YIL, @ARAC, @BARKOD, @DESCRIPTION, @CREATEDDATE, @ACTIVE) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
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

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_ITEMUNIT_INSERT(BM_XXX_ITEMUNIT B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_ITEMUNIT";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "CODE, DEFINITION_) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@CODE, @DEFINITION_) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
                    com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@CODE", B.CODE);
                com.Parameters.AddWithValue("@DEFINITION_", B.DEFINITION_);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_STFICHE_INSERT(BM_XXX_STFICHE B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_STFICHE";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "FICHENO, TYPE, SIGN, CARDREF, DATE_, DESCRIPTION, CREATEDDATE) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@FICHENO, @TYPE, @SIGN, @CARDREF, @DATE_, @DESCRIPTION, @CREATEDDATE) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
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

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_XXX_STLINE_INSERT(BM_XXX_STLINE B, bool INSERTTOBM, bool INSERTLOGICALREF, string FIRMNR) {
            try {
                string tableName = "BM_XXX_STLINE";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "FICHEREF, ITEMREF, DOVIZ, DOVIZ_KUR, UNITPRICE, AMOUNT, TOTAL, DESCRIPTION, CREATEDDATE) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + "@FICHEREF, @ITEMREF, @DOVIZ, @DOVIZ_KUR, @UNITPRICE, @AMOUNT, @TOTAL, @DESCRIPTION, @CREATEDDATE) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
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

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_CAPIFIRM_INSERT(BM_CAPIFIRM B, bool INSERTTOBM, bool INSERTLOGICALREF) {
            try {
                string tableName = "BM_CAPIFIRM";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_");

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "DEFITINION_, PHONE, ADDRESS, DESCRIPTION) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + " @DEFITINION_, @PHONE, @ADDRESS, @DESCRIPTION) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
                    com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@DEFITINION_", B.DEFITINION_);
                com.Parameters.AddWithValue("@PHONE", B.PHONE);
                com.Parameters.AddWithValue("@ADDRESS", B.ADDRESS);
                com.Parameters.AddWithValue("@DESCRIPTION", B.DESCRIPTION);

                return com;
            } catch {
                return null;
            }
        }

        public SqlCommand BM_USERS_INSERT(BM_USERS B, bool INSERTTOBM, bool INSERTLOGICALREF) {
            try {
                string tableName = "BM_USERS";
                if (!INSERTTOBM)
                    tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_");

                SqlCommand com = new SqlCommand("INSERT INTO " + tableName + "(" + (INSERTLOGICALREF ? "LOGICALREF, " : "") + "USERNAME, PASSWORD, BACKGROUND, ACTIVE) VALUES (" + (INSERTLOGICALREF ? "@LOGICALREF, " : "") + " @USERNAME, @PASSWORD, @BACKGROUND, @ACTIVE) SELECT " +
                 (INSERTLOGICALREF ? "MAX(LOGICALREF) FROM " + tableName + "" : " SCOPE_IDENTITY() "));
                if (INSERTLOGICALREF)
                    com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
                com.Parameters.AddWithValue("@USERNAME", B.USERNAME);
                com.Parameters.AddWithValue("@PASSWORD", B.PASSWORD);
                com.Parameters.AddWithValue("@BACKGROUND", B.BACKGROUND);
                com.Parameters.AddWithValue("@ACTIVE", B.ACTIVE);

                return com;
            } catch {
                return null;
            }
        }


    }
}