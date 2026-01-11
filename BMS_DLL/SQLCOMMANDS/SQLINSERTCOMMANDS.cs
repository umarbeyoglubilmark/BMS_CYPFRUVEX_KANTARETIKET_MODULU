using BMS_DLL.OBJECTS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DLL.SQLCOMMANDS
{

    public class SQLINSERTCOMMANDS
    {
        //SQLINSERTCOMMANDS SIC = new SQLINSERTCOMMANDS();
        //SqlCommand COM = null;
        //SqlTransaction TRANSACTION = null;
        //SqlConnection CON = new SqlConnection(BMS_DLL.sqlConnectionSource);
        //int ITEMSREF = -1;
        //BM_XXX_ITEMS ITEMS = new BM_XXX_ITEMS
        //{
        //    FIRMNR = CAPIUSER.FIRMNR,
        //    MODULENR = BAVMODULENR,
        //    CODE = "OOK251218000001",
        //    NAME = "Özel Oranlı Kesinti",
        //    QREF = 0,
        //    EXTCODE1 = "1",
        //    CREATEDBY = CAPIUSER.LOGICALREF,
        //    CREATEDDATE = DateTime.Now,
        //    MODIFIEDBY = 0,
        //    ACTIVE = 0
        //};
        //COM = SIC.BM_XXX_ITEMS_INSERT(ITEMS, true, false,218);
        //COM.Transaction = TRANSACTION;
        //COM.Connection = CON;
        //ITEMSREF = int.Parse(COM.ExecuteScalar().ToString());

        /// <summary>
        /// <para>Aciklama: SQLE OBJECTLI INSERT EDER</para>
        /// <para>Örnek Kod:</para>
        /// <para>BMS_DLL.CFGGETSET.AYARLARIYUKLE();</para>
        /// <para>BMS_DLL.OBJECTS.KAYITLAR K = new BMS_DLL.OBJECTS.KAYITLAR</para>
        /// <para>{</para>
        /// <para>FISNO = "1"</para>
        /// <para>};</para>
        /// <para>BMS_DLL.SQLCOMMANDS.SQLINSERTCOMMANDS SIC = new BMS_DLL.SQLCOMMANDS.SQLINSERTCOMMANDS();</para>
        /// <para>SIC.INSERTKAYITLAR(K);</para>
        /// </summary>
        public void INSERTKAYITLAR(KAYITLAR K)
        {
            DateTime TRANSACTIONDATE = DateTime.Now;
            SqlConnection CON = new SqlConnection(SQL.sqlConnectionSource.ConnectionString);
            SqlCommand COM = null;
            SqlTransaction TRANSACTION = null;
            int LOGICALREF = 0;
            try
            {
                if (CON.State != ConnectionState.Open)
                    CON.Open();
                TRANSACTION = CON.BeginTransaction();
                //COM = INSERT_KAYIT_COMMAND(K, CON, TRANSACTION);
                {
                    COM = new SqlCommand(string.Format("INSERT INTO KAYITLAR (FISNO) VALUES (@FISNO) SELECT SCOPE_IDENTITY()"),CON,TRANSACTION);
                    //COM.Parameters.AddWithValue("@LOGICALREF", K.LOGICALREF);
                    COM.Parameters.AddWithValue("@FISNO", K.FISNO != null ? K.FISNO : string.Empty);
                    LOGICALREF = int.Parse(COM.ExecuteScalar().ToString());
                    // foreach (DETAY D in B.DETAY)
                    //foreach (KAYITLAR._KAYITLAR_DETAY D in K.KAYITLAR_DETAY)
                    //{
                    //    COM = new SqlCommand(string.Format("INSERT INTO KAYITLAR_DETAY (LOGICALREF,KAYITLARREF,MALZEMEKODU) VALUES (@LOGICALREF,@KAYITLARREF,@MALZEMEKODU) SELECT SCOPE_IDENTITY()"));
                    //    COM.Parameters.AddWithValue("@LOGICALREF", D.LOGICALREF);
                    //    COM.Parameters.AddWithValue("@KAYITLARREF",LOGICALREF);
                    //    COM.Parameters.AddWithValue("@MALZEMEKODU", D.MALZEMEKODU);
                    //    COM.ExecuteNonQuery();
                    //}
                   // COM.ExecuteNonQuery();
                }
                TRANSACTION.Commit();
            }
            catch (Exception E)
            {
                GLOBAL.LOGYAZ("INSERTKAYITLAR", E);
                try { TRANSACTION.Rollback(); } catch { }
            }
            finally
            {
                try { if (CON.State != ConnectionState.Closed) CON.Close(); } catch { }
                try { TRANSACTION.Dispose(); } catch { }
            }
        }

        //public SqlCommand INSERT_CARIKART_COMMAND(KAYITLAR K, SqlConnection CON, SqlTransaction TRANSACTION, DateTime WEBSERVICERECEIVEDDATE)
        //{
        //    try
        //    {
        //        SqlCommand COM = new SqlCommand(string.Format("INSERT INTO KAYITLAR (LOGICALREF,FISNO) VALUES (@LOGICALREF,@FISNO)) SELECT SCOPE_IDENTITY()"), CON);

        //        COM.Parameters.AddWithValue("@LOGICALREF", K.LOGICALREF);
        //        COM.Parameters.AddWithValue("@FISNO", K.FISNO != null ? K.FISNO : string.Empty);

        //        if (CON != null)
        //            COM.Connection = CON;
        //        if (TRANSACTION != null)
        //            COM.Transaction = TRANSACTION;
        //        return COM;
        //    }
        //    catch (Exception E)
        //    {
        //        GLOBAL.LOGYAZ("INSERT_CARIKART_COMMAND", E);
        //        return null;
        //    }
        //}

    }
}
