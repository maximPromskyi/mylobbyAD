using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using MyLobbyAD.Models;
using MyLobbyAD.Services;
using MaterialSkin.Controls;
using MaterialSkin;

namespace MyLobbyAD
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            StorageService.CreateStorage();
            TryLogin();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            StartLoader();
            LoginInfoModel<LoginSuccess, LoginError> loginInfo = await ApiService.Login(email.Text, password.Text);
            if (loginInfo.Success != null)
            {
                StorageService.SetUserInfo(loginInfo.Success);
                StorageService.SaveData();
                await ConnectAD();
            }
            else
            {
                DisplayError(loginInfo?.Error?.Message);
                StopLoader();
            }
        }
        private async void TryLogin()
        {
            if (StorageService.ExistData() && await ApiService.GetUser())
            {
                StartLoader();
                await ConnectAD();
                StopLoader();
            }
        }
        private async Task ConnectAD()
        {
            bool isConnect = await ActiveDirectory.Connect();
            if (isConnect)
            {
                DisplayOtherForm(new ActiveDirectoryForm());
            }
            else
            {
                DisplayOtherForm(new LoginADForm());
            }
        }
        private void DisplayOtherForm(Form otherForm)
        {
            otherForm.Show();
            this.Hide();
        }
        private void DisplayError(string messageErr)
        {
            if (messageErr == null)
            {
                messageErr = "Incorrect data";
            }
            warning.Visible = true;
            warning.Text = messageErr;
        }
        private void StartLoader()
        {
            LoginButton.Text = "";
            loader.Visible = true;
        }
        private void StopLoader()
        {
            LoginButton.Text = "Sign in";
            loader.Visible = false;
        }
    }
}
