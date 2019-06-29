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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string tc;
        sqlconnection scn = new sqlconnection();
        
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            // name and surname withdrawal
            SqlCommand command = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", scn.connection());
            command.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNS.Text = dr[0] + " " + dr[1];
            }
            scn.connection().Close();
            // Appointment History withdrawal
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, scn.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            // Branchs withdrawal
            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", scn.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbranch.Items.Add(dr2[0]);
            }
            scn.connection().Close();
        }

        private void comboBoxbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxdoctor.Items.Clear();
            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", scn.connection());
            command.Parameters.AddWithValue("@p1", comboBoxbranch.Text);
            SqlDataReader dr3 = command.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxdoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            scn.connection().Close();
        }

        private void comboBoxdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + comboBoxbranch.Text + "'"+ " and Randevudoktor='" + comboBoxdoctor + "' and RandevuDurum=0", scn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUpdateInformation fr = new FrmUpdateInformation();
            fr.TCno = lblTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Randevular set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where Randevuid=@p3", scn.connection());
            command.Parameters.AddWithValue("@p1", lblTc.Text);
            command.Parameters.AddWithValue("@p2", richTextBoxcomplaint.Text);
            command.Parameters.AddWithValue("@p3", textBoxid.Text);
            command.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Appointment Received", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
