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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlconnection scn = new sqlconnection();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doktorlar", scn.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", scn.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                combobranch.Items.Add(dr2[0]);
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values(@d1, @d2, @d3, @d4, @d5)", scn.connection());
            commandsave.Parameters.AddWithValue("@d1", textname.Text);
            commandsave.Parameters.AddWithValue("@d2", textsurname.Text);
            commandsave.Parameters.AddWithValue("@d3", combobranch.Text);
            commandsave.Parameters.AddWithValue("@d4", maskedTextTC.Text);
            commandsave.Parameters.AddWithValue("@d5", textpassword.Text);
            commandsave.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Doctor saved.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textsurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            combobranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            maskedTextTC.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            textpassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            SqlCommand commanddelete = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@d1", scn.connection());
            commanddelete.Parameters.AddWithValue("@d1", maskedTextTC.Text);
            commanddelete.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Doctor deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3, DoktorSifre=@d4 where DoktorTC=@d5", scn.connection());
            command.Parameters.AddWithValue("@d1", textname.Text);
            command.Parameters.AddWithValue("@d2", textsurname.Text);
            command.Parameters.AddWithValue("@d3", combobranch.Text);
            command.Parameters.AddWithValue("@d4", textpassword.Text);
            command.Parameters.AddWithValue("@d5", maskedTextTC.Text);
            command.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Doctor Updated.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}