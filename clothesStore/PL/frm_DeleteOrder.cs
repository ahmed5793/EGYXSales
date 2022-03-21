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
    public partial class frm_DeleteOrder : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        Order o = new Order();
        Store Store = new Store();
        Customer Cm = new Customer();
        Proudect p = new Proudect();
        Stock s = new Stock();
        DataTable dt1 = new DataTable();
        DataTable dt51 = new DataTable();
        public frm_DeleteOrder()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                dt1.Clear();
                dt1 = o.SelectOrderReturn(Convert.ToInt32(Txt_IdOrder.Text));
                dt.Clear();
                dt = o.SelectProdUpdateOrder(Convert.ToInt32(Txt_IdOrder.Text));


                o.UpateOrderShow(Convert.ToInt32(Txt_IdOrder.Text), "false");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt51.Clear();
                    dt51 = o.SelectQuantityOFProductFromOrderReturn(Convert.ToInt32(Txt_IdOrder.Text), Convert.ToInt32(dt.Rows[i][0]));
                    if (dt51.Rows.Count > 0)
                    {
                        decimal qtyReturn = Convert.ToDecimal(dt51.Rows[0][4]);
                        decimal TotalQty = Convert.ToDecimal(dt.Rows[i][4]) - qtyReturn;
                        p.Update_ProductQuantityIncrease(Convert.ToInt32(dt.Rows[i][0]), TotalQty);
                        p.Add_MoveProduct(Convert.ToInt32(dt.Rows[i][0]), Convert.ToInt32(TotalQty), Convert.ToDecimal(dt.Rows[i][3])
                            , 0, 0, 0, 0, 0, "مسح فاتورة مبيعات رقم " + " " + Txt_IdOrder.Text, DateTime.Now,
                            Program.salesman, "دخول");
                    }
                    else
                    {
                        p.Update_ProductQuantityIncrease(Convert.ToInt32(dt.Rows[i][0]), Convert.ToDecimal((dt.Rows[i][4])));
                        p.Add_MoveProduct(Convert.ToInt32(dt.Rows[i][0]), Convert.ToInt32((dt.Rows[i][4])), Convert.ToDecimal(dt.Rows[i][3])
                            , 0, 0, 0, 0, 0, "مسح فاتورة مبيعات رقم " + " " + Txt_IdOrder.Text, DateTime.Now,
                            Program.salesman, "دخول");

                    }
                }


                if (Convert.ToDecimal(dt1.Rows[0][7]) > 0)
                {
                    s.Add_StockPull(Convert.ToInt32(dt1.Rows[0][9]), Convert.ToDecimal(dt1.Rows[0][7]), DateTime.Now, Program.salesman,
                  "حذف فاتورة المبيعات رقم " + " " + Txt_IdOrder.Text, "سحب المبلغ المدفوع مسبقا من العميل آثناء الفاتورة");

                    s.InsertStockMove(Convert.ToDecimal(dt1.Rows[0][7]) * -1, DateTime.Now, "حذف فاتورة",
                       " حذف فاتورة مبيعات رقم " + " " + Txt_IdOrder.Text,
                        Convert.ToInt32(dt1.Rows[0][9]), Program.salesman, "خروج من الخزينة",
                        Convert.ToInt32(Txt_IdOrder.Text));


            
                }
                dt51.Clear();
                dt51 = Cm.Select_CustomerBalance(Convert.ToInt32(dt1.Rows[0][1]));

                decimal mno = Convert.ToDecimal(dt1.Rows[0][13]);
                decimal mno1 = Convert.ToDecimal(dt51.Rows[0][1]) - mno;
                Cm.Update_CustomerTotalMoney(Convert.ToInt32(dt1.Rows[0][1]), mno1);
                Cm.Add_CustomerStatmentAccount(Convert.ToInt32(dt1.Rows[0][1]), mno,
                0, "حذف فاتورة مبيعات رقم " + " " + Txt_IdOrder.Text, DateTime.Now,
                mno1, Program.salesman);
                Login l = new Login();
                l.addMoveUser(Program.salesman, "حذف الفاتورة", $"مسح فاتورة رقم {Txt_IdOrder.Text}");

                MessageBox.Show("تم حذف الفاتورة بنجاح");

                Console.Beep();
                //this.Hide();
                
             //   Form_OrderManagment.getmain.simpleButton1_Click(null,null);
                Form_OrderManagment.getmain.gridControl1.DataSource = o.SelectOrderManagment();
                this.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

           // Form_OrderManagment.getmain.gridControl1.DataSource = o.SelectOrderManagment();
            this.Close();
        }
    }
}