using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using clothesStore.Bl;
using System.IO;

namespace clothesStore.PL
{
    public partial class Frm_AllProudect : DevExpress.XtraEditors.XtraForm
    {
        Proudect p = new Proudect();

        public Frm_AllProudect()
        {
            InitializeComponent();
            //reb7();
            //calcTotalSelling();
            //calcTotalPurshacing();
        }
        DataTable dt = new DataTable();
        void reb7()
        {
            decimal reb7 = Convert.ToDecimal(txt_TotalSelling.Text) - Convert.ToDecimal(txt_TotalPurshacing.Text);
            textBox2.Text = reb7.ToString();
        }
        void calcTotalSelling()
        {
            Decimal total = 0;
            for (int i = 0; i < layoutView1.RowCount; i++)
            {
                DataRow r = layoutView1.GetDataRow(i);
                total += Convert.ToDecimal(r[7].ToString());
            }
            txt_TotalSelling.Text = Math.Round(total, 2).ToString();
        }
        void calcTotalPurshacing()
        {
            decimal t = 0;
            for (int i = 0; i < layoutView1.RowCount; i++)
            {
                DataRow row = layoutView1.GetDataRow(i);
                t += Convert.ToDecimal(row[5].ToString());
            }
            txt_TotalPurshacing.Text = Math.Round(t, 2).ToString();
        }
        private void Frm_AllProudect_Load(object sender, EventArgs e)
        {

            dt= p.PrintAllProudects();
           

          
            gridControl1.DataSource = dt;
            calcTotalSelling();
            calcTotalPurshacing();
            reb7();

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (layoutView1.RowCount > 0)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
            else
            {
                MessageBox.Show("لا يوجد أصناف للطباعة");
            }
        }

        private void searchControl1_Properties_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {

        }

        private void searchControl1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void searchControl1_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            //reb7();
            //calcTotalSelling();
            //calcTotalPurshacing();
        }

        private void searchControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                calcTotalSelling();
                calcTotalPurshacing();
                reb7();
            }
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void searchControl1_Enter(object sender, EventArgs e)
        {
           
        }

        private void searchControl1_Properties_KeyUp(object sender, KeyEventArgs e)
        {
          
        }
    }
}