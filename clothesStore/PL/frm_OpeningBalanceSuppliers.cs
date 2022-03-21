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
    public partial class frm_OpeningBalanceSuppliers : DevExpress.XtraEditors.XtraForm
    {
        Suppliers s = new Suppliers();
        Order o = new Order();
        Customer c = new Customer();
        Login l = new Login();
        public frm_OpeningBalanceSuppliers()
        {
            InitializeComponent();
            ComboSupplier();
        }
       
        void ComboSupplier()
        {
            cmb_supp.Properties.DataSource = s.CompoBoxSuppliers();
            cmb_supp.Properties.DisplayMember = "Name";
            cmb_supp.Properties.ValueMember = "Sup_id";
            cmb_supp.SelectionLength = -1;
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
            cmb_supp.Enabled = true;

            gridControl1.DataSource = c.selectOpeniningBalance("مورد");
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            txt_name.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_depit.Text==""){MessageBox.Show("من فضلك قم بااخنيار نوع المديونية");return;}
                if (cmb_supp.Text == ""|| cmb_supp.Text == "اسم العميل") { MessageBox.Show("من فضلك قم بااخنيار اسم العميل");return;}
                if (txt_pay.Text == "" ||txt_pay.Text=="0"){MessageBox.Show("من فضلك قم باادخال المبلغ");return;}

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                  DataRow row = gridView1.GetDataRow(i);
                 if (Convert.ToInt32(row[0]).ToString() == Convert.ToInt32(cmb_supp.EditValue).ToString()) { MessageBox.Show("رصيد اول المدة لهذا العميل مسجل من قبل");return; }
                    
                }
                DataTable dt6 = new DataTable();

           


               
               


                if (Cmb_depit.Text== "مدين")
                {
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(cmb_supp.EditValue));
                    c.AddOpeningBalance( dateTimePicker1.Value, 0, Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة", "مورد",Convert.ToInt32(cmb_supp.EditValue),null);

                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) - Convert.ToDecimal(txt_pay.Text);
                    s.Update_SupplierTotalMoney(Convert.ToInt32(cmb_supp.EditValue), mno);
                    s.Add_SuppliersStatementAccount(Convert.ToInt32(cmb_supp.EditValue), 0, Convert.ToDecimal(txt_pay.Text),
                            "مدين رصيد اول المدة", dateTimePicker1.Value, mno);

                    l.addMoveUser(Program.salesman, this.Text, $"مدين رصيد اول المدة للمورد {cmb_supp.Text} برصيد ({txt_pay.Text})");

                }
                else if(Cmb_depit.Text == "دائن")
                {
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(cmb_supp.EditValue));
                    c.AddOpeningBalance(dateTimePicker1.Value, Convert.ToDecimal(txt_pay.Text), 0, "دائن رصيد اول المدة", "مورد", Convert.ToInt32(cmb_supp.EditValue), null);

                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) + Convert.ToDecimal(txt_pay.Text);
                    s.Update_SupplierTotalMoney(Convert.ToInt32(cmb_supp.EditValue), mno);
                    s.Add_SuppliersStatementAccount(Convert.ToInt32(cmb_supp.EditValue), Convert.ToDecimal(txt_pay.Text),
                      0,"دائن رصيد اول المدة", dateTimePicker1.Value, mno);

                    l.addMoveUser(Program.salesman, this.Text, $"دائن رصيد اول المدة للمورد {cmb_supp.Text} برصيد ({txt_pay.Text})");


                }
                gridControl1.DataSource = c.selectOpeniningBalance("مورد");
                MessageBox.Show("تم حفظ العملية بنجاح");
                cmb_supp.SelectionLength = -1;
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




                DataTable dt6 = new DataTable();

               


                if (gridView1.GetFocusedRowCellValue(bayan).ToString()== "دائن رصيد اول المدة")
                {
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(textBox1.Text));

                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) + Convert.ToDecimal(txt_pay.Text);
                    s.Update_SupplierTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                }
                else if(gridView1.GetFocusedRowCellValue(bayan).ToString() == "مدين رصيد اول المدة")
                {
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(textBox1.Text));

                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) - Convert.ToDecimal(txt_pay.Text);
                    s.Update_SupplierTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                }

              
                if (Cmb_depit.Text == "مدين")
                {

                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(textBox1.Text));

                    s.updateOpeningBalanceSupp( dateTimePicker1.Value, 0, Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة",Convert.ToInt32(textBox1.Text));
                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) - Convert.ToDecimal(txt_pay.Text);
                    s.Update_SupplierTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                    s.Update_SupplierStatmentAccount(Convert.ToInt32(textBox1.Text), 0,
                      Convert.ToDecimal(txt_pay.Text), "مدين رصيد اول المدة", dateTimePicker1.Value, mno);

                    l.addMoveUser(Program.salesman, this.Text, $"تعديل في رصيد اول المدة للمورد {cmb_supp.Text} برصيد ({txt_pay.Text})");

                }
                else if (Cmb_depit.Text == "دائن")
                {
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(textBox1.Text));

                    s.updateOpeningBalanceSupp( dateTimePicker1.Value, Convert.ToDecimal(txt_pay.Text), 0, "دائن رصيد اول المدة", Convert.ToInt32(textBox1.Text));
                    decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) + Convert.ToDecimal(txt_pay.Text);

                    s.Update_SupplierTotalMoney(Convert.ToInt32(textBox1.Text), mno);
                    s.Update_SupplierStatmentAccount(Convert.ToInt32(textBox1.Text), Convert.ToDecimal(txt_pay.Text),
                      0, "دائن رصيد اول المدة", dateTimePicker1.Value, mno);




                }

                MessageBox.Show("تم حفظ العملية بنجاح");

                cmb_supp.Enabled = true;
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                gridControl1.DataSource = c.selectOpeniningBalance("مورد");
                cmb_supp.SelectionLength = -1;
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
                        cmb_supp.Enabled = false;
                        txt_name.Show();
                        txt_name.Clear();
                        textBox1.Clear();
                        txt_name.Text = gridView1.GetFocusedRowCellValue(NameSupp).ToString();
                        textBox1.Text = gridView1.GetFocusedRowCellValue(Sup_id).ToString();
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
                        s.deleteOpeningBalanceSupp(Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneyadd)),
                         Convert.ToDecimal(gridView1.GetFocusedRowCellValue(Moneydiscount)), gridView1.GetFocusedRowCellValue(bayan).ToString(),
                         Convert.ToInt32(gridView1.GetFocusedRowCellValue(Sup_id)));

                        l.addMoveUser(Program.salesman, this.Text, $"مسح رصيد اول المدة للمورد {gridView1.GetFocusedRowCellValue(NameSupp)}");

                        MessageBox.Show("تم المسح بنجاح");
                        gridControl1.DataSource = c.selectOpeniningBalance("مورد");

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