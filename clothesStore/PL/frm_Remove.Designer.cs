
namespace clothesStore.PL
{
    partial class frm_Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Remove));
            this.rdb_all = new System.Windows.Forms.RadioButton();
            this.rdb_move = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // rdb_all
            // 
            this.rdb_all.AutoSize = true;
            this.rdb_all.Checked = true;
            this.rdb_all.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_all.Location = new System.Drawing.Point(269, 41);
            this.rdb_all.Name = "rdb_all";
            this.rdb_all.Size = new System.Drawing.Size(95, 28);
            this.rdb_all.TabIndex = 0;
            this.rdb_all.TabStop = true;
            this.rdb_all.Text = "حذف الكل";
            this.rdb_all.UseVisualStyleBackColor = true;
            // 
            // rdb_move
            // 
            this.rdb_move.AutoSize = true;
            this.rdb_move.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_move.Location = new System.Drawing.Point(64, 41);
            this.rdb_move.Name = "rdb_move";
            this.rdb_move.Size = new System.Drawing.Size(125, 28);
            this.rdb_move.TabIndex = 1;
            this.rdb_move.Text = "حذف الحركات";
            this.rdb_move.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(119, 94);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(174, 34);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "تنفيذ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 140);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.rdb_move);
            this.Controls.Add(this.rdb_all);
            this.Name = "frm_Remove";
            this.Text = "مسح الداتا";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_all;
        private System.Windows.Forms.RadioButton rdb_move;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}