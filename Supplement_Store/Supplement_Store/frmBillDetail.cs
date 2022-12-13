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
    public partial class frmBillDetail : Form
    {
        public frmBillDetail()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection(Connect.strConn);
        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daBD = new SqlDataAdapter("SELECT * FROM BILL_DETAIL", conn);
            SqlDataAdapter daB = new SqlDataAdapter("SELECT * FROM BILL", conn);
            SqlDataAdapter daP = new SqlDataAdapter("SELECT * FROM PRODUCT", conn);
            DataTable dt = new DataTable();
            daBD.Fill(dt);
            dataGridView1.DataSource = dt;

            DataSet dsB, dsP;
            dsB = new DataSet();
            dsP = new DataSet();
            daB.Fill(dsB);
            daP.Fill(dsP);
            txtBillID.DataSource = dsB.Tables[0];
            txtBillID.DisplayMember = dsB.Tables[0].Columns[0].ToString();

            txtProdID.DataSource = dsP.Tables[0];
            txtProdID.DisplayMember = dsP.Tables[0].Columns[0].ToString();
        }

        private void txtProdID_SelectedValueChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ProID='" +txtProdID.Text+"'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtProdName.Text = dr[1].ToString();
                txtProdUnit.Text = dr[2].ToString();
                txtProdPrice.Text = dr[3].ToString();
            }
            conn.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                String IDDetail = Convert.ToString(row.Cells[0].Value);
                String BillID = Convert.ToString(row.Cells[1].Value);
                String ProID = Convert.ToString(row.Cells[2].Value);
                String ProQty = Convert.ToString(row.Cells[3].Value);

                //update UI
                txtBillID.Text = BillID;
                txtBillDeID.Text = IDDetail;
                txtProdID.Text = ProID;
                txtProdQty.Text = ProQty;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
