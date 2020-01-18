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
    public partial class loginn : Form
    {
        public loginn()
        {
            InitializeComponent();
        }
        //Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Fill in the blank portions.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from yonetim where YonAd=@p1 and YonSifre=@p2 ", baglanti);
                    komut.Parameters.AddWithValue("@p1", textBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox2.Text);
                    SqlDataReader dr = komut.ExecuteReader(CommandBehavior.CloseConnection);
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            if (dr["YonNo"].ToString() == "0")
                            {
                                admin ad = new admin();
                                ad.Show();
                                this.Hide();
                            }
                            else if (dr["YonNo"].ToString() == "1")
                            {
                                user us = new user();
                                us.Show();
                                this.Hide();
                            }
                            
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("The username or password is invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    baglanti.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("DataBase Not Working...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void loginn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Got a problem ? Contact with support...(0533-876-18-61)","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}