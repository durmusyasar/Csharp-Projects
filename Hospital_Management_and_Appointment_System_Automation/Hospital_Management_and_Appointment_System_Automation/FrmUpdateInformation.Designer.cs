namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FrmUpdateInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateInformation));
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.maskedTextPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 23;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(240, 197);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(154, 31);
            this.comboGender.TabIndex = 37;
            // 
            // maskedTextPhone
            // 
            this.maskedTextPhone.Location = new System.Drawing.Point(240, 123);
            this.maskedTextPhone.Mask = "(999) 000-0000";
            this.maskedTextPhone.Name = "maskedTextPhone";
            this.maskedTextPhone.Size = new System.Drawing.Size(154, 31);
            this.maskedTextPhone.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Phone Number :";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(240, 160);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(154, 31);
            this.textpassword.TabIndex = 5;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Password :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(240, 12);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(154, 31);
            this.textname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Name :";
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(240, 49);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(154, 31);
            this.textsurname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Surname :";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Info;
            this.save.Location = new System.Drawing.Point(240, 245);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(154, 34);
            this.save.TabIndex = 7;
            this.save.Text = "Update";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(240, 86);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.Size = new System.Drawing.Size(154, 31);
            this.maskedTextTC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "TC identification number :";
            // 
            // FrmUpdateInformation
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 287);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.maskedTextPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmUpdateInformation";
            this.Text = "Update Information";
            this.Load += new System.EventHandler(this.FrmUpdateInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.MaskedTextBox maskedTextPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}