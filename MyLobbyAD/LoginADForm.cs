using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.Linq;
using MaterialSkin.Controls;

namespace MyLobbyAD
{
    public partial class LoginADForm : MaterialForm
    {
        public LoginADForm()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            /* string urlAD = @"ldap://mymedia.local";
            string usernameAD = "maxim.promskyi@mymedia.local";
            string passwordAD = "CodeCarePro1@";*/

            if (url.Text == "a" && username.Text == "s" && password.Text == "d")
            {
                ActiveDirectoryForm activeDirectory = new ActiveDirectoryForm();
                activeDirectory.Show();
                this.Close();
            }
        }
    }
}
