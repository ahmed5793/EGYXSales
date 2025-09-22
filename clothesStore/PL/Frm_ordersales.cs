using clothesStore.Bl;
using System;
using System.Data;
using System.Windows.Forms;
using clothesStore.Rpt;
using DevExpress.XtraReports.UI;

namespace clothesStore.PL
{
    public partial class Frm_ordersales : DevExpress.XtraEditors.XtraForm
    {
        Frm_Customer c = new Frm_Customer();
        Customer Cm = new Customer();
        Order o = new Order();
        Stock s = new Stock();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt51 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt5 = new DataTable();

        Store Store = new Store();
        unit U = new unit();
        Proudect p = new Proudect();
        public Frm_ordersales()
        {
            InitializeComponent();
            ComboCustomer();
            ComboStock();
          
           // ComboProduct();
            SelectdataTable();
            //rezizse();
            txt_sales.Text = Program.salesman;
        }
        void ComboCustomer()
        {
            comboBox1.Properties.DataSource = o.SelectCustName();
            comboBox1.Properties.DisplayMember = "Name";
            comboBox1.Properties.ValueMember = "ID_Cust";
            comboBox1.SelectionLength = -1;
        }
        //void ComboStore()
        //{
        //    Cmb_Store.DataSource = Store.Select_ComboStore();
        //    Cmb_Store.DisplayMember = "Store_Name";
        //    Cmb_Store.ValueMember = "Store_Id";
        //}
        void ComboStock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
        }
        void ComboProduct()
        {
            Cmb_product.DataSource = p.Select_ProductFormStoreForSale();
            Cmb_product.DisplayMember = "Name_Prod";
            Cmb_product.ValueMember = "ID_Prod";
            Cmb_product.SelectedIndex = -1;
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
        void SelectdataTable()
        {
           
            dt.Columns.Add("رقم الصنف");//0
            dt.Columns.Add("اسم الصنف");//1
            dt.Columns.Add("النوع");//2
            dt.Columns.Add("السعر");//3
            dt.Columns.Add("الكميه"); //4
            dt.Columns.Add("الأجمالي");//5
            dt.Columns.Add("الخصم");//6
            dt.Columns.Add("الاجمالي بعد الخصم");//7
            dt.Columns.Add("باركود");//8
            gridControl2.DataSource = dt;
        }
        //void rezizse()
        //{
        //    DgvSale.RowHeadersWidth = 20;
        //    DgvSale.Columns[0].Width = 60;
        //    DgvSale.Columns[1].Width = 195;
        //    DgvSale.Columns[2].Width = 158;
        //    DgvSale.Columns[3].Width = 108;
        //    DgvSale.Columns[4].Width = 106;
        //    DgvSale.Columns[5].Width = 100;
        //    DgvSale.Columns[6].Width = 97;
        //    DgvSale.Columns[7].Width = 95;
        //    DgvSale.Columns[8].Width = 90;
        //}
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
            Btn_Print.Enabled = false;
            Btn_AddCustomer.Enabled = true;
            //Btn_selectProduct.Enabled = true;
            btn_new.Enabled = true;
            //Cmb_product.SelectedIndex = -1;
            //comboBox1.SelectedIndex = -1;
            //lblItemsCount.Text = DgvSale.Rows.Count.ToString();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dt51.Clear();
                dt51 = p.selectListProudect( Convert.ToInt32(Cmb_product.SelectedValue));
                if (Cmb_product.Text != "" && dt51.Rows.Count > 0)
                {

                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        if (row[0].ToString() == dt51.Rows[0][0].ToString())
                        {
                            //dt6.Clear();
                            //dt6 = p.Select_NumberSmallInLargeUnit(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value), Convert.ToString(DgvSale.Rows[i].Cells[3].Value));
                            
                            decimal y = Convert.ToDecimal(row[4]) ;

                            if (y >= Convert.ToDecimal(dt51.Rows[0][4]))
                            {
                                MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {

                                decimal x = 1;
                                Console.Beep();
                               row[4] = Convert.ToDecimal(row[4]) + x;

                                calcalutordirect();
                                totaldirect();
                                calctotalinvoOrder();
                                TOTALFINALYDISCOUNT();
                                pay();



                                dt5.Clear();
                                dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
                                if (dt5.Rows.Count > 0)
                                {
                                    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                             //   Cmb_product.SelectedIndex = -1;

                                return;
                            }
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
                    r[8] = dt51.Rows[0][5];
                    r[6] = 0;
                    dt.Rows.Add(r);
                    Console.Beep();
                    gridControl2.DataSource = dt;
                    calcalutordirect();
                    totaldirect();
                    calctotalinvoOrder();
                    TOTALFINALYDISCOUNT();
                    pay();
                    dt5.Clear();
                    dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
                    if (dt5.Rows.Count > 0)
                    {
                        MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    
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
        Category C = new Category();
        void ComboCategory()
        {
            Cmb_Category.DataSource = C.Select_ComboCategory();
            Cmb_Category.DisplayMember = "Category_Name";
            Cmb_Category.ValueMember = "Category_Id";
           Cmb_Category.SelectedIndex = -1;

        }
        private void Frm_Sales_Load(object sender, EventArgs e)
        { 

            ComboCategory();
            //label6.Hide();
            //txt_barcode.Hide();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    dt2.Clear();
                    dt2 = Cm.VildateCustomer(Convert.ToInt32(comboBox1.EditValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("اسم العميل الذى قمت بإدخالة غير مسجل من قبل  ", "تنبيه", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        comboBox1.SelectAll();
                        comboBox1.Focus();
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

        //private void simpleButton1_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dt51.Clear();
        //        dt51 = p.selectListProudect(Convert.ToInt32(Cmb_Store.SelectedValue), Convert.ToInt32(Cmb_product.SelectedValue));
        //        if (Cmb_product.Text != "")
        //        {
        //            for (int i = 0; i < DgvSale.Rows.Count; i++)
        //            {
        //                if (DgvSale.Rows[i].Cells[0].Value == dt51.Rows[0][0])
        //                {
        //                    if (Convert.ToInt32(DgvSale.Rows[i].Cells[5].Value) >= Convert.ToInt32(dt51.Rows[0][5]))
        //                    {
        //                        MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return;
        //                    }
        //                    else
        //                    {

        //                        int x = 1;
        //                        Console.Beep();
        //                        DgvSale.Rows[i].Cells[5].Value = Convert.ToInt32(DgvSale.Rows[i].Cells[5].Value) + x;
        //                        calcalutordirect();
        //                        totaldirect();
        //                        calctotalinvoOrder();
        //                        pay();
        //                        return;
        //                    }
        //                }

        //                DataRow r = dt.NewRow();
        //                r[0] = dt51.Rows[0][0];
        //                r[1] = dt51.Rows[0][1];
        //                r[2] = dt51.Rows[0][2];
        //                r[3] = dt51.Rows[0][3];
        //                r[4] = dt51.Rows[0][4];
        //                r[5] = 1;
        //                r[7] = 0;
        //                dt.Rows.Add(r);
        //                Console.Beep();
        //                DgvSale.DataSource = dt;
        //                calcalutordirect();
        //                totaldirect();
        //                calctotalinvoOrder();
        //                pay();
        //                DataTable dt5 = new DataTable();
        //                dt5.Clear();
        //                dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][5]), Convert.ToInt32(Cmb_Store.SelectedValue));
        //                if (dt5.Rows.Count > 0)
        //                {
        //                    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Cmb_product_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_product.Text != "")
                {
                    dt2.Clear();
                    dt2 = p.Validate_ProductFormStoreForSale(Convert.ToInt32(Cmb_product.SelectedValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("اسم الصنف الذى قمت باادخالة غير موجود فى قائمة الاصناف ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Cmb_product.SelectAll();
                        Cmb_product.Focus();
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                Masrofat m = new Masrofat();
                DataTable dt4 = new DataTable();
                Stock st = new Stock();
                if (gridView2.RowCount <= 0) { MessageBox.Show("لا بد من اختيار صنف واحد على الاقل "); return; }
                if (comboBox1.Text == "") { MessageBox.Show("لابد من اختيار إسم العميل "); return; }
                if (comboBox1.Text != "")
                {
                    dt2.Clear();
                    dt2 = Cm.VildateCustomer(Convert.ToInt32(comboBox1.EditValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("اسم العميل الذى قمت بإدخالة غير مسجل من قبل  ", "تنبيه", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        comboBox1.SelectAll();
                        comboBox1.Focus();
                        return;
                    }
                }
                if (cmb_Stock.Text == "") { MessageBox.Show("لابد من اختيار الخزنة "); return; }
                if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(txt_invo.Text))
                {
                    MessageBox.Show("لابد أن يكون المدفوع اقل من اجمالى الفاتورة ");
                    txt_pay.Focus();
                    return;
                }
                

               

                if (gridView2.RowCount > 0 && comboBox1.Text != string.Empty && cmb_Stock.Text != string.Empty)
                {
                    o.AddOrder(dateTimePicker1.Value, Convert.ToInt32(comboBox1.EditValue), txt_note.Text, txt_sales.Text,
                    Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_pay.Text), Convert.ToDecimal(txt_mark.Text),
                     Convert.ToInt32(cmb_Stock.SelectedValue), 0,
               0, Convert.ToDecimal(txt_AfterDisc.Text), Convert.ToDecimal(txt_Discount.Text));

                    txt_num.Text = o.LastId().Rows[0][0].ToString();

                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        o.AddOrderDetails(Convert.ToInt32(txt_num.Text), Convert.ToInt32(row[0]),
                        (row[1].ToString()), Convert.ToDecimal(row[4]),
                        Convert.ToDecimal(row[3]), Convert.ToDecimal(row[6]),
                        Convert.ToDecimal(row[5]), Convert.ToDecimal(row[7]));

                        //dt6.Clear();
                        //dt6 = p.Select_NumberSmallInLargeUnit(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value), Convert.ToString(DgvSale.Rows[i].Cells[3].Value));

                        //decimal x = Convert.ToDecimal(DgvSale.Rows[i].Cells[5].Value) / Convert.ToDecimal(dt6.Rows[0][1]);
                        p.Add_MoveProduct(Convert.ToInt32(row[0]), 0, 0, Convert.ToDecimal(row[4]),
                        Convert.ToDecimal(row[3]), 0, 0, 0, "مبيعات رقم " + " " + txt_num.Text, dateTimePicker1.Value,
                        Program.salesman, "خروج");


                        p.Update_ProductQuantityDecrease(Convert.ToInt32(row[0])
                            , Convert.ToDecimal(row[4]));

                        //if (DgvSale.Rows[i].Cells[3].Value.ToString() == dt7.Rows[0][0].ToString())
                        //{
                        //    p.Update_ProductQuantitySmallUnit(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value), x);
                        //    p.Update_StoreProductQuantitySmallUnit(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value),
                        //    Convert.ToInt32(Cmb_Store.SelectedValue), x);
                        //}
                        //p.Update_TotalProduct();
                    }
                    if (Convert.ToDecimal(txt_pay.Text) > 0 && Convert.ToDecimal(txt_pay.Text) <= Convert.ToDecimal(txt_invo.Text))
                    {
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text),
                     dateTimePicker1.Value, txt_sales.Text, "فاتورة مبيعات رقم " + txt_num.Text, " فاتورة مبيعات إلى" + " " + comboBox1.Text);
                        s.InsertStockMove(Convert.ToDecimal(txt_pay.Text), dateTimePicker1.Value, "فاتورة مبيعات  ", $"فاتورة مبيعات رقم {txt_num.Text} للعميل {comboBox1.Text}", Convert.ToInt32(cmb_Stock.SelectedValue), txt_sales.Text, "دخول الي الخزينة", Convert.ToInt32(txt_num.Text));

                    }
                    else if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(txt_invo.Text))
                    {
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_invo.Text),
                      dateTimePicker1.Value, txt_sales.Text, "فاتورة مبيعات رقم" + txt_num.Text, " فاتورة مبيعات إلى" + " " + comboBox1.Text);
                      s.InsertStockMove(Convert.ToDecimal(txt_pay.Text), dateTimePicker1.Value, "فاتورة مبيعات  ", $"فاتورة مبيعات رقم {txt_num.Text} للعميل {comboBox1.Text}", Convert.ToInt32(cmb_Stock.SelectedValue), txt_sales.Text,"دخول الي الخزينة", Convert.ToInt32(txt_num.Text));

                    }
                    Login l = new Login();
                    l.addMoveUser(Program.salesman, this.Text, $"فاتورة مبيعات رقم {txt_num.Text}");

                    dt51.Clear();
                    dt51 = Cm.Select_CustomerBalance(Convert.ToInt32(comboBox1.EditValue));

                    decimal mno = Convert.ToDecimal(dt51.Rows[0][1]) + Convert.ToDecimal(txt_mark.Text);
                    Cm.Update_CustomerTotalMoney(Convert.ToInt32(comboBox1.EditValue), mno);

                    Cm.Add_CustomerStatmentAccount(Convert.ToInt32(comboBox1.EditValue), Convert.ToDecimal(txt_pay.Text),
                    Convert.ToDecimal(txt_AfterDisc.Text), "فاتورة مبيعات رقم " + " " + txt_num.Text + " " + "وعمل خصم على إجمالى الفاتورة بقيمة " + " " + txt_Discount.Text, dateTimePicker1.Value, mno, txt_sales.Text);


                    MessageBox.Show("تم اضافه الفاتوره بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btn_save.Enabled = false;
                    Btn_Print.Enabled = true;



                }


                else
                {
                    MessageBox.Show("من فضلك قم بااختيار صنف واحد علي الاقل &&او التاكد من اسم العميل &&او إضافة خزنة ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
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

        private void DgvSale_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calctotalinvoOrder();
            pay();

        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {
            if (txt_pay.Text==".")
            {
                txt_pay.Text = "0";
            }

            if (txt_pay.Text == "")
            {
                decimal x = 0;
                decimal totainv = Convert.ToDecimal(txt_invo.Text) - x;
                txt_mark.Text = totainv.ToString();
            }
            else
            {
                decimal totainv = Convert.ToDecimal(txt_invo.Text) - Convert.ToDecimal(txt_pay.Text);
                txt_mark.Text = totainv.ToString();
            }
            
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
                    //    Frm.cmb_Unit.ValueMember = "Id_Unit";
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
                    gridView2.SetFocusedRowCellValue(Price, Convert.ToDecimal(Frm.txt_prise.Text) - Convert.ToDecimal(Frm.Txt_DisCount.Text));
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
        private void Frm_Sales_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F11)
            {
                Update_QtyUnit();
            }

        }

        private void DgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Update_QtyUnit();
            }
        }

        private void Cmb_Store_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboProduct();
            dt.Clear();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            data();
            btn_save.Enabled = true;
            Btn_Print.Enabled = false;
            Cmb_Category.SelectedIndex = -1;
            Cmb_product.DataSource = null;

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            calcalutordirect();
            totaldirect();
            calctotalinvoOrder();
            pay();
            ComboProduct();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt51 = new DataTable();
              

                    Rpt_PrintOrder r = new Rpt_PrintOrder();
                    FrmSingleReport sr = new FrmSingleReport();
                    sr.crystalReportViewer1.RefreshReport();
                    //r.SetDatabaseLogon("", "", ".", "FEEDStore");
                    //r.SetParameterValue("@ID", int.Parse(dataGridViewList.CurrentRow.Cells[0].Value.ToString()));
                    //sr.crystalReportViewer1.ReportSource = r;
                    //sr.Show();
                    dt51.Clear();
                    dt51 = o.RportOrder(Convert.ToInt32(txt_num.Text));
                    clothesStore.DAL.DataOrderReport ds = new DAL.DataOrderReport();
                    Rpt.Frm_RptDocumetViewer frm = new Frm_RptDocumetViewer();
                    Rpt_PrintOrder rpts = new Rpt_PrintOrder();
                    frm.documentViewer1.Refresh();
                    ds.Tables["PrintOrder"].Clear();

                    for (int i = 0; i < dt51.Rows.Count; i++)
                    {
                        ds.Tables["PrintOrder"].Rows.Add(dt51.Rows[i][0], dt51.Rows[i][1], dt51.Rows[i][2],
                        dt51.Rows[i][3], dt51.Rows[i][4], dt51.Rows[i][5]
                          , dt51.Rows[i][6], dt51.Rows[i][7], dt51.Rows[i][8],
                         dt51.Rows[i][9], dt51.Rows[i][10], dt51.Rows[i][11], dt51.Rows[i][12]
                         , dt51.Rows[i][13]);
                    }
                    SettingPrint st = new SettingPrint();
                    DataTable tbl = new DataTable();
                    tbl.Clear();
                    tbl = st.SelectSettingPrintOrder();
                    ds.Tables["PrintInformation"].Clear();
                    ds.Tables["PrintInformation"].Rows.Add(tbl.Rows[0][0], tbl.Rows[0][1], tbl.Rows[0][2],
                        tbl.Rows[0][3], tbl.Rows[0][4]);


                    //rpts.SetDatabaseLogon("", "", ".", "EasySystem");
                    rpts.SetDataSource(ds);
                    rpts.SetParameterValue("@ID", Convert.ToInt32(txt_num.Text));

                    frm.documentViewer1.DocumentSource = rpts;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpts.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpts.PrintToPrinter(1, true, 0, 0);




                
        

            data();
            btn_save.Enabled = true;
            Btn_Print.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_AddCustomer_Click(object sender, EventArgs e)
        {
            Frm_Customer cm = new Frm_Customer();
            cm.ShowDialog();
                        comboBox1.Properties.DataSource = o.SelectCustName();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13 && txt_barcode.Text !=string.Empty )
                {


                    dt51.Clear();
                        dt51 = p.search_barcode(Convert.ToInt64(txt_barcode.Text));
                    if (dt51.Rows.Count > 0&&Convert.ToInt32(dt51.Rows[0][4])>0)
                    {

                        for (int i = 0; i < gridView2.RowCount; i++)
                        {
                            DataRow row = gridView2.GetDataRow(i);
                            if (row[0].ToString() == dt51.Rows[0][0].ToString())
                            {
                                if (Convert.ToInt32(row[4]) >= Convert.ToInt32(dt51.Rows[0][4]))
                                {
                                    MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_barcode.Clear();
                                    txt_barcode.Focus();
                                    return;
                                }
                                else
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



                                    dt5.Clear();
                                    dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
                                    if (dt5.Rows.Count > 0)
                                    {
                                        MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    return;

                                }
                            }
                        }



            
                        
                        DataRow r = dt.NewRow();
                        r[0] = dt51.Rows[0][0];
                        r[1] = dt51.Rows[0][1];
                        r[2] = dt51.Rows[0][2];
                        r[3] = dt51.Rows[0][3];
                        r[4] = 1.00;
                        r[8] = dt51.Rows[0][5];
                        r[6] = 0;
                        dt.Rows.Add(r);
                        Console.Beep();
                        gridControl2.DataSource = dt;
                        calcalutordirect();
                        totaldirect();
                        calctotalinvoOrder();
                        pay();
                        dt5.Clear();
                        dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
                        if (dt5.Rows.Count > 0)
                        {
                            MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


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

        private void txt_pay_Click(object sender, EventArgs e)
        {
            txt_pay.SelectAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_pay_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_pay.Text=="0")
            {
                txt_pay.Text = "";
            }
        }
        void selectproudectfromcategory()
        {
            try
            {
                dt5.Clear();
                dt5 = p.Select_ProductFormCategory(Convert.ToInt32(Cmb_Category.SelectedValue));
                if (dt5.Rows.Count>0)
                {


                 Cmb_product.DataSource = p.Select_ProductFormCategory(Convert.ToInt32(Cmb_Category.SelectedValue));
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

                MessageBox.Show(ex.Message) ;
            }
        }

        private void Cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
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
        }

        private void txt_Discount_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalinvoOrder();
            TOTALFINALYDISCOUNT();
            pay();
        }

        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_Discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text=="")
            {
                txt_pay.Text = "0";
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

           

            if (e.Column.Name == "Item_Name")
            {
                Update_QtyUnit();
            }

            if (e.Column.Name == "neg")
            {

                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    dt51.Clear();
                    dt51 = p.selectListProudect(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Item)));
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

            if (e.Column.Name == "Post")
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
            if (e.Column.Name == "remove")
            {

                gridView2.DeleteSelectedRows();

                calctotalinvoOrder();
                TOTALFINALYDISCOUNT();
                pay();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_num.Text == "")
                {
                    MessageBox.Show("لابد من حفظ الفاتورة اولا");
                    return;
                }
                DataTable dt51 = new DataTable();
                if (Properties.Settings.Default.printType == "ريسيت")
                {
                    //#region MyRegion

                 
                    //Rpt_PrintOrder r = new Rpt_PrintOrder();
                    //FrmSingleReport sr = new FrmSingleReport();
                    //sr.crystalReportViewer1.RefreshReport();
                    ////r.SetDatabaseLogon("", "", ".", "FEEDStore");
                    ////r.SetParameterValue("@ID", int.Parse(dataGridViewList.CurrentRow.Cells[0].Value.ToString()));
                    ////sr.crystalReportViewer1.ReportSource = r;
                    ////sr.Show();
                    //dt51.Clear();
                    //dt51 = o.RportOrder(Convert.ToInt32(txt_num.Text));
                    //clothesStore.DAL.DataOrderReport ds = new DAL.DataOrderReport();
                    //Rpt.Frm_RptDocumetViewer frm = new Frm_RptDocumetViewer();
                    //Rpt_PrintOrder rpts = new Rpt_PrintOrder();
                    //frm.documentViewer1.Refresh();
                    //ds.Tables["PrintOrder"].Clear();

                    //for (int i = 0; i < dt51.Rows.Count; i++)
                    //{
                    //    ds.Tables["PrintOrder"].Rows.Add(dt51.Rows[i][0], dt51.Rows[i][1], dt51.Rows[i][2],
                    //    dt51.Rows[i][3], dt51.Rows[i][4], dt51.Rows[i][5]
                    //      , dt51.Rows[i][6], dt51.Rows[i][7], dt51.Rows[i][8],
                    //     dt51.Rows[i][9], dt51.Rows[i][10], dt51.Rows[i][11], dt51.Rows[i][12]
                    //     , dt51.Rows[i][13]);
                    //}
                    //SettingPrint st = new SettingPrint();
                    //DataTable tbl = new DataTable();
                    //tbl.Clear();
                    //tbl = st.SelectSettingPrintOrder();
                    //ds.Tables["PrintInformation"].Clear();
                    //ds.Tables["PrintInformation"].Rows.Add(tbl.Rows[0][0], tbl.Rows[0][1], tbl.Rows[0][2],
                    //    tbl.Rows[0][3], tbl.Rows[0][4]);


                    ////rpts.SetDatabaseLogon("", "", ".", "EasySystem");
                    //rpts.SetDataSource(ds);
                    //rpts.SetParameterValue("@ID", Convert.ToInt32(txt_num.Text));

                    //frm.documentViewer1.DocumentSource = rpts;

                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpts.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    //rpts.PrintToPrinter(1, true, 0, 0);
                    //#endregion
                    dt51.Clear();
                    dt51 = o.RportOrder(Convert.ToInt32(txt_num.Text));
                    clothesStore.DAL.DataOrderReport dss = new DAL.DataOrderReport();
                    Rpt.Frm_RptDocumetViewer frms = new Frm_RptDocumetViewer();
                    Rpt.PrintOrderRecit rpt = new PrintOrderRecit();
                    frms.documentViewer1.Refresh();
                    dss.Tables["PrintOrder"].Clear();
                    for (int i = 0; i < dt51.Rows.Count; i++)
                    {
                        dss.Tables["PrintOrder"].Rows.Add((dt51.Rows[i][0]), dt51.Rows[i][1], dt51.Rows[i][2],
                        dt51.Rows[i][3], dt51.Rows[i][4], (dt51.Rows[i][5]), (dt51.Rows[i][6])
                          , (dt51.Rows[i][7]), (dt51.Rows[i][8]), (dt51.Rows[i][9]),
                          (dt51.Rows[i][10]), dt51.Rows[i][11], (dt51.Rows[i][12]), (dt51.Rows[i][13])
                         , (dt51.Rows[i][14]), (dt51.Rows[i][15]));
                    }
                    SettingPrint sts = new SettingPrint();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt = sts.SelectSettingPrintOrder();
                    dss.Tables["PrintInformation"].Clear();
                    dss.Tables["PrintInformation"].Rows.Add(dt.Rows[0][0], dt.Rows[0][1], dt.Rows[0][2],
                        dt.Rows[0][3], dt.Rows[0][4]);
                    rpt.DataSource = dss;
                    rpt.Parameters["ID"].Value = Convert.ToInt32(txt_num.Text);
                    frms.documentViewer1.DocumentSource = rpt;
                    rpt.Parameters["ID"].Visible = false;
                    frms.documentViewer1.Enabled = true;
                    // frms.ShowDialog();
                    rpt.PrinterName = Properties.Settings.Default.PrinterName;
                    rpt.Print();
                }

                else if (Properties.Settings.Default.printType == "A4")
                {
                    dt51.Clear();
                    dt51 = o.RportOrder(Convert.ToInt32(txt_num.Text));
                    clothesStore.DAL.DataOrderReport ds = new DAL.DataOrderReport();
                    Rpt.Frm_RptDocumetViewer frm = new Frm_RptDocumetViewer();
                    Rpt.Rpt_Order rpt = new Rpt_Order();
                    frm.documentViewer1.Refresh();
                    ds.Tables["PrintOrder"].Clear();
                    for (int i = 0; i < dt51.Rows.Count; i++)
                    {
                        ds.Tables["PrintOrder"].Rows.Add((dt51.Rows[i][0]), dt51.Rows[i][1], dt51.Rows[i][2],
                        dt51.Rows[i][3], dt51.Rows[i][4], (dt51.Rows[i][5]), (dt51.Rows[i][6])
                          , (dt51.Rows[i][7]), (dt51.Rows[i][8]), (dt51.Rows[i][9]),
                          (dt51.Rows[i][10]), dt51.Rows[i][11], (dt51.Rows[i][12]), (dt51.Rows[i][13])
                         , (dt51.Rows[i][14]), (dt51.Rows[i][15]));
                    }
                    SettingPrint st = new SettingPrint();
                    DataTable tbl = new DataTable();
                    tbl.Clear();
                    tbl = st.SelectSettingPrintOrder();
                    ds.Tables["PrintInformation"].Clear();
                    ds.Tables["PrintInformation"].Rows.Add(tbl.Rows[0][0], tbl.Rows[0][1], tbl.Rows[0][2],
                        tbl.Rows[0][3], tbl.Rows[0][4]);
                    rpt.DataSource = ds;
                    rpt.Parameters["ID"].Value = Convert.ToInt32(txt_num.Text);
                    frm.documentViewer1.DocumentSource = rpt;
                    rpt.Parameters["ID"].Visible = false;
                    frm.documentViewer1.Enabled = true;
                    frm.ShowDialog();
                }
                data();
                btn_save.Enabled = true;
                Btn_Print.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}