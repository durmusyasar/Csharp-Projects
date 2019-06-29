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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }

        public string tc;
        sqlconnection scn = new sqlconnection();

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            // name and surname withdrawal
            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@d1", scn.connection());
            command.Parameters.AddWithValue("@d1", lblTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNS.Text = dr[0] + " " + dr[1];
            }
            scn.connection().Close();

            // Appointment History withdrawal
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lblNS.Text + "'", scn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            FrmDoctorInfoEdit frde = new FrmDoctorInfoEdit();
            frde.TCNO = lblTc.Text;
            frde.Show();
        }

        private void buttonannouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fra = new FrmAnnouncements();
            fra.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
