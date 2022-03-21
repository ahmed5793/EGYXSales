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
    public partial class Generate : DevExpress.XtraEditors.XtraForm
    {
        public Generate()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txt_proudect.Text);
            KeyValuesClass kv;
            string proudectKey=string.Empty;
            if (Cmb_Licence.SelectedIndex==0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)proudectCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                    
                };
                if (!km.GenerateKey(kv,ref proudectKey))
                
                    Txt_key.Text = "error";
                
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)proudectCode,
                    Edition = Edition.ENTERPRISE,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(Txt_Day.Text)),


                };
                if (!km.GenerateKey(kv, ref proudectKey))

                    Txt_key.Text = "error";
            }

            Txt_key.Text = proudectKey;

        }
        const int proudectCode = 1;
        private void Generate_Load(object sender, EventArgs e)
        {
            Cmb_Licence.SelectedIndex = 0;
            txt_proudect.Text = ComputerInfo.GetComputerId();
        }
    }
}