using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Aslı", "Mehmet", "Kaan" };
            label1.Text = kisiler[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 67, 8, 9, 74 };
            label2.Text = sayilar[6].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] sehirler = {"Trabzon", "Rize", "Ankara", "Sivas", "Samsun" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 4, 2, 5, 87, 4, 5, 2 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Aslı", "Mehmet", "Kaan" };
            foreach (string kisi in kisiler)
            {
                listBox3.Items.Add(kisi);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int toplam = 0, ortalama = 0;
            int[] sayilar = { 4, 2, 5, 87, 4, 5, 2 };
            foreach (int sayi in sayilar)
            {
                listBox4.Items.Add(sayi);
                toplam += sayi;
            }
            ortalama = toplam / sayilar.Length;
            label3.Text = toplam.ToString();
            label4.Text = ortalama.ToString();
        }
    }
}
