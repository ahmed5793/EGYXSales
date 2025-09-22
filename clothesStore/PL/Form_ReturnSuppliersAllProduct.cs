using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clothesStore.PL;
using clothesStore.Bl;
using System.Net;
using System.Globalization;

namespace clothesStore.PL
{
    public partial class Form_ReturnSuppliersAllProduct : Form
    {
        Suppliers s = new Suppliers();
        Stock st = new Stock();
        DataTable dt2 = new DataTable();
        DataTable dt = new DataTable();
        Proudect p = new Proudect();
        DataTable dt10 = new DataTable();
        Store Store = new Store();
        DataTable dt87 = new DataTable();
        DataTable dt6 = new DataTable();
        public Form_ReturnSuppliersAllProduct()
        {
            InitializeComponent();
            Select_IdSupplierInnvoice();
            txt_sales.Text = Program.salesman;
            ComboStock();
        }
        void Select_IdSupplierInnvoice()
        {
            comboBox1.DataSource = s.ReturncompoSupplier();
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
        }
        void ComboStock()
        {
            cmb_Stock.DataSource = st.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
        }
        //void ComboStore()
        //{
        //    Cmb_Store.DataSource = Store.Select_ComboStore();
        //    Cmb_Store.DisplayMember = "Store_Name";
        //    Cmb_Store.ValueMember = "Store_Id";
        //}
        //void Select_ComboUnit()
        //{
        //    cmb_Unit.DataSource = p.Select_UnitProduct(Convert.ToInt32(Txt_IdProduct.Text));
        //    cmb_Unit.DisplayMember = "Unit_Name";
        //    cmb_Unit.ValueMember = "Id_Unit";
        //}
       
     
        private void Form_ReturnSuppliers_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try {

                dt.Clear();
                dt = s.Validate_IdSupplierinnoice(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    Console.Beep();
                    MessageBox.Show("لا توجد فاتورة بهذا الرقم");
                    return;
                }
                clear();
                dt = s.SelectSuppliersRteurn(Convert.ToInt32(comboBox1.SelectedValue));
                dt2 = s.SelectProudectRteurn(Convert.ToInt32(comboBox1.SelectedValue));
                foreach (DataRow dr in dt.Rows)
                {
                    txt_IdOrder.Text = dr["ID"].ToString();
                    txt_Name.Text = dr["Name"].ToString();
                    Txt_IdSupplier.Text = dr["sup_id"].ToString();
                    txt_totaldiscount.Text = dr["totalDiscount"].ToString();
                    txt_totalinvoice.Text = dr["totalAfterDicscount"].ToString();
                    txt_OldPay.Text = dr["pay"].ToString();
                    txt_sales.Text = Program.salesman;
                    Txt_TotalReturn.Text = txt_totalinvoice.Text;

                }
                dataGridView1.DataSource = dt2;
                dataGridView1.Columns[0].Visible = false;
                dt6.Clear();
                dt6 = s.select_SupplierBalance(Convert.ToInt32(Txt_IdSupplier.Text));
                decimal mno = Convert.ToDecimal(dt6.Rows[0][1]);
                Txt_CustBalance.Text = mno.ToString();
                if (mno>=0)
                {
                    label5.Text = "له";
                }
                else if (mno < 0)
                {
                    label5.Text = "عليه";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            }
 

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }
      

        void clear()
        {
            txt_Name.Clear();
            txt_IdOrder.Clear();
            txt_sales.Clear();
            dataGridView1.Columns.Clear();
            dt10.Clear();
            Txt_IdSupplier.Clear();
            Txt_TotalReturn.Text = "0";
            Txt_Pay.Text = "0";
            Txt_IdProduct.Clear();
            txt_OldPay.Clear();
            txt_totalinvoice.Clear();
            txt_totaldiscount.Clear();
            
        }
       
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void txt_return_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Txt_Pay_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txt_QuantityReturn_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void DGV_Return_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void Btn_OldReturn_Click(object sender, EventArgs e)
        {
            Frm_ShowOldReturnSupplier frm_show = new Frm_ShowOldReturnSupplier();
            DataTable data5 = new DataTable();
            try
            {
                if (txt_IdOrder.Text == "") { MessageBox.Show("لا بد من اختيار فاتورة"); return; }
                data5.Clear();
                data5 = s.Select_OldReturnSupplier(Convert.ToInt32(txt_IdOrder.Text));
                if (data5.Rows.Count > 0)
                {
                    frm_show.dataGridView1.DataSource = data5;
                    frm_show.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لا يوجد مرتجع سابق لهذه الفاتورة");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_SearchSupplierOrder frm = new Frm_SearchSupplierOrder();

            try
            {
                frm.ShowDialog();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                
                    if (frm.dataGridView1.SelectedRows.Count > 0 && frm.dataGridView1.Rows.Count > 0)
                    {
                        clear();

                        dt1.Clear();
                        dt2.Clear();
                         clear();
                        dt1 = s.SelectSuppliersRteurn(Convert.ToInt32(frm.dataGridView1.CurrentRow.Cells[0].Value));
                        dt2 = s.SelectProudectRteurn(Convert.ToInt32(frm.dataGridView1.CurrentRow.Cells[0].Value));
                    foreach (DataRow dr in dt1.Rows)
                    {
                        txt_IdOrder.Text = dr["ID"].ToString();
                        txt_Name.Text = dr["Name"].ToString();
                        Txt_IdSupplier.Text = dr["sup_id"].ToString();
                        txt_totaldiscount.Text = dr["totalDiscount"].ToString();
                        txt_totalinvoice.Text = dr["totalAfterDicscount"].ToString();
                        txt_OldPay.Text = dr["pay"].ToString();
                        txt_sales.Text = Program.salesman;
                        Txt_TotalReturn.Text = txt_totalinvoice.Text;

                    }
                    dataGridView1.DataSource = dt2;
                    dataGridView1.Columns[0].Visible = false;
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(Txt_IdSupplier.Text));
                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]);
                    Txt_CustBalance.Text = mno.ToString();
                    if (mno >= 0)
                    {
                        label5.Text = "له";
                    }
                    else if (mno < 0)
                    {
                        label5.Text = "عليه";
                    }

                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
              
            
          
        }

        private void txt_prise_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_QuantityReturn_Leave(object sender, EventArgs e)
        {
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد إسترجاع الفاتورة بالكامل", "إسترجاع الفاتورة بالكامل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (dataGridView1.Rows.Count > 0)
                    {
                        if (txt_IdOrder.Text == "") { MessageBox.Show("لا بد من اختيار فاتورة"); return; }
                        if (Txt_IdSupplier.Text == "") { MessageBox.Show("لا بد من وجود رقم المورد"); return; }
                        if (txt_sales.Text == "") { txt_sales.Text = Program.salesman; }
                        if (Txt_Pay.Text == "") Txt_Pay.Text = "0";

                        if (Convert.ToDecimal(Txt_Pay.Text) > 0)
                        {
                            if (cmb_Stock.Text == "")
                            {
                                MessageBox.Show("لا بد من تحديد الخزنة المضاف اليها المبلغ المدفوع من المورد");
                                return;
                            }
                            if (Convert.ToDecimal(Txt_Pay.Text)>0)
                            {
                                st.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(Txt_Pay.Text), dateTimePicker1.Value,
                                         txt_sales.Text, " رصيد مضاف الى الخزنة ", "مرتجع فاتورة مستريات رقم " + " " + txt_IdOrder.Text);
                                st.InsertStockMove(Convert.ToDecimal(Txt_Pay.Text), dateTimePicker1.Value, "مرتجع مشتريات ", $"مرتجع  فاتوره مشتريات رقم {txt_IdOrder.Text} للمورد {txt_Name.Text}", Convert.ToInt32(cmb_Stock.SelectedValue), txt_sales.Text, "دخول الي الخزينة", Convert.ToInt32(txt_IdOrder.Text));

                            }

                        }
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dt87.Clear();
                            dt87 = s.SelectQuantityOFProductFromSuppliersReturn(Convert.ToInt32(txt_IdOrder.Text),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                            if (dt87.Rows.Count > 0)
                            {

                                
                                MessageBox.Show("لقد تم استرجاع صنف من هذه الفاتورة من قبل او استرجعاها بالكامل ف لابد ان يتم المرتجع لكل صنف لوحده ");
                                return;

                            }
                        }

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {

                            s.AddReturn(Convert.ToInt32(txt_IdOrder.Text), Convert.ToInt32(Txt_IdSupplier.Text),
                            Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value),
                            dateTimePicker1.Value, Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value),
                            Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), txt_sales.Text);

                            //dt6.Clear();
                            //dt6 = p.Select_NumberSmallInLargeUnit(Convert.ToInt32(DGV_Return.Rows[i].Cells[0].Value), Convert.ToString(DGV_Return.Rows[i].Cells[3].Value));
                            //decimal x = Convert.ToDecimal(DGV_Return.Rows[i].Cells[4].Value) / Convert.ToDecimal(dt6.Rows[0][1]);

                            p.Update_ProductQuantityDecrease(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                                 Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value));


                            p.Add_MoveProduct(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), 0, 0,
                                Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value),
                          Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), 0, 0, 0, "مرتجع مشتريات فاتورة رقم" + " " + txt_IdOrder.Text
                          , dateTimePicker1.Value, Program.salesman, "خروج");
                        }

                        Login l = new Login();
                        l.addMoveUser(Program.salesman, this.Text, $"مرتجع مشتريات بالكامل برقم فاتورة {txt_IdOrder.Text}");
                        DataTable dt71 = new DataTable();
                        dt71.Clear();
                        dt71 = s.select_SupplierBalance(Convert.ToInt32(Txt_IdSupplier.Text));
                        decimal mno = Convert.ToDecimal(dt71.Rows[0][1]) - (Convert.ToDecimal(txt_totalinvoice.Text) - Convert.ToDecimal(Txt_Pay.Text));
                        s.Add_SuppliersStatementAccount(Convert.ToInt32(Txt_IdSupplier.Text), Convert.ToDecimal(Txt_Pay.Text),
                                                      Convert.ToDecimal(txt_totalinvoice.Text), "مرتجع مشتريات للفاتورة رقم " + " " + txt_IdOrder.Text, dateTimePicker1.Value, mno);

                        s.Update_SupplierTotalMoney(Convert.ToInt32(Txt_IdSupplier.Text), mno);



                        MessageBox.Show("تم حفظ مرتجع الفاتورة بنجاح ", "عمليه المرتجع", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                     
                        clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("لا بد من إختيار فاتورة");
                    }
                }
                else
                {
                    MessageBox.Show("تم إلغاء عملية إسترجاع الفاتورة بالكامل");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
            



