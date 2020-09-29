using MaterialSkin.Controls;
using MyLobbyAD.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyLobbyAD
{
    public partial class SchedulerForm : MaterialForm
    {
        private readonly ActiveDirectoryForm mainForm;
        public SchedulerForm(ActiveDirectoryForm mainForm)
        {
            InitializeComponent();
            SchedulerService.SetSchedulerForm(this);
            UpdatePreviousDate();
            this.mainForm = mainForm;
            string[] keys = SchedulerService.timeItems.Select(d => d.Key).ToArray();
            TimeComboBox.Items.AddRange(keys);
            TimeComboBox.SelectedIndex = 0;
            SchedulerService.СheckLaunch();
            if (SchedulerService.Enabled)
            {
                ChangeToRun();
            }
        }
        public void UpdatePreviousDate()
        {
            previousUpdate.Text = StorageService.GetStrPreviousUpdate(); ;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeToRun()
        {
            Run.Text = "Stop";
            Run.UseAccentColor = true;
            timerInfo.Text = $"Next update in: {SchedulerService.ConvertStrInterval()}";
            timerInfo.Visible = true;
            mainForm?.StartTimer(timerInfo.Text);
        }
        private void ChangeToStop()
        {
            Run.Text = "Start";
            Run.UseAccentColor = false;
            timerInfo.Visible = false;
            mainForm?.StopTimer();
        }
        private void Run_Click(object sender, EventArgs e)
        {
            if (Run.Text == "Start")
            {
                SchedulerService.Start(TimeComboBox.SelectedItem.ToString());
                ChangeToRun();
                SchedulerService.AddToStartUp(Application.ProductName, Application.ExecutablePath.Replace("dll", "exe"));
            }
            else 
            {
                SchedulerService.Stop();
                ChangeToStop();
            }
        }
    }
}
