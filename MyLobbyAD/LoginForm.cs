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

namespace MyLobbyAD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // 'displayName', 'mail', 'title', 'telephoneNumber', 'company'
            if (login.Text == "a" && password.Text == "s") {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(new PrincipalContext(ContextType.Domain, Environment.UserDomainName))))
                {
                    List<UserPrincipal> users = searcher.FindAll().Select(u => (UserPrincipal)u).ToList();
                    foreach (var u in users)
                    {
                        DirectoryEntry d = (DirectoryEntry)u.GetUnderlyingObject();
                        Console.WriteLine(d.Properties["GivenName"]?.Value?.ToString() + d.Properties["sn"]?.Value?.ToString());
                    }
                }
                LoginAD loginAD = new LoginAD();
                loginAD.Show();
                this.Hide();
            }
        }
    }
}
