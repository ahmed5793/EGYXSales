using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using clothesStore.Bl;
namespace clothesStore.PL
{
    public partial class Frm_DeletePurshases : DevExpress.XtraEditors.XtraForm
    {
        Suppliers s = new Suppliers();
        Stock st = new Stock();
        Proudect p = new Proudect();
        DataTable data5 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt6 = new DataTable();

        public Frm_DeletePurshases()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            { 
                //update purshases show from true to false
                s.DeleteSuppliersInformation(Convert.ToInt32(Txt_IdOrder.Text));

                dt7.Clear();
                dt7 = s.SelectSuppliersRteurn(Convert.ToInt32(Txt_IdOrder.Text));
                dt2.Clear();
                dt2 = s.SelectProudectRteurn(Convert.ToInt32(Txt_IdOrder.Text));
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    data5.Clear();
                    data5 = s.SelectQuantityOFProductFromSuppliersReturn(Convert.ToInt32(Txt_IdOrder.Text),
                        Convert.ToInt32(dt2.Rows[i][1]));
                    if (data5.Rows.Count > 0)
                    {

                        decimal qtyReturn = Convert.ToDecimal(data5.Rows[0][4]);
                        decimal TotalQty = Convert.ToDecimal(dt2.Rows[i][4]) - qtyReturn;

                        p.Update_ProductQuantityDecrease(Convert.ToInt32(dt2.Rows[i][1]), TotalQty);

                        p.Add_MoveProduct(Convert.ToInt32(dt2.Rows[i][1]), 0, 0, Convert.ToInt32(TotalQty),
                            Convert.ToDecimal(dt2.Rows[i][3])
                        , 0, 0, 0, "مسح فاتورة مشتريات رقم " + " " + Txt_IdOrder.Text, DateTime.Now,
                         Program.salesman, "خروج");
                    }
                    else
                    {
                        p.Update_ProductQuantityDecrease(Convert.ToInt32(dt2.Rows[i][1]), Convert.ToDecimal(dt2.Rows[i][4]));
                        p.Add_MoveProduct(Convert.ToInt32(dt2.Rows[i][1]), 0, 0, Convert.ToInt32(dt2.Rows[i][4]),
                        Convert.ToDecimal(dt2.Rows[i][3])
                    , 0, 0, 0, "مسح فاتورة مشتريات رقم " + " " + Txt_IdOrder.Text, DateTime.Now,
                     Program.salesman, "خروج");

                    }
                }

                    if (Convert.ToDecimal(dt7.Rows[0][4])>0)
                    {
                        st.add_insertStock(Convert.ToInt32(dt7.Rows[0][6]), Convert.ToDecimal(dt7.Rows[0][4]),
                         DateTime.Now,Program.salesman, "حذف فاتورة مشتريات رقم" + Txt_IdOrder.Text,
                          "استرداد مبلغ مدفوع للمورد مقابل الفاتورة" );

                        st.InsertStockMove(Convert.ToDecimal(dt7.Rows[0][4]), DateTime.Now, "فاتورة مشتريات  ",
                           "استرداد مبلغ مدفوع للمورد مقابل حذف الفاتورة رقم" + " " + Txt_IdOrder.Text,
                           Convert.ToInt32(dt7.Rows[0][6])
                            , Program.salesman, "دخول الي الخزينة", Convert.ToInt32(Txt_IdOrder.Text));
                    }
                    Login l = new Login();
                    l.addMoveUser(Program.salesman, "حذف الفاتورة", $"مسح فاتورة مشتريات رقم {Txt_IdOrder.Text}");
                   
                    dt6.Clear();
                    dt6 = s.select_SupplierBalance(Convert.ToInt32(dt7.Rows[0][2]));
                    decimal mno = Convert.ToDecimal(dt7.Rows[0][8]);
                    decimal mno1 = Convert.ToDecimal(dt6.Rows[0][1]) - mno;
                    s.Update_SupplierTotalMoney(Convert.ToInt32(dt7.Rows[0][2]), mno1);
                    s.Add_SuppliersStatementAccount(Convert.ToInt32(dt7.Rows[0][2]), 0,
                        mno, " حذف فاتورة مشتريات رقم " + " " + Txt_IdOrder.Text,DateTime.Now, mno1);
                Console.Beep();
                MessageBox.Show("تم حذف الفاتورة بنجاح");

                 
                Form_suppliermanagement.getmain.gridControl1.DataSource = s.suppliermanagement();
                    this.Close();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
            }
        }
    }
}