using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffet_Sales_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int safeholds = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int egypt, ticket, water, tea, sum;
            egypt = Convert.ToInt16(TxtEgy.Text);
            ticket= Convert.ToInt16(TxtTic.Text);
            water = Convert.ToInt16(TxtWat.Text);
            tea = Convert.ToInt16(TxtTea.Text);
            sum = egypt * 4 + tea * 2 + water * 1 + ticket * 8;
            LblSum.Text = sum.ToString() + "TL";
            safeholds = safeholds + sum;
            LblSaSum.Text = safeholds.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTic.Text = "";
            TxtEgy.Text = "";
            TxtWat.Text = "";
            TxtTea.Text = "";
            TxtEgy.Focus(); // temizledikten sonra imleci egypt ye getirdi
        }
    }
}
