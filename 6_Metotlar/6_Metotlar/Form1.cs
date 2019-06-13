using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.AntiqueWhite;
            textBox3.BackColor = Color.Aqua;
            textBox4.BackColor = Color.Aquamarine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        int toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(87, 43).ToString();
        }

        int küp(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox5.Text);
            label2.Text = küp(s).ToString();
        }
    }
}
