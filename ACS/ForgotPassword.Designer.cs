namespace acs
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newpasswordchangetxt = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordtext = new System.Windows.Forms.TextBox();
            this.ChangePasswordBttn = new System.Windows.Forms.Button();
            this.OTP = new System.Windows.Forms.Label();
            this.OTPtxt = new System.Windows.Forms.TextBox();
            this.VerifyOTPbttn = new System.Windows.Forms.Button();
            this.SendOTPbttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDNumberText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 378);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 96);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // newpasswordchangetxt
            // 
            this.newpasswordchangetxt.Location = new System.Drawing.Point(274, 164);
            this.newpasswordchangetxt.Name = "newpasswordchangetxt";
            this.newpasswordchangetxt.Size = new System.Drawing.Size(240, 20);
            this.newpasswordchangetxt.TabIndex = 4;
            this.newpasswordchangetxt.TextChanged += new System.EventHandler(this.newpasswordchangetxt_TextChanged);
            // 
            // ConfirmPasswordtext
            // 
            this.ConfirmPasswordtext.Location = new System.Drawing.Point(274, 206);
            this.ConfirmPasswordtext.Name = "ConfirmPasswordtext";
            this.ConfirmPasswordtext.Size = new System.Drawing.Size(240, 20);
            this.ConfirmPasswordtext.TabIndex = 5;
            this.ConfirmPasswordtext.TextChanged += new System.EventHandler(this.ConfirmPasswordtext_TextChanged);
            // 
            // ChangePasswordBttn
            // 
            this.ChangePasswordBttn.BackColor = System.Drawing.Color.Navy;
            this.ChangePasswordBttn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordBttn.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordBttn.Location = new System.Drawing.Point(415, 339);
            this.ChangePasswordBttn.Name = "ChangePasswordBttn";
            this.ChangePasswordBttn.Size = new System.Drawing.Size(137, 29);
            this.ChangePasswordBttn.TabIndex = 6;
            this.ChangePasswordBttn.Text = "Change Password";
            this.ChangePasswordBttn.UseVisualStyleBackColor = false;
            this.ChangePasswordBttn.Click += new System.EventHandler(this.ChangePasswordBttn_Click);
            // 
            // OTP
            // 
            this.OTP.AutoSize = true;
            this.OTP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTP.Location = new System.Drawing.Point(271, 229);
            this.OTP.Name = "OTP";
            this.OTP.Size = new System.Drawing.Size(69, 14);
            this.OTP.TabIndex = 7;
            this.OTP.Text = "Enter OTP:";
            // 
            // OTPtxt
            // 
            this.OTPtxt.Location = new System.Drawing.Point(274, 255);
            this.OTPtxt.Name = "OTPtxt";
            this.OTPtxt.Size = new System.Drawing.Size(158, 20);
            this.OTPtxt.TabIndex = 8;
            this.OTPtxt.TextChanged += new System.EventHandler(this.OTPtxt_TextChanged);
            // 
            // VerifyOTPbttn
            // 
            this.VerifyOTPbttn.BackColor = System.Drawing.Color.Navy;
            this.VerifyOTPbttn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyOTPbttn.ForeColor = System.Drawing.Color.White;
            this.VerifyOTPbttn.Location = new System.Drawing.Point(439, 255);
            this.VerifyOTPbttn.Name = "VerifyOTPbttn";
            this.VerifyOTPbttn.Size = new System.Drawing.Size(75, 29);
            this.VerifyOTPbttn.TabIndex = 9;
            this.VerifyOTPbttn.Text = "Verify";
            this.VerifyOTPbttn.UseVisualStyleBackColor = false;
            this.VerifyOTPbttn.Click += new System.EventHandler(this.VerifyOTPbttn_Click);
            // 
            // SendOTPbttn
            // 
            this.SendOTPbttn.BackColor = System.Drawing.Color.Navy;
            this.SendOTPbttn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendOTPbttn.ForeColor = System.Drawing.Color.White;
            this.SendOTPbttn.Location = new System.Drawing.Point(274, 286);
            this.SendOTPbttn.Name = "SendOTPbttn";
            this.SendOTPbttn.Size = new System.Drawing.Size(101, 25);
            this.SendOTPbttn.TabIndex = 10;
            this.SendOTPbttn.Text = "Send OTP";
            this.SendOTPbttn.UseVisualStyleBackColor = false;
            this.SendOTPbttn.Click += new System.EventHandler(this.SendOTPbttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Number / Admin Acc:";
            // 
            // IDNumberText
            // 
            this.IDNumberText.Location = new System.Drawing.Point(274, 113);
            this.IDNumberText.Name = "IDNumberText";
            this.IDNumberText.Size = new System.Drawing.Size(240, 20);
            this.IDNumberText.TabIndex = 13;
            this.IDNumberText.TextChanged += new System.EventHandler(this.IDNumberText_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back to Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 380);
            this.Controls.Add(this.IDNumberText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SendOTPbttn);
            this.Controls.Add(this.VerifyOTPbttn);
            this.Controls.Add(this.OTPtxt);
            this.Controls.Add(this.OTP);
            this.Controls.Add(this.ChangePasswordBttn);
            this.Controls.Add(this.ConfirmPasswordtext);
            this.Controls.Add(this.newpasswordchangetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpasswordchangetxt;
        private System.Windows.Forms.TextBox ConfirmPasswordtext;
        private System.Windows.Forms.Button ChangePasswordBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OTP;
        private System.Windows.Forms.TextBox OTPtxt;
        private System.Windows.Forms.Button VerifyOTPbttn;
        private System.Windows.Forms.Button SendOTPbttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDNumberText;
        private System.Windows.Forms.Button button1;
    }
}