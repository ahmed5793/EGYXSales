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
    public partial class frm_RptPersonaldrawal : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        public frm_RptPersonaldrawal()
        {
            InitializeComponent();
        }
        void totalPull()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row[2].ToString()== "مسحوبات شخصية")
                {
                    total += Convert.ToDecimal(row[0].ToString());

                }
                lab_totalPull.Text = Math.Round(total, 2).ToString();
            
            }
        }

        void totalInsert()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row[2].ToString() == "رد مبلغ مسحوب")
                {
                    total += Convert.ToDecimal(row[0].ToString());

                }
                lab_totalInsert.Text = Math.Round(total, 2).ToString();

            }
        }

        void totalBalance()
        {

            lab_totalBalance.Text = (Convert.ToDecimal(lab_totalInsert.Text) + Convert.ToDecimal(lab_totalPull.Text)).ToString();



        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = s.SelectPersonaldrawal(DateFrom.Value, DateTo.Value);
            totalInsert();
            totalPull();
            totalBalance();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();

        }

        private void frm_RptPersonaldrawal_Load(object sender, EventArgs e)
        {

        }
    }
}