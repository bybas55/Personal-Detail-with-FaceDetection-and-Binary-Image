namespace face
{
    partial class personellist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personellist));
            this.find = new System.Windows.Forms.Button();
            this.persname = new System.Windows.Forms.TextBox();
            this.perssurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.persid = new System.Windows.Forms.MaskedTextBox();
            this.persemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.perstel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.White;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.find.Image = ((System.Drawing.Image)(resources.GetObject("find.Image")));
            this.find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.find.Location = new System.Drawing.Point(459, 87);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(89, 23);
            this.find.TabIndex = 0;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // persname
            // 
            this.persname.Location = new System.Drawing.Point(135, 58);
            this.persname.Name = "persname";
            this.persname.Size = new System.Drawing.Size(138, 22);
            this.persname.TabIndex = 2;
            // 
            // perssurname
            // 
            this.perssurname.Location = new System.Drawing.Point(135, 84);
            this.perssurname.Name = "perssurname";
            this.perssurname.Size = new System.Drawing.Size(138, 22);
            this.perssurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personal Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personal Surname : ";
            // 
            // persid
            // 
            this.persid.Location = new System.Drawing.Point(135, 32);
            this.persid.Mask = "00000000000";
            this.persid.Name = "persid";
            this.persid.Size = new System.Drawing.Size(138, 22);
            this.persid.TabIndex = 4;
            // 
            // persemail
            // 
            this.persemail.Location = new System.Drawing.Point(410, 29);
            this.persemail.Name = "persemail";
            this.persemail.Size = new System.Drawing.Size(138, 22);
            this.persemail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personal E-Mail : ";
            // 
            // perstel
            // 
            this.perstel.Location = new System.Drawing.Point(410, 57);
            this.perstel.Mask = "(999) 000-0000";
            this.perstel.Name = "perstel";
            this.perstel.Size = new System.Drawing.Size(138, 22);
            this.perstel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Personal Tel  : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.persid);
            this.groupBox1.Controls.Add(this.perstel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.perssurname);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.persemail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.persname);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Find";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail});
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 184);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Detail
            // 
            this.Detail.FillWeight = 50F;
            this.Detail.HeaderText = "Detail";
            this.Detail.Image = ((System.Drawing.Image)(resources.GetObject("Detail.Image")));
            this.Detail.Name = "Detail";
            this.Detail.Width = 40;
            // 
            // personellist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(744, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(760, 371);
            this.MinimumSize = new System.Drawing.Size(760, 371);
            this.Name = "personellist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Find";
            this.Load += new System.EventHandler(this.personellist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox persname;
        private System.Windows.Forms.TextBox perssurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox persid;
        private System.Windows.Forms.TextBox persemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox perstel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Detail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}