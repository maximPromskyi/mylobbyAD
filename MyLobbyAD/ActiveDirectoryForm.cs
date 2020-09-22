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

namespace MyLobbyAD
{
    public partial class ActiveDirectoryForm : Form
    {

        public ActiveDirectoryForm(PrincipalSearcher searcher)
        {
            InitializeComponent();
            InitializeComponentAD(searcher);
            List<User> users = GetUsers(searcher);
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!");
        }
        private List<User> GetUsers(PrincipalSearcher searcher)
        {
            List<User> users = new List<User>();
            List<UserPrincipal> usersData = searcher
                .FindAll()
                .Select(user => (UserPrincipal)user)
                .ToList();

            foreach (var user in usersData)
            {
                DirectoryEntry dirEntry = (DirectoryEntry)user.GetUnderlyingObject();
                string firstName = dirEntry?.Properties["GivenName"]?.Value?.ToString();

                if (NameExist(firstName))
                {
                    users.Add(CreateUser(dirEntry));
                }                
            }

            return users;
        }
        private bool NameExist(string name)
        {
            return name != null;
        }
        private string GetFullName(string firstName, string lastName)
        {
            return lastName == null ? firstName : $"{firstName} {lastName}";
        }
        private User CreateUser(DirectoryEntry dirEntry)
        {
            return new User()
            {
                Name = GetFullName(dirEntry?.Properties["GivenName"]?.Value?.ToString(), dirEntry.Properties["sn"]?.Value?.ToString()),
                Company = dirEntry.Properties["company"]?.Value?.ToString(),
                JobTitle = dirEntry.Properties["title"]?.Value?.ToString(),
                Email = dirEntry.Properties["mail"]?.Value?.ToString(),
                PhoneSms = dirEntry.Properties["telephoneNumber"]?.Value?.ToString(),
                PhoneVoice = dirEntry.Properties["telephoneNumber"]?.Value?.ToString()
            };
        }
        private void InitializeComponentAD(PrincipalSearcher searcher)
        {
            string domainInfo = searcher?.Context?.Name;
            domain.Text = searcher?.Context?.Name == null ? "unknown" : searcher.Context.Name;
        }
    }
}
