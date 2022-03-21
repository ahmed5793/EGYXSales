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
    public partial class frm_otherRevenues : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public frm_otherRevenues()
        {
            InitializeComponent();
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_Stock.Text != "")
                {
                    if (txt_addbalance.Text == "" || txt_addbalance.Text == "0")
                    {
                        MessageBox.Show("لا بد من ان يكون الايداع اكبر من الصفر");
                        txt_addbalance.Focus();
                        return;
                    }

                    if (txt_reason.Text == "")
                    {
                        MessageBox.Show("من فضلك قم باادخال البيان");
                        
                        return;
                    }


                    else if (MessageBox.Show("هل تريد الحفظ ", "عملية الايرادات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, $" ايرادات اخرى ({txt_addbalance.Text}) عن طريق {Program.salesman}", $"ايرادات اخرى", txt_reason.Text);
                        MessageBox.Show("تم الحفظ بنجاح");

                        s.InsertStockMove(Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, "ايرادات اخرى", txt_reason.Text, Convert.ToInt32(cmb_Stock.SelectedValue), Program.salesman, "دخول الي الخزينة");

                        Login l = new Login();
                        l.addMoveUser(Program.salesman, this.Text, $"ايرادات اخرى");


                        s.addSanad("سند قبض", Program.salesman, Program.salesman, Convert.ToDecimal(txt_addbalance.Text),
                                    Date_insert.Value, $"ايرادات اخرى بمبلغ {txt_addbalance.Text} من  {Program.salesman}");

                        clear();

                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء الايداع");
                        clear();

                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد خزنة ");
                    return;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        void clear()
        {
            txt_addbalance.Clear();
          

            txt_reason.Clear();
        }
        private void frm_otherRevenues_Load(object sender, EventArgs e)
        {

        }

        private void txt_addbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && txt_addbalance.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}