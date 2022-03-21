
namespace clothesStore.PL
{
    partial class frm_otherRevenues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_otherRevenues));
            this.label7 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_addbalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_insert = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(170, 50);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 160;
            this.label7.Text = "البيان";
            // 
            // txt_reason
            // 
            this.txt_reason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_reason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(5, 7);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_reason.Size = new System.Drawing.Size(159, 109);
            this.txt_reason.TabIndex = 159;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_addbalance
            // 
            this.txt_addbalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_addbalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addbalance.Location = new System.Drawing.Point(315, 44);
            this.txt_addbalance.Multiline = true;
            this.txt_addbalance.Name = "txt_addbalance";
            this.txt_addbalance.Size = new System.Drawing.Size(195, 28);
            this.txt_addbalance.TabIndex = 154;
            this.txt_addbalance.Text = "0";
            this.txt_addbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_addbalance_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(526, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 157;
            this.label4.Text = "التاريخ";
            // 
            // Date_insert
            // 
            this.Date_insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Date_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_insert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_insert.Location = new System.Drawing.Point(315, 84);
            this.Date_insert.Name = "Date_insert";
            this.Date_insert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_insert.Size = new System.Drawing.Size(195, 26);
            this.Date_insert.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(527, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 155;
            this.label2.Text = "المبلغ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(517, 10);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 153;
            this.label5.Text = "الخزينة";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(315, 5);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(195, 27);
            this.cmb_Stock.TabIndex = 152;
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
            this.btn_Search.Location = new System.Drawing.Point(227, 128);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Search.Size = new System.Drawing.Size(118, 36);
            this.btn_Search.TabIndex = 162;
            this.btn_Search.Text = "اضافة";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_otherRevenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 168);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_addbalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Stock);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(619, 216);
            this.MinimumSize = new System.Drawing.Size(619, 216);
            this.Name = "frm_otherRevenues";
            this.Text = "ايرادات اخرى";
            this.Load += new System.EventHandler(this.frm_otherRevenues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btn_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_addbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Date_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Stock;
    }
}