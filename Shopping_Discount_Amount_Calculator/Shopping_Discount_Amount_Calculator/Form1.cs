using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Discount_Amount_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookpieces;
            double sum;
            bookpieces = Convert.ToInt16(textBox1.Text);
            if(bookpieces >= 0 && bookpieces <= 20)
            {
                sum = (bookpieces * 8) - (bookpieces * 8 * 0.20);
                label3.Text = sum + " TL";
            }
            if(bookpieces >= 21 && bookpieces <= 40)
            {
                sum = (bookpieces * 8) - (bookpieces * 8 * 0.40);
                label3.Text = sum + " TL";
            }
            if (bookpieces >= 41)
            {
                sum = (bookpieces * 8) - (bookpieces * 8 * 0.50);
                label3.Text = sum + " TL";
            }
        }
    }
}
// 0 - 20 ==> % 20
// 21 - 40 ==> % 40
// 41 ==> % 50
// Book = 8TL