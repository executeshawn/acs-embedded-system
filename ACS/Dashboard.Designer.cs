namespace acs
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashboardSignOutBttn = new System.Windows.Forms.Button();
            this.FacultyBttn = new System.Windows.Forms.Button();
            this.DashboardBttn = new System.Windows.Forms.Button();
            this.DashboardAttendanceBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 40);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(302, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 567);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Automated Doorlock System Management";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1127, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 16);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.DashboardSignOutBttn);
            this.panel2.Controls.Add(this.FacultyBttn);
            this.panel2.Controls.Add(this.DashboardBttn);
            this.panel2.Controls.Add(this.DashboardAttendanceBttn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 581);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DashboardSignOutBttn
            // 
            this.DashboardSignOutBttn.BackColor = System.Drawing.Color.Navy;
            this.DashboardSignOutBttn.ForeColor = System.Drawing.Color.White;
            this.DashboardSignOutBttn.Image = ((System.Drawing.Image)(resources.GetObject("DashboardSignOutBttn.Image")));
            this.DashboardSignOutBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardSignOutBttn.Location = new System.Drawing.Point(14, 528);
            this.DashboardSignOutBttn.Name = "DashboardSignOutBttn";
            this.DashboardSignOutBttn.Size = new System.Drawing.Size(137, 39);
            this.DashboardSignOutBttn.TabIndex = 3;
            this.DashboardSignOutBttn.Text = "SIGN OUT";
            this.DashboardSignOutBttn.UseVisualStyleBackColor = false;
            this.DashboardSignOutBttn.Click += new System.EventHandler(this.DashboardSignOutBttn_Click);
            // 
            // FacultyBttn
            // 
            this.FacultyBttn.BackColor = System.Drawing.Color.Navy;
            this.FacultyBttn.ForeColor = System.Drawing.Color.White;
            this.FacultyBttn.Location = new System.Drawing.Point(37, 349);
            this.FacultyBttn.Name = "FacultyBttn";
            this.FacultyBttn.Size = new System.Drawing.Size(200, 43);
            this.FacultyBttn.TabIndex = 3;
            this.FacultyBttn.Text = "FACULTY";
            this.FacultyBttn.UseVisualStyleBackColor = false;
            this.FacultyBttn.Click += new System.EventHandler(this.FacultyBttn_Click);
            // 
            // DashboardBttn
            // 
            this.DashboardBttn.BackColor = System.Drawing.Color.Navy;
            this.DashboardBttn.ForeColor = System.Drawing.Color.White;
            this.DashboardBttn.Image = ((System.Drawing.Image)(resources.GetObject("DashboardBttn.Image")));
            this.DashboardBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBttn.Location = new System.Drawing.Point(37, 221);
            this.DashboardBttn.Name = "DashboardBttn";
            this.DashboardBttn.Size = new System.Drawing.Size(200, 45);
            this.DashboardBttn.TabIndex = 3;
            this.DashboardBttn.Text = "DASHBOARD";
            this.DashboardBttn.UseVisualStyleBackColor = false;
            this.DashboardBttn.Click += new System.EventHandler(this.DashboardBttn_Click);
            // 
            // DashboardAttendanceBttn
            // 
            this.DashboardAttendanceBttn.BackColor = System.Drawing.Color.Navy;
            this.DashboardAttendanceBttn.ForeColor = System.Drawing.Color.White;
            this.DashboardAttendanceBttn.Image = ((System.Drawing.Image)(resources.GetObject("DashboardAttendanceBttn.Image")));
            this.DashboardAttendanceBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardAttendanceBttn.Location = new System.Drawing.Point(37, 285);
            this.DashboardAttendanceBttn.Name = "DashboardAttendanceBttn";
            this.DashboardAttendanceBttn.Size = new System.Drawing.Size(200, 44);
            this.DashboardAttendanceBttn.TabIndex = 3;
            this.DashboardAttendanceBttn.Text = "ATTENDANCE";
            this.DashboardAttendanceBttn.UseVisualStyleBackColor = false;
            this.DashboardAttendanceBttn.Click += new System.EventHandler(this.DashboardAttendanceBttn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(11, 517);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.Black;
            this.greet_user.Location = new System.Drawing.Point(76, 160);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(115, 19);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, User";
            this.greet_user.Click += new System.EventHandler(this.greet_user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(80, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(273, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 628);
            this.panel5.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 621);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "`";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DashboardAttendanceBttn;
        private System.Windows.Forms.Button DashboardBttn;
        private System.Windows.Forms.Button FacultyBttn;
        private System.Windows.Forms.Button DashboardSignOutBttn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}