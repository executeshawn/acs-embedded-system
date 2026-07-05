using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acs
{
    public partial class InstructorInfo : Form
    {
        public InstructorInfo()
        {
            InitializeComponent();

            choicesComboBox.Items.AddRange(new string[] { "Architecture", "Electrical Engineering", "Industrial Engineering", "Chemical Engineering", "Computer Engineering" });

            BuildingTypeComboBox.Items.Clear();
            BuildingTypeComboBox.Items.Add("GLE");

            RoomNumberComboBox.Items.AddRange(new string[] {
                "201", "202", "203", "204", "205", "206",
                "301", "302", "303", "304", "305", "306",
                "401", "402", "403", "404", "405", "406",
                "501", "502", "503", "504", "505", "506",
                "601", "602", "603", "604", "605", "606",
                "701", "702", "703", "704", "705", "706",
                "801", "802", "803", "804", "805", "806"
            });

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "0CzZEMzIAgQoQjEVNwObMl9C4YBZz5WbYI2ZisCz",
            BasePath = "https://acs-embedded-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void InstructorInfo_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase. Check your internet connection or Firebase configuration.");
            }
        }
        private void InstructorIDText_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(InstructorIDText.Text, "^[0-9]{0,9}$"))
            {
                MessageBox.Show("Instructor ID must be a numeric value with a maximum of 9 digits.");
                InstructorIDText.Text = InstructorIDText.Text.Remove(InstructorIDText.Text.Length - 1);
                InstructorIDText.SelectionStart = InstructorIDText.Text.Length;
            }
        }

        private void FullNameText_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void choicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private async void UpdateBttn_Click(object sender, EventArgs e)
        {
            string sanitizedID = InstructorIDText.Text.Replace(" ", "_");

            var instructor = new
            {
                RFIDCard = RFIDcardText,
                InstructorID = sanitizedID,
                FullName = FullNameText.Text,
                Department = choicesComboBox.Text,
                BuildingType = BuildingTypeComboBox.Text,
                RoomNumber = RoomNumberComboBox.Text,
                Date = monthCalendar1.SelectionStart.ToShortDateString(),
                TimeAM = TimeAMtxt.Text,
                TimePM = TimePMtext.Text

            };

            FirebaseResponse response = await client.UpdateAsync($"Instructors/{sanitizedID}", instructor);
            MessageBox.Show("Data updated successfully!");
        }

        private async void AddBttn_Click(object sender, EventArgs e)
        {
            string sanitizedID = InstructorIDText.Text.Replace(" ", "_");

            var instructor = new
            {
                RFIDCard = RFIDcardText,
                InstructorID = sanitizedID,
                FullName = FullNameText.Text,
                Department = choicesComboBox.Text,
                BuildingType = BuildingTypeComboBox.Text,
                RoomNumber = RoomNumberComboBox.Text,
                Date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"),
                TimeAM = TimeAMtxt.Text,
                TimePM = TimePMtext.Text
            };

            SetResponse response = await client.SetAsync($"Instructors/{sanitizedID}", instructor);
            MessageBox.Show("Data added successfully!");
        }

        private void ClearBttn_Click(object sender, EventArgs e)
        {
            RFIDcardText.Clear();
            InstructorIDText.Clear();
            FullNameText.Clear();
            choicesComboBox.SelectedIndex = -1;
            BuildingTypeComboBox.SelectedIndex = -1;
            RoomNumberComboBox.SelectedIndex = -1;
            monthCalendar1.SetDate(DateTime.Now); // Resets the calendar to today's date
            TimeAMtxt.Clear(); // Clear the TimeAM field
            TimePMtext.Clear(); // Clear the TimePM field
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private async void LoadBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("InstructorID", "Instructor ID");
                    dataGridView1.Columns.Add("FullName", "Full Name");
                    dataGridView1.Columns.Add("RoomNumber", "Room Number");
                    dataGridView1.Columns.Add("Department", "Department");
                    dataGridView1.Columns.Add("BuildingType", "Building Type");
                    dataGridView1.Columns.Add("Date", "Date");
                    dataGridView1.Columns.Add("TimeAM", "Time AM");
                    dataGridView1.Columns.Add("TimePM", "Time PM");
                }

                FirebaseResponse response = await client.GetAsync("Instructors");
                Dictionary<string, dynamic> instructors = response.ResultAs<Dictionary<string, dynamic>>();

                if (instructors != null)
                {
                    dataGridView1.Rows.Clear();

                    foreach (var instructorEntry in instructors)
                    {
                        var instructor = instructorEntry.Value;
                        string instructorID = instructorEntry.Key;
                        string fullName = instructor.FullName ?? "";
                        string roomNumber = instructor.RoomNumber ?? "";
                        string department = instructor.Department ?? "";
                        string buildingType = instructor.BuildingType ?? "";
                        string date = instructor.Date ?? "";
                        string timeAM = instructor.TimeAM ?? "";
                        string timePM = instructor.TimePM ?? "";

                        dataGridView1.Rows.Add(instructorID, fullName, roomNumber, department, buildingType, date, timeAM, timePM);
                    }
                    MessageBox.Show("All data loaded successfully!");
                }
                else
                {
                    MessageBox.Show("No data found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data. Error: {ex.Message}");
            }
        }
        private void BuildingTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RoomNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void DeleteBttn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete all records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();

                try
                {
                    FirebaseResponse response = await client.DeleteAsync("Instructors");

                    MessageBox.Show("All records deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete records. Error: {ex.Message}");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimeAMtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimePMtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
