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
using MyLobbyAD.Services;

namespace MyLobbyAD
{
    public partial class LoginADForm : MaterialForm
    {
        public LoginADForm()
        {
            InitializeComponent();
        }
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            loader.Visible = true;
            LoginButton.Text = "";
            bool isConnect = await ActiveDirectory.Connect(domainName.Text, username.Text, password.Text);

            if (isConnect)
            {
                ActiveDirectoryForm activeDirectory = new ActiveDirectoryForm();
                activeDirectory.Show();
                this.Close();
            }
            else
            {
                warning.Text = "Invalid data";
                warning.Visible = true;
                loader.Visible = false;
                LoginButton.Text = "Sign in";
            }
        }

        private void LoginADForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count <= 1)
            {
                Application.Exit();
            }
        }
    }
}
