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
    public partial class frmAgencies : Form
    {
        public frmAgencies()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection(Connect.strConn);
        private void frmAgencies_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM AGENCY", conn);
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
                String AgenID = Convert.ToString(row.Cells[0].Value);
                String AgenName = Convert.ToString(row.Cells[1].Value);
                String AgenPhone = Convert.ToString(row.Cells[2].Value);

                //update UI
                txtAgenID.Text = AgenID;
                txtAgenName.Text = AgenName;
                txtAgenPhone.Text = AgenPhone;

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
            String sSQL = "INSERT INTO AGENCY(AgenID, AgenName, phone) VALUES (@AgID, @AgName, @AgPhone)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add("@AgID", txtAgenID.Text);
            cmd.Parameters.Add("@AgName", txtAgenName.Text);
            cmd.Parameters.Add("@AgPhone", txtAgenPhone.Text);
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
            String sSQL = "UPDATE AGENCY SET AgenName=@AgName, phone=@AgPhone WHERE AgenID=@AgID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add("@AgID", txtAgenID.Text);
            cmd.Parameters.Add("@AgName", txtAgenName.Text);
            cmd.Parameters.Add("@AgPhone", txtAgenPhone.Text);
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
                String sSQL = "DELETE FROM AGENCY WHERE AgenID=@AgID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add("@AgID", txtAgenID.Text);
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
