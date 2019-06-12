using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, meslek, sehir;
            adsoyad = "Durmuş YAŞAR";
            meslek = "Öğrenci";
            label1.Text = adsoyad;
            label2.Text = meslek;
            sehir = textBox1.Text;
            label3.Text = sehir; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 13;
            sayi2 = 9;
            toplam = sayi1 + sayi2;
            label4.Text = toplam.ToString();//integer'ı string olarak yazdırmamız gerekiyor.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 15;
            alan = kenar * kenar;
            cevre = 4 * kenar;
            label5.Text = "Alan :" + alan + "\nÇevre :" + cevre;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt16(textBox2.Text);
            label7.Text = sayi.ToString();
            sonuc = sayi * sayi * sayi;
            label8.Text = " Küpü : " + sonuc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 45.58;
            label9.Text = sayi.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = 34;
            s2 = 50;
            s3 = 65;
            ort = (s1 + s2 + s3) / 3;
            label10.Text = ort.ToString("0.000");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = Convert.ToDouble(textBox3.Text);
            label11.Text = sayi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char takim;
            takim = 'G';
            label12.Text = takim.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char ders;
            ders = Convert.ToChar(textBox4.Text);
            label13.Text = ders.ToString();
        }
    }
}
