using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clothesStore.Bl;
namespace clothesStore.PL
{
    public partial class Frm_Category : Form
    {
        Category C = new Category();
        Login l = new Login();
        public Frm_Category()
        {
            InitializeComponent();
            dataGridViewPR.DataSource = C.Select_Category();
            btn_update.Enabled = false;
            button1.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text=="")
                {
                    MessageBox.Show("لا بد من كتابة إسم التصنيف");
                    txt_name.Focus();
                    return;
                }
                else
                {
                    C.Add_Category(txt_name.Text);
                    MessageBox.Show("تم الحفظ بنجاح");
                 
                    l.addMoveUser(Program.salesman, this.Text, $"تسجيل تصنيف");

                    txt_name.Clear();
                    dataGridViewPR.DataSource = C.Select_Category();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("لا بد من كتابة إسم التصنيف");
                    txt_name.Focus();
                    return;
                }
                if (MessageBox.Show("هل تريد تعديل التصنيف","تعديل التصنيف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    C.Update_Category(Convert.ToInt32(dataGridViewPR.CurrentRow.Cells[0].Value), txt_name.Text);
              
                    l.addMoveUser(Program.salesman, this.Text, $"تعديل علي تصنيف");

                    MessageBox.Show("تم التعديل بنجاح");
   
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديل");

                }
                txt_name.Clear();
                dataGridViewPR.DataSource = C.Select_Category();
                btn_add.Enabled = true;
                btn_update.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void dataGridViewPR_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPR.Rows.Count>0)
                {
                    txt_name.Text = dataGridViewPR.CurrentRow.Cells[1].Value.ToString();
                    btn_add.Enabled = false;
                    btn_update.Enabled = true;
                    button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewPR.Rows.Count > 0)
            {


                if (MessageBox.Show("هل تريد حذف التصنيف", "يرجي العلم  هيتم مسح جميع الاصناف المرتبطه بالتصنيف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    C.deletecategory(Convert.ToInt32(dataGridViewPR.CurrentRow.Cells[0].Value));
                    l.addMoveUser(Program.salesman, this.Text, $"مسح تصنيف");

                    MessageBox.Show("تم المسح بنجاح");
                }
                txt_name.Clear();
                dataGridViewPR.DataSource = C.Select_Category();
                btn_add.Enabled = true;
                btn_update.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }
    }
}
