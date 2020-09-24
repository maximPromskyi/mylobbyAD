using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLobbyAD
{
    public partial class SettingForm : MaterialForm
    {
        private readonly Form mainForm;
        public SettingForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SchedulerButton_Click(object sender, EventArgs e)
        {
            SchedulerForm schedulerForm = new SchedulerForm();
            schedulerForm.Show();
            this.Close();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            mainForm.Close();
            this.Close();
        }
        private void SwitchADButton_Click(object sender, EventArgs e)
        {
            LoginADForm loginADForm = new LoginADForm();
            loginADForm.Show();
            mainForm.Close();
            this.Close();
        }
    }
}
