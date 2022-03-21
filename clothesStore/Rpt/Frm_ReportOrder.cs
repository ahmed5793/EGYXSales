using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothesStore.Rpt
{
    public partial class Frm_ReportOrder : Form
    {
       ///* public string reportName =*/ "";
       // ReportDocument cryrpt;
        public Frm_ReportOrder()
        {
            InitializeComponent();
        }
        //public ReportDocument GetReportDocuments(string RptName)
        //{
        //    var Rpt = new ReportDocument();
        //    string rptPath = @"c:\RPT\"+RptName;
        //    Rpt.Load(rptPath);
         
        //    return Rpt;
        //}
        //void PrintInvoice(string RptRptName)
        //{




        //    cryrpt = GetReportDocuments(RptRptName);

        //    crystalReportViewer1.ReportSource = cryrpt;

        //}
        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
        
        }

        private void Frm_ReportOrder_Load(object sender, EventArgs e)
        {
            //PrintInvoice(reportName);
        }
    }
}
