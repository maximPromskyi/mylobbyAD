using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using MyLobbyAD.Models;
using System.Linq;
using MyLobbyAD.Services;
using MaterialSkin.Controls;

namespace MyLobbyAD
{
    public partial class ActiveDirectoryForm : MaterialForm
    {
        public ActiveDirectoryForm(LoginSuccess loginSuccess = null)
        {
            InitializeComponent();
            username.Text = AccounService.Email == null ? "unknown" : AccounService.Email;
            domainName.Text = ActiveDirectory.GetDomain();
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            await ApiService.UploadUsers();
            /*if (LoginButton.Text == "start")
            {
                
                if (ShedulerService.Enabled)
                {
                    ShedulerService.Start();
                    LoginButton.Text = "stop";
                    LoginButton.UseAccentColor = true;
                    LoginButton.Type = MaterialButton.MaterialButtonType.Outlined;
                }
            }
            else
            {
                LoginButton.Text = "start";
                LoginButton.UseAccentColor = false;
                LoginButton.Type = MaterialButton.MaterialButtonType.Contained;
            }*/
        }
    }
}
