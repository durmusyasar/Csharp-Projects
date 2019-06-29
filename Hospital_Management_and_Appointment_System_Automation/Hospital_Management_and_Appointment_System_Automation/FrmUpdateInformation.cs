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
    public partial class FrmUpdateInformation : Form
    {
        public FrmUpdateInformation()
        {
            InitializeComponent();
        }
        
        public string TCno;
        sqlconnection scn = new sqlconnection();

        private void FrmUpdateInformation_Load(object sender, EventArgs e)
        {
            maskedTextTC.Text = TCno;
            SqlCommand command = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", scn.connection());
            command.Parameters.AddWithValue("@p1", maskedTextTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textname.Text = dr[1].ToString();
                textsurname.Text = dr[2].ToString();
                maskedTextPhone.Text = dr[4].ToString();
                textpassword.Text = dr[5].ToString();
                comboGender.Text = dr[6].ToString();
            }
            scn.connection().Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTc=@p6", scn.connection());
            command.Parameters.AddWithValue("@p1", textname.Text);
            command.Parameters.AddWithValue("@p2", textsurname.Text);
            command.Parameters.AddWithValue("@p3", maskedTextPhone.Text);
            command.Parameters.AddWithValue("@p4", textpassword.Text);
            command.Parameters.AddWithValue("@p5", comboGender.Text);
            command.Parameters.AddWithValue("@p6", maskedTextTC.Text);
            command.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Your registration has been completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
