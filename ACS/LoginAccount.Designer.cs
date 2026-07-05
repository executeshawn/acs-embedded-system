namespace acs
{
    partial class LoginAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterAccSignUpBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.ShowPassCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginSignInBttn = new System.Windows.Forms.Button();
            this.UsernameLogin = new System.Windows.Forms.Label();
            this.PasswordLogin = new System.Windows.Forms.Label();
            this.LoginInAccountPasswordText = new System.Windows.Forms.TextBox();
            this.LoginAccInstitutionalEmail = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DirectToAdminBttn = new System.Windows.Forms.Label();
            this.ForgotPasswordReset = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RegisterAccSignUpBttn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 390);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegisterAccSignUpBttn
            // 
            this.RegisterAccSignUpBttn.BackColor = System.Drawing.Color.Navy;
            this.RegisterAccSignUpBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccSignUpBttn.ForeColor = System.Drawing.Color.White;
            this.RegisterAccSignUpBttn.Location = new System.Drawing.Point(35, 331);
            this.RegisterAccSignUpBttn.Name = "RegisterAccSignUpBttn";
            this.RegisterAccSignUpBttn.Size = new System.Drawing.Size(194, 34);
            this.RegisterAccSignUpBttn.TabIndex = 31;
            this.RegisterAccSignUpBttn.Text = "SIGN UP";
            this.RegisterAccSignUpBttn.UseVisualStyleBackColor = false;
            this.RegisterAccSignUpBttn.Click += new System.EventHandler(this.RegisterAccSignUpBttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Automated Door Lock System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(77, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Register your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Login Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(566, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ShowPassCheckBox
            // 
            this.ShowPassCheckBox.AutoSize = true;
            this.ShowPassCheckBox.Location = new System.Drawing.Point(466, 262);
            this.ShowPassCheckBox.Name = "ShowPassCheckBox";
            this.ShowPassCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPassCheckBox.TabIndex = 29;
            this.ShowPassCheckBox.Text = "Show Password";
            this.ShowPassCheckBox.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox_CheckedChanged);
            // 
            // LoginSignInBttn
            // 
            this.LoginSignInBttn.BackColor = System.Drawing.Color.Navy;
            this.LoginSignInBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSignInBttn.ForeColor = System.Drawing.Color.White;
            this.LoginSignInBttn.Location = new System.Drawing.Point(303, 295);
            this.LoginSignInBttn.Name = "LoginSignInBttn";
            this.LoginSignInBttn.Size = new System.Drawing.Size(166, 34);
            this.LoginSignInBttn.TabIndex = 30;
            this.LoginSignInBttn.Text = "SIGN IN";
            this.LoginSignInBttn.UseVisualStyleBackColor = false;
            this.LoginSignInBttn.Click += new System.EventHandler(this.LoginSignInBttn_Click);
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.AutoSize = true;
            this.UsernameLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLogin.Location = new System.Drawing.Point(303, 116);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new System.Drawing.Size(73, 16);
            this.UsernameLogin.TabIndex = 31;
            this.UsernameLogin.Text = "ID Number:";
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.AutoSize = true;
            this.PasswordLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLogin.Location = new System.Drawing.Point(303, 191);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(67, 16);
            this.PasswordLogin.TabIndex = 32;
            this.PasswordLogin.Text = "Password:";
            // 
            // LoginInAccountPasswordText
            // 
            this.LoginInAccountPasswordText.Location = new System.Drawing.Point(304, 219);
            this.LoginInAccountPasswordText.Name = "LoginInAccountPasswordText";
            this.LoginInAccountPasswordText.Size = new System.Drawing.Size(264, 20);
            this.LoginInAccountPasswordText.TabIndex = 34;
            this.LoginInAccountPasswordText.TextChanged += new System.EventHandler(this.LoginInAccountPasswordText_TextChanged);
            // 
            // LoginAccInstitutionalEmail
            // 
            this.LoginAccInstitutionalEmail.Location = new System.Drawing.Point(306, 158);
            this.LoginAccInstitutionalEmail.Name = "LoginAccInstitutionalEmail";
            this.LoginAccInstitutionalEmail.Size = new System.Drawing.Size(262, 20);
            this.LoginAccInstitutionalEmail.TabIndex = 35;
            this.LoginAccInstitutionalEmail.TextChanged += new System.EventHandler(this.LoginAccInstitutionalEmail_TextChanged);
            // 
            // DirectToAdminBttn
            // 
            this.DirectToAdminBttn.AutoSize = true;
            this.DirectToAdminBttn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectToAdminBttn.Location = new System.Drawing.Point(303, 332);
            this.DirectToAdminBttn.Name = "DirectToAdminBttn";
            this.DirectToAdminBttn.Size = new System.Drawing.Size(164, 14);
            this.DirectToAdminBttn.TabIndex = 36;
            this.DirectToAdminBttn.Text = "Click here, if you\'re an admin";
            this.DirectToAdminBttn.Click += new System.EventHandler(this.DirectToAdminBttn_Click);
            // 
            // ForgotPasswordReset
            // 
            this.ForgotPasswordReset.AutoSize = true;
            this.ForgotPasswordReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordReset.Location = new System.Drawing.Point(306, 256);
            this.ForgotPasswordReset.Name = "ForgotPasswordReset";
            this.ForgotPasswordReset.Size = new System.Drawing.Size(98, 14);
            this.ForgotPasswordReset.TabIndex = 37;
            this.ForgotPasswordReset.Text = "Forgot Password";
            this.ForgotPasswordReset.Click += new System.EventHandler(this.ForgotPasswordReset_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 390);
            this.Controls.Add(this.ForgotPasswordReset);
            this.Controls.Add(this.DirectToAdminBttn);
            this.Controls.Add(this.LoginAccInstitutionalEmail);
            this.Controls.Add(this.LoginInAccountPasswordText);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UsernameLogin);
            this.Controls.Add(this.LoginSignInBttn);
            this.Controls.Add(this.ShowPassCheckBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox ShowPassCheckBox;
        private System.Windows.Forms.Button LoginSignInBttn;
        private System.Windows.Forms.Button RegisterAccSignUpBttn;
        private System.Windows.Forms.Label UsernameLogin;
        private System.Windows.Forms.Label PasswordLogin;
        private System.Windows.Forms.TextBox LoginInAccountPasswordText;
        private System.Windows.Forms.TextBox LoginAccInstitutionalEmail;
        private System.Windows.Forms.Label DirectToAdminBttn;
        private System.Windows.Forms.Label ForgotPasswordReset;
    }
}