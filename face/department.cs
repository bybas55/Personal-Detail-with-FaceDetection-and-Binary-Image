using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace face
{
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel");
        string secilen2;
        private void department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.PerDep' table. You can move, or remove it, as needed.
            this.perDepTableAdapter.Fill(this.dataSet4.PerDep);
            dataGridView1.AllowUserToAddRows = false;
            MakeReadOnly();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Fill in the gaps ...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into PerDep (PerDep) values (@P1)", baglanti);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Department added...");
                this.perDepTableAdapter.Fill(this.dataSet4.PerDep);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Fill in the gaps ...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update PerDep set PerDep=@P1 where PerDepID=" + secilen2 + " ", baglanti);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Department updated...");
                this.perDepTableAdapter.Fill(this.dataSet4.PerDep);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            secilen2 = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from PerDep where PerDepID=" + secilen2 + " ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Department deleted...");
            this.perDepTableAdapter.Fill(this.dataSet4.PerDep);
        }
        private void MakeReadOnly()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
