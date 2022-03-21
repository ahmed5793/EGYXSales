using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clothesStore.Bl;

namespace clothesStore.PL
{
    public partial class frm_PrintAllBarcode : DevExpress.XtraEditors.XtraForm
    {
        Proudect p = new Proudect();
        public frm_PrintAllBarcode()
        {
            InitializeComponent();
            gridControl1.DataSource=p.selectProudectByBarcode();
        }

        private void frm_PrintAllBarcode_Load(object sender, EventArgs e)
        {
            txt_pay.Enabled = false;
        }

        private void Btn_PrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                   
                    if (checkEdit1.Checked==true)
                    {
                        if (txt_pay.Text=="0" ||txt_pay.Text=="")
                        {
                            return;
                        }
                       
                        for (int i = 0; i < gridView1.DataRowCount; i++)
                        {
                           
                            if (gridView1.IsRowSelected(i))
                            {
                     

                                DataSet1 ds = new DataSet1();           DataRow row = gridView1.GetDataRow(i);

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
                                    cr.PrintToPrinter(Convert.ToInt32(txt_pay.Text), true, 0, 0);
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
                                    cr.PrintToPrinter(Convert.ToInt32(txt_pay.Text), true, 0, 0);
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

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                txt_pay.Enabled = true;
            }
            else
            {
                txt_pay.Enabled = false ;
                txt_pay.Text = "";
            }
        }

        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' )
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = p.selectProudectByBarcode();
        }
    }
}