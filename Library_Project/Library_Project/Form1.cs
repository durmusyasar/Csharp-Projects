using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#_Projects\Kitaplik.mdb");

        void list()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }

        private void buttonlist_Click(object sender, EventArgs e)
        {
            list();
        }
        string status = "";
        private void buttonsave_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand commend1 = new OleDbCommand("insert into Kitaplar (KitapAd, Yazar, Tur, Sayfa, Durum) values (@p1, @p2, @p3, @p4, @p5)", connection);
            commend1.Parameters.AddWithValue("@p1", textsearch.Text);
            commend1.Parameters.AddWithValue("@p2", textauthor.Text);
            commend1.Parameters.AddWithValue("@p3", combotype.Text);
            commend1.Parameters.AddWithValue("@p4", textpage.Text);
            commend1.Parameters.AddWithValue("@p5", status);
            commend1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book Saved to System", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void radioused_CheckedChanged(object sender, EventArgs e)
        {
            status = "0";
        }

        private void radiounsed_CheckedChanged(object sender, EventArgs e)
        {
            status = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textsearch.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textauthor.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            combotype.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textpage.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            if (dataGridView1.Rows[selected].Cells[5].Value.ToString() == "True")
            {
                radiounsed.Checked = true;
            }
            else
            {
                radioused.Checked = true; 
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand commend2 = new OleDbCommand("Delete From Kitaplar where Kitapid=@k1", connection);
            commend2.Parameters.AddWithValue("@k1", textid.Text);
            commend2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book Deleted to System", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            list();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand commend1 = new OleDbCommand("update Kitaplar set KitapAd=@p1, Yazar=@p2, Tur=@p3, Sayfa=@p4, Durum=@p5 where Kitapid=@p6", connection);
            commend1.Parameters.AddWithValue("@p1", textsearch.Text);
            commend1.Parameters.AddWithValue("@p2", textauthor.Text);
            commend1.Parameters.AddWithValue("@p3", combotype.Text);
            commend1.Parameters.AddWithValue("@p4", textpage.Text);
            
            if (radioused.Checked == true)
            {
                commend1.Parameters.AddWithValue("@p5", status);
            }
            if (radiounsed.Checked == true)
            {
                commend1.Parameters.AddWithValue("@p5", status);
            }
            commend1.Parameters.AddWithValue("@p6", textid.Text);
            commend1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book Updated to System", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.None);
            list();
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            OleDbCommand commend = new OleDbCommand("Select * From Kitaplar where KitapAd=@k1", connection);
            commend.Parameters.AddWithValue("@k1", textsearch.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(commend);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand commend = new OleDbCommand("Select * From Kitaplar where KitapAd like '%" + textsearch.Text + "%'", connection);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(commend);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
