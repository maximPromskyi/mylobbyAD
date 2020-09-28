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
            this.mainForm = mainForm;
            string[] keys = SchedulerService.timeItems.Select(d => d.Key).ToArray();
            TimeComboBox.Items.AddRange(keys);
            TimeComboBox.SelectedIndex = 0;
            if (SchedulerService.Enabled)
            {
                ChangeToRun();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChangeToRun()
        {
            Run.Text = "Stop";
            Run.UseAccentColor = true;
            timerInfo.Text = $"Time to update: {SchedulerService.ConvertStrInterval()}";
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
                SchedulerService.AddToAutoStart();
            }
            else 
            {
                SchedulerService.Stop();
                ChangeToStop();
            }
        }
    }
}
