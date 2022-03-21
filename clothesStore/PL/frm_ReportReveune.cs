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
using clothesStore.Rpt;
using clothesStore.Bl;

namespace clothesStore.PL
{
    public partial class frm_ReportReveune : DevExpress.XtraEditors.XtraForm
    {
        Order o = new Order();
        Proudect p = new Proudect();
        public frm_ReportReveune()
        {
            InitializeComponent();

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

          
            DataSetRevenue sr = new DataSetRevenue();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            rptRevuene rv = new rptRevuene();


            dt2.Clear();
            dt2 = p.TestProudect(dtb_from.Value, dtb_to.Value);
            sr.Tables["proudects"].Clear();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                sr.Tables["proudects"].Rows.Add(dt2.Rows[i][0]);
            }
            DataTable dt5 = new DataTable();
            dt5.Clear();
         
            dt5 = p.SelectAverageBuyPrice(dtb_from.Value, dtb_to.Value);
            sr.Tables["buyprise"].Clear();
            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                sr.Tables["buyprise"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1]);
            }

            dt.Clear();
            dt = o.SelectSalesReb7(dtb_from.Value,dtb_to.Value);
            sr.Tables["OrderDetails"].Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sr.Tables["OrderDetails"].Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
            }

            dt1.Clear();
            dt1 = o.ReportAboutOrderReturn(dtb_from.Value, dtb_to.Value);
            sr.Tables["OrderReturn"].Clear();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                sr.Tables["OrderReturn"].Rows.Add(dt1.Rows[i][0], dt1.Rows[i][1], dt1.Rows[i][2]);
            }

            dt3.Clear();
            dt3 = p.SelectTotalDiscount(dtb_from.Value, dtb_to.Value);
            sr.Tables["Totaldiscount"].Clear();   
            sr.Tables["Totaldiscount"].Rows.Add(dt3.Rows[0][0]);
            

            rv.DataSource = sr;
            rv.Parameters["formdate"].Value = dtb_from.Text;
            rv.Parameters["todate"].Value = dtb_to.Text;

            rv.Parameters["formdate"].Visible = false;
            rv.Parameters["todate"].Visible = false;
            documentViewer1.DocumentSource = rv;

            rv.CreateDocument();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
           
}
}