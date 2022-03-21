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
using System.Globalization;

namespace clothesStore.PL
{
    public partial class Form2 : Form
    {
        private static Form2 farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Form2 getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Form2();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        Category C = new Category();
        DataTable dt = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt6 = new DataTable();
        Suppliers sup = new Suppliers();
        Store Store = new Store();
        Stock s = new Stock();
        Proudect p = new Proudect();

        void ComboCategory()
        {
            Cmb_Category.DataSource = C.Select_ComboCategory();
            Cmb_Category.DisplayMember = "Category_Name";
            Cmb_Category.ValueMember = "Category_Id";
               Cmb_Category.SelectedIndex = -1;

        }
        public Form2()
        {
            InitializeComponent();

            if (farm==null)
            {
                farm = this;
            }
            //txt_barcode.Hide();
            //Btn_PrintPreview.Hide();
            ComboSupplier();
            ComboStock();
            dataTablee();
            ComboCategory();
            txt_sales.Text = Program.salesman;
        }
      
        void ComboSupplier()
        {
            comboBox1.Properties.DataSource = sup.CompoBoxSuppliers();
            comboBox1.Properties.DisplayMember = "Name";
            comboBox1.Properties.ValueMember = "Sup_id";
            comboBox1.SelectionLength = -1;
        }
        void ComboStock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
            if (dt4.Rows.Count > 0)
            {
                dt4 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

            }
        }
        public void dataTablee()
        {
            dt.Columns.Add("رقم الصنف");//0
            dt.Columns.Add("اسم الصنف");//1
            dt.Columns.Add("النوع");//2
            dt.Columns.Add("سعرالشراء");//3
            dt.Columns.Add("الكميه"); //4
            dt.Columns.Add("الأجمالي");//5
            dt.Columns.Add("الخصم");//6
            dt.Columns.Add("الاجمالي بعد الخصم");//7
            dt.Columns.Add("رقم الباركود");//8
            dt.Columns.Add("سعر البيع");//9
            gridControl2.DataSource = dt;
        }

        void data()
        {
            //dataGridView1.DataSource = null;
            txt_Discount.Text = "0";
            txt_AfterDisc.Text = "0";

            dt.Clear();
            txt_note.Clear();
            txt_pay.Text = "0";
            txt_mark.Text = "0";
            txt_invo.Text = "0";
            txt_num.Clear();
            //txt_barcode.Enabled = true;
            btn_save.Enabled = false;

            button2.Enabled = true;
            //Btn_selectProduct.Enabled = true;
            Btn_New.Enabled = true;
            //Cmb_product.SelectedIndex = -1;
            //comboBox1.SelectedIndex = -1;
            //lblItemsCount.Text = DgvSale.Rows.Count.ToString();

        }

        public void TOTALFINALYDISCOUNT()
        {
            Decimal X = 0;
            Decimal Y;
            Decimal TEXT;
            if (txt_Discount.Text != "")
            {
                TEXT = (Convert.ToDecimal(txt_invo.Text) - Convert.ToDecimal(txt_Discount.Text));
                txt_AfterDisc.Text = TEXT.ToString();



            }

            else
            {
                txt_Discount.Text = "0";
                Y = (Convert.ToDecimal(txt_invo.Text) + X) - Convert.ToDecimal(txt_Discount.Text);
                txt_AfterDisc.Text = Y.ToString();
            }
        }
        public void calctotalinvoOrder()
        {
            decimal total = 0;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                total += Convert.ToDecimal(row[7]);
            }
            txt_invo.Text = Math.Round(total, 1).ToString();
        }
        public void pay()
        {
            if (txt_AfterDisc.Text != string.Empty && txt_pay.Text != string.Empty)
            {
                decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - Convert.ToDecimal(txt_pay.Text);
                txt_mark.Text = Math.Round(totainv, 1).ToString();
            }
            else if (txt_pay.Text == string.Empty)
            {
                decimal x = 0;
                decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - x;
                txt_mark.Text = Math.Round(totainv, 1).ToString();
            }
        }

        public void calcalutordirect()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                decimal mins = Convert.ToDecimal(row[3]) * Convert.ToInt32(row[4]);
                row[5] = mins.ToString();
            }
        }

        public void totaldirect()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                decimal amount = Convert.ToDecimal(row[5]);
                decimal discount = Convert.ToDecimal(row[6]);
                decimal total = amount;
                row[7] = total.ToString();
            }
        }
        public void totalinvoicesup()
        {           
                decimal total = 0;
                for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                total += Convert.ToDecimal(row[7]);
                }
                txt_invo.Text = Math.Round(total, 2).ToString();         
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{              
            //    FormListSuppliers ls = new FormListSuppliers();
            //    ls.ShowDialog();            
            //    if (ls.dataGridView1.Rows.Count > 0 && ls.dataGridView1.SelectedRows.Count>0)
            //    {
            //        for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //        {
            //            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == ls.dataGridView1.CurrentRow.Cells[0].Value.ToString())
            //            {
            //                Console.Beep();
            //                MessageBox.Show("هذا الصنف مسجل من قبل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //        }
                
            //        DataRow r = dt.NewRow();
            //        r[0] = ls.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //        r[1] = ls.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //        r[2] = ls.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //        r[3] = ls.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //        r[4] = 1;
            //        r[6] = 0;
            //        r[8] = ls.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //        r[9] = ls.dataGridView1.CurrentRow.Cells[6].Value.ToString();
 
            //        dt.Rows.Add(r);
            //        Console.Beep();
            //        dataGridView1.DataSource = dt;
            //        calcalutordirect();
            //        totaldirect();
            //        totalinvoicesup();
            //        pay();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //}
            }
        private void btn_save_Click(object sender, EventArgs e)
        {

            DataTable dt4 = new DataTable();
            try
            {
                if (gridView2.RowCount <= 0) { MessageBox.Show("لا بد من اختيار صنف واحد على الاقل "); return; }
                if (comboBox1.Text == "") { MessageBox.Show("لابد من اختيار إسم مورد "); return; }
                if (cmb_Stock.Text == "") { MessageBox.Show("لابد من اختيار الخزنة "); return; }
                if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(txt_invo.Text))
                {
                    MessageBox.Show("لابد أن يكون المدفوع اقل من اجمالى الفاتورة ");
                    txt_pay.Focus();
                    return;
                }
                dt4.Clear();
                dt4 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                if (dt4.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                    {
                        MessageBox.Show("رصيد الخزنة الحالى غير كافى لشراء هذه الفاتورة");
                        return;

                    }
                }
                btn_save.Enabled = false;

             

                sup.ADDSuppliersINFORMARION(Convert.ToInt32(comboBox1.EditValue),
                    dateTimePicker1.Value, txt_note.Text, txt_sales.Text, Convert.ToDecimal(txt_invo.Text),
                    Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_mark.Text), Convert.ToInt32(cmb_Stock.SelectedValue),
                     Convert.ToDecimal(txt_Discount.Text), Convert.ToDecimal(txt_AfterDisc.Text));
                txt_num.Text = sup.LastSuppliersDetalis().Rows[0][0].ToString();

                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    sup.addSuppliersDetails(Convert.ToInt32(txt_num.Text),
                   Convert.ToInt32(row[0]), Convert.ToDecimal(row[4])
                  , Convert.ToDecimal(row[3]), Convert.ToDecimal(row[5]),
                   Convert.ToDecimal(row[6]), Convert.ToDecimal(row[7]),
                   row[1].ToString());



                    p.Add_MoveProduct(Convert.ToInt32(row[0]), Convert.ToInt32(row[4]), Convert.ToDecimal(row[3]), 0,
                         0, 0, Convert.ToDecimal(row[3]), 0, "فاتورة مشتريات رقم " + " " + txt_num.Text,
                         dateTimePicker1.Value, Program.salesman, "دخول");
                    //dt6.Clear();
                    //dt6 = p.Select_NumberSmallInLargeUnit(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToString(dataGridView1.Rows[i].Cells[4].Value));
                    //decimal x = Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value) / Convert.ToDecimal(dt6.Rows[0][1]);
                    dt4.Clear();
                    dt4 = Store.Validate_ProductStore(Convert.ToInt32(row[0]),
                        Convert.ToDecimal(row[3]));
                    if (dt4.Rows.Count == 0)
                    {

                        Store.Add_StoreProduct(Convert.ToInt32(row[0]),
                         Convert.ToDecimal(row[3]));

                    }

                
                    //else if (dt4.Rows.Count>0)

                    p.Update_ProductQuantityIncrease(Convert.ToInt32(row[0]),
                                                      Convert.ToDecimal(row[4]));


                    //}
                }
                if (Convert.ToDecimal(txt_pay.Text) > 0)
                {
                    s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dateTimePicker1.Value,
                        txt_sales.Text, " رصيد مسحوب من الخزنة لفاتورة مشتريات", "فاتورة مشتريات" + " " + comboBox1.Text);
                    s.InsertStockMove(Convert.ToDecimal(txt_pay.Text)*-1, dateTimePicker1.Value, "فاتورة مشتريات  ", $"فاتورة مشتريات رقم {txt_num.Text} للمورد {comboBox1.Text}", Convert.ToInt32(cmb_Stock.SelectedValue), txt_sales.Text,"خروج من الخزينة", Convert.ToInt32(txt_num.Text));

                }
                Login l = new Login();
                l.addMoveUser(Program.salesman, this.Text, $"فاتورة مشتريات رقم {txt_num.Text}");

                dt6.Clear();
                dt6 = sup.select_SupplierBalance(Convert.ToInt32(comboBox1.EditValue));
                decimal mno = Convert.ToDecimal(dt6.Rows[0][1]) + Convert.ToDecimal(txt_mark.Text);
                sup.Update_SupplierTotalMoney(Convert.ToInt32(comboBox1.EditValue), mno);
                sup.Add_SuppliersStatementAccount(Convert.ToInt32(comboBox1.EditValue), Convert.ToDecimal(txt_AfterDisc.Text),
                    Convert.ToDecimal(txt_pay.Text), "فاتورة مشتريات رقم " + " " + txt_num.Text, dateTimePicker1.Value, mno);
                MessageBox.Show("تم اضافه الفاتوره بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                data();
                btn_save.Enabled = true;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }
     
      
     
     

     

      
       

       
        private void button2_Click(object sender, EventArgs e)
        {
            Form_Suppliers sm = new Form_Suppliers();
            sm.ShowDialog();
            comboBox1.Properties.DataSource = sup.CompoBoxSuppliers();
        }
        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txt_barcode.Text != "" && e.KeyChar == 13)
                {


                    dt51.Clear();
                    dt51 = p.search_barcode(Convert.ToInt64(txt_barcode.Text));
                    if (dt51.Rows.Count > 0)
                    {

                        for (int i = 0; i < gridView2.RowCount; i++)
                        {
                            DataRow row = gridView2.GetDataRow(i);
                            if (row[0].ToString() == dt51.Rows[0][0].ToString())
                            {
                                int x = 1;
                                Console.Beep();
                                row[4] = Convert.ToInt32(row[4]) + x;
                                txt_barcode.Clear();

                                calcalutordirect();
                                totaldirect();

                                calctotalinvoOrder();
                                TOTALFINALYDISCOUNT();
                                pay();


                                return;


                            }
                        }



                        DataRow r = dt.NewRow();
                        r[0] = dt51.Rows[0][0];
                        r[1] = dt51.Rows[0][1];
                        r[2] = dt51.Rows[0][2];
                        r[3] = dt51.Rows[0][3];
                        r[4] = 1.00;
                        r[6] = 0;
                        dt.Rows.Add(r);
                        Console.Beep();
                        gridControl2.DataSource = dt;
                        calcalutordirect();
                        totaldirect();
                        calctotalinvoOrder();
                        TOTALFINALYDISCOUNT();
                        pay();

                        //lblItemsCount.Text = DgvSale.Rows.Count.ToString();

                        btn_save.Enabled = true;
                        txt_pay.Enabled = true;


                        txt_barcode.Clear();
                        txt_barcode.Focus();
                    }

                    else
                    {
                        MessageBox.Show("هذا الصنف غير مسجل ");
                        txt_barcode.Clear();
                        return;
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Btn_PrintPreview_Click(object sender, EventArgs e)
        {
            try
            {


                if (gridView2.RowCount > 0)
                {

                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        DataRow row = gridView2.GetDataRow(i);

                        DataSet1 ds = new DataSet1();
                        //ds.Clear();
                        //Rpt.CrystalReport2 cr = new Rpt.CrystalReport2();
                        //ds.Tables[0].Rows.Add(dataGridView1.Rows[i].Cells[1].Value.ToString(), "*" + dataGridView1.Rows[i].Cells[10].Value.ToString().Trim() + "*", dataGridView1.Rows[i].Cells[10].Value.ToString(), dataGridView1.Rows[i].Cells[11].Value.ToString());
                        //cr.SetDataSource(ds);
                        //Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                        //frm.crystalReportViewer1.ReportSource = cr;
                        //frm.crystalReportViewer1.Refresh();
                        //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                        //cr.PrintToPrinter(Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value), true, 0, 0);
                        //frm.ShowDialog();
                        if (Properties.Settings.Default.BarcodeSize == "مقاس كبير ")
                        {

                            Rpt.Rpt_Large_Barcode cr = new Rpt.Rpt_Large_Barcode();
                            ds.Tables[0].Rows.Add(row[1].ToString(), "*" + row[8].ToString().Trim() + "*", row[8].ToString(), row[9].ToString());
                            cr.SetDataSource(ds);
                            Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                            frm.crystalReportViewer1.ReportSource = cr;
                            frm.crystalReportViewer1.Refresh();
                            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                            cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintBarcode;
                            //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                            cr.PrintToPrinter(Convert.ToInt32(row[4]), true, 0, 0);
                        }
                        else if (Properties.Settings.Default.BarcodeSize == "مقاس وسط ")
                        {

                            Rpt.Rpt_MidBarcode cr = new Rpt.Rpt_MidBarcode();
                            ds.Tables[0].Rows.Add(row[1].ToString(), "*" + row[8].ToString().Trim() + "*", row[8].ToString(), row[9].ToString());
                            cr.SetDataSource(ds);
                            Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                            frm.crystalReportViewer1.ReportSource = cr;
                            frm.crystalReportViewer1.Refresh();
                            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                            cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintBarcode;
                            //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                            cr.PrintToPrinter(Convert.ToInt32(row[4]), true, 0, 0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("لابد من اختيار صنف واحد على الاقل");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Txt_pay_MouseClick(object sender, MouseEventArgs e)
        {
            txt_pay.SelectAll();
        }
        void Update_QtyUnit()
        {
            try
            {


                Frm_EditUnit Frm = new Frm_EditUnit();

                if (gridView2.RowCount > 0 && gridView2.SelectedRowsCount > 0)
                {
                    //    Frm.cmb_Unit.DataSource = p.Select_UnitProduct(Convert.ToInt32(DgvSale.CurrentRow.Cells[0].Value));
                    //    Frm.cmb_Unit.DisplayMember = "Unit_Name";
                   // Frm.cmb_Unit.ValueMember = "Id_Unit";

                    Frm.textBox1.Text = gridView2.GetFocusedRowCellValue(ID_Item).ToString();
                   
                    Frm.Txt_Quantity.Text = gridView2.GetFocusedRowCellValue(quantity).ToString();

                    Frm.Txt_DisCount.Text = gridView2.GetFocusedRowCellValue(Discount).ToString();

                    Frm.txt_prise.Text = gridView2.GetFocusedRowCellValue(Price).ToString();

                    Frm.ShowDialog();

                }
                if (Frm.Txt_Quantity.Text != "0" && Frm.txt_prise.Text != "" && Frm.txt_prise.Text != "0"
                    && Frm.Txt_DisCount.Text != "")
                {

                    gridView2.SetFocusedRowCellValue(quantity, Frm.Txt_Quantity.Text);
                    gridView2.SetFocusedRowCellValue(Discount, Frm.Txt_DisCount.Text);
                    gridView2.SetFocusedRowCellValue(Price, 
                    Convert.ToDecimal(Frm.txt_prise.Text) - Convert.ToDecimal(Frm.Txt_DisCount.Text));
                    calcalutordirect();
                    totaldirect();
                    calctotalinvoOrder();
                    TOTALFINALYDISCOUNT();
                    pay();
                    gridView2.RefreshData();

                    //DgvSale.CurrentRow.Cells[3].Value = Frm.cmb_Unit.Text;
                    //  int qu = Convert.ToInt32(gridView2.GetFocusedRowCellValue(quantity).ToString());
                    //  qu= Convert.ToInt32(Frm.Txt_Quantity.Text);
                    //  decimal disc = Convert.ToDecimal(gridView2.GetFocusedRowCellValue(Discount).ToString());
                    //disc  = Convert.ToDecimal(Frm.Txt_DisCount.Text);
                    //  decimal pri = Convert.ToDecimal(gridView2.GetFocusedRowCellValue(Price).ToString());
                    //pri  = Convert.ToDecimal(Frm.txt_prise.Text);
                    //    DataTable dt3 = new DataTable();
                    //dt3.Clear();
                    //dt3 = p.SelectQuantityMinmun(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Item)));
                    //if (dt3.Rows.Count > 0)
                    //{
                    //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}

                    Frm.Txt_Quantity.Clear();
                    Frm.Txt_DisCount.Clear();
                    Frm.txt_prise.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        private void Txt_pay_MouseLeave(object sender, EventArgs e)
        {
            if (txt_pay.Text=="")
            {
                txt_pay.Text = "0";
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            dt4.Clear();
            if (comboBox1.Text != "")
            {
                dt4 = sup.VildateSuppliers(Convert.ToInt32(comboBox1.EditValue));
                if (dt4.Rows.Count == 0)
                {
                    MessageBox.Show("اسم المورد الذى قمت باادخالة غير مسجل ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    comboBox1.SelectAll();
                    comboBox1.Focus();
                    return;
                }
            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            data();
            btn_save.Enabled = true;
            Cmb_Category.SelectedIndex = -1;

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                totalinvoicesup();
                pay();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        DataTable dt5 = new DataTable();
        void selectproudectfromcategory()
        {
            try
            {
               
                dt5.Clear();
                dt5 = p.Select_ProductForButtonSupplier(Convert.ToInt32(Cmb_Category.SelectedValue));
                if (dt5.Rows.Count > 0)
                {


                    Cmb_product.DataSource = p.Select_ProductForButtonSupplier(Convert.ToInt32(Cmb_Category.SelectedValue));
                    Cmb_product.DisplayMember = "Name_Prod";
                    Cmb_product.ValueMember = "ID_Prod";
                }
                else
                {
                    Cmb_product.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Cmb_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                selectproudectfromcategory();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        DataTable dt51 = new DataTable();
   
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dt51.Clear();
                dt51 = p.SelectListSuppliersForPursh(Convert.ToInt32(Cmb_product.SelectedValue));
                if (Cmb_product.Text != "" && dt51.Rows.Count > 0)
                {

                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        if (row[0].ToString() == Cmb_product.SelectedValue.ToString())
                        {
                            //dt6.Clear();
                            //dt6 = p.Select_NumberSmallInLargeUnit(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value), Convert.ToString(DgvSale.Rows[i].Cells[3].Value));

                            decimal y = Convert.ToDecimal(row[4]);


                                decimal x = 1;
                                Console.Beep();
                                row[4] = Convert.ToDecimal(row[4]) + x;

                                calcalutordirect();
                                totaldirect();
                                calctotalinvoOrder();
                                TOTALFINALYDISCOUNT();
                                pay();



                                

                                return;
                            
                        }

                    }
              
                    //if (dt51.Rows.Count>0)
                    //{
                    DataRow r = dt.NewRow();
                    r[0] = dt51.Rows[0][0];
                    r[1] = dt51.Rows[0][1];
                    r[2] = dt51.Rows[0][2];
                    r[3] = dt51.Rows[0][3];
                    r[4] = 1.00;
                    r[6] = 0;
                    r[8]= dt51.Rows[0][5];
                    r[9]= dt51.Rows[0][6];
                    dt.Rows.Add(r);
                    Console.Beep();
                    gridControl2.DataSource = dt;
                    calcalutordirect();
                    totaldirect();
                    calctotalinvoOrder();
                    TOTALFINALYDISCOUNT();
                    pay();
                   


                    txt_barcode.Focus();
                }
                else
                {
                    MessageBox.Show("هذا الصنف غير مسجل فى قائمة الاصناف");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.Column.Name == "Item_Name")
            {
                Update_QtyUnit();
            }

            if (e.Column.Caption == "neg")
            {
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    if (gridView2.GetFocusedRowCellValue(ID_Item).ToString() == row[0].ToString())
                    {
                        //MessageBox.Show("هذا الصنف متسجل حاليا");
                        //return;



                        decimal y = Convert.ToDecimal(row[4]);

                        if (y >= Convert.ToDecimal(dt51.Rows[0][4]))
                        {
                            MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {

                            decimal x = 1;
                            row[4] = Convert.ToDecimal(row[4]) + x;
                            Console.Beep();
                            calcalutordirect();
                            totaldirect();
                            calctotalinvoOrder();
                            TOTALFINALYDISCOUNT();
                            pay();
                            gridView2.RefreshData();
                            //dt5.Clear();
                            //dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
                            //if (dt5.Rows.Count > 0)
                            //{
                            //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //}


                            return;
                        }
                    }


                }
            }

            if (e.Column.Caption == "Post")
            {
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    if (gridView2.GetFocusedRowCellValue(ID_Item).ToString() == row[0].ToString())
                    {
                        //MessageBox.Show("هذا الصنف متسجل حاليا");
                        //return;




                        if (Convert.ToInt32(row[4]) == 1)
                        {
                            return;
                        }

                        decimal x = 1;
                        row[4] = Convert.ToDecimal(row[4]) - x;
                        Console.Beep();
                        calcalutordirect();
                        totaldirect();
                        calctotalinvoOrder();
                        TOTALFINALYDISCOUNT();
                        pay();
                        gridView2.RefreshData();

                        //dt5.Clear();
                        //dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
                        //if (dt5.Rows.Count > 0)
                        //{
                        //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}

                        return;

                    }


                }
            }
            if (e.Column.Caption == "remove")
            {

                gridView2.DeleteSelectedRows();

                calctotalinvoOrder();
                TOTALFINALYDISCOUNT();
                pay();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Discount_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalinvoOrder();
            TOTALFINALYDISCOUNT();
            pay();
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

        private void txt_pay_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_pay.Text == "0")
            {
                txt_pay.Text = "";
            }
        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            if (txt_Discount.Text == "")
            {
                txt_Discount.Text = "0";
            }
        }

        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text == "")
            {
                txt_pay.Text = "0";
            }
        }

        private void gridView2_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            gridView2.DeleteSelectedRows();

            calctotalinvoOrder();
            TOTALFINALYDISCOUNT();
            pay();
        }

        private void txt_invo_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalinvoOrder();
            TOTALFINALYDISCOUNT();
            pay();
        }

        private void txt_pay_KeyUp(object sender, KeyEventArgs e)
        {
            pay();
        }

        private void txt_mark_KeyUp(object sender, KeyEventArgs e)
        {
            pay();
        }
    }
}

