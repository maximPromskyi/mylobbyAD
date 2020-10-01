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
        public ActiveDirectoryForm()
        {
            InitializeComponent();
            SchedulerService.SetADForm(this);
            getInfoData();
            SchedulerService.СheckLaunch();
            if (SchedulerService.Enabled)
            {
                StartTimer(SchedulerService.ConvertStrInterval());
            }
        }
        private void getInfoData()
        {
            string eml = StorageService.InfoData.Email == null ? "unknown" : StorageService.InfoData.Email;
            email.Text = eml.Length > 38 ? $"{eml.Substring(0, 38)}..." : eml;
            domainName.Text = ActiveDirectory.GetDomain();
            serverName.Text = ActiveDirectory.GetServerName();
            UpdateTable();
            UpdatePreviousDate();
        }
        private void UpdateTable()
        {
            List<User> users = ActiveDirectory.GetUsers();
            foreach (User user in users)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = user.Name;
                dataGridView1.Rows[num].Cells[1].Value = 
                    (user.Company == null || user.Company == String.Empty) ? "missing" : user.Company;
                dataGridView1.Rows[num].Cells[2].Value =
                    (user.JobTitle == null || user.JobTitle == String.Empty) ? "missing" : user.JobTitle;
                dataGridView1.Rows[num].Cells[3].Value =
                    (user.Email == null || user.Email == String.Empty) ? "missing" : user.Email;
                dataGridView1.Rows[num].Cells[4].Value =
                    (user.PhoneSms == null || user.PhoneSms == String.Empty) ? "missing" : user.PhoneSms;
            }
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
        }
        public void UpdatePreviousDate()
        { 
            previousUpdate.Text = StorageService.GetStrPreviousUpdate(); ;
        }
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            StartLoader();
            await ApiService.UploadUsers();
            StorageService.SetPreviousUpdate(DateTime.Now);
            UpdatePreviousDate();
            StopLoader();
        }
        public void StartTimer(string tInfo)
        {
            timerInfo.Visible = true;
            timerInfo.Text = tInfo;
        }
        public void StopTimer()
        {
            timerInfo.Visible = false;
        }
        public void StartLoader()
        {
            loader.Visible = true;
            LoginButton.Text = "";
        }
        public void StopLoader()
        {
            loader.Visible = false;
            LoginButton.Text = "Upload users";
        }
    }
}
