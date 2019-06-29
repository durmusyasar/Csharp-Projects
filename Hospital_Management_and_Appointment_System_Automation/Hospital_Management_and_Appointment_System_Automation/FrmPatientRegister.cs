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
    public partial class FrmPatientRegister : Form
    {
        public FrmPatientRegister()
        {
            InitializeComponent();
        }

        sqlconnection scn = new sqlconnection();

        private void buttonregister_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", scn.connection());
            command.Parameters.AddWithValue("@p1", textname.Text);
            command.Parameters.AddWithValue("@p2", textsurname.Text);
            command.Parameters.AddWithValue("@p3", maskedTextTC.Text);
            command.Parameters.AddWithValue("@p4", maskedTextPhone.Text);
            command.Parameters.AddWithValue("@p5", textpassword.Text);
            command.Parameters.AddWithValue("@p6", comboGender.Text);
            command.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Your registration has been completed; Your password : " + textpassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
