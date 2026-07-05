namespace acs
{
    partial class RegisterAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegToLoginSignInBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegShowPass = new System.Windows.Forms.CheckBox();
            this.RegAccBttn = new System.Windows.Forms.Button();
            this.RegEmail = new System.Windows.Forms.Label();
            this.RegPass = new System.Windows.Forms.Label();
            this.RegAccEmail = new System.Windows.Forms.TextBox();
            this.RegPasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RegToLoginSignInBttn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 380);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegToLoginSignInBttn
            // 
            this.RegToLoginSignInBttn.BackColor = System.Drawing.Color.Navy;
            this.RegToLoginSignInBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegToLoginSignInBttn.ForeColor = System.Drawing.Color.White;
            this.RegToLoginSignInBttn.Location = new System.Drawing.Point(39, 321);
            this.RegToLoginSignInBttn.Name = "RegToLoginSignInBttn";
            this.RegToLoginSignInBttn.Size = new System.Drawing.Size(189, 35);
            this.RegToLoginSignInBttn.TabIndex = 30;
            this.RegToLoginSignInBttn.Text = "SIGN IN";
            this.RegToLoginSignInBttn.UseVisualStyleBackColor = false;
            this.RegToLoginSignInBttn.Click += new System.EventHandler(this.RegToLoginSignInBttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 100);
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
            this.label5.Location = new System.Drawing.Point(82, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(565, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 25;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegShowPass
            // 
            this.RegShowPass.AutoSize = true;
            this.RegShowPass.Location = new System.Drawing.Point(449, 206);
            this.RegShowPass.Name = "RegShowPass";
            this.RegShowPass.Size = new System.Drawing.Size(102, 17);
            this.RegShowPass.TabIndex = 28;
            this.RegShowPass.Text = "Show Password";
            this.RegShowPass.UseVisualStyleBackColor = true;
            this.RegShowPass.CheckedChanged += new System.EventHandler(this.RegShowPass_CheckedChanged);
            // 
            // RegAccBttn
            // 
            this.RegAccBttn.BackColor = System.Drawing.Color.Navy;
            this.RegAccBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegAccBttn.ForeColor = System.Drawing.Color.White;
            this.RegAccBttn.Location = new System.Drawing.Point(299, 324);
            this.RegAccBttn.Name = "RegAccBttn";
            this.RegAccBttn.Size = new System.Drawing.Size(128, 36);
            this.RegAccBttn.TabIndex = 29;
            this.RegAccBttn.Text = "REGISTER";
            this.RegAccBttn.UseVisualStyleBackColor = false;
            this.RegAccBttn.Click += new System.EventHandler(this.RegAccBttn_Click);
            // 
            // RegEmail
            // 
            this.RegEmail.AutoSize = true;
            this.RegEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEmail.Location = new System.Drawing.Point(296, 95);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(73, 16);
            this.RegEmail.TabIndex = 30;
            this.RegEmail.Text = "ID Number:";
            // 
            // RegPass
            // 
            this.RegPass.AutoSize = true;
            this.RegPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPass.Location = new System.Drawing.Point(296, 161);
            this.RegPass.Name = "RegPass";
            this.RegPass.Size = new System.Drawing.Size(67, 16);
            this.RegPass.TabIndex = 31;
            this.RegPass.Text = "Password:";
            // 
            // RegAccEmail
            // 
            this.RegAccEmail.Location = new System.Drawing.Point(299, 114);
            this.RegAccEmail.Name = "RegAccEmail";
            this.RegAccEmail.Size = new System.Drawing.Size(252, 20);
            this.RegAccEmail.TabIndex = 32;
            this.RegAccEmail.TextChanged += new System.EventHandler(this.RegAccEmail_TextChanged);
            // 
            // RegPasswordText
            // 
            this.RegPasswordText.Location = new System.Drawing.Point(299, 180);
            this.RegPasswordText.Name = "RegPasswordText";
            this.RegPasswordText.Size = new System.Drawing.Size(252, 20);
            this.RegPasswordText.TabIndex = 33;
            this.RegPasswordText.TextChanged += new System.EventHandler(this.RegPasswordText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Phone Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PhoneNumText
            // 
            this.PhoneNumText.Location = new System.Drawing.Point(299, 274);
            this.PhoneNumText.Name = "PhoneNumText";
            this.PhoneNumText.Size = new System.Drawing.Size(128, 20);
            this.PhoneNumText.TabIndex = 35;
            this.PhoneNumText.TextChanged += new System.EventHandler(this.PhoneNumText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 380);
            this.Controls.Add(this.PhoneNumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegPasswordText);
            this.Controls.Add(this.RegAccEmail);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.RegAccBttn);
            this.Controls.Add(this.RegShowPass);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox RegShowPass;
        private System.Windows.Forms.Button RegToLoginSignInBttn;
        private System.Windows.Forms.Button RegAccBttn;
        private System.Windows.Forms.Label RegEmail;
        private System.Windows.Forms.Label RegPass;
        private System.Windows.Forms.TextBox RegPasswordText;
        private System.Windows.Forms.TextBox RegAccEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNumText;
    }
}

