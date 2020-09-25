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
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Text = "";
            loader.Visible = true;
            LoginInfoModel<LoginSuccess, LoginError> loginInfo = await ApiService.Login(email.Text, password.Text);
            if (loginInfo.Success != null)
            {
                AccounService.CreateAccounService(loginInfo.Success);
                bool isConnect = await ActiveDirectory.Connect();
                if (isConnect)
                {
                    DisplayOtherForm(new ActiveDirectoryForm(loginInfo.Success));
                }
                else
                {
                    DisplayOtherForm(new LoginADForm());
                }
            }
            else
            {
                DisplayError(loginInfo?.Error?.Message);
                LoginButton.Text = "Sign in";
                loader.Visible = false;
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
    }
}
