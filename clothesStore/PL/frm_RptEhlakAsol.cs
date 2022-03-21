using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clothesStore.Bl;

namespace clothesStore.PL
{
    public partial class frm_RptEhlakAsol : DevExpress.XtraEditors.XtraForm
    {
        Asol a = new Asol();

        public frm_RptEhlakAsol()
        {
            InitializeComponent();
       
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = a.SelectEhalakAsolByDate(DateFrom.Value, DateTo.Value);
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}