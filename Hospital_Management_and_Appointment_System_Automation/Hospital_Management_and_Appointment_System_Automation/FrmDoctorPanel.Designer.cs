namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FrmDoctorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorPanel));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.combobranch = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Branch :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Password :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(220, 12);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(154, 31);
            this.textname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Name :";
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(220, 49);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(154, 31);
            this.textsurname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Surname :";
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonadd.Location = new System.Drawing.Point(220, 197);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(73, 34);
            this.buttonadd.TabIndex = 6;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(220, 86);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.Size = new System.Drawing.Size(154, 31);
            this.maskedTextTC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "TC identification number :";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(220, 160);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(154, 31);
            this.textpassword.TabIndex = 5;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // combobranch
            // 
            this.combobranch.FormattingEnabled = true;
            this.combobranch.Location = new System.Drawing.Point(220, 124);
            this.combobranch.Name = "combobranch";
            this.combobranch.Size = new System.Drawing.Size(154, 31);
            this.combobranch.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 256);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonupdate.Location = new System.Drawing.Point(221, 237);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(154, 34);
            this.buttonupdate.TabIndex = 8;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.SystemColors.Info;
            this.buttondelete.Location = new System.Drawing.Point(299, 197);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(76, 34);
            this.buttondelete.TabIndex = 7;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // FrmDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 274);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combobranch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmDoctorPanel";
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.FrmDoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.ComboBox combobranch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
    }
}