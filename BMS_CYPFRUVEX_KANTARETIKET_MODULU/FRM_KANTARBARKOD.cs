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
using DevExpress.BarCodes;

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {

    public partial class FRM_KANTARBARKOD : DevExpress.XtraEditors.XtraForm {
        BarCode barCode = new BarCode();
        public static string LOGICALREF = "";
        public static string LGCONSTR = "";
        public FRM_KANTARBARKOD(string _LOGICALREF, string _LGCONSTR) {
            InitializeComponent();
            LOGICALREF = _LOGICALREF;
            LGCONSTR = _LGCONSTR;
            barCodeControl1.Text = LOGICALREF;


            barCode.Symbology = Symbology.QRCode;
            barCode.CodeText = LOGICALREF;
            barCode.BackColor = Color.White;
            barCode.ForeColor = Color.Black;
            barCode.RotationAngle = 0;
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte;
            barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            barCode.Options.QRCode.ShowCodeText = true;

            barCode.DpiX = 72;
            barCode.DpiY = 72;
            barCode.Module = 2f;
            barCode.Margins.Top = 1;
            barCode.Margins.Bottom = 1;
            TE_DPIX.Text = barCode.DpiX.ToString();
            TE_DPIY.Text = barCode.DpiX.ToString();
        }

        private void SB_YAZDIR_Click(object sender, EventArgs e) {
            MessageBox.Show(string.Format("DpiX:{0}, DpiY:{1}, Margin Top:{2}, Margin Bottom:{3}", barCode.DpiX.ToString(), barCode.DpiY.ToString(), barCode.Margins.Top.ToString(), barCode.Margins.Bottom.ToString()));
            barCode.PrintDialog();

        }

        private void TE_DPIX_TextChanged(object sender, EventArgs e) {
            barCode.DpiX = int.Parse(TE_DPIX.Text);
        }

        private void TE_DPIY_TextChanged(object sender, EventArgs e) {
            barCode.DpiY = int.Parse(TE_DPIY.Text);
        }

        private void TE_MARGINTOP_TextChanged(object sender, EventArgs e) {
            barCode.Margins.Top = int.Parse(TE_MARGINTOP.Text);
        }

        private void TE_MARGINBOTTOM_TextChanged(object sender, EventArgs e) {
            barCode.Margins.Bottom = int.Parse(TE_MARGINBOTTOM.Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            barCode.ShowPrintPreview();
        }

        private void button2_Click(object sender, EventArgs e) {
            BMS_DLL.DX.XTRAREPORT_AC("SELECT * FROM BMS_KE_KANTAR WHERE LOGICALREF=" + LOGICALREF, "BARKODDESIGN.repx", false, LGCONSTR);
        }
    }
}