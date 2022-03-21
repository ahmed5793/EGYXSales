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
using clothesStore.Rpt;

namespace clothesStore.PL
{
    public partial class frm_rptDaily : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        public frm_rptDaily()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            DsMoveStock ms = new DsMoveStock();


            DataTable dt = new DataTable();

            rptDaily rv = new rptDaily();


            dt.Clear();
            dt = s.rptDaily( dtb_from.Value, dtb_to.Value);
            ms.Tables["stockMove"].Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ms.Tables["stockMove"].Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4],
                    dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9]);
            }

            rv.DataSource = ms;
            rv.Parameters["formdate"].Value = dtb_from.Text;
            rv.Parameters["todate"].Value = dtb_to.Text;

            rv.Parameters["formdate"].Visible = false;
            rv.Parameters["todate"].Visible = false;
            documentViewer1.DocumentSource = rv;

            rv.CreateDocument();

        }
    }
    }
