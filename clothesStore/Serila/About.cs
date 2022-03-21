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
using FoxLearn.License;
using Microsoft.TeamFoundation.Common;
using ComputerInfo = FoxLearn.License.ComputerInfo;

namespace clothesStore.Serila
{
    public partial class About : DevExpress.XtraEditors.XtraForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void Txt_key_Click(object sender, EventArgs e)
        {

        }
        const int proudectCode = 1;

        private void About_Load(object sender, EventArgs e)
        {
            txt_proudect.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(txt_proudect.Text);
            LicenseInfo lc = new LicenseInfo();

            int value = km.LoadSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), ref lc);
            string proudectKey = lc.ProductKey;
            if (km.ValidKey(ref proudectKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(proudectKey, ref kv))
                {
                    txt_name.Text = "solution Company for SoftWare";
                    Txt_key.Text = proudectKey;
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        txt_Licence.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                    }
                    else
                    {
                        txt_Licence.Text = "Full";
                    }
                }

            }
        }
    }
}