using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supplement_Store
{
    public partial class frmBills : Form
    {
        public frmBills()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection(Connect.strConn);
        private void frmBills_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BILL",conn);
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM ACCOUNTANT", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            da2.Fill(ds);
            dataGridView1.DataSource = dt;
            txtAccountantID.DataSource = ds.Tables[0];
            txtAccountantID.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBillDetail frm = new frmBillDetail();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                String BillID = Convert.ToString(row.Cells[0].Value);
                String SuppID = Convert.ToString(row.Cells[1].Value);
                String AgenID = Convert.ToString(row.Cells[2].Value);
                String AccID = Convert.ToString(row.Cells[3].Value);
                String BType = Convert.ToString(row.Cells[4].Value);
                DateTime BDate = Convert.ToDateTime(row.Cells[5].Value);
                //String BDate = Convert.ToString(row.Cells[5].Value);
                String Total = Convert.ToString(row.Cells[6].Value);

                //update UI
                if (SuppID != "")
                {
                    suppRBTN.Checked = true;
                    ID_supp_agen.Text = SuppID;
                }
                else if (AgenID != "")
                {
                    agenRBTN.Checked = true;
                    ID_supp_agen.Text = AgenID;
                }
                txtBillID.Text = BillID;
                txtBillDate.Value = BDate;
                txtAccountantID.Text = AccID;
                txtTotal.Text = Total;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        private void suppRBTN_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SUPPLIER", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ID_supp_agen.DataSource = ds.Tables[0];
            ID_supp_agen.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }

        private void agenRBTN_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM AGENCY", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ID_supp_agen.DataSource = ds.Tables[0];
            ID_supp_agen.DisplayMember = ds.Tables[0].Columns[0].ToString();
        }

        private void allBillRBTN_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BILL", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void billImRBTN_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BILL WHERE billType = 'import'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void billExRBTN_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BILL WHERE billType = 'export'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check bill type and check supplier or agency
            String BillID = "", BillType = "", Supplier = "", Agency = "";
            String sSQL = "";
            if (suppRBTN.Checked == true)
            {
                BillID = "dbo.fn_autoIDBill('I')";
                BillType = "import";
                Supplier = ID_supp_agen.Text;
                sSQL = "INSERT INTO BILL VALUES ("+BillID+", '"+Supplier+"', null, '"+ txtAccountantID.Text + "', '"+BillType+"', GETDATE(), "+ Convert.ToDouble(txtTotal.Text) + ")";
            }
            else if (agenRBTN.Checked == true)
            {
                BillID = "dbo.fn_autoIDBill('E')";
                BillType = "export";
                Agency = ID_supp_agen.Text;
                sSQL = "INSERT INTO BILL VALUES ("+BillID+", null, '"+Agency+"', '"+txtAccountantID.Text+"', '"+BillType+"', GETDATE(), "+Convert.ToDouble(txtTotal.Text) + ")";
            }

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=POPCORN11\QUANGHUY; Initial Catalog=SUPPLEMENT_STORE; Integrated Security=True";
            //conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Add successfully!");
            dataGridView1.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // check bill type and check supplier or agency
            String BillID = txtBillID.Text;
            //DateTime bdate = DateTime.Parse(txtBillDate.Value.Date.ToString());
            String bdate = txtBillDate.Value.ToString("yyyy-MM-dd");
            String BillType = "", Supplier = "", Agency = "";
            String sSQL = "";
            if (suppRBTN.Checked == true)
            {
                BillType = "import";
                Supplier = ID_supp_agen.Text;
                sSQL = "UPDATE BILL " +
                        "SET SuppID='" + Supplier + "', AgenID=null, AccID='" + txtAccountantID.Text + "', billType='" + BillType + "', Bdate='"+ bdate + "', total=" + Convert.ToDouble(txtTotal.Text)+
                        "WHERE Bill_ID = @BillID";
            }
            else if (agenRBTN.Checked == true)
            {
                BillType = "export";
                Agency = ID_supp_agen.Text;
                sSQL = "UPDATE BILL " +
                        "SET SuppID=null, AgenID='"+Agency+"', AccID='" + txtAccountantID.Text + "', billType='" + BillType + "', Bdate='" + bdate + "', total=" + Convert.ToDouble(txtTotal.Text)+
                        "WHERE Bill_ID = @BillID";
            }

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=POPCORN11\QUANGHUY; Initial Catalog=SUPPLEMENT_STORE; Integrated Security=True";
            //conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add("@BillID", BillID);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Edit successfully!");
            dataGridView1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will delete Bill with Bill Detail. Are you sure to delete? ", "Confirm Delete!!",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                String BillID = txtBillID.Text;
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"Data Source=POPCORN11\QUANGHUY; Initial Catalog=SUPPLEMENT_STORE; Integrated Security=True";
                //conn.Close();
                conn.Open();
                String sSQL = "DELETE FROM BILL_DETAIL WHERE Bill_ID = @BillID; DELETE FROM BILL WHERE Bill_ID = @BillID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add("@BillID", BillID);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error:" + ex.Message);
                }
                MessageBox.Show("Delete successfully!");
                dataGridView1.Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suppFormBtn_Click(object sender, EventArgs e)
        {
            frmSupplilers frm = new frmSupplilers();
            frm.ShowDialog();
        }

        private void agenFormBtn_Click(object sender, EventArgs e)
        {
            frmAgencies frm = new frmAgencies();
            frm.ShowDialog();
        }
    }
}
