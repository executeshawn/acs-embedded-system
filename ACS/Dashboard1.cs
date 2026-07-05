using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net; 

namespace acs
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "0CzZEMzIAgQoQjEVNwObMl9C4YBZz5WbYI2ZisCz",
            BasePath = "https://acs-embedded-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private async void Dashboard1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase.");
                return;
            }

            try
            {
                
                FirebaseResponse response = await client.GetAsync("Instructors");
                Dictionary<string, dynamic> instructors = response.ResultAs<Dictionary<string, dynamic>>();

                if (instructors != null)
                {
                    
                    string roomNumbers = "";
                    foreach (var instructorEntry in instructors)
                    {
                        var instructor = instructorEntry.Value;
                        string roomNumber = instructor.RoomNumber ?? "";
                        if (!string.IsNullOrEmpty(roomNumber))
                        {
                            roomNumbers += roomNumber + "\n";
                        }
                    }

                    
                    RoomNumber.Text = roomNumbers.Trim();
                }
                else
                {
                    MessageBox.Show("No data found in the database.");
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void RoomNumber_Click(object sender, EventArgs e)
        {

        }

        
    }
}
