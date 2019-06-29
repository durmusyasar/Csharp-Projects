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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=FUJITSU\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void clean()
        {
            Txtid.Text = "";
            Txtname.Text = "";
            Textsur.Text = "";
            TxtJob.Text = "";
            MtbSalary.Text = "";
            Cmbcity.Text = "";
            RadioSingle.Checked = false;
            RadioMarried.Checked = false;
            Txtname.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet3.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet3.Tbl_Personel);
        }

        private void Btnlists_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet3.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet3.Tbl_Personel);
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerMeslek, PerDurum) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection);
            command.Parameters.AddWithValue("@p1", Txtname.Text);
            command.Parameters.AddWithValue("@p2", Textsur.Text);
            command.Parameters.AddWithValue("@p3", Cmbcity.Text);
            command.Parameters.AddWithValue("@p4", MtbSalary.Text);
            command.Parameters.AddWithValue("@p5", TxtJob.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Person Saved.");
        }

        private void RadioSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioMarried.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void RadioMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioSingle.Checked == true)
            {
                label8.Text = "Fasle";
            }
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commentdelete = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", connection);
            commentdelete.Parameters.AddWithValue("@k1", Txtid.Text);
            commentdelete.ExecuteNonQuery();//sorguyu calistir
            connection.Close();
            MessageBox.Show("Record deleted");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            Txtname.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            Textsur.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            Cmbcity.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            MtbSalary.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            TxtJob.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                RadioMarried.Checked = true;
            }
            if (label8.Text == "False")
            {
                RadioSingle.Checked = true;
            }
        }

        private void Btnclean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commentupdate = new SqlCommand("Update Tbl_Personel Set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4, PerDurum=@a5, PerMeslek=@a6 where Perid=@a7", connection);
            commentupdate.Parameters.AddWithValue("@a1", Txtname.Text);
            commentupdate.Parameters.AddWithValue("@a2", Textsur.Text);
            commentupdate.Parameters.AddWithValue("@a3", Cmbcity.Text);
            commentupdate.Parameters.AddWithValue("@a4", MtbSalary.Text);
            commentupdate.Parameters.AddWithValue("@a5", label8.Text);
            commentupdate.Parameters.AddWithValue("@a6", TxtJob.Text);
            commentupdate.Parameters.AddWithValue("@a7", Txtid.Text);
            commentupdate.ExecuteNonQuery(); // sorguyu çalıştır
            connection.Close();
            MessageBox.Show("Record updated");
        }

        private void Btnstatistic_Click(object sender, EventArgs e)
        {
            FrmStatistic fr = new FrmStatistic();
            fr.Show();
        }

        private void Btngraphic_Click(object sender, EventArgs e)
        {
            FrmGraphic fr = new FrmGraphic();
            fr.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmReport fr = new FrmReport();
            fr.Show();
        }
    }
}
