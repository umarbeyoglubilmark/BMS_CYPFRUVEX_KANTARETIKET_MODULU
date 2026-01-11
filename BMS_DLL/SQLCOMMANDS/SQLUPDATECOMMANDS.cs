using BMS_DLL.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_DLL.SQLCOMMANDS
{
    public static class SQLUPDATECOMMANDS
    {
        //public static SqlCommand BM_XXX_ITEMS_UPDATE(BM_XXX_ITEMS B, bool UPDATEBM, bool UPDATELOGICALREF, string FIRMNR, string WHERECLAUSE, object WHEREVALUE)
        //{
        //    try
        //    {
        //        string tableName = "BM_XXX_ITEMS";
        //        if (!UPDATEBM)
        //            tableName = tableName.Replace("BM", "LG").Replace("BH", "LH").Replace("L_", "B_").Replace("XXX", FIRMNR);

        //        SqlCommand com = new SqlCommand("UPDATE " + tableName + " SET " + (UPDATELOGICALREF ? "LOGICALREF = @LOGICALREF, " : "") + " ACTIVE = @ACTIVE, CARDTYPE = @CARDTYPE, CODE = @CODE, NAME = @NAME, STGRPCODE = @STGRPCODE, PRODUCERCODE = @PRODUCERCODE, SPECODE = @SPECODE, CYPHCODE = @CYPHCODE, CLASSTYPE = @CLASSTYPE, PURCHBRWS = @PURCHBRWS, SALESBRWS = @SALESBRWS, MTRLBRWS = @MTRLBRWS, VAT = @VAT, PAYMENTREF = @PAYMENTREF, TRACKTYPE = @TRACKTYPE, LOCTRACKING = @LOCTRACKING, TOOL = @TOOL, AUTOINCSL = @AUTOINCSL, DIVLOTSIZE = @DIVLOTSIZE, SHELFLIFE = @SHELFLIFE, SHELFDATE = @SHELFDATE, DOMINANTREFS1 = @DOMINANTREFS1, DOMINANTREFS2 = @DOMINANTREFS2, DOMINANTREFS3 = @DOMINANTREFS3, DOMINANTREFS4 = @DOMINANTREFS4, DOMINANTREFS5 = @DOMINANTREFS5, DOMINANTREFS6 = @DOMINANTREFS6, DOMINANTREFS7 = @DOMINANTREFS7, DOMINANTREFS8 = @DOMINANTREFS8, DOMINANTREFS9 = @DOMINANTREFS9, DOMINANTREFS10 = @DOMINANTREFS10, DOMINANTREFS11 = @DOMINANTREFS11, DOMINANTREFS12 = @DOMINANTREFS12, IMAGEINC = @IMAGEINC, TEXTINC = @TEXTINC, DEPRTYPE = @DEPRTYPE, DEPRRATE = @DEPRRATE, DEPRDUR = @DEPRDUR, SALVAGEVAL = @SALVAGEVAL, REVALFLAG = @REVALFLAG, REVDEPRFLAG = @REVDEPRFLAG, PARTDEP = @PARTDEP, DEPRTYPE2 = @DEPRTYPE2, DEPRRATE2 = @DEPRRATE2, DEPRDUR2 = @DEPRDUR2, REVALFLAG2 = @REVALFLAG2, REVDEPRFLAG2 = @REVDEPRFLAG2, PARTDEP2 = @PARTDEP2, APPROVED = @APPROVED, UNITSETREF = @UNITSETREF, QCCSETREF = @QCCSETREF, DISTAMOUNT = @DISTAMOUNT, CAPIBLOCK_CREATEDBY = @CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE = @CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR = @CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN = @CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC = @CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY = @CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE = @CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR = @CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN = @CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC = @CAPIBLOCK_MODIFIEDSEC, SITEID = @SITEID, RECSTATUS = @RECSTATUS, ORGLOGICREF = @ORGLOGICREF, UNIVID = @UNIVID, DISTLOTUNITS = @DISTLOTUNITS, COMBLOTUNITS = @COMBLOTUNITS, WFSTATUS = @WFSTATUS, DISTPOINT = @DISTPOINT, CAMPPOINT = @CAMPPOINT, CANUSEINTRNS = @CANUSEINTRNS, ISONR = @ISONR, GROUPNR = @GROUPNR, PRODCOUNTRY = @PRODCOUNTRY, ADDTAXREF = @ADDTAXREF, QPRODAMNT = @QPRODAMNT, QPRODUOM = @QPRODUOM, QPRODSRCINDEX = @QPRODSRCINDEX, EXTACCESSFLAGS = @EXTACCESSFLAGS, PACKET = @PACKET, SALVAGEVAL2 = @SALVAGEVAL2, SELLVAT = @SELLVAT, RETURNVAT = @RETURNVAT, LOGOID = @LOGOID, LIDCONFIRMED = @LIDCONFIRMED, GTIPCODE = @GTIPCODE, EXPCTGNO = @EXPCTGNO, B2CCODE = @B2CCODE, MARKREF = @MARKREF, IMAGE2INC = @IMAGE2INC, AVRWHDURATION = @AVRWHDURATION, EXTCARDFLAGS = @EXTCARDFLAGS, MINORDAMOUNT = @MINORDAMOUNT, FREIGHTPLACE = @FREIGHTPLACE, FREIGHTTYPCODE1 = @FREIGHTTYPCODE1, FREIGHTTYPCODE2 = @FREIGHTTYPCODE2, FREIGHTTYPCODE3 = @FREIGHTTYPCODE3, FREIGHTTYPCODE4 = @FREIGHTTYPCODE4, FREIGHTTYPCODE5 = @FREIGHTTYPCODE5, FREIGHTTYPCODE6 = @FREIGHTTYPCODE6, FREIGHTTYPCODE7 = @FREIGHTTYPCODE7, FREIGHTTYPCODE8 = @FREIGHTTYPCODE8, FREIGHTTYPCODE9 = @FREIGHTTYPCODE9, FREIGHTTYPCODE10 = @FREIGHTTYPCODE10, STATECODE = @STATECODE, STATENAME = @STATENAME, EXPCATEGORY = @EXPCATEGORY, LOSTFACTOR = @LOSTFACTOR, TEXTINCENG = @TEXTINCENG, EANBARCODE = @EANBARCODE, DEPRCLASSTYPE = @DEPRCLASSTYPE, WFLOWCRDREF = @WFLOWCRDREF, SELLPRVAT = @SELLPRVAT, RETURNPRVAT = @RETURNPRVAT, LOWLEVELCODES1 = @LOWLEVELCODES1, LOWLEVELCODES2 = @LOWLEVELCODES2, LOWLEVELCODES3 = @LOWLEVELCODES3, LOWLEVELCODES4 = @LOWLEVELCODES4, LOWLEVELCODES5 = @LOWLEVELCODES5, LOWLEVELCODES6 = @LOWLEVELCODES6, LOWLEVELCODES7 = @LOWLEVELCODES7, LOWLEVELCODES8 = @LOWLEVELCODES8, LOWLEVELCODES9 = @LOWLEVELCODES9, LOWLEVELCODES10 = @LOWLEVELCODES10, ORGLOGOID = @ORGLOGOID, QPRODDEPART = @QPRODDEPART, CANCONFIGURE = @CANCONFIGURE, CHARSETREF = @CHARSETREF, CANDEDUCT = @CANDEDUCT, CONSCODEREF = @CONSCODEREF, SPECODE2 = @SPECODE2, SPECODE3 = @SPECODE3, SPECODE4 = @SPECODE4, SPECODE5 = @SPECODE5, EXPENSE = @EXPENSE, ORIGIN = @ORIGIN, NAME2 = @NAME2, COMPKDVUSE = @COMPKDVUSE, USEDINPERIODS = @USEDINPERIODS, EXIMTAX1 = @EXIMTAX1, EXIMTAX2 = @EXIMTAX2, EXIMTAX3 = @EXIMTAX3, EXIMTAX4 = @EXIMTAX4, EXIMTAX5 = @EXIMTAX5, PRODUCTLEVEL = @PRODUCTLEVEL, APPSPEVATMATRAH = @APPSPEVATMATRAH, NAME3 = @NAME3, FACOSTKEYS = @FACOSTKEYS, KKLINESDISABLE = @KKLINESDISABLE, APPROVE = @APPROVE, APPROVEDATE = @APPROVEDATE, GLOBALID = @GLOBALID, SALEDEDUCTPART1 = @SALEDEDUCTPART1, SALEDEDUCTPART2 = @SALEDEDUCTPART2, PURCDEDUCTPART1 = @PURCDEDUCTPART1, PURCDEDUCTPART2 = @PURCDEDUCTPART2, CATEGORYID = @CATEGORYID, CATEGORYNAME = @CATEGORYNAME, KEYWORD1 = @KEYWORD1, KEYWORD2 = @KEYWORD2, KEYWORD3 = @KEYWORD3, KEYWORD4 = @KEYWORD4, KEYWORD5 = @KEYWORD5, GUID = @GUID, DEMANDMEETSORTFLD1 = @DEMANDMEETSORTFLD1, DEMANDMEETSORTFLD2 = @DEMANDMEETSORTFLD2, DEMANDMEETSORTFLD3 = @DEMANDMEETSORTFLD3, DEMANDMEETSORTFLD4 = @DEMANDMEETSORTFLD4, DEMANDMEETSORTFLD5 = @DEMANDMEETSORTFLD5, DEDUCTCODE = @DEDUCTCODE, PROJECTREF = @PROJECTREF, NAME4 = @NAME4, QPRODSUBAMNT = @QPRODSUBAMNT, QPRODSUBUOM = @QPRODSUBUOM, QPRODSUBSRCINDEX = @QPRODSUBSRCINDEX, QPRODSUBDEPART = @QPRODSUBDEPART WHERE " + WHERECLAUSE + " = @" + WHERECLAUSE + " SELECT @@ROWCOUNT");
        //        com.Parameters.AddWithValue("@LOGICALREF", B.LOGICALREF);
        //        com.Parameters.AddWithValue("@ACTIVE", B.ACTIVE);
        //        com.Parameters.AddWithValue("@CARDTYPE", B.CARDTYPE);
        //        com.Parameters.AddWithValue("@CODE", B.CODE);
        //        com.Parameters.AddWithValue("@NAME", B.NAME);
        //        com.Parameters.AddWithValue("@STGRPCODE", B.STGRPCODE);
        //        com.Parameters.AddWithValue("@PRODUCERCODE", B.PRODUCERCODE);
        //        com.Parameters.AddWithValue("@SPECODE", B.SPECODE);
        //        com.Parameters.AddWithValue("@CYPHCODE", B.CYPHCODE);
        //        com.Parameters.AddWithValue("@CLASSTYPE", B.CLASSTYPE);
        //        com.Parameters.AddWithValue("@PURCHBRWS", B.PURCHBRWS);
        //        com.Parameters.AddWithValue("@SALESBRWS", B.SALESBRWS);
        //        com.Parameters.AddWithValue("@MTRLBRWS", B.MTRLBRWS);
        //        com.Parameters.AddWithValue("@VAT", B.VAT);
        //        com.Parameters.AddWithValue("@PAYMENTREF", B.PAYMENTREF);
        //        com.Parameters.AddWithValue("@TRACKTYPE", B.TRACKTYPE);
        //        com.Parameters.AddWithValue("@LOCTRACKING", B.LOCTRACKING);
        //        com.Parameters.AddWithValue("@TOOL", B.TOOL);
        //        com.Parameters.AddWithValue("@AUTOINCSL", B.AUTOINCSL);
        //        com.Parameters.AddWithValue("@DIVLOTSIZE", B.DIVLOTSIZE);
        //        com.Parameters.AddWithValue("@SHELFLIFE", B.SHELFLIFE);
        //        com.Parameters.AddWithValue("@SHELFDATE", B.SHELFDATE);
        //        com.Parameters.AddWithValue("@DOMINANTREFS1", B.DOMINANTREFS1);
        //        com.Parameters.AddWithValue("@DOMINANTREFS2", B.DOMINANTREFS2);
        //        com.Parameters.AddWithValue("@DOMINANTREFS3", B.DOMINANTREFS3);
        //        com.Parameters.AddWithValue("@DOMINANTREFS4", B.DOMINANTREFS4);
        //        com.Parameters.AddWithValue("@DOMINANTREFS5", B.DOMINANTREFS5);
        //        com.Parameters.AddWithValue("@DOMINANTREFS6", B.DOMINANTREFS6);
        //        com.Parameters.AddWithValue("@DOMINANTREFS7", B.DOMINANTREFS7);
        //        com.Parameters.AddWithValue("@DOMINANTREFS8", B.DOMINANTREFS8);
        //        com.Parameters.AddWithValue("@DOMINANTREFS9", B.DOMINANTREFS9);
        //        com.Parameters.AddWithValue("@DOMINANTREFS10", B.DOMINANTREFS10);
        //        com.Parameters.AddWithValue("@DOMINANTREFS11", B.DOMINANTREFS11);
        //        com.Parameters.AddWithValue("@DOMINANTREFS12", B.DOMINANTREFS12);
        //        com.Parameters.AddWithValue("@IMAGEINC", B.IMAGEINC);
        //        com.Parameters.AddWithValue("@TEXTINC", B.TEXTINC);
        //        com.Parameters.AddWithValue("@DEPRTYPE", B.DEPRTYPE);
        //        com.Parameters.AddWithValue("@DEPRRATE", B.DEPRRATE);
        //        com.Parameters.AddWithValue("@DEPRDUR", B.DEPRDUR);
        //        com.Parameters.AddWithValue("@SALVAGEVAL", B.SALVAGEVAL);
        //        com.Parameters.AddWithValue("@REVALFLAG", B.REVALFLAG);
        //        com.Parameters.AddWithValue("@REVDEPRFLAG", B.REVDEPRFLAG);
        //        com.Parameters.AddWithValue("@PARTDEP", B.PARTDEP);
        //        com.Parameters.AddWithValue("@DEPRTYPE2", B.DEPRTYPE2);
        //        com.Parameters.AddWithValue("@DEPRRATE2", B.DEPRRATE2);
        //        com.Parameters.AddWithValue("@DEPRDUR2", B.DEPRDUR2);
        //        com.Parameters.AddWithValue("@REVALFLAG2", B.REVALFLAG2);
        //        com.Parameters.AddWithValue("@REVDEPRFLAG2", B.REVDEPRFLAG2);
        //        com.Parameters.AddWithValue("@PARTDEP2", B.PARTDEP2);
        //        com.Parameters.AddWithValue("@APPROVED", B.APPROVED);
        //        com.Parameters.AddWithValue("@UNITSETREF", B.UNITSETREF);
        //        com.Parameters.AddWithValue("@QCCSETREF", B.QCCSETREF);
        //        com.Parameters.AddWithValue("@DISTAMOUNT", B.DISTAMOUNT);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDBY", B.CAPIBLOCK_CREATEDBY);
        //        if (B.CAPIBLOCK_CREADEDDATE != new DateTime())
        //            com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", B.CAPIBLOCK_CREADEDDATE);
        //        else
        //            com.Parameters.AddWithValue("@CAPIBLOCK_CREADEDDATE", DBNull.Value);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDHOUR", B.CAPIBLOCK_CREATEDHOUR);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDMIN", B.CAPIBLOCK_CREATEDMIN);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_CREATEDSEC", B.CAPIBLOCK_CREATEDSEC);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDBY", B.CAPIBLOCK_MODIFIEDBY);
        //        if (B.CAPIBLOCK_MODIFIEDDATE != new DateTime())
        //            com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", B.CAPIBLOCK_MODIFIEDDATE);
        //        else
        //            com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDDATE", DBNull.Value);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDHOUR", B.CAPIBLOCK_MODIFIEDHOUR);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDMIN", B.CAPIBLOCK_MODIFIEDMIN);
        //        com.Parameters.AddWithValue("@CAPIBLOCK_MODIFIEDSEC", B.CAPIBLOCK_MODIFIEDSEC);
        //        com.Parameters.AddWithValue("@SITEID", B.SITEID);
        //        com.Parameters.AddWithValue("@RECSTATUS", B.RECSTATUS);
        //        com.Parameters.AddWithValue("@ORGLOGICREF", B.ORGLOGICREF);
        //        com.Parameters.AddWithValue("@UNIVID", B.UNIVID);
        //        com.Parameters.AddWithValue("@DISTLOTUNITS", B.DISTLOTUNITS);
        //        com.Parameters.AddWithValue("@COMBLOTUNITS", B.COMBLOTUNITS);
        //        com.Parameters.AddWithValue("@WFSTATUS", B.WFSTATUS);
        //        com.Parameters.AddWithValue("@DISTPOINT", B.DISTPOINT);
        //        com.Parameters.AddWithValue("@CAMPPOINT", B.CAMPPOINT);
        //        com.Parameters.AddWithValue("@CANUSEINTRNS", B.CANUSEINTRNS);
        //        com.Parameters.AddWithValue("@ISONR", B.ISONR);
        //        com.Parameters.AddWithValue("@GROUPNR", B.GROUPNR);
        //        com.Parameters.AddWithValue("@PRODCOUNTRY", B.PRODCOUNTRY);
        //        com.Parameters.AddWithValue("@ADDTAXREF", B.ADDTAXREF);
        //        com.Parameters.AddWithValue("@QPRODAMNT", B.QPRODAMNT);
        //        com.Parameters.AddWithValue("@QPRODUOM", B.QPRODUOM);
        //        com.Parameters.AddWithValue("@QPRODSRCINDEX", B.QPRODSRCINDEX);
        //        com.Parameters.AddWithValue("@EXTACCESSFLAGS", B.EXTACCESSFLAGS);
        //        com.Parameters.AddWithValue("@PACKET", B.PACKET);
        //        com.Parameters.AddWithValue("@SALVAGEVAL2", B.SALVAGEVAL2);
        //        com.Parameters.AddWithValue("@SELLVAT", B.SELLVAT);
        //        com.Parameters.AddWithValue("@RETURNVAT", B.RETURNVAT);
        //        com.Parameters.AddWithValue("@LOGOID", B.LOGOID);
        //        com.Parameters.AddWithValue("@LIDCONFIRMED", B.LIDCONFIRMED);
        //        com.Parameters.AddWithValue("@GTIPCODE", B.GTIPCODE);
        //        com.Parameters.AddWithValue("@EXPCTGNO", B.EXPCTGNO);
        //        com.Parameters.AddWithValue("@B2CCODE", B.B2CCODE);
        //        com.Parameters.AddWithValue("@MARKREF", B.MARKREF);
        //        com.Parameters.AddWithValue("@IMAGE2INC", B.IMAGE2INC);
        //        com.Parameters.AddWithValue("@AVRWHDURATION", B.AVRWHDURATION);
        //        com.Parameters.AddWithValue("@EXTCARDFLAGS", B.EXTCARDFLAGS);
        //        com.Parameters.AddWithValue("@MINORDAMOUNT", B.MINORDAMOUNT);
        //        com.Parameters.AddWithValue("@FREIGHTPLACE", B.FREIGHTPLACE);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE1", B.FREIGHTTYPCODE1);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE2", B.FREIGHTTYPCODE2);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE3", B.FREIGHTTYPCODE3);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE4", B.FREIGHTTYPCODE4);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE5", B.FREIGHTTYPCODE5);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE6", B.FREIGHTTYPCODE6);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE7", B.FREIGHTTYPCODE7);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE8", B.FREIGHTTYPCODE8);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE9", B.FREIGHTTYPCODE9);
        //        com.Parameters.AddWithValue("@FREIGHTTYPCODE10", B.FREIGHTTYPCODE10);
        //        com.Parameters.AddWithValue("@STATECODE", B.STATECODE);
        //        com.Parameters.AddWithValue("@STATENAME", B.STATENAME);
        //        com.Parameters.AddWithValue("@EXPCATEGORY", B.EXPCATEGORY);
        //        com.Parameters.AddWithValue("@LOSTFACTOR", B.LOSTFACTOR);
        //        com.Parameters.AddWithValue("@TEXTINCENG", B.TEXTINCENG);
        //        com.Parameters.AddWithValue("@EANBARCODE", B.EANBARCODE);
        //        com.Parameters.AddWithValue("@DEPRCLASSTYPE", B.DEPRCLASSTYPE);
        //        com.Parameters.AddWithValue("@WFLOWCRDREF", B.WFLOWCRDREF);
        //        com.Parameters.AddWithValue("@SELLPRVAT", B.SELLPRVAT);
        //        com.Parameters.AddWithValue("@RETURNPRVAT", B.RETURNPRVAT);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES1", B.LOWLEVELCODES1);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES2", B.LOWLEVELCODES2);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES3", B.LOWLEVELCODES3);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES4", B.LOWLEVELCODES4);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES5", B.LOWLEVELCODES5);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES6", B.LOWLEVELCODES6);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES7", B.LOWLEVELCODES7);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES8", B.LOWLEVELCODES8);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES9", B.LOWLEVELCODES9);
        //        com.Parameters.AddWithValue("@LOWLEVELCODES10", B.LOWLEVELCODES10);
        //        com.Parameters.AddWithValue("@ORGLOGOID", B.ORGLOGOID);
        //        com.Parameters.AddWithValue("@QPRODDEPART", B.QPRODDEPART);
        //        com.Parameters.AddWithValue("@CANCONFIGURE", B.CANCONFIGURE);
        //        com.Parameters.AddWithValue("@CHARSETREF", B.CHARSETREF);
        //        com.Parameters.AddWithValue("@CANDEDUCT", B.CANDEDUCT);
        //        com.Parameters.AddWithValue("@CONSCODEREF", B.CONSCODEREF);
        //        com.Parameters.AddWithValue("@SPECODE2", B.SPECODE2);
        //        com.Parameters.AddWithValue("@SPECODE3", B.SPECODE3);
        //        com.Parameters.AddWithValue("@SPECODE4", B.SPECODE4);
        //        com.Parameters.AddWithValue("@SPECODE5", B.SPECODE5);
        //        com.Parameters.AddWithValue("@EXPENSE", B.EXPENSE);
        //        com.Parameters.AddWithValue("@ORIGIN", B.ORIGIN);
        //        com.Parameters.AddWithValue("@NAME2", B.NAME2);
        //        com.Parameters.AddWithValue("@COMPKDVUSE", B.COMPKDVUSE);
        //        com.Parameters.AddWithValue("@USEDINPERIODS", B.USEDINPERIODS);
        //        com.Parameters.AddWithValue("@EXIMTAX1", B.EXIMTAX1);
        //        com.Parameters.AddWithValue("@EXIMTAX2", B.EXIMTAX2);
        //        com.Parameters.AddWithValue("@EXIMTAX3", B.EXIMTAX3);
        //        com.Parameters.AddWithValue("@EXIMTAX4", B.EXIMTAX4);
        //        com.Parameters.AddWithValue("@EXIMTAX5", B.EXIMTAX5);
        //        com.Parameters.AddWithValue("@PRODUCTLEVEL", B.PRODUCTLEVEL);
        //        com.Parameters.AddWithValue("@APPSPEVATMATRAH", B.APPSPEVATMATRAH);
        //        com.Parameters.AddWithValue("@NAME3", B.NAME3);
        //        com.Parameters.AddWithValue("@FACOSTKEYS", B.FACOSTKEYS);
        //        com.Parameters.AddWithValue("@KKLINESDISABLE", B.KKLINESDISABLE);
        //        com.Parameters.AddWithValue("@APPROVE", B.APPROVE);
        //        if (B.APPROVEDATE != new DateTime())
        //            com.Parameters.AddWithValue("@APPROVEDATE", B.APPROVEDATE);
        //        else
        //            com.Parameters.AddWithValue("@APPROVEDATE", DBNull.Value);
        //        com.Parameters.AddWithValue("@GLOBALID", B.GLOBALID);
        //        com.Parameters.AddWithValue("@SALEDEDUCTPART1", B.SALEDEDUCTPART1);
        //        com.Parameters.AddWithValue("@SALEDEDUCTPART2", B.SALEDEDUCTPART2);
        //        com.Parameters.AddWithValue("@PURCDEDUCTPART1", B.PURCDEDUCTPART1);
        //        com.Parameters.AddWithValue("@PURCDEDUCTPART2", B.PURCDEDUCTPART2);
        //        com.Parameters.AddWithValue("@CATEGORYID", B.CATEGORYID);
        //        com.Parameters.AddWithValue("@CATEGORYNAME", B.CATEGORYNAME);
        //        com.Parameters.AddWithValue("@KEYWORD1", B.KEYWORD1);
        //        com.Parameters.AddWithValue("@KEYWORD2", B.KEYWORD2);
        //        com.Parameters.AddWithValue("@KEYWORD3", B.KEYWORD3);
        //        com.Parameters.AddWithValue("@KEYWORD4", B.KEYWORD4);
        //        com.Parameters.AddWithValue("@KEYWORD5", B.KEYWORD5);
        //        com.Parameters.AddWithValue("@GUID", B.GUID);
        //        com.Parameters.AddWithValue("@DEMANDMEETSORTFLD1", B.DEMANDMEETSORTFLD1);
        //        com.Parameters.AddWithValue("@DEMANDMEETSORTFLD2", B.DEMANDMEETSORTFLD2);
        //        com.Parameters.AddWithValue("@DEMANDMEETSORTFLD3", B.DEMANDMEETSORTFLD3);
        //        com.Parameters.AddWithValue("@DEMANDMEETSORTFLD4", B.DEMANDMEETSORTFLD4);
        //        com.Parameters.AddWithValue("@DEMANDMEETSORTFLD5", B.DEMANDMEETSORTFLD5);
        //        com.Parameters.AddWithValue("@DEDUCTCODE", B.DEDUCTCODE);
        //        com.Parameters.AddWithValue("@PROJECTREF", B.PROJECTREF);
        //        com.Parameters.AddWithValue("@NAME4", B.NAME4);
        //        com.Parameters.AddWithValue("@QPRODSUBAMNT", B.QPRODSUBAMNT);
        //        com.Parameters.AddWithValue("@QPRODSUBUOM", B.QPRODSUBUOM);
        //        com.Parameters.AddWithValue("@QPRODSUBSRCINDEX", B.QPRODSUBSRCINDEX);
        //        com.Parameters.AddWithValue("@QPRODSUBDEPART", B.QPRODSUBDEPART);
        //        com.Parameters.AddWithValue("@WHERECLAUSE", WHEREVALUE);

        //        return com;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
