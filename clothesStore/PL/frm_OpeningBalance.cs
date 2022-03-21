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
    public partial class frm_OpeningBalance : DevExpress.XtraEditors.XtraForm
    {
        Customer c = new Customer();
        Order o = new Order();
        Login l = new Login();
        public frm_OpeningBalance()
        {
            InitializeComponent();
            ComboCustomer();
        }
        void ComboCustomer()
        {
            cmb_cust.Properties.DataSource = o.SelectCustName();
            cmb_cust.Properties.DisplayMember = "Name";
            cmb_cust.Properties.ValueMember = "ID_Cust";
            cmb_cust.SelectionLength = -1;
        }
        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_pay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void frm_OpeningBalance_Load(object sender, EventArgs e)
        {
            cmb_cust.Enabled = true;

            gridControl1.DataSource = c.selectOpeniningBalance("عميل");
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            txt_name.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_depit.Text==""){MessageBox.Show("من فضلك قم بااخنيار نوع المديونية");return;}
                if (cmb_cust.Text == ""|| cmb_cust.Text == "اسم العميل") { MessageBox.Show("من فضلك قم بااخنيار اسم العميل");return;}
                if (txt_pay.Text == "" ||txt_pay.Text=="0"){MessageBox.Show("من فضلك قم باادخال المبلغ");return;}

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                  DataRow row = gridView1.GetDataRow(i);
                 if (Convert.ToInt32(row[0]).ToString() == Convert.ToInt32(cmb_cust.EditValue).ToString()) { MessageBox.Show("رصيد اول المدة لهذا العميل مسجل من قبل");return; }
                    
                }
                DataTable dt51 = new DataTable();

                dt51.Clear();
                dt51 = c.Select_CustomerBalance(Convert.ToInt32(cmb_cust.EditValue));
             
               



                if (Cmb_depit.Text== "مدين")
                {

                    c.AddOpeningBalance(dateTimePicker1.Value,0 , Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة", "عميل", null, Convert.ToInt32(cmb_cust.EditValue));
                    decimal mno = Convert.ToDecimal(dt51.Rows[0][1]) + Convert.ToDecimal(txt_pay.Text);
                    c.Update_CustomerTotalMoney(Convert.ToInt32(cmb_cust.EditValue), mno);
                    c.Add_CustomerStatmentAccount(Convert.ToInt32(cmb_cust.EditValue), 0,
                      Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة", dateTimePicker1.Value, mno, Program.salesman);

                    l.addMoveUser(Program.salesman, this.Text, $"مدين رصيد اول المدة للعميل {cmb_cust.Text} برصيد ({txt_pay.Text})" );

                }
                else if(Cmb_depit.Text == "دائن")
                {
                    c.AddOpeningBalance( dateTimePicker1.Value, Convert.ToDecimal(txt_pay.Text),0, "دائن رصيد اول المدة","عميل", null, Convert.ToInt32(cmb_cust.EditValue));
                    decimal mno = Convert.ToDecimal(dt51.Rows[0][1]) - Convert.ToDecimal(txt_pay.Text);

                    c.Update_CustomerTotalMoney(Convert.ToInt32(cmb_cust.EditValue), mno);
                    c.Add_CustomerStatmentAccount(Convert.ToInt32(cmb_cust.EditValue), Convert.ToDecimal(txt_pay.Text),
                      0, "دائن رصيد اول المدة", dateTimePicker1.Value, mno, Program.salesman);

                    l.addMoveUser(Program.salesman, this.Text, $"دائن رصيد اول المدة للعميل {cmb_cust.Text} برصيد ({txt_pay.Text})");


                }
                gridControl1.DataSource = c.selectOpeniningBalance("عميل");
                MessageBox.Show("تم حفظ العملية بنجاح");
                cmb_cust.SelectionLength = -1;
                Cmb_depit.SelectedIndex = -1;
                txt_pay.Text = "0";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_depit.Text == "") { MessageBox.Show("من فضلك قم بااخنيار نوع المديونية"); return; }

                if (txt_pay.Text == "" || txt_pay.Text == "0") { MessageBox.Show("من فضلك قم باادخال المبلغ"); return; }




                DataTable dt51 = new DataTable();

           


                if (gridView1.GetFocusedRowCellValue(bayan).ToString()== "دائن رصيد اول المدة")
                {
                    dt51.Clear();
                    dt51 = c.Select_CustomerBalance(Convert.ToInt32(textBox1.Text));
                    decimal m = Convert.ToDecimal(dt51.Rows[0][1]) + Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneydiscount));

                    c.Update_CustomerTotalMoney(Convert.ToInt32(textBox1.Text), m);
                }
                else if(gridView1.GetFocusedRowCellValue(bayan).ToString() == "مدين رصيد اول المدة")
                {
                    dt51.Clear();
                    dt51 = c.Select_CustomerBalance(Convert.ToInt32(textBox1.Text));
                    decimal m = Convert.ToDecimal(dt51.Rows[0][1]) - Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneyadd));

                    c.Update_CustomerTotalMoney(Convert.ToInt32(textBox1.Text), m);
                }

                dt51.Clear();
                dt51 = c.Select_CustomerBalance(Convert.ToInt32(textBox1.Text));
                if (Cmb_depit.Text == "مدين")
                {

                    

                    c.updateOpeningBalance( dateTimePicker1.Value, 0, Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة", Convert.ToInt32(textBox1.Text));
                    decimal mno = Convert.ToDecimal(dt51.Rows[0][1]) + Convert.ToDecimal(txt_pay.Text);
                    c.Update_CustomerTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                    c.Update_CustomerStatmentAccount(Convert.ToInt32(textBox1.Text), 0,
                      Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة", dateTimePicker1.Value, mno, Program.salesman);

                    l.addMoveUser(Program.salesman, this.Text, $"تعديل في رصيد اول المدة للعميل {cmb_cust.Text} برصيد ({txt_pay.Text})");



                }
                else if (Cmb_depit.Text == "دائن")
                {
                

                    c.updateOpeningBalance( dateTimePicker1.Value, Convert.ToDecimal(txt_pay.Text), 0, "دائن رصيد اول المدة",Convert.ToInt32(textBox1.Text));
                    decimal mno = Convert.ToDecimal(dt51.Rows[0][1]) - Convert.ToDecimal(txt_pay.Text);

                    c.Update_CustomerTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                    c.Update_CustomerStatmentAccount(Convert.ToInt32(textBox1.Text), Convert.ToDecimal(txt_pay.Text),
                      0, "دائن رصيد اول المدة", dateTimePicker1.Value, mno, Program.salesman);

                    l.addMoveUser(Program.salesman, this.Text, $"تعديل في رصيد اول المدة للعميل {cmb_cust.Text} برصيد ({txt_pay.Text})");


                }

                MessageBox.Show("تم حفظ العملية بنجاح");

                cmb_cust.Enabled = true;
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                gridControl1.DataSource = c.selectOpeniningBalance("عميل");
                cmb_cust.SelectionLength = -1;
                Cmb_depit.SelectedIndex = -1;
                txt_pay.Text = "0";
                txt_name.Hide();
                txt_name.Clear();
                textBox1.Clear();
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption== "update")
                {
               
                    if (gridView1.RowCount > 0)
                    {
                        
                        btn_add.Enabled = false;
                        btn_update.Enabled = true;
                        cmb_cust.Enabled = false;
                        txt_name.Show();
                        txt_name.Clear();
                        textBox1.Clear();
                        txt_name.Text = gridView1.GetFocusedRowCellValue(Namecust).ToString();
                        textBox1.Text = gridView1.GetFocusedRowCellValue(ID_Cust).ToString();
                        dateTimePicker1.Text = gridView1.GetFocusedRowCellValue(date).ToString();
                        if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneydiscount)) > 0)
                        {
                            txt_pay.Text = gridView1.GetFocusedRowCellValue(Moneydiscount).ToString();
                            Cmb_depit.Text = "دائن";
                        }
                        if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneyadd)) > 0)
                        {
                            txt_pay.Text = gridView1.GetFocusedRowCellValue(Moneyadd).ToString();
                            Cmb_depit.Text = "مدين";
                        }
                      

                    }
                  

                   
               
                }
                else if (e.Column.Caption == "remove")
                {
                    if (MessageBox.Show("هل تريد المسح","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                    {
                        c.deleteOpeningBalance( Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneyadd)),
                         Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneydiscount)), gridView1.GetFocusedRowCellValue(bayan).ToString(),
                         Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID_Cust)));

                        l.addMoveUser(Program.salesman, this.Text, $"مسح رصيد اول المدة للعميل {gridView1.GetFocusedRowCellValue(Namecust)})");

                        MessageBox.Show("تم المسح بنجاح");
                        gridControl1.DataSource = c.selectOpeniningBalance("عميل");

                    }

                }
            }
                catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}