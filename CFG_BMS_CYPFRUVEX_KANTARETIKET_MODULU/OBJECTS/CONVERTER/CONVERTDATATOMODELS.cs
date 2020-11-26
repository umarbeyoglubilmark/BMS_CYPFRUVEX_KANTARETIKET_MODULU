using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;

namespace CFG_BMS_CYPFRUVEX_KANTARETIKET_MODULU.OBJECTS {
    public class CONVERTDATATOMODELS {


        public List<BM_XXX_CLCARD> BM_XXX_CLCARD_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_CLCARD> L = new List<BM_XXX_CLCARD>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_CLCARD B = new BM_XXX_CLCARD();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.CODE = (string)r["CODE"]; } catch { }
                try { B.DEFINITION_ = (string)r["DEFINITION_"]; } catch { }
                try { B.ADDRESS = (string)r["ADDRESS"]; } catch { }
                try { B.PHONE = (string)r["PHONE"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
                try { B.ACTIVE = (int)r["ACTIVE"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_CLCARD BM_XXX_CLCARD_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_CLCARD B = new BM_XXX_CLCARD();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.CODE = (string)r["CODE"]; } catch { }
            try { B.DEFINITION_ = (string)r["DEFINITION_"]; } catch { }
            try { B.ADDRESS = (string)r["ADDRESS"]; } catch { }
            try { B.PHONE = (string)r["PHONE"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
            try { B.ACTIVE = (int)r["ACTIVE"]; } catch { }
            return B;
        }

        public List<BM_XXX_CLFICHE> BM_XXX_CLFICHE_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_CLFICHE> L = new List<BM_XXX_CLFICHE>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_CLFICHE B = new BM_XXX_CLFICHE();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.FICHENO = (string)r["FICHENO"]; } catch { }
                try { B.TYPE = (string)r["TYPE"]; } catch { }
                try { B.SIGN = (string)r["SIGN"]; } catch { }
                try { B.CARDREF = (int)r["CARDREF"]; } catch { }
                try { B.DATE_ = (DateTime)r["DATE_"]; } catch { }
                try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_CLFICHE BM_XXX_CLFICHE_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_CLFICHE B = new BM_XXX_CLFICHE();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.FICHENO = (string)r["FICHENO"]; } catch { }
            try { B.TYPE = (string)r["TYPE"]; } catch { }
            try { B.SIGN = (string)r["SIGN"]; } catch { }
            try { B.CARDREF = (int)r["CARDREF"]; } catch { }
            try { B.DATE_ = (DateTime)r["DATE_"]; } catch { }
            try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            return B;
        }

        public List<BM_XXX_CLFLINE> BM_XXX_CLFLINE_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_CLFLINE> L = new List<BM_XXX_CLFLINE>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_CLFLINE B = new BM_XXX_CLFLINE();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.FICHEREF = (int)r["FICHEREF"]; } catch { }
                try { B.DOVIZ = (string)r["DOVIZ"]; } catch { }
                try { B.DOVIZ_KUR = (double)r["DOVIZ_KUR"]; } catch { }
                try { B.AMOUNT = (double)r["AMOUNT"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_CLFLINE BM_XXX_CLFLINE_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_CLFLINE B = new BM_XXX_CLFLINE();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.FICHEREF = (int)r["FICHEREF"]; } catch { }
            try { B.DOVIZ = (string)r["DOVIZ"]; } catch { }
            try { B.DOVIZ_KUR = (double)r["DOVIZ_KUR"]; } catch { }
            try { B.AMOUNT = (double)r["AMOUNT"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
            return B;
        }

        public List<BM_XXX_ITEMS> BM_XXX_ITEMS_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_ITEMS> L = new List<BM_XXX_ITEMS>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_ITEMS B = new BM_XXX_ITEMS();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.CODE = (string)r["CODE"]; } catch { }
                try { B.DEFINITION_ = (string)r["DEFINITION_"]; } catch { }
                try { B.UNITREF = (int)r["UNITREF"]; } catch { }
                try { B.MARKA = (string)r["MARKA"]; } catch { }
                try { B.MODEL = (string)r["MODEL"]; } catch { }
                try { B.YIL = (DateTime)r["YIL"]; } catch { }
                try { B.ARAC = (string)r["ARAC"]; } catch { }
                try { B.BARKOD = (string)r["BARKOD"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
                try { B.ACTIVE = (int)r["ACTIVE"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_ITEMS BM_XXX_ITEMS_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_ITEMS B = new BM_XXX_ITEMS();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.CODE = (string)r["CODE"]; } catch { }
            try { B.DEFINITION_ = (string)r["DEFINITION_"]; } catch { }
            try { B.UNITREF = (int)r["UNITREF"]; } catch { }
            try { B.MARKA = (string)r["MARKA"]; } catch { }
            try { B.MODEL = (string)r["MODEL"]; } catch { }
            try { B.YIL = (DateTime)r["YIL"]; } catch { }
            try { B.ARAC = (string)r["ARAC"]; } catch { }
            try { B.BARKOD = (string)r["BARKOD"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
            try { B.ACTIVE = (int)r["ACTIVE"]; } catch { }
            return B;
        }

        public List<BM_XXX_ITEMUNIT> BM_XXX_ITEMUNIT_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_ITEMUNIT> L = new List<BM_XXX_ITEMUNIT>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_ITEMUNIT B = new BM_XXX_ITEMUNIT();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.CODE = (string)r["CODE"]; } catch { }
                try { B.DEFINITION_ = (string)r["DEFINITION_"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_ITEMUNIT BM_XXX_ITEMUNIT_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_ITEMUNIT B = new BM_XXX_ITEMUNIT();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.CODE = (string)r["CODE"]; } catch { }
            try { B.DEFINITION_ = (string)r["DEFINITION_"]; } catch { }
            return B;
        }

        public List<BM_XXX_STFICHE> BM_XXX_STFICHE_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_STFICHE> L = new List<BM_XXX_STFICHE>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_STFICHE B = new BM_XXX_STFICHE();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.FICHENO = (string)r["FICHENO"]; } catch { }
                try { B.TYPE = (string)r["TYPE"]; } catch { }
                try { B.SIGN = (string)r["SIGN"]; } catch { }
                try { B.CARDREF = (int)r["CARDREF"]; } catch { }
                try { B.DATE_ = (DateTime)r["DATE_"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_STFICHE BM_XXX_STFICHE_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_STFICHE B = new BM_XXX_STFICHE();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.FICHENO = (string)r["FICHENO"]; } catch { }
            try { B.TYPE = (string)r["TYPE"]; } catch { }
            try { B.SIGN = (string)r["SIGN"]; } catch { }
            try { B.CARDREF = (int)r["CARDREF"]; } catch { }
            try { B.DATE_ = (DateTime)r["DATE_"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
            return B;
        }

        public List<BM_XXX_STLINE> BM_XXX_STLINE_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_XXX_STLINE> L = new List<BM_XXX_STLINE>();
            foreach (DataRow r in dt.Rows) {
                BM_XXX_STLINE B = new BM_XXX_STLINE();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.FICHEREF = (int)r["FICHEREF"]; } catch { }
                try { B.ITEMREF = (int)r["ITEMREF"]; } catch { }
                try { B.DOVIZ = (string)r["DOVIZ"]; } catch { }
                try { B.DOVIZ_KUR = (double)r["DOVIZ_KUR"]; } catch { }
                try { B.UNITPRICE = (double)r["UNITPRICE"]; } catch { }
                try { B.AMOUNT = (double)r["AMOUNT"]; } catch { }
                try { B.TOTAL = (double)r["TOTAL"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_XXX_STLINE BM_XXX_STLINE_CONVERT_FROM_DATAROW(DataRow r) {
            BM_XXX_STLINE B = new BM_XXX_STLINE();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.FICHEREF = (int)r["FICHEREF"]; } catch { }
            try { B.ITEMREF = (int)r["ITEMREF"]; } catch { }
            try { B.DOVIZ = (string)r["DOVIZ"]; } catch { }
            try { B.DOVIZ_KUR = (double)r["DOVIZ_KUR"]; } catch { }
            try { B.UNITPRICE = (double)r["UNITPRICE"]; } catch { }
            try { B.AMOUNT = (double)r["AMOUNT"]; } catch { }
            try { B.TOTAL = (double)r["TOTAL"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            try { B.CREATEDDATE = (DateTime)r["CREATEDDATE"]; } catch { }
            return B;
        }

        public List<BM_CAPIFIRM> BM_CAPIFIRM_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_CAPIFIRM> L = new List<BM_CAPIFIRM>();
            foreach (DataRow r in dt.Rows) {
                BM_CAPIFIRM B = new BM_CAPIFIRM();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
                try { B.DEFITINION_ = (string)r["DEFITINION_"]; } catch { }
                try { B.PHONE = (string)r["PHONE"]; } catch { }
                try { B.ADDRESS = (string)r["ADDRESS"]; } catch { }
                try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_CAPIFIRM BM_CAPIFIRM_CONVERT_FROM_DATAROW(DataRow r) {
            BM_CAPIFIRM B = new BM_CAPIFIRM();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }
            try { B.DEFITINION_ = (string)r["DEFITINION_"]; } catch { }
            try { B.PHONE = (string)r["PHONE"]; } catch { }
            try { B.ADDRESS = (string)r["ADDRESS"]; } catch { }
            try { B.DESCRIPTION = (string)r["DESCRIPTION"]; } catch { }
            return B;
        }

        public List<BM_USERS> BM_USERS_CONVERT_FROM_DATATABLE(DataTable dt) {
            List<BM_USERS> L = new List<BM_USERS>();
            foreach (DataRow r in dt.Rows) {
                BM_USERS B = new BM_USERS();
                try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }

                try { B.USERNAME = (string)r["USERNAME"]; } catch { }
                try { B.PASSWORD = (string)r["PASSWORD"]; } catch { }
                try { B.BACKGROUND = (byte[])r["BACKGROUND"]; } catch { }
                try { B.ACTIVE = (int)r["ACTIVE"]; } catch { }
                L.Add(B);
            }
            return L;
        }

        public BM_USERS BM_USERS_CONVERT_FROM_DATAROW(DataRow r) {
            BM_USERS B = new BM_USERS();
            try { B.LOGICALREF = (int)r["LOGICALREF"]; } catch { }

            try { B.USERNAME = (string)r["USERNAME"]; } catch { }
            try { B.PASSWORD = (string)r["PASSWORD"]; } catch { }
            try { B.BACKGROUND = (byte[])r["BACKGROUND"]; } catch { }
            try { B.ACTIVE = (int)r["ACTIVE"]; } catch { }
            return B;
        }
    }
}