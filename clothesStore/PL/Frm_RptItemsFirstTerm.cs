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
    public partial class Frm_RptItemsFirstTerm : DevExpress.XtraEditors.XtraForm
    {
        Proudect p = new Proudect();
        public Frm_RptItemsFirstTerm()
        {
            InitializeComponent();
            gridControl1.DataSource = p.selectItemsFirstTerm();
        }

        private void Frm_RptItemsFirstTerm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}