namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.buttonpatient = new System.Windows.Forms.Button();
            this.buttondoctor = new System.Windows.Forms.Button();
            this.buttonsecretary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonpatient
            // 
            this.buttonpatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonpatient.BackgroundImage")));
            this.buttonpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpatient.Location = new System.Drawing.Point(14, 143);
            this.buttonpatient.Name = "buttonpatient";
            this.buttonpatient.Size = new System.Drawing.Size(171, 137);
            this.buttonpatient.TabIndex = 0;
            this.buttonpatient.UseVisualStyleBackColor = true;
            this.buttonpatient.Click += new System.EventHandler(this.buttonpatient_Click);
            // 
            // buttondoctor
            // 
            this.buttondoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondoctor.BackgroundImage")));
            this.buttondoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondoctor.Location = new System.Drawing.Point(232, 143);
            this.buttondoctor.Name = "buttondoctor";
            this.buttondoctor.Size = new System.Drawing.Size(171, 137);
            this.buttondoctor.TabIndex = 1;
            this.buttondoctor.UseVisualStyleBackColor = true;
            this.buttondoctor.Click += new System.EventHandler(this.buttondoctor_Click);
            // 
            // buttonsecretary
            // 
            this.buttonsecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsecretary.BackgroundImage")));
            this.buttonsecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonsecretary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsecretary.Location = new System.Drawing.Point(452, 143);
            this.buttonsecretary.Name = "buttonsecretary";
            this.buttonsecretary.Size = new System.Drawing.Size(171, 137);
            this.buttonsecretary.TabIndex = 2;
            this.buttonsecretary.UseVisualStyleBackColor = true;
            this.buttonsecretary.Click += new System.EventHandler(this.buttonsecretary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yasaroglu Hospital";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsecretary);
            this.Controls.Add(this.buttondoctor);
            this.Controls.Add(this.buttonpatient);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "FrmLogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yasaroglu Hospital Logins";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonpatient;
        private System.Windows.Forms.Button buttondoctor;
        private System.Windows.Forms.Button buttonsecretary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

