using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PersonRegisterProject
{
    public partial class FrmGraphic : Form
    {
        public FrmGraphic()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=FUJITSU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGraphic_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commentg1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel Group By PerSehir", connection);
            SqlDataReader dr1 = commentg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["City"].Points.AddXY(dr1[0], dr1[1]);
            }
            connection.Close();

            connection.Open();
            SqlCommand commentg2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel Group By PerMeslek", connection);
            SqlDataReader dr2 = commentg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Job - Salary"].Points.AddXY(dr2[0], dr2[1]);
            }
            connection.Close();

        }
    }
}
