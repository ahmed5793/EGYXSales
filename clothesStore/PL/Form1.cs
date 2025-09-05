using clothesStore.PL;
using System;
using System.Windows.Forms;


namespace clothesStore.PL

{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_SelectProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text==Properties.Settings.Default.Configration_Pass)
                {
                    FRM_CONFIG fc = new FRM_CONFIG();
                    fc.Show();
                    this.Close();
                  
                }
                else
                {
                    MessageBox.Show("The password is incorrect");
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}
