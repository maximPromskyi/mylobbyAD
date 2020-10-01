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
            string eml = StorageService.InfoData.Email == null ? "unknown" : StorageService.InfoData.Email;
            email.Text = eml.Length > 20 ? $"{eml.Substring(0, 20)}..." : eml;
            domainName.Text = ActiveDirectory.GetDomain();
            UpdatePreviousDate();
            SchedulerService.СheckLaunch();
            if (SchedulerService.Enabled)
            {
                StartTimer(SchedulerService.ConvertStrInterval());
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
