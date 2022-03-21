
namespace clothesStore.PL
{
    partial class frm_RptPersonaldrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RptPersonaldrawal));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Prise = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bean = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lab_totalPull = new DevExpress.XtraEditors.LabelControl();
            this.lab_totalInsert = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lab_totalBalance = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(996, 393);
            this.gridControl1.TabIndex = 158;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.FontSizeDelta = 1;
            this.gridView1.Appearance.FocusedRow.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.FontSizeDelta = 1;
            this.gridView1.Appearance.FooterPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.FontSizeDelta = 1;
            this.gridView1.Appearance.GroupRow.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 21.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.FontSizeDelta = 1;
            this.gridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.FontSizeDelta = 1;
            this.gridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Prise,
            this.Date,
            this.Type,
            this.Bean,
            this.userName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PreviewIndent = 0;
            // 
            // Prise
            // 
            this.Prise.Caption = "القيمة";
            this.Prise.FieldName = "Prise";
            this.Prise.Name = "Prise";
            this.Prise.Visible = true;
            this.Prise.VisibleIndex = 0;
            // 
            // Date
            // 
            this.Date.Caption = "التاريخ";
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 1;
            // 
            // Type
            // 
            this.Type.Caption = "النوع";
            this.Type.FieldName = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 2;
            // 
            // Bean
            // 
            this.Bean.Caption = "البيان";
            this.Bean.FieldName = "Bean";
            this.Bean.Name = "Bean";
            this.Bean.Visible = true;
            this.Bean.VisibleIndex = 3;
            // 
            // userName
            // 
            this.userName.Caption = "اسم المستخدم";
            this.userName.FieldName = "userName";
            this.userName.Name = "userName";
            this.userName.Visible = true;
            this.userName.VisibleIndex = 4;
            // 
            // DateFrom
            // 
            this.DateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateFrom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(673, 15);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateFrom.Size = new System.Drawing.Size(138, 25);
            this.DateFrom.TabIndex = 159;
            // 
            // DateTo
            // 
            this.DateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(673, 51);
            this.DateTo.Name = "DateTo";
            this.DateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTo.Size = new System.Drawing.Size(138, 25);
            this.DateTo.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(817, 47);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 155;
            this.label4.Text = "إلى :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(813, 16);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(51, 28);
            this.label3.TabIndex = 154;
            this.label3.Text = " : من";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Appearance.BackColor = System.Drawing.Color.Navy;
            this.btn_Search.Appearance.BackColor2 = System.Drawing.Color.Aqua;
            this.btn_Search.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Search.Appearance.Options.UseBackColor = true;
            this.btn_Search.Appearance.Options.UseBorderColor = true;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Appearance.Options.UseForeColor = true;
            this.btn_Search.Appearance.Options.UseTextOptions = true;
            this.btn_Search.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btn_Search.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btn_Search.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Search.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_Search.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_Search.AppearanceDisabled.Options.UseFont = true;
            this.btn_Search.AppearanceDisabled.Options.UseTextOptions = true;
            this.btn_Search.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Search.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btn_Search.AppearanceHovered.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Search.AppearanceHovered.Options.UseFont = true;
            this.btn_Search.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Search.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Search.AppearancePressed.BackColor2 = System.Drawing.Color.Black;
            this.btn_Search.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btn_Search.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.AppearancePressed.Options.UseBackColor = true;
            this.btn_Search.AppearancePressed.Options.UseBorderColor = true;
            this.btn_Search.AppearancePressed.Options.UseFont = true;
            this.btn_Search.AppearancePressed.Options.UseForeColor = true;
            this.btn_Search.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Search.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(517, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(118, 36);
            this.btn_Search.TabIndex = 157;
            this.btn_Search.Text = "بحث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Print.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_Print.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.Btn_Print.Appearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Print.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Print.Appearance.Options.UseBackColor = true;
            this.Btn_Print.Appearance.Options.UseBorderColor = true;
            this.Btn_Print.Appearance.Options.UseFont = true;
            this.Btn_Print.Appearance.Options.UseForeColor = true;
            this.Btn_Print.Appearance.Options.UseTextOptions = true;
            this.Btn_Print.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Print.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.Btn_Print.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.Btn_Print.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.Btn_Print.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Btn_Print.AppearanceDisabled.Options.UseBackColor = true;
            this.Btn_Print.AppearanceDisabled.Options.UseBorderColor = true;
            this.Btn_Print.AppearanceDisabled.Options.UseFont = true;
            this.Btn_Print.AppearanceDisabled.Options.UseTextOptions = true;
            this.Btn_Print.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Print.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_Print.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.Btn_Print.AppearanceHovered.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.AppearanceHovered.Options.UseBackColor = true;
            this.Btn_Print.AppearanceHovered.Options.UseFont = true;
            this.Btn_Print.AppearanceHovered.Options.UseTextOptions = true;
            this.Btn_Print.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Print.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Print.AppearancePressed.BackColor2 = System.Drawing.Color.Black;
            this.Btn_Print.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.Btn_Print.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.Btn_Print.AppearancePressed.Options.UseBackColor = true;
            this.Btn_Print.AppearancePressed.Options.UseBorderColor = true;
            this.Btn_Print.AppearancePressed.Options.UseFont = true;
            this.Btn_Print.AppearancePressed.Options.UseForeColor = true;
            this.Btn_Print.AppearancePressed.Options.UseTextOptions = true;
            this.Btn_Print.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Print.ImageOptions.Image")));
            this.Btn_Print.Location = new System.Drawing.Point(205, 8);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(147, 36);
            this.Btn_Print.TabIndex = 156;
            this.Btn_Print.Text = "طباعة التقرير";
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(907, 503);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 22);
            this.labelControl1.TabIndex = 161;
            this.labelControl1.Text = "اجمالي المنسحب";
            // 
            // lab_totalPull
            // 
            this.lab_totalPull.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_totalPull.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_totalPull.Appearance.Options.UseFont = true;
            this.lab_totalPull.Location = new System.Drawing.Point(837, 503);
            this.lab_totalPull.Name = "lab_totalPull";
            this.lab_totalPull.Size = new System.Drawing.Size(27, 22);
            this.lab_totalPull.TabIndex = 162;
            this.lab_totalPull.Text = "0.0";
            // 
            // lab_totalInsert
            // 
            this.lab_totalInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_totalInsert.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_totalInsert.Appearance.Options.UseFont = true;
            this.lab_totalInsert.Location = new System.Drawing.Point(474, 503);
            this.lab_totalInsert.Name = "lab_totalInsert";
            this.lab_totalInsert.Size = new System.Drawing.Size(27, 22);
            this.lab_totalInsert.TabIndex = 164;
            this.lab_totalInsert.Text = "0.0";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(565, 503);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 22);
            this.labelControl4.TabIndex = 163;
            this.labelControl4.Text = "اجمالي الأيداع";
            // 
            // lab_totalBalance
            // 
            this.lab_totalBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_totalBalance.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_totalBalance.Appearance.Options.UseFont = true;
            this.lab_totalBalance.Location = new System.Drawing.Point(12, 503);
            this.lab_totalBalance.Name = "lab_totalBalance";
            this.lab_totalBalance.Size = new System.Drawing.Size(27, 22);
            this.lab_totalBalance.TabIndex = 166;
            this.lab_totalBalance.Text = "0.0";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(89, 503);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 22);
            this.labelControl6.TabIndex = 165;
            this.labelControl6.Text = "الرصيد";
            // 
            // frm_RptPersonaldrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 537);
            this.Controls.Add(this.lab_totalBalance);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lab_totalInsert);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lab_totalPull);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Btn_Print);
            this.Name = "frm_RptPersonaldrawal";
            this.Text = "تقرير المسحوبات الشخصية";
            this.Load += new System.EventHandler(this.frm_RptPersonaldrawal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Prise;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraGrid.Columns.GridColumn Bean;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.SimpleButton btn_Search;
        public DevExpress.XtraEditors.SimpleButton Btn_Print;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lab_totalPull;
        private DevExpress.XtraEditors.LabelControl lab_totalInsert;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lab_totalBalance;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}