using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route : " + comboBox1.Text + "-" + comboBox2.Text + " History : " + dateTimePicker1.Text + " Hour : " + maskedTextBox1.Text + " ~ Passenger Information ~ Name Surname : " + textBox1.Text + " Identification No :" + maskedTextBox2.Text + " Phone Number : " + maskedTextBox3.Text);
            MessageBox.Show("Passenger Registration Done");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
