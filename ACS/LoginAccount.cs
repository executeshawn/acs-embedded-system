using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace acs
{
    public partial class LoginAccount : Form
    {
        private RegisterAccount registrationForm;

        public LoginAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoginInAccountPasswordText.UseSystemPasswordChar = true;
            ShowPassCheckBox.CheckedChanged += ShowPassCheckBox_CheckedChanged;
            this.LoginSignInBttn.Click += new System.EventHandler(this.LoginSignInBttn_Click);
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "0CzZEMzIAgQoQjEVNwObMl9C4YBZz5WbYI2ZisCz",
            BasePath = "https://acs-embedded-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void Login_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Failed to connect to Firebase. Check your internet connection or Firebase configuration.");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private bool isSignIn = false;

        private async void LoginSignInBttn_Click(object sender, EventArgs e)
        {
            isSignIn = false;

            string username = LoginAccInstitutionalEmail.Text;
            string password = LoginInAccountPasswordText.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                if (client == null)
                {
                    MessageBox.Show("Unable to connect to Firebase. Please check your configuration.");
                    return;
                }

                FirebaseResponse response = await client.GetAsync("Users/" + username);

                if (response.Body == "null")
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                var user = response.ResultAs<User>();

                if (user != null && user.Password == password && !isSignIn)
                {
                    isSignIn = true;
                    MessageBox.Show("Login successful!");

                    Dashboard dashboardForm = new Dashboard();
                    dashboardForm.Show();
                    this.Hide();

                    if (registrationForm != null && !registrationForm.IsDisposed)
                    {
                        registrationForm.WindowState = FormWindowState.Minimized;
                    }
                }
                else if (!isSignIn)
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception)
            {
            }
        }

        private void RegisterAccSignUpBttn_Click(object sender, EventArgs e)
        {
            if (registrationForm == null || registrationForm.IsDisposed)
            {
                registrationForm = new RegisterAccount();
                registrationForm.Show();
            }
            else
            {
                registrationForm.BringToFront();
            }
            this.Hide();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginInAccountPasswordText.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
        }
        private void LoginInAccountPasswordText_TextChanged(object sender, EventArgs e)
        {
            if (LoginInAccountPasswordText.Text.Length > 30)
            {
                MessageBox.Show("Password cannot exceed 30 characters.");
                LoginInAccountPasswordText.Text = LoginInAccountPasswordText.Text.Substring(0, 30);
                LoginInAccountPasswordText.SelectionStart = LoginInAccountPasswordText.Text.Length;
            }
        }

        private void LoginAccInstitutionalEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(LoginAccInstitutionalEmail.Text, @"^\d*$"))
            {
                MessageBox.Show("Wrong Input! Only Numeric. Try again");
                LoginAccInstitutionalEmail.Text = Regex.Replace(LoginAccInstitutionalEmail.Text, @"\D", "");
                LoginAccInstitutionalEmail.SelectionStart = LoginAccInstitutionalEmail.Text.Length;
            }

            if (LoginAccInstitutionalEmail.Text.Length > 9)
            {
                MessageBox.Show("ID Number cannot exceed 9 digits.");
                LoginAccInstitutionalEmail.Text = LoginAccInstitutionalEmail.Text.Substring(0, 9);
                LoginAccInstitutionalEmail.SelectionStart = LoginAccInstitutionalEmail.Text.Length;
            }
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DirectToAdminBttn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLoginForm = new AdminLogin();
            adminLoginForm.Show();
            this.Hide();
        }

        private void ForgotPasswordReset_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
            this.Hide(); // Hide the current login form
        }
    }
}
