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

namespace BMS_DLL
{
    public partial class Ayarlar : DevExpress.XtraEditors.XtraForm
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void simpleButtonKAYDET_Click(object sender, EventArgs e)
        {
 
            BMS_DLL.CFGGETSET.AYARLARIKAYDET(textEditLS_KULLANICIADI.Text, textEditLS_PAROLA.Text, textEditLS_SUNUCU.Text, textEditLS_VERITABANI.Text, textEditLS_RESTAPIURL.Text, comboBoxEditBS_VERITABANITIPI.SelectedIndex, textEditBS_KULLANICIADI.Text, textEditBS_PAROLA.Text, textEditBS_SUNUCU.Text, textEditBS_VERITABANI.Text, textEditFB_FIRMANO.Text, textEditFB_PERIOD.Text, textEditFB_ONCEKIFIRMANO.Text, textEditFB_ONCEKIPERIOD.Text, textEditKB_BMSKULLANICIKODU.Text, textEditKB_BMSPAROLA.Text, textEditKB_LOKULLANICIKODU.Text, textEditKB_LOPAROLA.Text, textEditWS_SERVISSURE.Text, comboBoxEditWS_SURECINSI.SelectedIndex, comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex,0);
        }

        private void simpleButtonVAZGEC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}