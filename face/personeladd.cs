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
using System.Text.RegularExpressions;
using System.IO;

namespace face
{
    public partial class personeladd : Form
    {
        public personeladd()
        {
            InitializeComponent();
        }
        //^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$
        //^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$
        //Regex mail = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
        string secilen2;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel");
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(perid.Text) || string.IsNullOrWhiteSpace(perid.Text) || string.IsNullOrEmpty(perad.Text) || string.IsNullOrWhiteSpace(perad.Text) || string.IsNullOrEmpty(persoy.Text) || string.IsNullOrWhiteSpace(persoy.Text) || string.IsNullOrEmpty(peradres.Text) || string.IsNullOrWhiteSpace(peradres.Text))
            {
                MessageBox.Show("Fill in the gaps ...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Helpers.MAIL_REGEX.IsMatch(permail.Text.Trim()))
                {
                    if (!Helpers.MOBILE_PHONE_REGEX.IsMatch(pertel.Text))
                    {

                        MessageBox.Show("Invalid Phone Number. Phone number must be match with (5##) ###-####");
                        return;

                    }
                    else
                    {
                        if (thereis(perid.Text) != 0)
                        {
                            MessageBox.Show("Invalid Personel ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //resim yüklemek için filestream metodunu kullanıyoruz...
                            FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] resim = br.ReadBytes((int)fs.Length);
                            br.Close();
                            fs.Close();

                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into personel (PersID,PerAD,PerSoyad,PerEmail,PerTel,PerAdress,PerDate,PerDepName,PerRes) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", baglanti);
                            komut.Parameters.AddWithValue("@P1", perid.Text.ToString());
                            komut.Parameters.AddWithValue("@P2", perad.Text.Trim());
                            komut.Parameters.AddWithValue("@P3", persoy.Text.Trim());
                            komut.Parameters.AddWithValue("@P4", permail.Text.Trim());
                            komut.Parameters.AddWithValue("@P5", pertel.Text.ToString());
                            komut.Parameters.AddWithValue("@P7", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                            komut.Parameters.AddWithValue("@P6", peradres.Text.ToString());
                            komut.Parameters.AddWithValue("@P8", comboBox1.Text);
                            komut.Parameters.Add("@P9", SqlDbType.Image, resim.Length).Value = resim;
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("User added...");
                            this.personelTableAdapter3.Fill(this.dataSet32.personel);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email.'__@__.com'");
                }
            }
            

        }

        private void peradres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '/' && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != ',')
            {
                if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbox.Visible = true;
            updatebox.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(upperid.Text) || string.IsNullOrWhiteSpace(upperid.Text) || string.IsNullOrEmpty(upperad.Text) || string.IsNullOrWhiteSpace(upperad.Text) || string.IsNullOrEmpty(uppersoy.Text) || string.IsNullOrWhiteSpace(uppersoy.Text) || string.IsNullOrEmpty(upperadres.Text) || string.IsNullOrWhiteSpace(upperadres.Text))
            {
                MessageBox.Show("Fill in the gaps ...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Helpers.MAIL_REGEX.IsMatch(uppermail.Text.Trim()))
                {
                    if (!Helpers.MOBILE_PHONE_REGEX.IsMatch(uppertel.Text))
                    {

                        MessageBox.Show("Invalid Phone Number. Phone number must be match with (5##) ###-####");
                        return;

                    }
                    else
                    {
                        
                            //resim yüklemek için filestream metodunu kullanıyoruz...
                            FileStream fs1 = new FileStream(imagepath1, FileMode.Open, FileAccess.Read);
                            BinaryReader br1 = new BinaryReader(fs1);
                            byte[] resim1 = br1.ReadBytes((int)fs1.Length);
                            br1.Close();
                            fs1.Close();


                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("update personel set PersID=@P1,PerAD=@P2,PerSoyad=@P3,PerEmail=@P4,PerTel=@P5,PerDate=@P6,PerAdress=@P7,PerDepName=@P8,PerRes=@P9 where PerID=" + secilen2 + " ", baglanti);
                            komut.Parameters.AddWithValue("@P1", upperid.Text.ToString());
                            komut.Parameters.AddWithValue("@P2", upperad.Text.Trim());
                            komut.Parameters.AddWithValue("@P3", uppersoy.Text.Trim());
                            komut.Parameters.AddWithValue("@P4", uppermail.Text.Trim());
                            komut.Parameters.AddWithValue("@P5", uppertel.Text.ToString());
                            komut.Parameters.AddWithValue("@P6", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                            komut.Parameters.AddWithValue("@P7", upperadres.Text.ToString());
                            komut.Parameters.AddWithValue("@P8", comboBox2.Text);
                            komut.Parameters.Add("@P9", SqlDbType.Image, resim1.Length).Value = resim1;
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("User updated...");
                            this.personelTableAdapter3.Fill(this.dataSet32.personel);
                        
                        
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Email.(__@__.com)");
                }
            }
            
        }

        private void personeladd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet32.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter3.Fill(this.dataSet32.personel);
            //// TODO: This line of code loads data into the 'dataSet5.personel' table. You can move, or remove it, as needed.
            //this.personelTableAdapter1.Fill(this.dataSet5.personel);
            dataGridView1.AllowUserToAddRows = false;
            MakeReadOnly();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * From PerDep",baglanti);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["PerDep"]);
                comboBox2.Items.Add(dr["PerDep"]);
            }
            baglanti.Close();
        }

        private void MakeReadOnly()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            secilen2 = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            upperid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            upperad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            uppersoy.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            uppermail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            uppertel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            upperadres.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            comboBox2.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from personel where PerID='" + secilen2 + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                //binary olarak eklediğimiz image geri çevirerek dönüştürüp picturebox2'ye bastırdık
                if (dr["PerRes"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["PerRes"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox2.Image = Image.FromStream(mem);
                }
                dr.Close();
                
                
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personel where PerID=" + secilen2 + " ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("User deleted...");
            this.personelTableAdapter3.Fill(this.dataSet32.personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            addbox.Visible = false;
            updatebox.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facedetection face = new facedetection();
            face.Show();
        }
        string imagepath;
        private void openbut1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select photos will be uploaded ...";
            openFileDialog1.Filter = "Jpeg file (*.jpg)|*.jpg|Png file (*.png)|*.png";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName.ToString();
            }
        }
        string imagepath1;
        private void openbut2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Select photos will be updated ...";
            openFileDialog2.Filter = "Jpeg file (*.jpg)|*.jpg|Png file (*.png)|*.png";
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.CheckFileExists = false;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
                imagepath1 = openFileDialog2.FileName.ToString();
            }
        }
        public int thereis(string aranan)
        {
            int sonuc;
            
            SqlCommand komut = new SqlCommand("Select COUNT(PersID) from personel where PersID=" + aranan + " ", baglanti);
            baglanti.Open();
            sonuc =Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            return sonuc;
        }
    }
}
