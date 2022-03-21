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
    public partial class Form_RptOrderDeleted : Form
    {
        DataTable dt = new DataTable();
        Order o = new Order();
        Store Store = new Store();
        Customer Cm = new Customer();
        Proudect p = new Proudect();
        Stock s = new Stock();
        DataTable dt1 = new DataTable();
        DataTable dt51 = new DataTable();

        //void calc()
        //{
        //    decimal total = 0;
        //    for (int i = 0; i < gridView1.RowCount; i++)
        //    {
        //        DataRow row = gridView1.GetDataRow(i);
        //        total += Convert.ToDecimal(row[3].ToString());
        //    }
        //    textBox2.Text = Math.Round(total, 2).ToString();
        //}
        //void ComboStore()
        //{
        //    Cmb_Store.DataSource = Store.Select_ComboStore();
        //    Cmb_Store.DisplayMember = "Store_Name";
        //    Cmb_Store.ValueMember = "Store_Id";
        //}

        private static Form_RptOrderDeleted farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Form_RptOrderDeleted getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Form_RptOrderDeleted();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;

            }
        }
        public Form_RptOrderDeleted()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            //ComboStore();
          //  gridControl1.DataSource= o.SelectOrderManagment();
            //calc();
            DateFrom.Text = DateTime.Now.ToShortDateString();
            DateTo.Text = DateTime.Now.ToShortDateString();
        }

        private void Form_OrderManagment_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt51 = new DataTable();
                if (gridView1.RowCount>0)                {

                    Rpt_PrintOrder r = new Rpt_PrintOrder();
                    FrmSingleReport sr = new FrmSingleReport();
                    sr.crystalReportViewer1.RefreshReport();
                    //r.SetDatabaseLogon("", "", ".", "FEEDStore");
                    //r.SetParameterValue("@ID", int.Parse(dataGridViewList.CurrentRow.Cells[0].Value.ToString()));
                    //sr.crystalReportViewer1.ReportSource = r;
                    //sr.Show();
                    dt51.Clear();
                    dt51 = o.RportOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                    clothesStore.DAL.DataOrderReport ds = new DAL.DataOrderReport();
                    Rpt.Frm_RptDocumetViewer frm = new Frm_RptDocumetViewer();
                    Rpt_PrintOrder rpts = new Rpt_PrintOrder();
                    frm.documentViewer1.Refresh();
                    ds.Tables["PrintOrder"].Clear();

                    for (int i = 0; i < dt51.Rows.Count; i++)
                    {
                        ds.Tables["PrintOrder"].Rows.Add(dt51.Rows[i][0], dt51.Rows[i][1], dt51.Rows[i][2],
                        dt51.Rows[i][3], dt51.Rows[i][4], dt51.Rows[i][5]
                          , dt51.Rows[i][6], dt51.Rows[i][7], dt51.Rows[i][8],
                         dt51.Rows[i][9], dt51.Rows[i][10], dt51.Rows[i][11], dt51.Rows[i][12]
                         , dt51.Rows[i][13]);
                    }
                    SettingPrint st = new SettingPrint();
                    DataTable tbl = new DataTable();
                    tbl.Clear();
                    tbl = st.SelectSettingPrintOrder();
                    ds.Tables["PrintInformation"].Clear();
                    ds.Tables["PrintInformation"].Rows.Add(tbl.Rows[0][0], tbl.Rows[0][1], tbl.Rows[0][2],
                        tbl.Rows[0][3], tbl.Rows[0][4]);


                    //rpts.SetDatabaseLogon("", "", ".", "EasySystem");
                    rpts.SetDataSource(ds);
                    rpts.SetParameterValue("@ID", Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));

                    frm.documentViewer1.DocumentSource = rpts;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    rpts.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    rpts.PrintToPrinter(1, true, 0, 0);


               

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = o.Select_Deleted_Orders(DateFrom.Value, DateTo.Value);
                    gridControl1.DataSource = dt;

                //calc();                  
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
               
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.addMoveUser(Program.salesman, this.Text, $"طباعه تقرير فواتير المبيعات الفترة بين {DateFrom.Text} الي الفترة{DateTo.Text}");
            gridControl1.ShowRibbonPrintPreview();
    

        }

        private void Cmb_Store_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //gridControl1.DataSource = o.SelectOrderManagment(Convert.T);
            //calc();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //textBox1.Text = gridView1.GetFocusedRowCellValue("رقم الفاتوره").ToString();
           

           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt51 = new DataTable();
                if (gridView1.RowCount > 0)
                {

                    //Rpt_PrintOrder r = new Rpt_PrintOrder();
                    FrmSingleReport sr = new FrmSingleReport();
                 //   sr.crystalReportViewer1.RefreshReport();
                    //r.SetDatabaseLogon("", "", ".", "FEEDStore");
                    //r.SetParameterValue("@ID", int.Parse(dataGridViewList.CurrentRow.Cells[0].Value.ToString()));
                    //sr.crystalReportViewer1.ReportSource = r;
                    //sr.Show();
                    dt51.Clear();
                    dt51 = o.RportOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                    DAL.DataOrderReport ds = new DAL.DataOrderReport();
                 //   Frm_ReportOrder frm = new Frm_ReportOrder();
                    Rpt_PrintOrder rpts = new Rpt_PrintOrder();
                 //   frm.documentViewer1.Refresh();
                    ds.Tables["PrintOrder"].Clear();

                    for (int i = 0; i < dt51.Rows.Count; i++)
                    {
                        ds.Tables["PrintOrder"].Rows.Add(dt51.Rows[i][0], dt51.Rows[i][1], dt51.Rows[i][2],
                        dt51.Rows[i][3], dt51.Rows[i][4], dt51.Rows[i][5]
                          , dt51.Rows[i][6], dt51.Rows[i][7], dt51.Rows[i][8],
                         dt51.Rows[i][9], dt51.Rows[i][10], dt51.Rows[i][11], dt51.Rows[i][12]
                         , dt51.Rows[i][13]);
                    }
                    SettingPrint st = new SettingPrint();
                    DataTable tbl = new DataTable();
                    tbl.Clear();
                    tbl = st.SelectSettingPrintOrder();
                    ds.Tables["PrintInformation"].Clear();
                    ds.Tables["PrintInformation"].Rows.Add(tbl.Rows[0][0], tbl.Rows[0][1], tbl.Rows[0][2],
                        tbl.Rows[0][3], tbl.Rows[0][4]);


                    //rpts.SetDatabaseLogon("", "", ".", "EasySystem");
                    rpts.SetDataSource(ds);
                    rpts.SetParameterValue("@ID", Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));

                    sr.crystalReportViewer1.ReportSource = rpts;

                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpts.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                    //rpts.PrintToPrinter(1, true, 0, 0);
                    sr.Show();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name=="btn_prints")
            {

                try
                {
                    DataTable dt51 = new DataTable();
                    if (gridView1.RowCount > 0)
                    {

                        Rpt_PrintOrder r = new Rpt_PrintOrder();
                        FrmSingleReport sr = new FrmSingleReport();
                        sr.crystalReportViewer1.RefreshReport();
                        //r.SetDatabaseLogon("", "", ".", "FEEDStore");
                        //r.SetParameterValue("@ID", int.Parse(dataGridViewList.CurrentRow.Cells[0].Value.ToString()));
                        //sr.crystalReportViewer1.ReportSource = r;
                        //sr.Show();
                        dt51.Clear();
                        dt51 = o.RportOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                        clothesStore.DAL.DataOrderReport ds = new DAL.DataOrderReport();
                        Rpt.Frm_RptDocumetViewer frm = new Frm_RptDocumetViewer();
                        Rpt_PrintOrder rpts = new Rpt_PrintOrder();
                        frm.documentViewer1.Refresh();
                        ds.Tables["PrintOrder"].Clear();

                        for (int i = 0; i < dt51.Rows.Count; i++)
                        {
                            ds.Tables["PrintOrder"].Rows.Add(dt51.Rows[i][0], dt51.Rows[i][1], dt51.Rows[i][2],
                            dt51.Rows[i][3], dt51.Rows[i][4], dt51.Rows[i][5]
                              , dt51.Rows[i][6], dt51.Rows[i][7], dt51.Rows[i][8],
                             dt51.Rows[i][9], dt51.Rows[i][10], dt51.Rows[i][11], dt51.Rows[i][12]
                             , dt51.Rows[i][13], dt51.Rows[i][14], dt51.Rows[i][15]);
                        }
                        SettingPrint st = new SettingPrint();
                        DataTable tbl = new DataTable();
                        tbl.Clear();
                        tbl = st.SelectSettingPrintOrder();
                        ds.Tables["PrintInformation"].Clear();
                        ds.Tables["PrintInformation"].Rows.Add(tbl.Rows[0][0], tbl.Rows[0][1], tbl.Rows[0][2],
                            tbl.Rows[0][3], tbl.Rows[0][4]);


                        //rpts.SetDatabaseLogon("", "", ".", "EasySystem");
                        rpts.SetDataSource(ds);
                        rpts.SetParameterValue("@ID", Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));

                        frm.documentViewer1.DocumentSource = rpts;

                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rpts.PrintOptions.PrinterName = Properties.Settings.Default.PrinterName;
                        rpts.PrintToPrinter(1, true, 0, 0);

                        Login l = new Login();
                        l.addMoveUser(Program.salesman, this.Text, $"طباعة فاتورة المبيعات رقم ({gridView1.GetFocusedRowCellValue("رقم الفاتوره")})");


                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.Column.Name=="btn_show")
            {

                try
                {

                    Login l = new Login();
                    l.addMoveUser(Program.salesman, this.Text, $"عرض فاتورة المبيعات رقم ({gridView1.GetFocusedRowCellValue("رقم الفاتوره")})");


                    FrmPreviewSales frmPreview = new FrmPreviewSales();
                    DataTable dt1 = new DataTable();
                    dt1.Clear();
                    dt1 = o.SelectOrderReturn(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                    //  dt.Clear();
                   dt = o.SelectProdUpdateOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                    frmPreview.gridControl2.DataSource = dt;
                    foreach (DataRow dr in dt1.Rows)
                    {
                        frmPreview.txt_num.Text = dr["ID_Order"].ToString();
                        frmPreview.txt_name.Text = dr["Name"].ToString();
                        frmPreview.id_cust.Text = dr["ID_Cust"].ToString();
                        //  txt_sales.Text = Program.salesman;
                        frmPreview.txt_Service.Text = dr["AddService"].ToString();
                        frmPreview.txt_Na2l.Text = dr["AddNa2l"].ToString();
                        frmPreview.Id_Stock.Text = dr["Treasury_name"].ToString();
                        frmPreview.txt_Discount.Text = dr["total_Discount"].ToString();
                        frmPreview.txt_AfterDisc.Text = dr["total_AfterDisc"].ToString();
                        frmPreview.txt_invo.Text = dr["Total_Invoic"].ToString();
                        frmPreview.txt_pay.Text = dr["pay"].ToString();
                        frmPreview.txt_mark.Text = dr["rent"].ToString();
                        frmPreview.dateTimePicker1.Text = dr["Date_Order"].ToString();

                    }
                    frmPreview.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.Column.Name== "Btn_Update")
            {
                try
                {

                    Frm_UpdateSales frm_UpdateSales = new Frm_UpdateSales();
                    frm_UpdateSales.flowLayoutPanel1.Enabled = true;
                    frm_UpdateSales.flowLayoutPanel2.Enabled = true;



                    dt1.Clear();
                    dt1 = o.SelectOrderReturn(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                      dt.Clear();
                    frm_UpdateSales.dt = o.SelectProdUpdateOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتوره")));
                    frm_UpdateSales.gridControl2.DataSource = frm_UpdateSales.dt;
                    foreach (DataRow dr in dt1.Rows)
                    {
                        frm_UpdateSales.txt_num.Text = dr["ID_Order"].ToString();
                        frm_UpdateSales.txt_name.Text = dr["Name"].ToString();
                        frm_UpdateSales.id_cust.Text = dr["ID_Cust"].ToString();
                        //  txt_sales.Text = Program.salesman;
                        frm_UpdateSales.txt_Service.Text = dr["AddService"].ToString();
                        frm_UpdateSales.txt_Na2l.Text = dr["AddNa2l"].ToString();
                        frm_UpdateSales.Id_Stock.Text = dr["Id_Stock"].ToString();
                        frm_UpdateSales.txt_Discount.Text = dr["total_Discount"].ToString();
                        frm_UpdateSales.txt_AfterDisc.Text = dr["total_AfterDisc"].ToString();
                        frm_UpdateSales.txt_invo.Text = dr["Total_Invoic"].ToString();
                        frm_UpdateSales.txt_pay.Text = dr["pay"].ToString();
                        frm_UpdateSales.txt_mark.Text = dr["rent"].ToString();
                        frm_UpdateSales.dateTimePicker1.Text = dr["Date_Order"].ToString();
                        frm_UpdateSales.txt_TotalPay.Text = dr["pay"].ToString();
                        frm_UpdateSales.txt_note.Text = dr["Discraption"].ToString();


                    }
                    frm_UpdateSales.ShowDialog();

                    Login l = new Login();
                    l.addMoveUser(Program.salesman, this.Text, $"فتح شاشة تعديل فاتورة المبيعات رقم ({gridView1.GetFocusedRowCellValue("رقم الفاتوره")})");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    
                }
            }
            if (e.Column.Name== "Btn_Delete")
            {

                Login l = new Login();
                l.addMoveUser(Program.salesman, this.Text, $"فتح شاشة حذف فاتورة المبيعات رقم ({gridView1.GetFocusedRowCellValue("رقم الفاتوره")})");

                frm_DeleteOrder DeleteOrder = new frm_DeleteOrder();
                DeleteOrder.Txt_IdOrder.Text = gridView1.GetFocusedRowCellValue("رقم الفاتوره").ToString();
                Console.Beep();

                DeleteOrder.ShowDialog();




            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
