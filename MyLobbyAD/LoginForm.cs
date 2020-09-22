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

namespace MyLobbyAD
{
    public partial class LoginForm : Form
    {
        private PrincipalSearcher Searcher { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        { 
            LoginInfoModel<LoginSuccess, LoginError> loginInfo = await ApiService.Login(email.Text, password.Text);
            if (loginInfo.Success != null)
            {
                ConnectAD();

                if (Searcher != null)
                {
                    ActiveDirectoryForm activeDirectory = new ActiveDirectoryForm(Searcher);
                    activeDirectory.Show();
                    this.Hide();
                }
                else
                {
                    LoginAD loginAD = new LoginAD();
                    loginAD.Show();
                    this.Hide();
                }
            }
            else
            {
                string messageErr = "Incorrect data";
                if (loginInfo?.Error?.Message != null)
                {
                    messageErr = loginInfo?.Error?.Message;
                }
                DisplayError(messageErr);
            }
        }
        private void DisplayError(string messageErr)
        {
            warning.Visible = true;
            warning.Text = messageErr;
        }
        private void ConnectAD()
        {
            try
            {
                Searcher = new PrincipalSearcher(
                    new UserPrincipal(
                        new PrincipalContext(ContextType.Domain, Environment.UserDomainName)));
            }
            catch
            {
                Searcher = null;
            }
        }
    }
}
