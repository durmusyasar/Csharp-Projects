using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + "Merhaba Trabzon");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i+=2)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            label1.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 2; i <= 10; i += 2)
            {
                toplam += i;
            }
            label3.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox3.Items.Add(i);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox4.Items.Add(i);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i=0;
            while (i <= 5)
            {
                listBox5.Items.Add("Merhaba Trabzon");
                listBox6.Items.Add(i);
                i++;
            }

            int j = 0;
            int toplam=0;
            while (j <= 5)
            {
                toplam = toplam + j;
                j++;
            }
            MessageBox.Show(toplam.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = 15;
            do
            {
                listBox7.Items.Add("Merhaba Kardeş");
                i++;
            } while (i <= 10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label4.Text = sayac.ToString();
            if (sayac == 15)
            {
                //timer1.Stop();
                this.BackColor = Color.PeachPuff;
            }
            if (sayac == 30)
            {
                sayac = 0;
            }
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            label7.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label6.Text = dakika.ToString();
                saniye = 0;
                if (dakika == 60)
                {
                    saat++;
                    label5.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

    }
}
