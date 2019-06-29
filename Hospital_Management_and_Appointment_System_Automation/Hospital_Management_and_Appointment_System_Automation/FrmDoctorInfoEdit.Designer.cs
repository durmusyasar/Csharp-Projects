namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FrmDoctorInfoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorInfoEdit));
            this.label7 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxbranch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Branch :";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(216, 163);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(154, 31);
            this.textpassword.TabIndex = 47;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Password :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(216, 15);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(154, 31);
            this.textname.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Name :";
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(216, 52);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(154, 31);
            this.textsurname.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Surname :";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Info;
            this.save.Location = new System.Drawing.Point(216, 200);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(154, 34);
            this.save.TabIndex = 41;
            this.save.Text = "Update";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(216, 126);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.Size = new System.Drawing.Size(154, 31);
            this.maskedTextTC.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "TC identification number :";
            // 
            // comboBoxbranch
            // 
            this.comboBoxbranch.FormattingEnabled = true;
            this.comboBoxbranch.Location = new System.Drawing.Point(216, 89);
            this.comboBoxbranch.Name = "comboBoxbranch";
            this.comboBoxbranch.Size = new System.Drawing.Size(154, 31);
            this.comboBoxbranch.TabIndex = 49;
            // 
            // FrmDoctorInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 240);
            this.Controls.Add(this.comboBoxbranch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save);
            this.Controls.Add(this.maskedTextTC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorInfoEdit";
            this.Text = "Doctor Info Edit";
            this.Load += new System.EventHandler(this.FrmDoctorInfoEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxbranch;
    }
}