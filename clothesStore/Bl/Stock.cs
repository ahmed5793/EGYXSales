using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using clothesStore.DAL;

namespace clothesStore.Bl
{
    class Stock
    {
        internal void add_stock(int id, string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Treasury_name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            da.excutequery("add_stock", param);
            da.close();
        }
        internal void Update_Stock(int id, string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Treasury_name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            da.excutequery("Update_Stock", param);
            da.close();


        }


        internal void Delete_Stock(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("Delete_Stock", param);
            da.close();
        }
        internal DataTable select_Stock()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("select_Stock", null);

            return dt;
        }

        internal DataTable Select_LastIdStock()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("Select_LastIdStock", null);

            return dt;
        }
        internal DataTable Compo_Stock()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Compo_Stock", null);
            return dt;
        }
        internal DataTable Select_moneyStock(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("Select_moneyStock", param);
            return dt;
        }
        internal void add_stockData(int id,decimal Money)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Real);
            param[1].Value = Money;
            da.excutequery("add_stockData", param);
            da.close();
        }

        internal void add_insertStock(int id, decimal money, DateTime date, string name, string type, string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Real);
            param[1].Value = money;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;
            param[4] = new SqlParameter("@Type", SqlDbType.NVarChar, 250);
            param[4].Value = type;
            param[5] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[5].Value = reason;
            da.excutequery("add_insertStock", param);
            da.close();
        }

        internal void Add_StockPull(int id, decimal money, DateTime date, string name, string type, string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Money", SqlDbType.Real);
            param[1].Value = money;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;
            param[4] = new SqlParameter("@Type", SqlDbType.NVarChar, 250);
            param[4].Value = type;
            param[5] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[5].Value = reason;
            da.excutequery("Add_StockPull", param);
            da.close();
        }

        internal void Add_StockTransfair(decimal money, DateTime date, string from, string to, string name, string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Money", SqlDbType.Real);
            param[0].Value = money;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@From_", SqlDbType.NVarChar, 50);
            param[2].Value = from;
            param[3] = new SqlParameter("@To_", SqlDbType.NVarChar, 50);
            param[3].Value = to;
            param[4] = new SqlParameter("@Name", SqlDbType.NVarChar, 75);
            param[4].Value = name;
            param[5] = new SqlParameter("@Reason", SqlDbType.NVarChar, 150);
            param[5].Value = reason;
            da.excutequery("Add_StockTransfair", param);
            da.close();
        }
        internal DataTable Insert_Stock(int Id_Stock)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Insert_Stock", param);
            return dt;
        }
        internal DataTable Search_Insert_Stock(int Id_Stock,DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            param[1] = new SqlParameter("@data_from", SqlDbType.Date);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@data_to", SqlDbType.Date);
            param[2].Value = DateTo;
            dt = da.selected("Search_Insert_Stock", param);
            return dt;
        }
        internal DataTable Report_PullStock(int Id_Stock)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("Report_PullStock", param);
            return dt;
        }
        internal DataTable Search_PullStock(int Id_Stock,DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            param[1] = new SqlParameter("@data_from", SqlDbType.Date);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@data_to", SqlDbType.Date);
            param[2].Value = DateTo;
            dt = da.selected("Search_PullStock", param);
            return dt;


        }
        internal void DeletePullStock(int id_stock, DateTime date, decimal money)
        {

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[0].Value = id_stock;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@Money", SqlDbType.Real);
            param[2].Value = money;
            da.selected("DeletePullStock", param);
            da.close();
        }
        internal void DeleteInsertStock(int id_stock, DateTime date, decimal money)
        {

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_stock", SqlDbType.Int);
            param[0].Value = id_stock;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@Money", SqlDbType.Real);
            param[2].Value = money;
            da.selected("DeletePullStock", param);
            da.close();
        }
        internal void UpdateinsertStockMoney(int id, decimal money)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Stock", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@moeny", SqlDbType.Decimal);
            param[1].Value = money;
            da.excutequery("UpdateinsertStockMoney", param);
            da.close();
        }
        internal void update_StockPull(int id, decimal moneyBeforeEdit,decimal moneyAfterEdit,string reason)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id_Treasury", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@MoneybeforeEdit", SqlDbType.Real);
            param[1].Value = moneyBeforeEdit;
            param[2] = new SqlParameter("@MoneyAfterEdit", SqlDbType.Real);
            param[2].Value = moneyAfterEdit;
            param[3] = new SqlParameter("@Reason", SqlDbType.NVarChar, 250);
            param[3].Value = reason;
            da.excutequery("update_StockPull", param);
            da.close();


        }



        internal void InsertStockMove(decimal Prise,  DateTime Date, string Type, string Bean,int StockID,string userName, string moveStock, int?  IDOrder = null)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Prise", SqlDbType.Decimal);
            param[0].Value = Prise;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
            param[2] = new SqlParameter("@Type", SqlDbType.NVarChar);
            param[2].Value = Type;
            param[3] = new SqlParameter("Bean", SqlDbType.NVarChar);
            param[3].Value = Bean;
       
            param[4] = new SqlParameter("@StockID", SqlDbType.Int);
            param[4].Value = StockID;
            param[5] = new SqlParameter("@userName", SqlDbType.NVarChar,100);
            param[5].Value = userName;
            param[6] = new SqlParameter("@moveStock", SqlDbType.NVarChar, 50);
            param[6].Value = moveStock;
            param[7] = new SqlParameter("@IDOrder", SqlDbType.Int);
            param[7].Value = IDOrder;
            da.excutequery("InsertStockMove", param);
            da.close();
        }

        internal DataTable reportStockMove(int Id_Stock, DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Id_Stock", SqlDbType.Int);
            param[0].Value = Id_Stock;
            param[1] = new SqlParameter("@data_from", SqlDbType.Date);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@data_to", SqlDbType.Date);
            param[2].Value = DateTo;
            dt = da.selected("reportStockMove", param);
            return dt;


        }

        internal DataTable rptDaily( DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
      
            param[0] = new SqlParameter("@data_from", SqlDbType.Date);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.Date);
            param[1].Value = DateTo;
            dt = da.selected("rptDaily", param);
            return dt;


        }


        internal void updateMoney( decimal money)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
       
            param[0] = new SqlParameter("@Money", SqlDbType.Decimal);
            param[0].Value = money;
            da.excutequery("updateMoney", param);
            da.close();
        }

        internal DataTable selectMoney()
        {
            DataAccessLayer da = new DataAccessLayer();
         
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("selectMoney", null);
            return dt;
        }
        internal DataTable Select_MoneyForUsers(string  UserName, DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
            param[0].Value = UserName;
            param[1] = new SqlParameter("@DateFrom", SqlDbType.DateTime);
            param[1].Value = dateFrom;
            param[2] = new SqlParameter("@DateTo", SqlDbType.DateTime);
            param[2].Value = DateTo;
            dt = da.selected("Select_MoneyForUsers", param);
            return dt;
        }

        internal DataTable Select_MoneyForCashir(string UserName, DateTime date, DateTime TimeFrom , DateTime TimeTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;
            param[1] = new SqlParameter("@Date", SqlDbType.Date);
            param[1].Value = date;
            param[2] = new SqlParameter("@TimeFrom", SqlDbType.Time);
            param[2].Value = TimeFrom;
            param[3] = new SqlParameter("@TimeTo", SqlDbType.Time);
            param[3].Value = TimeTo;
            dt = da.selected("Select_MoneyForCashir", param);
            return dt;
        }

        internal DataTable SelectPersonaldrawal(DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@data_from", SqlDbType.Date);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.Date);
            param[1].Value = DateTo;
            dt = da.selected("SelectPersonaldrawal", param);
            return dt;


        }


        internal DataTable SelectRevenueOther(DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@data_from", SqlDbType.Date);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.Date);
            param[1].Value = DateTo;
            dt = da.selected("SelectRevenueOther", param);
            return dt;


        }

        internal DataTable SelectRptStock_tansfair(DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@data_from", SqlDbType.Date);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@data_to", SqlDbType.Date);
            param[1].Value = DateTo;
            dt = da.selected("SelectRptStock_tansfair", param);
            return dt;


        }

        internal DataTable ReportBudgetReview()
        {
            DataAccessLayer da = new DataAccessLayer();

            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("ReportBudgetReview", null);
            return dt;
        }


        internal DataTable ReportIncomestatement(DateTime dateFrom, DateTime DateTo)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@fromDate", SqlDbType.Date);
            param[0].Value = dateFrom;
            param[1] = new SqlParameter("@todate", SqlDbType.Date);
            param[1].Value = DateTo;
            dt = da.selected("ReportIncomestatement", param);
            return dt;


        }

        internal void addSanad(string Type, string UserName, string Name, decimal Money, DateTime Date, string elbayan)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Type", SqlDbType.NVarChar,50);
            param[0].Value = Type;
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
            param[1].Value = UserName;
            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            param[2].Value = Name;
            param[3] = new SqlParameter("@Money", SqlDbType.Decimal);
            param[3].Value = Money;
            param[4] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[4].Value = Date;
            param[5] = new SqlParameter("@elbayan", SqlDbType.NVarChar, 150);
            param[5].Value = elbayan;
            da.excutequery("addSanad", param);
            da.close();
        }
    }
}
