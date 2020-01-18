namespace face
{
    partial class useradd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(useradd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtuptel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuseruppas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtuserupid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonetimBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new face.DataSet2();
            this.dataSet1 = new face.DataSet1();
            this.yonetimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yonetimTableAdapter = new face.DataSet1TableAdapters.yonetimTableAdapter();
            this.yonetimBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yonetimTableAdapter1 = new face.DataSet2TableAdapters.yonetimTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetimBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetimBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtuserid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User ADD";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(108, 115);
            this.txttel.Mask = "(999) 000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(125, 22);
            this.txttel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Authority :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(108, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(108, 59);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(125, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tel :";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(108, 33);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(125, 22);
            this.txtuserid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(158, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtuptel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtuseruppas);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtuserupid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Update";
            // 
            // txtuptel
            // 
            this.txtuptel.Location = new System.Drawing.Point(109, 117);
            this.txtuptel.Mask = "(999) 000-0000";
            this.txtuptel.Name = "txtuptel";
            this.txtuptel.Size = new System.Drawing.Size(156, 22);
            this.txtuptel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Authority :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox2.Location = new System.Drawing.Point(109, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(109, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tel :";
            // 
            // txtuseruppas
            // 
            this.txtuseruppas.Location = new System.Drawing.Point(109, 59);
            this.txtuseruppas.Name = "txtuseruppas";
            this.txtuseruppas.Size = new System.Drawing.Size(156, 22);
            this.txtuseruppas.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(190, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtuserupid
            // 
            this.txtuserupid.Location = new System.Drawing.Point(109, 33);
            this.txtuserupid.Name = "txtuserupid";
            this.txtuserupid.Size = new System.Drawing.Size(156, 22);
            this.txtuserupid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "User ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yonIDDataGridViewTextBoxColumn,
            this.yonAdDataGridViewTextBoxColumn,
            this.yonSifreDataGridViewTextBoxColumn,
            this.yonNoDataGridViewTextBoxColumn,
            this.yonTelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yonetimBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yonIDDataGridViewTextBoxColumn
            // 
            this.yonIDDataGridViewTextBoxColumn.DataPropertyName = "YonID";
            this.yonIDDataGridViewTextBoxColumn.FillWeight = 83.87746F;
            this.yonIDDataGridViewTextBoxColumn.HeaderText = "YonID";
            this.yonIDDataGridViewTextBoxColumn.Name = "yonIDDataGridViewTextBoxColumn";
            this.yonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yonAdDataGridViewTextBoxColumn
            // 
            this.yonAdDataGridViewTextBoxColumn.DataPropertyName = "YonAd";
            this.yonAdDataGridViewTextBoxColumn.FillWeight = 82.30476F;
            this.yonAdDataGridViewTextBoxColumn.HeaderText = "YonAd";
            this.yonAdDataGridViewTextBoxColumn.Name = "yonAdDataGridViewTextBoxColumn";
            // 
            // yonSifreDataGridViewTextBoxColumn
            // 
            this.yonSifreDataGridViewTextBoxColumn.DataPropertyName = "YonSifre";
            this.yonSifreDataGridViewTextBoxColumn.FillWeight = 82.30476F;
            this.yonSifreDataGridViewTextBoxColumn.HeaderText = "YonSifre";
            this.yonSifreDataGridViewTextBoxColumn.Name = "yonSifreDataGridViewTextBoxColumn";
            // 
            // yonNoDataGridViewTextBoxColumn
            // 
            this.yonNoDataGridViewTextBoxColumn.DataPropertyName = "YonNo";
            this.yonNoDataGridViewTextBoxColumn.FillWeight = 82.30476F;
            this.yonNoDataGridViewTextBoxColumn.HeaderText = "YonNo";
            this.yonNoDataGridViewTextBoxColumn.Name = "yonNoDataGridViewTextBoxColumn";
            // 
            // yonTelDataGridViewTextBoxColumn
            // 
            this.yonTelDataGridViewTextBoxColumn.DataPropertyName = "YonTel";
            this.yonTelDataGridViewTextBoxColumn.FillWeight = 82.30476F;
            this.yonTelDataGridViewTextBoxColumn.HeaderText = "YonTel";
            this.yonTelDataGridViewTextBoxColumn.Name = "yonTelDataGridViewTextBoxColumn";
            // 
            // yonetimBindingSource2
            // 
            this.yonetimBindingSource2.DataMember = "yonetim";
            this.yonetimBindingSource2.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yonetimBindingSource
            // 
            this.yonetimBindingSource.DataMember = "yonetim";
            this.yonetimBindingSource.DataSource = this.dataSet1;
            // 
            // yonetimTableAdapter
            // 
            this.yonetimTableAdapter.ClearBeforeFill = true;
            // 
            // yonetimBindingSource1
            // 
            this.yonetimBindingSource1.DataMember = "yonetim";
            this.yonetimBindingSource1.DataSource = this.dataSet1;
            // 
            // yonetimTableAdapter1
            // 
            this.yonetimTableAdapter1.ClearBeforeFill = true;
            // 
            // useradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(563, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(579, 482);
            this.MinimumSize = new System.Drawing.Size(579, 482);
            this.Name = "useradd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.useradd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetimBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yonetimBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource yonetimBindingSource;
        private DataSet1TableAdapters.yonetimTableAdapter yonetimTableAdapter;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtuseruppas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtuserupid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource yonetimBindingSource1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource yonetimBindingSource2;
        private DataSet2TableAdapters.yonetimTableAdapter yonetimTableAdapter1;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.MaskedTextBox txtuptel;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonTelDataGridViewTextBoxColumn;
    }
}