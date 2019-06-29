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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string tc;
        sqlconnection scn = new sqlconnection();

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            SqlCommand commandcreate = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", scn.connection());
            commandcreate.Parameters.AddWithValue("@d1", richTextBoxCannoun.Text);
            commandcreate.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Announcement Created.");

        }

        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            // name and surname withdrawal
            SqlCommand command = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", scn.connection());
            command.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNS.Text = dr[0].ToString();
            }
            scn.connection().Close();

            // Branchs datagrid transfer
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", scn.connection());
            da.Fill(dt);
            dataGridViewbranchs.DataSource = dt;

            // doctors datagrid transfer
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", scn.connection());
            da1.Fill(dt1);
            dataGridViewdoctors.DataSource = dt1;

            // Branchs ComboBox transfer
            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", scn.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbranch.Items.Add(dr2[0]);
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values(@r1, @r2, @r3, @r4)", scn.connection());
            commandsave.Parameters.AddWithValue("@r1", maskedTextBoxdate.Text);
            commandsave.Parameters.AddWithValue("@r2", maskedTextBoxhour.Text);
            commandsave.Parameters.AddWithValue("@r3", comboBoxbranch.Text);
            commandsave.Parameters.AddWithValue("@r4", comboBoxdoctor.Text);
            commandsave.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Appointment created.");
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

        private void buttonDpanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frd = new FrmDoctorPanel();
            frd.Show();
        }

        private void buttonbpanel_Click(object sender, EventArgs e)
        {
            FrmBranch frb = new FrmBranch();
            frb.Show();
        }

        private void buttonAlist_Click(object sender, EventArgs e)
        {
            FrmAppointmentList fra = new FrmAppointmentList();
            fra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fra = new FrmAnnouncements();
            fra.Show();
        }
    }
}
