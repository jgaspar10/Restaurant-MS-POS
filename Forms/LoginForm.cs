using Restaurant_MS_POS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_POS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_txtbox.Text;
            string password = password_txtbox.Text;

            if (MainClass.IsValidUser(username, password))
            {
                // User is valid, perform the necessary actions
                this.Hide();
                MainForm mform = new MainForm();
                mform.Show();
            }
            else
            {
                // Invalid user, display an error message
                guna2MessageDialog1.Show("Invalid Username or Password");
            }
        }
    }
}
