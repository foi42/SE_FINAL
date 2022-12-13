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
    public partial class frmSupplilers : Form
    {
        public frmSupplilers()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection(Connect.strConn);
        private void frmSupplilers_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SUPPLIER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                String SuppID = Convert.ToString(row.Cells[0].Value);
                String SuppName = Convert.ToString(row.Cells[1].Value);
                String SuppPhone = Convert.ToString(row.Cells[2].Value);

                //update UI
                txtSuppID.Text = SuppID;
                txtSuppName.Text = SuppName;
                txtSuppPhone.Text = SuppPhone;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=POPCORN11\QUANGHUY; Initial Catalog=SUPPLEMENT_STORE; Integrated Security=True";
            conn.Open();
            String sSQL = "INSERT INTO SUPPLIER(SuppID, SName, phone) VALUES (@SuID, @SuName, @SuPhone)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add("@SuID", txtSuppID.Text);
            cmd.Parameters.Add("@SuName", txtSuppName.Text);
            cmd.Parameters.Add("@SuPhone", txtSuppPhone.Text);
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
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=POPCORN11\QUANGHUY; Initial Catalog=SUPPLEMENT_STORE; Integrated Security=True";
            conn.Open();
            String sSQL = "UPDATE SUPPLIER SET SName=@SuName, phone=@SuPhone WHERE SuppID=@SuID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add("@SuID", txtSuppID.Text);
            cmd.Parameters.Add("@SuName", txtSuppName.Text);
            cmd.Parameters.Add("@SuPhone", txtSuppPhone.Text);
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
            var confirmResult = MessageBox.Show("Are you sure to delete? ", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"Data Source=POPCORN11\QUANGHUY; Initial Catalog=SUPPLEMENT_STORE; Integrated Security=True";
                conn.Open();
                String sSQL = "DELETE FROM SUPPLIER WHERE SuppID=@SuID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add("@SuID", txtSuppID.Text);
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
    }
}
