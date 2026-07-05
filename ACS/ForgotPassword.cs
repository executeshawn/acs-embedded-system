using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.Threading.Tasks;
using System.Threading;

namespace acs
{
    public partial class ForgotPassword : Form
    {
        private string generatedOTP; // Stores the generated OTP
        private bool isOTPVerified = false; // Tracks OTP verification status
        private IFirebaseClient client;

        public ForgotPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Firebase configuration
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "0CzZEMzIAgQoQjEVNwObMl9C4YBZz5WbYI2ZisCz",
                BasePath = "https://acs-embedded-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };

            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase. Check your internet connection or Firebase configuration.");
            }

            // Initialize Firebase Admin SDK
            InitializeFirebase();
        }

        private void InitializeFirebase()
        {
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(@"C:\Users\clare\source\repos\ACS\ACS\acs-automated-door-lock-system-firebase-adminsdk-bz43s-fb88f9cfca.json") // Replace with your JSON file path
                });
            }
        }


        private void ForgotPassword_Load(object sender, EventArgs e)
        {
        }

        private async void SendOTPbttn_Click(object sender, EventArgs e)
        {
            string idOrUsername = IDNumberText.Text.Trim(); // Can be ID Number or Admin Username

            if (string.IsNullOrEmpty(idOrUsername))
            {
                MessageBox.Show("Please enter your ID Number or Admin Username.");
                return;
            }

            try
            {
                FirebaseResponse response;
                if (idOrUsername == "admin@cit.edu")
                {
                    // Check for admin account
                    response = await client.GetAsync("Admins/" + idOrUsername.Replace(".", "_"));
                    if (response.Body == "null")
                    {
                        MessageBox.Show("Admin account not found. Please input the correct admin username.");
                        return;
                    }
                }
                else
                {
                    // Check for user account with ID Number
                    response = await client.GetAsync("Users/" + idOrUsername);
                    if (response.Body == "null")
                    {
                        MessageBox.Show("User not found. Please check your ID Number.");
                        return;
                    }
                }

                var user = response.ResultAs<RegisterAccount.User>();
                string phoneNumber = user.PhoneNumber;

                // Validate phone number
                if (!Regex.IsMatch(phoneNumber, @"^09\d{9}$"))
                {
                    MessageBox.Show("The registered phone number is invalid. Ensure it is a valid Philippine number starting with 09.");
                    return;
                }

                // Generate OTP
                generatedOTP = GenerateOTP(6);

                // Save OTP to Firebase
                var otpData = new { OTP = generatedOTP, Expiry = DateTime.UtcNow.AddMinutes(5).ToString("o") };
                await client.SetAsync($"OTPs/{idOrUsername.Replace(".", "_")}", otpData);

                MessageBox.Show($"OTP sent successfully to {phoneNumber}. Please enter the OTP.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send OTP. Error: {ex.Message}");
            }
        }



        private void VerifyOTPbttn_Click(object sender, EventArgs e)
        {
            string inputOTP = OTPtxt.Text;

            if (string.IsNullOrEmpty(inputOTP))
            {
                MessageBox.Show("Please enter the OTP.");
                return;
            }

            if (string.IsNullOrEmpty(generatedOTP))
            {
                MessageBox.Show("No OTP has been sent yet. Please request an OTP first.");
                return;
            }

            try
            {
                // Compare the input OTP with the generated OTP
                if (inputOTP == generatedOTP)
                {
                    isOTPVerified = true;
                    ChangePasswordBttn.Enabled = true;
                    MessageBox.Show("OTP verified successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid OTP. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Verification failed: {ex.Message}");
            }
        }

        private string GenerateOTP(int length)
        {
            const string numbers = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(numbers, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private async void ChangePasswordBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isOTPVerified)
                {
                    MessageBox.Show("OTP verification is required before changing the password.");
                    return;
                }

                string idOrUsername = IDNumberText.Text.Trim();
                string newPassword = newpasswordchangetxt.Text.Trim();
                string confirmPassword = ConfirmPasswordtext.Text.Trim();

                // Validate input fields
                if (string.IsNullOrEmpty(idOrUsername))
                {
                    MessageBox.Show("Please enter your ID Number or Admin Username.");
                    return;
                }

                if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill out all password fields.");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                    return;
                }

                // Check for admin account
                FirebaseResponse response;
                if (idOrUsername == "admin@cit.edu")
                {
                    response = await client.GetAsync("Admins/" + idOrUsername.Replace(".", "_"));
                    if (response.Body == "null")
                    {
                        MessageBox.Show("Admin account not found. Please input the correct admin username.");
                        return;
                    }
                }
                else
                {
                    // Check for user account with ID Number
                    response = await client.GetAsync("Users/" + idOrUsername);
                    if (response.Body == "null")
                    {
                        MessageBox.Show("User not found. Please check your ID Number.");
                        return;
                    }
                }

                // Update password
                var user = response.ResultAs<RegisterAccount.User>();
                user.Password = newPassword;

                // Save updated user details back to Firebase
                string key = idOrUsername == "admin@cit.edu" ? "Admins/" + idOrUsername.Replace(".", "_") : "Users/" + idOrUsername;
                SetResponse updateResponse = await client.SetAsync(key, user);

                if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Password updated successfully!");

                    // Redirect to Login form after 2 seconds
                    var timer = new System.Windows.Forms.Timer { Interval = 2000 };
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        this.Hide();
                        LoginAccount loginForm = new LoginAccount();
                        loginForm.Show();
                    };
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Failed to update password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void OTPtxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void IDNumberText_TextChanged(object sender, EventArgs e)
        {
        }

        private void ChangePasswordBttn_Click_1(object sender, EventArgs e)
        {
        }

        private void newpasswordchangetxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConfirmPasswordtext_TextChanged(object sender, EventArgs e)
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
