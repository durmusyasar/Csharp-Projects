using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Kara_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ali")
            {
                label1.Text = "doğru";
            }
            else
            {
                label1.Text = "yanlış";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);
            if (sayi == 5)
            {
                label2.Text = "doğru";
            }
            else
            {
                label2.Text = "yanlış";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt16(textBox3.Text);
            if(sayi2 % 2 == 0)
            {
                label3.Text = "Çift";
            }
            else
            {
                label3.Text = "Tek";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt16(textBox4.Text);
            if (sayi2 >= 10 && sayi2 % 2 == 0) 
            { 
                label4.Text = "10'dan büyük ve çift";
            }
            else
            {
                label4.Text = "10'dan büyük ya da çift değil";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt16(textBox5.Text);
            if (sayi2 >= 10 || sayi2 % 2 == 0)
            {
                label5.Text = "10'dan büyük veya çift";
            }
            else
            {
                label5.Text = "10'dan büyük veya çift değil";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double s1, s2, p, ort;
            string durum;
            s1 = Convert.ToDouble(textBox6.Text);
            s2 = Convert.ToDouble(textBox7.Text);
            p = Convert.ToDouble(textBox8.Text);
            ort = (s1 + s2 + p) / 3;

            if(ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            textBox9.Text = ort.ToString("0.00") + " /" + durum; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox10.Text);
            switch (ay)
            {
                case 1: label11.Text = "Ocak"; break;
                case 2: label11.Text = "Şubat"; break;
                case 3: label11.Text = "Mart"; break;
                case 4: label11.Text = "Nisan"; break;
                case 5: label11.Text = "Mayıs"; break;
                case 6: label11.Text = "Haziran"; break;
                case 7: label11.Text = "Temmuz"; break;
                case 8: label11.Text = "Ağustos"; break;
                case 9: label11.Text = "Eylül"; break;
                case 10: label11.Text = "Ekim"; break;
                case 11: label11.Text = "Kasım"; break;
                case 12: label11.Text = "Aralık"; break;
                default: label11.Text = "Hatalı Ay"; break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string mevsim = textBox11.Text;
            switch(mevsim)
            {
                case "yaz": label12.Text = "haziran temmuz ağustos";
                    break;
                case "sonbahar": label12.Text = "eylül ekim kasım";
                    break;
                case "kış": label12.Text = "aralık ocak şubat";
                    break;
                case "ilkbahar": label12.Text = "mart nisan mayıs";
                    break;
                default: label12.Text = "Hatalı Mevsim"; break;
            }
        }
    }
}
