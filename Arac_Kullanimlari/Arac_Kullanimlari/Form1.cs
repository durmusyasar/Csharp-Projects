using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Durmuş";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Durmuş";
            label7.Text = "YAŞAR";
            label8.Text = "Öğrenci";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Bilgisayar Mühendisliği";
            label9.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ardahan");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Akademisyen");
            listBox1.Items.Add("Avukat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(dateTimePicker1.Text);
        }
    }
}
