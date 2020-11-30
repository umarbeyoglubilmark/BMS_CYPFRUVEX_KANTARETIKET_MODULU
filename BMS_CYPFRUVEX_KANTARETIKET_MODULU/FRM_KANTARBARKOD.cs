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
        public FRM_KANTARBARKOD(string _LOGICALREF) {
            InitializeComponent();
            LOGICALREF = _LOGICALREF;
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

        }

        private void SB_YAZDIR_Click(object sender, EventArgs e) {
            barCode.PrintDialog();

        }
    }
}