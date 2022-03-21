using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using clothesStore.Bl;

namespace clothesStore.PL
{
    public partial class Form_BackUp : Form
    {
        SqlConnection con = new SqlConnection(@"server =.; database=EasyPos;integrated security=true");
        SqlCommand cmd;
        public Form_BackUp()
        {
            InitializeComponent();
             
            
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_backUp_Click(object sender, EventArgs e)
        {
            try {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتحديد المسار ");
                }
                else
                {
                    string fileName = textBox1.Text + "\\EasyPos " + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string sqlQuary = "BackUp Database EasyPos to Disk= '" + fileName + ".bak '";
                    cmd = new SqlCommand(sqlQuary, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    Login l = new Login();
                    l.addMoveUser(Program.salesman, this.Text, $"انشاء نسخه احتياطية وحفظها في مسار ({textBox1.Text})");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ممنوع حفظ نسخه علي سطح المكتب");
                MessageBox.Show(ex.Message);
              
            }
            }

        private void Form_BackUp_Load(object sender, EventArgs e)
        {

        }
    }
}
