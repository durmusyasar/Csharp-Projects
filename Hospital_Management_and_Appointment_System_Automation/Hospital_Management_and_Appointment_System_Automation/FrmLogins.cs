using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_and_Appointment_System_Automation
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void buttonpatient_Click(object sender, EventArgs e)
        {
            FrmPatientLogin frp = new FrmPatientLogin();
            frp.Show();
            this.Hide();
        }

        private void buttondoctor_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin frd = new FrmDoctorLogin();
            frd.Show();
            this.Hide();
        }

        private void buttonsecretary_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin frs = new FrmSecretaryLogin();
            frs.Show();
            this.Hide();
        }
    }
}
