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
    public partial class UpdateOrder : Form
    {
        Order o = new Order();
        Stock s = new Stock();
        Masrofat m = new Masrofat();
        DataTable dt = new DataTable();
        void Select_IdOrder()
        {
            comboBox1.DataSource = o.SelectIdOrder();
            comboBox1.DisplayMember = "ID_Order";
            comboBox1.ValueMember = "ID_Order";
        }
        public UpdateOrder()
        {
            InitializeComponent();
            Select_IdOrder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_SearchCustomerOrder frm = new Frm_SearchCustomerOrder();

            try
            {
                frm.ShowDialog();
                if (frm.dataGridView1.SelectedRows.Count > 0 && frm.dataGridView1.Rows.Count > 0)
                {

                    TransportAfterEdit.Clear();
                    TransportBeforeEdit.Clear();
                    trkebBeforeEdit.Clear();
                    TrkebAfterEdit.Clear();
                    id_stock.Clear();
                    dt.Clear();
                    dt = o.SelectOrderData(Convert.ToInt32(frm.dataGridView1.CurrentRow.Cells[0].Value));
                    if (dt.Rows.Count>0)
                    {
                        trkebBeforeEdit.Text = dt.Rows[0][9].ToString();
                        TransportBeforeEdit.Text = dt.Rows[0][10].ToString();
                        comboBox1.Text = dt.Rows[0][0].ToString();
                        id_stock.Text = dt.Rows[0][8].ToString();

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TransportAfterEdit.Clear();
                TransportBeforeEdit.Clear();
                trkebBeforeEdit.Clear();
                TrkebAfterEdit.Clear();
                id_stock.Clear();
                dt.Clear();
                dt = o.SelectOrderData(Convert.ToInt32(comboBox1.Text));
                if (dt.Rows.Count>0)
                {
                    trkebBeforeEdit.Text = dt.Rows[0][9].ToString();
                    TransportBeforeEdit.Text = dt.Rows[0][10].ToString();
                    id_stock.Text = dt.Rows[0][8].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد تاكيد التعديلات", "تعديل البيانات", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (TransportAfterEdit.Text != "")
                    {

                        m.Update_masrof_N2al($"تكلفة نقل للفاتورة رقم {comboBox1.Text}",
                            Convert.ToDecimal(TransportAfterEdit.Text));
                        s.update_StockPull(Convert.ToInt32(id_stock.Text), Convert.ToDecimal(TransportBeforeEdit.Text),
                       Convert.ToDecimal(TransportAfterEdit.Text), "مصروفات نقل للفاتورة رقم" + comboBox1.Text);

                    }
                    if (TrkebAfterEdit.Text != "")
                    {

                        m.Update_masrof_N2al($"تكلفة تركيب للفاتورة رقم {comboBox1.Text}", Convert.ToDecimal(TrkebAfterEdit.Text));
                        s.update_StockPull(Convert.ToInt32(id_stock.Text), Convert.ToDecimal(TrkebAfterEdit.Text),
                          Convert.ToDecimal(TrkebAfterEdit.Text), "مصروفات تركيب للفاتورة رقم" + comboBox1.Text);


                    }
                    if (TransportAfterEdit.Text!=""&&TrkebAfterEdit.Text!="")
                    {

                        o.Update_OrderNa2lAndTrkeb(Convert.ToInt32(comboBox1.Text), Convert.ToDecimal(TransportAfterEdit.Text)
                            , Convert.ToDecimal(TrkebAfterEdit.Text));
                    }
                    else
                    {

                        o.Update_OrderNa2lAndTrkeb(Convert.ToInt32(comboBox1.Text), 0, 0);
                    }
                    Login l = new Login();
                    l.addMoveUser(Program.salesman, this.Text, $" تعديل علي بيانات النقل والتركيب برقم فاتورة{comboBox1.Text}");

                    MessageBox.Show("تم حفظ التعديلات ");
                }
                else
                {
                    MessageBox.Show("تم إلغاء التعديلات ");
                }
                TransportAfterEdit.Clear();
                TransportBeforeEdit.Clear();
                trkebBeforeEdit.Clear();
                TrkebAfterEdit.Clear();
                id_stock.Clear();
                Select_IdOrder();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
            }
        }

        private void TrkebAfterEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TransportAfterEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TransportAfterEdit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TrkebAfterEdit_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void TrkebAfterEdit_Move(object sender, EventArgs e)
        {
            if (TrkebAfterEdit.Text == "")
            {
                TrkebAfterEdit.Text = "0";
            }
        }

        private void TransportAfterEdit_Move(object sender, EventArgs e)
        {
            if (TransportAfterEdit.Text == "")
            {
                TransportAfterEdit.Text = "0";
            }
        }
    }
}
