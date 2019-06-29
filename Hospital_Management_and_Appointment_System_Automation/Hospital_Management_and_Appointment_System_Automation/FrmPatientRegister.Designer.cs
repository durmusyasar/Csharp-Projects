namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FrmPatientRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientRegister));
            this.buttonregister = new System.Windows.Forms.Button();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextPhone = new System.Windows.Forms.MaskedTextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.SystemColors.Info;
            this.buttonregister.Location = new System.Drawing.Point(240, 310);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(154, 34);
            this.buttonregister.TabIndex = 7;
            this.buttonregister.Text = "Register";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(240, 151);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.Size = new System.Drawing.Size(154, 31);
            this.maskedTextTC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC identification number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient Register Panel";
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(240, 114);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(154, 31);
            this.textsurname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Surname :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(240, 77);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(154, 31);
            this.textname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Phone Number :";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(240, 225);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(154, 31);
            this.textpassword.TabIndex = 5;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password :";
            // 
            // maskedTextPhone
            // 
            this.maskedTextPhone.Location = new System.Drawing.Point(240, 188);
            this.maskedTextPhone.Mask = "(999) 000-0000";
            this.maskedTextPhone.Name = "maskedTextPhone";
            this.maskedTextPhone.Size = new System.Drawing.Size(154, 31);
            this.maskedTextPhone.TabIndex = 4;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(240, 262);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(154, 31);
            this.comboGender.TabIndex = 6;
            // 
            // FrmPatientRegister
            // 
            this.AcceptButton = this.buttonregister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 367);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.maskedTextPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientRegister";
            this.Text = "Patient Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextPhone;
        private System.Windows.Forms.ComboBox comboGender;
    }
}