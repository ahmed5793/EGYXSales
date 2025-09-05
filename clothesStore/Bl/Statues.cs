using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clothesStore.BL;
using clothesStore.DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace clothesStore.BL
{
   class Statues
      
    {
       

        public DataTable get_IDName_customser()
        {
            DataAccessLayer dl = new DataAccessLayer();

            dl.open();
          DataTable   dt = new DataTable();
            dt = dl.selected("get_IDName_customers", null);
            dl.close();
            return dt;

        }
      

        public DataTable get_last_id()
        {
            DataAccessLayer dl = new DataAccessLayer();

            dl.open();
            DataTable dt = new DataTable();
            dt = dl.selected("get_last_id", null);
            dl.close();
            return dt;

        }

        public void add_statues(string ACTIVITY,string taxFileNumber,string activityAdress,string commercial,
            string nobond,DateTime date,int cust_id,DateTime dateStartACtivity
            ,DateTime lastTaxCheck , DateTime lastCommittee , string ValueAddedTax  , DateTime ValueAddedTaxDate,string TaxRegistrationNumber)
        {

            DataAccessLayer dl = new DataAccessLayer();
            dl.open();
            SqlParameter[] param = new SqlParameter[13];

      
            param[0] = new SqlParameter("@ACTIVITY   ", SqlDbType.NVarChar, 150);
            param[0].Value = ACTIVITY;
            param[1] = new SqlParameter("@taxFileNumber ", SqlDbType.NVarChar,250);
            param[1].Value = taxFileNumber;
            param[2] = new SqlParameter("@activityAdress   ", SqlDbType.NVarChar, 150);
            param[2].Value = activityAdress;
            param[3] = new SqlParameter("@commercial ", SqlDbType.NVarChar, 250);
            param[3].Value = commercial;
            param[4] = new SqlParameter("@nobond", SqlDbType.NVarChar, 250);
            param[4].Value = nobond;
            param[5] = new SqlParameter("@dateTime ", SqlDbType.DateTime);
            param[5].Value = date;
            param[6] = new SqlParameter("@cust_id ", SqlDbType.Int);
            param[6].Value = cust_id;
            param[7] = new SqlParameter("@dateStartActivity ", SqlDbType.DateTime);
            param[7].Value = dateStartACtivity;
            param[8] = new SqlParameter("@lastTaxCheck ", SqlDbType.Date);
            param[8].Value = lastTaxCheck;
            param[9] = new SqlParameter("@lastCommittee ", SqlDbType.Date);
            param[9].Value = lastCommittee;
            param[10] = new SqlParameter("@ValueAddedTax ", SqlDbType.NVarChar,50);
            param[10].Value = ValueAddedTax;
            param[11] = new SqlParameter("@ValueAddedTaxDate ", SqlDbType.Date);
            param[11].Value = ValueAddedTaxDate;
            param[12] = new SqlParameter("@TaxRegistrationNumber ", SqlDbType.NVarChar, 50);
            param[12].Value = TaxRegistrationNumber;
            dl.excutequery("add_statues", param);
            dl.close();

        }

        public DataTable get_all_statu_show()
        {
            DataAccessLayer dl = new DataAccessLayer();

            dl.open();
            DataTable dt = new DataTable();
            dt = dl.selected("get_all_statues_show", null);
            dl.close();
            return dt;

        }
        public void update_statues(string ACTIVITY, int taxFileNumber, string activityAdress, int commercial, 
            int nobond, DateTime date,DateTime dateStartActivity,int id
            , DateTime lastTaxCheck, DateTime lastCommittee, string ValueAddedTax, DateTime ValueAddedTaxDate,string TaxRegistrationNumber)
        {

            DataAccessLayer dl = new DataAccessLayer();
            dl.open();
            SqlParameter[] param = new SqlParameter[13];


            param[0] = new SqlParameter("@ACTIVITY", SqlDbType.NVarChar, 150);
            param[0].Value = ACTIVITY;
            param[1] = new SqlParameter("@taxFileNumber ", SqlDbType.Int);
            param[1].Value = taxFileNumber;
            param[2] = new SqlParameter("@activityAdress   ", SqlDbType.NVarChar, 150);
            param[2].Value = activityAdress;
            param[3] = new SqlParameter("@commercial ", SqlDbType.Int);
            param[3].Value = commercial;
            param[4] = new SqlParameter("@nobond", SqlDbType.Int);
            param[4].Value = nobond;

            param[5] = new SqlParameter("@dateTime", SqlDbType.DateTime);
            param[5].Value = date;
            param[6] = new SqlParameter("@dateStarActivity", SqlDbType.DateTime);
            param[6].Value = dateStartActivity;

            param[7] = new SqlParameter("@id ", SqlDbType.Int);
            param[7].Value = id;
            param[8] = new SqlParameter("@lastTaxCheck ", SqlDbType.Date);
            param[8].Value = lastTaxCheck;
            param[9] = new SqlParameter("@lastCommittee ", SqlDbType.Date);
            param[9].Value = lastCommittee;
            param[10] = new SqlParameter("@ValueAddedTax ", SqlDbType.NVarChar,50);
            param[10].Value = ValueAddedTax;
            param[11] = new SqlParameter("@ValueAddedTaxDate ", SqlDbType.Date);
            param[11].Value = ValueAddedTaxDate;
            param[12] = new SqlParameter("@TaxRegistrationNumber ", SqlDbType.NVarChar, 50);
            param[12].Value = TaxRegistrationNumber;
            dl.excutequery("update_statues", param);
            dl.close();

        }
        public DataTable search_statues(string id)
        {


            DataAccessLayer dl = new DataAccessLayer();

            dl.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,150);
            param[0].Value = id;

            dt = dl.selected("search_statues", param);
            dl.close();
            return dt;
        }

        public DataTable delete_statues(int id)
        {


            DataAccessLayer dl = new DataAccessLayer();

            dl.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dl.selected("delete_statues", param);
            dl.close();
            return dt;
        }

    }
}
