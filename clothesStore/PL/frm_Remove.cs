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
   
    public partial class frm_Remove : DevExpress.XtraEditors.XtraForm
    {
        deleteAll d = new deleteAll();
        Login l = new Login();
        public frm_Remove()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rdb_all.Checked==true)
            {
                if (MessageBox.Show("هل انت متأكد من تنفيذ هذة العملية/هذة العملية ستؤدي الي حذف الداتا الموجودة","تنبية",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                {
                    d.deleteAllTable();
                    MessageBox.Show("تم مسح كل الداتا بنجاح");

                    l.addMoveUser(Program.salesman, this.Text, $" مسح كل الداتا ");

                }

            }

            else if(rdb_move.Checked==true)
            {
                if (MessageBox.Show("هل انت متأكد من تنفيذ هذة العملية/هذة العملية ستؤدي الي حذف الداتا الموجودة", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    d.deleteAllMoveTbale();
                    MessageBox.Show("تم مسح الحركات  بنجاح");
                    l.addMoveUser(Program.salesman, this.Text, $" مسح الحركات ");

                }
            }
        }
    }
}