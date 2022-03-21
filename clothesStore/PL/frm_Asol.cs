using DevExpress.XtraEditors;
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
   
    public partial class frm_Asol : DevExpress.XtraEditors.XtraForm
    {
        Asol a = new Asol();
        public frm_Asol()
        {
            InitializeComponent();
            gridControl1.DataSource = a.SelectAsol();
            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }

        private void frm_Asol_Load(object sender, EventArgs e)
        {

        }
        Login l = new Login();
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_asl.Text=="")
            {
                MessageBox.Show("من فضلك قم باادخال الأصل");
                return;
            }

            if (txt_value.Text == "")
            {
                MessageBox.Show("من فضلك قم باادخال قيمة الأصل");
                return;
            }

            a.AddAsol(txt_asl.Text, Convert.ToDecimal(txt_value.Text), Date_insert.Value);
            MessageBox.Show("تم الاضافة بنجاح","اضافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
            gridControl1.DataSource = a.SelectAsol();

            l.addMoveUser(Program.salesman, this.Text, $"اضافة اصول ثابتة");

            clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txt_asl.Text == "")
            {
                MessageBox.Show("من فضلك قم باادخال الأصل");
                return;
            }

            if (txt_value.Text == "")
            {
                MessageBox.Show("من فضلك قم باادخال قيمة الأصل");
                return;
            }
           
            a.UpdateAsol(txt_asl.Text, Convert.ToDecimal(txt_value.Text), Date_insert.Value,Convert.ToInt32(txtid.Text));
            MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = a.SelectAsol();
            l.addMoveUser(Program.salesman, this.Text, $"تعديل علي اصول ثابتة");
            clear();
            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    btn_save.Enabled = false;
                    btn_update.Enabled = true;

                    if (e.Column.Caption == "تعديل")
                    {
                      

                         txtid.Text= gridView1.GetFocusedRowCellValue(ID).ToString();
                        txt_asl.Text= gridView1.GetFocusedRowCellValue(Asl).ToString();
                        txt_value.Text= gridView1.GetFocusedRowCellValue(Value).ToString();
                        Date_insert.Text= gridView1.GetFocusedRowCellValue(Date).ToString();
                    }

                    else if (e.Column.Caption == "حذف")
                    {
                        if (MessageBox.Show("هل تريد حذف الأصل", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            a.DeleteAsol(Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID)));
                            MessageBox.Show("تم المسح بنجاح");
                            l.addMoveUser(Program.salesman, this.Text, $"حذف اصول ثابتة");
                            gridControl1.DataSource = a.SelectAsol();
                            clear();
                            btn_update.Enabled = false;
                            btn_save.Enabled = true;
                        }
                        else
                        {
                            clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        void clear()
        {
            txtid.Text = "";
            txt_asl.Text = "";
            txt_value.Text = "";
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_value.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}