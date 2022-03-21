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
using       clothesStore.Rpt;

namespace clothesStore.PL
{
    public partial class frm_MoveStock : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        void ComboStock()
        {

          
            cmb_Stock.DataSource = s.Compo_Stock();
         
       
            cmb_Stock.ValueMember = "id_Treasury";
            cmb_Stock.DisplayMember = "Treasury_name";

            


            //cmb_Stock.Items.Add("كل الخزائن");


        }
        public frm_MoveStock()
        {
            InitializeComponent();
           
            ComboStock();
         

        }

        private void frm_MoveStock_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {


            DsMoveStock ms = new DsMoveStock();
           
       
            DataTable dt = new DataTable();
         
            rptStockMove rv = new rptStockMove();


            dt.Clear();
            dt = s.reportStockMove(Convert.ToInt32(cmb_Stock.SelectedValue),dtb_from.Value,dtb_to.Value);
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