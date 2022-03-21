using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clothesStore.DAL;
using System.Data.SqlClient;
using System.Data;

namespace clothesStore.Bl
{
    class Asol
    {
        internal void AddAsol(string Asl,decimal value,DateTime date)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Asl", SqlDbType.NVarChar,150);
            param[0].Value = Asl;
            param[1] = new SqlParameter("@Value", SqlDbType.Decimal);
            param[1].Value = value;
            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = date;
            da.excutequery("AddAsol", param);
            da.close();
        }

        internal void UpdateAsol(string Asl, decimal value, DateTime date,int ID)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Asl", SqlDbType.NVarChar, 150);
            param[0].Value = Asl;
            param[1] = new SqlParameter("@Value", SqlDbType.Decimal);
            param[1].Value = value;
            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = date;
            param[3] = new SqlParameter("@ID", SqlDbType.Int);
            param[3].Value = ID;
            da.excutequery("UpdateAsol", param);
            da.close();
        }


        internal void DeleteAsol( int ID)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
          
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            da.excutequery("DeleteAsol", param);
            da.close();
        }

        internal DataTable SelectAsol()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("SelectAsol", null);
            da.close();
            return dt;
        }

        internal DataTable SelectAsolByID(int idAsol)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@idAsl", SqlDbType.Int);
            param[0].Value = idAsol;
            DataTable dt = new DataTable();
            dt = da.selected("SelectAsolByID", param);
            da.close();
            return dt;
        }

        internal void AddEhlakatAsol(int Asl_ID,  decimal Ehalak_Value, DateTime Date)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Asl_ID", SqlDbType.Int);
            param[0].Value = Asl_ID;
            param[1] = new SqlParameter("@Ehalak_Value", SqlDbType.Decimal);
            param[1].Value = Ehalak_Value;
            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = Date;
          
            da.excutequery("AddEhlakatAsol", param);
            da.close();
        }
        internal void UpdateEhlakatAsol(int Asl_ID, decimal Ehalak_Value, DateTime Date,int ID_Ehlak)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Asl_ID", SqlDbType.Int);
            param[0].Value = Asl_ID;
            param[1] = new SqlParameter("@Ehalak_Value", SqlDbType.Decimal);
            param[1].Value = Ehalak_Value;
            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = Date;
            param[3] = new SqlParameter("@ID_Ehlak", SqlDbType.Int);
            param[3].Value = ID_Ehlak;

            da.excutequery("UpdateEhlakatAsol", param);
            da.close();
        }

        internal void DeleteEhlakatAsol( int ID_Ehlak)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
          
            param[0] = new SqlParameter("@ID_Ehlak", SqlDbType.Int);
            param[0].Value = ID_Ehlak;

            da.excutequery("DeleteEhlakatAsol", param);
            da.close();
        }
        internal DataTable selectEhlakatAsol()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("selectEhlakatAsol", null);
            da.close();
            return dt;
        }



        internal DataTable SelectEhalakAsolByDate(DateTime fromDate,DateTime ToDate)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            da.open();
            param[0] = new SqlParameter("@fromDate", SqlDbType.Date);
            param[0].Value = fromDate;
            param[1] = new SqlParameter("@ToDate", SqlDbType.Date);
            param[1].Value = ToDate;
            DataTable dt = new DataTable();
            dt = da.selected("SelectEhalakAsolByDate", param);
            da.close();
            return dt;
        }

    }
}
