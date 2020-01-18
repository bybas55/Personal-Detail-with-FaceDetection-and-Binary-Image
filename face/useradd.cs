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

namespace face
{
    public partial class useradd : Form
    {
        public useradd()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel");

        string secilen2;
        private void useradd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.yonetim' table. You can move, or remove it, as needed.
            this.yonetimTableAdapter1.Fill(this.dataSet2.yonetim);
            // TODO: This line of code loads data into the 'dataSet1.yonetim' table. You can move, or remove it, as needed.
            this.yonetimTableAdapter.Fill(this.dataSet1.yonetim);
            dataGridView1.AllowUserToAddRows = false;
            MakeReadOnly();

        }

        private void MakeReadOnly()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserid.Text) || string.IsNullOrWhiteSpace(txtuserid.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Fill in the gaps ...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!Helpers.MOBILE_PHONE_REGEX.IsMatch(txttel.Text))
                {

                    MessageBox.Show("Invalid Phone Number. Phone number must be match with (5##) ###-####");
                   
                    if (thereis(txtuserid.Text) != 0)
                    {
                        MessageBox.Show("Invalid User ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into yonetim (YonAd,YonSifre,YonNo,YonTel) values (@P1,@P2,@P3,@P4)", baglanti);
                        komut.Parameters.AddWithValue("@P1", txtuserid.Text);
                        komut.Parameters.AddWithValue("@P2", txtpassword.Text.ToString());
                        komut.Parameters.AddWithValue("@P3", comboBox1.Text);
                        komut.Parameters.AddWithValue("@P4", txttel.Text.ToString());
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("User added...");
                        this.yonetimTableAdapter.Fill(this.dataSet1.yonetim);
                        this.yonetimTableAdapter1.Fill(this.dataSet2.yonetim);
                    }
                    
                }
               
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            secilen2 = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtuserupid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtuseruppas.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtuptel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserupid.Text) || string.IsNullOrWhiteSpace(txtuserupid.Text) || string.IsNullOrEmpty(txtuseruppas.Text) || string.IsNullOrWhiteSpace(txtuseruppas.Text))
            {
                MessageBox.Show("Fill in the gaps ...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (!Helpers.MOBILE_PHONE_REGEX.IsMatch(txtuptel.Text))
                {

                    MessageBox.Show("Invalid Phone Number. Phone number must be match with (5##) ###-####");
                    return;

                }
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update yonetim set YonAd=@P1,YonSifre=@P2,YonNo=@P3,YonTel=@P4 where YonID=" + secilen2 + " ", baglanti);
                komut.Parameters.AddWithValue("@P1", txtuserupid.Text);
                komut.Parameters.AddWithValue("@P2", txtuseruppas.Text);
                komut.Parameters.AddWithValue("@P3", comboBox2.Text);
                komut.Parameters.AddWithValue("@P4", txtuptel.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("User updated...");
                this.yonetimTableAdapter.Fill(this.dataSet1.yonetim);
                this.yonetimTableAdapter1.Fill(this.dataSet2.yonetim);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from yonetim where YonID=" + secilen2 + " ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("User deleted...");
            this.yonetimTableAdapter.Fill(this.dataSet1.yonetim);
            this.yonetimTableAdapter1.Fill(this.dataSet2.yonetim);
            
        }
        public int thereis(string aranan)
        {
            int sonuc;

            SqlCommand komut = new SqlCommand("Select COUNT(YonAd) from yonetim where YonAd=" + aranan + " ", baglanti);
            baglanti.Open();
            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            return sonuc;
        }
    }
}
