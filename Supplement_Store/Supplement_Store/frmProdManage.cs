using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplement_Store
{
    public partial class frmProductManage : Form
    {
        public frmProductManage()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection(Connect.strConn);
        private void ProductManage_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sSQL = "SELECT * FROM PRODUCT";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }
    }
}
