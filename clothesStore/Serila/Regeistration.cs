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

namespace clothesStore.Serila
{
    public partial class Regeistration : DevExpress.XtraEditors.XtraForm
    {
        public Regeistration()
        {
            InitializeComponent();
        }
        const int proudectCode = 1;
        private void Regeistration_Load(object sender, EventArgs e)
        {
            txt_proudect.Text = ComputerInfo.GetComputerId();
          
           

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txt_proudect.Text);
            string proudectKey = Txt_key.Text;
            if (km.ValidKey(ref proudectKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(proudectKey,ref kv))
                {
                    LicenseInfo lc = new LicenseInfo();
                    lc.ProductKey = proudectKey;
                    lc.FullName = "solution Company for SoftWare";
                    if (kv.Type==LicenseType.TRIAL)
                    {
                        lc.Day = kv.Expiration.Day;
                        lc.Month = kv.Expiration.Month;
                        lc.Year = kv.Expiration.Year;
                    }
                    km.SaveSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath),lc);
                    MessageBox.Show("you have been successfuly registred", "message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Properties.Settings.Default.ProudectKey = "YES";
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                

                

            }
            else

             MessageBox.Show("your proudect key is invalid", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}