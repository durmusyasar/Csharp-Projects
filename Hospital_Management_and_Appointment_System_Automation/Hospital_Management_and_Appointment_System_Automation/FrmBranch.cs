using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_and_Appointment_System_Automation
{
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }
        sqlconnection scn = new sqlconnection();
        private void FrmBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", scn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            SqlCommand commandadd = new SqlCommand("insert into Tbl_Branslar (BransAd) values(@b1)", scn.connection());
            commandadd.Parameters.AddWithValue("@b1", textname.Text);
            commandadd.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Branch added.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            SqlCommand commanddelete = new SqlCommand("delete from Tbl_Branslar where Bransid=@b1", scn.connection());
            commanddelete.Parameters.AddWithValue("@b1", textid.Text);
            commanddelete.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Branch deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Branslar set BransAd=@b1 where Bransid=@b2", scn.connection());
            command.Parameters.AddWithValue("@b1", textname.Text);
            command.Parameters.AddWithValue("@b2", textid.Text);
            command.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Branch Updated.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
