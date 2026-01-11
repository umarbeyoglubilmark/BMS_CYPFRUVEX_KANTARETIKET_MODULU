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

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class FRM_TANIMLAMALAR_KULLANICILAR : DevExpress.XtraEditors.XtraForm {
        public string LOGICALREF = "";
        public string KOD = "";
        public string AD = "";
        CONFIG _CFG;
        string LGCONSTR = "";
        SqlConnection SQLCON = new SqlConnection();
        public FRM_TANIMLAMALAR_KULLANICILAR(CONFIG CFG) {
            InitializeComponent();
            _CFG = CFG;
            LGCONSTR = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};MultipleActiveResultSets=True;",
_CFG.LGDBSERVER, _CFG.LGDBDATABASE, _CFG.LGDBUSERNAME, _CFG.LGDBPASSWORD);
            SQLCON = new SqlConnection(LGCONSTR);
            INITIALIZEGRID();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(GRC_TANIMLAMALAR_KULLANICILAR, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_TANIMLAMALAR_KULLANICILAR.Name);
        }
        private void INITIALIZEGRID() {
            GRC_TANIMLAMALAR_KULLANICILAR.DataSource = BMS_DLL.SQL.SELECT2(@" SELECT * FROM BMS_KE_KULLANICILAR", SQLCON);


        }
        private void FRM_KANTARPLAKA_FormClosing(object sender, FormClosingEventArgs e) {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(GRC_TANIMLAMALAR_KULLANICILAR, "BMS_CYPFRUVEX_KANTARETIKET_MODULU", GRC_TANIMLAMALAR_KULLANICILAR.Name);
        }



        private void BTN_UA_Click(object sender, EventArgs e) {
            if (TE_KULLANICIADI.Text == "") {
                MessageBox.Show("EKSİK YERLERİ DOLDURUNUZ");
                return;
            }
            if (LBL_LOGICALREF.Text == "") {
                if (BMS_DLL.DX.DXMESSAGEBOX(true, "ONAY", "EKLEMEK ISTEDIGINIZE EMINMISINIZ ?") == true) {
                    BMS_DLL.SQL.EXECUTE2(this, string.Format("INSERT INTO BMS_KE_KULLANICILAR (KULLANICIADI,PAROLA,TUR) VALUES ('{0}','{1}','{2}')", TE_KULLANICIADI.Text, TE_PAROLA.Text, TE_TUR.Text), SQLCON);
                    INITIALIZEGRID();
                }
            } else {
                if (BMS_DLL.DX.DXMESSAGEBOX(true, "ONAY", "GUNCELLEMEK ISTEDIGINIZE EMINMISINIZ ?") == true) {
                    BMS_DLL.SQL.EXECUTE2(this, string.Format("UPDATE BMS_KE_KULLANICILAR SET KULLANICIADI='{0}' ,PAROLA='{1}' ,TUR='{2}' WHERE LOGICALREF={3}", TE_KULLANICIADI.Text, TE_PAROLA.Text, TE_TUR.Text, LBL_LOGICALREF.Text), SQLCON);
                    INITIALIZEGRID();
                }
            }


        }

        private void BTN_DELETE_Click(object sender, EventArgs e) {
            try {
                if (BMS_DLL.DX.DXMESSAGEBOX(true, "ONAY", "SILMEK ISTEDIGINIZE EMINMISINIZ ?") == true) {
                    BMS_DLL.SQL.EXECUTE2(this, "DELETE BMS_KE_KULLANICILAR WHERE LOGICALREF=" + LBL_LOGICALREF.Text, SQLCON);
                    INITIALIZEGRID();
                }
                BTN_DELETE.Enabled = false;
                LBL_LOGICALREF.Text = "";
            } catch {
                INITIALIZEGRID();
            }
        }

        private void GRV_TANIMLAMALAR_KULLANICILAR_DoubleClick(object sender, EventArgs e) {
            TE_KULLANICIADI.Text = GRV_TANIMLAMALAR_KULLANICILAR.GetRowCellValue(GRV_TANIMLAMALAR_KULLANICILAR.FocusedRowHandle, "KULLANICIADI").ToString();
            TE_PAROLA.Text = GRV_TANIMLAMALAR_KULLANICILAR.GetRowCellValue(GRV_TANIMLAMALAR_KULLANICILAR.FocusedRowHandle, "PAROLA").ToString();
            TE_TUR.Text = GRV_TANIMLAMALAR_KULLANICILAR.GetRowCellValue(GRV_TANIMLAMALAR_KULLANICILAR.FocusedRowHandle, "TUR").ToString();
            LBL_LOGICALREF.Text = GRV_TANIMLAMALAR_KULLANICILAR.GetRowCellValue(GRV_TANIMLAMALAR_KULLANICILAR.FocusedRowHandle, "LOGICALREF").ToString();
            BTN_DELETE.Enabled = true;
        }

        private void BTN_YENI_Click(object sender, EventArgs e) {
            BTN_DELETE.Enabled = false;
            LBL_LOGICALREF.Text = "";
            TE_KULLANICIADI.Text = "";
            TE_PAROLA.Text = "";
            TE_TUR.Text = "";
        }
    }
}