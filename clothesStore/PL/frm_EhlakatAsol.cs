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
    public partial class frm_EhlakatAsol : DevExpress.XtraEditors.XtraForm
    {
        Asol a = new Asol();
        public frm_EhlakatAsol()
        {
            InitializeComponent();
            gridControl1.DataSource = a.selectEhlakatAsol();
            cmb_asl.DataSource = a.SelectAsol();
            cmb_asl.DisplayMember = "Asl";
            cmb_asl.ValueMember = "ID";
        }


        private void frm_EhlakatAsol_Load(object sender, EventArgs e)
        {
            dt.Clear();
            dt = a.SelectAsolByID(Convert.ToInt32(cmb_asl.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_valueAsl.Text = dt.Rows[0][1].ToString();
                txt_Totalhlak.Text = dt.Rows[0][2].ToString();
                txt_TotalValueAsl.Text = (Convert.ToDecimal(dt.Rows[0][1]) - Convert.ToDecimal(dt.Rows[0][2])).ToString();
            }
            else
            {

                txt_valueAsl.Text = "0.0";
                txt_Totalhlak.Text = "0.0";
                txt_TotalValueAsl.Text = "0.0";
            }
        }
        DataTable dt = new DataTable();
        private void cmb_asl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            dt = a.SelectAsolByID(Convert.ToInt32(cmb_asl.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txt_valueAsl.Text = dt.Rows[0][1].ToString();
                txt_Totalhlak.Text = dt.Rows[0][2].ToString();
                txt_TotalValueAsl.Text = (Convert.ToDecimal(dt.Rows[0][1]) - Convert.ToDecimal(dt.Rows[0][2])).ToString();
            }
            else
            {
                txt_valueAsl.Text = "0.0";
                txt_Totalhlak.Text = "0.0";
                txt_TotalValueAsl.Text = "0.0";
            }
        }
        void clear()
        {
            cmb_asl.SelectedIndex = -1;
            txt_ehlak.Text = "0.0";
            txt_Totalhlak.Text = "0.0";
            txt_TotalValueAsl.Text = "0.0";
            txt_valueAsl.Text = "0.0";
        }
        Login l = new Login();
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ehlak.Text=="" || txt_ehlak.Text=="0")
                {
                    MessageBox.Show("من فضلك ادخال قيمة الأهلاك");
                    return;
                }
                dt.Clear();
                dt = a.SelectAsolByID(Convert.ToInt32(cmb_asl.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("من فضلك اختر اسم الأصل صحيح");
                    return;
                }
                a.AddEhlakatAsol(Convert.ToInt32(cmb_asl.SelectedValue), Convert.ToDecimal(txt_ehlak.Text), Dtb_Date.Value);
                MessageBox.Show("تم الأضافة بنجاح");
                l.addMoveUser(Program.salesman, this.Text, $"اضافة اهلاك اصول ثابتة");
                gridControl1.DataSource = a.selectEhlakatAsol();
                clear();



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (txt_ehlak.Text == "" || txt_ehlak.Text == "0")
            {
                MessageBox.Show("من فضلك ادخال قيمة الأهلاك");
                return;
            }
            dt.Clear();
            dt = a.SelectAsolByID(Convert.ToInt32(cmb_asl.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("من فضلك اختر اسم الأصل صحيح");
                return;
            }
            a.UpdateEhlakatAsol(Convert.ToInt32(cmb_asl.SelectedValue), Convert.ToDecimal(txt_ehlak.Text), Dtb_Date.Value,Convert.ToInt32(txtid.Text));
            l.addMoveUser(Program.salesman, this.Text, $"تعديل علي اهلاك اصول ثابتة");
            MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = a.selectEhlakatAsol();
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
                        dt.Clear();
                        dt = a.SelectAsolByID(Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID_Asol)));

                        txtid.Text = gridView1.GetFocusedRowCellValue(ID_Ehlak).ToString();
                        cmb_asl.Text = gridView1.GetFocusedRowCellValue(Asl).ToString();
                        txt_valueAsl.Text = gridView1.GetFocusedRowCellValue(AsolValue).ToString();
                        txt_Totalhlak.Text = dt.Rows[0][2].ToString();
                        txt_ehlak.Text = gridView1.GetFocusedRowCellValue(Ehalak_Value).ToString();
                        txt_TotalValueAsl.Text = (Convert.ToDecimal(txt_valueAsl.Text) - Convert.ToDecimal(txt_Totalhlak.Text)).ToString();
                        Dtb_Date.Text = gridView1.GetFocusedRowCellValue(Date).ToString();
                    }

                    else if (e.Column.Caption == "حذف")
                    {
                        if (MessageBox.Show("هل تريد الحذف ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            a.DeleteEhlakatAsol(Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID_Ehlak)));
                            MessageBox.Show("تم المسح بنجاح");
                            l.addMoveUser(Program.salesman, this.Text, $"حذف اهلاك اصول ثابتة");
                            gridControl1.DataSource = a.selectEhlakatAsol();
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

        private void txt_ehlak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_ehlak.Text.ToString().IndexOf('.') > -1)
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