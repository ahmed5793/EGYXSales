using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using clothesStore.PL;
using System.Data.SqlClient;
using System.IO;
using clothesStore.Rpt;
using clothesStore.Bl;
using DevExpress.XtraCharts.Design;

namespace clothesStore.PL
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Login l = new Login();
        private static Frm_Main farm;

        SqlConnection con = new SqlConnection(@"server =.; database=EasyPos;integrated security=true");
        SqlCommand cmd;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Main getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Main();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;

            }
        }
        public Frm_Main()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            txtDATETIME.Hide();
            txt_idLogin.Hide();
            Txt_IDUsers.Hide();
        }

        private void Btn_addStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Store fs = new Frm_Store();
           
                //fs.MdiParent = this;
                fs.ShowDialog();
         
        
        }

        private void Btn_addProduct_ItemClick(object sender, ItemClickEventArgs e)
        {        
            Frm_Product fp = new Frm_Product();
                fp.ShowDialog();       
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
     
        
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Properties.Settings.Default.fileBackUp != string.Empty)
            {
                string fileName = Properties.Settings.Default.fileBackUp + "\\EasyPos " + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string sqlQuary = "BackUp Database EasyPos to Disk= '" + fileName + ".bak '";
                cmd = new SqlCommand(sqlQuary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //  MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  this.Close();
            }
            l.addMoveUser(Program.salesman, this.Text, $"خروج");
            Application.Exit();
        }


        private void Btn_AddCust_ItemClick(object sender, ItemClickEventArgs e)
        {        
            Frm_Customer FC = new Frm_Customer();
            //FC.MdiParent = this;
            FC.Show();
        }

        private void Btn_PayCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            PayCustomer FPC = new PayCustomer();
                //FPC.MdiParent = this;
                FPC.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CustomerStatment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportCustomerStatmentBalance frc = new Frm_ReportCustomerStatmentBalance();

            //frc.MdiParent = this;
                frc.Show();
       
       
        }
        private void Btn_SalesInnvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Frm_Sales FsA = new Frm_Sales();
            //   //FsA.MdiParent = this;
            //   FsA.Show();

            //Frm_Sales frm_Sales = new Frm_Sales();
            //frm_Sales.Show();
            Frm_ordersales os = new Frm_ordersales();
            os.Show();
        }
        private void Btn_ReturnSales_ItemClick(object sender, ItemClickEventArgs e)
        {      
            FrmOrderReturn For = new FrmOrderReturn();
                For.ShowDialog();
        }
        private void Btn_PurshasingInnvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form2 f = new Form2();
           // Frm_Purchases fp = new Frm_Purchases();
            //f.MdiParent = this;
            f.Show();
        }
        private void Btn_PurshasingReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ReturnSuppliers r = new Form_ReturnSuppliers(); 
                r.ShowDialog();

        }
        private void Btn_Masrofat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Masrofat fm = new Frm_Masrofat();
                //fm.MdiParent = this;
                fm.Show();

        }
        private void Btn_ReportMAsrofat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Allmasroft fl = new Frm_Allmasroft();
                //fl.MdiParent = this;
                fl.Show();
        }

        private void Btn_SalesArba7_ItemClick(object sender, ItemClickEventArgs e)
        {
            //FrmSalesReb7 fsr = new FrmSalesReb7();
            //    //fsr.MdiParent = this;
           // fsr.Show();

            frm_ReportReveune rv = new frm_ReportReveune();
            rv.Show();
            
           
        }
        private void Btn_PaySuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            PaySuppliers ps = new PaySuppliers();
                //ps.MdiParent = this;
                ps.Show();        
        }
        private void Btn_TransfairProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_TransFairProduct ftrp = new Frm_TransFairProduct();
                //ftrp.MdiParent = this;
                ftrp.Show();      
        }
        private void Btn_BalanceAdjustment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_BalanceAdjustment fba = new Frm_BalanceAdjustment();
                //fba.MdiParent = this;
                fba.Show();         
        }

        private void Bar_ReportStock_ListItemClick(object sender, ListItemClickEventArgs e)
        {

        }
        private void Btn_MAsrofatReport_ItemClick(object sender, ItemClickEventArgs e)
        {
             Frm_Allmasroft fam = new Frm_Allmasroft();
             //fam.MdiParent = this;
             fam.Show();        
        }
        private void Btn_AddNewStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form_Stock form_Stock = new Form_Stock();
            //    //form_Stock.MdiParent = this;
            //    form_Stock.Show();

            frm_ValueFirst fv = new frm_ValueFirst();

            fv.ShowDialog();
        }

        private void Btn_AddStockMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_addStockMoney fsm = new Form_addStockMoney();

                //fsm.MdiParent = this;
                fsm.Show();
        }
        private void Btn_AddStockPull_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_StockPull fsp = new Form_StockPull();
                //fsp.MdiParent = this;
                fsp.Show();
        }
        private void Btn_TransfairStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_StockTransfair fst = new Form_StockTransfair();
                //fst.MdiParent = this;
                fst.Show();
        }
        private void BtnAdd_CustomerMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_NoticeDisCountOrAddToCustomer fnd = new Frm_NoticeDisCountOrAddToCustomer();

                //fnd.MdiParent = this;
                fnd.Show();
        }
        private void Btn_AddSupplierMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_NoticeDiscountOrAddToSuppliers fns = new Frm_NoticeDiscountOrAddToSuppliers();

                //fns.MdiParent = this;
                fns.Show();
        }
        private void Btn_SupplierStatment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportSuppliersBalanceStatement frsbs = new Frm_ReportSuppliersBalanceStatement();

                //frsbs.MdiParent = this;
                frsbs.Show();
        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
  
        }

        private void ReportAllProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void Btn_ReportAllProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_AllProudect fap = new Frm_AllProudect();
         //   Frm_AllProduct fap = new Frm_AllProduct();
            //fap.MdiParent = this;
            fap.Show();    
        }
        private void Btn_prodtrans_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportTransfairProduct frtp = new Frm_ReportTransfairProduct();
                //frtp.MdiParent = this;
                frtp.Show();

        }
        private void Btn_Adjustmentbalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportAdujstmentBalance frab = new Frm_ReportAdujstmentBalance();
                //frab.MdiParent = this;
                frab.Show();
        }
        private void Btn_DebitCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
             Debit D = new Debit();
             //D.MdiParent = this;
             D.Show();
        }
        private void Btn_AllCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportAllCustomer frac = new Frm_ReportAllCustomer();
                //frac.MdiParent = this;
                frac.Show();


        }
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportAllSuppliers fras = new Frm_ReportAllSuppliers();
                //fras.MdiParent = this;
                fras.Show();
        }
        private void Btn_DebitSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_DebitSupplier fds = new Form_DebitSupplier();
                //fds.MdiParent = this;
                fds.Show();   
        }
        private void Btn_AllOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_OrderManagment fom = new Form_OrderManagment();
                //fom.MdiParent = this;
                fom.Show();
        }

        private void Btn_ReportOrderReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportOrderReturn fror = new Frm_ReportOrderReturn();
                //fror.MdiParent = this;
                fror.Show();
        }
        private void Btn_PurshasingMangement_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_suppliermanagement supplierm = new Form_suppliermanagement();
                //supplierm.MdiParent = this;
                supplierm.Show();
        }
        private void Btn_ReportpurshasingReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportPurshasingReturn frpr = new Frm_ReportPurshasingReturn();
                //frpr.MdiParent = this;
                frpr.Show();
        }
        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
                   
        }
        private void Btn_Backup_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_BackUp fb = new Form_BackUp();
                //fb.MdiParent = this;
                fb.Show();
        }
        private void Btn_Restore_ItemClick(object sender, ItemClickEventArgs e)
        {      
            Form_Restore fr = new Form_Restore();
                //fr.MdiParent = this;
                fr.Show();
        }

        private void Btn_CreateUserAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        private void Btn_ReportInsertStock_ItemClick(object sender, ItemClickEventArgs e)
        {
                 
        }
        private void Btn_ReportPullStock_ItemClick(object sender, ItemClickEventArgs e)
        {
    
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            barStaticItem1.Caption = Program.salesman;
        }
        private void Btn_AddSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Suppliers frm_Suppliers = new Form_Suppliers();
                //frm_Suppliers.MdiParent = this;
                frm_Suppliers.Show();
        }

        private void Bnt_Minimum_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_QuantityMinmum fqm = new Frm_QuantityMinmum();
            //fqm.MdiParent = this;
            fqm.Show();
        }

        private void barButtonItem17_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_Setting s = new Frm_Setting();
                s.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_UserManagment s = new Form_UserManagment();

            //s.MdiParent = this;
            s.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Validate_Users v = new Validate_Users();
            //fu.MdiParent = ts;
            v.ShowDialog();
        }

        private void Frm_Main_Load_1(object sender, EventArgs e)
        {
            barCheckItem1.Caption = Program.salesman;
        }

        private void tileControl2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SarfMabl5ll3mel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_PermessionMoneyNotice fpmn = new Frm_PermessionMoneyNotice();
            fpmn.Show();
        }

        private void btn_HarkaItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_MoveProduct mp = new Frm_MoveProduct();
            mp.Show();
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Form_suppliermanagement supplierm = new Form_suppliermanagement();
            //supplierm.MdiParent = this;
            supplierm.Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_ReportCustomerStatmentBalance frc = new Frm_ReportCustomerStatmentBalance();

            //frc.MdiParent = this;
            frc.Show();

        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Masrofat fp = new Frm_Masrofat();
            fp.ShowDialog();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_RecieveMoneyFromCashir frm_RecieveMoneyFrom = new frm_RecieveMoneyFromCashir();
            frm_RecieveMoneyFrom.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //Frm_Sales frm_Sales = new Frm_Sales();
            //frm_Sales.Show();
            Frm_ordersales os = new Frm_ordersales();
            os.Show();
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmOrderReturn frmOrderReturn = new FrmOrderReturn();
            //fqm.MdiParent = this;
            frmOrderReturn.Show();
        }

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmOrderReturn For = new FrmOrderReturn();
            For.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmSalesReb7 fsr = new FrmSalesReb7();
            //fsr.MdiParent = this;
            fsr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barCheckItem5.Caption = DateTime.Now.ToShortDateString();
            barCheckItem3.Caption = DateTime.Now.ToLongTimeString();
        }

        private void tileI_ManagmentOrder_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Form_OrderManagment fom = new Form_OrderManagment();
            //fom.MdiParent = this;
            fom.Show();
        }

        private void barButtonItem15_ItemClick_1(object sender, ItemClickEventArgs e)
        {
    
        }

        private void barButtonItem15_ItemClick_2(object sender, ItemClickEventArgs e)
        {
        //    UpdateOrder updateOrder = new UpdateOrder();
        //    updateOrder.Show();

            Frm_UpdateOrderSales us = new Frm_UpdateOrderSales();
            us.ShowDialog();
        }

        private void barButtonItem15_ItemClick_3(object sender, ItemClickEventArgs e)
        {
            frm_Remove fr = new frm_Remove();
            fr.ShowDialog();
        }

        private void barButtonItem17_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            FrmOrderReturnAllProduct frmOrderReturnAll = new FrmOrderReturnAllProduct();
            frmOrderReturnAll.Show();
        }

        private void Btn_returnAllProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ReturnSuppliersAllProduct form_ReturnSuppliersAllProduct = new Form_ReturnSuppliersAllProduct();
            form_ReturnSuppliersAllProduct.Show();
        }

        private void Btn_returnAllProduct_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form_ReturnSuppliersAllProduct form_ReturnSuppliersAll = new Form_ReturnSuppliersAllProduct();
            form_ReturnSuppliersAll.Show();
        }

        private void barButtonItem18_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_PrintAllBarcode pab = new frm_PrintAllBarcode();
            pab.Show();
        }

        private void barButtonItem18_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            frm_OpeningBalance ob = new frm_OpeningBalance();
            ob.Show();
        }

        private void barButtonItem19_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_OpeningBalanceSuppliers os = new frm_OpeningBalanceSuppliers();
            os.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_UpdatePurchasesDoors frm_UpdatePurchases = new Frm_UpdatePurchasesDoors();
            frm_UpdatePurchases.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptUserMove rm = new frm_RptUserMove();
            rm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RptItemsFirstTerm rptf = new Frm_RptItemsFirstTerm();
            rptf.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_otherRevenues or = new frm_otherRevenues();
            or.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ReportInsertStock fris = new Form_ReportInsertStock();
            //fris.MdiParent = this;
            fris.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_reportStockPull frsp = new Form_reportStockPull();
            //frsp.MdiParent = this;
            frsp.Show();
        }

        private void btn_ReciveMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RecieveMoney r = new frm_RecieveMoney();
            r.Show();
        }

        private void Btn_ReportDaily_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_rptDaily r = new frm_rptDaily();
            r.Show();
        }

        private void BTn_ReportMoveStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_MoveStock ms = new frm_MoveStock();
            ms.Show();
        }

        private void Btn_PresonalPull_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Personaldrawal pd = new frm_Personaldrawal();
            pd.Show();
        }

        private void btn_asol_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Asol fa = new frm_Asol();
            fa.Show();
        }

        private void Btn_EhlakElasol_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_EhlakatAsol frm_EhlakatAsol = new frm_EhlakatAsol();
            frm_EhlakatAsol.Show();
        }

        private void Btn_Eradat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_otherRevenues frm_OtherRevenues = new frm_otherRevenues();
            frm_OtherRevenues.Show();
        }

        private void Btn_ReportMs7obat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptPersonaldrawal _RptPersonaldrawal = new frm_RptPersonaldrawal();
            _RptPersonaldrawal.Show();
        }

        private void Btn_Ms7obat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptRevenueOther frm_RptRevenueOther = new frm_RptRevenueOther();
            frm_RptRevenueOther.Show();
        }

        private void Btn_ReportEhlaktElasool_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptEhlakAsol frm_RptEhlakAsol = new frm_RptEhlakAsol();
            frm_RptEhlakAsol.Show();
        }

        private void Btn_ReportTransfairStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptStockTransfer rst = new frm_RptStockTransfer();
            rst.Show();
        }

        private void Btn_INputMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptIncomestatement frm_RptIncomestatement = new frm_RptIncomestatement();
            frm_RptIncomestatement.Show();
        }

        private void Btn_MezanElmorg3a_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_rptBudget_review frm_RptBudget_ = new frm_rptBudget_review();
            frm_RptBudget_.Show();
        }

        private void Btn_CompanyReview_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RptCompanEvaluation frm_RptCompan = new frm_RptCompanEvaluation();
            frm_RptCompan.Show();
        }

        private void barButtonItem23_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form_RptOrderDeleted form_RptOrderDeleted = new Form_RptOrderDeleted();
            form_RptOrderDeleted.Show();
        }

        private void barButtonItem29_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form_DeletedPurshasing form_DeletedPurshasing = new Form_DeletedPurshasing();

            form_DeletedPurshasing.Show();
        }

        private void barButtonItem30_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FormStatues frmstuta = new FormStatues();
            frmstuta.Show();
        }
    }
}