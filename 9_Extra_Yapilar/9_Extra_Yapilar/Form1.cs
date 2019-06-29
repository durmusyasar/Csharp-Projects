using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Extra_Yapilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi;
            sayi = rnd.Next(1, 10);
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);
            label2.Text = s1.ToString();
            label4.Text = s2.ToString();
            label3.Text = s3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s1, s2, s3, s4;
            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);
            s4 = rnd.Next(1, 5);
            label5.Text = s1.ToString();
            label6.Text = s2.ToString();
            label7.Text = s3.ToString();
            label8.Text = s4.ToString();

            if (textBox1.Text == label5.Text)
            {
                textBox1.BackColor = Color.Bisque;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == label6.Text)
            {
                textBox2.BackColor = Color.Black;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == label7.Text)
            {
                textBox3.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == label8.Text)
            {
                textBox4.BackColor = Color.Blue;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            int sembol3;
            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);
            label9.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide(); // şuan üstünde çalışılan formu arka tarafına atılır.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.mesaj = textBox5.Text;
            fr.kimden = textBox6.Text;
            fr.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 30;
            konum.Y = 50;
            pictureBox1.Location = konum;
        }
        enum sehirler { Trabzon, Sivas, Rize, Ankara, İstanbul, Adana, İzmir}
        private void button8_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox7.Text);
            sehirler s;
            s = (sehirler)plaka;
            label10.Text = s.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox8.Text);
            //label11.Text = Math.Abs(sayi).ToString(); // mutlak 
            label11.Text = Math.Ceiling(sayi).ToString(); // üsse yuvarlama
            //label11.Text = Math.Floor(sayi).ToString(); // alta yuvarlama
            //label11.Text = Math.Pow(sayi, 3).ToString(); // üs
            //label11.Text = Math.Sqrt(sayi).ToString(); // karekök
            //label11.Text = Math.Cos(sayi).ToString(); // cosinus
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(620, 10);
            btn.Location = btnkonum;
            btn.Name = "Dinamik Araç";
            btn.Text = "Dinamik Araç";
            btn.Height = 50;
            btn.Width = 100;
            btn.BackColor = Color.BlueViolet;
            

            Label lbl = new Label();
            Point lblkonum = new Point(620, 130);
            lbl.Location = lblkonum;
            lbl.Name = "Labell";
            lbl.Text = "Dinamik Araç";
            lbl.AutoSize = true;
            lbl.BackColor = Color.Brown;
            this.Controls.Add(lbl);

            //Birden fazla oluşturma
            for (int i = 0; i < 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(620, i * 70);
                txt.Location = txtkonum;
                txt.Name = "TextBox";
                txt.Text = "Dinamik Araç" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
            this.Controls.Add(btn);
        }
    }
}
