using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Security.Cryptography; // Add this namespace
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;


namespace acs
{
    public partial class RegisterAccount : Form
    {
        public RegisterAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            RegPasswordText.UseSystemPasswordChar = true;
            RegShowPass.CheckedChanged += RegShowPass_CheckedChanged;
            this.RegAccBttn.Click += new System.EventHandler(this.RegAccBttn_Click);
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "0CzZEMzIAgQoQjEVNwObMl9C4YBZz5WbYI2ZisCz",
            BasePath = "https://acs-embedded-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase. Check your internet connection or Firebase configuration.");
            }
        }
        private void InitializeFirebase()
        {
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(@"C:\Users\EZWorks\Downloads\ACS-master\acs-embedded-firebase-adminsdk-c1k01-3b489dead3") // Replace with your JSON file path
                });
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RegShowPass_CheckedChanged(object sender, EventArgs e)
        {
            RegPasswordText.UseSystemPasswordChar = !RegShowPass.Checked;
        }

        private void RegToLoginSignInBttn_Click(object sender, EventArgs e)
        {
            LoginAccount loginForm = new LoginAccount();
            loginForm.Show();
            this.Hide();
        }
        private static string GenerateDeviceToken(string userId)
        {
            // Combine user ID with a timestamp or random string
            string input = userId + DateTime.UtcNow.ToString("o");

            // Use SHA256 to hash the input for a unique and secure token
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hash);
            }
        }
        private bool isRegistered = false;

        private async void RegAccBttn_Click(object sender, EventArgs e)
        {
            isRegistered = false;
            string username = RegAccEmail.Text;
            string password = RegPasswordText.Text;
            string phoneNumber = PhoneNumText.Text;

            // Validate username (Institutional Email / ID Number)
            if (!Regex.IsMatch(username, @"^\d{9}$"))
            {
                MessageBox.Show("Institutional Email should contain exactly 9 numeric characters.");
                return;
            }

            // Validate password
            if (password.Length > 30)
            {
                MessageBox.Show("Password should not exceed 30 characters.");
                return;
            }

            // Validate phone number
            if (!IsValidPhilippinePhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone number should contain exactly 11 numeric characters and start with 09.");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill out all fields for registration.");
                return;
            }

            try
            {
                // Automatically generate a device token
                string deviceToken = GenerateDeviceToken(username);

                var user = new User
                {
                    Username = username,
                    Password = password,
                    PhoneNumber = phoneNumber,
                    DeviceToken = deviceToken // Automatically generated token
                };

                SetResponse response = await client.SetAsync("Users/" + username, user);

                if (response.StatusCode == System.Net.HttpStatusCode.OK && !isRegistered)
                {
                    isRegistered = true;
                    MessageBox.Show("Registration successful!");
                }
                else if (!isRegistered)
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void RegPasswordText_TextChanged(object sender, EventArgs e)
        {
            if (RegPasswordText.Text.Length > 30)
            {
                MessageBox.Show("Password cannot exceed 30 characters.");
                RegPasswordText.Text = RegPasswordText.Text.Substring(0, 30);
                RegPasswordText.SelectionStart = RegPasswordText.Text.Length;
            }
        }

        private void RegAccEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(RegAccEmail.Text, @"^\d*$"))
            {
                MessageBox.Show("Wrong Input! Only Numeric. Try again");
                RegAccEmail.Text = Regex.Replace(RegAccEmail.Text, @"\D", "");
                RegAccEmail.SelectionStart = RegAccEmail.Text.Length;
            }

            if (RegAccEmail.Text.Length > 9)
            {
                MessageBox.Show("ID Number cannot exceed 9 digits.");
                RegAccEmail.Text = RegAccEmail.Text.Substring(0, 9);
                RegAccEmail.SelectionStart = RegAccEmail.Text.Length;
            }
        }

        private void PhoneNumText_TextChanged(object sender, EventArgs e)
        {
            // Validate phone number as numeric and limited to 11 digits
            if (!Regex.IsMatch(PhoneNumText.Text, @"^\d*$"))
            {
                MessageBox.Show("Phone number should contain only numeric characters.");
                PhoneNumText.Text = Regex.Replace(PhoneNumText.Text, @"\D", "");
                PhoneNumText.SelectionStart = PhoneNumText.Text.Length;
            }

            if (PhoneNumText.Text.Length > 11)
            {
                MessageBox.Show("Phone number cannot exceed 11 digits.");
                PhoneNumText.Text = PhoneNumText.Text.Substring(0, 11);
                PhoneNumText.SelectionStart = PhoneNumText.Text.Length;
            }
        }

        private bool IsValidPhilippinePhoneNumber(string phoneNumber)
        {
            // Validate phone number (11 digits, starts with 09)
            return Regex.IsMatch(phoneNumber, @"^09\d{9}$");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string PhoneNumber { get; set; } // Added PhoneNumber property
            public string DeviceToken { get; set; } // Added DeviceToken property
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

       
    }
}
