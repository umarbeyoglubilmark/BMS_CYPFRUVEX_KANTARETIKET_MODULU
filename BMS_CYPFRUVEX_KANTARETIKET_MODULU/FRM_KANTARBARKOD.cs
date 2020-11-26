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

namespace BMS_CYPFRUVEX_KANTARETIKET_MODULU {
    public partial class FRM_KANTARBARKOD : DevExpress.XtraEditors.XtraForm {
        public static string LOGICALREF = "";
        public FRM_KANTARBARKOD(string _LOGICALREF) {
            InitializeComponent();
            LOGICALREF = _LOGICALREF;
            barCodeControl1.Text = LOGICALREF;
        }

        private void SB_YAZDIR_Click(object sender, EventArgs e) {

        }
    }
}