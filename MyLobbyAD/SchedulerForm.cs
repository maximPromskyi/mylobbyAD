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
        public SchedulerForm()
        {
            InitializeComponent();
            string[] keys = ShedulerService.timeItems.Select(d => d.Key).ToArray();
            TimeComboBox.Items.AddRange(keys);
            TimeComboBox.SelectedIndex = 0;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string selectedState = TimeComboBox.SelectedItem.ToString();
            ShedulerService.SetTime(selectedState);
        }
    }
}
