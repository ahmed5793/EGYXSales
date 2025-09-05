namespace clothesStore.PL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Btn_SelectProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(151, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(374, 35);
            this.textBox3.TabIndex = 117;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_SelectProduct
            // 
            this.Btn_SelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_SelectProduct.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_SelectProduct.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SelectProduct.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_SelectProduct.Appearance.Options.UseBackColor = true;
            this.Btn_SelectProduct.Appearance.Options.UseFont = true;
            this.Btn_SelectProduct.Appearance.Options.UseForeColor = true;
            this.Btn_SelectProduct.Appearance.Options.UseTextOptions = true;
            this.Btn_SelectProduct.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_SelectProduct.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_SelectProduct.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_SelectProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SelectProduct.ImageOptions.Image")));
            this.Btn_SelectProduct.Location = new System.Drawing.Point(242, 107);
            this.Btn_SelectProduct.Name = "Btn_SelectProduct";
            this.Btn_SelectProduct.Size = new System.Drawing.Size(137, 35);
            this.Btn_SelectProduct.TabIndex = 118;
            this.Btn_SelectProduct.Text = "CONFIRM";
            this.Btn_SelectProduct.Click += new System.EventHandler(this.Btn_SelectProduct_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 30);
            this.labelControl1.TabIndex = 119;
            this.labelControl1.Text = "PASSWORD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(558, 154);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Btn_SelectProduct);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 193);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 193);
            this.Name = "Form1";
            this.Text = "CONFIG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private DevExpress.XtraEditors.SimpleButton Btn_SelectProduct;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}