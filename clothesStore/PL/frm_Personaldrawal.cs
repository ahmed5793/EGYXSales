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

    public partial class frm_Personaldrawal : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        DataTable dt = new DataTable();
        public frm_Personaldrawal()
        {
            
         

            InitializeComponent();

            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

            if (dt.Rows.Count > 0)
            {
                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }
        }
        void clear()
        {
            txt_addbalance.Clear();
            txt_CurrentBalance.Text = "0";
          
            txt_reason.Clear();
        }
        private void frm_Personaldrawal_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

            if (dt.Rows.Count > 0)
            {
                txt_CurrentBalance.Text = dt.Rows[0][0].ToString();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "سحب مبلغ")
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

                        else if (Convert.ToDecimal(txt_addbalance.Text) > Convert.ToDecimal(txt_CurrentBalance.Text))
                        {
                            MessageBox.Show("هذا المبلغ اكبر من الرصيد الحالى");
                            txt_addbalance.Focus();
                            return;

                        }
                        else if (MessageBox.Show("هل تريد حفظ السحب", "عملية السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, $"سحب مبلغ {txt_addbalance.Text} عن طريق {Program.salesman}", $"سحب مبلغ", txt_reason.Text);
                            MessageBox.Show("تم سحب الرصيد من الخزنة ");
                            s.InsertStockMove(Convert.ToDecimal(txt_addbalance.Text) * -1, Date_insert.Value, "مسحوبات شخصية", $"مسحوبات شخصية من حزينة {cmb_Stock.Text}", Convert.ToInt32(cmb_Stock.SelectedValue), Program.salesman, "خروج من الخزينة");

                            Login l = new Login();
                            l.addMoveUser(Program.salesman, this.Text, $"مسحوبات شخصية برصيد من خزينة {cmb_Stock.Text}");



                            s.addSanad("سند دفع", Program.salesman, Program.salesman, Convert.ToDecimal(txt_addbalance.Text),
                                        Date_insert.Value, $"مسحوبات شخصية بمبلغ {txt_addbalance.Text} الي  {Program.salesman}");

                            clear();

                        }
                        else
                        {
                            MessageBox.Show("تم إلغاء السحب");
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
            else if(comboBox1.Text== "رد مبلغ مسحوب")
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
                      
                        else if (MessageBox.Show("هل تريد حفظ الايداع", "عملية الايداع", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, $" رد مبلغ مسحوب ({txt_addbalance.Text}) عن طريق {Program.salesman}", $"رد مبلغ مسحوب", txt_reason.Text);
                            MessageBox.Show("تم إضافة الرصيد للخزنة المحددة");

                            s.InsertStockMove(Convert.ToDecimal(txt_addbalance.Text), Date_insert.Value, "رد مبلغ مسحوب", $"رد مبلغ مسحوب الي خزينة {cmb_Stock.Text}", Convert.ToInt32(cmb_Stock.SelectedValue), Program.salesman, "دخول الي الخزينة");

                            Login l = new Login();
                            l.addMoveUser(Program.salesman, this.Text, $"رد مبلغ مسحوب ({txt_addbalance.Text}) لخزنة {cmb_Stock.Text}");



                            s.addSanad("سند دفع", Program.salesman, Program.salesman, Convert.ToDecimal(txt_addbalance.Text),
                                        Date_insert.Value, $"رد مبلغ مسحوب بمبلغ {txt_addbalance.Text} من  {Program.salesman}");

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