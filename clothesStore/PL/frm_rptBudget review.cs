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
    public partial class frm_rptBudget_review : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        public frm_rptBudget_review()
        {
            InitializeComponent();
            print();

        }

        void print()
        {

            try
            {

            DsMoveStock ms = new DsMoveStock();


            DataTable dt = new DataTable();

            RptBudgetReview rv = new RptBudgetReview();


            dt.Clear();
            dt = s.ReportBudgetReview();
            ms.Tables["BudgetReview"].Clear();
           
                ms.Tables["BudgetReview"].Rows.Add(dt.Rows[0][0], dt.Rows[0][1], dt.Rows[0][2], dt.Rows[0][3], dt.Rows[0][4],
                    dt.Rows[0][5], dt.Rows[0][6], dt.Rows[0][7], dt.Rows[0][8], dt.Rows[0][9], dt.Rows[0][10], dt.Rows[0][11],
                    dt.Rows[0][12], dt.Rows[0][13], dt.Rows[0][14], dt.Rows[0][15], dt.Rows[0][16], dt.Rows[0][17], dt.Rows[0][18], dt.Rows[0][19], dt.Rows[0][20]);
            

            rv.DataSource = ms;
        

           
            documentViewer1.DocumentSource = rv;

            rv.CreateDocument();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }
        private void frm_rptBudget_review_Load(object sender, EventArgs e)
        {

        }
    }
}