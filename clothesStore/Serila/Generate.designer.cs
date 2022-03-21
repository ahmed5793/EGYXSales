namespace clothesStore.Serila
{
    partial class Generate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Cmb_Licence = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_key = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Day = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_proudect = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Licence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_key.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Day.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_proudect.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.Cmb_Licence);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.Txt_key);
            this.groupControl1.Controls.Add(this.Txt_Day);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_proudect);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(478, 259);
            this.groupControl1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(178, 195);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 39);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Generiate";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Cmb_Licence
            // 
            this.Cmb_Licence.Location = new System.Drawing.Point(148, 80);
            this.Cmb_Licence.Name = "Cmb_Licence";
            this.Cmb_Licence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Licence.Properties.Items.AddRange(new object[] {
            "FULL",
            "TRIAL"});
            this.Cmb_Licence.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Cmb_Licence.Size = new System.Drawing.Size(304, 20);
            this.Cmb_Licence.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Proudect Key";
            // 
            // Txt_key
            // 
            this.Txt_key.Location = new System.Drawing.Point(148, 150);
            this.Txt_key.Name = "Txt_key";
            this.Txt_key.Size = new System.Drawing.Size(304, 20);
            this.Txt_key.TabIndex = 7;
            // 
            // Txt_Day
            // 
            this.Txt_Day.Location = new System.Drawing.Point(148, 114);
            this.Txt_Day.Name = "Txt_Day";
            this.Txt_Day.Size = new System.Drawing.Size(304, 20);
            this.Txt_Day.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(55, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Experience Day";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Licence Type";
            // 
            // txt_proudect
            // 
            this.txt_proudect.Location = new System.Drawing.Point(148, 41);
            this.txt_proudect.Name = "txt_proudect";
            this.txt_proudect.Size = new System.Drawing.Size(304, 20);
            this.txt_proudect.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proudect ID";
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 271);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2016 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Generate";
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.Generate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Licence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_key.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Day.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_proudect.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit Cmb_Licence;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_key;
        private DevExpress.XtraEditors.TextEdit Txt_Day;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_proudect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}