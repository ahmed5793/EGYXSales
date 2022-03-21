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
    public partial class Frm_MoveProduct : Form
    {
        Proudect p = new Proudect();
        Category C = new Category();
        DataTable dt5 = new DataTable();
        
                void ComboProduct()
                {
                    Cmb_product.DataSource = p.Select_ProductFormStoreForSale();
                    Cmb_product.DisplayMember = "Name_Prod";
                    Cmb_product.ValueMember = "ID_Prod";
                }
      

        public Frm_MoveProduct()
        {
            InitializeComponent();
            ComboProduct();
          //  ComboCategory();
          // gridControl1.DataSource = p.SelectMovePorduct();
        }

        private void Frm_MoveProduct_Load(object sender, EventArgs e)
        {
            DateFrom.Value = DateTime.Now;
            DateTo.Value = DateTime.Now;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_product.Text != "" && Cmb_product.SelectedValue != null)
                {

                    dt5 = p.SearchMovePorduct((DateFrom.Value), DateTo.Value, Convert.ToInt32(Cmb_product.SelectedValue));
                    gridControl1.DataSource = dt5;
                }
                else
                {
                    MessageBox.Show("لا بد من تحديد الصنف اولا لمتابعة حركة الصنف ");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
            }
           
        }

        private void Cmb_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}
