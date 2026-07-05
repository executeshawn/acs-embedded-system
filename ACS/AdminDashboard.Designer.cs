namespace acs
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBttn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImportBttn = new System.Windows.Forms.Button();
            this.ExportBttn = new System.Windows.Forms.Button();
            this.EditBttn = new System.Windows.Forms.Button();
            this.SaveBttn = new System.Windows.Forms.Button();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.ClearBttn = new System.Windows.Forms.Button();
            this.LoadBttn = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutBttn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.exitBttn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 41);
            this.panel1.TabIndex = 0;
            // 
            // exitBttn
            // 
            this.exitBttn.AutoSize = true;
            this.exitBttn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.ForeColor = System.Drawing.Color.White;
            this.exitBttn.Location = new System.Drawing.Point(771, 7);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(24, 25);
            this.exitBttn.TabIndex = 2;
            this.exitBttn.Text = "X";
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Automated Door Lock System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "ENTRY LOGS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(14, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 277);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ImportBttn
            // 
            this.ImportBttn.BackColor = System.Drawing.Color.Navy;
            this.ImportBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBttn.ForeColor = System.Drawing.Color.White;
            this.ImportBttn.Location = new System.Drawing.Point(17, 404);
            this.ImportBttn.Name = "ImportBttn";
            this.ImportBttn.Size = new System.Drawing.Size(81, 34);
            this.ImportBttn.TabIndex = 3;
            this.ImportBttn.Text = "IMPORT";
            this.ImportBttn.UseVisualStyleBackColor = false;
            // 
            // ExportBttn
            // 
            this.ExportBttn.BackColor = System.Drawing.Color.Navy;
            this.ExportBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBttn.ForeColor = System.Drawing.Color.White;
            this.ExportBttn.Location = new System.Drawing.Point(104, 404);
            this.ExportBttn.Name = "ExportBttn";
            this.ExportBttn.Size = new System.Drawing.Size(84, 34);
            this.ExportBttn.TabIndex = 4;
            this.ExportBttn.Text = "EXPORT";
            this.ExportBttn.UseVisualStyleBackColor = false;
            // 
            // EditBttn
            // 
            this.EditBttn.BackColor = System.Drawing.Color.Navy;
            this.EditBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBttn.ForeColor = System.Drawing.Color.White;
            this.EditBttn.Location = new System.Drawing.Point(467, 404);
            this.EditBttn.Name = "EditBttn";
            this.EditBttn.Size = new System.Drawing.Size(75, 34);
            this.EditBttn.TabIndex = 5;
            this.EditBttn.Text = "EDIT";
            this.EditBttn.UseVisualStyleBackColor = false;
            // 
            // SaveBttn
            // 
            this.SaveBttn.BackColor = System.Drawing.Color.Navy;
            this.SaveBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBttn.ForeColor = System.Drawing.Color.White;
            this.SaveBttn.Location = new System.Drawing.Point(629, 404);
            this.SaveBttn.Name = "SaveBttn";
            this.SaveBttn.Size = new System.Drawing.Size(75, 34);
            this.SaveBttn.TabIndex = 6;
            this.SaveBttn.Text = "SAVE";
            this.SaveBttn.UseVisualStyleBackColor = false;
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.BackColor = System.Drawing.Color.Navy;
            this.DeleteBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBttn.ForeColor = System.Drawing.Color.White;
            this.DeleteBttn.Location = new System.Drawing.Point(543, 404);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(80, 34);
            this.DeleteBttn.TabIndex = 7;
            this.DeleteBttn.Text = "DELETE";
            this.DeleteBttn.UseVisualStyleBackColor = false;
            // 
            // ClearBttn
            // 
            this.ClearBttn.BackColor = System.Drawing.Color.Navy;
            this.ClearBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBttn.ForeColor = System.Drawing.Color.White;
            this.ClearBttn.Location = new System.Drawing.Point(710, 404);
            this.ClearBttn.Name = "ClearBttn";
            this.ClearBttn.Size = new System.Drawing.Size(75, 34);
            this.ClearBttn.TabIndex = 8;
            this.ClearBttn.Text = "CLEAR";
            this.ClearBttn.UseVisualStyleBackColor = false;
            // 
            // LoadBttn
            // 
            this.LoadBttn.BackColor = System.Drawing.Color.Navy;
            this.LoadBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBttn.ForeColor = System.Drawing.Color.White;
            this.LoadBttn.Location = new System.Drawing.Point(710, 62);
            this.LoadBttn.Name = "LoadBttn";
            this.LoadBttn.Size = new System.Drawing.Size(75, 34);
            this.LoadBttn.TabIndex = 9;
            this.LoadBttn.Text = "LOAD";
            this.LoadBttn.UseVisualStyleBackColor = false;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(448, 72);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(256, 20);
            this.SearchBar.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(683, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutBttn
            // 
            this.LogoutBttn.BackColor = System.Drawing.Color.Navy;
            this.LogoutBttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBttn.ForeColor = System.Drawing.Color.White;
            this.LogoutBttn.Location = new System.Drawing.Point(305, 404);
            this.LogoutBttn.Name = "LogoutBttn";
            this.LogoutBttn.Size = new System.Drawing.Size(75, 36);
            this.LogoutBttn.TabIndex = 12;
            this.LogoutBttn.Text = "LOGOUT";
            this.LogoutBttn.UseVisualStyleBackColor = false;
            this.LogoutBttn.Click += new System.EventHandler(this.LogoutBttn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBttn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.LoadBttn);
            this.Controls.Add(this.ClearBttn);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.SaveBttn);
            this.Controls.Add(this.EditBttn);
            this.Controls.Add(this.ExportBttn);
            this.Controls.Add(this.ImportBttn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImportBttn;
        private System.Windows.Forms.Button ExportBttn;
        private System.Windows.Forms.Button EditBttn;
        private System.Windows.Forms.Button SaveBttn;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.Button ClearBttn;
        private System.Windows.Forms.Button LoadBttn;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exitBttn;
        private System.Windows.Forms.Button LogoutBttn;
    }
}