using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace MyLobbyAD
{
    public partial class LoginAD : Form
    {
        public LoginAD()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string urlAD = @"ldap://mylobby.local";
            string usernameAD = "maxim.promskyi@mylobby.local";
            string passwordAD = "CodeCarePro1@";
            using (DirectoryEntry directoryEntry = new DirectoryEntry(
                urlAD, usernameAD, passwordAD) { 

            }
            if (url.Text == "a" && username.Text == "s" && password.Text == "d") {
                ActiveDirectoryForm activeDirectory = new ActiveDirectoryForm();
                activeDirectory.Show();
                this.Hide();
            }
        }
    }
}
