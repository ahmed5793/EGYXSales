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

namespace clothesStore.Serila
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Generate g = new Generate();
            g.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Regeistration r = new Regeistration();
            r.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
    }
}