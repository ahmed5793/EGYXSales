using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothesStore.PL
{
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            rbSQL.CheckedChanged += RbSQL_CheckedChanged;
            rbWindows.CheckedChanged += RbWindows_CheckedChanged;
            txtServer.Text = Properties.Settings.Default.Server == string.Empty ? "SQL5088.site4now.net" : Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database == string.Empty ? "db_a54a03_egyxsales" : Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSQL.Checked = true;
           
                    
                txtID.Text = Properties.Settings.Default.ID==string.Empty?"db_a54a03_egyxsales_admin":Properties.Settings.Default.ID;
                txtPWD.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtID.Clear();
                txtPWD.Clear();
                txtID.ReadOnly = true;
                txtPWD.ReadOnly = true;
            }
        }

        private void RbWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWindows.Checked == true)
            {
                txtID.Text = string.Empty;
                txtPWD.Text = string.Empty;
            }
        }

        private void RbSQL_CheckedChanged(object sender, EventArgs e)
        {
          if(rbSQL.Checked==true)
            {
                txtID.Text = Properties.Settings.Default.ID == string.Empty ? "db_a54a03_egyxsales_admin" : Properties.Settings.Default.ID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Mode = rbSQL.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.ID = txtID.Text;
            Properties.Settings.Default.Password = txtPWD.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح");
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtPWD.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtPWD.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_CONFIG_Load(object sender, EventArgs e)
        {
            
        }
    }
}
