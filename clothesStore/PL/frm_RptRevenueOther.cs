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
    public partial class frm_RptRevenueOther : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        public frm_RptRevenueOther()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = s.SelectRevenueOther(DateFrom.Value,DateTo.Value);
        }
    }
}