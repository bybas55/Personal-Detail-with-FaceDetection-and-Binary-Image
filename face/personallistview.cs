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
using System.IO;

namespace face
{
    public partial class personallistview : Form
    {
        public personallistview()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0OLBCM7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBpersonel");

        public string persid { get; set; }

        private void personallistview_Load(object sender, EventArgs e)
        {
            string pers;
            pers = persid;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from personel where PersID='" + pers + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["PersID"].ToString();
                textBox2.Text = dr["PerAD"].ToString();
                textBox3.Text = dr["PerSoyad"].ToString();
                textBox4.Text = dr["PerEmail"].ToString();
                textBox5.Text = dr["PerTel"].ToString();
                textBox6.Text = dr["PerAdress"].ToString();
                textBox7.Text = dr["PerDepName"].ToString();
                DateTime bt = Convert.ToDateTime(dr["PerDate"]);
                DateTime st = Convert.ToDateTime(DateTime.Now);
                TimeSpan rs = st - bt;
                label9.Text = Math.Round(rs.TotalDays).ToString() + " Days ";
                if (dr["PerRes"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["PerRes"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(mem);
                }
                dr.Close();


            }
            komut.Dispose();
            baglanti.Close();
        }
    }
}
