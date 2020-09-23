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

namespace MyLobbyAD
{
    public partial class ActiveDirectoryForm : Form
    {
        public ActiveDirectoryForm(LoginSuccess loginSuccess)
        {
            InitializeComponent();
        }

        private async void Upload_Click(object sender, EventArgs e)
        {
            List<User> users = ActiveDirectory.GetUsers();
            string[] usersId = users.Select(u => u.Id.ToString()).ToArray();
            LoginInfoModel<EmployeeInfo[], LoginError> employeesInfo = await ApiService.CheckEmployeeById(usersId);
            string usersData = "";
            string usersUpdateData = "";
            string usersError = "";
            foreach (User user in users)
            {
                EmployeeInfo employeeInfo = employeesInfo.Success
                    .Where(e => e.ActiveDirectoryId == user.Id.ToString())
                    .FirstOrDefault();
                if (employeeInfo.EmployeeId != null)
                {
                    user.EmployeeId = employeeInfo.EmployeeId;
                    if (await ApiService.EmployeUpdate(user))
                    {
                        usersUpdateData += $"{user.Name}\n";
                    }
                    else
                    {
                        usersError += $"{user.Name}\n";
                    }
                }
                else
                {
                    if (await ApiService.EmployeeAdd(user))
                    {
                        usersData += $"{user.Name}\n";
                    }
                    else
                    {
                        usersError += $"{user.Name}\n";
                    }
                }
                
            }
            MessageBox.Show(usersUpdateData, "updated");
            MessageBox.Show(usersData, "created");
            MessageBox.Show(usersError, "error");

        }
    }
}
