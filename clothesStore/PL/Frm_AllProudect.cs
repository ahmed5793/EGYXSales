using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using clothesStore.Bl;
using System.IO;

namespace clothesStore.PL
{
    public partial class Frm_AllProudect : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Proudect p = new Proudect();

        public Frm_AllProudect()
        {
            InitializeComponent();
            checkEdit1.EditValue = false;
            txt_pay.Enabled = false;
        }
        DataTable dt = new DataTable();
   

        private void btnSearchItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dt = p.PrintAllProudects();
            gridControl1.DataSource = dt;
        }

        private void btnAllPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
            else
            {
                MessageBox.Show("لا يوجد أصناف للطباعة");
            }
        }
   
 

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {

                    if ((bool)checkEdit1.EditValue == true)
                    {
                        if (string.IsNullOrWhiteSpace(txt_pay.EditValue.ToString()))
                        {
                            return;
                        }

                        for (int i = 0; i < gridView1.DataRowCount; i++)
                        {

                            if (gridView1.IsRowSelected(i))
                            {


                                DataSet1 ds = new DataSet1(); DataRow row = gridView1.GetDataRow(i);

                                if (Properties.Settings.Default.BarcodeSize == "مقاس كبير ")
                                {

                                    Rpt.Rpt_Large_Barcode cr = new Rpt.Rpt_Large_Barcode();
                                    ds.Tables[0].Rows.Add(row[1].ToString(), "*" + row[8].ToString().Trim() + "*", row[8].ToString(), row[4].ToString());
                                    cr.SetDataSource(ds);
                                    Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                                    frm.crystalReportViewer1.ReportSource = cr;
                                    frm.crystalReportViewer1.Refresh();
                                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                    cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintBarcode;
                                    //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                                    cr.PrintToPrinter(Convert.ToInt32(txt_pay.EditValue), true, 0, 0);
                                }
                                else if (Properties.Settings.Default.BarcodeSize == "مقاس وسط ")
                                {


                                    Rpt.Rpt_MidBarcode cr = new Rpt.Rpt_MidBarcode();
                                    ds.Tables[0].Rows.Add(row[1].ToString(), "*" + row[8].ToString().Trim() + "*", row[8].ToString(), row[4].ToString());
                                    cr.SetDataSource(ds);
                                    Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                                    frm.crystalReportViewer1.ReportSource = cr;
                                    frm.crystalReportViewer1.Refresh();
                                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                    cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintBarcode;
                                    //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                                    cr.PrintToPrinter(Convert.ToInt32(txt_pay.EditValue), true, 0, 0);
                                }


                                else
                                {
                                    MessageBox.Show("لابد من اختيار صنف واحد على الاقل");
                                }
                            }
                            //MessageBox.Show(gridView1.GetRowCellValue(i, "ID_Prod").ToString());
                        }

                    }
                    else
                    {

                        for (int i = 0; i < gridView1.DataRowCount; i++)
                        {


                            if (gridView1.IsRowSelected(i))
                            {
                                DataRow row = gridView1.GetDataRow(i);


                                DataSet1 ds = new DataSet1();

                                if (Properties.Settings.Default.BarcodeSize == "مقاس كبير ")
                                {


                                    Rpt.Rpt_Large_Barcode cr = new Rpt.Rpt_Large_Barcode();
                                    ds.Tables[0].Rows.Add(row[1].ToString(), "*" + row[8].ToString().Trim() + "*", row[8].ToString(), row[4].ToString());
                                    cr.SetDataSource(ds);
                                    Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                                    frm.crystalReportViewer1.ReportSource = cr;
                                    frm.crystalReportViewer1.Refresh();
                                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                    cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintBarcode;
                                    //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                                    cr.PrintToPrinter(Convert.ToInt32(row[3]), true, 0, 0);
                                }
                                else if (Properties.Settings.Default.BarcodeSize == "مقاس وسط ")
                                {


                                    Rpt.Rpt_MidBarcode cr = new Rpt.Rpt_MidBarcode();
                                    ds.Tables[0].Rows.Add(row[1].ToString(), "*" + row[8].ToString().Trim() + "*", row[8].ToString(), row[4].ToString());
                                    cr.SetDataSource(ds);
                                    Rpt.FrmSingleReport frm = new Rpt.FrmSingleReport();
                                    frm.crystalReportViewer1.ReportSource = cr;
                                    frm.crystalReportViewer1.Refresh();
                                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                    cr.PrintOptions.PrinterName = Properties.Settings.Default.PrintBarcode;
                                    //cr.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                                    cr.PrintToPrinter(Convert.ToInt32(row[3]), true, 0, 0);
                                }


                                else
                                {
                                    MessageBox.Show("لابد من اختيار صنف واحد على الاقل");
                                }
                            }
                            //MessageBox.Show(gridView1.GetRowCellValue(i, "ID_Prod").ToString());
                        }

                    }



                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void checkEdit1_EditValueChanged(object sender, EventArgs e)
        {

            if ((bool)checkEdit1.EditValue == true)
            {
                txt_pay.Enabled = true;
            }
            else
            {
                txt_pay.Enabled = false;
                txt_pay.EditValue = "";
            }
        }
    }
}