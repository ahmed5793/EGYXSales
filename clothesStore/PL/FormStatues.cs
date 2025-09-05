using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clothesStore.DAL;
using clothesStore.BL;
using clothesStore.Rpt;


namespace clothesStore.PL
{
    public partial class FormStatues : Form
    {
        private static FormStatues farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static FormStatues getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new FormStatues();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        int id;
        Statues st = new Statues();
        Bl.Order o = new Bl.Order();
        void ComboCustomer()
        {
            comboBox1.Properties.DataSource = o.SelectCustName();
            comboBox1.Properties.DisplayMember = "Name";
            comboBox1.Properties.ValueMember = "ID_Cust";
            comboBox1.SelectionLength = -1;
        }
        public FormStatues()
        {


            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }



            ComboCustomer();

            dataGridView1.DataSource = st.get_all_statu_show();
            btn_print.Enabled = false;
            btn_update.Enabled = false;
            btn_allprint.Enabled = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            btn_delete.Enabled = false;






        }
        public void clear()

        {
            txt_activity.Text = "";
            txt_addresactivity.Text = "";
            txt_file.Text = "";
           
            txt_registration.Text = "";
       
            txt__bond.Text = "";

        }

        private void FormStatues_Load(object sender, EventArgs e)
        {
            txt_id.Text = st.get_last_id().Rows[0][0].ToString();
        
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Customer cm = new Frm_Customer();
            cm.ShowDialog();
            comboBox1.Properties.DataSource = o.SelectCustName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void txt_registration_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{


            //    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            //txt__bond.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //txt_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //txt_pay.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //txt_total.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //txt_registration.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //txt_addresactivity.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //txt_file.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //txt_activity.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ////comboBox1.Enabled = false;

            //datestarpikser.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[11].Value);
            //btn_save.Enabled = false;
            //btn_update.Enabled = true;
            //btn_print.Enabled = true;
            //btn_allprint.Enabled = true;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = st.search_statues(txt_search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataAccessLayer dc = new DataAccessLayer();
        private void btn_print_Click(object sender, EventArgs e)
        {
            
     
        }

        private void btn_allprint_Click(object sender, EventArgs e)
        {

         
        }

        private void اضافهمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافهمستخدمجديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FormAddUser fd = new FormAddUser();
            //fd.ShowDialog();
        }

        private void انشاءنسخهاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormBackUp bc = new FormBackUp();
            //bc.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void استرجاعنسخهمنقاعدهالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //FormRestore fr = new FormRestore();
            //fr.ShowDialog();
            //this.Close();

        }

        private void قاعدةالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                txt_activity.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_addresactivity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                datestarpikser.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                txt__bond.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


                txt_registration.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                txt_file.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dtp_LasttaxCheck.Value= Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);
                dtp_lastCommittee.Value= Convert.ToDateTime(dataGridView1.CurrentRow.Cells[11].Value);
                comboBox2.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                dtp_ValueAddedTaxDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[13].Value);



                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                btn_save.Enabled = false;
                btn_update.Enabled = true;
                btn_print.Enabled = true;
                btn_allprint.Enabled = true;
                btn_delete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormStatues_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("هل تريد اغلاق البرنامج", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    switch (e.KeyChar)
            //    {
            //        case '0':
            //        case '1':
            //        case '2':
            //        case '3':
            //        case '4':
            //        case '5':
            //        case '6':
            //        case '7':
            //        case '8':
            //        case '9':
            //        //case '.':




            //        case (char)Keys.Back:

            //            e.Handled = false;


            //            break;


            //        default:
            //            //MessageBox.Show("من فضلك قم باادخال ارقام فقط");
            //            e.Handled = true;


            //            break;

            //    }




            //    if (e.KeyChar == '.')
            //    {
            //        if (!txt_amount.Text.Contains('.'))
            //            txt_amount.Text = txt_amount.Text + e.KeyChar;


            //    }



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }






        //void calculamont()
        //{
        //    if (txt_amount.Text != string.Empty && txt_pay.Text != string.Empty)
        //    {


        //        double mins = Convert.ToDouble(txt_amount.Text) - Convert.ToDouble(txt_pay.Text);
        //        txt_total.Text = mins.ToString();
        //    }
        //    else
        //    {
        //        txt_total.Text = "";
        //    }
        //}

        private void txt_amount_KeyUp(object sender, KeyEventArgs e)
        {
         //   calculamont();
        }

        private void txt_pay_KeyUp(object sender, KeyEventArgs e)
        {
    
        }

        private void txt_file_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_amount_Validated(object sender, EventArgs e)
        {




        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        
        }

        private void تبديلالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت تريد تبديل المستخدم ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void txt_file_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //dc.open();
            //Statues st = new Statues();
            //CrystalReportStatues rp = new CrystalReportStatues();
            //FormReport fr = new FormReport();






            //fr.crystalReportViewer1.ReportSource = rp;



            //fr.ShowDialog();

            //dc.close();

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //try
            //{

            //    dc.open();

            //    CrystalReport cr = new CrystalReport();

            //    cr.SetParameterValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //    FormReport fr = new FormReport();
            //    fr.crystalReportViewer1.ReportSource = cr;
            //    fr.ShowDialog();

            //    dc.close();

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dtp_LasttaxCheck_ValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            clear();
            btn_update.Enabled = false;
            btn_print.Enabled = false;
            btn_allprint.Enabled = true;
            btn_save.Enabled = true;
            comboBox1.Enabled = true;
            btn_delete.Enabled = false;
            txt_id.Text = st.get_last_id().Rows[0][0].ToString();
        }

        private void simpleButton1_Click_3(object sender, EventArgs e)
        {
            //  Customer cm = new Customer();
            DataTable dt = new DataTable();
            try


            {
                dt.Clear();
                dt = st.get_all_statu_show();
                if (dt.Rows.Count>=10)
                {
                    MessageBox.Show("لقد تم نفاذ العدد المحدد بالنسبه للنسخه التجريبيه ");
                    //Application.Exit();
                    this.Close();
                    return;
                }

                if (comboBox1.Text != "" && txt_activity.Text != "")
                {


                   
                        st.add_statues(txt_activity.Text, txt_file.Text, txt_addresactivity.Text, txt_registration.Text,
                          txt__bond.Text, dateTimePicker1.Value,
                          Convert.ToInt32(comboBox1.EditValue), datestarpikser.Value, dtp_LasttaxCheck.Value,
                          dtp_lastCommittee.Value,comboBox2.Text,dtp_lastCommittee.Value,Txt_TaxRegistrationNumber.Text);
                   


                    MessageBox.Show("تم  الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = st.get_all_statu_show();
                    clear();

                }

                else
                {
                    MessageBox.Show("من فضلك قم باادخال اسم العميل او النشاط ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txt_id.Text = st.get_last_id().Rows[0][0].ToString();
        }

        private void simpleButton1_Click_4(object sender, EventArgs e)
        {
            try

            {

                    st.update_statues(txt_activity.Text, Convert.ToInt32(txt_file.Text), txt_addresactivity.Text,
                      Convert.ToInt32(txt_registration.Text), Convert.ToInt32(txt__bond.Text)
                      , dateTimePicker1.Value, datestarpikser.Value,
                      Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dtp_LasttaxCheck.Value,
                      dtp_lastCommittee.Value, comboBox2.Text, dtp_lastCommittee.Value, Txt_TaxRegistrationNumber.Text);
              

                MessageBox.Show("تم  التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = st.get_all_statu_show();
                clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click_5(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت تريد حذف بيانات العميل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                st.delete_statues(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = st.get_all_statu_show();
            }
            else
            {
                MessageBox.Show(" الغاء عمليه المسح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
