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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=FUJITSU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayisi
            connection.Open();
            SqlCommand comment1 = new SqlCommand("Select Count(*) From Tbl_Personel", connection);
            SqlDataReader dr1 = comment1.ExecuteReader(); //Veri okuyucu
            while (dr1.Read())
            {
                LblTNoP.Text = dr1[0].ToString();
            }
            connection.Close();

            // Evli Personel Sayisi
            connection.Open();
            SqlCommand comment2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", connection);
            SqlDataReader dr2 = comment2.ExecuteReader(); //Veri okuyucu
            while (dr2.Read())
            {
                LblNoMS.Text = dr2[0].ToString();
            }
            connection.Close();

            // Bekar Personel Sayisi
            connection.Open();
            SqlCommand comment3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0", connection);
            SqlDataReader dr3 = comment3.ExecuteReader(); //Veri okuyucu
            while (dr3.Read())
            {
                LblNoSS.Text = dr3[0].ToString();
            }
            connection.Close();

            // Şehir Sayisi
            connection.Open();
            SqlCommand comment4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel", connection);
            SqlDataReader dr4 = comment4.ExecuteReader(); //Veri okuyucu
            while (dr4.Read())
            {
                LblNoC.Text = dr4[0].ToString();
            }
            connection.Close();

            // Toplam Maaş
            connection.Open();
            SqlCommand comment5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", connection);
            SqlDataReader dr5 = comment5.ExecuteReader(); //Veri okuyucu
            while (dr5.Read())
            {
                LblTS.Text = dr5[0].ToString();
            }
            connection.Close();

            // Ortalama Maaş
            connection.Open();
            SqlCommand comment6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", connection);
            SqlDataReader dr6 = comment6.ExecuteReader(); //Veri okuyucu
            while (dr6.Read())
            {
                LblAS.Text = dr6[0].ToString();
            }
            connection.Close();
        }
    }
}
