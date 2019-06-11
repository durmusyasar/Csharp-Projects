using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Exam_Grades_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            int e1, e2, project;
            double average;
            name = textBox1.Text;
            surname = textBox2.Text;
            e1 = Convert.ToInt16(textBox3.Text);
            e2 = Convert.ToInt16(textBox4.Text);
            project = Convert.ToInt16(textBox5.Text);
            average = (e1 + e2 + project) / 3;
            listBox1.Items.Add(name + " " + surname + " Average : " + average);
        }
    }
}
