namespace clothesStore.PL
{
    partial class Form_ReturnSuppliersAllProduct
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_sales = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_totalinvoice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_totaldiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_OldPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CustBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.Txt_TotalReturn = new System.Windows.Forms.TextBox();
            this.Btn_OldReturn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_IdSupplier = new System.Windows.Forms.TextBox();
            this.Txt_IdProduct = new System.Windows.Forms.TextBox();
            this.txt_IdOrder = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Pay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(470, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(145, 32);
            this.comboBox1.TabIndex = 9;
            // 
            // txt_sales
            // 
            this.txt_sales.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sales.Location = new System.Drawing.Point(45, 19);
            this.txt_sales.Name = "txt_sales";
            this.txt_sales.ReadOnly = true;
            this.txt_sales.Size = new System.Drawing.Size(205, 29);
            this.txt_sales.TabIndex = 8;
            this.txt_sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sales.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(674, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(883, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاريخ المرتجع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المورد";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(5, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(996, 170);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_totalinvoice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_totaldiscount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_OldPay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_CustBalance);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 123);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(139, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 1014;
            this.label11.Text = "إجمالى الفاتورة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_totalinvoice
            // 
            this.txt_totalinvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalinvoice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_totalinvoice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalinvoice.ForeColor = System.Drawing.Color.Yellow;
            this.txt_totalinvoice.Location = new System.Drawing.Point(9, 50);
            this.txt_totalinvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalinvoice.Multiline = true;
            this.txt_totalinvoice.Name = "txt_totalinvoice";
            this.txt_totalinvoice.ReadOnly = true;
            this.txt_totalinvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_totalinvoice.Size = new System.Drawing.Size(122, 32);
            this.txt_totalinvoice.TabIndex = 1015;
            this.txt_totalinvoice.Text = "0";
            this.txt_totalinvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(139, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 30);
            this.label13.TabIndex = 1012;
            this.label13.Text = "الخصم على الفاتورة";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_totaldiscount
            // 
            this.txt_totaldiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totaldiscount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_totaldiscount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totaldiscount.ForeColor = System.Drawing.Color.Yellow;
            this.txt_totaldiscount.Location = new System.Drawing.Point(9, 14);
            this.txt_totaldiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totaldiscount.Multiline = true;
            this.txt_totaldiscount.Name = "txt_totaldiscount";
            this.txt_totaldiscount.ReadOnly = true;
            this.txt_totaldiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_totaldiscount.Size = new System.Drawing.Size(122, 32);
            this.txt_totaldiscount.TabIndex = 1013;
            this.txt_totaldiscount.Text = "0";
            this.txt_totaldiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 88);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 30);
            this.label15.TabIndex = 1010;
            this.label15.Text = "المدفوع مسبقا ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_OldPay
            // 
            this.txt_OldPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_OldPay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_OldPay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPay.ForeColor = System.Drawing.Color.Yellow;
            this.txt_OldPay.Location = new System.Drawing.Point(8, 86);
            this.txt_OldPay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OldPay.Multiline = true;
            this.txt_OldPay.Name = "txt_OldPay";
            this.txt_OldPay.ReadOnly = true;
            this.txt_OldPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_OldPay.Size = new System.Drawing.Size(122, 32);
            this.txt_OldPay.TabIndex = 1011;
            this.txt_OldPay.Text = "0";
            this.txt_OldPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 1009;
            // 
            // Txt_CustBalance
            // 
            this.Txt_CustBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CustBalance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustBalance.Location = new System.Drawing.Point(752, 51);
            this.Txt_CustBalance.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CustBalance.Multiline = true;
            this.Txt_CustBalance.Name = "Txt_CustBalance";
            this.Txt_CustBalance.ReadOnly = true;
            this.Txt_CustBalance.Size = new System.Drawing.Size(147, 30);
            this.Txt_CustBalance.TabIndex = 1008;
            this.Txt_CustBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(904, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 1007;
            this.label3.Text = "الرصيد السابق";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(396, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 36);
            this.button1.TabIndex = 149;
            this.button1.Text = "بحث بأسم المورد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(689, 11);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(210, 30);
            this.txt_Name.TabIndex = 114;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 32);
            this.button2.TabIndex = 114;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(443, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 24);
            this.label20.TabIndex = 113;
            this.label20.Text = "اختر رقم الفاتورة";
            // 
            // Txt_TotalReturn
            // 
            this.Txt_TotalReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_TotalReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalReturn.ForeColor = System.Drawing.Color.Yellow;
            this.Txt_TotalReturn.Location = new System.Drawing.Point(748, 91);
            this.Txt_TotalReturn.Multiline = true;
            this.Txt_TotalReturn.Name = "Txt_TotalReturn";
            this.Txt_TotalReturn.ReadOnly = true;
            this.Txt_TotalReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_TotalReturn.Size = new System.Drawing.Size(133, 32);
            this.Txt_TotalReturn.TabIndex = 121;
            this.Txt_TotalReturn.Text = "0";
            this.Txt_TotalReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_OldReturn
            // 
            this.Btn_OldReturn.BackColor = System.Drawing.Color.Black;
            this.Btn_OldReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OldReturn.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_OldReturn.Location = new System.Drawing.Point(414, 19);
            this.Btn_OldReturn.Name = "Btn_OldReturn";
            this.Btn_OldReturn.Size = new System.Drawing.Size(244, 46);
            this.Btn_OldReturn.TabIndex = 161;
            this.Btn_OldReturn.Text = "عرض المرتجع السابق للفاتورة";
            this.Btn_OldReturn.UseVisualStyleBackColor = false;
            this.Btn_OldReturn.Click += new System.EventHandler(this.Btn_OldReturn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_IdSupplier);
            this.groupBox3.Controls.Add(this.Txt_IdProduct);
            this.groupBox3.Controls.Add(this.txt_IdOrder);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cmb_Stock);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_sales);
            this.groupBox3.Controls.Add(this.Btn_OldReturn);
            this.groupBox3.Controls.Add(this.Txt_Pay);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Txt_TotalReturn);
            this.groupBox3.Location = new System.Drawing.Point(3, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(998, 133);
            this.groupBox3.TabIndex = 164;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Txt_IdSupplier
            // 
            this.Txt_IdSupplier.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdSupplier.Location = new System.Drawing.Point(687, 50);
            this.Txt_IdSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IdSupplier.Multiline = true;
            this.Txt_IdSupplier.Name = "Txt_IdSupplier";
            this.Txt_IdSupplier.ReadOnly = true;
            this.Txt_IdSupplier.Size = new System.Drawing.Size(92, 24);
            this.Txt_IdSupplier.TabIndex = 177;
            this.Txt_IdSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_IdSupplier.Visible = false;
            // 
            // Txt_IdProduct
            // 
            this.Txt_IdProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdProduct.Location = new System.Drawing.Point(851, 18);
            this.Txt_IdProduct.Name = "Txt_IdProduct";
            this.Txt_IdProduct.ReadOnly = true;
            this.Txt_IdProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_IdProduct.Size = new System.Drawing.Size(57, 27);
            this.Txt_IdProduct.TabIndex = 176;
            this.Txt_IdProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_IdProduct.Visible = false;
            // 
            // txt_IdOrder
            // 
            this.txt_IdOrder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdOrder.Location = new System.Drawing.Point(786, 51);
            this.txt_IdOrder.Multiline = true;
            this.txt_IdOrder.Name = "txt_IdOrder";
            this.txt_IdOrder.ReadOnly = true;
            this.txt_IdOrder.Size = new System.Drawing.Size(86, 23);
            this.txt_IdOrder.TabIndex = 175;
            this.txt_IdOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IdOrder.Visible = false;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(219, 90);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 29);
            this.label17.TabIndex = 174;
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
            this.cmb_Stock.Location = new System.Drawing.Point(45, 90);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(167, 26);
            this.cmb_Stock.TabIndex = 173;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 171;
            this.label4.Text = "المدفوع من المورد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Pay
            // 
            this.Txt_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Pay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pay.ForeColor = System.Drawing.Color.Yellow;
            this.Txt_Pay.Location = new System.Drawing.Point(400, 91);
            this.Txt_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Pay.Multiline = true;
            this.Txt_Pay.Name = "Txt_Pay";
            this.Txt_Pay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Pay.Size = new System.Drawing.Size(132, 32);
            this.Txt_Pay.TabIndex = 172;
            this.Txt_Pay.Text = "0";
            this.Txt_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(884, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 31);
            this.label9.TabIndex = 166;
            this.label9.Text = "إجمالى المرتجع";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(375, 447);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 50);
            this.button4.TabIndex = 168;
            this.button4.Text = "استرجاع الفاتورة بالكامل";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form_ReturnSuppliersAllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1008, 501);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ReturnSuppliersAllProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرتجع فاتورة مشتريات بالكامل";
            this.Load += new System.EventHandler(this.Form_ReturnSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_sales;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_TotalReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_OldReturn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_CustBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_totalinvoice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_totaldiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_OldPay;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Pay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Txt_IdSupplier;
        private System.Windows.Forms.TextBox Txt_IdProduct;
        private System.Windows.Forms.TextBox txt_IdOrder;
    }
}