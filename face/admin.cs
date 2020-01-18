﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            useradd us = new useradd();
            us.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facedetection fa = new facedetection();
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personeladd per = new personeladd();
            per.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            department dep = new department();
            dep.Show();
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic dg = MessageBox.Show("Do you want to logout?", "LOGOUT", MessageBoxButtons.YesNo);

                if (dg == DialogResult.Yes)
                {
                    loginn lor = new loginn();
                    lor.Show();
                    this.Hide();
                }
                else if (dg == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personellist per = new personellist();
            per.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
