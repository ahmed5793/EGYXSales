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
    public partial class frm_RptIncomestatement : DevExpress.XtraEditors.XtraForm
    {
        
        public frm_RptIncomestatement()
        {
            InitializeComponent();
        }
        void print()
        {
            try
            {

            
            DsMoveStock ms = new DsMoveStock();
            Stock s = new Stock();
            Proudect p = new Proudect();

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            RptIncomestatement rv = new RptIncomestatement();

            dt.Clear();
            dt = s.ReportIncomestatement(dtb_from.Value,dtb_to.Value);
            ms.Tables["Incomestatement"].Clear();

            ms.Tables["Incomestatement"].Rows.Add(dt.Rows[0][0], dt.Rows[0][1], dt.Rows[0][2], dt.Rows[0][3], dt.Rows[0][4],
                dt.Rows[0][5], dt.Rows[0][6], dt.Rows[0][7], dt.Rows[0][8], dt.Rows[0][9], dt.Rows[0][10], dt.Rows[0][11],
                dt.Rows[0][12], dt.Rows[0][13]);



            dt2.Clear();
            dt2 = p.ReportStoreValueLast();
                decimal x = 0;
                for (int i = 0; i < dt2.Rows.Count; i++)
                {

              
                  
               
                    x += Convert.ToDecimal(dt2.Rows[i][1]);

                    ms.Tables["StoreValueLast"].Clear();

                    ms.Tables["StoreValueLast"].Rows.Add(dt2.Rows[i][0],x);
                }

            rv.Parameters["from"].Value = dtb_from.Text;
            rv.Parameters["to"].Value = dtb_to.Text;

            rv.Parameters["from"].Visible = false;
            rv.Parameters["to"].Visible = false;


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
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}