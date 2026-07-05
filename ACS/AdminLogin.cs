using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace acs
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            AdminPassword.UseSystemPasswordChar = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            LoginBttn.Click += LoginBttn_Click;
            ForgotPasswordChange.Click += ForgotPasswordChange_Click; // Attach the event handler
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "0CzZEMzIAgQoQjEVNwObMl9C4YBZz5WbYI2ZisCz",
            BasePath = "https://acs-embedded-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase. Check your internet connection or Firebase configuration.");
            }
        }

        private void AdminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AdminPassword.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private async void LoginBttn_Click(object sender, EventArgs e)
        {
            string defaultAdminUsername = "admin@cit.edu";
            string defaultAdminPassword = "admincit@2024!";

            string enteredUsername = AdminUsername.Text;
            string enteredPassword = AdminPassword.Text;

            // Admin credentials validation
            if (enteredUsername == defaultAdminUsername && enteredPassword == defaultAdminPassword)
            {
                LoginBttn.Enabled = false;

                // Save phone number to Firebase only if provided
                string phoneNumber = PhoneNumText.Text;
                if (!string.IsNullOrEmpty(phoneNumber) && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^09\d{9}$"))
                {
                    try
                    {
                        var adminData = new
                        {
                            Username = enteredUsername,
                            Password = enteredPassword,
                            PhoneNumber = phoneNumber
                        };

                        SetResponse response = await client.SetAsync("Admins/" + enteredUsername.Replace(".", "_"), adminData);

                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("Phone number saved successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving phone number: {ex.Message}");
                    }
                }

                // Navigate to AdminDashboard
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminDashboard adminDashboardForm = new AdminDashboard();
                adminDashboardForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid admin username or password.");
            }
        }

        private void ForgotPasswordChange_Click(object sender, EventArgs e)
        {
            string phoneNumber = PhoneNumText.Text;

            // Validate phone number before navigating to ForgotPassword form
            if (string.IsNullOrEmpty(phoneNumber) || !System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^09\d{9}$"))
            {
                MessageBox.Show("Please input a valid phone number starting with '09' to reset your password.");
                return;
            }

            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
            this.Hide(); // Hide the current login form
        }

        private void PhoneNumText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAccount loginForm = new LoginAccount();
            loginForm.Show();


            this.Close();
        }
    }
}
