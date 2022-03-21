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
using clothesStore.Rpt;

namespace clothesStore.PL
{
    public partial class Form_DeletedPurshasing : Form
    {
        private static Form_DeletedPurshasing farm;
        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Form_DeletedPurshasing getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Form_DeletedPurshasing();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        Suppliers s = new Suppliers();
        Store Store = new Store();
        DataTable dt7 = new DataTable();
        Login l = new Login();

        public Form_DeletedPurshasing()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
         //   calc();
            DateFrom.Text = DateTime.Now.ToShortDateString();
            DateTo.Text = DateTime.Now.ToShortDateString();
        }
        

        void calc()
        {
            //decimal total = 0;
            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    DataRow r = gridView1.GetDataRow(i);
            //    total += Convert.ToDecimal(r[3].ToString()) ;
            //}
            ////textBox2.Text = Math.Round(total,2).ToString();
        }

        
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0 )
            {
                Frm_supplierDetails fsu = new Frm_supplierDetails();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                dt3.Clear();
                dt3 = s.reportsupplier(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                foreach (DataRow item in dt3.Rows)
                {
                    fsu.txt_num.Text = item[0].ToString();
                    fsu.txt_name.Text = item[1].ToString();
                    fsu.txt_date.Text = item[3].ToString();
                    fsu.txt_note.Text = item[4].ToString();
                    fsu.txt_sales.Text = item[5].ToString();
                    fsu.txt_invo.Text = item[6].ToString();
                    fsu.txt_pay.Text = item[7].ToString();
                    fsu.txt_mark.Text = item[8].ToString();
                }
                dt4.Clear();
                dt4 = s.reportsupplierprod(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                fsu.dataGridView1.DataSource = dt4;
                fsu.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا يوجد فواتير لعرضها");
            }
      


            //dt4 = s.reportsupplierprod(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));
            //Frm_supplierDetails.getmain.dataGridView1.DataSource = dt4;
            //dt3 = s.reportsupplier(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));

            //foreach (DataRow item in dt3.Rows)
            //{

            //    Frm_supplierDetails.getmain.txt_num.Text = item[0].ToString();
            //    Frm_supplierDetails.getmain.txt_name.Text = item[1].ToString();
            //    Frm_supplierDetails.getmain.txt_date.Text = item[3].ToString();
            //    Frm_supplierDetails.getmain.txt_note.Text = item[4].ToString();
            //    Frm_supplierDetails.getmain.txt_sales.Text = item[5].ToString();
            //    Frm_supplierDetails.getmain.txt_invo.Text = item[14].ToString();
            //    Frm_supplierDetails.getmain.txt_pay.Text = item[15].ToString();
            //    Frm_supplierDetails.getmain.txt_mark.Text = item[16].ToString();
            //}

           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = s.SearchsuppliermanagementSystem(DateFrom.Value, DateTo.Value);
                gridControl1.DataSource = dt;
                calc();          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Cmb_Store_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
            l.addMoveUser(Program.salesman, this.Text, $"طباعه تقرير شامل لفواتير الشراء");

        }

        private void Form_suppliermanagement_Load(object sender, EventArgs e)
        {

        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
          try
          {

                if (e.Column.Name == "btn_show")
                {


                    if (gridView1.RowCount > 0)
                    {
                        Frm_supplierDetails fsu = new Frm_supplierDetails();
                        DataTable dt3 = new DataTable();
                        DataTable dt4 = new DataTable();
                        l.addMoveUser(Program.salesman, this.Text, $" فتح شاشة تفاصيل فاتورة المشتريات رقم {gridView1.GetFocusedRowCellValue("رقم الفاتورة")}");

                        dt4.Clear();
                        dt4 = s.reportsupplierprod(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        fsu.dataGridView1.DataSource = dt4;
                        dt3.Clear();
                        dt3 = s.reportsupplier(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        foreach (DataRow item in dt3.Rows)
                        {
                            fsu.txt_num.Text = item[0].ToString();
                            fsu.txt_name.Text = item[1].ToString();
                            fsu.txt_date.Text = item[3].ToString();
                            fsu.txt_note.Text = item[4].ToString();
                            fsu.txt_sales.Text = item[5].ToString();
                            fsu.txt_invo.Text = item[6].ToString();
                            fsu.txt_pay.Text = item[7].ToString();
                            fsu.txt_mark.Text = item[8].ToString();
                        }

                        fsu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد فواتير لعرضها");
                    }
                }

                if (e.Column.Name== "btn_update")
                {
                    Frm_UpdatePurchasesDoors frm_UpdatePurchases = new Frm_UpdatePurchasesDoors();

                    
                    dt7.Clear();
                    dt7 = s.Validate_IdSupplierinnoice(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt7.Rows.Count == 0)
                    {
                        Console.Beep();
                        MessageBox.Show("لا توجد فاتورة بهذا الرقم");
                        return;
                    }
                    dt7.Clear();
                    dt7 = s.SelectSuppliersRteurn(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                    frm_UpdatePurchases.dt = s.SelectProductForUpdate(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow dr in dt7.Rows)
                    {
                        frm_UpdatePurchases.txt_num.Text = dr["ID"].ToString();
                        frm_UpdatePurchases.Txt_supName.Text = dr["Name"].ToString();
                        frm_UpdatePurchases.txt_IdSupplier.Text = dr["sup_id"].ToString();
                        frm_UpdatePurchases.txt_Discount.Text = dr["totalDiscount"].ToString();
                        frm_UpdatePurchases.txt_invo.Text = dr["Total_Invoic"].ToString();
                        frm_UpdatePurchases.txt_AfterDisc.Text = dr["totalAfterDicscount"].ToString();
                        frm_UpdatePurchases.txt_pay.Text = dr["pay"].ToString();
                        frm_UpdatePurchases.txt_mark.Text = dr["rent"].ToString();
                        frm_UpdatePurchases.Txt_TotalPay.Text = frm_UpdatePurchases.txt_pay.Text;



                    }
                    frm_UpdatePurchases.gridControl2.DataSource = frm_UpdatePurchases.dt;

                    frm_UpdatePurchases.ShowDialog();
                    l.addMoveUser(Program.salesman, this.Text, $"فتح شاشة تعديل فاتورة مشضتريات رقم ({gridView1.GetFocusedRowCellValue("رقم الفاتورة")})");

                }
                if (e.Column.Name=="btn_delete")
                {
                    Frm_DeletePurshases deletePurshases = new Frm_DeletePurshases();
                    deletePurshases.Txt_IdOrder.Text = gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString();
                    deletePurshases.ShowDialog();
                    l.addMoveUser(Program.salesman, this.Text, $"فتح شاشة حذف فاتورة المشتريات رقم ({gridView1.GetFocusedRowCellValue("رقم الفاتورة")})");
              
                
                }
            }
          catch (Exception ex )
          {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
          }
        

        }
    }
}
