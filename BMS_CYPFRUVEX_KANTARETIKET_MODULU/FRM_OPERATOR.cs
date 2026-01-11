using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.MODELS;
using BMS_CYPFRUVEX_KANTARETIKET_MODULU.CONVERTER;
using BMS_DLL.OBJECTS;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU
{
    public partial class FRM_OPERATOR : DevExpress.XtraEditors.XtraForm
    {
        string LGCONSTR;
        CONFIG _CFG;
        SqlConnection SQLCON = new SqlConnection();
        BMS_KE_KANTAR KANTAR = new BMS_KE_KANTAR();
        CONVERTDATATOMODELS SIC = new CONVERTDATATOMODELS();
        public FRM_OPERATOR(CONFIG CFG)
        {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            SQLCON = new SqlConnection(LGCONSTR);
            TE_QRKOD.Text = null;
        }
        private void YENI_SATINALMAFATURASI()
        {
            FRM_OPERATOR_YENISATINALMAFATURASI O = new FRM_OPERATOR_YENISATINALMAFATURASI(_CFG, KANTAR);
            TE_QRKOD.Text = "";
            O.Show();
        }
        private void SB_TAMAM_Click(object sender, EventArgs e)
        {
            YENI_SATINALMAFATURASI();
        }

        private void TE_QRKOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataRow dr;
                try
                {
                    dr = BMS_DLL.SQL.SELECT2("SELECT * FROM BMS_KE_KANTAR WHERE LOGICALREF=" + TE_QRKOD.Text, SQLCON).Rows[0];
                    KANTAR = SIC.BMS_KE_KANTAR_CONVERT_FROM_DATAROW(dr);
                    YENI_SATINALMAFATURASI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(TE_QRKOD.Text + " NUMARALI QRKOD BULUNAMADI!");
                    BMS_DLL.GLOBAL.LOGYAZ("HATA", ex);
                }
            }
        }
    }
}