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
    public partial class FrmDoctorInfoEdit : Form
    {
        public FrmDoctorInfoEdit()
        {
            InitializeComponent();
        }

        sqlconnection scn = new sqlconnection();
        public string TCNO;
        private void FrmDoctorInfoEdit_Load(object sender, EventArgs e)
        {
            maskedTextTC.Text = TCNO;
            SqlCommand command = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@d1", scn.connection());
            command.Parameters.AddWithValue("@d1", maskedTextTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                textname.Text = dr[1].ToString();
                textsurname.Text = dr[2].ToString();
                comboBoxbranch.Text = dr[3].ToString();
                textpassword.Text = dr[5].ToString();
            }
            scn.connection().Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3, DoktorSifre=@d4 where DoktorTC=@d5", scn.connection());
            command.Parameters.AddWithValue("@d1", textname.Text);
            command.Parameters.AddWithValue("@d2", textsurname.Text);
            command.Parameters.AddWithValue("@d3", comboBoxbranch.Text);
            command.Parameters.AddWithValue("@d4", textpassword.Text);
            command.Parameters.AddWithValue("@d5", maskedTextTC.Text);
            command.ExecuteNonQuery();
            scn.connection().Close();
            MessageBox.Show("Doctor Updated.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
