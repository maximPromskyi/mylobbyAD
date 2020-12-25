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
using System.Threading.Tasks;
using System.Threading;

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
            dataGridView1.Columns["IsSynchron"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.RowTemplate.Height = 80;
            IsSyncCompany.Checked = StorageService.InfoData.PropertiesAD["Company"];
            IsSyncJobTitle.Checked = StorageService.InfoData.PropertiesAD["JobTitle"];
            IsSyncEmail.Checked = StorageService.InfoData.PropertiesAD["Email"];
            IsSyncPhone.Checked = StorageService.InfoData.PropertiesAD["Phone"];
            UpdateTable();
            UpdatePreviousDate();
            countInfo.Text = $"Total number of users {dataGridView1.Rows.Count}";
        }
        private void UpdateTable()
        {
            List<User> users = ActiveDirectory.GetUsers();
            StorageService.UpdateInfoSyncs(users.Select(u => u.Id).ToList());
            foreach (User user in users)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells["IsSynchron"].Value = StorageService.InfoData.InfoSyncs[user.Id];
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
            Success success = await ApiService.UploadUsers(ProgressBarUsers);
            if (success.IsSuccess)
            {
                StorageService.SetPreviousUpdate(DateTime.Now);
                UpdatePreviousDate();
                DisplaySuccess(success);
            }
            else
            {
                DisplayError();
            }
            StopLoader();
        }
       
        public void DisplaySuccess(Success success)
        {
            SuccessForm successForm = new SuccessForm($"Users uploaded!\nNew employees added: {success.CountAddEmployees}\nUpdated employees: {success.CountUpdateEmployees}");
            successForm.Show();
        }
        public void DisplayError()
        {
            ErrorForm errorForm = new ErrorForm("Upload failed! Try again.\nIf the error persists,\ntry to re-enter your account");
            errorForm.Show();
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

        private void Save_Click(object sender, EventArgs e)
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

            Dictionary<string, bool> propertiesAD = new Dictionary<string, bool>
            {
                ["Company"] = IsSyncCompany.Checked,
                ["JobTitle"] = IsSyncJobTitle.Checked,
                ["Email"] = IsSyncEmail.Checked,
                ["Phone"] = IsSyncPhone.Checked
            };

            StorageService.SetPropetiesAD(propertiesAD);
        }
    }
}
