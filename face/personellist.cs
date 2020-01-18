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
    public partial class personellist : Form
    {
        public personellist()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel");

        private void personellist_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel", baglanti);
            DataSet gs = new DataSet();
            komut.Fill(gs,"personel");
            dataGridView1.DataSource = gs.Tables["personel"];
            //DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            //dgvBtn.HeaderText = "Detail";
            //dgvBtn.Text = "More Detail";
            //dgvBtn.UseColumnTextForButtonValue = true;
            //dgvBtn.DefaultCellStyle.BackColor = Color.White;
            //dgvBtn.DefaultCellStyle.SelectionBackColor = Color.White;
            //dgvBtn.Width = 70;
            //dataGridView1.Columns.Add(dgvBtn);
            ///*** RESİMLİ BUTON EKLEME ***/
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img.Image = Image.FromFile("C:\\Users\\bbas5\\Documents\\Visual Studio 2017\\Projects\\face\\face\\photos\\icons\\search1.ico");
            //img.HeaderText = "Detail";
            //img.Width = 50;
            //dataGridView1.Columns.Add(img);
            dataGridView1.AllowUserToAddRows = false;

            baglanti.Close();

        }

        private void find_Click(object sender, EventArgs e)
        {
           
            
            if (persid.Text!=string.Empty)
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel where PersID like '%"
                                                            + persid.Text + "%'", baglanti);
                DataSet gs = new DataSet();
                komut.Fill(gs, "personel");
                dataGridView1.DataSource = gs.Tables["personel"];

                baglanti.Close();
            }

            else if (persname.Text != string.Empty)
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel where PerAD like '%"
                                                                + persname.Text + "%'", baglanti);
                DataSet gs = new DataSet();
                komut.Fill(gs, "personel");
                dataGridView1.DataSource = gs.Tables["personel"];

                baglanti.Close();
            }
            else if (perssurname.Text != string.Empty)
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel where PerSoyad like '%"
                                                            + perssurname.Text + "%'", baglanti);
                DataSet gs = new DataSet();
                komut.Fill(gs, "personel");
                dataGridView1.DataSource = gs.Tables["personel"];

                baglanti.Close();
            }
            else if (persemail.Text != string.Empty)
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel where PerEmail like '%"
                                                            + persemail.Text + "%'", baglanti);
                DataSet gs = new DataSet();
                komut.Fill(gs, "personel");
                dataGridView1.DataSource = gs.Tables["personel"];

                baglanti.Close();
            }
            else if (perstel.Text != string.Empty)
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel where PerTel like '%"
                                                            + perstel.Text + "%'", baglanti);
                DataSet gs = new DataSet();
                komut.Fill(gs, "personel");
                dataGridView1.DataSource = gs.Tables["personel"];

                baglanti.Close();
            }

            else
            {
               baglanti.Open();
               SqlDataAdapter komut = new SqlDataAdapter("Select PersID,PerAD,PerSoyad,PerEmail,PerTel,PerDepName from personel", baglanti);
               DataSet gs = new DataSet();
               komut.Fill(gs, "personel");
               dataGridView1.DataSource = gs.Tables["personel"];

                baglanti.Close();
            }

        }
        int secilen;
        string secilen2;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            secilen2 = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            if (secilen2 != string.Empty)
            {// hangi kolona göre işlem yapacaksak onun index i ile karşılaştırıyoruz
                personallistview ps = new personallistview();
                ps.persid = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                ps.Show();
            }

        }
    }
}
