using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplement_Store
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBills frm = new frmBills();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductManage frm = new frmProductManage();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }
    }

    static class Connect
    {
        public static String strConn = "";
        [STAThread]
        static void Main()
        {
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        }
    }
}
