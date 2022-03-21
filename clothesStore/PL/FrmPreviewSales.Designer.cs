namespace clothesStore.PL
{
    partial class FrmPreviewSales
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreviewSales));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_Item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AfterDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonMins = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonremove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Service = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Na2l = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_AfterDisc = new System.Windows.Forms.TextBox();
            this.txt_invo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Id_Stock = new System.Windows.Forms.TextBox();
            this.id_cust = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mark = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonremove)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.gridControl2);
            this.groupControl4.Location = new System.Drawing.Point(12, 151);
            this.groupControl4.LookAndFeel.SkinName = "Office 2016 Black";
            this.groupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(943, 223);
            this.groupControl4.TabIndex = 136;
            this.groupControl4.Text = "اصناف الفاتورة";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(0, 25);
            this.gridControl2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonMins,
            this.repositoryItemButtonremove});
            this.gridControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl2.Size = new System.Drawing.Size(943, 198);
            this.gridControl2.TabIndex = 129;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.RowSeparator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.AppearancePrint.Row.Options.UseFont = true;
            this.gridView2.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_Item,
            this.Item_Name,
            this.Category,
            this.Price,
            this.quantity,
            this.Total,
            this.Discount,
            this.AfterDiscount});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ID_Item
            // 
            this.ID_Item.Caption = "رقم الصنف";
            this.ID_Item.FieldName = "رقم الصنف";
            this.ID_Item.Name = "ID_Item";
            this.ID_Item.OptionsColumn.AllowEdit = false;
            this.ID_Item.OptionsColumn.AllowMove = false;
            this.ID_Item.OptionsColumn.AllowShowHide = false;
            this.ID_Item.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.ID_Item.OptionsColumn.ReadOnly = true;
            this.ID_Item.Width = 90;
            // 
            // Item_Name
            // 
            this.Item_Name.Caption = "اسم الصنف";
            this.Item_Name.FieldName = "اسم الصنف";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.OptionsColumn.AllowEdit = false;
            this.Item_Name.OptionsColumn.AllowMove = false;
            this.Item_Name.OptionsColumn.AllowShowHide = false;
            this.Item_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Item_Name.OptionsColumn.FixedWidth = true;
            this.Item_Name.OptionsColumn.ReadOnly = true;
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 0;
            this.Item_Name.Width = 276;
            // 
            // Category
            // 
            this.Category.Caption = "النوع";
            this.Category.FieldName = "النوع";
            this.Category.Name = "Category";
            // 
            // Price
            // 
            this.Price.Caption = "السعر";
            this.Price.FieldName = "السعر";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.OptionsColumn.AllowMove = false;
            this.Price.OptionsColumn.AllowShowHide = false;
            this.Price.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Price.OptionsColumn.FixedWidth = true;
            this.Price.OptionsColumn.ReadOnly = true;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 1;
            this.Price.Width = 119;
            // 
            // quantity
            // 
            this.quantity.Caption = "الكميه";
            this.quantity.FieldName = "الكميه";
            this.quantity.Name = "quantity";
            this.quantity.OptionsColumn.AllowEdit = false;
            this.quantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.quantity.OptionsColumn.AllowMove = false;
            this.quantity.OptionsColumn.AllowShowHide = false;
            this.quantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.quantity.OptionsColumn.FixedWidth = true;
            this.quantity.OptionsColumn.ReadOnly = true;
            this.quantity.Visible = true;
            this.quantity.VisibleIndex = 2;
            this.quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.Caption = "الأجمالي";
            this.Total.FieldName = "الأجمالي";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.OptionsColumn.AllowMove = false;
            this.Total.OptionsColumn.AllowShowHide = false;
            this.Total.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Total.OptionsColumn.FixedWidth = true;
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 3;
            this.Total.Width = 140;
            // 
            // Discount
            // 
            this.Discount.Caption = "الخصم";
            this.Discount.FieldName = "الخصم";
            this.Discount.Name = "Discount";
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 4;
            this.Discount.Width = 108;
            // 
            // AfterDiscount
            // 
            this.AfterDiscount.Caption = "بعد الخصم";
            this.AfterDiscount.FieldName = "الاجمالي بعد الخصم";
            this.AfterDiscount.Name = "AfterDiscount";
            this.AfterDiscount.Visible = true;
            this.AfterDiscount.VisibleIndex = 5;
            this.AfterDiscount.Width = 156;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemButtonEdit1.LookAndFeel.SkinMaskColor = System.Drawing.Color.CornflowerBlue;
            this.repositoryItemButtonEdit1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.DodgerBlue;
            this.repositoryItemButtonEdit1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.repositoryItemButtonEdit1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonMins
            // 
            this.repositoryItemButtonMins.AutoHeight = false;
            this.repositoryItemButtonMins.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)});
            this.repositoryItemButtonMins.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.repositoryItemButtonMins.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Red;
            this.repositoryItemButtonMins.LookAndFeel.SkinName = "Office 2010 Silver";
            this.repositoryItemButtonMins.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonMins.Name = "repositoryItemButtonMins";
            this.repositoryItemButtonMins.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonremove
            // 
            this.repositoryItemButtonremove.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonremove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonremove.Name = "repositoryItemButtonremove";
            this.repositoryItemButtonremove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_pay);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_mark);
            this.groupBox3.Controls.Add(this.txt_Service);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_Na2l);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txt_AfterDisc);
            this.groupBox3.Controls.Add(this.txt_invo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_Discount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(11, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(943, 160);
            this.groupBox3.TabIndex = 134;
            this.groupBox3.TabStop = false;
            // 
            // txt_Service
            // 
            this.txt_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Service.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Service.Enabled = false;
            this.txt_Service.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Service.ForeColor = System.Drawing.Color.White;
            this.txt_Service.Location = new System.Drawing.Point(199, 123);
            this.txt_Service.Name = "txt_Service";
            this.txt_Service.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Service.Size = new System.Drawing.Size(151, 25);
            this.txt_Service.TabIndex = 6;
            this.txt_Service.Text = "0.0";
            this.txt_Service.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(354, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 24);
            this.label12.TabIndex = 78;
            this.label12.Text = "تركيب";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(673, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 76;
            this.label11.Text = "خدمة نقل";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_Na2l
            // 
            this.txt_Na2l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Na2l.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Na2l.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Na2l.Enabled = false;
            this.txt_Na2l.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Na2l.ForeColor = System.Drawing.Color.White;
            this.txt_Na2l.Location = new System.Drawing.Point(517, 123);
            this.txt_Na2l.Name = "txt_Na2l";
            this.txt_Na2l.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Na2l.Size = new System.Drawing.Size(150, 25);
            this.txt_Na2l.TabIndex = 65;
            this.txt_Na2l.Text = "0.0";
            this.txt_Na2l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(815, 19);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label24.Size = new System.Drawing.Size(67, 24);
            this.label24.TabIndex = 76;
            this.label24.Text = "الاجمالي";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // txt_AfterDisc
            // 
            this.txt_AfterDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AfterDisc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_AfterDisc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AfterDisc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AfterDisc.ForeColor = System.Drawing.Color.White;
            this.txt_AfterDisc.Location = new System.Drawing.Point(12, 13);
            this.txt_AfterDisc.Name = "txt_AfterDisc";
            this.txt_AfterDisc.ReadOnly = true;
            this.txt_AfterDisc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_AfterDisc.Size = new System.Drawing.Size(147, 25);
            this.txt_AfterDisc.TabIndex = 81;
            this.txt_AfterDisc.Text = "0.0";
            this.txt_AfterDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_invo
            // 
            this.txt_invo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_invo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_invo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invo.ForeColor = System.Drawing.Color.White;
            this.txt_invo.Location = new System.Drawing.Point(666, 18);
            this.txt_invo.Name = "txt_invo";
            this.txt_invo.ReadOnly = true;
            this.txt_invo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_invo.Size = new System.Drawing.Size(143, 25);
            this.txt_invo.TabIndex = 65;
            this.txt_invo.Text = "0.0";
            this.txt_invo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(507, 17);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(55, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "الخصم";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Discount
            // 
            this.txt_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Discount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Discount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.ForeColor = System.Drawing.Color.White;
            this.txt_Discount.Location = new System.Drawing.Point(358, 16);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Discount.Size = new System.Drawing.Size(143, 25);
            this.txt_Discount.TabIndex = 79;
            this.txt_Discount.Text = "0.0";
            this.txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(164, 15);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(145, 24);
            this.label13.TabIndex = 82;
            this.label13.Text = "الاجمالي بعد الخصم";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Id_Stock);
            this.groupBox1.Controls.Add(this.id_cust);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_num);
            this.groupBox1.Controls.Add(this.txt_note);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(943, 144);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // Id_Stock
            // 
            this.Id_Stock.BackColor = System.Drawing.Color.White;
            this.Id_Stock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Stock.Location = new System.Drawing.Point(635, 100);
            this.Id_Stock.Multiline = true;
            this.Id_Stock.Name = "Id_Stock";
            this.Id_Stock.ReadOnly = true;
            this.Id_Stock.Size = new System.Drawing.Size(214, 27);
            this.Id_Stock.TabIndex = 78;
            this.Id_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_cust
            // 
            this.id_cust.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cust.Location = new System.Drawing.Point(403, 15);
            this.id_cust.Multiline = true;
            this.id_cust.Name = "id_cust";
            this.id_cust.ReadOnly = true;
            this.id_cust.Size = new System.Drawing.Size(48, 23);
            this.id_cust.TabIndex = 77;
            this.id_cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_cust.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(26, 21);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(214, 29);
            this.txt_name.TabIndex = 72;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_num
            // 
            this.txt_num.BackColor = System.Drawing.Color.White;
            this.txt_num.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(635, 15);
            this.txt_num.Multiline = true;
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.Size = new System.Drawing.Size(214, 27);
            this.txt_num.TabIndex = 57;
            this.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "اسم العميل ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "رقم الفاتورة";
            // 
            // txt_note
            // 
            this.txt_note.BackColor = System.Drawing.Color.White;
            this.txt_note.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(25, 57);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.ReadOnly = true;
            this.txt_note.Size = new System.Drawing.Size(215, 81);
            this.txt_note.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "ملاحظات";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(857, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "تاريخ الفاتوره";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(635, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 26);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(883, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "الخزنة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(356, 67);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "المتبقي";
            // 
            // txt_pay
            // 
            this.txt_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_pay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pay.ForeColor = System.Drawing.Color.White;
            this.txt_pay.Location = new System.Drawing.Point(511, 70);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.ReadOnly = true;
            this.txt_pay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_pay.Size = new System.Drawing.Size(156, 25);
            this.txt_pay.TabIndex = 85;
            this.txt_pay.Text = "0.0";
            this.txt_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(673, 70);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 88;
            this.label9.Text = "المدفوع مسبقا";
            // 
            // txt_mark
            // 
            this.txt_mark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mark.BackColor = System.Drawing.SystemColors.ControlText;
            this.txt_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mark.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mark.ForeColor = System.Drawing.Color.White;
            this.txt_mark.Location = new System.Drawing.Point(194, 66);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.ReadOnly = true;
            this.txt_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mark.Size = new System.Drawing.Size(156, 25);
            this.txt_mark.TabIndex = 86;
            this.txt_mark.Text = "0.0";
            this.txt_mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPreviewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 546);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(969, 578);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(969, 578);
            this.Name = "FrmPreviewSales";
            this.Text = "شاشة معاينة تفاصيل الفاتورة";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonremove)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl groupControl4;
        public DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Columns.GridColumn ID_Item;
        public DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        public DevExpress.XtraGrid.Columns.GridColumn Category;
        public DevExpress.XtraGrid.Columns.GridColumn Price;
        public DevExpress.XtraGrid.Columns.GridColumn quantity;
        public DevExpress.XtraGrid.Columns.GridColumn Total;
        public DevExpress.XtraGrid.Columns.GridColumn Discount;
        public DevExpress.XtraGrid.Columns.GridColumn AfterDiscount;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonMins;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonremove;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txt_Service;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_Na2l;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txt_AfterDisc;
        public System.Windows.Forms.TextBox txt_invo;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_Discount;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox Id_Stock;
        public System.Windows.Forms.TextBox id_cust;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_num;
        public System.Windows.Forms.TextBox txt_note;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_pay;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_mark;
    }
}