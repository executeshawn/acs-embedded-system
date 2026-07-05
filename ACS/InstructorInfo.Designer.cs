namespace acs
{
    partial class InstructorInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimePMtext = new System.Windows.Forms.TextBox();
            this.TimeAMtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomNumberComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Building = new System.Windows.Forms.Label();
            this.AddBttn = new System.Windows.Forms.Button();
            this.choicesComboBox = new System.Windows.Forms.ComboBox();
            this.ClearBttn = new System.Windows.Forms.Button();
            this.UpdateBttn = new System.Windows.Forms.Button();
            this.FullNameText = new System.Windows.Forms.RichTextBox();
            this.InstructorIDText = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadBttn = new System.Windows.Forms.Button();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.RFIDcardText = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(316, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 463);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(508, 374);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.RFIDcardText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TimePMtext);
            this.panel1.Controls.Add(this.TimeAMtxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RoomNumberComboBox);
            this.panel1.Controls.Add(this.BuildingTypeComboBox);
            this.panel1.Controls.Add(this.Building);
            this.panel1.Controls.Add(this.choicesComboBox);
            this.panel1.Controls.Add(this.FullNameText);
            this.panel1.Controls.Add(this.InstructorIDText);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 517);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(105, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "AM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(229, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "PM";
            // 
            // TimePMtext
            // 
            this.TimePMtext.Location = new System.Drawing.Point(151, 480);
            this.TimePMtext.Name = "TimePMtext";
            this.TimePMtext.Size = new System.Drawing.Size(104, 20);
            this.TimePMtext.TabIndex = 29;
            this.TimePMtext.TextChanged += new System.EventHandler(this.TimePMtext_TextChanged);
            // 
            // TimeAMtxt
            // 
            this.TimeAMtxt.Location = new System.Drawing.Point(25, 480);
            this.TimeAMtxt.Name = "TimeAMtxt";
            this.TimeAMtxt.Size = new System.Drawing.Size(106, 20);
            this.TimeAMtxt.TabIndex = 28;
            this.TimeAMtxt.TextChanged += new System.EventHandler(this.TimeAMtxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Input Time:";
            // 
            // RoomNumberComboBox
            // 
            this.RoomNumberComboBox.FormattingEnabled = true;
            this.RoomNumberComboBox.Location = new System.Drawing.Point(200, 210);
            this.RoomNumberComboBox.Name = "RoomNumberComboBox";
            this.RoomNumberComboBox.Size = new System.Drawing.Size(74, 21);
            this.RoomNumberComboBox.TabIndex = 5;
            this.RoomNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomNumberComboBox_SelectedIndexChanged);
            // 
            // BuildingTypeComboBox
            // 
            this.BuildingTypeComboBox.FormattingEnabled = true;
            this.BuildingTypeComboBox.Location = new System.Drawing.Point(22, 210);
            this.BuildingTypeComboBox.Name = "BuildingTypeComboBox";
            this.BuildingTypeComboBox.Size = new System.Drawing.Size(172, 21);
            this.BuildingTypeComboBox.TabIndex = 21;
            this.BuildingTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.BuildingTypeComboBox_SelectedIndexChanged);
            // 
            // Building
            // 
            this.Building.AutoSize = true;
            this.Building.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Building.Location = new System.Drawing.Point(19, 186);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(60, 16);
            this.Building.TabIndex = 20;
            this.Building.Text = "Building /";
            // 
            // AddBttn
            // 
            this.AddBttn.BackColor = System.Drawing.Color.Navy;
            this.AddBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBttn.ForeColor = System.Drawing.Color.White;
            this.AddBttn.Location = new System.Drawing.Point(405, 510);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(75, 29);
            this.AddBttn.TabIndex = 5;
            this.AddBttn.Text = "ADD";
            this.AddBttn.UseVisualStyleBackColor = false;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // choicesComboBox
            // 
            this.choicesComboBox.FormattingEnabled = true;
            this.choicesComboBox.Location = new System.Drawing.Point(22, 258);
            this.choicesComboBox.Name = "choicesComboBox";
            this.choicesComboBox.Size = new System.Drawing.Size(239, 21);
            this.choicesComboBox.TabIndex = 5;
            this.choicesComboBox.SelectedIndexChanged += new System.EventHandler(this.choicesComboBox_SelectedIndexChanged);
            // 
            // ClearBttn
            // 
            this.ClearBttn.BackColor = System.Drawing.Color.Navy;
            this.ClearBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBttn.ForeColor = System.Drawing.Color.White;
            this.ClearBttn.Location = new System.Drawing.Point(483, 510);
            this.ClearBttn.Name = "ClearBttn";
            this.ClearBttn.Size = new System.Drawing.Size(81, 29);
            this.ClearBttn.TabIndex = 5;
            this.ClearBttn.Text = "CLEAR";
            this.ClearBttn.UseVisualStyleBackColor = false;
            this.ClearBttn.Click += new System.EventHandler(this.ClearBttn_Click);
            // 
            // UpdateBttn
            // 
            this.UpdateBttn.BackColor = System.Drawing.Color.Navy;
            this.UpdateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBttn.ForeColor = System.Drawing.Color.White;
            this.UpdateBttn.Location = new System.Drawing.Point(315, 510);
            this.UpdateBttn.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateBttn.Name = "UpdateBttn";
            this.UpdateBttn.Size = new System.Drawing.Size(86, 29);
            this.UpdateBttn.TabIndex = 5;
            this.UpdateBttn.Text = "UPDATE";
            this.UpdateBttn.UseVisualStyleBackColor = false;
            this.UpdateBttn.Click += new System.EventHandler(this.UpdateBttn_Click);
            // 
            // FullNameText
            // 
            this.FullNameText.Location = new System.Drawing.Point(22, 148);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(239, 26);
            this.FullNameText.TabIndex = 5;
            this.FullNameText.Text = "";
            this.FullNameText.TextChanged += new System.EventHandler(this.FullNameText_TextChanged);
            // 
            // InstructorIDText
            // 
            this.InstructorIDText.Location = new System.Drawing.Point(22, 90);
            this.InstructorIDText.Name = "InstructorIDText";
            this.InstructorIDText.Size = new System.Drawing.Size(239, 25);
            this.InstructorIDText.TabIndex = 5;
            this.InstructorIDText.Text = "";
            this.InstructorIDText.TextChanged += new System.EventHandler(this.InstructorIDText_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 285);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instructor  ID:";
            // 
            // LoadBttn
            // 
            this.LoadBttn.BackColor = System.Drawing.Color.Navy;
            this.LoadBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBttn.ForeColor = System.Drawing.Color.White;
            this.LoadBttn.Location = new System.Drawing.Point(759, 510);
            this.LoadBttn.Name = "LoadBttn";
            this.LoadBttn.Size = new System.Drawing.Size(104, 33);
            this.LoadBttn.TabIndex = 6;
            this.LoadBttn.Text = "LOAD";
            this.LoadBttn.UseVisualStyleBackColor = false;
            this.LoadBttn.Click += new System.EventHandler(this.LoadBttn_Click);
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.BackColor = System.Drawing.Color.Navy;
            this.DeleteBttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBttn.ForeColor = System.Drawing.Color.White;
            this.DeleteBttn.Location = new System.Drawing.Point(659, 510);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(94, 31);
            this.DeleteBttn.TabIndex = 7;
            this.DeleteBttn.Text = "DELETE";
            this.DeleteBttn.UseVisualStyleBackColor = false;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // RFIDcardText
            // 
            this.RFIDcardText.Location = new System.Drawing.Point(22, 27);
            this.RFIDcardText.Name = "RFIDcardText";
            this.RFIDcardText.Size = new System.Drawing.Size(239, 25);
            this.RFIDcardText.TabIndex = 8;
            this.RFIDcardText.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "RFID Card Number:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // InstructorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 565);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.LoadBttn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClearBttn);
            this.Controls.Add(this.UpdateBttn);
            this.Controls.Add(this.AddBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructorInfo";
            this.Text = "InstructorInfo";
            this.Load += new System.EventHandler(this.InstructorInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button UpdateBttn;
        private System.Windows.Forms.RichTextBox FullNameText;
        private System.Windows.Forms.RichTextBox InstructorIDText;
        private System.Windows.Forms.Button ClearBttn;
        private System.Windows.Forms.ComboBox choicesComboBox;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Button LoadBttn;
        private System.Windows.Forms.ComboBox BuildingTypeComboBox;
        private System.Windows.Forms.Label Building;
        private System.Windows.Forms.ComboBox RoomNumberComboBox;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TimePMtext;
        private System.Windows.Forms.TextBox TimeAMtxt;
        private System.Windows.Forms.RichTextBox RFIDcardText;
        private System.Windows.Forms.Label label8;
    }
}