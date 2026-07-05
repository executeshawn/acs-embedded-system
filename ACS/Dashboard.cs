using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acs
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;

            ShowForm(new Dashboard1());
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowForm(Form form)
        {
            
            foreach (Form openForm in this.MdiChildren)
            {
                openForm.Close();
            }

            
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FacultyBttn_Click(object sender, EventArgs e)
        {
            
            ShowForm(new InstructorInfo());
        }

        private void DashboardAttendanceBttn_Click(object sender, EventArgs e)
        {
            
            ShowForm(new Attendance());
        }

        private void DashboardBttn_Click(object sender, EventArgs e)
        {
            
            ShowForm(new Dashboard1());
        }

        private void DashboardSignOutBttn_Click(object sender, EventArgs e)
        {
            
            LoginAccount loginForm = new LoginAccount();
            loginForm.Show();

            
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void greet_user_Click(object sender, EventArgs e)
        {

        }
    }
}
