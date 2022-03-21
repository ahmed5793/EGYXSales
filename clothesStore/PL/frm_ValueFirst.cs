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
    public partial class frm_ValueFirst : DevExpress.XtraEditors.XtraForm
    {
        Stock s = new Stock();
        Store st = new Store();
        public frm_ValueFirst()
        {
            InitializeComponent();
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form_Stock fs = new Form_Stock();
            fs.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_OpeningBalance ob = new frm_OpeningBalance();
            ob.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frm_OpeningBalanceSuppliers os = new frm_OpeningBalanceSuppliers();
            os.ShowDialog();
        }
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        private void frm_ValueFirst_Load(object sender, EventArgs e)
        {
            
            dt.Clear();
            dt = s.selectMoney();
            txtBalance.Text = dt.Rows[0][1].ToString();

            dt1.Clear();
            dt1 = st.selectStoreValue();
            textStoreValue.Text = dt1.Rows[0][1].ToString();

            //if (Convert.ToDecimal(textStoreValue.Text) > 0)
            //{
            //    Btn_SaveStore.Enabled = false;
            //}
            if (Convert.ToDecimal(txtBalance.Text) > 0)
            {
                btnSaveStock.Enabled = false;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد التعديل علي قيمة مخزون اول المدة", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {


                    dt1 = st.selectStoreValue();
                    st.Updatestorevalue(Convert.ToDecimal(textStoreValue.Text), DateTime.Now, Convert.ToInt32(dt1.Rows[0][0]));

                    MessageBox.Show("تم التعديل بنجاح");
                    dt1 = st.selectStoreValue();
                    textStoreValue.Text = dt1.Rows[0][1].ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
       
                s.updateMoney(Convert.ToDecimal(txtBalance.Text));
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}