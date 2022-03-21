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
    public partial class frm_RptUserMove : DevExpress.XtraEditors.XtraForm
    {
        Login l = new Login();
        public frm_RptUserMove()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = l.selectRptUserMove(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}