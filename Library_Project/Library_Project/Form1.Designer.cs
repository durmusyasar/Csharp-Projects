namespace Library_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.textauthor = new System.Windows.Forms.TextBox();
            this.textpage = new System.Windows.Forms.TextBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.radioused = new System.Windows.Forms.RadioButton();
            this.radiounsed = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonlist = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.buttonfind = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Page :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status : ";
            // 
            // textid
            // 
            this.textid.Enabled = false;
            this.textid.Location = new System.Drawing.Point(101, 6);
            this.textid.Margin = new System.Windows.Forms.Padding(2);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(145, 26);
            this.textid.TabIndex = 6;
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(403, 143);
            this.textsearch.Margin = new System.Windows.Forms.Padding(2);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(145, 26);
            this.textsearch.TabIndex = 7;
            // 
            // textauthor
            // 
            this.textauthor.Location = new System.Drawing.Point(101, 61);
            this.textauthor.Margin = new System.Windows.Forms.Padding(2);
            this.textauthor.Name = "textauthor";
            this.textauthor.Size = new System.Drawing.Size(145, 26);
            this.textauthor.TabIndex = 8;
            // 
            // textpage
            // 
            this.textpage.Location = new System.Drawing.Point(101, 88);
            this.textpage.Margin = new System.Windows.Forms.Padding(2);
            this.textpage.Name = "textpage";
            this.textpage.Size = new System.Drawing.Size(145, 26);
            this.textpage.TabIndex = 9;
            // 
            // combotype
            // 
            this.combotype.FormattingEnabled = true;
            this.combotype.Location = new System.Drawing.Point(101, 115);
            this.combotype.Margin = new System.Windows.Forms.Padding(2);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(145, 26);
            this.combotype.TabIndex = 10;
            // 
            // radioused
            // 
            this.radioused.AutoSize = true;
            this.radioused.Location = new System.Drawing.Point(101, 143);
            this.radioused.Margin = new System.Windows.Forms.Padding(2);
            this.radioused.Name = "radioused";
            this.radioused.Size = new System.Drawing.Size(65, 24);
            this.radioused.TabIndex = 11;
            this.radioused.TabStop = true;
            this.radioused.Text = "Used";
            this.radioused.UseVisualStyleBackColor = true;
            this.radioused.CheckedChanged += new System.EventHandler(this.radioused_CheckedChanged);
            // 
            // radiounsed
            // 
            this.radiounsed.AutoSize = true;
            this.radiounsed.Location = new System.Drawing.Point(169, 143);
            this.radiounsed.Margin = new System.Windows.Forms.Padding(2);
            this.radiounsed.Name = "radiounsed";
            this.radiounsed.Size = new System.Drawing.Size(85, 24);
            this.radiounsed.TabIndex = 12;
            this.radiounsed.TabStop = true;
            this.radiounsed.Text = "Unused";
            this.radiounsed.UseVisualStyleBackColor = true;
            this.radiounsed.CheckedChanged += new System.EventHandler(this.radiounsed_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 203);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 167);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonlist
            // 
            this.buttonlist.Location = new System.Drawing.Point(264, 7);
            this.buttonlist.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlist.Name = "buttonlist";
            this.buttonlist.Size = new System.Drawing.Size(110, 28);
            this.buttonlist.TabIndex = 14;
            this.buttonlist.Text = "List";
            this.buttonlist.UseVisualStyleBackColor = true;
            this.buttonlist.Click += new System.EventHandler(this.buttonlist_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(264, 40);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(110, 28);
            this.buttonsave.TabIndex = 15;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(264, 73);
            this.buttondelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(110, 28);
            this.buttondelete.TabIndex = 16;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(264, 106);
            this.buttonupdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(110, 28);
            this.buttonupdate.TabIndex = 17;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Book Name :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(101, 34);
            this.textname.Margin = new System.Windows.Forms.Padding(2);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(145, 26);
            this.textname.TabIndex = 20;
            // 
            // buttonfind
            // 
            this.buttonfind.BackColor = System.Drawing.Color.Aqua;
            this.buttonfind.Location = new System.Drawing.Point(402, 173);
            this.buttonfind.Margin = new System.Windows.Forms.Padding(2);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(73, 28);
            this.buttonfind.TabIndex = 21;
            this.buttonfind.Text = "Find";
            this.buttonfind.UseVisualStyleBackColor = false;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.Aqua;
            this.buttonsearch.Location = new System.Drawing.Point(475, 173);
            this.buttonsearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(73, 28);
            this.buttonsearch.TabIndex = 22;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonfind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(554, 371);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttonfind);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttonlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radiounsed);
            this.Controls.Add(this.radioused);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.textpage);
            this.Controls.Add(this.textauthor);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.TextBox textauthor;
        private System.Windows.Forms.TextBox textpage;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.RadioButton radioused;
        private System.Windows.Forms.RadioButton radiounsed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonlist;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.Button buttonsearch;
    }
}

