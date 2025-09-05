using clothesStore.PL;
using System;
using System.Windows.Forms;

namespace clothesStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        internal static string salesman;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //
           // Application.Run(new FRM_CONFIG () );
          // Application.Run(new Frm_NewLogin () );
            // Application.Run(new FormStatues () );
             Application.Run(new clothesStore.Serila.Home () );
            //  Application.Run(new Frm_UpdateSales () );
            // Application.Run(new Frm_UpdatePurchasesDoors () );



        }
    }
}
