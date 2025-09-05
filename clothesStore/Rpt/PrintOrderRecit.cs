using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.SqlClient;

using DevExpress.ClipboardSource.SpreadsheetML;

using System.IO;

namespace clothesStore.Rpt

{
    public partial class PrintOrderRecit : DevExpress.XtraReports.UI.XtraReport
    {
      
      

        
        public PrintOrderRecit()
        {
            
            InitializeComponent();
         
                
        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void PrintOrderDelivery_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
