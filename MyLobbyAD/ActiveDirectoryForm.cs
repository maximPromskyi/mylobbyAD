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
using System.IO;

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
            emailLabel.Text = eml.Length > 38 ? $"{eml.Substring(0, 38)}..." : eml;
            domainName.Text = ActiveDirectory.GetDomain();
            serverName.Text = ActiveDirectory.GetServerName();
            this.dataGridView1.Columns["IsSynchron"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.RowHeadersWidth = 4;
            UpdateTable();
            UpdatePreviousDate();
        }
        private void UpdateTable()
        {
            List<User> users = ActiveDirectory.GetUsers();
            StorageService.UpdateInfoSyncs(users.Select(u => u.Id).ToList());
            Dictionary<Guid, bool> infoSyncs = StorageService.InfoData.InfoSyncs;
            foreach (User user in users)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells["IsSynchron"].Value = infoSyncs[user.Id];
                dataGridView1.Rows[num].Cells["UserName"].Value = user.Name;
                dataGridView1.Rows[num].Cells["Company"].Value =
                    (user.Company == null || user.Company == String.Empty) ? "-" : user.Company;
                dataGridView1.Rows[num].Cells["JobTitle"].Value =
                    (user.JobTitle == null || user.JobTitle == String.Empty) ? "-" : user.JobTitle;
                dataGridView1.Rows[num].Cells["Email"].Value =
                    (user.Email == null || user.Email == String.Empty) ? "-" : user.Email;
                dataGridView1.Rows[num].Cells["PhoneSms"].Value =
                    (user.PhoneSms == null || user.PhoneSms == String.Empty) ? "-" : user.PhoneSms;
                dataGridView1.Rows[num].Cells["UserId"].Value = user.Id;
                dataGridView1.Rows[num].Cells["Photo"].Value = user.Image == null ? 
                    Properties.Resources.default_user_photo : user.Image;
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

        private void SaveChange_Click(object sender, EventArgs e)
        {
            Dictionary<Guid, bool> infoSyncs = new Dictionary<Guid, bool>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                infoSyncs.Add(
                    new Guid(dataGridView1.Rows[i].Cells["UserId"].Value.ToString()),
                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["IsSynchron"].Value)
                );
            }
            StorageService.SetInfoSyncs(infoSyncs);
        }
    }
}
