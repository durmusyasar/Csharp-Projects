using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Competition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int question = 0, truee = 0, falsee = 0;
        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox1.Visible = false;
            question++;
            LblQ.Text = question.ToString();
            if (question == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (question == 2)
            {
                richTextBox1.Text = "Hangi il Karadeniz bölgesinde bulunmaz ?";
                BtnA.Text = "Trabzon";
                BtnB.Text = "Rize";
                BtnC.Text = "Samsun";
                BtnD.Text = "Erzurum";
                label4.Text = "Erzurum";
            }
            if (question == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir ?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                BtnNext.Text="Results";
            }
            if (question == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnNext.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox1.Visible = false;
                MessageBox.Show("True : " + truee + "\nFalse : " + falsee);
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                LblT.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                LblF.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;
            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                LblT.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                LblF.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                LblT.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                LblF.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                LblT.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                LblF.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
