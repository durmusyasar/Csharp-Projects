namespace PersonRegisterProject
{
    partial class FrmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmbcity = new System.Windows.Forms.ComboBox();
            this.MtbSalary = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.Textsur = new System.Windows.Forms.TextBox();
            this.RadioMarried = new System.Windows.Forms.RadioButton();
            this.RadioSingle = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btngraphic = new System.Windows.Forms.Button();
            this.Btnstatistic = new System.Windows.Forms.Button();
            this.Btnclean = new System.Windows.Forms.Button();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.Btnsave = new System.Windows.Forms.Button();
            this.Btnlists = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet3 = new PersonRegisterProject.PersonelVeriTabaniDataSet3();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new PersonRegisterProject.PersonelVeriTabaniDataSet3TableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmbcity);
            this.groupBox1.Controls.Add(this.MtbSalary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txtname);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.TxtJob);
            this.groupBox1.Controls.Add(this.Textsur);
            this.groupBox1.Controls.Add(this.RadioMarried);
            this.groupBox1.Controls.Add(this.RadioSingle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Register";
            // 
            // Cmbcity
            // 
            this.Cmbcity.FormattingEnabled = true;
            this.Cmbcity.Location = new System.Drawing.Point(162, 121);
            this.Cmbcity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmbcity.Name = "Cmbcity";
            this.Cmbcity.Size = new System.Drawing.Size(123, 27);
            this.Cmbcity.TabIndex = 4;
            // 
            // MtbSalary
            // 
            this.MtbSalary.Location = new System.Drawing.Point(162, 151);
            this.MtbSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MtbSalary.Mask = "00000";
            this.MtbSalary.Name = "MtbSalary";
            this.MtbSalary.Size = new System.Drawing.Size(123, 27);
            this.MtbSalary.TabIndex = 5;
            this.MtbSalary.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salary : ";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(162, 60);
            this.Txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(123, 27);
            this.Txtname.TabIndex = 2;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(162, 31);
            this.Txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(123, 27);
            this.Txtid.TabIndex = 1;
            // 
            // TxtJob
            // 
            this.TxtJob.Location = new System.Drawing.Point(162, 203);
            this.TxtJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(123, 27);
            this.TxtJob.TabIndex = 8;
            // 
            // Textsur
            // 
            this.Textsur.Location = new System.Drawing.Point(162, 90);
            this.Textsur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Textsur.Name = "Textsur";
            this.Textsur.Size = new System.Drawing.Size(123, 27);
            this.Textsur.TabIndex = 3;
            // 
            // RadioMarried
            // 
            this.RadioMarried.AutoSize = true;
            this.RadioMarried.Location = new System.Drawing.Point(206, 181);
            this.RadioMarried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioMarried.Name = "RadioMarried";
            this.RadioMarried.Size = new System.Drawing.Size(79, 23);
            this.RadioMarried.TabIndex = 7;
            this.RadioMarried.TabStop = true;
            this.RadioMarried.Text = "Married";
            this.RadioMarried.UseVisualStyleBackColor = true;
            this.RadioMarried.CheckedChanged += new System.EventHandler(this.RadioMarried_CheckedChanged);
            // 
            // RadioSingle
            // 
            this.RadioSingle.AutoSize = true;
            this.RadioSingle.Location = new System.Drawing.Point(133, 179);
            this.RadioSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioSingle.Name = "RadioSingle";
            this.RadioSingle.Size = new System.Drawing.Size(69, 23);
            this.RadioSingle.TabIndex = 6;
            this.RadioSingle.TabStop = true;
            this.RadioSingle.Text = "Single";
            this.RadioSingle.UseVisualStyleBackColor = true;
            this.RadioSingle.CheckedChanged += new System.EventHandler(this.RadioSingle_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "City :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Person Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person İD :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnReport);
            this.groupBox2.Controls.Add(this.Btngraphic);
            this.groupBox2.Controls.Add(this.Btnstatistic);
            this.groupBox2.Controls.Add(this.Btnclean);
            this.groupBox2.Controls.Add(this.Btnupdate);
            this.groupBox2.Controls.Add(this.Btndelete);
            this.groupBox2.Controls.Add(this.Btnsave);
            this.groupBox2.Controls.Add(this.Btnlists);
            this.groupBox2.Location = new System.Drawing.Point(331, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(214, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // Btngraphic
            // 
            this.Btngraphic.Location = new System.Drawing.Point(32, 195);
            this.Btngraphic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btngraphic.Name = "Btngraphic";
            this.Btngraphic.Size = new System.Drawing.Size(105, 26);
            this.Btngraphic.TabIndex = 15;
            this.Btngraphic.Text = "Graphic";
            this.Btngraphic.UseVisualStyleBackColor = true;
            this.Btngraphic.Click += new System.EventHandler(this.Btngraphic_Click);
            // 
            // Btnstatistic
            // 
            this.Btnstatistic.Location = new System.Drawing.Point(32, 166);
            this.Btnstatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnstatistic.Name = "Btnstatistic";
            this.Btnstatistic.Size = new System.Drawing.Size(105, 26);
            this.Btnstatistic.TabIndex = 14;
            this.Btnstatistic.Text = "Statistics";
            this.Btnstatistic.UseVisualStyleBackColor = true;
            this.Btnstatistic.Click += new System.EventHandler(this.Btnstatistic_Click);
            // 
            // Btnclean
            // 
            this.Btnclean.Location = new System.Drawing.Point(32, 138);
            this.Btnclean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnclean.Name = "Btnclean";
            this.Btnclean.Size = new System.Drawing.Size(105, 26);
            this.Btnclean.TabIndex = 13;
            this.Btnclean.Text = "Clean";
            this.Btnclean.UseVisualStyleBackColor = true;
            this.Btnclean.Click += new System.EventHandler(this.Btnclean_Click);
            // 
            // Btnupdate
            // 
            this.Btnupdate.Location = new System.Drawing.Point(32, 108);
            this.Btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(105, 26);
            this.Btnupdate.TabIndex = 12;
            this.Btnupdate.Text = "Update";
            this.Btnupdate.UseVisualStyleBackColor = true;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(32, 78);
            this.Btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(105, 26);
            this.Btndelete.TabIndex = 11;
            this.Btndelete.Text = "Delete";
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(32, 47);
            this.Btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(105, 26);
            this.Btnsave.TabIndex = 10;
            this.Btnsave.Text = "Save";
            this.Btnsave.UseVisualStyleBackColor = true;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Btnlists
            // 
            this.Btnlists.Location = new System.Drawing.Point(32, 18);
            this.Btnlists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnlists.Name = "Btnlists";
            this.Btnlists.Size = new System.Drawing.Size(105, 26);
            this.Btnlists.TabIndex = 9;
            this.Btnlists.Text = "Lists";
            this.Btnlists.UseVisualStyleBackColor = true;
            this.Btnlists.Click += new System.EventHandler(this.Btnlists_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 278);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(715, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet3;
            // 
            // personelVeriTabaniDataSet3
            // 
            this.personelVeriTabaniDataSet3.DataSetName = "PersonelVeriTabaniDataSet3";
            this.personelVeriTabaniDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(32, 221);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(105, 26);
            this.BtnReport.TabIndex = 16;
            this.BtnReport.Text = "Report";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(738, 438);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.TextBox TxtJob;
        private System.Windows.Forms.TextBox Textsur;
        private System.Windows.Forms.RadioButton RadioMarried;
        private System.Windows.Forms.RadioButton RadioSingle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btngraphic;
        private System.Windows.Forms.Button Btnstatistic;
        private System.Windows.Forms.Button Btnclean;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button Btnsave;
        private System.Windows.Forms.Button Btnlists;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Cmbcity;
        private System.Windows.Forms.MaskedTextBox MtbSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet3 personelVeriTabaniDataSet3;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSet3TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnReport;
    }
}

