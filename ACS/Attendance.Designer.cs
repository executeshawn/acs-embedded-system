namespace acs
{
    partial class Attendance
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
            this.ImportBttn = new System.Windows.Forms.Button();
            this.ExportBttn = new System.Windows.Forms.Button();
            this.LoadDataBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentAttendanceLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportBttn
            // 
            this.ImportBttn.BackColor = System.Drawing.Color.Navy;
            this.ImportBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBttn.ForeColor = System.Drawing.Color.White;
            this.ImportBttn.Location = new System.Drawing.Point(21, 410);
            this.ImportBttn.Name = "ImportBttn";
            this.ImportBttn.Size = new System.Drawing.Size(86, 28);
            this.ImportBttn.TabIndex = 3;
            this.ImportBttn.Text = "IMPORT";
            this.ImportBttn.UseVisualStyleBackColor = false;
            this.ImportBttn.Click += new System.EventHandler(this.ImportBttn_Click);
            // 
            // ExportBttn
            // 
            this.ExportBttn.BackColor = System.Drawing.Color.Navy;
            this.ExportBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBttn.ForeColor = System.Drawing.Color.White;
            this.ExportBttn.Location = new System.Drawing.Point(137, 410);
            this.ExportBttn.Name = "ExportBttn";
            this.ExportBttn.Size = new System.Drawing.Size(85, 28);
            this.ExportBttn.TabIndex = 4;
            this.ExportBttn.Text = "EXPORT";
            this.ExportBttn.UseVisualStyleBackColor = false;
            this.ExportBttn.Click += new System.EventHandler(this.ExportBttn_Click);
            // 
            // LoadDataBttn
            // 
            this.LoadDataBttn.BackColor = System.Drawing.Color.Navy;
            this.LoadDataBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataBttn.ForeColor = System.Drawing.Color.White;
            this.LoadDataBttn.Location = new System.Drawing.Point(764, 410);
            this.LoadDataBttn.Name = "LoadDataBttn";
            this.LoadDataBttn.Size = new System.Drawing.Size(91, 28);
            this.LoadDataBttn.TabIndex = 5;
            this.LoadDataBttn.Text = "LOAD DATA";
            this.LoadDataBttn.UseVisualStyleBackColor = false;
            this.LoadDataBttn.Click += new System.EventHandler(this.LoadDataBttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 305);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDataBttn_Click);
            // 
            // StudentAttendanceLabel
            // 
            this.StudentAttendanceLabel.AutoSize = true;
            this.StudentAttendanceLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAttendanceLabel.Location = new System.Drawing.Point(17, 42);
            this.StudentAttendanceLabel.Name = "StudentAttendanceLabel";
            this.StudentAttendanceLabel.Size = new System.Drawing.Size(238, 23);
            this.StudentAttendanceLabel.TabIndex = 7;
            this.StudentAttendanceLabel.Text = "STUDENT ATTENDANCE";
            this.StudentAttendanceLabel.Click += new System.EventHandler(this.StudentAttendanceLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(646, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);

            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.StudentAttendanceLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoadDataBttn);
            this.Controls.Add(this.ExportBttn);
            this.Controls.Add(this.ImportBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ImportBttn;
        private System.Windows.Forms.Button ExportBttn;
        private System.Windows.Forms.Button LoadDataBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StudentAttendanceLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}