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
    public partial class Form_reportStockPull : Form
    {

        Stock s = new Stock();
        DataTable dt = new DataTable();
        public Form_reportStockPull()
        {
            InitializeComponent();
            Stock();
            gridControl1.DataSource = s.Report_PullStock(Convert.ToInt32(cmb_Stock.SelectedValue));
            DateFrom.Text = DateTime.Now.ToShortDateString();
            DateTo.Text = DateTime.Now.ToShortDateString();
        }
        void Stock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
        }
        //void calc()
        //{
        //    decimal total = 0;
        //    for (int i = 0; i < gridView1.RowCount; i++)
        //    {
        //        DataRow r = gridView1.GetDataRow(i);
        //        total += Convert.ToDecimal(r[1].ToString());

        //    }
        //    textBox1.Text = Math.Round(total, 2).ToString();
        //}

        private void Form_reportStockPull_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = s.Search_PullStock(Convert.ToInt32(cmb_Stock.SelectedValue), DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;

            Login l = new Login();
            l.addMoveUser(Program.salesman, this.Text, $"بحث في تقرير الارصدة المسحوبة من خزينة({cmb_Stock.Text}),في الفترة مابين {DateFrom.Text} الي فترة {DateTo.Text}");


        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.addMoveUser(Program.salesman, this.Text, $"طباعه تقرير شامل الارصدة المسحوبة من خزينة({cmb_Stock.Text}),في الفترة مابين {DateFrom.Text} الي فترة {DateTo.Text}");

            gridControl1.ShowRibbonPrintPreview();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
