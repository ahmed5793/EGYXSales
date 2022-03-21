namespace clothesStore.PL
{
    partial class FrmOrderReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txt_QuantityReturn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_totalQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.txt_nameProduct = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_sales = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDOrder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Txt_CustBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalinvoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totaldiscount = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_trkeb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_transport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumCust = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Id_Stock = new System.Windows.Forms.TextBox();
            this.Txt_IdProduct = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Pay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Dgv_Return = new System.Windows.Forms.DataGridView();
            this.Txt_TotalReturn = new System.Windows.Forms.TextBox();
            this.Btn_OldReturn = new System.Windows.Forms.Button();
            this.Btn_AddToReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 147;
            this.label6.Text = "الكميه المرتجعه";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_QuantityReturn
            // 
            this.txt_QuantityReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_QuantityReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityReturn.Location = new System.Drawing.Point(285, 65);
            this.txt_QuantityReturn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QuantityReturn.MaxLength = 8;
            this.txt_QuantityReturn.Multiline = true;
            this.txt_QuantityReturn.Name = "txt_QuantityReturn";
            this.txt_QuantityReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_QuantityReturn.Size = new System.Drawing.Size(92, 27);
            this.txt_QuantityReturn.TabIndex = 146;
            this.txt_QuantityReturn.Text = "0";
            this.txt_QuantityReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_QuantityReturn.Click += new System.EventHandler(this.txt_QuantityReturn_Click);
            this.txt_QuantityReturn.TextChanged += new System.EventHandler(this.txt_return_TextChanged);
            this.txt_QuantityReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_return_KeyPress);
            this.txt_QuantityReturn.Leave += new System.EventHandler(this.txt_QuantityReturn_Leave);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(383, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 143;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.MintCream;
            this.label20.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(432, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 24);
            this.label20.TabIndex = 142;
            this.label20.Text = "اختر رقم الفاتورة";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 27);
            this.label14.TabIndex = 135;
            this.label14.Text = "الكمية بالمخزن";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_totalQuantity
            // 
            this.txt_totalQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalQuantity.Location = new System.Drawing.Point(12, 14);
            this.txt_totalQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalQuantity.Multiline = true;
            this.txt_totalQuantity.Name = "txt_totalQuantity";
            this.txt_totalQuantity.ReadOnly = true;
            this.txt_totalQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_totalQuantity.Size = new System.Drawing.Size(101, 27);
            this.txt_totalQuantity.TabIndex = 134;
            this.txt_totalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(674, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 29);
            this.label12.TabIndex = 132;
            this.label12.Text = "الاجمالي بعد  الخصم";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(895, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 27);
            this.label10.TabIndex = 131;
            this.label10.Text = "اسم الصنف";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(901, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 130;
            this.label8.Text = "سعر البيع";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 27);
            this.label7.TabIndex = 129;
            this.label7.Text = "الكمية المباعه فى الفاتورة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(287, 16);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quantity.MaxLength = 8;
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_quantity.Size = new System.Drawing.Size(92, 27);
            this.txt_quantity.TabIndex = 128;
            this.txt_quantity.Text = "0";
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(581, 67);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_amount.Size = new System.Drawing.Size(91, 29);
            this.txt_amount.TabIndex = 127;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prise
            // 
            this.txt_prise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(800, 67);
            this.txt_prise.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prise.MaxLength = 8;
            this.txt_prise.Multiline = true;
            this.txt_prise.Name = "txt_prise";
            this.txt_prise.ReadOnly = true;
            this.txt_prise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_prise.Size = new System.Drawing.Size(93, 29);
            this.txt_prise.TabIndex = 125;
            this.txt_prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prise_KeyPress);
            this.txt_prise.Validated += new System.EventHandler(this.txt_prise_Validated);
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameProduct.Location = new System.Drawing.Point(637, 21);
            this.txt_nameProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nameProduct.Multiline = true;
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.ReadOnly = true;
            this.txt_nameProduct.Size = new System.Drawing.Size(256, 27);
            this.txt_nameProduct.TabIndex = 124;
            this.txt_nameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(674, 10);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(211, 30);
            this.txt_Name.TabIndex = 114;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(477, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(128, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // txt_sales
            // 
            this.txt_sales.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sales.Location = new System.Drawing.Point(821, 421);
            this.txt_sales.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sales.Name = "txt_sales";
            this.txt_sales.ReadOnly = true;
            this.txt_sales.Size = new System.Drawing.Size(164, 32);
            this.txt_sales.TabIndex = 8;
            this.txt_sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sales.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(655, 125);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 26);
            this.dateTimePicker1.TabIndex = 1000;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(985, 140);
            this.dataGridView1.TabIndex = 136;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(870, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاريخ المرتجع";
            // 
            // txt_IDOrder
            // 
            this.txt_IDOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IDOrder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDOrder.Location = new System.Drawing.Point(116, 46);
            this.txt_IDOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IDOrder.Multiline = true;
            this.txt_IDOrder.Name = "txt_IDOrder";
            this.txt_IDOrder.ReadOnly = true;
            this.txt_IDOrder.Size = new System.Drawing.Size(64, 25);
            this.txt_IDOrder.TabIndex = 80;
            this.txt_IDOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IDOrder.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Txt_CustBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_totalinvoice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_totaldiscount);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_trkeb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_transport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(985, 158);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(878, 85);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 28);
            this.label18.TabIndex = 1008;
            this.label18.Text = "المدفوع مسبقا";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(692, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(181, 32);
            this.textBox1.TabIndex = 1009;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.MintCream;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(682, 50);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 24);
            this.label16.TabIndex = 1007;
            // 
            // Txt_CustBalance
            // 
            this.Txt_CustBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CustBalance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustBalance.Location = new System.Drawing.Point(726, 47);
            this.Txt_CustBalance.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CustBalance.Multiline = true;
            this.Txt_CustBalance.Name = "Txt_CustBalance";
            this.Txt_CustBalance.ReadOnly = true;
            this.Txt_CustBalance.Size = new System.Drawing.Size(147, 30);
            this.Txt_CustBalance.TabIndex = 1006;
            this.Txt_CustBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(892, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 1005;
            this.label4.Text = "الرصيد السابق";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 1003;
            this.label5.Text = "إجمالى الفاتورة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_totalinvoice
            // 
            this.txt_totalinvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalinvoice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_totalinvoice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalinvoice.ForeColor = System.Drawing.Color.Yellow;
            this.txt_totalinvoice.Location = new System.Drawing.Point(12, 118);
            this.txt_totalinvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalinvoice.Multiline = true;
            this.txt_totalinvoice.Name = "txt_totalinvoice";
            this.txt_totalinvoice.ReadOnly = true;
            this.txt_totalinvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_totalinvoice.Size = new System.Drawing.Size(122, 32);
            this.txt_totalinvoice.TabIndex = 1004;
            this.txt_totalinvoice.Text = "0";
            this.txt_totalinvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 1001;
            this.label3.Text = "الخصم على الفاتورة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_totaldiscount
            // 
            this.txt_totaldiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totaldiscount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_totaldiscount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totaldiscount.ForeColor = System.Drawing.Color.Yellow;
            this.txt_totaldiscount.Location = new System.Drawing.Point(12, 82);
            this.txt_totaldiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totaldiscount.Multiline = true;
            this.txt_totaldiscount.Name = "txt_totaldiscount";
            this.txt_totaldiscount.ReadOnly = true;
            this.txt_totaldiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_totaldiscount.Size = new System.Drawing.Size(122, 32);
            this.txt_totaldiscount.TabIndex = 1002;
            this.txt_totaldiscount.Text = "0";
            this.txt_totaldiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(383, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 36);
            this.button3.TabIndex = 145;
            this.button3.Text = "بحث بأسم العميل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(142, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 164;
            this.label11.Text = "تكلفة التركيب";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_trkeb
            // 
            this.txt_trkeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trkeb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_trkeb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trkeb.ForeColor = System.Drawing.Color.Yellow;
            this.txt_trkeb.Location = new System.Drawing.Point(12, 46);
            this.txt_trkeb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trkeb.Multiline = true;
            this.txt_trkeb.Name = "txt_trkeb";
            this.txt_trkeb.ReadOnly = true;
            this.txt_trkeb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_trkeb.Size = new System.Drawing.Size(122, 32);
            this.txt_trkeb.TabIndex = 165;
            this.txt_trkeb.Text = "0";
            this.txt_trkeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 31);
            this.label9.TabIndex = 162;
            this.label9.Text = "تكلفة النقل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_transport
            // 
            this.txt_transport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_transport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_transport.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transport.ForeColor = System.Drawing.Color.Yellow;
            this.txt_transport.Location = new System.Drawing.Point(12, 11);
            this.txt_transport.Margin = new System.Windows.Forms.Padding(4);
            this.txt_transport.Multiline = true;
            this.txt_transport.Name = "txt_transport";
            this.txt_transport.ReadOnly = true;
            this.txt_transport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_transport.Size = new System.Drawing.Size(122, 32);
            this.txt_transport.TabIndex = 163;
            this.txt_transport.Text = "0";
            this.txt_transport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "إسم العميل";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_NumCust
            // 
            this.txt_NumCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NumCust.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumCust.Location = new System.Drawing.Point(188, 75);
            this.txt_NumCust.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumCust.Multiline = true;
            this.txt_NumCust.Name = "txt_NumCust";
            this.txt_NumCust.ReadOnly = true;
            this.txt_NumCust.Size = new System.Drawing.Size(43, 25);
            this.txt_NumCust.TabIndex = 122;
            this.txt_NumCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NumCust.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Id_Stock);
            this.groupBox2.Controls.Add(this.txt_NumCust);
            this.groupBox2.Controls.Add(this.Txt_IdProduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_nameProduct);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_prise);
            this.groupBox2.Controls.Add(this.txt_IDOrder);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_amount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_QuantityReturn);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_totalQuantity);
            this.groupBox2.Controls.Add(this.txt_quantity);
            this.groupBox2.Location = new System.Drawing.Point(7, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(985, 107);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصنف المرتجع";
            // 
            // Id_Stock
            // 
            this.Id_Stock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Stock.Location = new System.Drawing.Point(100, 75);
            this.Id_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.Id_Stock.Multiline = true;
            this.Id_Stock.Name = "Id_Stock";
            this.Id_Stock.ReadOnly = true;
            this.Id_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Id_Stock.Size = new System.Drawing.Size(80, 25);
            this.Id_Stock.TabIndex = 149;
            this.Id_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id_Stock.Visible = false;
            // 
            // Txt_IdProduct
            // 
            this.Txt_IdProduct.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdProduct.Location = new System.Drawing.Point(12, 75);
            this.Txt_IdProduct.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IdProduct.Multiline = true;
            this.Txt_IdProduct.Name = "Txt_IdProduct";
            this.Txt_IdProduct.ReadOnly = true;
            this.Txt_IdProduct.Size = new System.Drawing.Size(80, 25);
            this.Txt_IdProduct.TabIndex = 148;
            this.Txt_IdProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cmb_Stock);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Txt_Pay);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Dgv_Return);
            this.groupBox3.Controls.Add(this.Txt_TotalReturn);
            this.groupBox3.Location = new System.Drawing.Point(4, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(985, 172);
            this.groupBox3.TabIndex = 163;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الاصناف المرتجعة";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(180, 130);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 29);
            this.label17.TabIndex = 170;
            this.label17.Text = "الخزنة";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(6, 133);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(167, 26);
            this.cmb_Stock.TabIndex = 168;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(496, 132);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 29);
            this.label13.TabIndex = 166;
            this.label13.Text = "المدفوع للعميل";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Pay
            // 
            this.Txt_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Pay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pay.ForeColor = System.Drawing.Color.Yellow;
            this.Txt_Pay.Location = new System.Drawing.Point(361, 131);
            this.Txt_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Pay.Multiline = true;
            this.Txt_Pay.Name = "Txt_Pay";
            this.Txt_Pay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Pay.Size = new System.Drawing.Size(132, 32);
            this.Txt_Pay.TabIndex = 167;
            this.Txt_Pay.Text = "0";
            this.Txt_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Pay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pay_KeyPress);
            this.Txt_Pay.Leave += new System.EventHandler(this.Txt_Pay_Leave_1);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(838, 132);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 29);
            this.label15.TabIndex = 150;
            this.label15.Text = "إجمالى قيمة المرتجع";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_Return
            // 
            this.Dgv_Return.AllowUserToAddRows = false;
            this.Dgv_Return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Return.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Return.Location = new System.Drawing.Point(11, 18);
            this.Dgv_Return.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Return.MultiSelect = false;
            this.Dgv_Return.Name = "Dgv_Return";
            this.Dgv_Return.ReadOnly = true;
            this.Dgv_Return.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dgv_Return.RowHeadersVisible = false;
            this.Dgv_Return.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Return.ShowEditingIcon = false;
            this.Dgv_Return.Size = new System.Drawing.Size(970, 105);
            this.Dgv_Return.TabIndex = 161;
            this.Dgv_Return.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Return_CellContentClick);
            this.Dgv_Return.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dgv_Return_RowsRemoved);
            // 
            // Txt_TotalReturn
            // 
            this.Txt_TotalReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_TotalReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_TotalReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalReturn.ForeColor = System.Drawing.Color.Yellow;
            this.Txt_TotalReturn.Location = new System.Drawing.Point(700, 131);
            this.Txt_TotalReturn.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_TotalReturn.Multiline = true;
            this.Txt_TotalReturn.Name = "Txt_TotalReturn";
            this.Txt_TotalReturn.ReadOnly = true;
            this.Txt_TotalReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_TotalReturn.Size = new System.Drawing.Size(132, 32);
            this.Txt_TotalReturn.TabIndex = 157;
            this.Txt_TotalReturn.Text = "0";
            this.Txt_TotalReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_TotalReturn.Click += new System.EventHandler(this.Txt_TotalReturn_Click);
            this.Txt_TotalReturn.TextChanged += new System.EventHandler(this.Txt_TotalReturn_TextChanged);
            // 
            // Btn_OldReturn
            // 
            this.Btn_OldReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_OldReturn.BackColor = System.Drawing.Color.Black;
            this.Btn_OldReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OldReturn.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_OldReturn.Location = new System.Drawing.Point(560, 422);
            this.Btn_OldReturn.Name = "Btn_OldReturn";
            this.Btn_OldReturn.Size = new System.Drawing.Size(244, 33);
            this.Btn_OldReturn.TabIndex = 164;
            this.Btn_OldReturn.Text = "عرض المرتجع السابق للفاتورة";
            this.Btn_OldReturn.UseVisualStyleBackColor = false;
            this.Btn_OldReturn.Click += new System.EventHandler(this.Btn_OldReturn_Click);
            // 
            // Btn_AddToReturn
            // 
            this.Btn_AddToReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_AddToReturn.BackColor = System.Drawing.Color.Black;
            this.Btn_AddToReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddToReturn.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_AddToReturn.Location = new System.Drawing.Point(303, 421);
            this.Btn_AddToReturn.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddToReturn.Name = "Btn_AddToReturn";
            this.Btn_AddToReturn.Size = new System.Drawing.Size(207, 33);
            this.Btn_AddToReturn.TabIndex = 165;
            this.Btn_AddToReturn.Text = "إضافة للمرتجع";
            this.Btn_AddToReturn.UseVisualStyleBackColor = false;
            this.Btn_AddToReturn.Click += new System.EventHandler(this.Btn_AddToReturn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(409, 646);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 166;
            this.button1.Text = "حفظ المرتجع";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOrderReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(994, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_AddToReturn);
            this.Controls.Add(this.Btn_OldReturn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_sales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderReturn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرتجع مبيعات جزئى";
            this.Load += new System.EventHandler(this.FrmOrderReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_QuantityReturn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_totalQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.TextBox txt_nameProduct;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_sales;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_NumCust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Dgv_Return;
        private System.Windows.Forms.TextBox Txt_TotalReturn;
        private System.Windows.Forms.Button Btn_OldReturn;
        private System.Windows.Forms.Button Btn_AddToReturn;
        private System.Windows.Forms.TextBox Txt_IdProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_trkeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_transport;
        private System.Windows.Forms.TextBox Id_Stock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Pay;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalinvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totaldiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Txt_CustBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
    }
}