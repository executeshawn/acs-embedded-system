using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acs
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "00DG4KD9kG8FLtURtxXpC2AjIrLsHWv74ygyAqot",
            BasePath = "https://acs-automated-door-lock-system-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void Attendance_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase. Check your internet connection or Firebase configuration.");
            }
        }
        private void ADSMpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Import attendance data from CSV
        private void ImportBttn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "CSV File|*.csv",
                    Title = "Import Attendance Data"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string[] headers = sr.ReadLine().Split(',');
                        foreach (string header in headers)
                        {
                            dt.Columns.Add(header);
                        }

                        while (!sr.EndOfStream)
                        {
                            dt.Rows.Add(sr.ReadLine().Split(','));
                        }
                    }

                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Data imported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing data: {ex.Message}");
            }
        }

        // Export attendance data to CSV
        private void ExportBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV File|*.csv",
                    Title = "Export Attendance Data"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write headers
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(dataGridView1.Columns[i].HeaderText + (i == dataGridView1.Columns.Count - 1 ? "" : ","));
                        }
                        sw.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value + (i == row.Cells.Count - 1 ? "" : ","));
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Data exported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}");
            }
        }

        // Load attendance data from Firebase
        private async void LoadDataBttn_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Students");
                var students = response.ResultAs<Dictionary<string, Student>>();

                DataTable dt = new DataTable();
                dt.Columns.Add("Student ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Department");
                dt.Columns.Add("Room Number");
                dt.Columns.Add("RFID Card");
                dt.Columns.Add("Attendance Time");

                foreach (var student in students.Values)
                {
                    string attendanceTime = student.AttendanceRecords.ContainsKey(DateTime.Now.ToString("yyyy-MM-dd"))
                        ? student.AttendanceRecords[DateTime.Now.ToString("yyyy-MM-dd")]
                        : "Absent";

                    dt.Rows.Add(student.StudentID, student.Name, student.Department, student.RoomNumber, student.RFIDCard, attendanceTime);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        // Record attendance (Time-In or Time-Out)
        private async void RecordAttendance(string rfidCard)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Students");
                var students = response.ResultAs<Dictionary<string, Student>>();

                var matchedStudent = students.Values.FirstOrDefault(s => s.RFIDCard == rfidCard);
                if (matchedStudent != null)
                {
                    string dateKey = DateTime.Now.ToString("yyyy-MM-dd");
                    string timeNow = DateTime.Now.ToString("HH:mm:ss");

                    if (matchedStudent.AttendanceRecords.ContainsKey(dateKey))
                    {
                        matchedStudent.AttendanceRecords[dateKey] += $", Out: {timeNow}";
                    }
                    else
                    {
                        matchedStudent.AttendanceRecords[dateKey] = $"In: {timeNow}";
                    }

                    await client.SetAsync($"Students/{matchedStudent.StudentID}", matchedStudent);
                    MessageBox.Show($"Attendance recorded for {matchedStudent.Name}");
                }
                else
                {
                    MessageBox.Show("RFID card not recognized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording attendance: {ex.Message}");
            }
        }

        private void StudentAttendanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
    // Define Student class
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string RoomNumber { get; set; }
        public string RFIDCard { get; set; }
        public Dictionary<string, string> AttendanceRecords { get; set; } = new Dictionary<string, string>();
    }
}
