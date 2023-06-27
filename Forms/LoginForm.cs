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
            // Creating Database and User Table

            if(MainClass.IsValidUser(username_txtbox.Text, password_txtbox.Text) == false)
            {

                guna2MessageDialog1.Show("Invalid Username or Password");
                return;
            
            }
            else
            {
                this.Hide();
                MainForm mform = new MainForm();
                mform.Show();
            }

            // Inserting Users 
        }
    }
}
