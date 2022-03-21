using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clothesStore.DAL;
using System.Data;
using System.Data.SqlClient;
namespace clothesStore.Bl
{
    class deleteAll
    {
        internal DataTable deleteAllTable()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("deleteAllTable", null);
            da.close();
            return dt;
        }

        internal DataTable deleteAllMoveTbale()
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            dt = da.selected("deleteAllMoveTbale", null);
            da.close();
            return dt;
        }
    }
}
