using clothesStore.Bl;
using System;
using System.Data;
using System.Windows.Forms;
using clothesStore.Rpt;
using System.Drawing;
using System.IO;

namespace clothesStore.PL
{
    public partial class Frm_UpdatePurchasesDoors : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
      public  DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt51 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt5 = new DataTable();
        Suppliers sup = new Suppliers();

        Store Store = new Store();
        unit U = new unit();
        Proudect p = new Proudect();
        void Select_IdSupplierInnvoice()
        {
            cmb_search.Properties.DataSource = sup.ReturncompoSupplier();
            cmb_search.Properties.DisplayMember = "ID";
            cmb_search.Properties.ValueMember = "ID";
          
        }
        public Frm_UpdatePurchasesDoors()
        {
            InitializeComponent();
           // ComboSupplier();
            ComboStock();
            Select_IdSupplierInnvoice();
            //ComboProduct();
            SelectdataTable();
            comboBox1.SelectedIndex = 0;
            //Btn_Print.Enabled = false;
            //rezizse();
        }

        //void ComboSupplier()
        //{
        //    comboBox.Properties.DataSource = sup.CompoBoxSuppliers();
        //    comboBox.Properties.DisplayMember = "Name";
        //    comboBox.Properties.ValueMember = "Sup_id";
        //    comboBox.EditValue = -1;
        //}


        void ComboStock()
        {
            cmb_Stock.DataSource = s.Compo_Stock();
            cmb_Stock.DisplayMember = "Treasury_name";
            cmb_Stock.ValueMember = "id_Treasury";
        }
        //void ComboProduct()
        //{
        //    Cmb_product.DataSource = p.Select_ProductFormStoreForSale();
        //    Cmb_product.DisplayMember = "Name_Prod";
        //    Cmb_product.ValueMember = "ID_Prod";
        //    Cmb_product.SelectedIndex = -1;
        //}
        void sumTotalPay()
        {
            try
            {
                if (comboBox1.Text == "مدفوع للمورد")
                {
                    if (txt_NewPay.Text != "")
                    {
                        decimal x = Convert.ToDecimal(txt_NewPay.Text) + Convert.ToDecimal(txt_pay.Text);
                        Txt_TotalPay.Text = x.ToString();

                    }

                    else
                    {
                        decimal y = 0;
                        decimal x = Convert.ToDecimal(y) + Convert.ToDecimal(txt_pay.Text);
                        Txt_TotalPay.Text = x.ToString();
                    }

                }
                if (comboBox1.Text == "مدفوع من المورد")
                {
                    if (txt_NewPay.Text != "")
                    {
                        decimal x = Convert.ToDecimal(txt_pay.Text) - Convert.ToDecimal(txt_NewPay.Text);
                        Txt_TotalPay.Text = x.ToString();
                    }
                    else
                    {
                     //   decimal y = 0;
                        decimal x = Convert.ToDecimal(txt_pay.Text);
                        Txt_TotalPay.Text = x.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
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
                decimal total = amount - discount;
                row[7] = amount.ToString();
            }
        }
        public void pay()
        {          
                if (txt_AfterDisc.Text != string.Empty)
                {
                    decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - Convert.ToDecimal(Txt_TotalPay.Text);
                    txt_mark.Text = Math.Round(totainv, 1).ToString();
                }
                else if (txt_AfterDisc.Text == string.Empty)
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
            dt.Columns.Add("رقم الباركود");//8
            dt.Columns.Add("سعر البيع");//9
            gridControl2.DataSource = dt;
        }



        //كود الاضافة
        public void DataRow()
        {
          try
          {

            int quantity = 1;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                if (tileViewItem.GetFocusedRowCellValue("ID_Prod").ToString() == row[0].ToString())
                {
                    //MessageBox.Show("هذا الصنف متسجل حاليا");
                    //return;
                        decimal x = 1;
                        row[4] = Convert.ToDecimal(row[4]) + x;
                        Console.Beep();
                        calcalutordirect();
                        totaldirect();
                        calctotalinvoOrder();
                        TOTALFINALYDISCOUNT();
                        sumTotalPay();
                        pay();
                        //dt5.Clear();
                        //dt5 = p.SelectQuantityMinmun(Convert.ToInt32(btn2.Tag));
                        //if (dt5.Rows.Count > 0)
                        //{
                        //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}

                        return;
                }
            }
            //dt51 = p.selectListProudect(Convert.ToInt32(btn2.Tag));
            //if (dt51.Rows.Count == 0)
            //{
            //    MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            DataRow r = dt.NewRow();
            //r[0] = btn.Tag;
            //r[1] = btn.Text;

            r[0] = tileViewItem.GetFocusedRowCellValue("ID_Prod");  
                
            r[1] = tileViewItem.GetFocusedRowCellValue("Name_Prod");
                
            r[2] = tileViewcategory.GetFocusedRowCellValue("Category_Id");

            r[3] = tileViewItem.GetFocusedRowCellValue("Buy_Price");

            r[4] = quantity;

            r[6] = 0;

            dt.Rows.Add(r);
            Console.Beep();
            gridControl2.DataSource = dt;


            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            calcalutordirect();
            totaldirect();
            calctotalinvoOrder();
            TOTALFINALYDISCOUNT();
            sumTotalPay();
            pay();
            //dt5.Clear();
            //dt5 = p.SelectQuantityMinmun(Convert.ToInt32(btn2.Tag));
            //if (dt5.Rows.Count > 0)
            //{
            //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //lblItemsCount.Text = DgvSale.Rows.Count.ToString();
            txt_barcode.Focus();
        }
        catch (Exception ex)
        {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
        }

        }
          




    // كود الاصناف

    public void items()
        {
            try
            {
                //DataTable dtpr = new DataTable();
                //flowLayoutPanel2.Controls.Clear();
                //Button btn = sender as Button;
                //dtpr.Clear();
                gridItem.DataSource = p.Select_ProductForButtonSupplier(Convert.ToInt32(tileViewcategory.GetFocusedRowCellValue("Category_Id")));

                //// btn2.BackgroundImageLayout = ImageLayout.Stretch;
                ////  btn2.Size = btn2.BackgroundImage.Size;
                //for (int i = 0; i < dtpr.Rows.Count; i++)
                //{
                //    Button btn2 = new Button();

                //    byte[] image = (byte[])dtpr.Rows[i][2];
                //    MemoryStream f = new MemoryStream(image);

                //    btn2.Image = Image.FromStream(f);

                //    btn2.Image = (Image)(new Bitmap(Image.FromStream(f), new Size(162, 110)));
                //    btn2.ImageAlign = ContentAlignment.MiddleCenter;
                //    btn2.TextImageRelation = TextImageRelation.ImageAboveText;
                //    // btn2.TextAlign = ContentAlignment.BottomCenter;

                //    btn2.Name = "btn" + dtpr.Rows[i][0];
                //    btn2.Tag = dtpr.Rows[i][0];
                //    btn2.Text = dtpr.Rows[i][1].ToString();
                //    btn2.Font = new Font("AL-Mateen", 15f, FontStyle.Bold);
                //    btn2.UseCompatibleTextRendering = true;
                //    btn2.BackColor = Color.Yellow;
                //    btn2.ForeColor = Color.Black;
                //    btn2.Height = 150;
                //    btn2.Width = 190;

                //    btn2.Click += DataRow;

                //    flowLayoutPanel2.Controls.Add(btn2);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        // كود الفئات
        public void ButtonSelectCategory()
        {
            //flowLayoutPanel1.Controls.Clear();
            //DataTable dt1 = new DataTable();

            Category c = new Category();
            //dt1.Clear();
            gridCategory.DataSource = c.Select_ComboCategory();

            //for (int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    Button btn = new Button();


            //    btn.Name = "btn" + dt1.Rows[i][0];
            //    btn.Tag = dt1.Rows[i][0];
            //    btn.Text = dt1.Rows[i][1].ToString();
            //    btn.Font = new Font("AL-Mateen", 16f, FontStyle.Bold);
            //    btn.UseCompatibleTextRendering = true;
            //    btn.ForeColor = Color.Black;
            //    btn.BackColor = Color.Yellow;
            //    btn.Height = 65;
            //    btn.Width = 140;
            //    btn.Click += items;
            //    flowLayoutPanel1.Controls.Add(btn);
            //}
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
            txt_NewPay.Text = "0";
            Txt_TotalPay.Text = "0";
            txt_num.Clear();
            Txt_supName.Clear();

            //txt_barcode.Enabled = true;
            btn_save.Enabled = false;
            //Btn_Print.Enabled = false;
            //Btn_selectProduct.Enabled = true;
            btn_new.Enabled = true;
            //Cmb_product.SelectedIndex = -1;
            //comboBox1.SelectedIndex = -1;
            //lblItemsCount.Text = DgvSale.Rows.Count.ToString();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dt51.Clear();
            //    dt51 = p.selectListProudect( Convert.ToInt32(Cmb_product.SelectedValue));
            //    if (Cmb_product.Text != "" && dt51.Rows.Count > 0)
            //    {

            //        for (int i = 0; i < DgvSale.Rows.Count; i++)
            //        {
            //            DataRow row = gridView2.GetDataRow(i);

            //            if (DgvSale.Rows[i].Cells[0].Value.ToString() == dt51.Rows[0][0].ToString())
            //            {
            //                //dt6.Clear();
            //                //dt6 = p.Select_NumberSmallInLargeUnit(Convert.ToInt32(DgvSale.Rows[i].Cells[0].Value), Convert.ToString(DgvSale.Rows[i].Cells[3].Value));

            //                decimal y = Convert.ToDecimal(row[4]) ;

            //                if (y >= Convert.ToDecimal(dt51.Rows[0][4]))
            //                {
            //                    MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    return;
            //                }
            //                else
            //                {

            //                    decimal x = 1;
            //                    row[4] = Convert.ToDecimal(DgvSale.Rows[i].Cells[4].Value) + x;

            //                    calcalutordirect();
            //                    totaldirect();
            //                    calctotalinvoOrder();
            //                    pay();
            //                    dt5.Clear();
            //                    dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
            //                    if (dt5.Rows.Count > 0)
            //                    {
            //                        MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    }
            //                    Cmb_product.SelectedIndex = -1;

            //                    return;
            //                }
            //            }

            //        }
            //        //if (dt51.Rows.Count>0)
            //        //{
            //        DataRow r = dt.NewRow();
            //        r[0] = dt51.Rows[0][0];
            //        r[1] = dt51.Rows[0][1];
            //        r[2] = dt51.Rows[0][2];
            //        r[3] = dt51.Rows[0][3];
            //        r[4] = 1.00;
            //        r[6] = 0;
            //        dt.Rows.Add(r);
            //        Console.Beep();
            //        DgvSale.DataSource = dt;
            //        calcalutordirect();
            //        totaldirect();
            //        calctotalinvoOrder();
            //        pay();
            //        dt5.Clear();
            //        dt5 = p.SelectQuantityMinmun(Convert.ToInt32(dt51.Rows[0][0]));
            //        if (dt5.Rows.Count > 0)
            //        {
            //            MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }

            //        //lblItemsCount.Text = DgvSale.Rows.Count.ToString();
            //        txt_barcode.Focus();
            //    }
            //    else
            //    {
            //        MessageBox.Show("هذا الصنف غير مسجل فى قائمة الاصناف");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //}
        }

        private void Frm_Sales_Load(object sender, EventArgs e)
        {
            //label6.Hide();
            //txt_barcode.Hide();
            ButtonSelectCategory();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

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
            //try
            //{
            //    if (Cmb_product.Text != "")
            //    {
            //        dt2.Clear();
            //        dt2 = p.Validate_ProductFormStoreForSale(Convert.ToInt32(Cmb_product.SelectedValue));
            //        if (dt2.Rows.Count == 0)
            //        {
            //            MessageBox.Show("اسم الصنف الذى قمت باادخالة غير موجود فى قائمة الاصناف ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //            Cmb_product.SelectAll();
            //            Cmb_product.Focus();
            //            return;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //}

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
        DataTable dt4 = new DataTable();

        private void simpleButton3_Click(object sender, EventArgs e)
        {

           
            try
            {
                if (gridView2.RowCount <= 0) { MessageBox.Show("لا بد من اختيار صنف واحد على الاقل "); return; }
                if (Convert.ToDecimal(txt_NewPay.Text) > 0)
                {
                    if (comboBox1.Text == "مدفوع للمورد")
                    {
                        if (cmb_Stock.Text == "") { MessageBox.Show("لابد من اختيار الخزنة "); return; }
                    }
                }
                //if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(txt_invo.Text))
                //{
                //    MessageBox.Show("لابد أن يكون المدفوع اقل من اجمالى الفاتورة ");
                //    txt_pay.Focus();
                //    return;
                //}
                if (txt_num.Text == "" || txt_IdSupplier.Text=="" )
                {
                    MessageBox.Show("لا بد من اختيار فاتورة اولا للتعديل او التحقق من الفاتورة المختاره", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                   
                
                btn_save.Enabled = false;

                dt7.Clear();
                dt7= sup.Validate_IdSupplierinnoice(Convert.ToInt32(txt_num.Text));
                if (dt.Rows.Count == 0)
                {
                    Console.Beep();
                    MessageBox.Show("لا توجد فاتورة بهذا الرقم");
                    return;
                }
                dt7.Clear();
                dt7 = sup.SelectSuppliersRteurn(Convert.ToInt32(txt_num.Text));
                dt2.Clear();
                dt2 = sup.SelectProudectRteurn(Convert.ToInt32(txt_num.Text));
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    DataTable data5 = new DataTable();
                    data5.Clear();
                    data5 = sup.SelectQuantityOFProductFromSuppliersReturn(Convert.ToInt32(txt_num.Text), 
                        Convert.ToInt32(dt2.Rows[i][1]));
                    if (data5.Rows.Count > 0)
                    {

                        decimal qtyReturn = Convert.ToDecimal(data5.Rows[0][4]);
                        decimal TotalQty = Convert.ToDecimal(dt2.Rows[i][4]) + qtyReturn;

                        sup.AddRemovePurshasesInProudect(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dt2.Rows[i][1]),
                            TotalQty, "فاتورة مشتريات رقم " + " " + txt_num.Text);

                    }
                    else
                    {

                        sup.AddRemovePurshasesInProudect(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dt2.Rows[i][1]),
                            Convert.ToDecimal(dt2.Rows[i][4]), "فاتورة مشتريات رقم " + " " + txt_num.Text);
                    }


                }
                sup.UpdateSuppliersINformation(Convert.ToInt32(txt_num.Text),txt_note.Text,Convert.ToDecimal(txt_invo.Text)
                   , Convert.ToDecimal(Txt_TotalPay.Text), Convert.ToDecimal(txt_mark.Text), Convert.ToDecimal(txt_Discount.Text),
                   Convert.ToDecimal(txt_AfterDisc.Text),DateTime.Now,Program.salesman);



                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    sup.addSuppliersDetails(Convert.ToInt32(txt_num.Text),
                   Convert.ToInt32(row[0]), Convert.ToDecimal(row[4])
                  , Convert.ToDecimal(row[3]), Convert.ToDecimal(row[5]),
                   Convert.ToDecimal(row[6]), Convert.ToDecimal(row[7]),
                   row[1].ToString());

                    p.Add_MoveProduct(Convert.ToInt32(row[0]), Convert.ToDecimal(row[4]), Convert.ToDecimal(row[3]), 0,
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

                // كشف حساب العميل بعد ان اصبح إجمالى الفاتورة بعد الخصم اكبر من إجمالى الفاتورة القديم
                if (Convert.ToDecimal(txt_AfterDisc.Text) > Convert.ToDecimal(dt7.Rows[0][8]))
                {


                    dt6.Clear();
                    dt6 = sup.select_SupplierBalance(Convert.ToInt32(txt_IdSupplier.Text));
                    decimal mno = Convert.ToDecimal(txt_AfterDisc.Text) - Convert.ToDecimal(dt7.Rows[0][8]);
                    decimal mno1 = Convert.ToDecimal(dt6.Rows[0][1]) + mno;
                    sup.Update_SupplierTotalMoney(Convert.ToInt32(txt_IdSupplier.Text), mno1);
                    sup.Add_SuppliersStatementAccount(Convert.ToInt32(txt_IdSupplier.Text), mno,
                        0, "تعديل فاتورة مشتريات رقم " + " " + txt_num.Text,
                        dateTimePicker1.Value, mno1);


                }

                // كشف حساب العميل بعد ان اصبح إجمالى الفاتورة القديم أكبر من أجمالى الفاتورة الجديد
                if (Convert.ToDecimal(dt7.Rows[0][8]) > Convert.ToDecimal(txt_AfterDisc.Text))
                {
                    dt6.Clear();
                    dt6 = sup.select_SupplierBalance(Convert.ToInt32(txt_IdSupplier.Text));
                    decimal mno = Convert.ToDecimal(dt7.Rows[0][8]) - Convert.ToDecimal(txt_AfterDisc.Text);
                    decimal mno1 = Convert.ToDecimal(dt6.Rows[0][1]) - mno;
                    sup.Update_SupplierTotalMoney(Convert.ToInt32(txt_IdSupplier.Text), mno1);
                    sup.Add_SuppliersStatementAccount(Convert.ToInt32(txt_IdSupplier.Text), 0,
                        mno, "تعديل فاتورة مشتريات رقم " + " " + txt_num.Text,
                        dateTimePicker1.Value, mno1);
                }



                if (Convert.ToDecimal(txt_NewPay.Text) > 0)
                {


                    if (comboBox1.Text == "مدفوع للمورد")
                    {
                        //dt4.Clear();
                        //dt4 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));

                        //if (dt4.Rows.Count > 0)
                        //{
                        //    if (Convert.ToDecimal(txt_NewPay.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                        //    {
                        //        MessageBox.Show("رصيد الخزنة الحالى غير كافى للدفع للمورد");
                        //        return;
                        //    }
                        //}
                        //else
                        //{
                            s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_NewPay.Text),
                            dateTimePicker1.Value, Program.salesman, "رصيد مسحوب من الخزنة",
                            "مبلغ مدفوع للمورد بعد التعديل على الفاتورة" + txt_num.Text);

                            s.InsertStockMove(Convert.ToDecimal(txt_NewPay.Text) * -1, dateTimePicker1.Value, "فاتورة مشتريات  ",
                               "مبلغ مدفوع للمورد مقابل تعديل فاتورة مشتريات رقم " + " " + txt_num.Text,
                                Convert.ToInt32(cmb_Stock.SelectedValue), Program.salesman, "خروج من الخزينة",
                                Convert.ToInt32(txt_num.Text));



                            dt6.Clear();
                            dt6 = sup.select_SupplierBalance(Convert.ToInt32(txt_IdSupplier.Text));
                            decimal mno = Convert.ToDecimal(txt_NewPay.Text);
                            decimal mno1 = Convert.ToDecimal(dt6.Rows[0][1]) - mno;
                            sup.Update_SupplierTotalMoney(Convert.ToInt32(txt_IdSupplier.Text), mno1);
                            sup.Add_SuppliersStatementAccount(Convert.ToInt32(txt_IdSupplier.Text), 0,
                                mno, "مبلغ مدفوع للمورد مقابل تعديل فاتورة مشتريات رقم " + " " + txt_num.Text,
                                dateTimePicker1.Value, mno1);

                       // }
                    }
                    else if (comboBox1.Text == "مدفوع من المورد")
                    {
                        s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_NewPay.Text),
                      dateTimePicker1.Value, Program.salesman, "تعديل فاتورة مشتريات رقم" + txt_num.Text,
                      "مبلغ مدفوع من المورد مقابل تعديل فاتورة مشتريات إلى" + " " + Txt_supName.Text);

                        s.InsertStockMove(Convert.ToDecimal(txt_NewPay.Text), DateTime.Now, "فاتورة مشتريات  ",
                           "مبلغ مدفوع للمورد مقابل تعديل فاتورة مبيعات رقم " + " " + txt_num.Text,
                           Convert.ToInt32(cmb_Stock.SelectedValue)
                            , Program.salesman, "دخول الي الخزينة", Convert.ToInt32(txt_num.Text));



                        dt6.Clear();
                        dt6 = sup.select_SupplierBalance(Convert.ToInt32(txt_IdSupplier.Text));
                        decimal mno = Convert.ToDecimal(txt_NewPay.Text);
                        decimal mno1 = Convert.ToDecimal(dt6.Rows[0][1]) + mno;
                        sup.Update_SupplierTotalMoney(Convert.ToInt32(txt_IdSupplier.Text), mno1);
                        sup.Add_SuppliersStatementAccount(Convert.ToInt32(txt_IdSupplier.Text), mno,
                            0, "مبلغ مدفوع من المورد مقابل تعديل فاتورة مشتريات رقم " + " " + txt_num.Text,
                            dateTimePicker1.Value, mno1);
                    }
                }

                MessageBox.Show(" تم تعديل الفاتوره بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                data();
                btn_save.Enabled = true;
                
                
                Form_suppliermanagement.getmain.gridControl1.DataSource = sup.suppliermanagement();


                this.Close();

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
            sumTotalPay();
            pay();
        }

        private void txt_mark_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void DgvSale_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calctotalinvoOrder();
            sumTotalPay();
            pay();
            //lblItemsCount.Text = DgvSale.Rows.Count.ToString();

        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {
            if (txt_pay.Text == ".")
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


                Frm_EditQuantitySupplier Frm = new Frm_EditQuantitySupplier();

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
                    gridView2.SetFocusedRowCellValue(Price, (Convert.ToDecimal(Frm.txt_prise.Text)-Convert.ToDecimal(Frm.Txt_DisCount.Text)));
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


                    DataTable dt3 = new DataTable();
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

            //كزد الحفظ

            if (btn_save.Enabled == true)
            {
                if (e.KeyCode == Keys.F5)
                {
                    simpleButton3_Click(null, null);
                }
            }


            //---------------------------------------------------------------------------
            //if (Btn_Print.Enabled==true)
            //{
            //     if (e.KeyCode == Keys.F2)   /// كود الطباعة
            //    {
            //        Btn_Print_Click(null, null);
            //    }
            //}


            //---------------------------------------------------------------------
            //كود جديد

            else if (e.KeyCode == Keys.F1)
            {
                btn_new_Click(null, null);
            }

            //------------------------------------------------------------------

            //كود فتح شاشة تغير الكمية والسعر والخصم
            else if (e.KeyCode == Keys.F11)
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
            //ComboProduct();
            dt.Clear();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            data();
            btn_save.Enabled = true;
            //Btn_Print.Enabled = false;
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
            //ComboProduct();
        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_pay_Click(object sender, EventArgs e)
        {
            txt_pay.SelectAll();
        }

        private void txt_pay_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_pay.Text == "0")
            {
                txt_pay.Text = "";
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

        private void txt_Discount_KeyUp(object sender, KeyEventArgs e)
        {
            calctotalinvoOrder();
            TOTALFINALYDISCOUNT();
            pay();
        }

        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text == "")
            {
                txt_pay.Text = "0";
            }
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
        private void tileViewcategory_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            items();
        }

        private void tileViewItem_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            DataRow();
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            if (txt_Discount.Text=="")
            {
                txt_Discount.Text = "0";
            }
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            try
            {

                dt7.Clear();
                dt7 = sup.Validate_IdSupplierinnoice(Convert.ToInt32(cmb_search.EditValue));
                if (dt7.Rows.Count == 0)
                {
                    Console.Beep();
                    MessageBox.Show("لا توجد فاتورة بهذا الرقم");
                    return;
                }
                dt7.Clear();
                dt7 = sup.SelectSuppliersRteurn(Convert.ToInt32(cmb_search.EditValue));
          
                dt = sup.SelectProductForUpdate(Convert.ToInt32(cmb_search.EditValue));
                foreach (DataRow dr in dt7.Rows)
                {
                    txt_num.Text = dr["ID"].ToString();
                    Txt_supName.Text = dr["Name"].ToString();
                    txt_IdSupplier.Text= dr["sup_id"].ToString();
                    txt_Discount.Text = dr["totalDiscount"].ToString();
                    txt_invo.Text = dr["Total_Invoic"].ToString();
                    txt_AfterDisc.Text = dr["totalAfterDicscount"].ToString();
                    txt_pay.Text = dr["pay"].ToString();
                    txt_mark.Text = dr["rent"].ToString();
                    Txt_TotalPay.Text = txt_pay.Text;


                }
                gridControl2.DataSource = dt;
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void txt_NewPay_TextChanged(object sender, EventArgs e)
        {
            if (txt_NewPay.Text == ".")
            {
                txt_NewPay.Text = "0.";
            }
        }

        private void txt_NewPay_Leave(object sender, EventArgs e)
        {
            if (txt_NewPay.Text == "")
            {
                txt_NewPay.Text = "0.0";
            }
        }

        private void txt_NewPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_NewPay.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_NewPay_KeyUp(object sender, KeyEventArgs e)
        {
            sumTotalPay();
            pay();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sumTotalPay();
            pay();
        }

        private void Txt_TotalPay_KeyUp(object sender, KeyEventArgs e)
        {
            sumTotalPay();
            pay();
        }

        private void cmb_search_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
