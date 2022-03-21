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
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.SqlServer.Server;

namespace clothesStore.PL
{
    public partial class frm_RecieveMoneyFromCashir : DevExpress.XtraEditors.XtraForm
    {
         Stock s = new Stock();
        Login l = new Login();
        DataTable dt = new DataTable();

        public frm_RecieveMoneyFromCashir()
        {
            InitializeComponent();
           TimeTo.Value = DateTime.Now;
           TimeFRom.Value = DateTime.Now;
            textBox4.Text = Program.salesman;
          
        }
        void Clac_total()
        {
            decimal totalmoney = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox2.Text);
            textBox3.Text = totalmoney.ToString();
        }
        void calcPull()
        {
            decimal total = 0;

            for (int i = 0; i < gridViewInsert.RowCount; i++)
            {
                DataRow r = gridViewInsert.GetDataRow(i);
                if (r[6].ToString()== "خروج من الخزينة")
                {
                    total += Convert.ToDecimal(r[0].ToString());

                }

            }
            textBox2.Text = Math.Round(total, 2).ToString();
        }
        void calcinsert()
        {
            
            decimal total = 0;
            for (int i = 0; i < gridViewInsert.RowCount; i++)
            {
                DataRow r = gridViewInsert.GetDataRow(i);
                if (r[6].ToString()== "دخول الي الخزينة")
                {
                    total += Convert.ToDecimal(r[0].ToString());
                }
            }
            textBox1.Text = Math.Round(total, 2).ToString();
        }
        void insertStock()
        {

            dt.Clear();

            //string TimeF = TimeFRom.Value.ToString("hh:mm tt");
            //string TimeT = TimeTo.Value.ToString("hh:mm tt");

            dt = s.Select_MoneyForUsers((textBox4.Text),TimeFRom.Value,TimeTo.Value);
            gridControlInsert.DataSource = dt;

        }
        //void PullStock()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Clear();
        //    dt = s.Search_PullStock(Convert.ToInt32(cmb_Users1.SelectedValue), FromDate.Value, ToDate.Value);
        //    gridControl1.DataSource = dt;
        //    calcPull();
        //}
      

        private void frm_RecieveMoney_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                insertStock();
                calcinsert();
                calcPull();
                Clac_total();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}