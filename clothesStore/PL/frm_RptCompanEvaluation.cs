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
    public partial class frm_RptCompanEvaluation : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        Proudect p = new Proudect();
        public frm_RptCompanEvaluation()
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

                RptCompanEvaluation rv = new RptCompanEvaluation();


                dt.Clear();
                dt = s.ReportBudgetReview();
                ms.Tables["BudgetReview"].Clear();

                ms.Tables["BudgetReview"].Rows.Add(dt.Rows[0][0], dt.Rows[0][1], dt.Rows[0][2], dt.Rows[0][3], dt.Rows[0][4],
                    dt.Rows[0][5], dt.Rows[0][6], dt.Rows[0][7], dt.Rows[0][8], dt.Rows[0][9], dt.Rows[0][10], dt.Rows[0][11],
                    dt.Rows[0][12], dt.Rows[0][13], dt.Rows[0][14], dt.Rows[0][15], dt.Rows[0][16], dt.Rows[0][17], dt.Rows[0][18], dt.Rows[0][19], dt.Rows[0][20]);

                DataTable dt2 = new DataTable();
                dt2.Clear();
                dt2 = p.ReportStoreValueLast();
                decimal x = 0;
                for (int i = 0; i < dt2.Rows.Count; i++)
                {




                    x += Convert.ToDecimal(dt2.Rows[i][1]);

                    ms.Tables["StoreValueLast"].Clear();

                    ms.Tables["StoreValueLast"].Rows.Add(dt2.Rows[i][0], x);
                }



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
        private void frm_RptCompanEvaluation_Load(object sender, EventArgs e)
        {

        }
    }
}