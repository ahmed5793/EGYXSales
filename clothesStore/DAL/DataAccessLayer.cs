using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace clothesStore.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;
        internal DataAccessLayer()
        {
            if (Properties.Settings.Default.Mode == "SQL")
            {
                con = new SqlConnection($"Data Source={Properties.Settings.Default.Server}; database={Properties.Settings.Default.Database};User Id={Properties.Settings.Default.ID};Password={Properties.Settings.Default.Password};MultipleActiveResultSets=True;Max Pool Size=200;");
               // "Data Source=SQL5088.site4now.net;Initial Catalog=db_a54a03_egyxsales;User Id=db_a54a03_egyxsales_admin;Password=Titonasser1994

            }
            else
            {
                con = new SqlConnection($"server ={Properties.Settings.Default.Server}; database={Properties.Settings.Default.Database};integrated security=true");

            }
            //   con = new SqlConnection(@"Data Source=SQL5078.site4now.net;Initial Catalog=DB_A54A03_SalesDoor;User Id=DB_A54A03_SalesDoor_admin;Password=@TitoNasser1994");


        }

        internal void open()
        {
            try {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                
            }

        }
        internal void close()
        {
            try {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        SqlCommand cm = new SqlCommand();
        internal DataTable selected(string storedProcedure,SqlParameter[]param)
        {
        
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedProcedure;
            cm.Connection = con;
            if (param!=null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cm.Parameters.Add(param[i]);
                }

            }
            SqlDataAdapter adabt = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adabt.Fill(dt);
            return dt;
        }

        internal void excutequery (string storedProcedure,SqlParameter[]param)
        {
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedProcedure;
            cm.Connection = con;
            if (param!=null)
            {
                cm.Parameters.AddRange(param);
            }
            cm.ExecuteNonQuery();           
        }
    
    }
}
