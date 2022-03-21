using clothesStore.Bl;
using System;
using System.Data;
using System.Windows.Forms;
using clothesStore.Rpt;
using System.Drawing;
using System.IO;
using DevExpress.XtraEditors;
using System.Runtime.Remoting.Messaging;

namespace clothesStore.PL
{
    public partial class Frm_UpdateSales : DevExpress.XtraEditors.XtraForm
    {
        Frm_Customer c = new Frm_Customer();
        Customer Cm = new Customer();
        Order o = new Order();
        Stock s = new Stock();
      public  DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt51 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt5 = new DataTable();

        Store Store = new Store();
        unit U = new unit();
        Proudect p = new Proudect();
        public Frm_UpdateSales()
        {
            InitializeComponent();
            ComboStock();
            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel2.Enabled = false;
            //ComboProduct();
            SelectdataTable();
            Btn_Print.Enabled = false;
            //rezizse();

        }
        //void ComboCustomer()
        //{
        //    txt_name.Properties.DataSource = o.SelectCustName();
        //    txt_name.Properties.DisplayMember = "Name";
        //    txt_name.Properties.ValueMember = "ID_Cust";
        //    // comboBox1.Properties.SelectedIndex = -1;
           
        //}
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
        //void ComboProduct()
        //{
        //    Cmb_product.DataSource = p.Select_ProductFormStoreForSale();
        //    Cmb_product.DisplayMember = "Name_Prod";
        //    Cmb_product.ValueMember = "ID_Prod";
        //    Cmb_product.SelectedIndex = -1;
        //}

        void totalRentFromTotalPay()
        {
            decimal x = Convert.ToDecimal(txt_invo.Text)-Convert.ToDecimal(txt_TotalPay.Text);
            decimal y= Convert.ToDecimal(x) - Convert.ToDecimal(txt_mark.Text);
            txt_mark.Text = y.ToString();
        }
        void sumTotalPay()
        {
            try
            {
                if (comboBox1.Text == "مدفوع من العميل")
                {
                    if (txt_NewPay.Text != "")
                    {
                        decimal x = Convert.ToDecimal(txt_NewPay.Text) + Convert.ToDecimal(txt_pay.Text);
                        txt_TotalPay.Text = x.ToString();

                    }

                    else
                    {
                        decimal y = 0;
                        decimal x = Convert.ToDecimal(y) + Convert.ToDecimal(txt_pay.Text);
                        txt_TotalPay.Text = x.ToString();
                    }

                }
                if (comboBox1.Text == "مدفوع للعميل")
                {
                    if (txt_NewPay.Text != "")
                    {
                        decimal x = Convert.ToDecimal(txt_pay.Text) - Convert.ToDecimal(txt_NewPay.Text);
                        txt_TotalPay.Text = x.ToString();

                    }

                    else
                    {
                        decimal y = 0;
                        decimal x = Convert.ToDecimal(txt_pay.Text);
                        txt_TotalPay.Text = x.ToString();
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
                decimal total = amount ;
                row[7] = total.ToString();
            }
        }
        public void pay()
        {
            if (comboBox1.Text=="مدفوع من العميل")
            {
                if (txt_AfterDisc.Text != string.Empty)
                {
                    decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - Convert.ToDecimal(txt_TotalPay.Text);
                    txt_mark.Text = Math.Round(totainv, 1).ToString();
                }
                else if (txt_TotalPay.Text == string.Empty)
                {
                    decimal x = 0;
                    decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - x;
                    txt_mark.Text = Math.Round(totainv, 1).ToString();
                }
            }
            else if(comboBox1.Text== "مدفوع للعميل")
            {
                if (txt_AfterDisc.Text != string.Empty)
                {
                    decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - Convert.ToDecimal(txt_TotalPay.Text);
                    txt_mark.Text = Math.Round(totainv, 1).ToString();
                }
                else if (txt_TotalPay.Text == string.Empty)
                {
                    decimal x = 0;
                    decimal totainv = Convert.ToDecimal(txt_AfterDisc.Text) - x;
                    txt_mark.Text = Math.Round(totainv, 1).ToString();
                }
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
            gridControl2.DataSource = dt;
        }



        //كود الاضافة
       
    public void DataRow(object sender, EventArgs e)
        {

            try
            {

           

            Button btn = sender as Button;
            Button btn2 = sender as Button;
            dt51 = p.selectListProudect(Convert.ToInt32(btn2.Tag));
            if (dt51.Rows.Count == 0)
            {
                MessageBox.Show(" الكميه المدخله لهذا الصنف غير متاحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity = 1;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                if (btn2.Tag.ToString() == row[0].ToString())
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
                            //dt5.Clear();
                            //dt5 = p.SelectQuantityMinmun(Convert.ToInt32(btn2.Tag));
                            //if (dt5.Rows.Count > 0)
                            //{
                            //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //}


                            return;
                        }


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
            r[0] = btn2.Tag;
            r[1] = btn2.Text;

            r[2] = btn.Tag;
            r[3] = p.selectListProudect(Convert.ToInt32(btn2.Tag)).Rows[0][3];
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
            pay();
                //dt5.Clear();
                //dt5 = p.SelectQuantityMinmun(Convert.ToInt32(btn2.Tag));
                //if (dt5.Rows.Count > 0)
                //{
                //    MessageBox.Show("عزيزيى المستخدم يرجي العلم بان هذا الصنف وصل للحد الادني", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                //lblItemsCount.Text = DgvSale.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }




        // كود الاصناف

        public void items(object sender, EventArgs E)
        {
            try
            {
                DataTable dtpr = new DataTable();
                flowLayoutPanel2.Controls.Clear();
                Button btn = sender as Button;
                dtpr.Clear();
                dtpr = p.Select_ProductForButton(Convert.ToInt32(btn.Tag));

                // btn2.BackgroundImageLayout = ImageLayout.Stretch;
                //  btn2.Size = btn2.BackgroundImage.Size;
                for (int i = 0; i < dtpr.Rows.Count; i++)
                {
                    Button btn2 = new Button();

                    byte[] image = (byte[])dtpr.Rows[i][2];
                    MemoryStream f = new MemoryStream(image);

                    btn2.Image = Image.FromStream(f);

                    btn2.Image = (Image)(new Bitmap(Image.FromStream(f), new Size(162, 110)));
                    btn2.ImageAlign = ContentAlignment.MiddleCenter;
                    btn2.TextImageRelation = TextImageRelation.ImageAboveText;
                    // btn2.TextAlign = ContentAlignment.BottomCenter;

                    btn2.Name = "btn" + dtpr.Rows[i][0];
                    btn2.Tag = dtpr.Rows[i][0];
                    btn2.Text = dtpr.Rows[i][1].ToString();
                    btn2.Font = new Font("AL-Mateen", 15f, FontStyle.Bold);
                    btn2.UseCompatibleTextRendering = true;
                    btn2.BackColor = Color.Yellow;
                    btn2.ForeColor = Color.Black;
                    btn2.Height = 150;
                    btn2.Width = 190;
                  
                    btn2.Click += DataRow;
                  
                    flowLayoutPanel2.Controls.Add(btn2);
                }
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
            flowLayoutPanel1.Controls.Clear();
            DataTable dt1 = new DataTable();

            Category c = new Category();
            dt1.Clear();
            dt1 = c.Select_ComboCategory();

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Button btn = new Button();


                btn.Name = "btn" + dt1.Rows[i][0];
                btn.Tag = dt1.Rows[i][0];
                btn.Text = dt1.Rows[i][1].ToString();
                btn.Font = new Font("AL-Mateen", 16f, FontStyle.Bold);
                btn.UseCompatibleTextRendering = true;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.Yellow;
                btn.Height = 65;
                btn.Width = 140;
                btn.Click += items;
                flowLayoutPanel1.Controls.Add(btn);
            }
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
            txt_Service.Text = "0";
            txt_Na2l.Text = "0";
            dt.Clear();
            txt_note.Clear();
            txt_pay.Text = "0";
            txt_mark.Text = "0";
            txt_invo.Text = "0";
            txt_num.Clear();
            //txt_barcode.Enabled = true;
            btn_save.Enabled = false;
            Btn_Print.Enabled = false;
    
            //Btn_selectProduct.Enabled = true;
      
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
            comboBox1.SelectedIndex = 0;
            cmb_search.Properties.DataSource = o.SelectOrderManagment();
            cmb_search.Properties.DisplayMember = "رقم الفاتوره";
            cmb_search.Properties.ValueMember = "رقم الفاتوره";
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                Masrofat m = new Masrofat();
                DataTable dt4 = new DataTable();
                Stock st = new Stock();
                if (gridView2.RowCount <= 0) { MessageBox.Show("لا بد من اختيار صنف واحد على الاقل "); return; }
                if (txt_name.Text == "") { MessageBox.Show("لابد من اختيار إسم العميل "); return; }
                if (cmb_Stock.Text == "") { MessageBox.Show("لابد من اختيار الخزنة "); return; }
                //if (Convert.ToDecimal(txt_pay.Text) > Convert.ToDecimal(txt_invo.Text))
                //{
                //    MessageBox.Show("لابد أن يكون المدفوع اقل من اجمالى الفاتورة ");
                //    txt_pay.Focus();
                //    return;
                //}




                decimal MoneySotck = 0;

               

                if (gridView2.RowCount > 0 && txt_name.Text != string.Empty && cmb_Stock.Text != string.Empty)
                {

                    dt5.Clear();
                    dt5 = o.SelectOrderReturn(Convert.ToInt32(txt_num.Text));


                    dt2.Clear();
                    dt2 = o.SelectProdRuturnOrder(Convert.ToInt32(txt_num.Text));
    
                    //delete product from orderDetails and increase Quantity To Product in Store And Delete From Move Product
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        dt51.Clear();
                        dt51 = o.SelectQuantityOFProductFromOrderReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dt2.Rows[i][1]));
                        if (dt51.Rows.Count > 0)
                        {
                            decimal qtyReturn = Convert.ToDecimal(dt51.Rows[0][4]);
                            decimal TotalQty = Convert.ToDecimal(dt2.Rows[i][4]) - qtyReturn;
                            o.AddRemoveInProudect(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dt2.Rows[i][1]),
                               TotalQty, "مبيعات رقم " + " " + txt_num.Text);
                        }
                        else
                        {

                            o.AddRemoveInProudect(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dt2.Rows[i][1]),
                               Convert.ToDecimal(dt2.Rows[i][4]), "مبيعات رقم " + " " + txt_num.Text);
                        }
                    }

                    
                    // add new product after  update order 

                    o.updateOrder(Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_TotalPay.Text), Convert.ToDecimal(txt_mark.Text)
                   , Convert.ToDecimal(txt_Service.Text), Convert.ToDecimal(txt_Na2l.Text),
                   Convert.ToDecimal(txt_AfterDisc.Text), Convert.ToDecimal(txt_Discount.Text), Convert.ToInt32(txt_num.Text),
                   txt_note.Text,Program.salesman,DateTime.Now);
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        o.AddOrderDetails(Convert.ToInt32(txt_num.Text), Convert.ToInt32(row[0]),
                        (row[1].ToString()), Convert.ToDecimal(row[4]),
                        Convert.ToDecimal(row[3]), Convert.ToDecimal(row[6]),
                        Convert.ToDecimal(row[5]), Convert.ToDecimal(row[7]));

                            dt51.Clear();
                            dt51 = o.SelectQuantityOFProductFromOrderReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(row[0]));
                            if (dt51.Rows.Count > 0)
                            {
                                decimal qtyReturn = Convert.ToDecimal(dt51.Rows[0][4]);
                                decimal TotalQty = Convert.ToDecimal(row[4]) - qtyReturn;
                                p.Update_ProductQuantityDecrease(Convert.ToInt32(row[0]), TotalQty);

                            }
                            else
                            {

                                p.Update_ProductQuantityDecrease(Convert.ToInt32(row[0])
                                   , Convert.ToDecimal(row[4]));

                            }
                        
                      
                        p.Add_MoveProduct(Convert.ToInt32(row[0]), 0, 0, Convert.ToInt32(row[4]),
                       Convert.ToDecimal(row[3]), 0, 0, 0, "تعديل مبيعات رقم " + " " + txt_num.Text, dateTimePicker1.Value,
                       Program.salesman, "خروج");
                    }


                    // كشف حساب العميل بعد ان اصبح إجمالى الفاتورة بعد الخصم اكبر من إجمالى الفاتورة القديم
                    if (Convert.ToDecimal(txt_AfterDisc.Text) > Convert.ToDecimal(dt5.Rows[0][13]))
                    {
                        dt51.Clear();
                        dt51 = Cm.Select_CustomerBalance(Convert.ToInt32(id_cust.Text));

                        decimal mno = Convert.ToDecimal(txt_AfterDisc.Text) - Convert.ToDecimal(dt5.Rows[0][13]);
                        decimal mno1 = Convert.ToDecimal(dt51.Rows[0][1]) + mno;
                        Cm.Update_CustomerTotalMoney(Convert.ToInt32(id_cust.Text), mno1);
                        Cm.Add_CustomerStatmentAccount(Convert.ToInt32(id_cust.Text), 0,
                        mno, "تعديل فاتورة مبيعات رقم " + " " + txt_num.Text, dateTimePicker1.Value,
                        mno1, Program.salesman);
                    }

                    // كشف حساب العميل بعد ان اصبح إجمالى الفاتورة القديم أكبر من أجمالى الفاتورة الجديد
                    if (Convert.ToDecimal(dt5.Rows[0][13]) > Convert.ToDecimal(txt_AfterDisc.Text))
                    {
                        dt51.Clear();
                        dt51 = Cm.Select_CustomerBalance(Convert.ToInt32(id_cust.Text));

                        decimal mno = Convert.ToDecimal(dt5.Rows[0][13]) - Convert.ToDecimal(txt_AfterDisc.Text);
                        decimal mno1 = Convert.ToDecimal(dt51.Rows[0][1]) - mno;
                        Cm.Update_CustomerTotalMoney(Convert.ToInt32(id_cust.Text), mno1);
                        Cm.Add_CustomerStatmentAccount(Convert.ToInt32(id_cust.Text), mno,
                        0, "تعديل فاتورة مبيعات رقم " + " " + txt_num.Text, dateTimePicker1.Value,
                        mno1, Program.salesman);
                    }

                    if (Convert.ToDecimal(txt_NewPay.Text) > 0)
                    {


                        if (comboBox1.Text == "مدفوع للعميل")
                        {
                            dt4 = st.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                            if (Convert.ToDecimal(dt4.Rows[0][0]) > 0)
                            {
                                MoneySotck = Convert.ToDecimal(dt4.Rows[0][0]);
                            }

                            if (Convert.ToDecimal(txt_NewPay.Text) > Convert.ToDecimal(MoneySotck))
                            {
                                MessageBox.Show("رصيد الخزنة الحالى غير كافى لدفع هذا المبلغ للعميل");
                                return;
                            }
                            else
                            {
                                st.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_NewPay.Text),
                                dateTimePicker1.Value, Program.salesman, "رصيد مسحوب من الخزنة",
                                "مبلغ مدفوع للعميل بعد التعديل على الفاتورة" + txt_num.Text);

                                s.InsertStockMove(Convert.ToDecimal(txt_NewPay.Text) * -1, dateTimePicker1.Value, "فاتورة مبيعات  ",
                                   "مبلغ مدفوع للعميل مقابل تعديل فاتورة مبيعات رقم " + " " + txt_num.Text, 
                                    Convert.ToInt32(cmb_Stock.SelectedValue), Program.salesman, "خروج من الخزينة", 
                                    Convert.ToInt32(txt_num.Text));



                                dt51.Clear();
                                dt51 = Cm.Select_CustomerBalance(Convert.ToInt32(id_cust.Text));

                                decimal mno =  Convert.ToDecimal(txt_NewPay.Text);
                                decimal mno1 = Convert.ToDecimal(dt51.Rows[0][1]) + mno;
                                Cm.Update_CustomerTotalMoney(Convert.ToInt32(id_cust.Text), mno1);
                                Cm.Add_CustomerStatmentAccount(Convert.ToInt32(id_cust.Text), 0,
                                mno, "مبلغ مدفوع للعميل مقابل تعديل فاتورة مبيعات رقم " + " " + txt_num.Text, dateTimePicker1.Value,
                                mno1, Program.salesman);

                            }
                        }
                        else if (comboBox1.Text == "مدفوع من العميل")
                        {
                            s.add_insertStock(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_NewPay.Text),
                          dateTimePicker1.Value, Program.salesman, "تعديل فاتورة مبيعات رقم" + txt_num.Text, " تعديل فاتورة مبيعات إلى" + " " + txt_name.Text);

                            s.InsertStockMove(Convert.ToDecimal(txt_NewPay.Text), DateTime.Now, "فاتورة مبيعات  ",
                               "مبلغ مدفوع من العميل مقابل تعديل فاتورة مبيعات رقم " + " " + txt_num.Text,
                               Convert.ToInt32(cmb_Stock.SelectedValue)
                                , Program.salesman, "دخول الي الخزينة", Convert.ToInt32(txt_num.Text));


                            dt51.Clear();
                            dt51 = Cm.Select_CustomerBalance(Convert.ToInt32(id_cust.Text));

                            decimal mno = Convert.ToDecimal(txt_NewPay.Text);
                            decimal mno1 = Convert.ToDecimal(dt51.Rows[0][1]) - mno;
                            Cm.Update_CustomerTotalMoney(Convert.ToInt32(id_cust.Text), mno1);
                            Cm.Add_CustomerStatmentAccount(Convert.ToInt32(id_cust.Text), mno,
                            0, "مبلغ مدفوع من العميل مقابل تعديل فاتورة مبيعات رقم " + " " + txt_num.Text, dateTimePicker1.Value,
                            mno1, Program.salesman);
                        }
                    }


                    /////// تعديل مصروفات النقل والتركيب
                    if (txt_Na2l.Text != "")
                    {

                        m.Update_masrof_N2al($"تكلفة نقل للفاتورة رقم {txt_num.Text}",
                            Convert.ToDecimal(txt_Na2l.Text));
                        s.update_StockPull(Convert.ToInt32(Id_Stock.Text), Convert.ToDecimal(dt5.Rows[0][11]),
                       Convert.ToDecimal(txt_Na2l.Text), "مصروفات نقل للفاتورة رقم" + txt_num.Text);

                    }
                    if (txt_Service.Text != "")
                    {

                        m.Update_masrof_N2al($"تكلفة تركيب للفاتورة رقم {comboBox1.Text}", Convert.ToDecimal(txt_Service.Text));
                        s.update_StockPull(Convert.ToInt32(Id_Stock.Text), Convert.ToDecimal(dt5.Rows[0][10]),
                          Convert.ToDecimal(txt_Service.Text), "مصروفات تركيب للفاتورة رقم" + comboBox1.Text);

                    }
                    Login l = new Login();

                    l.addMoveUser(Program.salesman, this.Text, $"تعديل علي فاتورة مبيعات رقم {txt_num.Text}");



                    MessageBox.Show("تم تعديل الفاتوره بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btn_save.Enabled = false;
                    Btn_Print.Enabled = true;
                    
                    
                    Form_OrderManagment.getmain.gridControl1.DataSource = o.SelectOrderManagment();



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

           
            Frm_EditUnit Frm = new Frm_EditUnit();

            if (gridView2.RowCount > 0 && gridView2.SelectedRowsCount > 0)
            {
                    //    Frm.cmb_Unit.DataSource = p.Select_UnitProduct(Convert.ToInt32(DgvSale.CurrentRow.Cells[0].Value));
                    //    Frm.cmb_Unit.DisplayMember = "Unit_Name";
                    //    Frm.cmb_Unit.ValueMember = "Id_Unit";
                    Frm.textBox1.Text = gridView2.GetFocusedRowCellValue(ID_Item).ToString();
                    //Frm.Txt_Quantity.Text = gridView2.GetFocusedRowCellValue(quantity).ToString();

                    //Frm.Txt_DisCount.Text = gridView2.GetFocusedRowCellValue(Discount).ToString();

                    //Frm.txt_prise.Text = gridView2.GetFocusedRowCellValue(Price).ToString();

                Frm.ShowDialog();

            }
            if (Frm.Txt_Quantity.Text != "0" && Frm.txt_prise.Text != "" && Frm.txt_prise.Text != "0"
                && Frm.Txt_DisCount.Text != "")
            {
                    gridView2.SetFocusedRowCellValue(quantity, Frm.Txt_Quantity.Text) ;
                    gridView2.SetFocusedRowCellValue(Discount, Frm.Txt_DisCount.Text) ;
                    gridView2.SetFocusedRowCellValue(Price, Convert.ToDecimal(Frm.txt_prise.Text)- Convert.ToDecimal(Frm.Txt_DisCount.Text));
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

            //كزد الحفظ

            if (btn_save.Enabled==true)
            {
                if (e.KeyCode == Keys.F5)
                {
                    simpleButton3_Click(null, null);
                }
            }


            //---------------------------------------------------------------------------
            if (Btn_Print.Enabled==true)
            {
                 if (e.KeyCode == Keys.F2)   /// كود الطباعة
                {
                    Btn_Print_Click(null, null);
                }
            }
               

            //---------------------------------------------------------------------
            //كود جديد

          else  if (e.KeyCode == Keys.F1)
            {
                btn_new_Click(null,null);   
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
            Btn_Print.Enabled = false;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //dt.Clear();
            //calcalutordirect();
            //totaldirect();
            //calctotalinvoOrder();
            //pay();
            //ComboProduct();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
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

        private void Btn_AddCustomer_Click(object sender, EventArgs e)
        {
       

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
            if (txt_pay.Text == "0")
            {
                txt_pay.Text = "";
            }
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Na2l_Leave(object sender, EventArgs e)
        {
            if (txt_Na2l.Text=="")
            {
                txt_Na2l.Text = "0";
            }
        }

        private void txt_Service_Leave(object sender, EventArgs e)
        {
            if (txt_Service.Text == "")
            {
                txt_Service.Text = "0";
            }
        }

        private void txt_Na2l_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_Na2l.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_Service.Text.ToString().IndexOf('.') > -1)
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

        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text=="")
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

        private void btn_new_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void btn_save_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Btn_Print_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Frm_Sales_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void combo_Leave(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboBox1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        void clear()
        {
            txt_AfterDisc.Text = "0";
            txt_Discount.Text = "0";
            txt_invo.Text = "0";
            txt_mark.Text = "0";
            txt_Na2l.Text = "0";
            txt_name.Text = "";
            txt_note.Text = "";
            txt_num.Text = "";
            txt_pay.Text = "0";
            id_cust.Text = "";
            txt_Service.Text = "0";
            dt.Clear();

        }
        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            try
            {

                if (cmb_search.Text=="")
                {
                    return;
                }
                clear();
                dt2.Clear();
                if (txt_name.Text != "")
                {
                    dt2 = o.VildateID_Order(Convert.ToInt32(cmb_search.EditValue));
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show(" رقم الفاتورة غير موجود ف الفواتير ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        txt_name.SelectAll();
                        txt_name.Focus();
                        return;

                    }
                }
                flowLayoutPanel1.Enabled = true;
                flowLayoutPanel2.Enabled = true;
                DataTable dt1 = new DataTable();
                dt1.Clear();
                dt1 = o.SelectOrderReturn(Convert.ToInt32(cmb_search.EditValue));
              //  dt.Clear();
                dt = o.SelectProdUpdateOrder(Convert.ToInt32(cmb_search.EditValue));
                gridControl2.DataSource = dt;
                foreach (DataRow dr in dt1.Rows)
                {
                    txt_num.Text = dr["ID_Order"].ToString();
                    txt_name.Text = dr["Name"].ToString();
                    id_cust.Text = dr["ID_Cust"].ToString();
                  //  txt_sales.Text = Program.salesman;
                    txt_Service.Text = dr["AddService"].ToString();
                    txt_Na2l.Text = dr["AddNa2l"].ToString();
                    Id_Stock.Text = dr["Id_Stock"].ToString();
                    txt_Discount.Text = dr["total_Discount"].ToString();
                    txt_AfterDisc.Text = dr["total_AfterDisc"].ToString();
                    txt_invo.Text = dr["Total_Invoic"].ToString();
                    txt_pay.Text = dr["pay"].ToString();
                    txt_mark.Text = dr["rent"].ToString();
                    dateTimePicker1.Text = dr["Date_Order"].ToString();
                    txt_TotalPay.Text = dr["pay"].ToString();
                    txt_note.Text = dr["Discraption"].ToString();

                }
              
               // dataGridView1.Columns[0].Visible = false;
                //Cmb_Store.Text = dt2.Rows[0][10].ToString();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void txt_NewPay_KeyUp(object sender, KeyEventArgs e)
        {
            sumTotalPay();
            pay();
        }

        private void txt_TotalPay_KeyUp(object sender, KeyEventArgs e)
        {
            sumTotalPay();
            pay();
        }

        private void txt_NewPay_Leave(object sender, EventArgs e)
        {
            if (txt_NewPay.Text=="")
            {
                txt_NewPay.Text = "0.0";
            }
        }

        private void txt_NewPay_TextChanged(object sender, EventArgs e)
        {
            if (txt_NewPay.Text == ".")
            {
                txt_NewPay.Text = "0.";
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sumTotalPay();
            pay();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //if (e.Column.Name == "Item_Name")
            //{
            //    Update_QtyUnit();
            //}

            if (e.Column.Caption == "neg")
            {
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);

                    dt51.Clear();
                    dt51 = p.selectListProudect(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Item)));

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
                DataRow row = gridView2.GetFocusedDataRow();
                dt51.Clear();
                dt51 = o.SelectQuantityOFProductFromOrderReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(row[0]));
                if (dt51.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الصنف تم عمل مرتجع علية من قبل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                gridView2.DeleteSelectedRows();

                calctotalinvoOrder();
                TOTALFINALYDISCOUNT();
                pay();
            }

        }
    }
    }